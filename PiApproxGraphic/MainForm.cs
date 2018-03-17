using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiApproxGraphic
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {

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
