namespace _1var
{
    partial class AddApplicationForm
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
            ClientTb = new TextBox();
            PriceNum = new NumericUpDown();
            SaveBt = new Button();
            PriorTb = new TextBox();
            TypeTb = new TextBox();
            DescTb = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)PriceNum).BeginInit();
            SuspendLayout();
            // 
            // ClientTb
            // 
            ClientTb.Location = new Point(12, 37);
            ClientTb.Name = "ClientTb";
            ClientTb.Size = new Size(141, 23);
            ClientTb.TabIndex = 0;
            // 
            // PriceNum
            // 
            PriceNum.Location = new Point(600, 38);
            PriceNum.Name = "PriceNum";
            PriceNum.Size = new Size(141, 23);
            PriceNum.TabIndex = 1;
            // 
            // SaveBt
            // 
            SaveBt.Font = new Font("Segoe UI", 12F);
            SaveBt.Location = new Point(306, 75);
            SaveBt.Name = "SaveBt";
            SaveBt.Size = new Size(141, 49);
            SaveBt.TabIndex = 2;
            SaveBt.Text = "Save";
            SaveBt.UseVisualStyleBackColor = true;
            SaveBt.Click += SaveBt_Click;
            // 
            // PriorTb
            // 
            PriorTb.Location = new Point(159, 37);
            PriorTb.Name = "PriorTb";
            PriorTb.Size = new Size(141, 23);
            PriorTb.TabIndex = 3;
            // 
            // TypeTb
            // 
            TypeTb.Location = new Point(306, 37);
            TypeTb.Name = "TypeTb";
            TypeTb.Size = new Size(141, 23);
            TypeTb.TabIndex = 4;
            // 
            // DescTb
            // 
            DescTb.Location = new Point(453, 37);
            DescTb.Name = "DescTb";
            DescTb.Size = new Size(141, 23);
            DescTb.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(73, 25);
            label1.TabIndex = 6;
            label1.Text = "Клиент";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(159, 9);
            label2.Name = "label2";
            label2.Size = new Size(107, 25);
            label2.TabIndex = 7;
            label2.Text = "Приоритет";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(306, 9);
            label3.Name = "label3";
            label3.Size = new Size(117, 25);
            label3.TabIndex = 8;
            label3.Text = "Тип ошибки";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(453, 12);
            label4.Name = "label4";
            label4.Size = new Size(142, 21);
            label4.TabIndex = 9;
            label4.Text = "Описание ошибки";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(600, 9);
            label5.Name = "label5";
            label5.Size = new Size(57, 25);
            label5.TabIndex = 10;
            label5.Text = "Цена";
            // 
            // AddApplicationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 136);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DescTb);
            Controls.Add(TypeTb);
            Controls.Add(PriorTb);
            Controls.Add(SaveBt);
            Controls.Add(PriceNum);
            Controls.Add(ClientTb);
            Name = "AddApplicationForm";
            Text = "AddApplicationForm";
            ((System.ComponentModel.ISupportInitialize)PriceNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ClientTb;
        private NumericUpDown PriceNum;
        private Button SaveBt;
        private TextBox PriorTb;
        private TextBox TypeTb;
        private TextBox DescTb;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}