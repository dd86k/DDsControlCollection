using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static System.Math;

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

            float s = (_time.Second - 15) * 0.1047f;
            float m = (_time.Minute - 15) * 0.1047f;
            float h = (_time.Hour - 3) * 0.5235f;
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
    }
}
