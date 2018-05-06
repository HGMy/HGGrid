using System;
using System.Collections.Generic;
using System.Text;

namespace HGGrid
{
    partial class HGGrid
    {
        #region 外观
        public HGGridStyle Sytle { get; set; }

        private HGGridViewStyle _viewStyle = HGGridViewStyle.Excel2016;
        public HGGridViewStyle ViewStyle
        {
            get
            {
                return _viewStyle;
            }
            set
            {
                _viewStyle = value;
                SetViewStyle();
            }
        }
        #endregion

        private void SetViewStyle()
        {

        }
    }
}
