using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiApproxGraphic
{
    public partial class MainForm : Form
    {
        private Graphics graphics;
        private Pen redPx = new Pen(Color.Red, 0);
        private Pen bluePx = new Pen(Color.Blue, 0);
        private bool runForever = false;
        private int iterationsToRun = 100000;
        private int iterationsRan = 0;
        private const int scaling = 250;

        public MainForm()
        {
            InitializeComponent();
            graphics = DrawPanel.CreateGraphics();
        }

        private double Calculate()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            int insideUnitCircle = 0;

            for (int i = 0; i < iterationsToRun; i++)
            {
                iterationsRan++;
                double x = random.NextDouble() * 2 - 1;
                double y = random.NextDouble() * 2 - 1;

                if (x * x + y * y < 1.0)
                {
                    double xToDraw = (x * scaling) + 250;
                    double yToDraw = (y * scaling) + 250;
                    insideUnitCircle++;
                    DrawPx(bluePx, (int)xToDraw, (int)yToDraw);
                }
                else
                {
                    double xToDraw = (x * scaling) + 250;
                    double yToDraw = (y * scaling) + 250;
                    DrawPx(redPx, (int)xToDraw, (int)yToDraw);
                }
            }

            return insideUnitCircle * 4.0 / iterationsRan;
        }

        private void DrawPx(Pen pen, int x, int y)
        {
            graphics.DrawRectangle(pen, x, y, 1, 1);
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            iterationsRan = 0;
            ApproxPiNum.Text = Calculate().ToString("0.0000000000");
            SimsLabelNum.Text = iterationsRan.ToString();
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {

        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            DrawPanel.Invalidate();
            iterationsRan = 0;
            ApproxPiNum.Text = "0";
            SimsLabelNum.Text = "0";
        }

        private void RunForeverCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            IterationsToRunTextBox.Enabled = !RunForeverCheckbox.Checked;
        }

        private void IterationsToRunTextBox_TextChanged(object sender, EventArgs e)
        {
            if (IterationsToRunTextBox.Text != string.Empty)
            {
                iterationsToRun = Int32.Parse(IterationsToRunTextBox.Text);
            }
        }

        private void SimThreadsTextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
