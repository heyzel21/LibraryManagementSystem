using System.Windows.Forms;

namespace LibraryManagementSystem
{
    partial class DashboardPanel
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
            this.data2Panel = new System.Windows.Forms.Panel();
            this.legendUsersPenaltyLbl = new System.Windows.Forms.Label();
            this.legendReturnedBooksLbl = new System.Windows.Forms.Label();
            this.legendBorrowedBooksLbl = new System.Windows.Forms.Label();
            this.legendUsersLbl = new System.Windows.Forms.Label();
            this.legendUsersPenaltyPanel = new System.Windows.Forms.Panel();
            this.legendReturnedBooksPanel = new System.Windows.Forms.Panel();
            this.legendBorrowedBooksPanel = new System.Windows.Forms.Panel();
            this.legendUsersPanel = new System.Windows.Forms.Panel();
            this.barUsersPenaltyPanel = new System.Windows.Forms.Panel();
            this.barReturnedBooksPanel = new System.Windows.Forms.Panel();
            this.barBorrowedBooksPanel = new System.Windows.Forms.Panel();
            this.barUsersPanel = new System.Windows.Forms.Panel();
            this.data1Panel = new System.Windows.Forms.Panel();
            this.numUsersPenaltyPanel = new System.Windows.Forms.Panel();
            this.numUsersPenaltyLbl = new System.Windows.Forms.Label();
            this.numBorrowBookPanel = new System.Windows.Forms.Panel();
            this.numBorrowedBooksLbl = new System.Windows.Forms.Label();
            this.numReturnBookPanel = new System.Windows.Forms.Panel();
            this.numReturneedBooksLbl = new System.Windows.Forms.Label();
            this.numUsersPanel = new System.Windows.Forms.Panel();
            this.numUsersLbl = new System.Windows.Forms.Label();
            this.data2Panel.SuspendLayout();
            this.data1Panel.SuspendLayout();
            this.numUsersPenaltyPanel.SuspendLayout();
            this.numBorrowBookPanel.SuspendLayout();
            this.numReturnBookPanel.SuspendLayout();
            this.numUsersPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // data2Panel
            // 
            this.data2Panel.BackColor = System.Drawing.Color.White;
            this.data2Panel.Controls.Add(this.legendUsersPenaltyLbl);
            this.data2Panel.Controls.Add(this.legendReturnedBooksLbl);
            this.data2Panel.Controls.Add(this.legendBorrowedBooksLbl);
            this.data2Panel.Controls.Add(this.legendUsersLbl);
            this.data2Panel.Controls.Add(this.legendUsersPenaltyPanel);
            this.data2Panel.Controls.Add(this.legendReturnedBooksPanel);
            this.data2Panel.Controls.Add(this.legendBorrowedBooksPanel);
            this.data2Panel.Controls.Add(this.legendUsersPanel);
            this.data2Panel.Controls.Add(this.barUsersPenaltyPanel);
            this.data2Panel.Controls.Add(this.barReturnedBooksPanel);
            this.data2Panel.Controls.Add(this.barBorrowedBooksPanel);
            this.data2Panel.Controls.Add(this.barUsersPanel);
            this.data2Panel.Location = new System.Drawing.Point(14, 232);
            this.data2Panel.Name = "data2Panel";
            this.data2Panel.Size = new System.Drawing.Size(720, 255);
            this.data2Panel.TabIndex = 1;
            // 
            // legendUsersPenaltyLbl
            // 
            this.legendUsersPenaltyLbl.AutoSize = true;
            this.legendUsersPenaltyLbl.Location = new System.Drawing.Point(550, 34);
            this.legendUsersPenaltyLbl.Name = "legendUsersPenaltyLbl";
            this.legendUsersPenaltyLbl.Size = new System.Drawing.Size(96, 13);
            this.legendUsersPenaltyLbl.TabIndex = 8;
            this.legendUsersPenaltyLbl.Text = "USERS PENALTY";
            // 
            // legendReturnedBooksLbl
            // 
            this.legendReturnedBooksLbl.AutoSize = true;
            this.legendReturnedBooksLbl.Location = new System.Drawing.Point(401, 34);
            this.legendReturnedBooksLbl.Name = "legendReturnedBooksLbl";
            this.legendReturnedBooksLbl.Size = new System.Drawing.Size(108, 13);
            this.legendReturnedBooksLbl.TabIndex = 7;
            this.legendReturnedBooksLbl.Text = "RETURNED BOOKS";
            // 
            // legendBorrowedBooksLbl
            // 
            this.legendBorrowedBooksLbl.AutoSize = true;
            this.legendBorrowedBooksLbl.BackColor = System.Drawing.Color.White;
            this.legendBorrowedBooksLbl.Cursor = System.Windows.Forms.Cursors.Default;
            this.legendBorrowedBooksLbl.Location = new System.Drawing.Point(254, 34);
            this.legendBorrowedBooksLbl.Name = "legendBorrowedBooksLbl";
            this.legendBorrowedBooksLbl.Size = new System.Drawing.Size(112, 13);
            this.legendBorrowedBooksLbl.TabIndex = 6;
            this.legendBorrowedBooksLbl.Text = "BORROWED BOOKS";
            // 
            // legendUsersLbl
            // 
            this.legendUsersLbl.AutoSize = true;
            this.legendUsersLbl.Location = new System.Drawing.Point(105, 34);
            this.legendUsersLbl.Name = "legendUsersLbl";
            this.legendUsersLbl.Size = new System.Drawing.Size(83, 13);
            this.legendUsersLbl.TabIndex = 5;
            this.legendUsersLbl.Text = "NO. OF USERS";
            // 
            // legendUsersPenaltyPanel
            // 
            this.legendUsersPenaltyPanel.BackColor = System.Drawing.Color.Black;
            this.legendUsersPenaltyPanel.Location = new System.Drawing.Point(517, 24);
            this.legendUsersPenaltyPanel.Name = "legendUsersPenaltyPanel";
            this.legendUsersPenaltyPanel.Size = new System.Drawing.Size(27, 29);
            this.legendUsersPenaltyPanel.TabIndex = 4;
            // 
            // legendReturnedBooksPanel
            // 
            this.legendReturnedBooksPanel.BackColor = System.Drawing.Color.Navy;
            this.legendReturnedBooksPanel.Location = new System.Drawing.Point(368, 24);
            this.legendReturnedBooksPanel.Name = "legendReturnedBooksPanel";
            this.legendReturnedBooksPanel.Size = new System.Drawing.Size(27, 29);
            this.legendReturnedBooksPanel.TabIndex = 3;
            // 
            // legendBorrowedBooksPanel
            // 
            this.legendBorrowedBooksPanel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.legendBorrowedBooksPanel.Location = new System.Drawing.Point(219, 24);
            this.legendBorrowedBooksPanel.Name = "legendBorrowedBooksPanel";
            this.legendBorrowedBooksPanel.Size = new System.Drawing.Size(27, 29);
            this.legendBorrowedBooksPanel.TabIndex = 2;
            // 
            // legendUsersPanel
            // 
            this.legendUsersPanel.BackColor = System.Drawing.Color.MediumPurple;
            this.legendUsersPanel.Location = new System.Drawing.Point(72, 24);
            this.legendUsersPanel.Name = "legendUsersPanel";
            this.legendUsersPanel.Size = new System.Drawing.Size(27, 29);
            this.legendUsersPanel.TabIndex = 1;
            // 
            // barUsersPenaltyPanel
            // 
            this.barUsersPenaltyPanel.BackColor = System.Drawing.Color.Black;
            this.barUsersPenaltyPanel.Location = new System.Drawing.Point(55, 176);
            this.barUsersPenaltyPanel.Name = "barUsersPenaltyPanel";
            this.barUsersPenaltyPanel.Size = new System.Drawing.Size(615, 29);
            this.barUsersPenaltyPanel.TabIndex = 3;
            // 
            // barReturnedBooksPanel
            // 
            this.barReturnedBooksPanel.BackColor = System.Drawing.Color.Navy;
            this.barReturnedBooksPanel.Location = new System.Drawing.Point(55, 141);
            this.barReturnedBooksPanel.Name = "barReturnedBooksPanel";
            this.barReturnedBooksPanel.Size = new System.Drawing.Size(615, 29);
            this.barReturnedBooksPanel.TabIndex = 2;
            // 
            // barBorrowedBooksPanel
            // 
            this.barBorrowedBooksPanel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.barBorrowedBooksPanel.Location = new System.Drawing.Point(55, 106);
            this.barBorrowedBooksPanel.Name = "barBorrowedBooksPanel";
            this.barBorrowedBooksPanel.Size = new System.Drawing.Size(615, 29);
            this.barBorrowedBooksPanel.TabIndex = 1;
            // 
            // barUsersPanel
            // 
            this.barUsersPanel.BackColor = System.Drawing.Color.MediumPurple;
            this.barUsersPanel.Location = new System.Drawing.Point(55, 71);
            this.barUsersPanel.Name = "barUsersPanel";
            this.barUsersPanel.Size = new System.Drawing.Size(615, 29);
            this.barUsersPanel.TabIndex = 0;
            // 
            // data1Panel
            // 
            this.data1Panel.BackColor = System.Drawing.Color.White;
            this.data1Panel.Controls.Add(this.numUsersPenaltyPanel);
            this.data1Panel.Controls.Add(this.numBorrowBookPanel);
            this.data1Panel.Controls.Add(this.numReturnBookPanel);
            this.data1Panel.Controls.Add(this.numUsersPanel);
            this.data1Panel.Location = new System.Drawing.Point(14, 21);
            this.data1Panel.Name = "data1Panel";
            this.data1Panel.Size = new System.Drawing.Size(720, 189);
            this.data1Panel.TabIndex = 0;
            // 
            // numUsersPenaltyPanel
            // 
            this.numUsersPenaltyPanel.BackColor = System.Drawing.Color.SkyBlue;
            this.numUsersPenaltyPanel.Controls.Add(this.numUsersPenaltyLbl);
            this.numUsersPenaltyPanel.Location = new System.Drawing.Point(547, 15);
            this.numUsersPenaltyPanel.Name = "numUsersPenaltyPanel";
            this.numUsersPenaltyPanel.Size = new System.Drawing.Size(164, 161);
            this.numUsersPenaltyPanel.TabIndex = 3;
            // 
            // numUsersPenaltyLbl
            // 
            this.numUsersPenaltyLbl.AutoSize = true;
            this.numUsersPenaltyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUsersPenaltyLbl.ForeColor = System.Drawing.Color.Black;
            this.numUsersPenaltyLbl.Location = new System.Drawing.Point(21, 22);
            this.numUsersPenaltyLbl.Name = "numUsersPenaltyLbl";
            this.numUsersPenaltyLbl.Size = new System.Drawing.Size(119, 16);
            this.numUsersPenaltyLbl.TabIndex = 0;
            this.numUsersPenaltyLbl.Text = "USERS PENALTY";
            // 
            // numBorrowBookPanel
            // 
            this.numBorrowBookPanel.BackColor = System.Drawing.Color.SkyBlue;
            this.numBorrowBookPanel.Controls.Add(this.numBorrowedBooksLbl);
            this.numBorrowBookPanel.Location = new System.Drawing.Point(188, 15);
            this.numBorrowBookPanel.Name = "numBorrowBookPanel";
            this.numBorrowBookPanel.Size = new System.Drawing.Size(164, 161);
            this.numBorrowBookPanel.TabIndex = 1;
            // 
            // numBorrowedBooksLbl
            // 
            this.numBorrowedBooksLbl.AutoSize = true;
            this.numBorrowedBooksLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBorrowedBooksLbl.ForeColor = System.Drawing.Color.Black;
            this.numBorrowedBooksLbl.Location = new System.Drawing.Point(12, 22);
            this.numBorrowedBooksLbl.Name = "numBorrowedBooksLbl";
            this.numBorrowedBooksLbl.Size = new System.Drawing.Size(137, 16);
            this.numBorrowedBooksLbl.TabIndex = 0;
            this.numBorrowedBooksLbl.Text = "BORROWED BOOKS";
            // 
            // numReturnBookPanel
            // 
            this.numReturnBookPanel.BackColor = System.Drawing.Color.SkyBlue;
            this.numReturnBookPanel.Controls.Add(this.numReturneedBooksLbl);
            this.numReturnBookPanel.Location = new System.Drawing.Point(368, 15);
            this.numReturnBookPanel.Name = "numReturnBookPanel";
            this.numReturnBookPanel.Size = new System.Drawing.Size(164, 161);
            this.numReturnBookPanel.TabIndex = 2;
            // 
            // numReturneedBooksLbl
            // 
            this.numReturneedBooksLbl.AutoSize = true;
            this.numReturneedBooksLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numReturneedBooksLbl.ForeColor = System.Drawing.Color.Black;
            this.numReturneedBooksLbl.Location = new System.Drawing.Point(23, 22);
            this.numReturneedBooksLbl.Name = "numReturneedBooksLbl";
            this.numReturneedBooksLbl.Size = new System.Drawing.Size(133, 16);
            this.numReturneedBooksLbl.TabIndex = 0;
            this.numReturneedBooksLbl.Text = "RETURNED BOOKS";
            // 
            // numUsersPanel
            // 
            this.numUsersPanel.BackColor = System.Drawing.Color.SkyBlue;
            this.numUsersPanel.Controls.Add(this.numUsersLbl);
            this.numUsersPanel.Location = new System.Drawing.Point(9, 15);
            this.numUsersPanel.Name = "numUsersPanel";
            this.numUsersPanel.Size = new System.Drawing.Size(164, 161);
            this.numUsersPanel.TabIndex = 0;
            // 
            // numUsersLbl
            // 
            this.numUsersLbl.AutoSize = true;
            this.numUsersLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUsersLbl.ForeColor = System.Drawing.Color.Black;
            this.numUsersLbl.Location = new System.Drawing.Point(32, 22);
            this.numUsersLbl.Name = "numUsersLbl";
            this.numUsersLbl.Size = new System.Drawing.Size(101, 16);
            this.numUsersLbl.TabIndex = 0;
            this.numUsersLbl.Text = "NO. OF USERS";
            // 
            // DashboardPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.data1Panel);
            this.Controls.Add(this.data2Panel);
            this.Location = new System.Drawing.Point(237, 60);
            this.Name = "DashboardPanel";
            this.Size = new System.Drawing.Size(752, 500);
            this.data2Panel.ResumeLayout(false);
            this.data2Panel.PerformLayout();
            this.data1Panel.ResumeLayout(false);
            this.numUsersPenaltyPanel.ResumeLayout(false);
            this.numUsersPenaltyPanel.PerformLayout();
            this.numBorrowBookPanel.ResumeLayout(false);
            this.numBorrowBookPanel.PerformLayout();
            this.numReturnBookPanel.ResumeLayout(false);
            this.numReturnBookPanel.PerformLayout();
            this.numUsersPanel.ResumeLayout(false);
            this.numUsersPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel data1Panel;
        private Panel numUsersPenaltyPanel;
        private Label numUsersPenaltyLbl;
        private Panel numBorrowBookPanel;
        private Label numBorrowedBooksLbl;
        private Panel numReturnBookPanel;
        private Label numReturneedBooksLbl;
        private Panel numUsersPanel;
        private Label numUsersLbl;
        private Panel data2Panel;
        private Panel barBorrowedBooksPanel;
        private Panel barUsersPanel;
        private Panel barUsersPenaltyPanel;
        private Panel barReturnedBooksPanel;
        private Panel legendUsersPenaltyPanel;
        private Panel legendReturnedBooksPanel;
        private Panel legendBorrowedBooksPanel;
        private Panel legendUsersPanel;
        private Label legendUsersLbl;
        private Label legendUsersPenaltyLbl;
        private Label legendReturnedBooksLbl;
        private Label legendBorrowedBooksLbl;
    }
}
