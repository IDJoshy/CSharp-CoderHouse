using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.Design
{
    public class CustomPanel : Panel
    {
        #region Borders
        private int _borderRadius = 0;
        private bool _applyBorder = false;

        private Color _colorTop = Color.White;
        private Color _colorBottom = Color.White;

        [Category("Custom Values")]
        public int BorderRadius
        {
            get => _borderRadius;
            set
            {
                if (value <= this.Height)
                {
                    _borderRadius = value;
                }
                else
                {
                    _borderRadius = this.Height;
                }
                this.Invalidate();
            }
        }
        [Category("Custom Values")]
        public bool ApplyBorder { get => _applyBorder; set { _applyBorder = value; this.Invalidate(); } }
        [Category("Custom Values")]
        public Color ColorTop { get => _colorTop; set { _colorTop = value; this.Invalidate(); } }
        [Category("Custom Values")]
        public Color ColorBottom { get => _colorBottom; set { _colorBottom = value; this.Invalidate(); } }

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

        #endregion

        public CustomPanel()
        {
            this.Resize += new EventHandler(Panel_Resize);
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Panel_BackColorChanged);
        }

        private void Panel_BackColorChanged(Object sender, EventArgs e)
        {
            if (this.DesignMode) this.Invalidate();
        }

        private void Panel_Resize(object sender, EventArgs e)
        {
            if (_borderRadius > this.Height)
            {
                _borderRadius = this.Height;
            }
        }


        protected override void OnPaint(PaintEventArgs e)
        {

            LinearGradientBrush b = new LinearGradientBrush(this.ClientRectangle, this.ColorTop, this.ColorBottom, 90f);
            Graphics g = e.Graphics;
            g.FillRectangle(b, this.ClientRectangle);

            if (_applyBorder)
            {
                RectangleF rectangleF = new RectangleF(0, 0, this.Width, this.Height);

                if (_borderRadius > 2)
                {
                    using (GraphicsPath path = GetPath(rectangleF, _borderRadius))
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
            }

            base.OnPaint(e);
        }
    }
}
