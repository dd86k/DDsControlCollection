using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static System.Math;

namespace DDsControlCollection
{
    public class SimpleClock : Control
    {
        public System.Timers.Timer ClockTimer { get; private set; }
        
        public SimpleClock()
        {
            _framePen = new Pen(Color.Black, 4);
            _secondPen = new Pen(Color.Red, 2);
            _minutePen =
                _hourPen = new Pen(Color.Black, 3);
            _middlePointBrush = new SolidBrush(Color.Black);
            _backgroundColorBrush = new SolidBrush(Color.Black);
            _backgroundImageBrush =
                new TextureBrush("DefaultClockBgImage.png".GetEmbeddedImage());
            _smoothingMode = SmoothingMode.AntiAlias;
            _showBackgroundColor =
                _showBackgroundImage = false;
            _showFrame =
                _showMiddlePoint =
                _showSecondNeedle =
                _showMinuteNeedle =
                _showHourNeedle = true;

            SizeChanged += (s, e) =>
            {
                if (_showBackgroundImage && Width > 0 && Height > 0)
                {
                    _backgroundImageBrush =
                        new TextureBrush(_backgroundImage.Resize(Size));

                    GC.Collect(2);
                
                    Invalidate();
                }
            };

            DoubleBuffered = true;

            Size = new Size(100, 100);

            // Timer
            ClockTimer = new System.Timers.Timer(1000);
            ClockTimer.Elapsed += (s, e) =>
            {
                _time = DateTime.Now;

                Invalidate();
            };
            ClockTimer.Start();

            _time = DateTime.Now;
        }

        #region Frame
        // Frame
        Pen _framePen;
        public Color FrameColor
        {
            get { return _framePen.Color; }
            set
            {
                _framePen.Color = value;

                Invalidate();
            }
        }
        [DefaultValue(4)]
        public float FrameThickness
        {
            get { return _framePen.Width; }
            set
            {
                _framePen.Width = value;

                Invalidate();
            }
        }

        bool _showFrame;
        [DefaultValue(true)]
        public bool ShowFrame
        {
            get { return _showFrame; }
            set
            {
                _showFrame = value;

                Invalidate();
            }
        }
        #endregion

        #region Second needle
        Pen _secondPen;
        public Color SecondNeedleColor
        {
            get { return _secondPen.Color; }
            set
            {
                _secondPen.Color = value;

                Invalidate();
            }
        }
        [DefaultValue(2)]
        public float SecondNeedleThickness
        {
            get { return _secondPen.Width; }
            set
            {
                _secondPen.Width = value;

                Invalidate();
            }
        }

        bool _showSecondNeedle;
        [DefaultValue(true)]
        public bool ShowSecondNeedle
        {
            get { return _showSecondNeedle; }
            set
            {
                _showSecondNeedle = value;

                Invalidate();
            }
        }
        #endregion

        #region Minute needle
        Pen _minutePen;
        public Color MinuteNeedleColor
        {
            get { return _minutePen.Color; }
            set
            {
                _minutePen.Color = value;

                Invalidate();
            }
        }
        [DefaultValue(3)]
        public float MinuteNeedleThickness
        {
            get { return _minutePen.Width; }
            set
            {
                _minutePen.Width = value;

                Invalidate();
            }
        }

        bool _showMinuteNeedle;
        [DefaultValue(true)]
        public bool ShowMinuteNeedle
        {
            get { return _showMinuteNeedle; }
            set
            {
                _showMinuteNeedle = value;

                Invalidate();
            }
        }
        #endregion

        #region Hour needle
        Pen _hourPen;
        public Color HourNeedlePen
        {
            get { return _hourPen.Color; }
            set
            {
                _hourPen.Color = value;

                Invalidate();
            }
        }
        [DefaultValue(3)]
        public float HourNeedleThickness
        {
            get { return _hourPen.Width; }
            set
            {
                _hourPen.Width = value;

                Invalidate();
            }
        }

        bool _showHourNeedle;
        [DefaultValue(true)]
        public bool ShowHourNeedle
        {
            get { return _showHourNeedle; }
            set
            {
                _showHourNeedle = value;

                Invalidate();
            }
        }
        #endregion

