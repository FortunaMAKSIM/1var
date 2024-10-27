namespace _1var
{
    partial class Form2
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
            EditBt = new Button();
            AddBt = new Button();
            dataGridView1 = new DataGridView();
            StatBt = new Button();
            SearchTb = new TextBox();
            SearchBt = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // EditBt
            // 
            EditBt.Location = new Point(12, 12);
            EditBt.Name = "EditBt";
            EditBt.Size = new Size(153, 49);
            EditBt.TabIndex = 1;
            EditBt.Text = "Edit";
            EditBt.UseVisualStyleBackColor = true;
            EditBt.Click += EditBt_Click;
            // 
            // AddBt
            // 
            AddBt.Location = new Point(12, 67);
            AddBt.Name = "AddBt";
            AddBt.Size = new Size(153, 49);
            AddBt.TabIndex = 2;
            AddBt.Text = "Add";
            AddBt.UseVisualStyleBackColor = true;
            AddBt.Click += AddBt_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(171, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(617, 426);
            dataGridView1.TabIndex = 3;
            // 
            // StatBt
            // 
            StatBt.Location = new Point(12, 122);
            StatBt.Name = "StatBt";
            StatBt.Size = new Size(153, 49);
            StatBt.TabIndex = 4;
            StatBt.Text = "Stat";
            StatBt.UseVisualStyleBackColor = true;
            StatBt.Click += StatBt_Click;
            // 
            // SearchTb
            // 
            SearchTb.Location = new Point(12, 228);
            SearchTb.Name = "SearchTb";
            SearchTb.Size = new Size(153, 23);
            SearchTb.TabIndex = 5;
            // 
            // SearchBt
            // 
            SearchBt.Location = new Point(12, 257);
            SearchBt.Name = "SearchBt";
            SearchBt.Size = new Size(153, 49);
            SearchBt.TabIndex = 6;
            SearchBt.Text = "Search";
            SearchBt.UseVisualStyleBackColor = true;
            SearchBt.Click += SearchBt_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SearchBt);
            Controls.Add(SearchTb);
            Controls.Add(StatBt);
            Controls.Add(dataGridView1);
            Controls.Add(AddBt);
            Controls.Add(EditBt);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button EditBt;
        private Button AddBt;
        private DataGridView dataGridView1;
        private Button StatBt;
        private TextBox SearchTb;
        private Button SearchBt;
    }
}