using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiApproxGraphicalSimple
{
    public partial class Form1 : Form
    {
        private Random _rand = new Random(Guid.NewGuid().GetHashCode());
        private Bitmap _bmp;
        private Bitmap _pixel;
        private Graphics _graphics;
        private Thread _thread;
        delegate void PixelFunc(int x, int y, Color color);
        private int iterations = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void DrawSinglePx(int x, int y, Color color)
        {
            lock (_graphics)
            {
                _pixel.SetPixel(0,0, Color.Red);
                _graphics.DrawImageUnscaled(_pixel, x, y);
                _bmp.SetPixel(x, y, Color.Red);
            }
        }

        private void Initialise()
        {
            _bmp = new Bitmap(DrawBox.Width, DrawBox.Height);
            _pixel = new Bitmap(1, 1);
            DrawBox.Image = _bmp;
            _graphics = DrawBox.CreateGraphics();
        }

        private void RenderPixels()
        {
            PixelFunc pxFunc = new PixelFunc(DrawSinglePx);
            DrawBox.Invoke(pxFunc, _rand.Next(0, 580), _rand.Next(0, 580), Color.Red);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            Initialise();
            while (true)
            {
                iterations++;
                RenderPixels();
                IterationsNumericalLabel.Text = iterations.ToString();
            }
        }
    }
}
