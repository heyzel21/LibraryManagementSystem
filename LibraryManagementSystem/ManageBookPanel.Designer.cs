using System.Windows.Forms;

namespace LibraryManagementSystem
{
    partial class ManageBookPanel
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
            this.booksDataGridView = new System.Windows.Forms.DataGridView();
            this.bookListPanel = new System.Windows.Forms.Panel();
            this.dgvTitle = new System.Windows.Forms.Label();
            this.bookControlPanel = new System.Windows.Forms.Panel();
            this.addBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGridView)).BeginInit();
            this.bookListPanel.SuspendLayout();
            this.bookControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // booksDataGridView
            // 
            this.booksDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.booksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksDataGridView.Location = new System.Drawing.Point(14, 39);
            this.booksDataGridView.Name = "booksDataGridView";
            this.booksDataGridView.Size = new System.Drawing.Size(487, 442);
            this.booksDataGridView.TabIndex = 0;
            // 
            // bookListPanel
            // 
            this.bookListPanel.BackColor = System.Drawing.Color.White;
            this.bookListPanel.Controls.Add(this.dgvTitle);
            this.bookListPanel.Controls.Add(this.booksDataGridView);
            this.bookListPanel.Location = new System.Drawing.Point(229, 10);
            this.bookListPanel.Name = "bookListPanel";
            this.bookListPanel.Size = new System.Drawing.Size(507, 484);
            this.bookListPanel.TabIndex = 1;
            // 
            // dgvTitle
            // 
            this.dgvTitle.AutoSize = true;
            this.dgvTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTitle.Location = new System.Drawing.Point(10, 9);
            this.dgvTitle.Name = "dgvTitle";
            this.dgvTitle.Size = new System.Drawing.Size(163, 24);
            this.dgvTitle.TabIndex = 1;
            this.dgvTitle.Text = "All issued books";
            // 
            // bookControlPanel
            // 
            this.bookControlPanel.BackColor = System.Drawing.Color.White;
            this.bookControlPanel.Controls.Add(this.addBtn);
            this.bookControlPanel.Location = new System.Drawing.Point(12, 10);
            this.bookControlPanel.Name = "bookControlPanel";
            this.bookControlPanel.Size = new System.Drawing.Size(207, 484);
            this.bookControlPanel.TabIndex = 2;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(12, 317);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // ManageBookPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.bookControlPanel);
            this.Controls.Add(this.bookListPanel);
            this.Location = new System.Drawing.Point(237, 60);
            this.Name = "ManageBookPanel";
            this.Size = new System.Drawing.Size(744, 503);
            this.Load += new System.EventHandler(this.ManageBookPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGridView)).EndInit();
            this.bookListPanel.ResumeLayout(false);
            this.bookListPanel.PerformLayout();
            this.bookControlPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView booksDataGridView;
        private Panel bookListPanel;
        private Label dgvTitle;
        private Panel bookControlPanel;
        private Button addBtn;
    }
}
