using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace HGGrid
{
    partial class HGGrid
    {
        private void DrawScrollsExcel2016(Graphics g)
        {

        }

        private void DrawColumnHeaderExcel2016(Graphics g)
        {
            Rectangle rec = new Rectangle(0, 0, RowHeaderWidth, ColumnHeaderHeight);
            Pen bp = new Pen(Brushes.Black, 2);
            g.DrawRectangle(bp, rec);

            foreach (HGGridColumn hgc in Columns)
            {
                rec = new Rectangle(rec.Left + rec.Width, 0, hgc.Width, ColumnHeaderHeight);
                g.FillRectangle(Brushes.AliceBlue, rec);
                g.DrawRectangle(bp, rec);
                if (rec.Left + rec.Width > _clientArea.Width) break;
            }

            bp.Dispose();
        }

        private void DrawRowHeaderExcel2016(Graphics g)
        {
            Rectangle rec = new Rectangle(0, 0, RowHeaderWidth, ColumnHeaderHeight);
            Pen bp = new Pen(Brushes.Black, 2);

            foreach (HGGridRow r in _rows)
            {
                rec = new Rectangle(0, rec.Top + rec.Height, RowHeaderWidth, r.Height);
                g.FillRectangle(Brushes.AliceBlue, rec);
                g.DrawRectangle(bp, rec);
                if (rec.Top + rec.Height > _clientArea.Height) break;
            }

            bp.Dispose();
        }

        private void DrawCellsExcel2016(Graphics g)
        {
            Rectangle rec = new Rectangle(0,0, RowHeaderWidth, ColumnHeaderHeight);
            Pen bp = new Pen(Brushes.Black, 1);

            int ox = RowHeaderWidth;
            int oy = ColumnHeaderHeight;

            int x = ox;
            int y = oy;

            int ry = 0;
            bool bdy = false;
            foreach (HGGridRow r in _rows)
            {
                if(!bdy)
                {
                    if(ry+r.Height<_vScrollBar.Value )
                    {
                        ry += r.Height;
                        continue;
                    }
                    else
                    {
                        bdy = true;
                        int suby = _vScrollBar.Value - ry;
                        y -= suby;
                    }
                }


                int rx = 0;
                bool bd = false;
                foreach (HGGridColumn hgc in _columns)
                {
                    if (!bd)
                    {
                        if (rx + hgc.Width < _hScrollBar.Value)
                        {
                            rx += hgc.Width;
                            continue;
                        }
                        else
                        {
                            bd = true;

                            int subx = _hScrollBar.Value - rx;
                            x -= subx;
                        }
                    }

                    rec = new Rectangle(x, y, hgc.Width, r.Height);
                    g.FillRectangle(Brushes.White, rec);
                    g.DrawRectangle(bp, rec);

                    g.DrawString(_table.Rows[r.Index][hgc.Index].ToString(), this.Font, Brushes.Black, x + 2, y + 2);

                    x += hgc.Width;

                    if (x > _clientArea.Width) break;
                }
                y += r.Height;
                x = ox;
                if (y > _clientArea.Height) break;
            }

            bp.Dispose();
        }
    }
}
