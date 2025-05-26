using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Core
{
    public class OneJumpPlatform : BasicPlatform
    {
        public override Color Color => Color.Gray;

        public override void Step(Player p)
        {
            base.Step(p);
            Y = -400;
        }
    }
}
