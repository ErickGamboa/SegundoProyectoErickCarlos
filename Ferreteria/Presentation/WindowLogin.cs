﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class WindowLogin : Form
    {
        public WindowLogin()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            WindowRegister wregister = new WindowRegister();
            wregister.Show(this);
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
