namespace LibraryManagementSystem
{
    partial class IssueReturn
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
            this.bookControlPanel = new System.Windows.Forms.Panel();
            this.dateTimePickerPublished = new System.Windows.Forms.DateTimePicker();
            this.clearButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.publishedLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.bookListPanel = new System.Windows.Forms.Panel();
            this.dgvTitle = new System.Windows.Forms.Label();
            this.booksDataGridView = new System.Windows.Forms.DataGridView();
            this.nameLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.IDLabel = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.bookControlPanel.SuspendLayout();
            this.bookListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bookControlPanel
            // 
            this.bookControlPanel.BackColor = System.Drawing.Color.White;
            this.bookControlPanel.Controls.Add(this.IDLabel);
            this.bookControlPanel.Controls.Add(this.textBox4);
            this.bookControlPanel.Controls.Add(this.emailLabel);
            this.bookControlPanel.Controls.Add(this.textBox3);
            this.bookControlPanel.Controls.Add(this.numLabel);
            this.bookControlPanel.Controls.Add(this.textBox2);
            this.bookControlPanel.Controls.Add(this.nameLabel);
            this.bookControlPanel.Controls.Add(this.textBox1);
            this.bookControlPanel.Controls.Add(this.dateTimePickerPublished);
            this.bookControlPanel.Controls.Add(this.clearButton);
            this.bookControlPanel.Controls.Add(this.deleteButton);
            this.bookControlPanel.Controls.Add(this.updateButton);
            this.bookControlPanel.Controls.Add(this.publishedLabel);
            this.bookControlPanel.Controls.Add(this.authorLabel);
            this.bookControlPanel.Controls.Add(this.titleLabel);
            this.bookControlPanel.Controls.Add(this.authorTextBox);
            this.bookControlPanel.Controls.Add(this.titleTextBox);
            this.bookControlPanel.Controls.Add(this.addButton);
            this.bookControlPanel.Location = new System.Drawing.Point(10, 14);
            this.bookControlPanel.Name = "bookControlPanel";
            this.bookControlPanel.Size = new System.Drawing.Size(242, 475);
            this.bookControlPanel.TabIndex = 4;
            // 
            // dateTimePickerPublished
            // 
            this.dateTimePickerPublished.CustomFormat = "MMMM dd yyyy";
            this.dateTimePickerPublished.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerPublished.Location = new System.Drawing.Point(94, 289);
            this.dateTimePickerPublished.Name = "dateTimePickerPublished";
            this.dateTimePickerPublished.Size = new System.Drawing.Size(137, 20);
            this.dateTimePickerPublished.TabIndex = 13;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(118, 360);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(86, 23);
            this.clearButton.TabIndex = 12;
            this.clearButton.Text = "CLEAR";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Enabled = false;
            this.deleteButton.Location = new System.Drawing.Point(26, 360);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(86, 23);
            this.deleteButton.TabIndex = 11;
            this.deleteButton.Text = "DELETE";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            this.updateButton.Enabled = false;
            this.updateButton.Location = new System.Drawing.Point(118, 331);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(86, 23);
            this.updateButton.TabIndex = 10;
            this.updateButton.Text = "UPDATE";
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // publishedLabel
            // 
            this.publishedLabel.AutoSize = true;
            this.publishedLabel.Location = new System.Drawing.Point(32, 289);
            this.publishedLabel.Name = "publishedLabel";
            this.publishedLabel.Size = new System.Drawing.Size(56, 13);
            this.publishedLabel.TabIndex = 8;
            this.publishedLabel.Text = "Published:";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(47, 263);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(41, 13);
            this.authorLabel.TabIndex = 7;
            this.authorLabel.Text = "Author:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(30, 233);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(58, 13);
            this.titleLabel.TabIndex = 6;
            this.titleLabel.Text = "Book Title:";
            // 
            // authorTextBox
            // 
            this.authorTextBox.Location = new System.Drawing.Point(94, 260);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(137, 20);
            this.authorTextBox.TabIndex = 3;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(94, 230);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(137, 20);
            this.titleTextBox.TabIndex = 2;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(26, 331);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(86, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // bookListPanel
            // 
            this.bookListPanel.BackColor = System.Drawing.Color.White;
            this.bookListPanel.Controls.Add(this.dgvTitle);
            this.bookListPanel.Controls.Add(this.booksDataGridView);
            this.bookListPanel.Location = new System.Drawing.Point(258, 14);
            this.bookListPanel.Name = "bookListPanel";
            this.bookListPanel.Size = new System.Drawing.Size(476, 475);
            this.bookListPanel.TabIndex = 3;
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
            // booksDataGridView
            // 
            this.booksDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.booksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksDataGridView.Location = new System.Drawing.Point(14, 39);
            this.booksDataGridView.Name = "booksDataGridView";
            this.booksDataGridView.Size = new System.Drawing.Size(452, 420);
            this.booksDataGridView.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(10, 131);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(78, 13);
            this.nameLabel.TabIndex = 15;
            this.nameLabel.Text = "Student Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 131);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 20);
            this.textBox1.TabIndex = 14;
            // 
            // numLabel
            // 
            this.numLabel.AutoSize = true;
            this.numLabel.Location = new System.Drawing.Point(21, 163);
            this.numLabel.Name = "numLabel";
            this.numLabel.Size = new System.Drawing.Size(67, 13);
            this.numLabel.TabIndex = 17;
            this.numLabel.Text = "Contact No.:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(94, 163);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(137, 20);
            this.textBox2.TabIndex = 16;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(53, 200);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(35, 13);
            this.emailLabel.TabIndex = 19;
            this.emailLabel.Text = "Email:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(94, 200);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(137, 20);
            this.textBox3.TabIndex = 18;
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(27, 105);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(61, 13);
            this.IDLabel.TabIndex = 21;
            this.IDLabel.Text = "Student ID:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(94, 105);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(137, 20);
            this.textBox4.TabIndex = 20;
            // 
            // IssueReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(744, 503);
            this.Controls.Add(this.bookControlPanel);
            this.Controls.Add(this.bookListPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IssueReturn";
            this.Text = "IssueReturn";
            this.bookControlPanel.ResumeLayout(false);
            this.bookControlPanel.PerformLayout();
            this.bookListPanel.ResumeLayout(false);
            this.bookListPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bookControlPanel;
        private System.Windows.Forms.DateTimePicker dateTimePickerPublished;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label publishedLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Panel bookListPanel;
        private System.Windows.Forms.Label dgvTitle;
        private System.Windows.Forms.DataGridView booksDataGridView;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label numLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox textBox1;
    }
}