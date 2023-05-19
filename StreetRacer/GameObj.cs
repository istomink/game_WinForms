using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StreetRacer
{
    public abstract class GameObj
    {
        public Image texture;
        public Rectangle src;
        public RectangleF pos;

        public GameObj(Image texture, Rectangle src, RectangleF pos)
        {
            this.texture = texture;
            this.src = src;
            this.pos = pos;
        }

        public void Draw(object sender, PaintEventArgs e) => e.Graphics.DrawImage(texture, pos, src, GraphicsUnit.Pixel);
        public virtual void Update() { }
    }
}