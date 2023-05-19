using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StreetRacer
{
	public class Player : GameObj
	{
		public float coordX;
		public float coordY;
		public float movementSpeed;

		public string carName;

		public Player(Image _texture, Rectangle src, RectangleF pos) : base(_texture, src, pos)
		{
            coordX = base.pos.X;
            coordY = base.pos.Y;

			movementSpeed = 10f;
		}

		public override void Update()
		{
			base.Update();
			pos.X = (int)coordX;
			pos.Y = (int)coordY;
		}
	}
}