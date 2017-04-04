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
        string selectText;
        int oldPositionCursor;

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
                this.Text = openFile.FileName;
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
                this.Text = saveFile.FileName;
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
                    this.Text = saveFile.FileName;
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
            if (textBox1.Text != "")
            {
                textBox1.SelectAll();
            }
            else
            {
                MessageBox.Show("Пусто");
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectionLength > 0)
            {
                textBox1.Copy();
            }
            //if (textBox1.SelectedText != "")
            //{
            //    
            //    selectText = textBox1.SelectedText;
            //    
            //}
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
            //oldPositionCursor = textBox1.SelectionStart + textBox1.SelectionLength;
            //textBox1.Text = textBox1.Text.Insert(textBox1.SelectionStart, selectText);
            //textBox1.SelectionStart = oldPositionCursor;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectedText != "")
            {
                textBox1.Cut();
            }
            //if (textBox1.SelectedText != "")
            //{
            //    selectText = textBox1.SelectedText;
            //    oldPositionCursor = textBox1.SelectionStart;
            //    textBox1.Text = textBox1.Text.Remove(textBox1.SelectionStart, textBox1.SelectionLength);
            //    textBox1.SelectionStart = oldPositionCursor;
            //}
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            // Determine if last operation can be undone in text box.
            if (textBox1.CanUndo == true)
            {
                // Undo the last operation.
                textBox1.Undo();
                // Clear the undo buffer to prevent last action from being redone.
                textBox1.ClearUndo();
            }
        }

        private void цвецФонаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.BackColor = colorDialog1.Color;
            }
        }

        private void цветШрифтаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
            }
        }
    }
}
