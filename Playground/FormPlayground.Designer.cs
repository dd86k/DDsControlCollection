namespace FancyProgressBar
{
    partial class FormPlayground
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.simpleClock1 = new DDsControlCollection.SimpleClock();
            this.simpleProgressBar1 = new DDsControlCollection.SimpleProgressBar();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 41);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Perform step";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Set Value to 0";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // simpleClock1
            // 
            this.simpleClock1.Location = new System.Drawing.Point(118, 12);
            this.simpleClock1.Name = "simpleClock1";
            this.simpleClock1.Size = new System.Drawing.Size(100, 100);
            this.simpleClock1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
            this.simpleClock1.TabIndex = 6;
            this.simpleClock1.Text = "simpleClock1";
            this.simpleClock1.Time = new System.DateTime(2016, 5, 7, 0, 34, 47, 377);
            // 
            // simpleProgressBar1
            // 
            this.simpleProgressBar1.BackColor = System.Drawing.Color.LightGray;
            this.simpleProgressBar1.BarOrientation = System.Windows.Forms.Orientation.Horizontal;
            this.simpleProgressBar1.ForeColor = System.Drawing.Color.Green;
            this.simpleProgressBar1.Location = new System.Drawing.Point(12, 12);
            this.simpleProgressBar1.Name = "simpleProgressBar1";
            this.simpleProgressBar1.Size = new System.Drawing.Size(100, 23);
            this.simpleProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Blocks;
            this.simpleProgressBar1.TabIndex = 0;
            this.simpleProgressBar1.TextColor = System.Drawing.Color.Black;
            // 
            // FormPlayground
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 426);
            this.Controls.Add(this.simpleClock1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.simpleProgressBar1);
            this.Name = "FormPlayground";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private DDsControlCollection.SimpleProgressBar simpleProgressBar1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private DDsControlCollection.SimpleClock simpleClock1;
    }
}

