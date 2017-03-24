﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dz1_8
{
    public partial class BestOil : Form
    {
        public BestOil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            labelItogo.Text = Convert.ToString(double.Parse(labelItogoBenz.Text) + double.Parse(labelItogoCafe.Text));
        }

        private void checkBoxDog_CheckedChanged(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(CheckBox))
            {
                if (((CheckBox)sender).Checked == true)
                {
                    if (((CheckBox)sender).Text==checkBoxDog.Text)
                    {
                        textBoxDog.ReadOnly = false;
                    }
                    if (((CheckBox)sender).Text == checkBoxGamb.Text)
                    {
                        textBoxGamb.ReadOnly = false;
                    }
                    if (((CheckBox)sender).Text == checkBoxFri.Text)
                    {
                        textBoxFri.ReadOnly = false;
                    }
                    if (((CheckBox)sender).Text == checkBoxCoca.Text)
                    {
                        textBoxCoca.ReadOnly = false;
                    }
                }
                if (((CheckBox)sender).Checked == false)
                {
                    if (((CheckBox)sender).Text == checkBoxDog.Text)
                    {
                        textBoxDog.ReadOnly = true;
                    }
                    if (((CheckBox)sender).Text == checkBoxGamb.Text)
                    {
                        textBoxGamb.ReadOnly = true;
                    }
                    if (((CheckBox)sender).Text == checkBoxFri.Text)
                    {
                        textBoxFri.ReadOnly = true;
                    }
                    if (((CheckBox)sender).Text == checkBoxCoca.Text)
                    {
                        textBoxCoca.ReadOnly = true;
                    }
                }
            }
           
        }

        private void textBoxDog_TextChanged(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            if (sender.GetType() == typeof(TextBox))
            {
                    if (((TextBox)sender) == textBoxDog)
                    {
                        labelItogoCafe.Text = Convert.ToString(double.Parse(textBox1.Text) * double.Parse(textBoxDog.Text)+ double.Parse(textBox2.Text) * double.Parse(textBoxGamb.Text));
                    }
                    if (((TextBox)sender) == textBoxGamb)
                    {
                        labelItogoCafe.Text = Convert.ToString(double.Parse(textBox2.Text) * double.Parse(textBoxGamb.Text));
                    }
                    if (((TextBox)sender) == textBoxFri)
                    {
                        labelItogoCafe.Text = Convert.ToString(double.Parse(textBox3.Text) * double.Parse(textBoxFri.Text));
                    }
                    if (((TextBox)sender) == textBoxCoca)
                    {
                        labelItogoCafe.Text = Convert.ToString(double.Parse(textBox4.Text) * double.Parse(textBoxCoca.Text));
                    }
            }
        }

        private void textBoxDog_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch)&& ch!=8)
            {
                e.Handled = true;
            }
        }
    }
}
