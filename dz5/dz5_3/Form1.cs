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
            richTextBox1.AllowDrop = true;
            richTextBox1.DragEnter += new DragEventHandler(richTextBox1_DragEnter);
            richTextBox1.DragDrop += new DragEventHandler(richTextBox1_DragDrop);

        }

        private void richTextBox1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Effect == DragDropEffects.Copy)
            {
                string[] files = e.Data.GetData("FileDrop") as string[];
                if (files != null)
                    foreach (string file in files)
                        textBox1.Text += file + "\r\n";
            }
        }

        private void richTextBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("FileDrop"))
                e.Effect = DragDropEffects.Copy;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
