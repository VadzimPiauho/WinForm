using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dz5_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "NotePad";
            richTextBox1.AllowDrop = true;
            richTextBox1.DragEnter += new DragEventHandler(richTextBox1_DragEnter);
            richTextBox1.DragDrop += new DragEventHandler(richTextBox1_DragDrop);
            richTextBox1.AllowDrop = true;
            

        }

        private void richTextBox1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Effect == DragDropEffects.Copy)
            {
                //string[] files = e.Data.GetData("FileDrop") as string[];
                //if (files != null)
                //    foreach (string file in files)
                //        textBox1.Text += file + "\r\n";
                if (e.Data.GetDataPresent(DataFormats.FileDrop) &&
                    ((e.AllowedEffect & DragDropEffects.Move) == DragDropEffects.Move))
                {
                    string[] objects = (string[])e.Data.GetData(DataFormats.FileDrop);
                    // В objects хранятся пути к папкам и файлам 
                    richTextBox1.Text = "";
                    for (int i = 0; i < objects.Length; i++)
                        richTextBox1.Text += objects[i] + "\r\n";
                }
                else
                    e.Effect = DragDropEffects.None;
            }
        }

        private void richTextBox1_DragEnter(object sender, DragEventArgs e)
        {
            //if (e.Data.GetDataPresent("FileDrop"))
            //    e.Effect = DragDropEffects.Copy;
            if (e.Data.GetDataPresent(DataFormats.FileDrop) &&
                ((e.AllowedEffect & DragDropEffects.Move) == DragDropEffects.Move))
                e.Effect = DragDropEffects.Move;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
