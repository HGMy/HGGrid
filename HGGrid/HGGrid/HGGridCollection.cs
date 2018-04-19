using System;
using System.Collections.Generic;
using System.Text;

namespace HGGrid
{
    public abstract class HGGridCollection
    {
    }

    public class HGGridRowCollection : HGGridCollection 
    {
        private List<HGGridRow> _rows = new List<HGGridRow>();

        public HGGridRow this[int index]
        {
            get
            {
                if(index<0||index>=_rows.Count )
                {
                    throw new IndexOutOfRangeException();
                }
                return _rows[index];
            }
        }
    }

    public class HGGridColumnCollection : HGGridCollection
    {
        private List<HGGridColumn> _columns = new List<HGGridColumn>();

        private Dictionary<string, int> _columnKeyIndex = new Dictionary<string, int>();

        public HGGridColumn this[int index]
        {
            get
            {
                if (index < 0 || index >= _columns.Count)
                {
                    throw new IndexOutOfRangeException();
                }
                return _columns[index];
            }
        }



        public HGGridColumn this[string key]
        {
            get
            {
                if(!_columnKeyIndex.ContainsKey(key))
                {
                    throw new ArgumentOutOfRangeException();
                }
                return _columns[_columnKeyIndex[key]];
            }
        }

        public int Add(HGGridColumn column)
        {
            _columns.Add(column);
            column.ViewIndex = _columns.Count - 1;
            ResetColumnIndex();
            return _columns.Count;
        }

        internal void ResetColumnIndex()
        {
            _columnKeyIndex.Clear();

            for(int i=0;i<_columns.Count;i++)
            {
                _columns[i].Index = i;
                _columnKeyIndex[_columns[i].Key] = i;
            }
        }

        internal List<HGGridColumn> GetViewOrderColumn()
        {
            List<HGGridColumn> list = new List<HGGridColumn>();
            _columns.ForEach(a =>
            {
                if (list.Count <= 0)
                {
                    list.Add(a);
                }
                else
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (i == 0 && list[0].ViewIndex > a.ViewIndex)
                        {
                            list.Insert(0, a);
                        }
                        else if (i == list.Count - 1)
                        {
                            list.Add(a);
                        }
                        else
                        {
                            if (list[i].ViewIndex < a.ViewIndex && list[i + 1].ViewIndex > a.ViewIndex)
                            {
                                list.Insert(i + 1, a);
                                break;
                            }
                        }
                    }
                }
            });
            return list;
        }
    }
    public class HGGridCellCollection : HGGridCollection
    {
        private List<HGGridCell> _cells = new List<HGGridCell>();

        public HGGridCell this[int index]
        {
            get
            {
                if (index < 0 || index >= _cells.Count)
                {
                    throw new IndexOutOfRangeException();
                }
                return _cells[index];
            }
        }

        public HGGridCell this[string key]
        {
            get
            {
                return null;
            }
        }

        public HGGridCell this[HGGridColumn column]
        {
            get
            {
                return null;
            }
        }

        internal HGGridColumnCollection Columns { get; set; }
    }

}
