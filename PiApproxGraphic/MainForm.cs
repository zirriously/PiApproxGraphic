using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace PiApproxGraphic
{
    public partial class MainForm : Form
    {
        private readonly Graphics _graphics;
        private readonly Pen _redPx = new Pen(Color.Red, 1);
        private readonly Pen _bluePx = new Pen(Color.Blue, 1);
        private int _iterationsToRun = 100000;
        private int _iterationsRan;
        private const int Scaling = 250;
        private readonly Random _random = new Random(Guid.NewGuid().GetHashCode());
        private int _insideUnitCircle;
        private double _approximatedPi;
        private const double Pi = 3.1415926535;
        private double _percentDifference;

        public MainForm()
        {
            InitializeComponent();
            _graphics = DrawPanel.CreateGraphics();
            StopBtn.Enabled = false;
            SimBackgroundWorker.WorkerSupportsCancellation = true;
            SimBackgroundWorker.WorkerReportsProgress = true;
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            //RunCalcTimer.Enabled = true;
            SimBackgroundWorker.RunWorkerAsync();

            StopBtn.Enabled = true;
            StartBtn.Enabled = RunForeverCheckbox.Enabled = IterationsToRunTextBox.Enabled =
                MSPerTickTextBox.Enabled = IterationsToRunLabel.Enabled = MSPerTickLabel.Enabled = false;
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            //RunCalcTimer.Enabled = StopBtn.Enabled = false;

            SimBackgroundWorker.CancelAsync();

            StartBtn.Enabled = RunForeverCheckbox.Enabled = IterationsToRunTextBox.Enabled =
                MSPerTickTextBox.Enabled = IterationsToRunLabel.Enabled = MSPerTickLabel.Enabled = true;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            //wipe panel of darts
            DrawPanel.Invalidate();

            ApproxPiNum.Text = SimsLabelNum.Text = PercentDifferenceLabelNum.Text = "0";

            SimBackgroundWorker.CancelAsync();

            StartBtn.Enabled = true;
            StopBtn.Enabled = false;
            RunForeverCheckbox.Enabled = true;
            IterationsToRunTextBox.Enabled = true;
            MSPerTickTextBox.Enabled = true;
            IterationsToRunLabel.Enabled = true;
            MSPerTickLabel.Enabled = true;
            //resets vars as to not effect future iterations
            _percentDifference = 0;
            _approximatedPi = 0;
            _insideUnitCircle = 0;
            _iterationsRan = 0;
        }

        private void RunForeverCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            IterationsToRunTextBox.Enabled = !RunForeverCheckbox.Checked;
        }

        private void IterationsToRunTextBox_TextChanged(object sender, EventArgs e)
        {
            if (IterationsToRunTextBox.Text != string.Empty) _iterationsToRun = int.Parse(IterationsToRunTextBox.Text);
        }

        private void SimThreadsTextbox_TextChanged(object sender, EventArgs e)
        {
            //TODO 
        }

        


        private void RunCalcTimer_Tick(object sender, EventArgs e)
        {
            if (_iterationsRan <= _iterationsToRun || RunForeverCheckbox.Checked)
            {
                //Console.WriteLine(iterationsRan);
                _iterationsRan++;
                var x = _random.NextDouble() * 2 - 1;
                var y = _random.NextDouble() * 2 - 1;
                if (x * x + y * y < 1.0)
                {
                    var xToDraw = x * Scaling + 250;
                    var yToDraw = y * Scaling + 250;
                    _insideUnitCircle++;
                    _graphics.DrawEllipse(_bluePx, (int) xToDraw, (int) yToDraw, 4, 4);
                }
                else
                {
                    var xToDraw = x * Scaling + 250;
                    var yToDraw = y * Scaling + 250;
                    _graphics.DrawEllipse(_redPx, (int) xToDraw, (int) yToDraw, 4, 4);
                }
            }
            else
            {
                Enabled = false;
            }

            _approximatedPi = _insideUnitCircle * 4.0 / _iterationsRan;
            ApproxPiNum.Text = _approximatedPi.ToString("0.0000000000");
            SimsLabelNum.Text = _iterationsRan.ToString();
            _percentDifference = 100 * Pi / _approximatedPi - 100;
            PercentDifferenceLabelNum.Text = _percentDifference.ToString("0.0000") + '%';
        }

        private void MSPerTickTextBox_TextChanged(object sender, EventArgs e)
        {
            if (MSPerTickTextBox.Text != null) RunCalcTimer.Interval = int.Parse(MSPerTickTextBox.Text);
        }

        private void SimBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (!SimBackgroundWorker.CancellationPending)
            {
                if (_iterationsRan <= _iterationsToRun || RunForeverCheckbox.Checked)
                {
                    //Console.WriteLine(iterationsRan);
                    _iterationsRan++;
                    var x = _random.NextDouble() * 2 - 1;
                    var y = _random.NextDouble() * 2 - 1;
                    if (x * x + y * y < 1.0)
                    {
                        var xToDraw = x * Scaling + 250;
                        var yToDraw = y * Scaling + 250;
                        _insideUnitCircle++;
                        try
                        {
                            _graphics.DrawRectangle(_bluePx, (int)xToDraw, (int)yToDraw, 1, 1);
                        }
                        catch (Exception exception)
                        {
                            Console.WriteLine(exception);
                        }
                    }
                    else
                    {
                        var xToDraw = x * Scaling + 250;
                        var yToDraw = y * Scaling + 250;
                        try
                        {
                            _graphics.DrawRectangle(_redPx, (int)xToDraw, (int)yToDraw, 1, 1);
                        }
                        catch (Exception exception)
                        {
                            Console.WriteLine(exception);
                        }
                    }
                }
                else
                {
                    //Enabled = false;
                }

                SimBackgroundWorker.ReportProgress(1);
            }
        }

        private void SimBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (_iterationsRan % 1000 == 0)
            {
                _approximatedPi = _insideUnitCircle * 4.0 / _iterationsRan;
                ApproxPiNum.Text = _approximatedPi.ToString("0.0000000000");
                SimsLabelNum.Text = _iterationsRan.ToString();
                _percentDifference = 100 * Pi / _approximatedPi - 100;
                PercentDifferenceLabelNum.Text = _percentDifference.ToString("0.0000") + '%';
            }
        }

        private void SimBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }
    }
}