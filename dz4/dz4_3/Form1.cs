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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (SubItem.Text != "")
            {
                //добавляем выпадающее меню для пункта
                TopMenu.DropDownItems.Add(SubItem.Text);
                //добавляем сепаратор
                TopMenu.DropDownItems.Add(new ToolStripSeparator());
            }
        }
    }
}
