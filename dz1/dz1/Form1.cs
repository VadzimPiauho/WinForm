using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dz1
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
            string message1 = "Name Vadim";
            string message2 = "grupp 22015";
            string message3 = "language C#";
            int count = message1.Length+ message2.Length+ message3.Length;

            MessageBox.Show(message1, "message1", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(message2, "message2", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(message3, $"Число символов {count} число MessageBox {3}", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
