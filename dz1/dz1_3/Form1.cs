using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dz1_3
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
        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {       
            //отображение текущих координат мыши в заголовке окна
            Text = CoordinatesToString(e);
        }
        private string CoordinatesToString(MouseEventArgs e)
        {
            return "Координаты мыши: х=" + e.X.ToString() + "; y=" + e.Y.ToString();
        }

        // обработчик события MouseClick
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            //определим какую кнопку мыши нажал пользователь
            String message = "";
            if (e.Button == MouseButtons.Right)
            {
                message = "Вы нажали правую кнопку мыши.";
                this.Text = "Ширина =" + this.Height.ToString() + "; Высота =" + this.Width.ToString();
            }
            if (e.Button == MouseButtons.Left)
            {
                if (Control.ModifierKeys == Keys.Control)
                {
                    this.Close();
                }
                else
                {
                    if (this.Height>0&& this.Height<10|| this.Width>0&& this.Width<10)
                    {
                        message = "Вы нажали левую кнопку мыши снаружи";
                    }
                    if (this.Height > 0 && this.Height < 10 || this.Width > 0 && this.Width < 10)
                    {
                        message = "Вы нажали левую кнопку мыши снаружи";
                    }

                }
            }
            message += "\n" + CoordinatesToString(e);
            //выведем сообщение в диалоговое окно
            String caption = "Клик мыши";
            MessageBox.Show(message, caption, MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            //bool go = true;
            //int countTiket = 1;
            //while (go)
            //{
            //    var result = MessageBox.Show($"Число угадано {new Random().Next(1, 2000)}", "Угадайка", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    if (result == DialogResult.Yes)
            //    {
            //        MessageBox.Show($"Число необходимых запросов {countTiket}", "Число угадано", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        result = MessageBox.Show("Играем еще раз", "Next Games", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //        if (result == DialogResult.Yes)
            //        {
            //            countTiket = 1;
            //        }
            //        if (result == DialogResult.No)
            //        {
            //            go = false;
            //        }
            //    }
            //    if (result == DialogResult.No)
            //    {
            //        countTiket++;
            //    }
            //}
        }
    }
}
