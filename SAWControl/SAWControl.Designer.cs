namespace SAWControl
{
    partial class SAWControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SAWControl));
            this.cmboCOMList = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtConsole = new System.Windows.Forms.RichTextBox();
            this.btnStatus = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnDual = new System.Windows.Forms.Button();
            this.btnPulsed = new System.Windows.Forms.Button();
            this.lblDualMode = new System.Windows.Forms.Label();
            this.lblPulseMode = new System.Windows.Forms.Label();
            this.txtPower = new System.Windows.Forms.TextBox();
            this.sldrPower = new System.Windows.Forms.TrackBar();
            this.lblFault = new System.Windows.Forms.Label();
            this.lblOverTemp = new System.Windows.Forms.Label();
            this.ledOverTemp = new System.Windows.Forms.PictureBox();
            this.ledFault = new System.Windows.Forms.PictureBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sldrPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledOverTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledFault)).BeginInit();
            this.SuspendLayout();
            // 
            // cmboCOMList
            // 
            this.cmboCOMList.FormattingEnabled = true;
            this.cmboCOMList.Location = new System.Drawing.Point(173, 41);
            this.cmboCOMList.Name = "cmboCOMList";
            this.cmboCOMList.Size = new System.Drawing.Size(55, 21);
            this.cmboCOMList.TabIndex = 0;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(173, 12);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(81, 23);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtConsole
            // 
            this.txtConsole.Location = new System.Drawing.Point(12, 12);
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.Size = new System.Drawing.Size(146, 225);
            this.txtConsole.TabIndex = 2;
            this.txtConsole.Text = "";
            this.txtConsole.TextChanged += new System.EventHandler(this.consoleText_TextChanged);
            // 
            // btnStatus
            // 
            this.btnStatus.Location = new System.Drawing.Point(173, 155);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(81, 24);
            this.btnStatus.TabIndex = 3;
            this.btnStatus.Text = "Check Status";
            this.btnStatus.UseVisualStyleBackColor = true;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(173, 12);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(81, 23);
            this.btnDisconnect.TabIndex = 4;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Visible = false;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(290, 12);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(73, 13);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Disconnected";
            // 
            // btnDual
            // 
            this.btnDual.Location = new System.Drawing.Point(173, 185);
            this.btnDual.Name = "btnDual";
            this.btnDual.Size = new System.Drawing.Size(81, 23);
            this.btnDual.TabIndex = 6;
            this.btnDual.Text = "Dual Mode";
            this.btnDual.UseVisualStyleBackColor = true;
            this.btnDual.Click += new System.EventHandler(this.btnDual_Click);
            // 
            // btnPulsed
            // 
            this.btnPulsed.Location = new System.Drawing.Point(173, 214);
            this.btnPulsed.Name = "btnPulsed";
            this.btnPulsed.Size = new System.Drawing.Size(81, 23);
            this.btnPulsed.TabIndex = 7;
            this.btnPulsed.Text = "Pulse Mode";
            this.btnPulsed.UseVisualStyleBackColor = true;
            this.btnPulsed.Click += new System.EventHandler(this.btnPulsed_Click);
            // 
            // lblDualMode
            // 
            this.lblDualMode.AutoSize = true;
            this.lblDualMode.Location = new System.Drawing.Point(260, 190);
            this.lblDualMode.Name = "lblDualMode";
            this.lblDualMode.Size = new System.Drawing.Size(27, 13);
            this.lblDualMode.TabIndex = 8;
            this.lblDualMode.Text = "OFF";
            // 
            // lblPulseMode
            // 
            this.lblPulseMode.AutoSize = true;
            this.lblPulseMode.Location = new System.Drawing.Point(260, 219);
            this.lblPulseMode.Name = "lblPulseMode";
            this.lblPulseMode.Size = new System.Drawing.Size(27, 13);
            this.lblPulseMode.TabIndex = 9;
            this.lblPulseMode.Text = "OFF";
            // 
            // txtPower
            // 
            this.txtPower.Enabled = false;
            this.txtPower.Location = new System.Drawing.Point(321, 214);
            this.txtPower.Name = "txtPower";
            this.txtPower.Size = new System.Drawing.Size(42, 20);
            this.txtPower.TabIndex = 10;
            this.txtPower.Text = "0";
            this.txtPower.TextChanged += new System.EventHandler(this.txtPower_TextChanged);
            // 
            // sldrPower
            // 
            this.sldrPower.Enabled = false;
            this.sldrPower.Location = new System.Drawing.Point(321, 29);
            this.sldrPower.Maximum = 100;
            this.sldrPower.Name = "sldrPower";
            this.sldrPower.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.sldrPower.Size = new System.Drawing.Size(45, 179);
            this.sldrPower.TabIndex = 11;
            this.sldrPower.Scroll += new System.EventHandler(this.sldrPower_Scroll);
            // 
            // lblFault
            // 
            this.lblFault.AutoSize = true;
            this.lblFault.Location = new System.Drawing.Point(193, 82);
            this.lblFault.Name = "lblFault";
            this.lblFault.Size = new System.Drawing.Size(30, 13);
            this.lblFault.TabIndex = 14;
            this.lblFault.Text = "Fault";
            // 
            // lblOverTemp
            // 
            this.lblOverTemp.AutoSize = true;
            this.lblOverTemp.Location = new System.Drawing.Point(193, 108);
            this.lblOverTemp.Name = "lblOverTemp";
            this.lblOverTemp.Size = new System.Drawing.Size(60, 13);
            this.lblOverTemp.TabIndex = 16;
            this.lblOverTemp.Text = "Over Temp";
            // 
            // ledOverTemp
            // 
            this.ledOverTemp.BackColor = System.Drawing.Color.Transparent;
            this.ledOverTemp.BackgroundImage = global::SAWControl.Properties.Resources.green;
            this.ledOverTemp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ledOverTemp.Location = new System.Drawing.Point(173, 105);
            this.ledOverTemp.Name = "ledOverTemp";
            this.ledOverTemp.Size = new System.Drawing.Size(18, 18);
            this.ledOverTemp.TabIndex = 15;
            this.ledOverTemp.TabStop = false;
            // 
            // ledFault
            // 
            this.ledFault.BackColor = System.Drawing.Color.Transparent;
            this.ledFault.BackgroundImage = global::SAWControl.Properties.Resources.green;
            this.ledFault.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ledFault.Location = new System.Drawing.Point(173, 78);
            this.ledFault.Name = "ledFault";
            this.ledFault.Size = new System.Drawing.Size(18, 18);
            this.ledFault.TabIndex = 13;
            this.ledFault.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.Location = new System.Drawing.Point(234, 39);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(20, 23);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // SAWControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 250);
            this.Controls.Add(this.lblOverTemp);
            this.Controls.Add(this.ledOverTemp);
            this.Controls.Add(this.lblFault);
            this.Controls.Add(this.ledFault);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.sldrPower);
            this.Controls.Add(this.txtPower);
            this.Controls.Add(this.lblPulseMode);
            this.Controls.Add(this.lblDualMode);
            this.Controls.Add(this.btnPulsed);
            this.Controls.Add(this.btnDual);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnStatus);
            this.Controls.Add(this.txtConsole);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.cmboCOMList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SAWControl";
            this.Text = "SAWControl";
            ((System.ComponentModel.ISupportInitialize)(this.sldrPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledOverTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledFault)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmboCOMList;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.RichTextBox txtConsole;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnDual;
        private System.Windows.Forms.Button btnPulsed;
        private System.Windows.Forms.Label lblDualMode;
        private System.Windows.Forms.Label lblPulseMode;
        private System.Windows.Forms.TextBox txtPower;
        private System.Windows.Forms.TrackBar sldrPower;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.PictureBox ledFault;
        private System.Windows.Forms.Label lblFault;
        private System.Windows.Forms.PictureBox ledOverTemp;
        private System.Windows.Forms.Label lblOverTemp;
    }
}

