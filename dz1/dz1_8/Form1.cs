using System;
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
            labelItogo.Text = Convert.to
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
                        textBoxDog.ReadOnly = false;
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
    }
}
