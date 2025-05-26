using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Core
{
    public partial class World
    {
        public void Telepot()
        {
            if (Player.X < 0) Player.X = WORLD_WIDTH + Player.X;
            else if (Player.X > WORLD_WIDTH) Player.X -= WORLD_WIDTH;
        }
    }
}
