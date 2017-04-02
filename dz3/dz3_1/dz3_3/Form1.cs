using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dz3_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public TextBox SomeTextB()
        {
            return this.textBox1;
        }
        public void TextReturn(string txt)
        {
            this.textBox1.Text =txt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "TXT Files (txt,doc)|*.txt;*.doc";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFile.FileName);
                textBox1.Clear();
                textBox1.Text = sr.ReadToEnd();
                sr.Close();
                button2.Enabled = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(this);
            form.Show();

        }
    }
}
