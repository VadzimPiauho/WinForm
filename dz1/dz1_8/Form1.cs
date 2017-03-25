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
        double TOTALSIZE = 0;
        private int i;

        public BestOil()
        {
            InitializeComponent();
            comboBoxBenz.SelectedIndex = 0;
            Text = $"BestOil прибыль за сегодня = {TOTALSIZE}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            if (radioButton1.Checked == true)
            {
                labelItogo.Text = Convert.ToString(double.Parse(labelItogoBenz.Text) + double.Parse(labelItogoCafe.Text));
            }
            if (radioButton2.Checked == true)
            {
                labelItogo.Text = Convert.ToString(double.Parse(textBox10.Text) + double.Parse(labelItogoCafe.Text));
            }
            timer1.Start();
            i = 0;
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
                    if ((((TextBox)sender) == textBoxDog|| ((TextBox)sender) == textBoxGamb|| ((TextBox)sender) == textBoxFri || ((TextBox)sender) == textBoxCoca)&&
                    (textBoxDog.Text!="" && textBoxGamb.Text != "" && textBoxFri.Text != "" && textBoxCoca.Text != ""))
                    {
                        labelItogoCafe.Text = Convert.ToString(double.Parse(textBox1.Text) * double.Parse(textBoxDog.Text)+ double.Parse(textBox2.Text) * double.Parse(textBoxGamb.Text)+ double.Parse(textBox3.Text) * double.Parse(textBoxFri.Text)+ double.Parse(textBox4.Text) * double.Parse(textBoxCoca.Text));
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

        private void textBoxDog_Leave(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(TextBox))
            {
                if (((TextBox)sender).Text=="")
                    {
                    ((TextBox)sender).Text = "0.00";
                }
            }

            }

        private void comboBoxBenz_VisibleChanged(object sender, EventArgs e)
        {
            if (((ComboBox)sender).SelectedIndex== 0)
            {
                textBoxCenaBenz.Text = "1.13";
            }
            if (((ComboBox)sender).SelectedIndex == 1)
            {
                textBoxCenaBenz.Text = "1.21";
            }
            if (((ComboBox)sender).SelectedIndex == 2)
            {
                textBoxCenaBenz.Text = "1.42";
            }
            if (((ComboBox)sender).SelectedIndex == 3)
            {
                textBoxCenaBenz.Text = "0.66";
            }
            if (((ComboBox)sender).SelectedIndex == 4)
            {
                textBoxCenaBenz.Text = "1.25";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
                if (((RadioButton)sender) == radioButton1&& ((RadioButton)sender).Checked == true)
                {
                    textBox9.ReadOnly = false;
                    textBox10.ReadOnly = true;
                    textBox10.Text = "0";
                    groupBoxOplataBenz.Text = "К оплате:";
                    labelItogoRubBenz.Text = "руб.";
                }
                if (((RadioButton)sender) == radioButton2&& ((RadioButton)sender).Checked == true)
                {
                    textBox10.ReadOnly = false;
                    textBox9.ReadOnly = true;
                    textBox9.Text = "0";
                    groupBoxOplataBenz.Text="К выдаче:";
                    labelItogoRubBenz.Text= "л.";
                }
        }

        private void textBox9_Enter(object sender, EventArgs e)
        {
            if(((TextBox)sender).Text=="0")
            {
                ((TextBox)sender).Text = "";
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            if (sender.GetType() == typeof(TextBox))
            {
                if (((TextBox)sender) == textBox9)
                {
                    if (((TextBox)sender).Text == "")
                    {
                        labelItogoBenz.Text = "0.00";
                    }
                    else
                    {
                        labelItogoBenz.Text = Convert.ToString(int.Parse(textBox9.Text) * double.Parse(textBoxCenaBenz.Text));
                    }
                }
                if (((TextBox)sender) == textBox10 && ((TextBox)sender).Text != "" && ((TextBox)sender).Text != ".")
                {
                    if (((TextBox)sender).Text == ""|| ((TextBox)sender).Text == ".")
                    {
                        labelItogoBenz.Text = "0.00";
                        if (((TextBox)sender).Text == ".")
                        {
                            textBox10.Text = "";
                        }
                    }
                    else
                    {
                        labelItogoBenz.Text = Convert.ToString(double.Parse(textBox10.Text)/ double.Parse(textBoxCenaBenz.Text));
                    }
                }
            }
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            i++;
            if (i==5)
            {
               var temp= MessageBox.Show("Завершить работу с текущим покупателем?", "Новый покупатель", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (temp==DialogResult.Yes)
                {
                    timer1.Stop();
                    TOTALSIZE = double.Parse(labelItogo.Text);
                    Text = $"BestOil прибыль за сегодня = {TOTALSIZE}";
                    labelItogo.Text = "0.00";
                    labelItogoCafe.Text = "0.00";
                    labelItogoBenz.Text = "0.00";
                    textBoxDog.Text = "0";
                    textBoxGamb.Text = "0";
                    textBoxFri.Text = "0";
                    textBoxCoca.Text = "0";
                    textBox9.Text = "0";
                    textBox10.Text = "0";
                }
                if (temp == DialogResult.No)
                {
                    i = 0;
                }
            }
        }
    }
}
