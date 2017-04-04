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

namespace dz4_2
{
    public partial class Form1 : Form
    {
        List<string> path = new List<string>();
        int indexPath = -1;
        public Form1()
        {
            InitializeComponent();
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo d in allDrives)
            {
                listBox1.Items.Add(d);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ListBox)sender).SelectedIndex > -1)
            {
                this.Text = ((ListBox)sender).Items[((ListBox)sender).SelectedIndex].ToString();
            }
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {

                String mypath = listBox1.Items[listBox1.SelectedIndex].ToString();
                path.Add(mypath);
                indexPath++;
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                String[] files = Directory.GetFiles(mypath);
                String[] dir = Directory.GetDirectories(mypath);
                foreach (var file in files)
                {
                    listBox2.Items.Add(file);
                    //listBox2.Items.Add(Path.GetFileName(file));
                }

                foreach (var d in dir)
                {
                    listBox1.Items.Add(d);
                    //listBox2.Items.Add(Path.GetFileName(d));
                }

                //Directory
                //    .GetFiles(mypath, "*", SearchOption.AllDirectories)
                //    .ToList()
                //    .ForEach(f => listBox1.Items.Add(Path.GetFileName(f)));
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            indexPath--;
            if (indexPath > 0)
            {
                String mypath = path[indexPath];
                path.Remove(path[indexPath + 1]);
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                String[] files = Directory.GetFiles(mypath);
                String[] dir = Directory.GetDirectories(mypath);
                foreach (var file in files)
                {
                    listBox2.Items.Add(file);
                    //listBox2.Items.Add(Path.GetFileName(file));
                }

                foreach (var d in dir)
                {
                    listBox1.Items.Add(d);
                    //listBox1.Items.Add(Path.GetFileName(d));
                }
            }
            else
            {
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                DriveInfo[] allDrives = DriveInfo.GetDrives();
                foreach (DriveInfo d in allDrives)
                {
                    listBox1.Items.Add(d);
                }
            }
        }
    }
}
