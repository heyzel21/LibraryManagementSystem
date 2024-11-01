using System;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 6;

            if (panel2.Width >= 575)
            {
                Timer1.Stop();

                Login lForm = new Login();
                lForm.Show();
                this.Hide();
            }
        }
    }
}