        #region Middle point
        SolidBrush _middlePointBrush;
        public Color MiddlePointColor
        {
            get { return _middlePointBrush.Color; }
            set
            {
                _middlePointBrush.Color = value;
                Invalidate();
            }
        }

        bool _showMiddlePoint;
        [DefaultValue(true)]
        public bool ShowMiddlePoint
        {
            get { return _showMiddlePoint; }
            set
            {
                _showMiddlePoint = value;

                Invalidate();
            }
        }
        #endregion

        #region Clock background image
        TextureBrush _backgroundImageBrush;
        Image _backgroundImage;
        public Image ClockBackgroundImage
        {
            get { return _backgroundImage; }
            set
            {
                _backgroundImageBrush =
                    new TextureBrush(_backgroundImage = value.Resize(Size));
                
                _showBackgroundImage = value != null;

                Invalidate();
            }
        }

        bool _showBackgroundImage;
        [DefaultValue(false)]
        public bool ShowBackgroundImage
        {
            get { return _showBackgroundImage; }
            set
            {
                _showBackgroundImage = value;

                Invalidate();
            }
        }
        #endregion

        #region Clock background color
        SolidBrush _backgroundColorBrush;
        public Color ClockBackgroundColor
        {
            get { return _backgroundColorBrush.Color; }
            set
            {
                _backgroundColorBrush.Color = value;

                _showBackgroundColor = value != null;

                Invalidate();
            }
        }

        bool _showBackgroundColor;
        [DefaultValue(false)]
        public bool ShowBackgroundColor
        {
            get { return _showBackgroundColor; }
            set
            {
                _showBackgroundColor = value;

                Invalidate();
            }
        }
        #endregion

        //TODO: HourOffset

        DateTime _time;
        [Browsable(false)]
        [ReadOnly(true)]
        public DateTime Time
        {
            get { return _time; }
            set
            {
                _time = value;

                ClockTimer.Stop();

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
        
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = _smoothingMode;
            int w = Width;
            int h = Height;
            
            // Scaling (with Radius)
            float rw = w * 0.4f;
            float rh = h * 0.4f;
            // Translation
            float tw = w / 2;
            float th = h / 2;

            // Background color
            if (_showBackgroundColor)
                e.Graphics.FillEllipse(_backgroundColorBrush,
                    w / 20, h / 20,
                    w - (w / 10), h - (h / 10));

            // Background image
            if (_showBackgroundImage)
                e.Graphics.FillEllipse(_backgroundImageBrush,
                    w / 20, h / 20,
                    w - (w / 10), h - (h / 10));

            // Frame
            if (_showFrame)
                e.Graphics.DrawEllipse(_framePen,
                    w / 20, h / 20,
                    w - (w / 10), h - (h / 10));

            // Seconds
            if (_showSecondNeedle)
            {
                float sn = (_time.Second - 15) * 0.10471975511965977461542144610932f;

                e.Graphics.DrawLine(_secondPen,
                    tw, th,
                    (float)(rw * Cos(sn) + tw),
                    (float)(rh * Sin(sn) + th));
            }

            // Minutes
            if (_showMinuteNeedle)
            {
                float mn = (_time.Minute - 15) * 0.10471975511965977461542144610932f;

                e.Graphics.DrawLine(_minutePen,
                    tw, th,
                    (float)(rw * Cos(mn) + tw),
                    (float)(rh * Sin(mn) + th));
            }

            // Hours
            if (_showHourNeedle)
            {
                float hn = (_time.Hour - 3) * 0.52359877559829887307710723054658f;

                float rwh = w * 0.28f;
                float rhh = h * 0.28f;

                e.Graphics.DrawLine(_hourPen,
                    tw, th,
                    (float)(rwh * Cos(hn) + tw),
                    (float)(rhh * Sin(hn) + th));
            }

            // Middle point
            if (_showMiddlePoint)
                e.Graphics.FillEllipse(_middlePointBrush,
                    tw - (w / 30), th - (h / 30),
                    w / 15, h / 15);
        }
    }
}
