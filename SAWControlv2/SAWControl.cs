﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace SAWControlv2
{
    public partial class SAWControl : Form
    {

        public SAWControl()
        {
            InitializeComponent();
            populateCOMLinst();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if(cmboCOMList.SelectedIndex > -1)
            {
                try
                {
                    Globals.port = new SerialPort();
                    Globals.port.PortName = cmboCOMList.SelectedItem.ToString();
                    Globals.port.BaudRate = 9600;
                    Globals.port.Parity = Parity.None;
                    Globals.port.StopBits = StopBits.One;
                    Globals.port.Encoding = System.Text.Encoding.GetEncoding(28591);
                    Globals.port.ReadTimeout = 1000;
                    Globals.port.WriteTimeout = 1000;
                    Globals._continue = true;

                    if (!Globals.port.IsOpen)
                    {
                        txtConsole.Clear();
                        txtConsole.AppendText("Connecting to " + Globals.port.PortName + "... ");

                        Globals.port.Open();

                        if (initializeConnection())
                        {
                            startReading();
                            btnConnect.Hide();
                            btnDisconnect.Show();
                            lblStatus.Text = "Connected";
                            lblStatus.ForeColor = Color.Green;
                            Globals._firstRun = false;
                            txtConsole.AppendText("OK");
                            sldrPower.Enabled = true;
                        }
                        else
                        {
                            txtConsole.AppendText("\nConnection failed.");
                        }
                        
                    }
                    else
                    {
                        txtConsole.AppendText("Port is already open.\n");
                    }

                }
                catch(Exception ex)
                {
                    txtConsole.AppendText("\nConnection failed.\n" + ex);
                }
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (Globals.port.IsOpen)
            {
                Actions.setPower("0");
                Actions.disablePulse();
                Actions.disableOne();
                Actions.disableTwo();
                updateControls();
                Globals._continue = false;
                Actions.disableRemote();
                Globals.port.Close();
                Globals.port.Dispose();
                btnDisconnect.Hide();
                btnConnect.Show();
                lblStatus.Text = "Disconnected";
                lblStatus.ForeColor = Color.Red;
                txtConsole.AppendText("\nDisconnected.");
                sldrPower.Enabled = false;
            }
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            Globals._printStatus = true;
            Actions.checkStatus();
            updateControls();
        }

        private void btnDual_Click(object sender, EventArgs e)
        {
            Actions.toggleDual();
            updateControls();
        }

        private void btnPulsed_Click(object sender, EventArgs e)
        {
            Actions.togglePulsed();
            updateControls();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            populateCOMLinst();
        }

        /*
         * 
         * Non-click related methods
         * 
        */
        private void populateCOMLinst()
        {
            cmboCOMList.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                cmboCOMList.Items.Add(port);
            }
        }

        private async void startReading()
        {
            var progress = new Progress<string>( s => processResponse(s) );
            await Task.Factory.StartNew(() => SerialReader.Read(progress),
                                        TaskCreationOptions.LongRunning);
        }

        private void processResponse(string response)
        {
            if (response == null)
            {
                btnDisconnect_Click(this, null);
            }
            else if (response.StartsWith("OK REM") && Globals._firstRun)
            {
                Actions.processStatusMessage(response);
            }
            else if (response.StartsWith("OK") && Globals._firstRun)
            {
                //txtConsole.AppendText(response + "\n");
            }
            else if (response.Equals("OK"))
            {
                //txtConsole.AppendText(response + "\n");
            }
            else if (response.StartsWith("OK REM") && !Globals._firstRun)
            {
                if (Globals._printStatus)
                {
                    string[] status = response.Split(' ');
                    foreach (string s in status)
                    {
                        txtConsole.AppendText("\n" + s);
                    }
                    Globals._printStatus = false;
                }
            }
            
        }

        private bool initializeConnection()
        {
            try
            {
                Actions.enableRemote();
                string response = Globals.port.ReadTo("\r");
            }
            catch (Exception ex)
            {
                Globals.port.Close();
                Globals.port.Dispose();
                return false;
            }
            
            Actions.enableOne();
            Actions.disableTwo();
            Actions.disablePulse();
            Actions.setPower("0");
            updateControls();
            return true;
        }

        private void updateControls()
        {
            if (Globals.PUL)
            {
                lblPulseMode.Text = "ON";
                lblPulseMode.ForeColor = Color.Green;
            }
            else
            {
                lblPulseMode.Text = "OFF";
                lblPulseMode.ForeColor = Color.Red;
            }

            if (Globals.EN1 && Globals.EN2)
            {
                lblDualMode.Text = "ON";
                lblDualMode.ForeColor = Color.Green;
            }
            else
            {
                lblDualMode.Text = "OFF";
                lblDualMode.ForeColor = Color.Red;
            }

            if (Globals.FL1 || Globals.FL2)
            {
                ledFault.BackgroundImage = SAWControlv2.Properties.Resources.icon_red_dot;
            }
            else
            {
                ledFault.BackgroundImage = SAWControlv2.Properties.Resources.icon_green_dot;
            }

            if (Globals.OT1 || Globals.OT2)
            {
                ledOverTemp.BackgroundImage = SAWControlv2.Properties.Resources.icon_red_dot;
            }
            else
            {
                ledOverTemp.BackgroundImage = SAWControlv2.Properties.Resources.icon_green_dot;
            }

            txtPower.Text = Globals.PWR.ToString();
            sldrPower.Value = Globals.PWR;
        }

        private void consoleText_TextChanged(object sender, EventArgs e)
        {
            txtConsole.SelectionStart = txtConsole.TextLength;
            txtConsole.ScrollToCaret();
        }

        private void txtPower_TextChanged(object sender, EventArgs e)
        {
            // nothing to do here... we dont support manual power entry yet.
        }

        private void sldrPower_Scroll(object sender, EventArgs e)
        {
            txtPower.Text = sldrPower.Value.ToString();
            Actions.setPower(txtPower.Text);
        }

        

    }
}
