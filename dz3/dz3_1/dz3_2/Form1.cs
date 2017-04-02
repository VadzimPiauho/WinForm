using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dz3_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Вы не выбрали товар"); return;
            }
            int n = comboBox1.SelectedIndex;
            t = (Tovar)comboBox1.Items[n];
            Form2 editform = new Form2(t, false);
            editform.ShowDialog();
            comboBox1.Items.RemoveAt(n);
            comboBox1.Items.Insert(n, t);
            comboBox1.SelectedIndex = n;
        }
        Tovar t = null;
        private void button2_Click(object sender, EventArgs e)
        {
            t = new Tovar();
            Form2 addform = new Form2(t, true);
            if (addform.ShowDialog() == DialogResult.OK)
            {
                comboBox1.Items.Add(t);
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            t = (Tovar)comboBox1.Items[comboBox1.SelectedIndex];
            textBox1.Text = Convert.ToString(t.Price);
        }
        double TOTALPRICE = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Вы не выбрали товар"); return;
            }
            t = (Tovar)comboBox1.Items[comboBox1.SelectedIndex];
            //this.Text = $"Итого продали за день: {TOTALPRICE+=t.Price}";
            //listBox1.Items.Add(t);
            Tovar t2 = new Tovar(t);
            listBox1.Items.Add(t2);
            this.Text = $"Итого продали за день: {TOTALPRICE += t2.Price}";
            //foreach (Tovar item in listBox1.Items)
            //{
            //    TOTALPRICE += item.Price;
            //}
            //this.Text = $"Итого продали за день: {TOTALPRICE}";
            //TOTALPRICE = 0;
        }
    }
}
