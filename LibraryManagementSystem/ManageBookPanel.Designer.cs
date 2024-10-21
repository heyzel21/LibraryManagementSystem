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
            this.clearButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.publishedLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.publishedTextBox = new System.Windows.Forms.TextBox();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
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
            this.booksDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.booksDataGridView_CellClick);
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
            this.bookControlPanel.Controls.Add(this.clearButton);
            this.bookControlPanel.Controls.Add(this.deleteButton);
            this.bookControlPanel.Controls.Add(this.updateButton);
            this.bookControlPanel.Controls.Add(this.quantityLabel);
            this.bookControlPanel.Controls.Add(this.publishedLabel);
            this.bookControlPanel.Controls.Add(this.authorLabel);
            this.bookControlPanel.Controls.Add(this.titleLabel);
            this.bookControlPanel.Controls.Add(this.quantityTextBox);
            this.bookControlPanel.Controls.Add(this.publishedTextBox);
            this.bookControlPanel.Controls.Add(this.authorTextBox);
            this.bookControlPanel.Controls.Add(this.titleTextBox);
            this.bookControlPanel.Controls.Add(this.addButton);
            this.bookControlPanel.Location = new System.Drawing.Point(12, 10);
            this.bookControlPanel.Name = "bookControlPanel";
            this.bookControlPanel.Size = new System.Drawing.Size(207, 484);
            this.bookControlPanel.TabIndex = 2;
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
            // updateButton
            // 
            this.updateButton.Enabled = false;
            this.updateButton.Location = new System.Drawing.Point(104, 317);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(86, 23);
            this.updateButton.TabIndex = 10;
            this.updateButton.Text = "UPDATE";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(27, 220);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(46, 13);
            this.quantityLabel.TabIndex = 9;
            this.quantityLabel.Text = "Quantity";
            // 
            // publishedLabel
            // 
            this.publishedLabel.AutoSize = true;
            this.publishedLabel.Location = new System.Drawing.Point(20, 194);
            this.publishedLabel.Name = "publishedLabel";
            this.publishedLabel.Size = new System.Drawing.Size(53, 13);
            this.publishedLabel.TabIndex = 8;
            this.publishedLabel.Text = "Published";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(35, 164);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(38, 13);
            this.authorLabel.TabIndex = 7;
            this.authorLabel.Text = "Author";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(18, 138);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(55, 13);
            this.titleLabel.TabIndex = 6;
            this.titleLabel.Text = "Book Title";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(79, 213);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantityTextBox.TabIndex = 5;
            // 
            // publishedTextBox
            // 
            this.publishedTextBox.Location = new System.Drawing.Point(79, 187);
            this.publishedTextBox.Name = "publishedTextBox";
            this.publishedTextBox.Size = new System.Drawing.Size(100, 20);
            this.publishedTextBox.TabIndex = 4;
            // 
            // authorTextBox
            // 
            this.authorTextBox.Location = new System.Drawing.Point(79, 161);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(100, 20);
            this.authorTextBox.TabIndex = 3;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(79, 135);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(100, 20);
            this.titleTextBox.TabIndex = 2;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 317);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(86, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addBtn_Click);
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
            this.bookControlPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView booksDataGridView;
        private Panel bookListPanel;
        private Label dgvTitle;
        private Panel bookControlPanel;
        private Button addButton;
        private TextBox titleTextBox;
        private TextBox authorTextBox;
        private TextBox publishedTextBox;
        private TextBox quantityTextBox;
        private Label quantityLabel;
        private Label publishedLabel;
        private Label authorLabel;
        private Label titleLabel;
        private Button updateButton;
        private Button deleteButton;
        private Button clearButton;
    }
}
