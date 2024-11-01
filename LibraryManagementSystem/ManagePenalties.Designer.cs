namespace LibraryManagementSystem
{
    partial class ManagePenalties
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
            this.studentListPanel = new System.Windows.Forms.Panel();
            this.dgvTitle = new System.Windows.Forms.Label();
            this.studentsDataGridView = new System.Windows.Forms.DataGridView();
            this.deleteButton = new System.Windows.Forms.Button();
            this.payButton = new System.Windows.Forms.Button();
            this.studentListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // studentListPanel
            // 
            this.studentListPanel.BackColor = System.Drawing.Color.White;
            this.studentListPanel.Controls.Add(this.deleteButton);
            this.studentListPanel.Controls.Add(this.payButton);
            this.studentListPanel.Controls.Add(this.dgvTitle);
            this.studentListPanel.Controls.Add(this.studentsDataGridView);
            this.studentListPanel.Location = new System.Drawing.Point(8, 12);
            this.studentListPanel.Name = "studentListPanel";
            this.studentListPanel.Size = new System.Drawing.Size(724, 479);
            this.studentListPanel.TabIndex = 2;
            // 
            // dgvTitle
            // 
            this.dgvTitle.AutoSize = true;
            this.dgvTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTitle.Location = new System.Drawing.Point(10, 9);
            this.dgvTitle.Name = "dgvTitle";
            this.dgvTitle.Size = new System.Drawing.Size(164, 24);
            this.dgvTitle.TabIndex = 1;
            this.dgvTitle.Text = "All Issued Books";
            // 
            // studentsDataGridView
            // 
            this.studentsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsDataGridView.Location = new System.Drawing.Point(14, 39);
            this.studentsDataGridView.Name = "studentsDataGridView";
            this.studentsDataGridView.Size = new System.Drawing.Size(693, 261);
            this.studentsDataGridView.TabIndex = 0;
            // 
            // deleteButton
            // 
            this.deleteButton.Enabled = false;
            this.deleteButton.Location = new System.Drawing.Point(406, 336);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(86, 23);
            this.deleteButton.TabIndex = 13;
            this.deleteButton.Text = "DELETE";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // payButton
            // 
            this.payButton.Location = new System.Drawing.Point(222, 336);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(86, 23);
            this.payButton.TabIndex = 12;
            this.payButton.Text = "PAY";
            this.payButton.UseVisualStyleBackColor = true;
            // 
            // ManagePenalties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(744, 503);
            this.Controls.Add(this.studentListPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManagePenalties";
            this.Text = "ManagePenalties";
            this.studentListPanel.ResumeLayout(false);
            this.studentListPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel studentListPanel;
        private System.Windows.Forms.Label dgvTitle;
        private System.Windows.Forms.DataGridView studentsDataGridView;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button payButton;
    }
}