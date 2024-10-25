using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    partial class Dashboard
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
            this.appNameLbl = new System.Windows.Forms.Label();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.navPanel = new System.Windows.Forms.Panel();
            this.managePenaltiesBtn = new System.Windows.Forms.Button();
            this.issueReturnBtn = new System.Windows.Forms.Button();
            this.manageStudentsBtn = new System.Windows.Forms.Button();
            this.manageBooksBtn = new System.Windows.Forms.Button();
            this.dashboardBtn = new System.Windows.Forms.Button();
            this.profileLbl = new System.Windows.Forms.Label();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.dashboardPanel = new LibraryManagementSystem.DashboardPanel();
            this.manageBookPanel = new LibraryManagementSystem.ManageBookPanel();
            this.headerPanel.SuspendLayout();
            this.navPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // appNameLbl
            // 
            this.appNameLbl.AutoSize = true;
            this.appNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appNameLbl.ForeColor = System.Drawing.Color.White;
            this.appNameLbl.Location = new System.Drawing.Point(3, 19);
            this.appNameLbl.Name = "appNameLbl";
            this.appNameLbl.Size = new System.Drawing.Size(359, 31);
            this.appNameLbl.TabIndex = 0;
            this.appNameLbl.Text = "Library Management System";
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(58)))), ((int)(((byte)(118)))));
            this.headerPanel.Controls.Add(this.appNameLbl);
            this.headerPanel.Location = new System.Drawing.Point(0, -3);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(986, 66);
            this.headerPanel.TabIndex = 0;
            // 
            // navPanel
            // 
            this.navPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(49)))), ((int)(((byte)(109)))));
            this.navPanel.Controls.Add(this.managePenaltiesBtn);
            this.navPanel.Controls.Add(this.issueReturnBtn);
            this.navPanel.Controls.Add(this.manageStudentsBtn);
            this.navPanel.Controls.Add(this.manageBooksBtn);
            this.navPanel.Controls.Add(this.dashboardBtn);
            this.navPanel.Controls.Add(this.profileLbl);
            this.navPanel.Controls.Add(this.profilePictureBox);
            this.navPanel.Location = new System.Drawing.Point(0, 60);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(245, 500);
            this.navPanel.TabIndex = 1;
            // 
            // managePenaltiesBtn
            // 
            this.managePenaltiesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(49)))), ((int)(((byte)(109)))));
            this.managePenaltiesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.managePenaltiesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.managePenaltiesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.managePenaltiesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managePenaltiesBtn.ForeColor = System.Drawing.Color.White;
            this.managePenaltiesBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.managePenaltiesBtn.Location = new System.Drawing.Point(12, 437);
            this.managePenaltiesBtn.Name = "managePenaltiesBtn";
            this.managePenaltiesBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.managePenaltiesBtn.Size = new System.Drawing.Size(219, 41);
            this.managePenaltiesBtn.TabIndex = 8;
            this.managePenaltiesBtn.Text = "MANAGE PENALTIES";
            this.managePenaltiesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.managePenaltiesBtn.UseVisualStyleBackColor = false;
            // 
            // issueReturnBtn
            // 
            this.issueReturnBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(49)))), ((int)(((byte)(109)))));
            this.issueReturnBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.issueReturnBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.issueReturnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.issueReturnBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueReturnBtn.ForeColor = System.Drawing.Color.White;
            this.issueReturnBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.issueReturnBtn.Location = new System.Drawing.Point(12, 380);
            this.issueReturnBtn.Name = "issueReturnBtn";
            this.issueReturnBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.issueReturnBtn.Size = new System.Drawing.Size(219, 41);
            this.issueReturnBtn.TabIndex = 7;
            this.issueReturnBtn.Text = "ISSUE / RETURN BOOK";
            this.issueReturnBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.issueReturnBtn.UseVisualStyleBackColor = false;
            // 
            // manageStudentsBtn
            // 
            this.manageStudentsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(49)))), ((int)(((byte)(109)))));
            this.manageStudentsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.manageStudentsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manageStudentsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageStudentsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageStudentsBtn.ForeColor = System.Drawing.Color.White;
            this.manageStudentsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manageStudentsBtn.Location = new System.Drawing.Point(12, 322);
            this.manageStudentsBtn.Name = "manageStudentsBtn";
            this.manageStudentsBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.manageStudentsBtn.Size = new System.Drawing.Size(219, 41);
            this.manageStudentsBtn.TabIndex = 6;
            this.manageStudentsBtn.Text = "MANAGE STUDENTS";
            this.manageStudentsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.manageStudentsBtn.UseVisualStyleBackColor = false;
            // 
            // manageBooksBtn
            // 
            this.manageBooksBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(49)))), ((int)(((byte)(109)))));
            this.manageBooksBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.manageBooksBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manageBooksBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageBooksBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageBooksBtn.ForeColor = System.Drawing.Color.White;
            this.manageBooksBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manageBooksBtn.Location = new System.Drawing.Point(12, 266);
            this.manageBooksBtn.Name = "manageBooksBtn";
            this.manageBooksBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.manageBooksBtn.Size = new System.Drawing.Size(219, 41);
            this.manageBooksBtn.TabIndex = 5;
            this.manageBooksBtn.Text = "MANAGE BOOKS";
            this.manageBooksBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.manageBooksBtn.UseVisualStyleBackColor = false;
            this.manageBooksBtn.Click += new System.EventHandler(this.ManageBooksBtn_Click);
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(49)))), ((int)(((byte)(109)))));
            this.dashboardBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dashboardBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardBtn.ForeColor = System.Drawing.Color.White;
            this.dashboardBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardBtn.Location = new System.Drawing.Point(12, 208);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dashboardBtn.Size = new System.Drawing.Size(219, 41);
            this.dashboardBtn.TabIndex = 4;
            this.dashboardBtn.Text = "DASHBOARD   ";
            this.dashboardBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dashboardBtn.UseVisualStyleBackColor = false;
            this.dashboardBtn.Click += new System.EventHandler(this.DashboardBtn_Click);
            // 
            // profileLbl
            // 
            this.profileLbl.AutoSize = true;
            this.profileLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileLbl.ForeColor = System.Drawing.Color.White;
            this.profileLbl.Location = new System.Drawing.Point(57, 168);
            this.profileLbl.Name = "profileLbl";
            this.profileLbl.Size = new System.Drawing.Size(128, 20);
            this.profileLbl.TabIndex = 3;
            this.profileLbl.Text = "Welcome, Admin";
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.profilePictureBox.Image = global::LibraryManagementSystem.Properties.Resources.inside_logo;
            this.profilePictureBox.Location = new System.Drawing.Point(61, 47);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(113, 107);
            this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePictureBox.TabIndex = 2;
            this.profilePictureBox.TabStop = false;
            // 
            // dashboardPanel
            // 
            this.dashboardPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dashboardPanel.Enabled = false;
            this.dashboardPanel.Location = new System.Drawing.Point(237, 60);
            this.dashboardPanel.Name = "dashboardPanel";
            this.dashboardPanel.Size = new System.Drawing.Size(752, 500);
            this.dashboardPanel.TabIndex = 0;
            // 
            // manageBookPanel
            // 
            this.manageBookPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.manageBookPanel.Location = new System.Drawing.Point(237, 60);
            this.manageBookPanel.Name = "manageBookPanel";
            this.manageBookPanel.Size = new System.Drawing.Size(746, 500);
            this.manageBookPanel.TabIndex = 1;
            this.manageBookPanel.Visible = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 559);
            this.Controls.Add(this.dashboardPanel);
            this.Controls.Add(this.manageBookPanel);
            this.Controls.Add(this.navPanel);
            this.Controls.Add(this.headerPanel);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.navPanel.ResumeLayout(false);
            this.navPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.ResumeLayout(false);

        }



        #endregion
        private DashboardPanel dashboardPanel;

        private Label appNameLbl;

        private Panel headerPanel;
        private Panel navPanel;

        private PictureBox profilePictureBox;
        private Label profileLbl;

        private Button dashboardBtn;
        private Button manageBooksBtn;
        private Button managePenaltiesBtn;
        private Button issueReturnBtn;
        private Button manageStudentsBtn;
        private ManageBookPanel manageBookPanel;
    }
}