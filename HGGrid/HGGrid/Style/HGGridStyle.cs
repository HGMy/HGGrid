using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace HGGrid
{
    public class HGGridStyle
    {
        private bool _isOwnDraw = false;

        private Font _font;

        private Image _backImage;

        private Color _backColor;

        public bool IsOwnDraw { get => _isOwnDraw; set => _isOwnDraw = value; }
        public Font Font { get => _font; set => _font = value; }
        public Image BackImage { get => _backImage; set => _backImage = value; }
        public Color BackColor { get => _backColor; set => _backColor = value; }
    }

    public interface IHGGridStyle
    {
        HGGridStyle Sytle { get; set; }
    }
}
