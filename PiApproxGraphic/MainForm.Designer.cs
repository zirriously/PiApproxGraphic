namespace PiApproxGraphic
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.SuspendLayout();
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(12, 12);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(98, 23);
            this.StartBtn.TabIndex = 0;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // StopBtn
            // 
            this.StopBtn.Enabled = false;
            this.StopBtn.Location = new System.Drawing.Point(12, 41);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(98, 23);
            this.StopBtn.TabIndex = 0;
            this.StopBtn.Text = "Stop";
            this.StopBtn.UseVisualStyleBackColor = true;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // SimsLabel
            // 
            this.SimsLabel.AutoSize = true;
            this.SimsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimsLabel.Location = new System.Drawing.Point(9, 96);
            this.SimsLabel.Name = "SimsLabel";
            this.SimsLabel.Size = new System.Drawing.Size(60, 13);
            this.SimsLabel.TabIndex = 1;
            this.SimsLabel.Text = "Iterations";
            // 
            // SimsLabelNum
            // 
            this.SimsLabelNum.AutoSize = true;
            this.SimsLabelNum.Location = new System.Drawing.Point(10, 111);
            this.SimsLabelNum.Name = "SimsLabelNum";
            this.SimsLabelNum.Size = new System.Drawing.Size(13, 13);
            this.SimsLabelNum.TabIndex = 2;
            this.SimsLabelNum.Text = "0";
            // 
            // PiLabel
            // 
            this.PiLabel.AutoSize = true;
            this.PiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PiLabel.Location = new System.Drawing.Point(9, 128);
            this.PiLabel.Name = "PiLabel";
            this.PiLabel.Size = new System.Drawing.Size(18, 13);
            this.PiLabel.TabIndex = 1;
            this.PiLabel.Text = "Pi";
            // 
            // PiLabelNum
            // 
            this.PiLabelNum.AutoSize = true;
            this.PiLabelNum.Location = new System.Drawing.Point(9, 141);
            this.PiLabelNum.Name = "PiLabelNum";
            this.PiLabelNum.Size = new System.Drawing.Size(76, 13);
            this.PiLabelNum.TabIndex = 1;
            this.PiLabelNum.Text = "3.1415926535";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Approximated Pi";
            // 
            // ApproxPiNum
            // 
            this.ApproxPiNum.AutoSize = true;
            this.ApproxPiNum.Location = new System.Drawing.Point(9, 172);
            this.ApproxPiNum.Name = "ApproxPiNum";
            this.ApproxPiNum.Size = new System.Drawing.Size(13, 13);
            this.ApproxPiNum.TabIndex = 1;
            this.ApproxPiNum.Text = "0";
            // 
            // IterationsToRunLabel
            // 
            this.IterationsToRunLabel.AutoSize = true;
            this.IterationsToRunLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IterationsToRunLabel.Location = new System.Drawing.Point(7, 187);
            this.IterationsToRunLabel.Name = "IterationsToRunLabel";
            this.IterationsToRunLabel.Size = new System.Drawing.Size(97, 13);
            this.IterationsToRunLabel.TabIndex = 3;
            this.IterationsToRunLabel.Text = "Iterations to run";
            // 
            // IterationsToRunTextBox
            // 
            this.IterationsToRunTextBox.Location = new System.Drawing.Point(10, 226);
            this.IterationsToRunTextBox.Name = "IterationsToRunTextBox";
            this.IterationsToRunTextBox.Size = new System.Drawing.Size(100, 20);
            this.IterationsToRunTextBox.TabIndex = 4;
            this.IterationsToRunTextBox.Text = "100000";
            this.IterationsToRunTextBox.TextChanged += new System.EventHandler(this.IterationsToRunTextBox_TextChanged);
            // 
            // RunForeverCheckbox
            // 
            this.RunForeverCheckbox.AutoSize = true;
            this.RunForeverCheckbox.Enabled = false;
            this.RunForeverCheckbox.Location = new System.Drawing.Point(11, 205);
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
            this.SimThreadsLabel.Location = new System.Drawing.Point(7, 253);
            this.SimThreadsLabel.Name = "SimThreadsLabel";
            this.SimThreadsLabel.Size = new System.Drawing.Size(111, 13);
            this.SimThreadsLabel.TabIndex = 6;
            this.SimThreadsLabel.Text = "Simulation threads";
            // 
            // SimThreadsTextbox
            // 
            this.SimThreadsTextbox.Enabled = false;
            this.SimThreadsTextbox.Location = new System.Drawing.Point(11, 269);
            this.SimThreadsTextbox.Name = "SimThreadsTextbox";
            this.SimThreadsTextbox.Size = new System.Drawing.Size(100, 20);
            this.SimThreadsTextbox.TabIndex = 4;
            this.SimThreadsTextbox.Text = "1";
            this.SimThreadsTextbox.TextChanged += new System.EventHandler(this.SimThreadsTextbox_TextChanged);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(13, 70);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(98, 23);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 515);
            this.Controls.Add(this.DrawPanel);
            this.Controls.Add(this.SimThreadsLabel);
            this.Controls.Add(this.RunForeverCheckbox);
            this.Controls.Add(this.SimThreadsTextbox);
            this.Controls.Add(this.IterationsToRunTextBox);
            this.Controls.Add(this.IterationsToRunLabel);
            this.Controls.Add(this.SimsLabelNum);
            this.Controls.Add(this.PiLabelNum);
            this.Controls.Add(this.ApproxPiNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PiLabel);
            this.Controls.Add(this.SimsLabel);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.StopBtn);
            this.Controls.Add(this.StartBtn);
            this.Name = "MainForm";
            this.Text = "Pi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button StopBtn;
        private System.Windows.Forms.Label SimsLabel;
        private System.Windows.Forms.Label SimsLabelNum;
        private System.Windows.Forms.Label PiLabel;
        private System.Windows.Forms.Label PiLabelNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ApproxPiNum;
        private System.Windows.Forms.Label IterationsToRunLabel;
        private System.Windows.Forms.TextBox IterationsToRunTextBox;
        private System.Windows.Forms.CheckBox RunForeverCheckbox;
        private System.Windows.Forms.Label SimThreadsLabel;
        private System.Windows.Forms.TextBox SimThreadsTextbox;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Panel DrawPanel;
    }
}

