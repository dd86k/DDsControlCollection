using System;
using System.Windows.Forms;
using DDsControlCollection;
using System.Drawing;

namespace FancyProgressBar
{
    public partial class FormPlayground : Form
    {
        public FormPlayground()
        {
            InitializeComponent();

            progressBar1.Style = ProgressBarStyle.Continuous; // Mono
            progressBar1.ForeColor = Color.Red; // Mono
            
            simpleProgressBar1.TextStyle = ProgressBarTextStyle.ValueOnMaximum;

            //simpleClock1.ShowBackgroundImage = true;
            simpleClock1.ClockBackgroundImage = Image.FromFile("1462332400379-1.png");

            listBox1.Items.Add("Item");
            listBox1.Items.Add("Selected");

            listBox1.SelectedItem = "Item";
            
            prettyListBox2.Items.Add("Item");
            prettyListBox2.Items.Add("Selected");

            prettyListBox2.SelectedItem = "Item";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            simpleProgressBar1.PerformStep();
            progressBar1.PerformStep();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            simpleProgressBar1.Value =
                  progressBar1.Value = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (simpleProgressBar1.Style == ProgressBarStyle.Continuous)
                simpleProgressBar1.Style = ProgressBarStyle.Marquee;
            else
                simpleProgressBar1.Style = ProgressBarStyle.Continuous;

            if (progressBar1.Style == ProgressBarStyle.Continuous)
                progressBar1.Style = ProgressBarStyle.Marquee;
            else
                progressBar1.Style = ProgressBarStyle.Continuous;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            simpleProgressBar1.MarqueeAnimation =
                (MarqueeAnimation)comboBox1.SelectedIndex;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndex =
                prettyListBox2.SelectedIndex = -1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Item");

            prettyListBox2.Items.Add("Item");
        }
    }
}
