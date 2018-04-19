using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Drawing;

namespace HGGrid
{
    public class HGGrid : UserControl,IHGGridStyle
    {
        #region 数据
        private DataTable _table;
        public DataTable Table
        {
            get { return _table; }
            set
            {
                _table = value;
                UpdateData();
            }
        }

        private HGGridRowCollection _rows;
        public HGGridRowCollection Rows
        {
            get
            {
                return _rows;
            }
        }

        private HGGridColumnCollection  _columns;

        public HGGridColumnCollection Columns
        {
            get
            {
                return _columns;
            }
        }
        #endregion

        #region 外观
        public HGGridStyle Sytle { get; set; }

        private HGGridViewStyle _viewStyle = HGGridViewStyle.Default;
        public HGGridViewStyle ViewStyle
        {
            get
            {
                return _viewStyle;
            }
            set
            {
                _viewStyle = value;
                SetViewStyle();
            }
        }
        #endregion

        private void UpdateData()
        {
            
        }  

        private void SetViewStyle()
        {
            
        }

        public HGGrid()
        {
            Sytle = new HGGridStyle();

            _rows = new HGGridRowCollection();
            _columns = new HGGridColumnCollection();


            ViewStyle = HGGridViewStyle.Excel2016;
        }

        public HGGridRow NewRow()
        {
            var r = new HGGridRow();

            

            return r;
        }







        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            PaintControl(g);
        }

        private void PaintControl(Graphics g)
        {
            Font f = new Font("ms gothic", 16);
            g.DrawString("HGGRID v1.0.0", f, Brushes.Black, 0, 0);
            f.Dispose();
        }
    }

    
}
