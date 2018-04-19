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

        public int ViewIndex { get; set; }

        public int Width { get; set; }





        internal HGGridColumn()
        {

        }
    }

    
}
