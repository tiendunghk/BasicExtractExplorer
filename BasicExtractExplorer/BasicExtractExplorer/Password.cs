﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicExtractExplorer
{
    public partial class Password : Form
    {

        public Password()
        {
            InitializeComponent();
        }

        public string PasswordString { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            PasswordString = textBoxPassword.Text;
            DialogResult = DialogResult.OK;
        }
    }
}
