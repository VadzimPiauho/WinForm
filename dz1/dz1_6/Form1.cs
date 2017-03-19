using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dz1_6
{
    public partial class FormDay : Form
    {
        public FormDay()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt = new DateTime();
            try
            {
                dt = DateTime.Parse(textBoxDaySet.Text);
                textBoxDayGet.Text = dt.ToString("dddd");
            }
            catch (Exception)
            {

                textBoxDaySet.Text = "Некоректные данные";
            }
        }

        private void buttonDayClear_Click(object sender, EventArgs e)
        {
            textBoxDaySet.Clear();
            textBoxDayGet.Clear();
        }

        private void textBoxDaySet_Enter(object sender, EventArgs e)
        {
            textBoxDaySet.Text = null;
        }

        private void FormDay_Load(object sender, EventArgs e)
        {

        }

        private void textBoxDaySet_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
