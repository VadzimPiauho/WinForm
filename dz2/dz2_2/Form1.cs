using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dz2_2
{
    public partial class Form1 : Form
    {
        const string myReg1 = @"^\b[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,6}\b";
        string nameFile = "name.txt";

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
                Regex regex = new Regex(myReg1);

                if (!regex.IsMatch(textBoxMail.Text))
                {
                    MessageBox.Show("Адрес электронной почты введен некорректно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxMail.Focus();
                }
                else
                {
                    listBox.Items.Add($"{textBoxFirst.Text}\t\t{textBoxLast.Text}\t\t{textBoxMail.Text}\t\t{textBoxPhone.Text}");
                    textBoxFirst.Focus();
                    //textBoxFirst.Clear();
                    //textBoxLast.Clear();
                    //textBoxMail.Clear();
                    //textBoxPhone.Clear();
                    buttonClear_Click(sender, e);
                }
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

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxFirst.Clear();
            textBoxLast.Clear();
            textBoxMail.Clear();
            textBoxPhone.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!File.Exists(nameFile))
            {
                MessageBox.Show("Файла не существует.Файл успешно создан в каталоге Debug", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FileStream fs1 = File.Create(nameFile);
                fs1.Close();
                using (StreamWriter sw = File.CreateText(nameFile))
                {
                    for (var i = 0; i < listBox.Items.Count; i++)
                    {
                        sw.WriteLine($"{listBox.Items[i]}");
                    }
                }
                MessageBox.Show("Файл успешно обновлен", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                using (StreamWriter sw = File.CreateText(nameFile))
                {
                    for (var i = 0; i < listBox.Items.Count; i++)
                    {
                            sw.WriteLine($"{listBox.Items[i]}");
                    }
                }
                MessageBox.Show("Файл успешно обновлен", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!File.Exists(nameFile))
            {
                MessageBox.Show("Файла не существует", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FileStream fs1 = File.Create(nameFile);
                fs1.Close();
                MessageBox.Show("Пустой файл успешно создан в каталоге Debug", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                using (StreamReader sr = File.OpenText(nameFile))
                {
                    //textBox1.Text = sr.ReadToEnd();
                    var fi = new FileInfo(nameFile);
                    if (fi.Length == 0)
                    {
                        MessageBox.Show("Файл пуст.", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        string s = "";
                        while ((s = sr.ReadLine()) != null)
                        {
                            listBox.Items.Add(s);
                        }
                    }
                }
            }
        }

        private void textBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listBox.SelectedIndex >= 0)
            {
                listBox.Items.Add(listBox.Items[listBox.SelectedIndex]);
            }
        }
    }
}
