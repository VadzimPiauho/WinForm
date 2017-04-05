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

namespace dz5
{

    public partial class Form1 : Form
    {
        TreeNode tn;
        DirectoryInfo di;
        public Form1()
        {

            InitializeComponent();
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            try
            {
                foreach (DriveInfo drive in DriveInfo.GetDrives())
                {
                    string[] root = System.IO.Directory.GetDirectories(Convert.ToString(/*allDrives[1]*/ drive));
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
                            BuildTree(di, treeView1.Nodes);
                        }
                        catch
                        {
                        }
                    }
                }
                else
                {
                    di = new DirectoryInfo(Convert.ToString(/*Convert.ToString(allDrives[1])*/drive));
                    BuildTree(di, treeView1.Nodes);
                }
                //tn = new TreeNode(Convert.ToString(drive));
                //treeView1.Nodes.Add(tn);
                }
            }
            catch (Exception)
            {
            }
        }

        private void BuildTree(DirectoryInfo directoryInfo, TreeNodeCollection addInMe)
        {
            //Добавляем новый узел в коллекцию Nodes
            //с именем текущей директории и указанием ключа 
            //со значением "Folder".
            TreeNode curNode = addInMe.Add("Folder", directoryInfo.Name);

            //addInMe.Add(directoryInfo.FullName, directoryInfo.Name, 
            //тут можно указать номер картинки для узла из imageCollection);

            //Перебираем папки.
            foreach (DirectoryInfo subdir in directoryInfo.GetDirectories())
            {
                //Запускам процесс получения папок и фалов 
                //с текущей найденной директории.
                BuildTree(subdir, curNode.Nodes);
            }

            //Перебираем файлы
            foreach (FileInfo file in directoryInfo.GetFiles())
            {
                //Добавляем новый узел в коллекцию Nodes
                //С именем текущей директории и указанием ключа 
                //со значением "File".
                curNode.Nodes.Add("File", file.Name);

                //curNode.Nodes.Add("File", file.Name, 
                //тут можно указать номер картинки для узла из imageCollection);  
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
