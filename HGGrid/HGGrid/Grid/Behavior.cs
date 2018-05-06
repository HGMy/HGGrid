using System;
using System.Collections.Generic;
using System.Text;

namespace HGGrid
{
    partial class HGGrid
    {
        private bool _isReadOnly = false;

        public bool IsReadOnly { get => _isReadOnly; set => _isReadOnly = value; }
    }
}
