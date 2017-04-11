using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Permissions;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dz5_4
{
    public partial class Form1 : Form
    {
        DirectoryInfo di;
        public Form1()
        {
            InitializeComponent();

            FolderBrowserDialog fbd = new FolderBrowserDialog();

            DriveInfo[] allDrives = DriveInfo.GetDrives();
            //if (fbd.ShowDialog() == DialogResult.OK)
            //{
            treeView1.BeginUpdate();
            try
            {
                foreach (DriveInfo drive in allDrives)
                {
                    string[] root = Directory.GetDirectories(Convert.ToString(/*allDrives[1] */drive));
                    //string[] root = Directory.GetDirectories(fbd.SelectedPath);
                    if (root.Rank > 1)
                    {
                        //Проходим по всем полученным подкаталогам.
                        foreach (string s in root)
                        {
                            try
                            {
                                //Заносим в переменную информацию
                                //о текущей директории.
                                di = new DirectoryInfo(s);
                                //Вызов метода сканирования с
                                //передачей в качестве параметра, информации
                                //о текущей директории и объект 
                                //System.Windows.Forms.TreeNodeCollection,
                                //который предоставляет узлы
                                //дерева, назначенные элементу управления 
                                //иерархического представления.
                                BuildTree(di.FullName, treeView1.Nodes);
                            }
                            catch (Exception e)
                            {
                                MessageBox.Show(e.Message);
                            }
                        }
                    }
                    else
                    {
                        //di = new DirectoryInfo(fbd.SelectedPath);
                        di = new DirectoryInfo(Convert.ToString(/*Convert.ToString(allDrives[1])*/drive));
                        BuildTree(di.FullName, treeView1.Nodes);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            //Разрешаем перерисовку иерархического представления.
            treeView1.EndUpdate();
            //}


        }

        private void BuildTree(string directoryInfo, TreeNodeCollection addInMe)
        {
            //Добавляем новый узел в коллекцию Nodes
            //с именем текущей директории и указанием ключа 
            //со значением "Folder".
            try
            {
                TreeNode curNode = addInMe.Add("Folder", directoryInfo);

                string[] root = Directory.GetDirectories(directoryInfo);
                //addInMe.Add(directoryInfo.FullName, directoryInfo.Name, 
                //тут можно указать номер картинки для узла из imageCollection);

                //Перебираем папки.
                foreach (var subdir in root)
                {
                    //DirectoryInfo dir = new DirectoryInfo(subdir);
                    // var ds = dir.GetAccessControl();
                    //foreach (FileSystemAccessRule item in ds.GetAccessRules(true, true, typeof(NTAccount)))
                    //{
                    //    if (item.AccessControlType == AccessControlType.Deny)
                    //    {

                    //    }
                    //}

                    //if (new FileInfo(subdir).IsReadOnly == true)
                    //{
                    //    continue;
                    //}

                    //if ((subdir.Contains("$") || subdir.Contains("Document") || subdir.Contains("Cach") || subdir.Contains("Policy") || subdir.Contains("Crash") || subdir.Contains("Application") || subdir.Contains("Desktop") || subdir.Contains("Favorites") || subdir.Contains("Microsoft") || subdir.Contains("Data") || subdir.Contains("System") || subdir.Contains("Start") || subdir.Contains("Symantec") || subdir.Contains("User") || subdir.Contains("Windows") || subdir.Contains("Config") || subdir.Contains("inetpub") || subdir.Contains("microsoft") || subdir.Contains("Recovery")) == true)
                    //{
                    //    continue;
                    //}

                    //Запускам процесс получения папок и фалов 
                    //с текущей найденной директории.
                    BuildTree(subdir, curNode.Nodes);
                }
                string[] rootFile = Directory.GetFiles(directoryInfo);
                //Перебираем файлы
                foreach (var file in rootFile)
                {

                    //Добавляем новый узел в коллекцию Nodes
                    //С именем текущей директории и указанием ключа 
                    //со значением "File".
                    curNode.Nodes.Add("File", file);

                    //curNode.Nodes.Add("File", file.Name, 
                    //тут можно указать номер картинки для узла из imageCollection);  
                }
            }
            catch
            {


            }
            
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {


        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode.FullPath != null)
            {
                string n = treeView1.SelectedNode.Text;
                ListViewItem liv;
                //string[] root = Directory.GetDirectories(n);
                //string[] rootFile = Directory.GetFiles(n);
                if (File.Exists(n))
                {
                    FileInfo fl = new FileInfo(n);
                    liv = new ListViewItem(fl.CreationTime.ToString());
                    liv.SubItems.Add(fl.Name);
                    liv.SubItems.Add(fl.Length.ToString());
                    liv.SubItems.Add("File");
                    liv.SubItems.Add("1");
                    liv.SubItems.Add(File.GetAttributes(n).ToString());
                    listView1.Items.Add(liv);
                }
                else if (System.IO.Directory.Exists(n))
                {
                    long Size = 0;
                    DirectoryInfo fl = new DirectoryInfo(n);
                    liv = new ListViewItem(fl.CreationTime.ToString());
                    liv.SubItems.Add(fl.Name);
                    //DirectoryInfo[] dis = fl.GetDirectories();
                    //foreach (DirectoryInfo di in dis)
                    //{
                    //    Size = DirSize(di, Size);
                    //}
                    liv.SubItems.Add("---");
                    liv.SubItems.Add("Directory");
                    liv.SubItems.Add((fl.GetFiles().Length + fl.GetDirectories().Length).ToString());
                    liv.SubItems.Add(File.GetAttributes(n).ToString());
                    listView1.Items.Add(liv);
                }
            }
        }
        public static long DirSize(DirectoryInfo d, long Size)
        {
            // Add file sizes.
            FileInfo[] fis = d.GetFiles();
            foreach (FileInfo fi in fis)
            {
                Size += fi.Length;
            }
            return Size;

        }
    }
}
