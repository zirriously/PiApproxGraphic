namespace PiApproxGraphic
{
    partial class Form1
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
            this.StartBtn = new System.Windows.Forms.Button();
            this.StopBtn = new System.Windows.Forms.Button();
            this.SimsLabel = new System.Windows.Forms.Label();
            this.SimsLabelNum = new System.Windows.Forms.Label();
            this.PiLabel = new System.Windows.Forms.Label();
            this.PiLabelNum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(12, 12);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(75, 23);
            this.StartBtn.TabIndex = 0;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            // 
            // StopBtn
            // 
            this.StopBtn.Location = new System.Drawing.Point(12, 41);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(75, 23);
            this.StopBtn.TabIndex = 0;
            this.StopBtn.Text = "Stop";
            this.StopBtn.UseVisualStyleBackColor = true;
            // 
            // SimsLabel
            // 
            this.SimsLabel.AutoSize = true;
            this.SimsLabel.Location = new System.Drawing.Point(12, 67);
            this.SimsLabel.Name = "SimsLabel";
            this.SimsLabel.Size = new System.Drawing.Size(53, 13);
            this.SimsLabel.TabIndex = 1;
            this.SimsLabel.Text = "Iterations:";
            // 
            // SimsLabelNum
            // 
            this.SimsLabelNum.AutoSize = true;
            this.SimsLabelNum.Location = new System.Drawing.Point(60, 68);
            this.SimsLabelNum.Name = "SimsLabelNum";
            this.SimsLabelNum.Size = new System.Drawing.Size(13, 13);
            this.SimsLabelNum.TabIndex = 2;
            this.SimsLabelNum.Text = "2";
            // 
            // PiLabel
            // 
            this.PiLabel.AutoSize = true;
            this.PiLabel.Location = new System.Drawing.Point(35, 88);
            this.PiLabel.Name = "PiLabel";
            this.PiLabel.Size = new System.Drawing.Size(16, 13);
            this.PiLabel.TabIndex = 1;
            this.PiLabel.Text = "Pi";
            // 
            // PiLabelNum
            // 
            this.PiLabelNum.AutoSize = true;
            this.PiLabelNum.Location = new System.Drawing.Point(11, 103);
            this.PiLabelNum.Name = "PiLabelNum";
            this.PiLabelNum.Size = new System.Drawing.Size(76, 13);
            this.PiLabelNum.TabIndex = 1;
            this.PiLabelNum.Text = "3.1415926535";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Approximated Pi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 481);
            this.Controls.Add(this.SimsLabelNum);
            this.Controls.Add(this.PiLabelNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PiLabel);
            this.Controls.Add(this.SimsLabel);
            this.Controls.Add(this.StopBtn);
            this.Controls.Add(this.StartBtn);
            this.Name = "Form1";
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
    }
}

