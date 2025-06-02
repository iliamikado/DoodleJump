using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Core.Platforms
{
    public class PlatformManager
    {
        public const int STEP = 100;
        public IPlatform[] Platforms { get; set; }
        private Random rnd;
        private double top = 100;
        private bool lastBroken = false;

        public PlatformManager(int prepared_platforms)
        {
            Platforms = new IPlatform[prepared_platforms];
            rnd = new Random();
        }
        public void Move(double y)
        {
            top -= y;
            for (int i = 0; i < Platforms.Length; i++)
            {
                var pl = Platforms[i];
                pl.Move(y);
                if (pl.Y < 0)
                {
                    pl = GetRandomPlatfrom();
                    pl.Y = top;
                    pl.X = GetRandomX();
                    Platforms[i] = pl;
                    top += STEP;
                }
            }
        }
        public void SetStartingPlatfroms()
        {

            for (int i = 0; i < Platforms.Length; i++)
            {
                var p = new BasicPlatform();
                p.X = GetRandomX();
                p.Y = top;
                top += STEP;
                Platforms[i] = p;
            }
            Platforms[0].X = World.WORLD_WIDTH / 2 - IPlatform.WIDTH / 2;
            Platforms[0].Y = 100;
        }

        public void SetPlatforms(int[] platformsX, int[] platformsY, string[] platformsType)
        {
            for (int i = 0; i < platformsX.Length; i++)
            {
                IPlatform pl = new BasicPlatform();
                switch (platformsType[i])
                {
                    case "BasicPlatform":
                        pl = new BasicPlatform();
                        break;
                    case "OneJumpPlatform":
                        pl = new OneJumpPlatform();
                        break;
                    case "HighJumpPlatform":
                        pl = new HighJumpPlatform();
                        break;
                    case "BrokenPlatfrom":
                        pl = new BrokenPlatfrom();
                        break;
                }
                Platforms[i] = pl;
                Platforms[i].X = platformsX[i];
                Platforms[i].Y = platformsY[i];
                top = platformsY.OrderByDescending(x => x).ToArray()[0] += STEP;
            }
        }

        private double GetRandomX()
        {
            return rnd.Next((int)(World.WORLD_WIDTH - IPlatform.WIDTH));
        }

        private IPlatform GetRandomPlatfrom()
        {
            var x = rnd.Next(11);
            if (x == 10 && !lastBroken)
            {
                lastBroken = true;
                return new BrokenPlatfrom();
            }
            lastBroken = false;
            if (x == 9 || x == 8) return new OneJumpPlatform();
            if (x == 7) return new HighJumpPlatform();
            return new BasicPlatform();
        }
    }
}
