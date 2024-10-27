namespace _1var
{
    partial class StatisticsForm
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
            statisticsDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)statisticsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // statisticsDataGridView
            // 
            statisticsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            statisticsDataGridView.Location = new Point(12, 12);
            statisticsDataGridView.Name = "statisticsDataGridView";
            statisticsDataGridView.Size = new Size(487, 260);
            statisticsDataGridView.TabIndex = 0;
            // 
            // StatisticsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 284);
            Controls.Add(statisticsDataGridView);
            Name = "StatisticsForm";
            Text = "StatisticsForm";
            Load += StatisticsForm_Load;
            ((System.ComponentModel.ISupportInitialize)statisticsDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView statisticsDataGridView;
    }
}