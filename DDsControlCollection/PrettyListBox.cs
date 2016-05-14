using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DDsControlCollection
{
    public class PrettyListBox : Panel
    {
        public PrettyListBox()
        {
            _foreColor = new SolidBrush(Color.Black);
            _focusColor = new SolidBrush(Color.Coral);
            _textPaddingVertical = 2;
            _textPaddingHorizontal = 2;
            _index = -1;

            AutoScroll = true;
            AutoScrollMinSize = new Size(200, 205);
            VerticalScroll.Enabled = false;
            Size = new Size(200, 300);
            BackColor = Color.White;
            Items = new ListBox.ObjectCollection(new ListBox());
        }

        int _textHeight;
        int _itemHeight;
        
        public ListBox.ObjectCollection Items
        {
            get;
            private set;
        }

        // I did not wanted to use Padding because 
        int _textPaddingVertical;
        public int TextPaddingVertical
        {
            get { return _textPaddingVertical; }
            set
            {
                _textPaddingVertical = value;

                Invalidate();
            }
        }

        int _textPaddingHorizontal;
        public int TextPaddingHorizontal
        {
            get { return _textPaddingHorizontal; }
            set
            {
                _textPaddingHorizontal = value;

                Invalidate();
            }
        }

        object _selectedItem;
        [Browsable(false)]
        [ReadOnly(true)]
        public object SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                if (Items.Count > 0)
                {
                    if (!Items.Contains(value))
                        throw new ArgumentOutOfRangeException();

                    _selectedItem = value;

                    Invalidate();
                }
            }
        }

        int _index;
        [Browsable(false)]
        [ReadOnly(true)]
        public int SelectedIndex
        {
            get { return _index; }
            set
            {
                if (Items.Count > 0)
                {
                    if (value > Items.Count || value < -1)
                        throw new IndexOutOfRangeException();

                    if (value == -1)
                        _index = -1;

                    _selectedItem = Items[_index = value];

                    Invalidate();
                }
            }
        }

        SolidBrush _focusColor;
        public Color FocusColor
        {
            get { return _focusColor.Color; }
            set
            {
                _focusColor = new SolidBrush(value);

                Invalidate();
            }
        }

        SolidBrush _foreColor;
        public new Color ForeColor
        {
            get { return _foreColor.Color; }
            set
            {
                _foreColor = new SolidBrush(value);

                Invalidate();
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (e.Button == MouseButtons.Left)
                if (e.Y < Items.Count * _itemHeight)
                {
                    _selectedItem = Items[_index = e.Y / _itemHeight];

                    Invalidate();
                }
        }
        
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.TranslateTransform(
                AutoScrollPosition.X,
                AutoScrollPosition.Y
            );

            int y = 0;
            _textHeight = (int)e.Graphics.MeasureString("Aa", Font).Height;
            _itemHeight = _textHeight + (_textPaddingVertical * 2);

            for (int i = 0; i < Items.Count; i++)
            {
                if (Items[i] == _selectedItem)
                {
                    e.Graphics.FillRectangle(_focusColor,
                        0, y,
                        Width, _itemHeight);
                    
                    e.Graphics.DrawString(Items[i].ToString(),
                        Font,
                        _foreColor.Negate(),
                        _textPaddingHorizontal + _textPaddingHorizontal,
                        y + _textPaddingVertical);
                }
                else
                {
                    e.Graphics.DrawString(Items[i].ToString(),
                        Font,
                        _foreColor,
                        _textPaddingHorizontal + _textPaddingHorizontal,
                        y + _textPaddingVertical);
                }

                y += _itemHeight;
            }
        }
    }
}
