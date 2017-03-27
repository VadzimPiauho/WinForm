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
using System.Xml;
using System.Xml.XPath;

namespace dz2_2
{
    public partial class Form1 : Form
    {
        const string myReg1 = @"^\b[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,6}\b";
        string nameFile = "name.txt";
        string nameFileXml = "name.xml";


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
                    buttonClear_Click(sender, e);
                }
            }
            else
            {
                empty_fild(sender, e);
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
                //MessageBox.Show("Файл успешно обновлен", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var res = MessageBox.Show("Заменить существующий файл?", "Инфо", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes==res)
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
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
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
                string str = Convert.ToString(listBox.Items[listBox.SelectedIndex]);
                str = str.Replace("\t\t", "\t");
                String[] substrings = str.Split('\t');
                //listBox.Items.Add(listBox.Items[listBox.SelectedIndex]);
                textBoxFirst.Text= substrings[0];
                textBoxLast.Text = substrings[1];
                textBoxMail.Text = substrings[2];
                textBoxPhone.Text = substrings[3];

            }
        }

        private void xml_Changed(object sender, EventArgs e)
        {
            if (listBox.Items.Count != 0)
            {
                XmlTextWriter user = null;
                try
                {
                    user = new XmlTextWriter(nameFileXml, System.Text.Encoding.Unicode);
                    user.Formatting = Formatting.Indented;
                    user.WriteStartDocument();
                    user.WriteStartElement("userList");
                    for (var i = 0; i < listBox.Items.Count; i++)
                    {
                        string str = Convert.ToString(listBox.Items[i]);
                        str = str.Replace("\t\t", "\t");
                        String[] substrings = str.Split('\t');
                        user.WriteStartElement($"user");
                        user.WriteElementString($"user{i}", Convert.ToString(listBox.Items[i]));
                        //user.WriteElementString("textBoxFirst", substrings[0]);
                        //user.WriteElementString("textBoxLast", substrings[1]);
                        //user.WriteElementString("textBoxMail", substrings[2]);
                        //user.WriteElementString("textBoxPhone", substrings[3]);
                        user.WriteEndElement();
                    }
                    user.WriteEndElement();
                }
                finally
                {
                    if (user != null)
                        user.Close();
                    MessageBox.Show("Данные внесены в файл", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("listBox - пуст, файл не обновлен", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }

        private void empty_fild(object sender, EventArgs e)
        {
            if (textBoxFirst.Text == "")
            {
                MessageBox.Show("Заполните имя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (this.listBox.SelectedIndex >= 0)
            {
                if (textBoxFirst.Text != "" && textBoxLast.Text != "" && textBoxMail.Text != "" && textBoxPhone.Text != "")
                {
                    Regex regex = new Regex(myReg1);

                    if (!regex.IsMatch(textBoxMail.Text))
                    {
                        MessageBox.Show("Адрес электронной почты введен некорректно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxMail.Focus();
                    }
                    else
                    {
                        listBox.Items[listBox.SelectedIndex] = ($"{textBoxFirst.Text}\t\t{textBoxLast.Text}\t\t{textBoxMail.Text}\t\t{textBoxPhone.Text}");
                        textBoxFirst.Focus();
                        buttonClear_Click(sender, e);
                    }
                }
                else
                {
                    empty_fild(sender,e);
                }
            }
            else
            {
                MessageBox.Show("Выберите данные для изменения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!File.Exists(nameFileXml))
            {
                MessageBox.Show("Файла не существует.Файл успешно создан в каталоге Debug", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FileStream fs1 = File.Create(nameFileXml);
                fs1.Close();
                xml_Changed(sender, e);
            }
            else
            {
                var res = MessageBox.Show("Заменить существующий файл?", "Инфо", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == res)
                {
                    xml_Changed(sender, e);                    
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
            if (!File.Exists(nameFileXml))
            {
                MessageBox.Show("Файла не существует", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                using (StreamReader sr = File.OpenText(nameFileXml))
                {
                    var i = 0;
                    var fi = new FileInfo(nameFileXml);
                    if (fi.Length == 0)
                    {
                        MessageBox.Show("Файл пуст.", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        XPathDocument doc = new XPathDocument(nameFileXml);
                        XPathNavigator nav = doc.CreateNavigator();
                        XPathNodeIterator iterator = nav.Select("/userList/user");
                        int x = iterator.Count;
                        string s = "";
                        while (iterator.MoveNext())
                        {
                            XPathNodeIterator it = iterator.Current.Select($"user{i}");
                            i++;
                            it.MoveNext();
                            s= it.Current.Value;
                            listBox.Items.Add(s);
                        }
                    }
                }
            }
        }
    }
}