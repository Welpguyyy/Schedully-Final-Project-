﻿using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedully
{
    class circlebutton : Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath g = new GraphicsPath();
            g.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(g);
            base.OnPaint(pevent);
           
        }
    }
}
