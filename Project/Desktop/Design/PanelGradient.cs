using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.Design
{
    public class PanelGradient : Panel
    {
        public Color top {  get; set; }
        public Color bottom { get; set; }

        public float borderRadius { get; set; } = 30f;


        private GraphicsPath GetPath(RectangleF rectangleF, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rectangleF.Width - radius, rectangleF.Height - radius, radius, radius, 0, 90);
            path.AddArc(rectangleF.X, rectangleF.Height - radius, radius, radius, 90, 90);
            path.AddArc(rectangleF.X, rectangleF.Y, radius, radius, 180, 90);
            path.AddArc(rectangleF.Width - radius, rectangleF.Y, radius, radius, 270, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush b = new LinearGradientBrush(this.ClientRectangle, this.top, this.bottom, 90f);
            Graphics g = e.Graphics;
            g.FillRectangle(b, this.ClientRectangle);

            RectangleF rectangleF = new RectangleF(0,0, this.Width, this.Height);

            if(borderRadius > 2)
            {
                using (GraphicsPath path = GetPath(rectangleF, borderRadius))
                using (Pen pen = new(this.Parent.BackColor, 2))
                {
                    this.Region = new(path);
                    e.Graphics.DrawPath(pen, path);
                }
            }
            else 
            {
                this.Region = new(rectangleF);
            }

            base.OnPaint(e);
        }
    }
}
