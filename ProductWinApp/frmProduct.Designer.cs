namespace ProductWinApp
{
    partial class frmProduct
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
            dgvList = new DataGridView();
            btnView = new Button();
            btnViewCategories = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvList).BeginInit();
            SuspendLayout();
            // 
            // dgvList
            // 
            dgvList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvList.Location = new Point(54, 135);
            dgvList.Margin = new Padding(4, 5, 4, 5);
            dgvList.Name = "dgvList";
            dgvList.RowTemplate.Height = 25;
            dgvList.Size = new Size(767, 230);
            dgvList.TabIndex = 1;
            // 
            // btnView
            // 
            btnView.Location = new Point(118, 58);
            btnView.Name = "btnView";
            btnView.Size = new Size(205, 36);
            btnView.TabIndex = 2;
            btnView.Text = "View Products";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // btnViewCategories
            // 
            btnViewCategories.Location = new Point(449, 58);
            btnViewCategories.Name = "btnViewCategories";
            btnViewCategories.Size = new Size(205, 36);
            btnViewCategories.TabIndex = 2;
            btnViewCategories.Text = "View Categories";
            btnViewCategories.UseVisualStyleBackColor = true;
            btnViewCategories.Click += btnViewCategories_Click;
            // 
            // frmProduct
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 616);
            Controls.Add(btnViewCategories);
            Controls.Add(btnView);
            Controls.Add(dgvList);
            Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmProduct";
            Text = "frmProduct";
            Load += frmProduct_Load;
            ((System.ComponentModel.ISupportInitialize)dgvList).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvList;
        private Button btnView;
        private Button btnViewCategories;
    }
}