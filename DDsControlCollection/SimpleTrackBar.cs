using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace DDsControlCollection
{
    public class SimpleTrackBar : Control
    {
        public SimpleTrackBar()
        {
            Size = new Size(104, 45);
            Padding = new Padding(5, 47, 5, 47);
        }

        SolidBrush _barBackgroundBrush;
        public Color BarBackgroundColor
        {
            get { return _barBackgroundBrush.Color; }
            set
            {
                _barBackgroundBrush.Color = value;

                Invalidate();
            }
        }

        int _value;

        protected override void OnPaint(PaintEventArgs e)
        {
            int barwidth = Width - Padding.Horizontal;
            int barheight = Height - Padding.Vertical;

            e.Graphics.FillRectangle(_barBackgroundBrush,
                Padding.Left, Padding.Top, barwidth, barheight);
        }
    }
}
