using System;
using System.Drawing;
using System.Windows.Forms;

namespace FancyProgressBar
{
    class SimpleProgressBar : Control
    {
        // Internal use variables

        System.Timers.Timer _marqueeTimer;

        // Enums

        public enum TextDisplayType
        {
            None,
            ValueOnMaximum, // value / max
            Pourcentage, // [n]nn[.Nn]%
            UserDefined
        }
        
        public enum Orientation
        {
            Horizontal, Vertical
        }

        // Construct

        public SimpleProgressBar()
        {
            _maximum = 100;
            _value = 0;
            _textDisplay = TextDisplayType.None;
            _font = new Font("Segoi UI", 12);
            _textColor = Color.Black;

            Step = 10;
            Size = new Size(100, 23);
            ForeColor = Color.Green;
            BackColor = Color.LightGray;
        }

        // Methods
        
        public void PerformStep()
        {
            if (_value + Step <= _maximum)
                Value += Step;
            else
                Value += _maximum - _value;
        }

        // Properties without private variables

        public int Step { get; set; }

        // Properties

        int _maximum;
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
        public int Value
        {
            get { return _value; }
            set
            {
                if (value > _maximum)
                    throw new ArgumentOutOfRangeException("Value is higher than maximum.");

                if (value < _minimum)
                    throw new ArgumentOutOfRangeException("Value is lower than minimum.");

                _value = value;

                Invalidate();
            }
        }

        Font _font;
        public new Font Font
        {
            get { return _font; }
            set
            {
                _font = value;

                Invalidate();
            }
        }

        TextDisplayType _textDisplay;
        public TextDisplayType TextDisplay
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
                    _textDisplay = TextDisplayType.None;
                else if (_textDisplay != TextDisplayType.UserDefined)
                    _textDisplay = TextDisplayType.UserDefined;

                Invalidate();
            }
        }

        Color _textColor;
        public Color TextColor
        {
            get { return _textColor; }
            set
            {
                _textColor = value;

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

        ProgressBarStyle _style;
        public ProgressBarStyle Style
        {
            get { return _style; }
            set
            {
                _style = value;

                //TODO: Style

                Invalidate();
            }
        }

        // Events

        protected override void OnPaint(PaintEventArgs e)
        {
            switch (_orientation)
            {
                case Orientation.Horizontal:
                    {
                        e.Graphics.FillRectangle(new SolidBrush(ForeColor),
                            0, 0,
                            (_value * Width) / _maximum, Height);
                    }
                    break;

                case Orientation.Vertical:
                    {
                        e.Graphics.FillRectangle(new SolidBrush(ForeColor),
                            0, Height - ((_value * Height) / _maximum),
                            Width, (_value * Height) / _maximum);
                    }
                    break;
            }

            if (_textDisplay != TextDisplayType.None)
            {
                switch (_textDisplay)
                {
                    case TextDisplayType.ValueOnMaximum:
                        _text = $"{_value} / {_maximum}";
                        break;

                    case TextDisplayType.Pourcentage:
                        _text = (float)_value / _maximum * 100 + "%";
                        break;
                }

                SizeF ts = e.Graphics.MeasureString(_text, _font);

                e.Graphics.DrawString(_text, _font,
                    new SolidBrush(_textColor),
                    (Width / 2) - (ts.Width / 2),
                    (Height / 2) - (ts.Height / 2));
            }
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(BackColor),
                e.ClipRectangle);
        }
    }
}
