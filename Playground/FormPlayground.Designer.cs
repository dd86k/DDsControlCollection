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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPlayground));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.simpleClock1 = new DDsControlCollection.SimpleClock();
            this.prettyListBox2 = new DDsControlCollection.PrettyListBox();
            this.simpleProgressBar1 = new DDsControlCollection.SimpleProgressBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 261);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(170, 95);
            this.listBox1.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(223, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 52);
            this.button3.TabIndex = 12;
            this.button3.Text = "Toggle marquee";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Slide",
            "Bouncy"});
            this.comboBox1.Location = new System.Drawing.Point(118, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(99, 21);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 362);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(335, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "Set SelectedIndex = -1";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 391);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(335, 23);
            this.button5.TabIndex = 15;
            this.button5.Text = "Add item";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // simpleClock1
            // 
            this.simpleClock1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleClock1.BackColor = System.Drawing.SystemColors.Control;
            this.simpleClock1.ClockBackgroundColor = System.Drawing.Color.Black;
            this.simpleClock1.ClockBackgroundImage = ((System.Drawing.Image)(resources.GetObject("simpleClock1.ClockBackgroundImage")));
            this.simpleClock1.FrameColor = System.Drawing.Color.Black;
            this.simpleClock1.FrameThickness = 4F;
            this.simpleClock1.HourNeedlePen = System.Drawing.Color.Black;
            this.simpleClock1.HourNeedleThickness = 3F;
            this.simpleClock1.Location = new System.Drawing.Point(362, 12);
            this.simpleClock1.MiddlePointColor = System.Drawing.Color.Black;
            this.simpleClock1.MinuteNeedleColor = System.Drawing.Color.Black;
            this.simpleClock1.MinuteNeedleThickness = 3F;
            this.simpleClock1.Name = "simpleClock1";
            this.simpleClock1.SecondNeedleColor = System.Drawing.Color.Red;
            this.simpleClock1.SecondNeedleThickness = 2F;
            this.simpleClock1.ShowBackgroundColor = false;
            this.simpleClock1.ShowBackgroundImage = false;
            this.simpleClock1.ShowFrame = true;
            this.simpleClock1.ShowHourNeedle = true;
            this.simpleClock1.ShowMiddlePoint = true;
            this.simpleClock1.ShowMinuteNeedle = true;
            this.simpleClock1.ShowSecondNeedle = true;
            this.simpleClock1.Size = new System.Drawing.Size(100, 100);
            this.simpleClock1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.simpleClock1.TabIndex = 11;
            this.simpleClock1.Text = "simpleClock1";
            // 
            // prettyListBox2
            // 
            this.prettyListBox2.AutoScroll = true;
            this.prettyListBox2.AutoScrollMinSize = new System.Drawing.Size(200, 205);
            this.prettyListBox2.BackColor = System.Drawing.Color.White;
            this.prettyListBox2.FocusColor = System.Drawing.Color.Coral;
            this.prettyListBox2.Location = new System.Drawing.Point(188, 261);
            this.prettyListBox2.Name = "prettyListBox2";
            this.prettyListBox2.Size = new System.Drawing.Size(159, 95);
            this.prettyListBox2.TabIndex = 10;
            this.prettyListBox2.Text = "prettyListBox2";
            this.prettyListBox2.TextPaddingHorizontal = 2;
            this.prettyListBox2.TextPaddingVertical = 2;
            // 
            // simpleProgressBar1
            // 
            this.simpleProgressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleProgressBar1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.simpleProgressBar1.BarOrientation = System.Windows.Forms.Orientation.Horizontal;
            this.simpleProgressBar1.BorderThickness = 1F;
            this.simpleProgressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.simpleProgressBar1.ForeColor = System.Drawing.Color.Green;
            this.simpleProgressBar1.InvertOrientation = false;
            this.simpleProgressBar1.Location = new System.Drawing.Point(12, 12);
            this.simpleProgressBar1.MarqueeAnimation = DDsControlCollection.MarqueeAnimation.Slide;
            this.simpleProgressBar1.Name = "simpleProgressBar1";
            this.simpleProgressBar1.Padding = new System.Windows.Forms.Padding(2);
            this.simpleProgressBar1.Size = new System.Drawing.Size(100, 23);
            this.simpleProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.simpleProgressBar1.TabIndex = 0;
            this.simpleProgressBar1.TextColor = System.Drawing.Color.Black;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 128);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 16;
            // 
            // FormPlayground
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 426);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.simpleClock1);
            this.Controls.Add(this.prettyListBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.simpleProgressBar1);
            this.Name = "FormPlayground";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DDsControlCollection.SimpleProgressBar simpleProgressBar1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        private DDsControlCollection.PrettyListBox prettyListBox2;
        private DDsControlCollection.SimpleClock simpleClock1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

