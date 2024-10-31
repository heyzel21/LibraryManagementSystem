using System.Windows.Forms;

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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.studentsDataGridView = new System.Windows.Forms.DataGridView();
            this.studentListPanel = new System.Windows.Forms.Panel();
            this.dgvTitle = new System.Windows.Forms.Label();
            this.studentControlPanel = new System.Windows.Forms.Panel();
            this.studentIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.addressLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.contactNoLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.middleNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.sectionLabel = new System.Windows.Forms.Label();
            this.yearLevelLabel = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.contactNoTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.middleNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.sectionTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.studentIdLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.yearLevelNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGridView)).BeginInit();
            this.studentListPanel.SuspendLayout();
            this.studentControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearLevelNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // studentsDataGridView
            // 
            this.studentsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsDataGridView.Location = new System.Drawing.Point(14, 39);
            this.studentsDataGridView.Name = "studentsDataGridView";
            this.studentsDataGridView.Size = new System.Drawing.Size(693, 224);
            this.studentsDataGridView.TabIndex = 0;
            this.studentsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentsDataGridView_CellClick);
            // 
            // studentListPanel
            // 
            this.studentListPanel.BackColor = System.Drawing.Color.White;
            this.studentListPanel.Controls.Add(this.dgvTitle);
            this.studentListPanel.Controls.Add(this.studentsDataGridView);
            this.studentListPanel.Location = new System.Drawing.Point(12, 10);
            this.studentListPanel.Name = "studentListPanel";
            this.studentListPanel.Size = new System.Drawing.Size(724, 280);
            this.studentListPanel.TabIndex = 1;
            // 
            // dgvTitle
            // 
            this.dgvTitle.AutoSize = true;
            this.dgvTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTitle.Location = new System.Drawing.Point(10, 9);
            this.dgvTitle.Name = "dgvTitle";
            this.dgvTitle.Size = new System.Drawing.Size(121, 24);
            this.dgvTitle.TabIndex = 1;
            this.dgvTitle.Text = "All Students";
            // 
            // studentControlPanel
            // 
            this.studentControlPanel.BackColor = System.Drawing.Color.White;
            this.studentControlPanel.Controls.Add(this.yearLevelNumericUpDown);
            this.studentControlPanel.Controls.Add(this.studentIdNumericUpDown);
            this.studentControlPanel.Controls.Add(this.addressLabel);
            this.studentControlPanel.Controls.Add(this.emailLabel);
            this.studentControlPanel.Controls.Add(this.contactNoLabel);
            this.studentControlPanel.Controls.Add(this.lastNameLabel);
            this.studentControlPanel.Controls.Add(this.middleNameLabel);
            this.studentControlPanel.Controls.Add(this.firstNameLabel);
            this.studentControlPanel.Controls.Add(this.sectionLabel);
            this.studentControlPanel.Controls.Add(this.yearLevelLabel);
            this.studentControlPanel.Controls.Add(this.addressTextBox);
            this.studentControlPanel.Controls.Add(this.emailTextBox);
            this.studentControlPanel.Controls.Add(this.contactNoTextBox);
            this.studentControlPanel.Controls.Add(this.lastNameTextBox);
            this.studentControlPanel.Controls.Add(this.middleNameTextBox);
            this.studentControlPanel.Controls.Add(this.firstNameTextBox);
            this.studentControlPanel.Controls.Add(this.sectionTextBox);
            this.studentControlPanel.Controls.Add(this.clearButton);
            this.studentControlPanel.Controls.Add(this.deleteButton);
            this.studentControlPanel.Controls.Add(this.updateButton);
            this.studentControlPanel.Controls.Add(this.studentIdLabel);
            this.studentControlPanel.Controls.Add(this.addButton);
            this.studentControlPanel.Location = new System.Drawing.Point(12, 296);
            this.studentControlPanel.Name = "studentControlPanel";
            this.studentControlPanel.Size = new System.Drawing.Size(724, 198);
            this.studentControlPanel.TabIndex = 2;
            // 
            // studentIdNumericUpDown
            // 
            this.studentIdNumericUpDown.Location = new System.Drawing.Point(94, 19);
            this.studentIdNumericUpDown.Controls[0].Visible = false;
            this.studentIdNumericUpDown.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.studentIdNumericUpDown.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.studentIdNumericUpDown.Name = "studentIdNumericUpDown";
            this.studentIdNumericUpDown.Size = new System.Drawing.Size(137, 20);
            this.studentIdNumericUpDown.TabIndex = 29;
            this.studentIdNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(336, 97);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(45, 13);
            this.addressLabel.TabIndex = 28;
            this.addressLabel.Text = "Address";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(349, 74);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(32, 13);
            this.emailLabel.TabIndex = 27;
            this.emailLabel.Text = "Email";
            // 
            // contactNoLabel
            // 
            this.contactNoLabel.AutoSize = true;
            this.contactNoLabel.Location = new System.Drawing.Point(323, 48);
            this.contactNoLabel.Name = "contactNoLabel";
            this.contactNoLabel.Size = new System.Drawing.Size(61, 13);
            this.contactNoLabel.TabIndex = 26;
            this.contactNoLabel.Text = "Contact No";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(323, 22);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.lastNameLabel.TabIndex = 25;
            this.lastNameLabel.Text = "Last Name";
            // 
            // middleNameLabel
            // 
            this.middleNameLabel.AutoSize = true;
            this.middleNameLabel.Location = new System.Drawing.Point(18, 126);
            this.middleNameLabel.Name = "middleNameLabel";
            this.middleNameLabel.Size = new System.Drawing.Size(69, 13);
            this.middleNameLabel.TabIndex = 24;
            this.middleNameLabel.Text = "Middle Name";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(30, 100);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.firstNameLabel.TabIndex = 23;
            this.firstNameLabel.Text = "First Name";
            // 
            // sectionLabel
            // 
            this.sectionLabel.AutoSize = true;
            this.sectionLabel.Location = new System.Drawing.Point(45, 74);
            this.sectionLabel.Name = "sectionLabel";
            this.sectionLabel.Size = new System.Drawing.Size(43, 13);
            this.sectionLabel.TabIndex = 22;
            this.sectionLabel.Text = "Section";
            // 
            // yearLevelLabel
            // 
            this.yearLevelLabel.AutoSize = true;
            this.yearLevelLabel.Location = new System.Drawing.Point(30, 48);
            this.yearLevelLabel.Name = "yearLevelLabel";
            this.yearLevelLabel.Size = new System.Drawing.Size(58, 13);
            this.yearLevelLabel.TabIndex = 21;
            this.yearLevelLabel.Text = "Year Level";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(387, 97);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(137, 20);
            this.addressTextBox.TabIndex = 20;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(387, 71);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(137, 20);
            this.emailTextBox.TabIndex = 19;
            // 
            // contactNoTextBox
            // 
            this.contactNoTextBox.Location = new System.Drawing.Point(387, 45);
            this.contactNoTextBox.Name = "contactNoTextBox";
            this.contactNoTextBox.Size = new System.Drawing.Size(137, 20);
            this.contactNoTextBox.TabIndex = 18;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(387, 19);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(137, 20);
            this.lastNameTextBox.TabIndex = 17;
            // 
            // middleNameTextBox
            // 
            this.middleNameTextBox.Location = new System.Drawing.Point(94, 123);
            this.middleNameTextBox.Name = "middleNameTextBox";
            this.middleNameTextBox.Size = new System.Drawing.Size(137, 20);
            this.middleNameTextBox.TabIndex = 16;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(94, 97);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(137, 20);
            this.firstNameTextBox.TabIndex = 15;
            // 
            // sectionTextBox
            // 
            this.sectionTextBox.Location = new System.Drawing.Point(94, 71);
            this.sectionTextBox.Name = "sectionTextBox";
            this.sectionTextBox.Size = new System.Drawing.Size(137, 20);
            this.sectionTextBox.TabIndex = 14;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(447, 159);
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
            this.deleteButton.Location = new System.Drawing.Point(355, 159);
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
            this.updateButton.Location = new System.Drawing.Point(263, 159);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(86, 23);
            this.updateButton.TabIndex = 10;
            this.updateButton.Text = "UPDATE";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // studentIdLabel
            // 
            this.studentIdLabel.AutoSize = true;
            this.studentIdLabel.Location = new System.Drawing.Point(30, 22);
            this.studentIdLabel.Name = "studentIdLabel";
            this.studentIdLabel.Size = new System.Drawing.Size(58, 13);
            this.studentIdLabel.TabIndex = 9;
            this.studentIdLabel.Text = "Student ID";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(171, 159);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(86, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // yearLevelNumericUpDown
            // 
            this.yearLevelNumericUpDown.Location = new System.Drawing.Point(94, 46);
            this.yearLevelNumericUpDown.Controls[0].Visible = false;
            this.yearLevelNumericUpDown.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.yearLevelNumericUpDown.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.yearLevelNumericUpDown.Name = "yearLevelNumericUpDown";
            this.yearLevelNumericUpDown.Size = new System.Drawing.Size(137, 20);
            this.yearLevelNumericUpDown.TabIndex = 30;
            this.yearLevelNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ManageStudentPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.studentControlPanel);
            this.Controls.Add(this.studentListPanel);
            this.Location = new System.Drawing.Point(237, 60);
            this.Name = "ManageStudentPanel";
            this.Size = new System.Drawing.Size(744, 503);
            this.Load += new System.EventHandler(this.ManageBookPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGridView)).EndInit();
            this.studentListPanel.ResumeLayout(false);
            this.studentListPanel.PerformLayout();
            this.studentControlPanel.ResumeLayout(false);
            this.studentControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearLevelNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView studentsDataGridView;
        private Panel studentListPanel;
        private Label dgvTitle;
        private Panel studentControlPanel;
        private Button addButton;
        private Label studentIdLabel;
        private Button updateButton;
        private Button deleteButton;
        private Button clearButton;
        private TextBox sectionTextBox;
        private TextBox firstNameTextBox;
        private TextBox middleNameTextBox;
        private TextBox lastNameTextBox;
        private TextBox addressTextBox;
        private TextBox emailTextBox;
        private TextBox contactNoTextBox;
        private Label yearLevelLabel;
        private Label sectionLabel;
        private Label firstNameLabel;
        private Label middleNameLabel;
        private Label lastNameLabel;
        private Label contactNoLabel;
        private Label emailLabel;
        private Label addressLabel;
        private NumericUpDown studentIdNumericUpDown;
        private NumericUpDown yearLevelNumericUpDown;
    }
}
