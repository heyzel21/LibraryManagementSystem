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
            this.headerPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dashboardPanel = new System.Windows.Forms.Panel();
            this.navPanel = new System.Windows.Forms.Panel();
            this.managePenaltiesBtn = new System.Windows.Forms.Button();
            this.issueReturnBtn = new System.Windows.Forms.Button();
            this.manageStudentsBtn = new System.Windows.Forms.Button();
            this.manageBooksBtn = new System.Windows.Forms.Button();
            this.dashboardBtn = new System.Windows.Forms.Button();
            this.profileLbl = new System.Windows.Forms.Label();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.headerPanel.SuspendLayout();
            this.dashboardPanel.SuspendLayout();
            this.navPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(58)))), ((int)(((byte)(118)))));
            this.headerPanel.Controls.Add(this.label1);
            this.headerPanel.Location = new System.Drawing.Point(0, -3);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(986, 66);
            this.headerPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Library Management System";
            // 
            // dashboardPanel
            // 
            this.dashboardPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dashboardPanel.Controls.Add(this.panel6);
            this.dashboardPanel.Controls.Add(this.panel1);
            this.dashboardPanel.Location = new System.Drawing.Point(237, 60);
            this.dashboardPanel.Name = "dashboardPanel";
            this.dashboardPanel.Size = new System.Drawing.Size(752, 500);
            this.dashboardPanel.TabIndex = 0;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Firebrick;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(9, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(164, 161);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(32, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "NO. OF USERS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(14, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 189);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Firebrick;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(188, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(164, 161);
            this.panel3.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "BORROWED BOOKS";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Firebrick;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(547, 15);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(164, 161);
            this.panel4.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "USERS PENALTY";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Firebrick;
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(368, 15);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(164, 161);
            this.panel5.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(23, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "RETURNED BOOKS";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.panel14);
            this.panel6.Controls.Add(this.panel13);
            this.panel6.Controls.Add(this.panel12);
            this.panel6.Controls.Add(this.panel11);
            this.panel6.Controls.Add(this.panel10);
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(14, 232);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(720, 255);
            this.panel6.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.MediumPurple;
            this.panel7.Location = new System.Drawing.Point(55, 71);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(615, 29);
            this.panel7.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel8.Location = new System.Drawing.Point(55, 106);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(615, 29);
            this.panel8.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Navy;
            this.panel9.Location = new System.Drawing.Point(55, 141);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(615, 29);
            this.panel9.TabIndex = 2;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Black;
            this.panel10.Location = new System.Drawing.Point(55, 176);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(615, 29);
            this.panel10.TabIndex = 3;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.MediumPurple;
            this.panel11.Location = new System.Drawing.Point(72, 24);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(27, 29);
            this.panel11.TabIndex = 1;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel12.Location = new System.Drawing.Point(219, 24);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(27, 29);
            this.panel12.TabIndex = 2;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.Navy;
            this.panel13.Location = new System.Drawing.Point(368, 24);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(27, 29);
            this.panel13.TabIndex = 3;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.Black;
            this.panel14.Location = new System.Drawing.Point(517, 24);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(27, 29);
            this.panel14.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(105, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "NO. OF USERS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.Location = new System.Drawing.Point(254, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "BORROWED BOOKS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(401, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "RETURNED BOOKS";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(550, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "USERS PENALTY";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 559);
            this.Controls.Add(this.dashboardPanel);
            this.Controls.Add(this.navPanel);
            this.Controls.Add(this.headerPanel);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.dashboardPanel.ResumeLayout(false);
            this.navPanel.ResumeLayout(false);
            this.navPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel navPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private Label profileLbl;
        private Button dashboardBtn;
        private Button manageBooksBtn;
        private Button managePenaltiesBtn;
        private Button issueReturnBtn;
        private Button manageStudentsBtn;
        private Panel dashboardPanel;
        private Panel panel1;
        private Panel panel4;
        private Label label4;
        private Panel panel3;
        private Label label3;
        private Panel panel5;
        private Label label5;
        private Panel panel2;
        private Label label2;
        private Panel panel6;
        private Panel panel8;
        private Panel panel7;
        private Panel panel10;
        private Panel panel9;
        private Panel panel14;
        private Panel panel13;
        private Panel panel12;
        private Panel panel11;
        private Label label6;
        private Label label9;
        private Label label8;
        private Label label7;
    }
}