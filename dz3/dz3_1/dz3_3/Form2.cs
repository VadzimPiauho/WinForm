using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dz3_3
{

    public partial class Form2 : Form
    {
        Form1 txt2;
        public Form2(Form1 txt)
        {
            InitializeComponent();
            this.txt2 = txt;
            textBoxForm2.Text = txt.SomeTextB().Text;
            this.Text = "Редактирование текста";
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxForm2.Text == "")
            {
                MessageBox.Show("Пусто");
            }
            txt2.TextReturn(textBoxForm2.Text);
            this.Close();
            //this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
