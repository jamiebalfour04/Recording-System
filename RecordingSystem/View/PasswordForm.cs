using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecordingSystem
{
    public partial class PasswordForm : Form
    {
        public PasswordForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (usernameInput.Text == Properties.Resources.username && passwordInput.Text == Properties.Resources.password)
            {
                new SelectMessage().Visible = true;
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Incorrect login details. Please try again.", "Please try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PasswordForm_Load(object sender, EventArgs e)
        {
            this.Text = Properties.Resources.applicationName + " :: Login";
        }
    }
}
