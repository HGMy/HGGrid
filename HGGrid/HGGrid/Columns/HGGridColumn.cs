using System;
using System.Collections.Generic;
using System.Text;

namespace HGGrid
{
    public abstract class HGGridColumn : IHGGridStyle
    {
        public HGGridStyle Sytle { get; set; }

        public string Key { get; internal set; }

        public string Text { get; set; }

        public int Index { get; internal set; }

        public int Width { get; set; }
        public HGGridCell Header { get => _header; }

        private HGGridCell _header = new HGGridCell();



        internal HGGridColumn()
        {

        }

        public override bool Equals(object obj)
        {
            if (base.Equals(obj)) return true;
            if (obj is HGGridColumn hgc)
            {
                if (hgc.Key != this.Key) return false;
                return true;
            }
            else return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}", Key, Text);
        }
    }

    
}
