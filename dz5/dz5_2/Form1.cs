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
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                
                try
                {
                    //foreach (DriveInfo drive in allDrives)
                    //{
                    //string[] root = Directory.GetDirectories(Convert.ToString(allDrives[1] /*drive*/), "*.*", SearchOption.TopDirectoryOnly);
                    string[] root = Directory.GetDirectories(fbd.SelectedPath);
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
                                BuildTree(di, listView1);
                            }
                            catch (Exception e)
                            {
                                MessageBox.Show(e.Message);
                            }
                        }
                    }
                    else
                    {
                        di = new DirectoryInfo(fbd.SelectedPath);
                        //di = new DirectoryInfo(Convert.ToString(Convert.ToString(allDrives[1])/*drive*/));
                        BuildTree(di, listView1);
                    }
                    //}
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                listView1.View = View.List;

            }
        }
        private void BuildTree(DirectoryInfo directoryInfo, ListView addInMe)
        {
            
            foreach (DirectoryInfo subdir in directoryInfo.GetDirectories())
            {

                if (FileAttributes.System == (subdir.Attributes & FileAttributes.System) ||
                    FileAttributes.Hidden == (subdir.Attributes & FileAttributes.Hidden))
                {
                    continue;
                }
                var x = subdir.GetAccessControl();
                //Запускам процесс получения папок и фалов 
                //с текущей найденной директории.
                addInMe.Items.Add(subdir.Name);
            }

            //Перебираем файлы
            foreach (FileInfo file in directoryInfo.GetFiles())
            {
                if (FileAttributes.System == (file.Attributes & FileAttributes.System))
                {
                    continue;
                }
                //Добавляем новый узел в коллекцию Nodes
                //С именем текущей директории и указанием ключа 
                //со значением "File".
                addInMe.Items.Add(file.Name);

                //curNode.Nodes.Add("File", file.Name, 
                //тут можно указать номер картинки для узла из imageCollection);  
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
