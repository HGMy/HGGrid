using System;
using System.Collections.Generic;
using System.Text;

namespace HGGrid
{
    public sealed class HGGridRow : IHGGridStyle
    {

        public int Height { get; set; }

        public int Index { get; internal set; }

        private HGGridCell _header;

        private List<HGGridCell> _cells;


        public HGGridStyle Sytle { get; set; }
        public HGGridCell Header { get => _header;  }
        public List<HGGridCell> Cells { get => _cells;  }

        internal HGGridRow ()
        {
            _header = new HGGridCell();
            _cells = new List<HGGridCell>();
        }
    }

    
}
