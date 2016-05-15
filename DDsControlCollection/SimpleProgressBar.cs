using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DDsControlCollection
{
    public enum BarTextDisplayType
    {
        None,
        ValueOnMaximum, // value / max
        Pourcentage, // [n]nn[.Nn]%
        UserDefined
    }

    public enum MarqueeAnimation
    {
        Bouncy, Slide
    }

    public class SimpleProgressBar : Control
    {
        // Marquee stuff
        //TODO: maybe wrap this all in a class (non-static)

        public System.Timers.Timer MarqueeTimer { get; private set; }
        enum MarqueeDirection { Right, Left, Up, Down }
        MarqueeDirection _marqueeDirection;
        int _marqueeWidth; // public
        int _marqueeSpeed; // public
        int _marqueePosition;
        //TODO: MarqueeAnimationType (enum)
        //TOPO: MarqueeAnimation (property) -> timer event
        public MarqueeAnimation MarqueeAnimation { get; set; }

        // Construct

        public SimpleProgressBar()
        {
            _maximum = 100;
            _value = 0;
            _textDisplay = BarTextDisplayType.None;
            _font = new Font("Segoi UI", 12);
            _textColor = new SolidBrush(Color.Black);
            _borderPen = new Pen(Color.DarkGray, 1);

            _style = ProgressBarStyle.Continuous;
            Padding = new Padding(2);
            Step = 10;
            Size = new Size(100, 23);
            ForeColor = Color.Green;
            BackColor = Color.WhiteSmoke;

            DoubleBuffered = true;

            // Marquee stuff
            _marqueeWidth = 40;
            //_marqueePosition = 0;
            _marqueeSpeed = 2;
            _marqueeDirection = MarqueeDirection.Right;
            MarqueeTimer = new System.Timers.Timer(25);
            MarqueeTimer.Elapsed += (s, e) =>
            {
                switch (MarqueeAnimation)
                {
                    case MarqueeAnimation.Bouncy:
                        switch (_marqueeDirection)
                        {
                            case MarqueeDirection.Right:
                                if (_marqueePosition + _marqueeSpeed + _marqueeWidth + Padding.Horizontal
                                    > Width)
                                    _marqueeDirection = MarqueeDirection.Left;
                                else
                                    _marqueePosition += _marqueeSpeed;
                                break;

                            case MarqueeDirection.Left:
                                if (_marqueePosition - _marqueeSpeed - Padding.Left
                                    < 0)
                                    _marqueeDirection = MarqueeDirection.Right;
                                else
                                    _marqueePosition -= _marqueeSpeed;
                                break;
                        }
                        break;

                    case MarqueeAnimation.Slide:
                        if (_marqueePosition > Width)
                            _marqueePosition = -_marqueeWidth;
                        else
                            _marqueePosition += _marqueeSpeed;
                        break;
                }
                
                Invalidate();
            };
        }

        // Methods
        
        public void PerformStep()
        {
            if (_style != ProgressBarStyle.Marquee)
            {
                if (_value + Step <= _maximum)
                    Value += Step;
                else
                    Value += _maximum - _value;
            }
            else
            {
                if (_value + Step <= _maximum)
                    _value += Step;
                else
                    _value += _maximum - _value;
            }
        }

        // Properties without private variables

        [DefaultValue(10)]
        public int Step { get; set; }

        // Properties
        
        Pen _borderPen;
        [ReadOnly(true)]
        public Color BorderColor
        {
            get { return _borderPen.Color; }
            set
            {
                _borderPen.Color = value;

                Invalidate();
            }
        }
        [DefaultValue(1)]
        public float BorderWidth
        {
            get { return _borderPen.Width; }
            set
            {
                _borderPen.Width = value;

                Invalidate();
            }
        }

        SolidBrush _foreColor;
        public new Color ForeColor
        {
            get { return base.ForeColor; }
            set
            {
                _foreColor = new SolidBrush(base.ForeColor = value);
            }
        }
        SolidBrush _backColor;
        public new Color BackColor
        {
            get { return base.BackColor; }
            set
            {
                _backColor = new SolidBrush(base.BackColor = value);
            }
        }

        int _maximum;
        [DefaultValue(100)]
        public int Maximum
        {
            get { return _maximum; }
            set
            {
                if (value < _value)
                    throw new ArgumentOutOfRangeException("Maximum is lower than Value.");

                _maximum = value;

                Invalidate();
            }
        }

        int _minimum;
        [DefaultValue(0)]
        public int Minimum
        {
            get { return _minimum; }
            set
            {
                if (value > _value)
                    throw new ArgumentOutOfRangeException("Minimum is higher than Value.");

                _minimum = value;

                Invalidate();
            }
        }

        int _value;
        [DefaultValue(0)]
        public int Value
        {
            get { return _value; }
            set
            {
                if (value <= _maximum)
                    _value = value;
                else if (value > _maximum)
                    throw new ArgumentOutOfRangeException("Value is higher than Maximum.");
                else if (value < _minimum)
                    throw new ArgumentOutOfRangeException("Value is lower than Minimum.");

                Invalidate();
            }
        }

        Font _font;
        [Description("Font to use when a BarTextDisplayType other than None is used.")]
        public new Font Font
        {
            get { return _font; }
            set
            {
                _font = value;

                Invalidate();
            }
        }

        BarTextDisplayType _textDisplay;
        [DefaultValue(BarTextDisplayType.None)]
        public BarTextDisplayType TextDisplay
        {
            get { return _textDisplay; }
            set
            {
                _textDisplay = value;

                Invalidate();
            }
        }

        string _text;
        public new string Text
        {
            get { return _text; }
            set
            {
                _text = value;

                if (string.IsNullOrWhiteSpace(_text))
                    _textDisplay = BarTextDisplayType.None;
                else if (_textDisplay != BarTextDisplayType.UserDefined)
                    _textDisplay = BarTextDisplayType.UserDefined;

                Invalidate();
            }
        }

        SolidBrush _textColor;
        public Color TextColor
        {
            get { return _textColor.Color; }
            set
            {
                _textColor = new SolidBrush(value);

                Invalidate();
            }
        }

        Orientation _orientation;
        public Orientation BarOrientation
        {
            get { return _orientation; }
            set
            {
                _orientation = value;

                Invalidate();
            }
        }

        bool _invertOrientation;
        public bool InvertOrientation
        {
            get { return _invertOrientation; }
            set
            {
                _invertOrientation = value;

                Invalidate();
            }
        }
        public override RightToLeft RightToLeft
        {
            get
            {
                return _invertOrientation ? RightToLeft.Yes : RightToLeft.No;
            }
            set
            {
                _invertOrientation = value == RightToLeft.Yes;

                Invalidate();
            }
        }

        ProgressBarStyle _style;
        public ProgressBarStyle Style
        {
            get { return _style; }
            set
            {
                _style = value;

                switch (value)
                {
                    case ProgressBarStyle.Blocks:
                    case ProgressBarStyle.Continuous:
                        {
                            MarqueeTimer.Stop();
                        }
                        break;
                    case ProgressBarStyle.Marquee:
                        {
                            _marqueePosition = Padding.Left;

                            MarqueeTimer.Start();
                        }
                        break;
                }

                Invalidate();
            }
        }

        // Events

        protected override void OnPaint(PaintEventArgs e)
        {
            switch (_style)
            {
                case ProgressBarStyle.Blocks:
                    {

                    }
                    break;
                case ProgressBarStyle.Continuous:
                    {

                        switch (_orientation)
                        {
                            case Orientation.Horizontal:
                                {
                                    if (_invertOrientation)
                                        e.Graphics.FillRectangle(_foreColor,
                                            (Width - ((_value * Width) / _maximum)) + Padding.Left, Padding.Top,
                                            ((_value * Width) / _maximum) - Padding.Horizontal, Height - Padding.Vertical);
                                    else
                                        e.Graphics.FillRectangle(_foreColor,
                                            Padding.Left, Padding.Top,
                                            ((_value * Width) / _maximum) - Padding.Horizontal, Height - Padding.Vertical);
                                }
                                break;

                            case Orientation.Vertical:
                                {
                                    if (_invertOrientation)
                                        e.Graphics.FillRectangle(_foreColor,
                                            Padding.Left, Padding.Top,
                                            Width - Padding.Horizontal, ((_value * Height) / _maximum) - Padding.Vertical);
                                    else
                                        e.Graphics.FillRectangle(_foreColor,
                                            Padding.Left, (Height - ((_value * Height) / _maximum)) + Padding.Top,
                                            Width - Padding.Horizontal, ((_value * Height) / _maximum) - Padding.Vertical);
                                }
                                break;
                        }
                    }
                    break;
                case ProgressBarStyle.Marquee:
                    {
                        e.Graphics.FillRectangle(_foreColor,
                            Padding.Left + _marqueePosition, Padding.Top,
                            _marqueeWidth, Height - Padding.Vertical);
                    }
                    break;
            }
            
            if (_textDisplay != BarTextDisplayType.None)
            {
                switch (_textDisplay)
                {
                    case BarTextDisplayType.ValueOnMaximum:
                        _text = $"{_value} / {_maximum}";
                        break;

                    case BarTextDisplayType.Pourcentage:
                        _text = (float)_value / _maximum * 100 + "%";
                        break;
                }

                SizeF ts = e.Graphics.MeasureString(_text, _font);

                e.Graphics.DrawString(_text, _font,
                    _textColor,
                    (Width / 2) - (ts.Width / 2),
                    (Height / 2) - (ts.Height / 2));
            }
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(_backColor, e.ClipRectangle);

            if (_borderPen.Width > 0)
            {
                // Top
                e.Graphics.DrawLine(_borderPen,
                    0, 0, Width, 0);

                // Bottom
                e.Graphics.DrawLine(_borderPen,
                    0, Height - 1, Width - 1, Height - 1);

                // Left
                e.Graphics.DrawLine(_borderPen,
                    0, 0, 0, Height);

                // Right
                e.Graphics.DrawLine(_borderPen,
                    Width - 1, 0, Width - 1, Height - 1);
            }
        }
    }
}
