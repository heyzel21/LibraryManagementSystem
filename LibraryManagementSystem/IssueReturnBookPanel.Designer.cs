using System.Windows.Forms;

namespace LibraryManagementSystem
{
    partial class IssueReturnBookPanel
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
            this.dgvTitle = new System.Windows.Forms.Label();
            this.issueReturnBookControlPanel = new System.Windows.Forms.Panel();
            this.bookIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.studentIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.viewBookButon = new System.Windows.Forms.Button();
            this.viewStudentButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.bookLabel = new System.Windows.Forms.Label();
            this.studentIdLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.issueReturnBooksDataGridView)).BeginInit();
            this.issueReturnBookListPanel.SuspendLayout();
            this.issueReturnBookControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentIdNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // issueReturnBooksDataGridView
            // 
            this.issueReturnBooksDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.issueReturnBooksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.issueReturnBooksDataGridView.Location = new System.Drawing.Point(14, 39);
            this.issueReturnBooksDataGridView.Name = "issueReturnBooksDataGridView";
            this.issueReturnBooksDataGridView.ReadOnly = true;
            this.issueReturnBooksDataGridView.Size = new System.Drawing.Size(487, 442);
            this.issueReturnBooksDataGridView.TabIndex = 0;
            this.issueReturnBooksDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BooksDataGridView_CellClick);
            // 
            // issueReturnBookListPanel
            // 
            this.issueReturnBookListPanel.BackColor = System.Drawing.Color.White;
            this.issueReturnBookListPanel.Controls.Add(this.dgvTitle);
            this.issueReturnBookListPanel.Controls.Add(this.issueReturnBooksDataGridView);
            this.issueReturnBookListPanel.Location = new System.Drawing.Point(229, 10);
            this.issueReturnBookListPanel.Name = "issueReturnBookListPanel";
            this.issueReturnBookListPanel.Size = new System.Drawing.Size(507, 484);
            this.issueReturnBookListPanel.TabIndex = 1;
            // 
            // dgvTitle
            // 
            this.dgvTitle.AutoSize = true;
            this.dgvTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTitle.Location = new System.Drawing.Point(10, 9);
            this.dgvTitle.Name = "dgvTitle";
            this.dgvTitle.Size = new System.Drawing.Size(179, 24);
            this.dgvTitle.TabIndex = 1;
            this.dgvTitle.Text = "Issue/Return book";
            // 
            // issueReturnBookControlPanel
            // 
            this.issueReturnBookControlPanel.BackColor = System.Drawing.Color.White;
            this.issueReturnBookControlPanel.Controls.Add(this.bookIdNumericUpDown);
            this.issueReturnBookControlPanel.Controls.Add(this.studentIdNumericUpDown);
            this.issueReturnBookControlPanel.Controls.Add(this.viewBookButon);
            this.issueReturnBookControlPanel.Controls.Add(this.viewStudentButton);
            this.issueReturnBookControlPanel.Controls.Add(this.clearButton);
            this.issueReturnBookControlPanel.Controls.Add(this.deleteButton);
            this.issueReturnBookControlPanel.Controls.Add(this.bookLabel);
            this.issueReturnBookControlPanel.Controls.Add(this.studentIdLabel);
            this.issueReturnBookControlPanel.Controls.Add(this.addButton);
            this.issueReturnBookControlPanel.Location = new System.Drawing.Point(12, 10);
            this.issueReturnBookControlPanel.Name = "issueReturnBookControlPanel";
            this.issueReturnBookControlPanel.Size = new System.Drawing.Size(211, 484);
            this.issueReturnBookControlPanel.TabIndex = 2;
            // 
            // bookIdNumericUpDown
            // 
            this.bookIdNumericUpDown.Location = new System.Drawing.Point(67, 161);
            this.bookIdNumericUpDown.Name = "bookIdNumericUpDown";
            this.bookIdNumericUpDown.Size = new System.Drawing.Size(137, 20);
            this.bookIdNumericUpDown.TabIndex = 19;
            // 
            // studentIdNumericUpDown
            // 
            this.studentIdNumericUpDown.Location = new System.Drawing.Point(67, 105);
            this.studentIdNumericUpDown.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.studentIdNumericUpDown.Name = "studentIdNumericUpDown";
            this.studentIdNumericUpDown.Size = new System.Drawing.Size(137, 20);
            this.studentIdNumericUpDown.TabIndex = 18;
            // 
            // viewBookButon
            // 
            this.viewBookButon.Location = new System.Drawing.Point(67, 187);
            this.viewBookButon.Name = "viewBookButon";
            this.viewBookButon.Size = new System.Drawing.Size(137, 23);
            this.viewBookButon.TabIndex = 15;
            this.viewBookButon.Text = "View Book";
            this.viewBookButon.UseVisualStyleBackColor = true;
            this.viewBookButon.Click += new System.EventHandler(this.ViewBookButon_Click);
            // 
            // viewStudentButton
            // 
            this.viewStudentButton.Location = new System.Drawing.Point(67, 132);
            this.viewStudentButton.Name = "viewStudentButton";
            this.viewStudentButton.Size = new System.Drawing.Size(137, 23);
            this.viewStudentButton.TabIndex = 14;
            this.viewStudentButton.Text = "View Student";
            this.viewStudentButton.UseVisualStyleBackColor = true;
            this.viewStudentButton.Click += new System.EventHandler(this.ViewStudentButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(104, 346);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(86, 23);
            this.clearButton.TabIndex = 12;
            this.clearButton.Text = "CLEAR";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Enabled = false;
            this.deleteButton.Location = new System.Drawing.Point(12, 346);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(86, 23);
            this.deleteButton.TabIndex = 11;
            this.deleteButton.Text = "DELETE";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // bookLabel
            // 
            this.bookLabel.AutoSize = true;
            this.bookLabel.Location = new System.Drawing.Point(19, 164);
            this.bookLabel.Name = "bookLabel";
            this.bookLabel.Size = new System.Drawing.Size(46, 13);
            this.bookLabel.TabIndex = 7;
            this.bookLabel.Text = "Book ID";
            // 
            // studentIdLabel
            // 
            this.studentIdLabel.AutoSize = true;
            this.studentIdLabel.Location = new System.Drawing.Point(7, 109);
            this.studentIdLabel.Name = "studentIdLabel";
            this.studentIdLabel.Size = new System.Drawing.Size(58, 13);
            this.studentIdLabel.TabIndex = 6;
            this.studentIdLabel.Text = "Student ID";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 317);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(86, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // IssueReturnBookPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.issueReturnBookControlPanel);
            this.Controls.Add(this.issueReturnBookListPanel);
            this.Location = new System.Drawing.Point(237, 60);
            this.Name = "IssueReturnBookPanel";
            this.Size = new System.Drawing.Size(744, 503);
            this.Load += new System.EventHandler(this.ManageBookPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.issueReturnBooksDataGridView)).EndInit();
            this.issueReturnBookListPanel.ResumeLayout(false);
            this.issueReturnBookListPanel.PerformLayout();
            this.issueReturnBookControlPanel.ResumeLayout(false);
            this.issueReturnBookControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentIdNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView issueReturnBooksDataGridView;
        private Panel issueReturnBookListPanel;
        private Label dgvTitle;
        private Panel issueReturnBookControlPanel;
        private Button addButton;
        private Label bookLabel;
        private Label studentIdLabel;
        private Button deleteButton;
        private Button clearButton;
        private Button viewStudentButton;
        private Button viewBookButon;
        private NumericUpDown bookIdNumericUpDown;
        private NumericUpDown studentIdNumericUpDown;
    }
}
