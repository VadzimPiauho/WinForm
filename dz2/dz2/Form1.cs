﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dz2
{
    public partial class Form1 : Form
    {
        string nameFile = "Day17.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!File.Exists(nameFile))
            {
                MessageBox.Show("Файла не существует", "Инфо",MessageBoxButtons.OK,MessageBoxIcon.Information);
                FileStream fs1 = File.Create(nameFile);
                fs1.Close();
                MessageBox.Show("Файл успешно создан в каталоге Debug", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                using (StreamReader sr = File.OpenText(nameFile))
                {
                    textBox1.Text = sr.ReadToEnd();
                    var fi = new FileInfo(nameFile);
                    if (fi.Length==0)
                    {
                        MessageBox.Show("Файл пуст. Введите текст в textBox", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    //string s = "";
                    //while ((s = sr.ReadLine()) != null)
                    //{
                    //    textBox1.Text += s;
                    //    textBox1.Text += Environment.NewLine;
                    //}
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!File.Exists(nameFile))
            {
                MessageBox.Show("Файла не существует", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FileStream fs1 = File.Create(nameFile);
                fs1.Close();
                MessageBox.Show("Файл успешно создан в каталоге Debug", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                using (StreamWriter sw = File.CreateText(nameFile))
                {
                    if (textBox1.Text!="")
                    {
                        sw.WriteLine($"{textBox1.Text}");
                    }
                }
            }
        }
    }
}
