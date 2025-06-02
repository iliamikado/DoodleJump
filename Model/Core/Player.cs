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

        private void MoveV(double y)
        {
            Y += y;
        }

        public static Player operator +(Player p, double y)
        {
            p.MoveV(y);
            return p;
        }

        public override string ToString()
        {
            return $"X: {X}; Y: {Y}; Speed: {Speed}";
        }
    }
}
