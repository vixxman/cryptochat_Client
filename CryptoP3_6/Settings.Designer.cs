namespace CryptoP3_6
{
    partial class SettingsForm
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
            this.Client1 = new System.Windows.Forms.GroupBox();
            this.PortLabel = new System.Windows.Forms.Label();
            this.IpLabel = new System.Windows.Forms.Label();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.textBoxIp = new System.Windows.Forms.TextBox();
            this.Client2 = new System.Windows.Forms.GroupBox();
            this.Portlabel2 = new System.Windows.Forms.Label();
            this.Iplabel2 = new System.Windows.Forms.Label();
            this.textBoxPort2 = new System.Windows.Forms.TextBox();
            this.textBoxIp2 = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTB1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTB2 = new System.Windows.Forms.TextBox();
            this.trentGB = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.portTrentTB = new System.Windows.Forms.TextBox();
            this.ipTrentTB = new System.Windows.Forms.TextBox();
            this.Client1.SuspendLayout();
            this.Client2.SuspendLayout();
            this.trentGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // Client1
            // 
            this.Client1.Controls.Add(this.label1);
            this.Client1.Controls.Add(this.nameTB1);
            this.Client1.Controls.Add(this.PortLabel);
            this.Client1.Controls.Add(this.IpLabel);
            this.Client1.Controls.Add(this.textBoxPort);
            this.Client1.Controls.Add(this.textBoxIp);
            this.Client1.Location = new System.Drawing.Point(13, 13);
            this.Client1.Name = "Client1";
            this.Client1.Size = new System.Drawing.Size(193, 141);
            this.Client1.TabIndex = 0;
            this.Client1.TabStop = false;
            this.Client1.Text = "You client";
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Location = new System.Drawing.Point(26, 107);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(26, 13);
            this.PortLabel.TabIndex = 3;
            this.PortLabel.Text = "Port";
            // 
            // IpLabel
            // 
            this.IpLabel.AutoSize = true;
            this.IpLabel.Location = new System.Drawing.Point(26, 67);
            this.IpLabel.Name = "IpLabel";
            this.IpLabel.Size = new System.Drawing.Size(17, 13);
            this.IpLabel.TabIndex = 2;
            this.IpLabel.Text = "IP";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(67, 104);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(120, 20);
            this.textBoxPort.TabIndex = 1;
            // 
            // textBoxIp
            // 
            this.textBoxIp.Location = new System.Drawing.Point(67, 64);
            this.textBoxIp.Name = "textBoxIp";
            this.textBoxIp.Size = new System.Drawing.Size(120, 20);
            this.textBoxIp.TabIndex = 0;
            // 
            // Client2
            // 
            this.Client2.Controls.Add(this.label2);
            this.Client2.Controls.Add(this.nameTB2);
            this.Client2.Controls.Add(this.Portlabel2);
            this.Client2.Controls.Add(this.Iplabel2);
            this.Client2.Controls.Add(this.textBoxPort2);
            this.Client2.Controls.Add(this.textBoxIp2);
            this.Client2.Location = new System.Drawing.Point(212, 13);
            this.Client2.Name = "Client2";
            this.Client2.Size = new System.Drawing.Size(183, 141);
            this.Client2.TabIndex = 1;
            this.Client2.TabStop = false;
            this.Client2.Text = "Friend Client";
            // 
            // Portlabel2
            // 
            this.Portlabel2.AutoSize = true;
            this.Portlabel2.Location = new System.Drawing.Point(16, 106);
            this.Portlabel2.Name = "Portlabel2";
            this.Portlabel2.Size = new System.Drawing.Size(26, 13);
            this.Portlabel2.TabIndex = 7;
            this.Portlabel2.Text = "Port";
            // 
            // Iplabel2
            // 
            this.Iplabel2.AutoSize = true;
            this.Iplabel2.Location = new System.Drawing.Point(16, 67);
            this.Iplabel2.Name = "Iplabel2";
            this.Iplabel2.Size = new System.Drawing.Size(17, 13);
            this.Iplabel2.TabIndex = 6;
            this.Iplabel2.Text = "IP";
            // 
            // textBoxPort2
            // 
            this.textBoxPort2.Location = new System.Drawing.Point(57, 103);
            this.textBoxPort2.Name = "textBoxPort2";
            this.textBoxPort2.Size = new System.Drawing.Size(120, 20);
            this.textBoxPort2.TabIndex = 5;
            // 
            // textBoxIp2
            // 
            this.textBoxIp2.Location = new System.Drawing.Point(57, 64);
            this.textBoxIp2.Name = "textBoxIp2";
            this.textBoxIp2.Size = new System.Drawing.Size(120, 20);
            this.textBoxIp2.TabIndex = 4;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(269, 160);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // nameTB1
            // 
            this.nameTB1.Location = new System.Drawing.Point(67, 28);
            this.nameTB1.Name = "nameTB1";
            this.nameTB1.Size = new System.Drawing.Size(120, 20);
            this.nameTB1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Name";
            // 
            // nameTB2
            // 
            this.nameTB2.Location = new System.Drawing.Point(57, 28);
            this.nameTB2.Name = "nameTB2";
            this.nameTB2.Size = new System.Drawing.Size(120, 20);
            this.nameTB2.TabIndex = 8;
            // 
            // trentGB
            // 
            this.trentGB.Controls.Add(this.label4);
            this.trentGB.Controls.Add(this.label5);
            this.trentGB.Controls.Add(this.portTrentTB);
            this.trentGB.Controls.Add(this.ipTrentTB);
            this.trentGB.Location = new System.Drawing.Point(401, 13);
            this.trentGB.Name = "trentGB";
            this.trentGB.Size = new System.Drawing.Size(183, 141);
            this.trentGB.TabIndex = 3;
            this.trentGB.TabStop = false;
            this.trentGB.Text = "Trent";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Port";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "IP";
            // 
            // portTrentTB
            // 
            this.portTrentTB.Location = new System.Drawing.Point(57, 100);
            this.portTrentTB.Name = "portTrentTB";
            this.portTrentTB.Size = new System.Drawing.Size(120, 20);
            this.portTrentTB.TabIndex = 5;
            // 
            // ipTrentTB
            // 
            this.ipTrentTB.Location = new System.Drawing.Point(57, 64);
            this.ipTrentTB.Name = "ipTrentTB";
            this.ipTrentTB.Size = new System.Drawing.Size(120, 20);
            this.ipTrentTB.TabIndex = 4;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 195);
            this.Controls.Add(this.trentGB);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.Client2);
            this.Controls.Add(this.Client1);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.Client1.ResumeLayout(false);
            this.Client1.PerformLayout();
            this.Client2.ResumeLayout(false);
            this.Client2.PerformLayout();
            this.trentGB.ResumeLayout(false);
            this.trentGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Client1;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.Label IpLabel;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.TextBox textBoxIp;
        private System.Windows.Forms.GroupBox Client2;
        private System.Windows.Forms.Label Portlabel2;
        private System.Windows.Forms.Label Iplabel2;
        private System.Windows.Forms.TextBox textBoxPort2;
        private System.Windows.Forms.TextBox textBoxIp2;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTB1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTB2;
        private System.Windows.Forms.GroupBox trentGB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox portTrentTB;
        private System.Windows.Forms.TextBox ipTrentTB;
    }
}