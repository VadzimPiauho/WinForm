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
                textBoxRes.Text = dt.ToString("dddd");
            }
            catch (Exception)
            {

                textBoxEnter.Text = "Некоректные данные";
            }
        }

        private void textBoxEnter_Enter(object sender, EventArgs e)
        {
            textBoxRes.Text = null;
        }
    }
}
