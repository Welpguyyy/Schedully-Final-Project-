using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedully
{
    class roundbutton:Button
    {
        class RoundedButton : Button
        {
            public int CornerRadius { get; set; } = 100; // Adjustable corner radius

            public RoundedButton()
            {
                this.FlatStyle = FlatStyle.Flat;
                this.FlatAppearance.BorderSize = 0;
                this.BackColor = Color.CadetBlue;
                this.ForeColor = Color.White;
                this.SetStyle(ControlStyles.UserPaint |
                              ControlStyles.AllPaintingInWmPaint |
                              ControlStyles.OptimizedDoubleBuffer, true);
            }

            private GraphicsPath GetRoundPath(Rectangle rect, int radius)
            {
                int diameter = radius * 2;
                GraphicsPath path = new GraphicsPath();

                path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90); // Top-left
                path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90); // Top-right
                path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90); // Bottom-right
                path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90); // Bottom-left
                path.CloseFigure();

                return path;
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);

                Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
                using (GraphicsPath path = GetRoundPath(rect, CornerRadius))
                {
                    this.Region = new Region(path);

                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    using (Pen pen = new Pen(Color.White, 2)) // Border color and thickness
                    {
                        e.Graphics.DrawPath(pen, path);
                    }
                }
            }
        }
    }
}
