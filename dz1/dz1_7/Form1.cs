using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dz1_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxEnter.Clear();
            textBoxRes.Clear();
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            DateTime dt = new DateTime();
            try
            {
                dt = DateTime.Parse(textBoxEnter.Text);
                DateTime newDate = DateTime.Now;                
                TimeSpan ts = dt - newDate;
                if (dt>newDate)
                {
                    if (radioButtonDay.Checked == true)
                    {
                        textBoxRes.Text = ts.Days.ToString();
                    }
                    if (radioButtonMin.Checked == true)
                    {
                        textBoxRes.Text = ts.Minutes.ToString();
                    }
                    if (radioButtonMonts.Checked == true)
                    {
                        textBoxRes.Text = (dt.Month-newDate.Month).ToString();
                    }
                    if (radioButtonSek.Checked == true)
                    {
                        textBoxRes.Text = ts.Seconds.ToString();
                    }
                    if (radioButtonYears.Checked == true)
                    {
                        textBoxRes.Text = (dt.Year - newDate.Year).ToString();
                    }
                }
                else
                {
                    textBoxRes.Text = "Указанная дата уже прошла";
                }
               
                //textBoxRes.Text = dt.ToString("dddd");
            }
            catch (Exception)
            {

                textBoxEnter.Text = "Некоректные данные";
            }
        }

        private void textBoxEnter_Enter(object sender, EventArgs e)
        {
            textBoxEnter.Text = null;
        }

        private void textBoxEnter_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
