using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public class PromptService
    {
        // Method to show a confirmation prompt
        public bool ShowConfirmation(string message, string title = "Confirmation")
        {
            // Show a message box with Yes and No options
            DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Return true if user clicked Yes, otherwise false
            return result == DialogResult.Yes;
        }
    }
}
