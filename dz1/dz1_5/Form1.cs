using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dz1_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Text = CoordinatesToString(e);
     
            if ((e.X >=label1.Left-30 && e.X <= label1.Left+label1.Width+30)  &&
               (e.Y>=label1.Top-30 && e.Y<=label1.Top + label1.Height+30) )
            {

                label1.Left = new Random().Next(0, this.Width);
                label1.Top = new Random().Next(0, this.Height);
                //if (e.X>=label1.Left+label1.Width/2)
                //{
                //    label1.Left = label1.Left-5;
                //}
                //else
                //{
                //    label1.Left = label1.Left + 5;
                //}  
            }

        }
        private string CoordinatesToString(MouseEventArgs e)
        {
            return "Координаты мыши: х=" + e.X.ToString() + "; y=" + e.Y.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Left = new Random().Next(0, this.Width);
            label1.Top = new Random().Next(0, this.Height);
            //label1.Location = new Point(new Random().Next(0, this.Width-label1.Width), new Random().Next(0, this.Height-label1.Height));
        }
    }
}
