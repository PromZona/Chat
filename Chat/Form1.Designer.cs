namespace Chat
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
            this.Chat_TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NickName_TB = new System.Windows.Forms.TextBox();
            this.Send_Button = new System.Windows.Forms.Button();
            this.Message_TB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Chat_TB
            // 
            this.Chat_TB.Enabled = false;
            this.Chat_TB.Location = new System.Drawing.Point(147, 46);
            this.Chat_TB.Multiline = true;
            this.Chat_TB.Name = "Chat_TB";
            this.Chat_TB.Size = new System.Drawing.Size(522, 183);
            this.Chat_TB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(331, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "CHAT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter your nickname";
            // 
            // NickName_TB
            // 
            this.NickName_TB.Location = new System.Drawing.Point(15, 96);
            this.NickName_TB.Name = "NickName_TB";
            this.NickName_TB.Size = new System.Drawing.Size(100, 20);
            this.NickName_TB.TabIndex = 3;
            // 
            // Send_Button
            // 
            this.Send_Button.Location = new System.Drawing.Point(594, 235);
            this.Send_Button.Name = "Send_Button";
            this.Send_Button.Size = new System.Drawing.Size(75, 23);
            this.Send_Button.TabIndex = 4;
            this.Send_Button.Text = "Send";
            this.Send_Button.UseVisualStyleBackColor = true;
            this.Send_Button.Click += new System.EventHandler(this.Send_Button_Click);
            this.Send_Button.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Send_Button_KeyUp);
            // 
            // Message_TB
            // 
            this.Message_TB.Location = new System.Drawing.Point(147, 238);
            this.Message_TB.Name = "Message_TB";
            this.Message_TB.Size = new System.Drawing.Size(443, 20);
            this.Message_TB.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 270);
            this.Controls.Add(this.Message_TB);
            this.Controls.Add(this.Send_Button);
            this.Controls.Add(this.NickName_TB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Chat_TB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Chat_TB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NickName_TB;
        private System.Windows.Forms.Button Send_Button;
        private System.Windows.Forms.TextBox Message_TB;
    }
}

