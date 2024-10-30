namespace LibraryManagementSystem
{
    partial class ManageStudentPanel
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
            this.booksDataGridView = new System.Windows.Forms.DataGridView();
            this.dgvTitle = new System.Windows.Forms.Label();
            this.bookControlPanel = new System.Windows.Forms.Panel();
            this.Emaillabel = new System.Windows.Forms.Label();
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.AddresstextBox = new System.Windows.Forms.TextBox();
            this.MnameLabel = new System.Windows.Forms.Label();
            this.MnametextBox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.FnameLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.bookListPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGridView)).BeginInit();
            this.bookControlPanel.SuspendLayout();
            this.bookListPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // booksDataGridView
            // 
            this.booksDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.booksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksDataGridView.Location = new System.Drawing.Point(14, 39);
            this.booksDataGridView.Name = "booksDataGridView";
            this.booksDataGridView.Size = new System.Drawing.Size(693, 205);
            this.booksDataGridView.TabIndex = 0;
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
            this.bookControlPanel.Controls.Add(this.Emaillabel);
            this.bookControlPanel.Controls.Add(this.EmailtextBox);
            this.bookControlPanel.Controls.Add(this.AddressLabel);
            this.bookControlPanel.Controls.Add(this.AddresstextBox);
            this.bookControlPanel.Controls.Add(this.MnameLabel);
            this.bookControlPanel.Controls.Add(this.MnametextBox);
            this.bookControlPanel.Controls.Add(this.deleteButton);
            this.bookControlPanel.Controls.Add(this.updateButton);
            this.bookControlPanel.Controls.Add(this.FnameLabel);
            this.bookControlPanel.Controls.Add(this.IDLabel);
            this.bookControlPanel.Controls.Add(this.authorTextBox);
            this.bookControlPanel.Controls.Add(this.titleTextBox);
            this.bookControlPanel.Controls.Add(this.addButton);
            this.bookControlPanel.Location = new System.Drawing.Point(13, 281);
            this.bookControlPanel.Name = "bookControlPanel";
            this.bookControlPanel.Size = new System.Drawing.Size(721, 210);
            this.bookControlPanel.TabIndex = 4;
            // 
            // Emaillabel
            // 
            this.Emaillabel.AutoSize = true;
            this.Emaillabel.Location = new System.Drawing.Point(348, 74);
            this.Emaillabel.Name = "Emaillabel";
            this.Emaillabel.Size = new System.Drawing.Size(35, 13);
            this.Emaillabel.TabIndex = 18;
            this.Emaillabel.Text = "Email:";
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.Location = new System.Drawing.Point(435, 71);
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(137, 20);
            this.EmailtextBox.TabIndex = 17;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(348, 39);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(48, 13);
            this.AddressLabel.TabIndex = 16;
            this.AddressLabel.Text = "Address:";
            // 
            // AddresstextBox
            // 
            this.AddresstextBox.Location = new System.Drawing.Point(435, 36);
            this.AddresstextBox.Name = "AddresstextBox";
            this.AddresstextBox.Size = new System.Drawing.Size(137, 20);
            this.AddresstextBox.TabIndex = 15;
            // 
            // MnameLabel
            // 
            this.MnameLabel.AutoSize = true;
            this.MnameLabel.Location = new System.Drawing.Point(63, 100);
            this.MnameLabel.Name = "MnameLabel";
            this.MnameLabel.Size = new System.Drawing.Size(72, 13);
            this.MnameLabel.TabIndex = 14;
            this.MnameLabel.Text = "Middle Name:";
            // 
            // MnametextBox
            // 
            this.MnametextBox.Location = new System.Drawing.Point(162, 97);
            this.MnametextBox.Name = "MnametextBox";
            this.MnametextBox.Size = new System.Drawing.Size(137, 20);
            this.MnametextBox.TabIndex = 13;
            // 
            // deleteButton
            // 
            this.deleteButton.Enabled = false;
            this.deleteButton.Location = new System.Drawing.Point(419, 153);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(86, 23);
            this.deleteButton.TabIndex = 11;
            this.deleteButton.Text = "DELETE";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            this.updateButton.Enabled = false;
            this.updateButton.Location = new System.Drawing.Point(304, 153);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(86, 23);
            this.updateButton.TabIndex = 10;
            this.updateButton.Text = "UPDATE";
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // FnameLabel
            // 
            this.FnameLabel.AutoSize = true;
            this.FnameLabel.Location = new System.Drawing.Point(63, 67);
            this.FnameLabel.Name = "FnameLabel";
            this.FnameLabel.Size = new System.Drawing.Size(60, 13);
            this.FnameLabel.TabIndex = 7;
            this.FnameLabel.Text = "First Name:";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(64, 39);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(61, 13);
            this.IDLabel.TabIndex = 6;
            this.IDLabel.Text = "Student ID:";
            // 
            // authorTextBox
            // 
            this.authorTextBox.Location = new System.Drawing.Point(162, 67);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(137, 20);
            this.authorTextBox.TabIndex = 3;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(162, 36);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(137, 20);
            this.titleTextBox.TabIndex = 2;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(187, 153);
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
            this.bookListPanel.Location = new System.Drawing.Point(13, 6);
            this.bookListPanel.Name = "bookListPanel";
            this.bookListPanel.Size = new System.Drawing.Size(721, 269);
            this.bookListPanel.TabIndex = 3;
            // 
            // ManageStudentPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(744, 503);
            this.Controls.Add(this.bookControlPanel);
            this.Controls.Add(this.bookListPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageStudentPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "manageStudentPanel";
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGridView)).EndInit();
            this.bookControlPanel.ResumeLayout(false);
            this.bookControlPanel.PerformLayout();
            this.bookListPanel.ResumeLayout(false);
            this.bookListPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView booksDataGridView;
        private System.Windows.Forms.Label dgvTitle;
        private System.Windows.Forms.Panel bookControlPanel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label FnameLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Panel bookListPanel;
        private System.Windows.Forms.Label Emaillabel;
        private System.Windows.Forms.TextBox EmailtextBox;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox AddresstextBox;
        private System.Windows.Forms.Label MnameLabel;
        private System.Windows.Forms.TextBox MnametextBox;
    }
}