using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediManage
{
    internal class GradientPanel : Panel
    {
        public Color TopColor { get; set; }
        public Color BottomColor { get; set; }
        public float Angle { get; set; }

        public GradientPanel()
        {
            this.Resize += GradientPanel_Resize;
        }

        private void GradientPanel_Resize(object sender, EventArgs e)
        {
            this.Invalidate(); // Force the panel to redraw itself
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, this.TopColor, this.BottomColor, this.Angle))
            {
                Graphics g = e.Graphics;
                g.FillRectangle(brush, this.ClientRectangle);
            }
            base.OnPaint(e);
        }
    }
}
