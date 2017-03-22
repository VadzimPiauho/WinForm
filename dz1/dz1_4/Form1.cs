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
        int LabelWidth;
        int LabelHeight;
        string LabelName;
        int LabelTxt = 0;
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

            //Text = "Координаты мыши: х=" + (e.X+this.Left).ToString() + "; y=" + e.Y.ToString();
            var borderVert = SystemInformation.VerticalResizeBorderThickness;
            var borderCapt = SystemInformation.CaptionHeight;
            var borderHoriz = SystemInformation.HorizontalResizeBorderThickness;
            //Text ="Координаты мыши: х=" + (MousePosition.X).ToString() + "; y=" + (MousePosition.Y).ToString();
            //Text ="Координаты мыши: х=" + (Cursor.Position.X - this.Location.X - borderVert).ToString() + "; y=" + (Cursor.Position.Y - this.Location.Y - borderCapt - borderHoriz).ToString();
            //return "Координаты мыши: х=" + e.X.ToString() + "; y=" + e.Y.ToString();
        }

         

        private void Form1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Right)
            {
               
                foreach (Control c in Controls)
                {
                    if (c.GetType() == typeof(Label))
                    {
                        Point location = c.PointToScreen(Point.Empty);
                        
                        if (MousePosition.X>= location.X && MousePosition.Y>= location.Y && MousePosition.X<= location.X + c.Width && MousePosition.Y<= location.Y + c.Height)
                        {
                            if ((Int32.Parse( c.Text)> LabelTxt))
                            {
                                LabelWidth = ((Label)c).Width;
                                LabelHeight = ((Label)c).Height;
                                LabelName = ((Label)c).Text;
                                oldX = ((Label)c).Location.X;
                                oldY = ((Label)c).Location.Y;
                                LabelTxt = Int32.Parse(c.Text);
                            }
                        }
                    }
                }
                if (Controls.Count == 0|| LabelTxt==0)
                {
                    MessageBox.Show("Нет контролов");
                }
                Text = $"Площадь {LabelWidth * LabelHeight} Х = {oldX} Y = {oldY} номер {LabelName}";
                LabelTxt = 0;
                //Text = $"Площадь {WiewDelControl.Width* WiewDelControl.Height} Х = {WiewDelControl.Location.X} Y = {WiewDelControl.Location.Y}";
                //WiewDelControl.Text = "0";
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                oldX = e.X;
                oldY = e.Y;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left&&(oldY!=0|| oldX!=0))
            {
                Label m_label = new Label();
                m_label.AutoSize = false;
                m_label.BorderStyle = BorderStyle.Fixed3D;
                // задаём позицию надписи относительно будущего родителя
                if (e.X>oldX&&e.Y>oldY)
                {
                    m_label.Location = new Point(oldX, oldY);
                }
                if (e.X > oldX && e.Y < oldY)
                {
                    m_label.Location = new Point(oldX, e.Y);
                }
                if (e.X < oldX && e.Y < oldY)
                {
                    m_label.Location = new Point(e.X, e.Y);
                }
                if (e.X < oldX && e.Y > oldY)
                {
                    m_label.Location = new Point(e.X, oldY);
                }

                if (Math.Abs(e.X - oldX)<10|| Math.Abs(e.Y - oldY)<10)
                {
                    MessageBox.Show("Невозможно создать статик меньше чем 10х10");
                }
                else
                {
                    // задаем размер надписи
                    m_label.Size = new Size(Math.Abs(e.X - oldX), Math.Abs(e.Y - oldY));
                    // задаем текст надписи
                    m_label.Text = $"{count}";
                    m_label.ForeColor = Color.Red;
                    count++;
                    // добавляем статический текст в коллекцию элементов формы
                    this.Controls.Add(m_label);
                    m_label.MouseClick += Form1_MouseClick;
                    m_label.MouseMove += Form1_MouseMove;
                    //===============================
                }
            }
            else
            {
                MessageBox.Show("Для создания контрола нажмите левую клавишу");
            }
        }
    }
}