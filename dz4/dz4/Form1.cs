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

namespace dz4
{
    public partial class Form1 : Form
    {
        OpenFileDialog openFile;
        SaveFileDialog saveFile;
        DialogResult resDialog;

        public Form1()
        {
            InitializeComponent();
        }



        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            openFile = new OpenFileDialog();
            openFile.Filter = "TXT Files (txt,doc)|*.txt;*.doc";
            resDialog = openFile.ShowDialog();
            if (resDialog == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFile.FileName);
                textBox1.Clear();
                textBox1.Text = sr.ReadToEnd();
                sr.Close();
            }
            if (resDialog == DialogResult.Cancel)
            {
                openFile = null;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

            if (openFile != null)
            {
                StreamWriter w = new StreamWriter(openFile.FileName);
                w.WriteLine(textBox1.Text);
                w.Close();
            }
            else
            {
                MessageBox.Show("Файл не открыт");
            }
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile = new SaveFileDialog();
            resDialog = saveFile.ShowDialog();
            if (resDialog == DialogResult.OK)
            {
                StreamWriter w = new StreamWriter(openFile.FileName);
                w.WriteLine(textBox1.Text);
                w.Close();
            }
            if (resDialog == DialogResult.Cancel)
            {
                saveFile = null;
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            saveFile = new SaveFileDialog();
            openFile = new OpenFileDialog();
            saveFile.Filter = "TXT Files (txt,doc)|*.txt;*.doc";
            resDialog = saveFile.ShowDialog();
            if (resDialog == DialogResult.OK)
            {
                if (!File.Exists(saveFile.FileName))
                {
                    FileStream fs1 = File.Create(saveFile.FileName);
                    fs1.Close();
                    openFile.FileName = saveFile.FileName;
                    //openFile.OpenFile();
                }
            }
            if (resDialog == DialogResult.Cancel)
            {
                saveFile = null;
                saveFile = null;
            }
        }

        private void выделитьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="")
            {
                textBox1.SelectAll();
            }
            else
            {
                MessageBox.Show("Пусто");
            }
        }
    }
}
