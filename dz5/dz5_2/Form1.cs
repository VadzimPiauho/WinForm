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

namespace dz5_2
{
    public partial class Form1 : Form
    {
        DirectoryInfo di;
        public Form1()
        {
            InitializeComponent();
            listView1.SetBounds(400, 20, 300, 200);
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //string[] root = Directory.GetDirectories(fbd.SelectedPath);
                    di = new DirectoryInfo(fbd.SelectedPath);
                    Build(di, listView1);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                listView1.View = View.List;
            }
        }
        private void Build(DirectoryInfo directoryInfo, ListView addInMe)
        {
            int i = 0;
            foreach (DirectoryInfo subdir in directoryInfo.GetDirectories())
            {
                if (FileAttributes.System == (subdir.Attributes & FileAttributes.System) ||
                    FileAttributes.Hidden == (subdir.Attributes & FileAttributes.Hidden))
                {
                    continue;
                }
                //imageList1.Images.Add(subdir.Extension, (Icon)Icon.ExtractAssociatedIcon(subdir.FullName));
                var x = subdir.GetAccessControl();
                addInMe.Items.Add(subdir.Name);
                //i++;
            }

            //Перебираем файлы
            foreach (FileInfo file in directoryInfo.GetFiles())
            {
                if (FileAttributes.System == (file.Attributes & FileAttributes.System))
                {
                    continue;
                }
                imageList1.Images.Add(file.Extension, (Icon)Icon.ExtractAssociatedIcon(file.FullName));
                addInMe.Items.Add(file.Name, i);
                i++;
                //addInMe.Items.Add("File", file.Name, 
                //тут можно указать номер картинки для узла из imageCollection);  
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void largeIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void smallIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }

        private void tileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.Tile;
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.List;
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }
    }
}
