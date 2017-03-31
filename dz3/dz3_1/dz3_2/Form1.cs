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
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Вы не выбрали товар"); return;
            }
            int n = listBox1.SelectedIndex;
            t = (Tovar)listBox1.Items[n];
            Form2 editform = new Form2(t, false);
            editform.ShowDialog();
            listBox1.Items.RemoveAt(n);
            listBox1.Items.Insert(n, t);
            listBox1.SelectedIndex = n;
        }
        Tovar t = null;
        private void button2_Click(object sender, EventArgs e)
        {
            t = new Tovar();
            Form2 addform = new Form2(t, true);
            if (addform.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Add(t);
            }
        }
    }
}
