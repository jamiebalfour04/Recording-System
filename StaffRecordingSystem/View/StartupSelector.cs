﻿using System;
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
    public partial class StartupSelector : Form
    {
        public StartupSelector()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new RecordSomething().Visible = true;
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new PasswordForm().Visible = true;
            this.Visible = false;
        }
    }
}
