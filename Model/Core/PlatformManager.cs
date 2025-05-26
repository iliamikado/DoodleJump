using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Core
{
    public class PlatformManager
    {
        public const int STEP = 100;
        public IPlatform[] Platforms { get; set; }
        private Random rnd;
        private double top = 100;

        public PlatformManager(int prepared_platforms)
        {
            Platforms = new IPlatform[prepared_platforms];
            rnd = new Random();
        }
        public void Move(double y)
        {
            top -= y;
            foreach (var pl in Platforms)
            {
                pl.Move(y);
                if (pl.Y < 0)
                {
                    pl.Y = top;
                    pl.X = GetRandomX();
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

        private double GetRandomX()
        {
            return rnd.Next((int) (World.WORLD_WIDTH - IPlatform.WIDTH));
        }
    }
}
