﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Core.Platforms
{
    public abstract class Platform : IPlatform
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double JumpPower = 500;
        public virtual Color Color => Color.Green;

        public bool IsSteping(Player player)
        {
            if (player == null) return false;
            if (player.Speed > 0) return false;
            if (X < player.X + Player.WIDTH && player.X < X + IPlatform.WIDTH &&
                Y < player.Y && player.Y + player.Speed * World.Delta < Y + IPlatform.HEIGHT) return true;
            return false;
        }

        public void Move(double y)
        {
            Y -= y;
        }

        public virtual void Step(Player p)
        {
            p.Speed = JumpPower;
        }
    }
}
