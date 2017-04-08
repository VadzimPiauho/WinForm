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

namespace dz5_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.richTextBox1.AllowDrop = true;
           // this.richTextBox1.DragEnter += new DragEventHandler(richTextBox1_DragEnter);
            this.richTextBox1.DragDrop += new DragEventHandler(richTextBox1_DragDrop);

        }

        private void richTextBox1_DragDrop(object sender, DragEventArgs e)
        {
            //richTextBox1.Text = (string)e.Data.GetData(DataFormats.FileDrop);
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {

                string[] files = e.Data.GetData(DataFormats.FileDrop) as string[];
                richTextBox1.Text = (string)e.Data.GetData(DataFormats.FileDrop);
                if (files != null)
                {
                    foreach (var item in files)
                    {

                        try
                        {
                            richTextBox1.AppendText(File.ReadAllText(item) + "\n\n");
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }
                    }

                }
            }
        }
    

        private void richTextBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            textBox1.DoDragDrop(textBox1.Text, DragDropEffects.Copy);
        }
    }
}
