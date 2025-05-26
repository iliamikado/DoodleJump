using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Core
{
    public class Player
    {
        public const int WIDTH = 50;
        public const int HEIGHT = 50;
        public double X { get; set; }
        public double Y { get; set; }
        public bool IsMirrored { get; set; }
        public double Speed { get; set; }
        public void MoveH(double x)
        {
            if (x < 0) IsMirrored = true;
            else if (x > 0) IsMirrored = false;
            X += x;
        }

        public void MoveV(double y)
        {
            Y += y;
        }
    }
}
