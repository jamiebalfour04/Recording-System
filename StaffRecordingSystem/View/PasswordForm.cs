using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaffRecordingSystem
{
    public partial class PasswordForm : Form
    {
        public PasswordForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(usernameInput.Text == "knoxStaff" && passwordInput.Text == "knox2024")
            {
                new SelectMessage().Visible = true;
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Incorrect login details. Please try again.", "Please try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
