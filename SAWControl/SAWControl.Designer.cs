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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSetPower = new System.Windows.Forms.Button();
            this.txtSetPower = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.sldrPower)).BeginInit();
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
            this.btnStatus.Enabled = false;
            this.btnStatus.Location = new System.Drawing.Point(173, 126);
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
            this.btnDual.Enabled = false;
            this.btnDual.Location = new System.Drawing.Point(173, 156);
            this.btnDual.Name = "btnDual";
            this.btnDual.Size = new System.Drawing.Size(81, 23);
            this.btnDual.TabIndex = 6;
            this.btnDual.Text = "Dual Mode";
            this.btnDual.UseVisualStyleBackColor = true;
            this.btnDual.Click += new System.EventHandler(this.btnDual_Click);
            // 
            // btnPulsed
            // 
            this.btnPulsed.Enabled = false;
            this.btnPulsed.Location = new System.Drawing.Point(173, 185);
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
            this.lblDualMode.Location = new System.Drawing.Point(260, 161);
            this.lblDualMode.Name = "lblDualMode";
            this.lblDualMode.Size = new System.Drawing.Size(27, 13);
            this.lblDualMode.TabIndex = 8;
            this.lblDualMode.Text = "OFF";
            // 
            // lblPulseMode
            // 
            this.lblPulseMode.AutoSize = true;
            this.lblPulseMode.Location = new System.Drawing.Point(260, 190);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(173, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnSetPower
            // 
            this.btnSetPower.Enabled = false;
            this.btnSetPower.Location = new System.Drawing.Point(222, 214);
            this.btnSetPower.Name = "btnSetPower";
            this.btnSetPower.Size = new System.Drawing.Size(32, 20);
            this.btnSetPower.TabIndex = 14;
            this.btnSetPower.Text = "Set";
            this.btnSetPower.UseVisualStyleBackColor = true;
            this.btnSetPower.Click += new System.EventHandler(this.btnSetPower_Click);
            // 
            // txtSetPower
            // 
            this.txtSetPower.AcceptsReturn = true;
            this.txtSetPower.Enabled = false;
            this.txtSetPower.Location = new System.Drawing.Point(173, 214);
            this.txtSetPower.MaxLength = 3;
            this.txtSetPower.Name = "txtSetPower";
            this.txtSetPower.Size = new System.Drawing.Size(43, 20);
            this.txtSetPower.TabIndex = 15;
            this.txtSetPower.TextChanged += new System.EventHandler(this.txtSetPower_TextChanged);
            // 
            // SAWControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 250);
            this.Controls.Add(this.txtSetPower);
            this.Controls.Add(this.btnSetPower);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSetPower;
        private System.Windows.Forms.TextBox txtSetPower;
    }
}

