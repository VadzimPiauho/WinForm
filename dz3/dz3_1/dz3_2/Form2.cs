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
    public partial class Form2 : Form
    {
        Tovar t;
        bool addnew;

        public Form2 (Tovar t, bool addnew)
        {
            InitializeComponent();
            this.addnew = addnew;
            this.t = t;//Запомнили ссылку на товар
            if (addnew == false)
            {
                textBox1.Text = t.Name;
                textBox3.Text = t.Opisanie;
                textBox2.Text = t.Price.ToString();
                this.Text = "Редактирование товара";
            }
            else this.Text = "Добавление товара";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" ||textBox3.Text == "")
            {
                MessageBox.Show("Заполните все поля");
                return;
            }
            if (t == null) t = new Tovar();
            t.Name = textBox1.Text;
            t.Opisanie = textBox3.Text;
            try
            {
                t.Price = Convert.ToDouble(textBox2.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Цена указана неверно");
                return;
            }
            this.DialogResult = DialogResult.OK;
        }
        //public string TTxt
        //{
        //    get
        //    {
        //        return $"{textBox1.Text} {textBox2.Text} {textBox3.Text}";
        //    }
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
