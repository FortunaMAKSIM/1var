namespace _1var
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LogBt = new Button();
            LoginTb = new TextBox();
            PasswordTb = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // LogBt
            // 
            LogBt.Location = new Point(93, 213);
            LogBt.Name = "LogBt";
            LogBt.Size = new Size(108, 38);
            LogBt.TabIndex = 0;
            LogBt.Text = "Вход";
            LogBt.UseVisualStyleBackColor = true;
            LogBt.Click += LogBt_Click;
            // 
            // LoginTb
            // 
            LoginTb.Location = new Point(47, 94);
            LoginTb.Name = "LoginTb";
            LoginTb.Size = new Size(211, 23);
            LoginTb.TabIndex = 1;
            // 
            // PasswordTb
            // 
            PasswordTb.Location = new Point(47, 163);
            PasswordTb.Name = "PasswordTb";
            PasswordTb.Size = new Size(211, 23);
            PasswordTb.TabIndex = 2;
            PasswordTb.UseSystemPasswordChar = true;
            PasswordTb.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(287, 37);
            label1.TabIndex = 3;
            label1.Text = "ООО \"ТЕХНОСЕРВИС\"";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(47, 70);
            label2.Name = "label2";
            label2.Size = new Size(54, 21);
            label2.TabIndex = 4;
            label2.Text = "Логин";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(47, 139);
            label3.Name = "label3";
            label3.Size = new Size(63, 21);
            label3.TabIndex = 5;
            label3.Text = "Пароль";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 279);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PasswordTb);
            Controls.Add(LoginTb);
            Controls.Add(LogBt);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LogBt;
        private TextBox LoginTb;
        private TextBox PasswordTb;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
