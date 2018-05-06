using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Drawing;

namespace HGGrid
{
    public partial class HGGrid : UserControl,IHGGridStyle
    {
        private List<HGGridColumn> _columns;

        private List<HGGridRow> _rows;

        private int _rowHeaderWidth = ColumnWidthDefault;

        private int _columnHeaderHeight = RowHeightDefault;

        public HGGrid()
        {
            Sytle = new HGGridStyle();
            ViewStyle = HGGridViewStyle.Excel2016;

            _rows = new List<HGGridRow>();
            _columns = new List<HGGridColumn>();

            _clientArea = new Panel();
            Controls.Add(_clientArea);
            _clientArea.Left = 0;
            _clientArea.Top = 0;
            _clientArea.Width = this.Width - ScrollBarWidthDefault;
            _clientArea.Height = this.Height - ScrollBarWidthDefault;
            _clientArea.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;
            _clientArea.Paint += (a, e) =>
            {
                DrawGrid(e.Graphics);
            };

            InitScrollBar();
        }

        public List<HGGridRow> Rows { get => _rows;}
        public List<HGGridColumn> Columns { get => _columns;}
        public int RowHeaderWidth { get => _rowHeaderWidth; set => _rowHeaderWidth = value; }
        public int ColumnHeaderHeight { get => _columnHeaderHeight; set => _columnHeaderHeight = value; }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // HGGrid
            // 
            this.Name = "HGGrid";
            this.Size = new System.Drawing.Size(850, 498);
            this.ResumeLayout(false);

        }

        protected override void OnResize(EventArgs e)
        {
            SetScrollBarStatus();
            base.OnResize(e);
        }
    }

    
}
