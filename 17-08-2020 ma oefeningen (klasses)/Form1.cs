﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17_08_2020_ma_oefeningen__klasses_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOef1_Click(object sender, EventArgs e)
        {
            oef1 oef1 = new oef1();
            oef1.Show();
        }

        private void btnOef2_Click(object sender, EventArgs e)
        {
            oef2 oef2 = new oef2();
            oef2.Show();
        }

        private void btnOef3_Click(object sender, EventArgs e)
        {
            oef3 oef3 = new oef3();
            oef3.Show();
        }

        private void btnOef4_Click(object sender, EventArgs e)
        {
            oef4 oef4 = new oef4();
            oef4.Show();
        }

        private void btnOef5_Click(object sender, EventArgs e)
        {

        }
    }
}
