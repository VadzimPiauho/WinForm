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

namespace dz3_1
{
    public partial class Form2 : Form
    {
        public Form2(int count)
        {
            InitializeComponent();
            this.Text = $"Форма {count}";
        }
        

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="")
            {
                MessageBox.Show("Маска поиска пуста", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            FolderBrowserDialog BrowserDial = new FolderBrowserDialog();
            
            if (BrowserDial.ShowDialog()==DialogResult.OK)
            {
                string[] allFoundFiles = Directory.GetFiles(BrowserDial.SelectedPath, textBox1.Text, SearchOption.AllDirectories);

                if (allFoundFiles.Length == 0)
                {
                    MessageBox.Show("Файлов не найдено", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    foreach (string file in allFoundFiles)
                    {
                        listBox1.Items.Add(file);
                    }
                }
            }
            
            
            
        }
    }
}
