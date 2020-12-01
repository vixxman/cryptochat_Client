namespace CryptoP3_6
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.msgList = new System.Windows.Forms.ListBox();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.settingsB = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // msgList
            // 
            this.msgList.FormattingEnabled = true;
            this.msgList.Location = new System.Drawing.Point(12, 12);
            this.msgList.Name = "msgList";
            this.msgList.Size = new System.Drawing.Size(435, 264);
            this.msgList.TabIndex = 0;
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(13, 281);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(300, 63);
            this.textBoxMessage.TabIndex = 1;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(319, 282);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(95, 23);
            this.sendButton.TabIndex = 2;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // settingsB
            // 
            this.settingsB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("settingsB.BackgroundImage")));
            this.settingsB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settingsB.Location = new System.Drawing.Point(421, 282);
            this.settingsB.Name = "settingsB";
            this.settingsB.Size = new System.Drawing.Size(26, 23);
            this.settingsB.TabIndex = 3;
            this.settingsB.UseVisualStyleBackColor = true;
            this.settingsB.Click += new System.EventHandler(this.settingsB_Click);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(319, 321);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(95, 23);
            this.StartButton.TabIndex = 4;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 356);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.settingsB);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.msgList);
            this.MaximumSize = new System.Drawing.Size(475, 395);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox msgList;
        private System.Windows.Forms.TextBox textBoxMessage;
        public System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button settingsB;
        public System.Windows.Forms.Button StartButton;
    }
}

