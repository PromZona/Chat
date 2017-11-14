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
            this.IP_TB = new System.Windows.Forms.TextBox();
            this.lable = new System.Windows.Forms.Label();
            this.Port_TB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Connect_Button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ConnectionStatus_label = new System.Windows.Forms.Label();
            this.DisConnect_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Chat_TB
            // 
            this.Chat_TB.Enabled = false;
            this.Chat_TB.Location = new System.Drawing.Point(278, 46);
            this.Chat_TB.Multiline = true;
            this.Chat_TB.Name = "Chat_TB";
            this.Chat_TB.Size = new System.Drawing.Size(522, 228);
            this.Chat_TB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(524, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "CHAT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter your nickname";
            // 
            // NickName_TB
            // 
            this.NickName_TB.Location = new System.Drawing.Point(12, 282);
            this.NickName_TB.Name = "NickName_TB";
            this.NickName_TB.Size = new System.Drawing.Size(152, 20);
            this.NickName_TB.TabIndex = 3;
            // 
            // Send_Button
            // 
            this.Send_Button.Location = new System.Drawing.Point(725, 280);
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
            this.Message_TB.Location = new System.Drawing.Point(276, 283);
            this.Message_TB.Name = "Message_TB";
            this.Message_TB.Size = new System.Drawing.Size(443, 20);
            this.Message_TB.TabIndex = 5;
            // 
            // IP_TB
            // 
            this.IP_TB.Location = new System.Drawing.Point(12, 46);
            this.IP_TB.Name = "IP_TB";
            this.IP_TB.Size = new System.Drawing.Size(124, 20);
            this.IP_TB.TabIndex = 6;
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Location = new System.Drawing.Point(32, 30);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(62, 13);
            this.lable.TabIndex = 7;
            this.lable.Text = "Введите IP";
            // 
            // Port_TB
            // 
            this.Port_TB.Location = new System.Drawing.Point(154, 46);
            this.Port_TB.Name = "Port_TB";
            this.Port_TB.Size = new System.Drawing.Size(79, 20);
            this.Port_TB.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Порт";
            // 
            // Connect_Button
            // 
            this.Connect_Button.Location = new System.Drawing.Point(62, 88);
            this.Connect_Button.Name = "Connect_Button";
            this.Connect_Button.Size = new System.Drawing.Size(75, 23);
            this.Connect_Button.TabIndex = 10;
            this.Connect_Button.Text = "Connect";
            this.Connect_Button.UseVisualStyleBackColor = true;
            this.Connect_Button.Click += new System.EventHandler(this.Connect_Button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Состояние подключния - ";
            // 
            // ConnectionStatus_label
            // 
            this.ConnectionStatus_label.AutoSize = true;
            this.ConnectionStatus_label.Location = new System.Drawing.Point(130, 162);
            this.ConnectionStatus_label.Name = "ConnectionStatus_label";
            this.ConnectionStatus_label.Size = new System.Drawing.Size(79, 13);
            this.ConnectionStatus_label.TabIndex = 12;
            this.ConnectionStatus_label.Text = "Не подключен";
            // 
            // DisConnect_button
            // 
            this.DisConnect_button.Location = new System.Drawing.Point(158, 88);
            this.DisConnect_button.Name = "DisConnect_button";
            this.DisConnect_button.Size = new System.Drawing.Size(75, 23);
            this.DisConnect_button.TabIndex = 13;
            this.DisConnect_button.Text = "Disconnet";
            this.DisConnect_button.UseVisualStyleBackColor = true;
            this.DisConnect_button.Click += new System.EventHandler(this.DisConnect_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 315);
            this.Controls.Add(this.DisConnect_button);
            this.Controls.Add(this.ConnectionStatus_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Connect_Button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Port_TB);
            this.Controls.Add(this.lable);
            this.Controls.Add(this.IP_TB);
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
        private System.Windows.Forms.TextBox IP_TB;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.TextBox Port_TB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Connect_Button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ConnectionStatus_label;
        private System.Windows.Forms.Button DisConnect_button;
    }
}

