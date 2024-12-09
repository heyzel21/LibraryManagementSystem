using System.Windows.Forms;

namespace LibraryManagementSystem
{
    partial class ManagePenaltyPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.issueReturnBooksDataGridView = new System.Windows.Forms.DataGridView();
            this.issueReturnBookListPanel = new System.Windows.Forms.Panel();
            this.payButton = new System.Windows.Forms.Button();
            this.dgvTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.issueReturnBooksDataGridView)).BeginInit();
            this.issueReturnBookListPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // issueReturnBooksDataGridView
            // 
            this.issueReturnBooksDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.issueReturnBooksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.issueReturnBooksDataGridView.Location = new System.Drawing.Point(14, 39);
            this.issueReturnBooksDataGridView.Name = "issueReturnBooksDataGridView";
            this.issueReturnBooksDataGridView.ReadOnly = true;
            this.issueReturnBooksDataGridView.Size = new System.Drawing.Size(689, 442);
            this.issueReturnBooksDataGridView.TabIndex = 0;
            this.issueReturnBooksDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BooksDataGridView_CellClick);
            // 
            // issueReturnBookListPanel
            // 
            this.issueReturnBookListPanel.BackColor = System.Drawing.Color.White;
            this.issueReturnBookListPanel.Controls.Add(this.payButton);
            this.issueReturnBookListPanel.Controls.Add(this.dgvTitle);
            this.issueReturnBookListPanel.Controls.Add(this.issueReturnBooksDataGridView);
            this.issueReturnBookListPanel.Location = new System.Drawing.Point(12, 10);
            this.issueReturnBookListPanel.Name = "issueReturnBookListPanel";
            this.issueReturnBookListPanel.Size = new System.Drawing.Size(718, 484);
            this.issueReturnBookListPanel.TabIndex = 1;
            // 
            // payButton
            // 
            this.payButton.Enabled = false;
            this.payButton.Location = new System.Drawing.Point(617, 12);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(86, 23);
            this.payButton.TabIndex = 20;
            this.payButton.Text = "PAY";
            this.payButton.UseVisualStyleBackColor = true;
            this.payButton.Click += new System.EventHandler(this.PayButton_Click);
            // 
            // dgvTitle
            // 
            this.dgvTitle.AutoSize = true;
            this.dgvTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTitle.Location = new System.Drawing.Point(10, 9);
            this.dgvTitle.Name = "dgvTitle";
            this.dgvTitle.Size = new System.Drawing.Size(176, 24);
            this.dgvTitle.TabIndex = 1;
            this.dgvTitle.Text = "Manage Penalties";
            // 
            // ManagePenaltyPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.issueReturnBookListPanel);
            this.Location = new System.Drawing.Point(237, 60);
            this.Name = "ManagePenaltyPanel";
            this.Size = new System.Drawing.Size(744, 503);
            this.Load += new System.EventHandler(this.ManageBookPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.issueReturnBooksDataGridView)).EndInit();
            this.issueReturnBookListPanel.ResumeLayout(false);
            this.issueReturnBookListPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView issueReturnBooksDataGridView;
        private Panel issueReturnBookListPanel;
        private Label dgvTitle;
        private Button payButton;
    }
}
