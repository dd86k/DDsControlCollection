using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Collections;
using System.Diagnostics;
using System.ComponentModel;

namespace DDsControlCollection
{
    public class PrettyTreeView : Control
    {
        public PrettyTreeView()
        {
            _textPaddingVertical = 2;
            _textPaddingHorizontal = 2;
            _nodes = new TreeNode().Nodes;
            //_nodes.Clear();
        }

        int _textHeight;
        int _itemHeight;

        TreeNodeCollection _nodes;
        public TreeNodeCollection Nodes
        {
            get { return _nodes; }
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

        TreeNode _selectedNode;
        [Browsable(false)]
        public TreeNode SelectedNode
        {
            get { return _selectedNode; }
            set
            {
                _selectedNode = value;

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
            //TODO: get subnode on mouse down
            _selectedNode = _nodes[e.Y / _itemHeight];

            Invalidate();

            Debug.WriteLine(_selectedNode);

            base.OnMouseDown(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            int y = 0;
            _textHeight = (int)e.Graphics.MeasureString("Aa", Font).Height;
            _itemHeight = _textHeight + (_textPaddingVertical * 2);

            for (int i = 0; i < _nodes.Count; i++)
            {
                if (_nodes[i] == _selectedNode)
                    e.Graphics.FillRectangle(_focusColor,
                        0, y,
                        Width, _itemHeight);

                e.Graphics.DrawString(_nodes[i].Text,
                    Font,
                    _foreColor,
                    _textPaddingHorizontal + (_textPaddingHorizontal* _nodes[i].Level),
                    y + _textPaddingVertical);

                y += _itemHeight;
            }
        }
    }
}
