using System.ComponentModel;
using System.Windows.Forms;

namespace PiApproxGraphic
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.StartBtn = new System.Windows.Forms.Button();
            this.StopBtn = new System.Windows.Forms.Button();
            this.SimsLabel = new System.Windows.Forms.Label();
            this.SimsLabelNum = new System.Windows.Forms.Label();
            this.PiLabel = new System.Windows.Forms.Label();
            this.PiLabelNum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ApproxPiNum = new System.Windows.Forms.Label();
            this.IterationsToRunLabel = new System.Windows.Forms.Label();
            this.IterationsToRunTextBox = new System.Windows.Forms.TextBox();
            this.RunForeverCheckbox = new System.Windows.Forms.CheckBox();
            this.SimThreadsLabel = new System.Windows.Forms.Label();
            this.SimThreadsTextbox = new System.Windows.Forms.TextBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.DrawPanel = new System.Windows.Forms.Panel();
            this.RunCalcTimer = new System.Windows.Forms.Timer(this.components);
            this.MSPerTickLabel = new System.Windows.Forms.Label();
            this.MSPerTickTextBox = new System.Windows.Forms.TextBox();
            this.PercentDifferenceLabel = new System.Windows.Forms.Label();
            this.PercentDifferenceLabelNum = new System.Windows.Forms.Label();
            this.SimBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(5, 8);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(121, 23);
            this.StartBtn.TabIndex = 0;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // StopBtn
            // 
            this.StopBtn.Location = new System.Drawing.Point(5, 37);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(121, 23);
            this.StopBtn.TabIndex = 0;
            this.StopBtn.Text = "Stop";
            this.StopBtn.UseVisualStyleBackColor = true;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // SimsLabel
            // 
            this.SimsLabel.AutoSize = true;
            this.SimsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimsLabel.Location = new System.Drawing.Point(2, 201);
            this.SimsLabel.Name = "SimsLabel";
            this.SimsLabel.Size = new System.Drawing.Size(60, 13);
            this.SimsLabel.TabIndex = 1;
            this.SimsLabel.Text = "Iterations";
            // 
            // SimsLabelNum
            // 
            this.SimsLabelNum.AutoSize = true;
            this.SimsLabelNum.Location = new System.Drawing.Point(2, 214);
            this.SimsLabelNum.Name = "SimsLabelNum";
            this.SimsLabelNum.Size = new System.Drawing.Size(13, 13);
            this.SimsLabelNum.TabIndex = 2;
            this.SimsLabelNum.Text = "0";
            // 
            // PiLabel
            // 
            this.PiLabel.AutoSize = true;
            this.PiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PiLabel.Location = new System.Drawing.Point(2, 92);
            this.PiLabel.Name = "PiLabel";
            this.PiLabel.Size = new System.Drawing.Size(18, 13);
            this.PiLabel.TabIndex = 1;
            this.PiLabel.Text = "Pi";
            // 
            // PiLabelNum
            // 
            this.PiLabelNum.AutoSize = true;
            this.PiLabelNum.Location = new System.Drawing.Point(2, 105);
            this.PiLabelNum.Name = "PiLabelNum";
            this.PiLabelNum.Size = new System.Drawing.Size(76, 13);
            this.PiLabelNum.TabIndex = 1;
            this.PiLabelNum.Text = "3.1415926535";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Approximated Pi";
            // 
            // ApproxPiNum
            // 
            this.ApproxPiNum.AutoSize = true;
            this.ApproxPiNum.Location = new System.Drawing.Point(2, 141);
            this.ApproxPiNum.Name = "ApproxPiNum";
            this.ApproxPiNum.Size = new System.Drawing.Size(13, 13);
            this.ApproxPiNum.TabIndex = 1;
            this.ApproxPiNum.Text = "0";
            // 
            // IterationsToRunLabel
            // 
            this.IterationsToRunLabel.AutoSize = true;
            this.IterationsToRunLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IterationsToRunLabel.Location = new System.Drawing.Point(2, 239);
            this.IterationsToRunLabel.Name = "IterationsToRunLabel";
            this.IterationsToRunLabel.Size = new System.Drawing.Size(97, 13);
            this.IterationsToRunLabel.TabIndex = 3;
            this.IterationsToRunLabel.Text = "Iterations to run";
            // 
            // IterationsToRunTextBox
            // 
            this.IterationsToRunTextBox.Location = new System.Drawing.Point(5, 278);
            this.IterationsToRunTextBox.Name = "IterationsToRunTextBox";
            this.IterationsToRunTextBox.Size = new System.Drawing.Size(121, 20);
            this.IterationsToRunTextBox.TabIndex = 4;
            this.IterationsToRunTextBox.Text = "100000";
            this.IterationsToRunTextBox.TextChanged += new System.EventHandler(this.IterationsToRunTextBox_TextChanged);
            // 
            // RunForeverCheckbox
            // 
            this.RunForeverCheckbox.AutoSize = true;
            this.RunForeverCheckbox.Location = new System.Drawing.Point(5, 255);
            this.RunForeverCheckbox.Name = "RunForeverCheckbox";
            this.RunForeverCheckbox.Size = new System.Drawing.Size(82, 17);
            this.RunForeverCheckbox.TabIndex = 5;
            this.RunForeverCheckbox.Text = "Run forever";
            this.RunForeverCheckbox.UseVisualStyleBackColor = true;
            this.RunForeverCheckbox.CheckedChanged += new System.EventHandler(this.RunForeverCheckbox_CheckedChanged);
            // 
            // SimThreadsLabel
            // 
            this.SimThreadsLabel.AutoSize = true;
            this.SimThreadsLabel.Enabled = false;
            this.SimThreadsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimThreadsLabel.Location = new System.Drawing.Point(2, 310);
            this.SimThreadsLabel.Name = "SimThreadsLabel";
            this.SimThreadsLabel.Size = new System.Drawing.Size(111, 13);
            this.SimThreadsLabel.TabIndex = 6;
            this.SimThreadsLabel.Text = "Simulation threads";
            // 
            // SimThreadsTextbox
            // 
            this.SimThreadsTextbox.Enabled = false;
            this.SimThreadsTextbox.Location = new System.Drawing.Point(5, 326);
            this.SimThreadsTextbox.Name = "SimThreadsTextbox";
            this.SimThreadsTextbox.Size = new System.Drawing.Size(121, 20);
            this.SimThreadsTextbox.TabIndex = 4;
            this.SimThreadsTextbox.Text = "1";
            this.SimThreadsTextbox.TextChanged += new System.EventHandler(this.SimThreadsTextbox_TextChanged);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(5, 66);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(121, 23);
            this.ResetButton.TabIndex = 0;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // DrawPanel
            // 
            this.DrawPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DrawPanel.BackgroundImage")));
            this.DrawPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DrawPanel.Location = new System.Drawing.Point(132, 8);
            this.DrawPanel.Name = "DrawPanel";
            this.DrawPanel.Size = new System.Drawing.Size(500, 500);
            this.DrawPanel.TabIndex = 7;
            // 
            // RunCalcTimer
            // 
            this.RunCalcTimer.Interval = 1;
            this.RunCalcTimer.Tick += new System.EventHandler(this.RunCalcTimer_Tick);
            // 
            // MSPerTickLabel
            // 
            this.MSPerTickLabel.AutoSize = true;
            this.MSPerTickLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MSPerTickLabel.Location = new System.Drawing.Point(2, 361);
            this.MSPerTickLabel.Name = "MSPerTickLabel";
            this.MSPerTickLabel.Size = new System.Drawing.Size(72, 13);
            this.MSPerTickLabel.TabIndex = 6;
            this.MSPerTickLabel.Text = "MS per tick";
            // 
            // MSPerTickTextBox
            // 
            this.MSPerTickTextBox.Location = new System.Drawing.Point(5, 377);
            this.MSPerTickTextBox.Name = "MSPerTickTextBox";
            this.MSPerTickTextBox.Size = new System.Drawing.Size(121, 20);
            this.MSPerTickTextBox.TabIndex = 4;
            this.MSPerTickTextBox.Text = "1";
            this.MSPerTickTextBox.TextChanged += new System.EventHandler(this.MSPerTickTextBox_TextChanged);
            // 
            // PercentDifferenceLabel
            // 
            this.PercentDifferenceLabel.AutoSize = true;
            this.PercentDifferenceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PercentDifferenceLabel.Location = new System.Drawing.Point(2, 167);
            this.PercentDifferenceLabel.Name = "PercentDifferenceLabel";
            this.PercentDifferenceLabel.Size = new System.Drawing.Size(127, 13);
            this.PercentDifferenceLabel.TabIndex = 8;
            this.PercentDifferenceLabel.Text = "Difference in percent";
            // 
            // PercentDifferenceLabelNum
            // 
            this.PercentDifferenceLabelNum.AutoSize = true;
            this.PercentDifferenceLabelNum.Location = new System.Drawing.Point(2, 180);
            this.PercentDifferenceLabelNum.Name = "PercentDifferenceLabelNum";
            this.PercentDifferenceLabelNum.Size = new System.Drawing.Size(13, 13);
            this.PercentDifferenceLabelNum.TabIndex = 9;
            this.PercentDifferenceLabelNum.Text = "0";
            // 
            // SimBackgroundWorker
            // 
            this.SimBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.SimBackgroundWorker_DoWork);
            this.SimBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.SimBackgroundWorker_ProgressChanged);
            this.SimBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.SimBackgroundWorker_RunWorkerCompleted);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(644, 515);
            this.Controls.Add(this.IterationsToRunTextBox);
            this.Controls.Add(this.RunForeverCheckbox);
            this.Controls.Add(this.IterationsToRunLabel);
            this.Controls.Add(this.PercentDifferenceLabelNum);
            this.Controls.Add(this.DrawPanel);
            this.Controls.Add(this.MSPerTickLabel);
            this.Controls.Add(this.SimsLabelNum);
            this.Controls.Add(this.PercentDifferenceLabel);
            this.Controls.Add(this.SimsLabel);
            this.Controls.Add(this.SimThreadsLabel);
            this.Controls.Add(this.MSPerTickTextBox);
            this.Controls.Add(this.SimThreadsTextbox);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ApproxPiNum);
            this.Controls.Add(this.StopBtn);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.PiLabelNum);
            this.Controls.Add(this.PiLabel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Pi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button StartBtn;
        private Button StopBtn;
        private Label SimsLabel;
        private Label SimsLabelNum;
        private Label PiLabel;
        private Label PiLabelNum;
        private Label label1;
        private Label ApproxPiNum;
        private Label IterationsToRunLabel;
        private TextBox IterationsToRunTextBox;
        private CheckBox RunForeverCheckbox;
        private Label SimThreadsLabel;
        private TextBox SimThreadsTextbox;
        private Button ResetButton;
        private Panel DrawPanel;
        private Timer RunCalcTimer;
        private Label MSPerTickLabel;
        private TextBox MSPerTickTextBox;
        private Label PercentDifferenceLabel;
        private Label PercentDifferenceLabelNum;
        private BackgroundWorker SimBackgroundWorker;
    }
}

