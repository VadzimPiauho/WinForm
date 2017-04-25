using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WpfCustomControlLibraryTemp;


namespace dz6
{
    public partial class Form1 : Form
    {
        protected ChessGame GameController { get; set; }
        public Form1()
        {
            InitializeComponent();
            GameController = new ChessGame();
            GameController.StartGame();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            var api = new FigureDrawer(e.Graphics);
            GameController.AllFigures.ForEach(f => f.Draw(api));
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            var calc = new FigurePositionCalculator();
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                var result = calc.GetCellByPoint(e.X, e.Y);
                if (result.HasValue)
                {
                    MessageBox.Show(string.Format("{0} - {1}. Letter {2}", e.X, e.Y,
                        result.Value.Letter));
                }
                else
                {
                    MessageBox.Show(string.Format("{0} - {1}", e.X, e.Y));
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }

    public class ChessGame
    {
        public List<Figure> AllFigures = new List<Figure>();

        public void StartGame()
        {
            AllFigures = new List<Figure>{
                new Figure(){FigureType = FigureType.Ladia, CurrentCell = new ChessCell(){Letter=ChessLetter.A, Number=1}},
                new Figure(){FigureType = FigureType.Kon, CurrentCell = new ChessCell(){Letter=ChessLetter.A, Number=2}}
            };
        }
    }

    public class Figure
    {
        public ChessCell? CurrentCell { get; set; }

        public FigureType FigureType { get; set; }

        public void Draw(FigureDrawer api)
        {
            api.DrawFigure(this);
        }
    }

    public enum FigureType
    {
        Ladia = 0,
        Kon = 1
    }

    public class FigureDrawer
    {
        protected Graphics CurrentGraphics { get; set; }

        public FigureDrawer(Graphics gdi)
        {
            CurrentGraphics = gdi;
        }

        public void DrawFigure(Figure figure)
        {
            CurrentGraphics.DrawImage(GetImageByChessType(figure.FigureType),
                0, (figure.CurrentCell.Value.Number - 1) * 50 + 5, 50, 50);
        }

        public Bitmap GetImageByChessType(FigureType type)
        {
            switch (type)
            {
                case FigureType.Ladia:
                {
                    return new Bitmap("ladia.jpg");
                }
                case FigureType.Kon:
                {
                    return new Bitmap("Kon.jpg");
                }
                default:
                {
                    return new Bitmap("notFound.jpg"); ;
                }
            }
        }
    }

    public class FigurePositionCalculator
    {
        public ChessCell? GetCellByPoint(int x, int y)
        {
            if (x < 50 && y < 50)
            {
                return new ChessCell() { Letter = ChessLetter.A, Number = 1 };
            }
            return null;
        }
    }

    public struct ChessCell
    {
        public ChessLetter Letter { get; set; }
        public int Number { get; set; }
    }

    public enum ChessLetter
    {
        A
    }
}
