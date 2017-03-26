using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dz2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDell_Click(object sender, EventArgs e)
        {
            if (this.listBox.SelectedIndex>=0)
            {
                this.listBox.Items.RemoveAt(this.listBox.SelectedIndex);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxFirst.Text!=""&& textBoxLast.Text != ""&& textBoxMail.Text != ""&& textBoxPhone.Text != "")
            {
                listBox.Items.Add(textBoxFirst.Text);
                listBox.Items.Add(textBoxLast.Text);
                listBox.Items.Add(textBoxMail.Text);
                listBox.Items.Add(textBoxPhone.Text);
                textBoxFirst.Focus();
                textBoxFirst.Clear();
                textBoxLast.Focus();
                textBoxLast.Clear();
                textBoxMail.Focus();
                textBoxMail.Clear();
                textBoxPhone.Focus();
                textBoxPhone.Clear();
            }
            else
            {
                if (textBoxFirst.Text == "")
                {
                    MessageBox.Show("Заполните имя","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    textBoxFirst.Focus();
                }
                if (textBoxLast.Text == "")
                {
                    MessageBox.Show("Заполните фамилию", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxLast.Focus();
                }
                if (textBoxMail.Text == "")
                {
                    MessageBox.Show("Заполните почту", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxMail.Focus();
                }
                if (textBoxPhone.Text == "")
                {
                    MessageBox.Show("Заполните телефон", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxPhone.Focus();
                }
            }
        }
    }
}
