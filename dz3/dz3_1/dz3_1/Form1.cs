﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dz3_1
{
    public partial class Form1 : Form
    {
        int count = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSeach_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(count);
            form.Show();
            count++;
        }
    }
}
