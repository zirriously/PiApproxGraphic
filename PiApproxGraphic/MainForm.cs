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
        Random rand = new Random();
        private Graphics graphics;
        private Pen redPx = new Pen(Color.Red, 0);
        private Pen bluePx = new Pen(Color.Blue, 0);
        private bool runForever = false;
        private double iterationsToRun = 100000;
        private double iterationsRan = 0;

        public MainForm()
        {
            InitializeComponent();
            graphics = DrawPanel.CreateGraphics();
        }

        private void IterateOnce()
        {
            iterationsRan++;
            graphics.DrawRectangle(redPx, rand.Next(3, 572), rand.Next(3, 572), 1, 1);
            graphics.DrawRectangle(bluePx, rand.Next(3, 572), rand.Next(3, 572), 1, 1);
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < iterationsToRun; i++)
            {
                IterateOnce();
            }

            SimsLabelNum.Text = iterationsRan.ToString();
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {

        }

        private void ResetButton_Click(object sender, EventArgs e)
        {

        }

        private void RunForeverCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            IterationsToRunTextBox.Enabled = !RunForeverCheckbox.Checked;
        }

        private void IterationsToRunTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SimThreadsTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Iterate()
        {

        }
    }
}
