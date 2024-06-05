using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace Desktop.Design
{
    public class CustomButton : Button
    {
        private int borderSize = 0;
        private int borderRadius = 40;
        private Color borderColor = Color.PaleVioletRed;

        [Category("Custom Values")]
        public int BorderSize { get => borderSize; set { borderSize = value; this.Invalidate(); } }
        [Category("Custom Values")]
        public int BorderRadius 
        { 
            get => borderRadius; 
            set 
            {
                if (value <= this.Height)
                {
                    borderRadius = value;
                }
                else 
                {
                    borderRadius = this.Height;
                }
                this.Invalidate();
            } 
        }
        [Category("Custom Values")]
        public Color BorderColor { get => borderColor; set { borderColor = value; this.Invalidate(); } }
        [Category("Custom Values")]
        public Color BackGroundColor { get { return this.BackColor; } set { BackColor = value; } }
        [Category("Custom Values")]
        public Color TextColor { get { return this.ForeColor; } set { this.ForeColor = value; } }


        public CustomButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150,40);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.WhiteSmoke;

            this.Resize+= new EventHandler(Button_Resize);

        }

        private GraphicsPath GetPath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180,90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path; 
        }

        

        protected override void OnPaint(PaintEventArgs e) 
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectSurface = new(0,0,this.Width,this.Height);
            RectangleF rectBorder = new(1, 1, this.Width - 0.8f, this.Height - 1);

            if (borderRadius > 2) 
            {
                using (GraphicsPath pathSurface = GetPath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetPath(rectBorder, borderRadius - 1f))
                using (Pen penSurface = new Pen(this.Parent.BackColor, 2))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    this.Region = new(pathSurface);
                    e.Graphics.DrawPath(penSurface, pathSurface);

                    if (borderSize >= 1) 
                    {
                        e.Graphics.DrawPath(penBorder, pathBorder);
                    }
                }
            }
            else
            {
                this.Region = new Region(rectSurface);

                if(borderSize >= 1)
                {
                    using(Pen penBorder = new(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        e.Graphics.DrawRectangle(penBorder, 0,0,this.Width- 1f, this.Height-1f);
                    }
                }
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(Object sender, EventArgs e)
        {
            if(this.DesignMode) this.Invalidate();
        }

        private void Button_Resize(object sender, EventArgs e)
        {
            if (borderRadius > this.Height)
            {
                borderRadius = this.Height;
            }
        }

    }
}
