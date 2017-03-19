using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dz1_4
{
    public partial class Form1 : Form
    {
        int count = 1;
        int oldX;
        int oldY;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        //private void Form1_MouseClick(object sender, MouseEventArgs e)
        //{
        //    //определим какую кнопку мыши нажал пользователь
        //    String message = "";
        //    if (e.Button == MouseButtons.Right)
        //    {
        //        message = "Вы нажали правую кнопку мыши.";
        //        this.Text = "Высота Y =" + this.Height.ToString() + "; Ширина X =" + this.Width.ToString();
        //    }
        //    if (e.Button == MouseButtons.Left)
        //    {
        //        if (Control.ModifierKeys == Keys.Control)
        //        {
        //            this.Close();
        //        }
        //        else
        //        {
        //            if (e.X > 0 && e.X < 50 || e.Y > 0 && e.Y < 50)
        //            {
        //                message = "Вы нажали левую кнопку мыши снаружи";
        //            }
        //            if (e.X > this.Width - 50 && e.X < this.Width || e.Y > this.Height - 50 && e.Y < this.Height)
        //            {
        //                message = "Вы нажали левую кнопку мыши снаружи";
        //            }
        //            if ((e.X > 50 && e.X < this.Width - 50) && (e.Y > 50 && e.Y < this.Height - 50))
        //            {
        //                message = "Вы нажали левую кнопку мыши внутри";
        //            }
        //            if (e.Y == 50 || e.Y == this.Height - 50 || e.X == 50 || e.X == this.Width - 50)
        //            {
        //                message = "Вы нажали левую кнопку мыши на границе";
        //            }

        //        }
        //    }

        //    //выведем сообщение в диалоговое окно
        //    String caption = "Клик мыши";
        //    MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            
            

        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Clicks == 1)
            {
                oldX = e.X;
                oldY = e.Y;

            }
            if (e.Button == MouseButtons.Left && e.Clicks == 2)
            {
                //=================================
                // создаем объект класса Label
                Label m_label = new Label();
                // задаём позицию надписи относительно будущего родителя
                m_label.Location = new Point(e.X - oldX, e.Y - oldY);
                // задаем размер надписи
                m_label.Size = new Size(100, 100);
                // задаем текст надписи
                m_label.Text = $"{count}";
                m_label.ForeColor = Color.Red;

                // добавляем статический текст в коллекцию элементов формы
                this.Controls.Add(m_label);
                //===============================

            }
        }
    }
}
