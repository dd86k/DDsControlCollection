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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.prettyTreeView1 = new DDsControlCollection.PrettyTreeView();
            this.simpleClock1 = new DDsControlCollection.SimpleClock();
            this.simpleProgressBar1 = new DDsControlCollection.SimpleProgressBar();
            this.prettyListBox1 = new DDsControlCollection.PrettyListBox();
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
            // treeView1
            // 
            this.treeView1.FullRowSelect = true;
            this.treeView1.Location = new System.Drawing.Point(12, 142);
            this.treeView1.Name = "treeView1";
            this.treeView1.ShowLines = false;
            this.treeView1.ShowPlusMinus = false;
            this.treeView1.ShowRootLines = false;
            this.treeView1.Size = new System.Drawing.Size(170, 119);
            this.treeView1.TabIndex = 7;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 267);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(170, 95);
            this.listBox1.TabIndex = 9;
            // 
            // prettyTreeView1
            // 
            this.prettyTreeView1.BackColor = System.Drawing.Color.LightGray;
            this.prettyTreeView1.Location = new System.Drawing.Point(188, 142);
            this.prettyTreeView1.Name = "prettyTreeView1";
            this.prettyTreeView1.SelectedNode = null;
            this.prettyTreeView1.Size = new System.Drawing.Size(159, 119);
            this.prettyTreeView1.TabIndex = 8;
            this.prettyTreeView1.Text = "prettyTreeView1";
            this.prettyTreeView1.TextPaddingHorizontal = 2;
            this.prettyTreeView1.TextPaddingVertical = 2;
            // 
            // simpleClock1
            // 
            this.simpleClock1.Location = new System.Drawing.Point(362, 12);
            this.simpleClock1.Name = "simpleClock1";
            this.simpleClock1.Size = new System.Drawing.Size(100, 100);
            this.simpleClock1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
            this.simpleClock1.TabIndex = 6;
            this.simpleClock1.Text = "simpleClock1";
            this.simpleClock1.Time = new System.DateTime(2016, 5, 7, 19, 29, 33, 105);
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
            // prettyListBox1
            // 
            this.prettyListBox1.BackColor = System.Drawing.Color.LightGray;
            this.prettyListBox1.Location = new System.Drawing.Point(188, 267);
            this.prettyListBox1.Name = "prettyListBox1";
            this.prettyListBox1.Size = new System.Drawing.Size(159, 95);
            this.prettyListBox1.TabIndex = 10;
            this.prettyListBox1.Text = "prettyListBox1";
            this.prettyListBox1.TextPaddingHorizontal = 2;
            this.prettyListBox1.TextPaddingVertical = 2;
            // 
            // FormPlayground
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 426);
            this.Controls.Add(this.prettyListBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.prettyTreeView1);
            this.Controls.Add(this.treeView1);
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
        private System.Windows.Forms.TreeView treeView1;
        private DDsControlCollection.PrettyTreeView prettyTreeView1;
        private System.Windows.Forms.ListBox listBox1;
        private DDsControlCollection.PrettyListBox prettyListBox1;
    }
}

