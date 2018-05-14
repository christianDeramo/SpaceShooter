﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fast2Da
{
    interface IDrawable
    {
        DrawManager.Layer Layer { get;}
        void Draw();
    }
}
