using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Core.Platforms
{
    public class HighJumpPlatform : Platform
    {
        public override Color Color => Color.Pink;

        public override void Step(Player p)
        {
            p.Speed = JumpPower * 2;
        }
    }
}
