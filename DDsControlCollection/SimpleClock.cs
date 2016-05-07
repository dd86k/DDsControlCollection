using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using static System.Math;
using System.ComponentModel;

namespace DDsControlCollection
{
    public enum ClockTimeType
    {
        Now,
        SpecificTime
    }

    public enum ClockStyle
    {
        Analog,
        Numeric,
        Binary
    }

    public class SimpleClock : Control
    {
        public System.Timers.Timer ClockTimer { get; private set; }


        public SimpleClock()
        {
            _framePen = new Pen(Color.Black, 4);
            _secondPen = new Pen(Color.Red, 2);
            _minutePen =
                _hourPen = new Pen(Color.Black, 3);
            _smoothingMode = SmoothingMode.AntiAlias;
            Size = new Size(100, 100);

            ClockTimer = new System.Timers.Timer(1000);
            ClockTimer.Elapsed += (s, e) =>
            {
                Invalidate();
            };
            ClockTimer.Start();
        }

        Pen _framePen;
        [Browsable(false)]
        public Pen FramePen
        {
            get { return _framePen; }
            set
            {
                _framePen = value;

                Invalidate();
            }
        }

        Pen _secondPen;
        [Browsable(false)]
        public Pen SecondsNeedlePen
        {
            get { return _secondPen; }
            set
            {
                _secondPen = value;

                Invalidate();
            }
        }

        Pen _minutePen;
        [Browsable(false)]
        public Pen MinutesNeedlePen
        {
            get { return _minutePen; }
            set
            {
                _minutePen = value;

                Invalidate();
            }
        }

        Pen _hourPen;
        [Browsable(false)]
        public Pen HoursNeedlePen
        {
            get { return _hourPen; }
            set
            {
                _hourPen = value;

                Invalidate();
            }
        }

        SmoothingMode _smoothingMode;
        public SmoothingMode SmoothingMode
        {
            get { return _smoothingMode; }
            set
            {
                _smoothingMode = value;

                Invalidate();
            }
        }

        //TODO: TimeZone

        DateTime _time;
        public DateTime Time
        {
            get { return _time; }
            set
            {
                _time = value;

                Invalidate();
            }
        }
        
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = _smoothingMode;

            if (ClockTimer.Enabled)
                _time = DateTime.Now;

            // sa (Second as angle): (360(deg) / 60(seconds)) = 6
            // (float)(Radius * Sin(((Seconds * sa) - 90) * Math.PI / 180F)) + Translation
            // -- Steps --
            // 1. Get number of steps with - Seconds * sa
            // 2. Backtrack 90 degrees because a clock's 0 is at the top while
            // in a chart, 0 is at the right
            // 3. Complete the section by radian (pi/2) and sin it
            // 4. Apply scaling (radius)
            // 5. Apply translation
            // 6. Coordinate for Y!

            //float s = (float)(_time.Second * 0.1047 - 1.5707);
            float s = (float)((_time.Second - 15) * 0.1047);
            float m = (float)(_time.Minute * 0.1047 - 1.5707);
            float h = (float)((_time.Hour - 3) * 0.5235);
            // Scaling (Radius)
            float rw = Width * 0.4f;
            float rh = Height * 0.4f;
            float rwh = Width * 0.3f;
            float rhh = Height * 0.3f;
            // Translation
            float tw = Width / 2;
            float th = Height / 2;

            // Frame
            e.Graphics.DrawEllipse(_framePen,
                Width / 20, Height / 20,
                Width - (Width / 10), Height - (Height / 10));
            
            // Seconds
            e.Graphics.DrawLine(_secondPen,
                tw, th,
                (float)(rw * Cos(s) + tw),
                (float)(rh * Sin(s) + th));

            // Minutes
            e.Graphics.DrawLine(_minutePen,
                tw, th,
                (float)(rw * Cos(m) + tw),
                (float)(rh * Sin(m) + th));

            // Hours
            e.Graphics.DrawLine(_hourPen,
                tw, th,
                (float)(rwh * Cos(h) + tw),
                (float)(rhh * Sin(h) + th));


        }
        /*
         * 
        float getX(int second)
        {
            
            (float)(radius * Math.Sin((Seconds * sa) * Math.PI / 180F)) + origin.Y
            return (float)(radius * Math.Cos(angleInDegrees * Math.PI / 180F)) + origin.X;
        }*/
    }
}
