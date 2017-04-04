using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dz4_3
{
    public partial class Form1 : Form
    {
        MenuStrip m = new MenuStrip();
        ToolStripMenuItem TopMenu;
        bool control = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TopLevelMenu.Text != "")
            {
                TopMenu = (ToolStripMenuItem)m.Items.Add(TopLevelMenu.Text);
                this.Controls.Add(m);
                //TopLevelMenu.Text
            }
            else
            {
                MessageBox.Show("Введите название пункта меню");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (SubItem.Text != "")
            {
                foreach (Control c in Controls)
                {
                    if (c.GetType() == typeof(MenuStrip))
                    {
                        foreach (var item in ((MenuStrip)c).Items)
                        {
                            TopMenu = (ToolStripMenuItem)item;
                            if (TopMenu.Text == TopLevelMenu.Text)
                            {
                                //добавляем выпадающее меню для пункта
                                TopMenu.DropDownItems.Add(SubItem.Text);
                                //добавляем сепаратор
                                TopMenu.DropDownItems.Add(new ToolStripSeparator());
                                control = true;
                            }
                        }
                    }
                }
            }
            if (control == false)
            {
                MessageBox.Show("Меню не найдено");
            }
            control = false;
        }
    }
}