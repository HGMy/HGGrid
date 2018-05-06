using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace HGGrid
{
    public enum HGGridViewStyle
    {
        Excel2016
    }

    partial class HGGrid
    {
        private void DrawScrolls(Graphics g, HGGridViewStyle style)
        {
            switch(style )
            {
                case HGGridViewStyle.Excel2016:
                    DrawScrollsExcel2016(g);
                    break;
            }
        }

        private void DrawColumnHeader(Graphics g, HGGridViewStyle style)
        {
            switch (style)
            {
                case HGGridViewStyle.Excel2016:
                    DrawColumnHeaderExcel2016(g);
                    break;
            }
        }

        private void DrawRowHeader(Graphics g, HGGridViewStyle style)
        {
            switch (style)
            {
                case HGGridViewStyle.Excel2016:
                    DrawRowHeaderExcel2016(g);
                    break;
            }
        }

        private void DrawCells(Graphics g, HGGridViewStyle style)
        {
            switch (style)
            {
                case HGGridViewStyle.Excel2016:
                    DrawCellsExcel2016(g);
                    break;
            }
        }
    }
}
