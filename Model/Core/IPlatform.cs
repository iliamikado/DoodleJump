using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Core
{
    public interface IPlatform
    {
        public const double WIDTH = 50;
        public const double HEIGHT = 10;
        double X {  get; set; }
        double Y { get; set; }
        bool IsSteping(Player player);
        void Move(double y);
        void Step(Player player);
    }
}
