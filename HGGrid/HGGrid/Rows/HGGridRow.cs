using System;
using System.Collections.Generic;
using System.Text;

namespace HGGrid
{
    public sealed class HGGridRow : IHGGridStyle
    {

        public int Height { get; set; }

        public int Index { get; internal set; }

        private HGGridCellCollection _cells;
        public HGGridCellCollection Cells
        {
            get
            {
                return _cells;
            }
        }


        public HGGridStyle Sytle { get; set; }


        internal HGGridRow ()
        {
            _cells = new HGGridCellCollection();
        }
    }

    
}
