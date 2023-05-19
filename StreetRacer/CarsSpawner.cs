using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreetRacer
{
    public class CarsSpawner
    {
        public static List<Car> possibleCars { get; private set; }
        public static void InitializeSpawner()
        {
            possibleCars = new List<Car>()
            {
                new Car(new Bitmap(new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\Resources\\car1.png"),
                new Rectangle(0, 0, 400, 745),
                new RectangleF(0, 0, 80, 745f / 400f * 80f),
                "car1"),

                new Car(new Bitmap(new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\Resources\\car2.png"),
                new Rectangle(0, 0, 185, 368),
                new RectangleF(0, 0, 80, 368f / 185f * 80f),
                "car2"),

                new Car(new Bitmap(new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\Resources\\car3.png"),
                new Rectangle(0, 0, 453, 800),
                new RectangleF(0, 0, 80, 800f / 453f * 80f),
                "car3"),
            };
        }
        public static Car SpawnCar(float atX)
        {
            Random rand = new Random((int)(atX * 100));
            int index = rand.Next(possibleCars.Count());

            RectangleF pos = new RectangleF(atX, -possibleCars[index].pos.Height, possibleCars[index].pos.Width, possibleCars[index].pos.Height);

            Car result = Car.Create(possibleCars[index]);
            result.pos = pos;
            result.startX = result.pos.X;
            result.movementSpeed = rand.Next(70, 100) / 10f;
            return result;
        }
    }
}