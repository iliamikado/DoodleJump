using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Core.Platforms
{
    public interface IPlatform
    {
        public const double WIDTH = 50;
        public const double HEIGHT = 10;
        double X { get; set; }
        double Y { get; set; }
        Color Color { get; }
        bool IsSteping(Player player);
        void Move(double y);
        void Step(Player player);
    }
}
