using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreetRacer
{
    public class Car : GameObj
    {
        public float movementSpeed;
        public string name;
        public RectangleF collider;

        private bool isDrunk;
        public float startX;

        Random rand;
        private float movementFrequencyModifier;

        public Car(Image tex, Rectangle src, RectangleF pos, string n) : base(tex, src, pos)
        {
            name = n;
            collider = new RectangleF(pos.X + 40, pos.Y + 40, pos.Width - 80, pos.Height - 80);
        }

        public override void Update()
        {
            base.Update();
            pos.Y += movementSpeed;
            if (isDrunk)
                pos.X = startX + (float)Math.Sin(pos.Y * 0.01f * movementFrequencyModifier) * 50;
            collider.X = pos.X + 40;
            collider.Y = pos.Y + 40;
        }
        

        public static Car Create(in Car createFrom)
        {
            Car result = createFrom.MemberwiseClone() as Car;
            result.rand = new Random(DateTime.Now.Millisecond);

            result.movementFrequencyModifier = result.rand.Next(2, 13) / 10f;
            result.isDrunk = result.rand.Next(0, 100) > 70;

            return result;
        }
    }
}