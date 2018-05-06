using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Drawing;


namespace HGGrid
{
    partial class HGGrid
    {
        private DataTable _table;
        public DataTable Table
        {
            get { return _table; }
            set
            {
                _table = value;
            }
        }

        public void UpdateData()
        {
            if (_table == null) return;

            List<HGGridColumn> listC = new List<HGGridColumn>();
            List<HGGridRow> listR = new List<HGGridRow>();

            foreach(DataColumn dc in _table.Columns)
            {
                bool exist = false;
                for(int i=0;i<_columns.Count;i++)
                {
                    HGGridColumn hgc = _columns[i];
                    if(dc.ColumnName == hgc.Key )
                    {
                        exist = true;
                        hgc.Index = listC.Count;
                        listC.Add(hgc);
                        _columns.RemoveAt(i);
                        break;
                    }
                }

                if(!exist)
                {
                    HGGridTextBoxColumn hgtc = new HGGridTextBoxColumn();
                    hgtc.Key = dc.ColumnName;
                    hgtc.Text = dc.Caption;
                    hgtc.Width = ColumnWidthDefault;
                    hgtc.Index = listC.Count;
                    listC.Add(hgtc);
                }
            }

            _columns = listC;

            int pos = 0;
            while (pos < _rows.Count&&pos<_table.Rows.Count )
            {
                listR.Add(_rows[pos]);
                pos++;
            }
            while(pos<_rows.Count )
            {
                listR.Add(_rows[pos]);
                pos++;
            }
            while(pos<_table.Rows.Count )
            {
                HGGridRow r = new HGGridRow();
                r.Height = RowHeightDefault;
                r.Index = listR.Count;
                listR.Add(r);
                pos++;
            }
            _rows = listR;

            SetScrollBarStatus();

            Refresh();
        }
    }
}
