using System;
using System.Windows.Forms;
using DDsControlCollection;

namespace FancyProgressBar
{
    public partial class FormPlayground : Form
    {
        public FormPlayground()
        {
            InitializeComponent();

            progressBar1.Style = ProgressBarStyle.Continuous; // Mono

            simpleProgressBar1.TextDisplay = BarTextDisplayType.ValueOnMaximum;

            treeView1.Nodes.Add("test");
            treeView1.Nodes[0].Nodes.Add("child");
            treeView1.Nodes.Add("test1");
            
            prettyTreeView1.Nodes.Add("test");
            prettyTreeView1.Nodes[0].Nodes.Add("child");
            prettyTreeView1.Nodes.Add("test1");

            listBox1.Items.Add("Item");
            listBox1.Items.Add("Selected");
            
            prettyListBox2.Items.Add("Item");
            prettyListBox2.Items.Add("Selected");
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
    }
}
