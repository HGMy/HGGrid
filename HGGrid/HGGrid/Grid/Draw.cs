using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace HGGrid
{
    partial class HGGrid
    {
        private Panel _clientArea;

        private Bitmap _canvas = null;

        private void DrawGrid(Graphics g)
        {
            if (_canvas == null || _canvas.Width != _clientArea.Width || _clientArea.Height != _canvas.Height)
            {
                Bitmap bmp = new Bitmap(_clientArea.Width, _clientArea.Height);
                if (_canvas != null)
                {
                    _canvas.Dispose();
                }
                _canvas = bmp;
            }

            PaintControl(Graphics.FromImage(_canvas));

            g.DrawImage(_canvas, _clientArea.Left, _clientArea.Top);
            
        }

        private void PaintControl(Graphics g)
        {

            DrawCells(g, this.ViewStyle);

            DrawColumnHeader(g, this.ViewStyle);

            DrawRowHeader(g, this.ViewStyle);

            
        }

        
    }
}
