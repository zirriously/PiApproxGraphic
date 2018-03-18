namespace PiApproxGraphicalSimple
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
            this.ApproximatedPiTextlabel = new System.Windows.Forms.Label();
            this.ApproximatedPiNumericalLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IterationsTextLabel = new System.Windows.Forms.Label();
            this.IterationsNumericalLabel = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.DrawBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DrawBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ApproximatedPiTextlabel
            // 
            this.ApproximatedPiTextlabel.AutoSize = true;
            this.ApproximatedPiTextlabel.Location = new System.Drawing.Point(58, 13);
            this.ApproximatedPiTextlabel.Name = "ApproximatedPiTextlabel";
            this.ApproximatedPiTextlabel.Size = new System.Drawing.Size(82, 13);
            this.ApproximatedPiTextlabel.TabIndex = 9;
            this.ApproximatedPiTextlabel.Text = "Approximated pi";
            // 
            // ApproximatedPiNumericalLabel
            // 
            this.ApproximatedPiNumericalLabel.AutoSize = true;
            this.ApproximatedPiNumericalLabel.Location = new System.Drawing.Point(58, 26);
            this.ApproximatedPiNumericalLabel.Name = "ApproximatedPiNumericalLabel";
            this.ApproximatedPiNumericalLabel.Size = new System.Drawing.Size(13, 13);
            this.ApproximatedPiNumericalLabel.TabIndex = 9;
            this.ApproximatedPiNumericalLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Actual pi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "3.1415926535";
            // 
            // IterationsTextLabel
            // 
            this.IterationsTextLabel.AutoSize = true;
            this.IterationsTextLabel.Location = new System.Drawing.Point(228, 13);
            this.IterationsTextLabel.Name = "IterationsTextLabel";
            this.IterationsTextLabel.Size = new System.Drawing.Size(50, 13);
            this.IterationsTextLabel.TabIndex = 9;
            this.IterationsTextLabel.Text = "Iterations";
            // 
            // IterationsNumericalLabel
            // 
            this.IterationsNumericalLabel.AutoSize = true;
            this.IterationsNumericalLabel.Location = new System.Drawing.Point(228, 26);
            this.IterationsNumericalLabel.Name = "IterationsNumericalLabel";
            this.IterationsNumericalLabel.Size = new System.Drawing.Size(13, 13);
            this.IterationsNumericalLabel.TabIndex = 9;
            this.IterationsNumericalLabel.Text = "0";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(12, 12);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(40, 31);
            this.StartButton.TabIndex = 10;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // DrawBox
            // 
            this.DrawBox.Location = new System.Drawing.Point(13, 50);
            this.DrawBox.Name = "DrawBox";
            this.DrawBox.Size = new System.Drawing.Size(580, 580);
            this.DrawBox.TabIndex = 11;
            this.DrawBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 642);
            this.Controls.Add(this.DrawBox);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.IterationsNumericalLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ApproximatedPiNumericalLabel);
            this.Controls.Add(this.IterationsTextLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ApproximatedPiTextlabel);
            this.Name = "Form1";
            this.Text = "Pi";
            ((System.ComponentModel.ISupportInitialize)(this.DrawBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ApproximatedPiTextlabel;
        private System.Windows.Forms.Label ApproximatedPiNumericalLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label IterationsTextLabel;
        private System.Windows.Forms.Label IterationsNumericalLabel;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.PictureBox DrawBox;
    }
}

