using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace DDsControlCollection
{
    public class PrettyListBox : Control
    {
        public PrettyListBox()
        {
            _textPaddingVertical = 2;
            _textPaddingHorizontal = 2;
            _collection = new List<object>();
            //_nodes.Clear();
        }

        int _textHeight;
        int _itemHeight;

        ICollection<object> _collection;
        public ListBox.ObjectCollection Items
        {
            //TODO: fix
            get { return (ListBox.ObjectCollection)_collection.Cast< ListBox.ObjectCollection>(); }
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
        public object SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                if (!Items.Contains(value))
                    throw new ArgumentOutOfRangeException();

                _selectedItem = value;

                Invalidate();
            }
        }
        int _index;
        public int SelectedIndex
        {
            get { return _index; }
            set
            {
                if (value > _collection.Count || value < -1)
                    throw new IndexOutOfRangeException();

                if (value == -1)
                    _index = -1;

                _selectedItem = _collection.ElementAt(_index = value);

                Invalidate();
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
            get { return _focusColor.Color; }
            set
            {
                _foreColor = new SolidBrush(value);

                Invalidate();
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            _selectedItem = Items[e.Y / _itemHeight];

            Invalidate();

            base.OnMouseDown(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            int y = 0;
            _textHeight = (int)e.Graphics.MeasureString("Aa", Font).Height;
            _itemHeight = _textHeight + (_textPaddingVertical * 2);

            for (int i = 0; i < _collection.Count; i++)
            {
                if (Items[i] == _selectedItem)
                    e.Graphics.FillRectangle(_focusColor,
                        0, y,
                        Width, _itemHeight);

                e.Graphics.DrawString(Items[i].ToString(),
                    Font,
                    _foreColor,
                    _textPaddingHorizontal + _textPaddingHorizontal,
                    y + _textPaddingVertical);

                y += _itemHeight;
            }
        }
    }
}
