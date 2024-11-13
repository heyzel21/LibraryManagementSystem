namespace LibraryManagementSystem
{
    partial class BookDetails
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.returnButton = new System.Windows.Forms.Button();
            this.quantityPlaceholder = new System.Windows.Forms.Label();
            this.publishedPlaceholder = new System.Windows.Forms.Label();
            this.authorPlaceholder = new System.Windows.Forms.Label();
            this.titlePlaceholder = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.publishedLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.idPlaceholder = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.idPlaceholder);
            this.panel1.Controls.Add(this.idLabel);
            this.panel1.Controls.Add(this.returnButton);
            this.panel1.Controls.Add(this.quantityPlaceholder);
            this.panel1.Controls.Add(this.publishedPlaceholder);
            this.panel1.Controls.Add(this.authorPlaceholder);
            this.panel1.Controls.Add(this.titlePlaceholder);
            this.panel1.Controls.Add(this.quantityLabel);
            this.panel1.Controls.Add(this.publishedLabel);
            this.panel1.Controls.Add(this.authorLabel);
            this.panel1.Controls.Add(this.titleLabel);
            this.panel1.Controls.Add(this.headerLabel);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 289);
            this.panel1.TabIndex = 0;
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(102, 243);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(75, 23);
            this.returnButton.TabIndex = 17;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // quantityPlaceholder
            // 
            this.quantityPlaceholder.AutoSize = true;
            this.quantityPlaceholder.Location = new System.Drawing.Point(143, 149);
            this.quantityPlaceholder.Name = "quantityPlaceholder";
            this.quantityPlaceholder.Size = new System.Drawing.Size(19, 13);
            this.quantityPlaceholder.TabIndex = 12;
            this.quantityPlaceholder.Text = "10";
            // 
            // publishedPlaceholder
            // 
            this.publishedPlaceholder.AutoSize = true;
            this.publishedPlaceholder.Location = new System.Drawing.Point(143, 127);
            this.publishedPlaceholder.Name = "publishedPlaceholder";
            this.publishedPlaceholder.Size = new System.Drawing.Size(65, 13);
            this.publishedPlaceholder.TabIndex = 11;
            this.publishedPlaceholder.Text = "2001/01/01";
            // 
            // authorPlaceholder
            // 
            this.authorPlaceholder.AutoSize = true;
            this.authorPlaceholder.Location = new System.Drawing.Point(143, 103);
            this.authorPlaceholder.Name = "authorPlaceholder";
            this.authorPlaceholder.Size = new System.Drawing.Size(65, 13);
            this.authorPlaceholder.TabIndex = 10;
            this.authorPlaceholder.Text = "Hazel Bugot";
            // 
            // titlePlaceholder
            // 
            this.titlePlaceholder.AutoSize = true;
            this.titlePlaceholder.Location = new System.Drawing.Point(143, 79);
            this.titlePlaceholder.Name = "titlePlaceholder";
            this.titlePlaceholder.Size = new System.Drawing.Size(59, 13);
            this.titlePlaceholder.TabIndex = 9;
            this.titlePlaceholder.Text = "Book 2001";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(71, 149);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(46, 13);
            this.quantityLabel.TabIndex = 4;
            this.quantityLabel.Text = "Quantity";
            // 
            // publishedLabel
            // 
            this.publishedLabel.AutoSize = true;
            this.publishedLabel.Location = new System.Drawing.Point(64, 127);
            this.publishedLabel.Name = "publishedLabel";
            this.publishedLabel.Size = new System.Drawing.Size(53, 13);
            this.publishedLabel.TabIndex = 3;
            this.publishedLabel.Text = "Published";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(79, 103);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(38, 13);
            this.authorLabel.TabIndex = 2;
            this.authorLabel.Text = "Author";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(90, 79);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(27, 13);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Title";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(89, 15);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(111, 20);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Book Details";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(99, 59);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(18, 13);
            this.idLabel.TabIndex = 18;
            this.idLabel.Text = "ID";
            // 
            // idPlaceholder
            // 
            this.idPlaceholder.AutoSize = true;
            this.idPlaceholder.Location = new System.Drawing.Point(143, 59);
            this.idPlaceholder.Name = "idPlaceholder";
            this.idPlaceholder.Size = new System.Drawing.Size(13, 13);
            this.idPlaceholder.TabIndex = 19;
            this.idPlaceholder.Text = "1";
            // 
            // BookDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(324, 313);
            this.Controls.Add(this.panel1);
            this.Name = "BookDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewStudent";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label publishedLabel;
        private System.Windows.Forms.Label titlePlaceholder;
        private System.Windows.Forms.Label quantityPlaceholder;
        private System.Windows.Forms.Label publishedPlaceholder;
        private System.Windows.Forms.Label authorPlaceholder;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label idPlaceholder;
    }
}