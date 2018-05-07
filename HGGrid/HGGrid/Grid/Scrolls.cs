using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace HGGrid
{
    partial class HGGrid
    {
        private HScrollBar _hScrollBar = new HScrollBar();

        private VScrollBar _vScrollBar = new VScrollBar();

        private void InitScrollBar()
        {
            Controls.Add(_hScrollBar);
            _hScrollBar.Top = _clientArea.Top + _clientArea.Height + 1;
            _hScrollBar.Left = 0;
            _hScrollBar.Width = _clientArea.Width;
            _hScrollBar.Height = ScrollBarWidthDefault;
            _hScrollBar.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            _hScrollBar.ValueChanged += (a, e) =>
            {
                //Refresh();
                DrawGrid(Graphics.FromHwnd(_clientArea.Handle));
            };


            Controls.Add(_vScrollBar);
            _vScrollBar.Top = 0;
            _vScrollBar.Left = _clientArea.Left + _clientArea.Width + 1;
            _vScrollBar.Width = ScrollBarWidthDefault;
            _vScrollBar.Height = _clientArea.Height;
            _vScrollBar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            _vScrollBar.ValueChanged += (a, e) =>
            {
                //Refresh();
                DrawGrid(Graphics.FromHwnd(_clientArea.Handle));
            };

            SetScrollBarStatus();
        }

        private void SetScrollBarStatus()
        {
            int totalWidth = 0;

            foreach(HGGridColumn hgc in _columns)
            {
                totalWidth += hgc.Width;
            }

            int htmp = _hScrollBar.Value;
            _hScrollBar.Minimum = 0;
            _hScrollBar.Maximum = totalWidth;
            _hScrollBar.SmallChange = 1;
            _hScrollBar.LargeChange = _clientArea.Width - RowHeaderWidth;
            if (htmp > totalWidth)
            {
                htmp = totalWidth;
            }
            _hScrollBar.Value = htmp;

            int totalHeight = 0;

            foreach(HGGridRow r in _rows)
            {
                totalHeight += r.Height;
            }

            int vtmp = _vScrollBar.Value;
            _vScrollBar.Minimum = 0;
            _vScrollBar.Maximum = totalHeight;
            _vScrollBar.SmallChange = 1;
            _vScrollBar.LargeChange = _clientArea.Height - ColumnHeaderHeight;
            if (vtmp > totalHeight)
            {
                vtmp = totalHeight;
            }
            _vScrollBar.Value = vtmp;
        }
    }
}
