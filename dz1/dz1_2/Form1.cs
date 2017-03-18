using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dz1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            bool go = true;
            int countTiket = 1;
            while (go)
            {
                var result = MessageBox.Show($"Число угадано {new Random ().Next(1,2000)}", "Угадайка", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show($"Число необходимых запросов {countTiket}", "Число угадано", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    result  = MessageBox.Show("Играем еще раз", "Next Games", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        countTiket = 1;
                    }
                    if (result == DialogResult.No)
                    {
                        go = false;
                    }
                }
                if (result == DialogResult.No)
                {
                    countTiket++;
                }
            }
        }
    }
}
