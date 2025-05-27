using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Core
{
    public class BrokenPlatfrom : BasicPlatform
    {
        public override Color Color => Color.Brown;

        public override void Step(Player p)
        {
            Y = -400;
        }
    }
}
