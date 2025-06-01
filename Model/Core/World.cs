using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Core
{
    public partial class World
    {
        public const double HorizontSpeed = 200;
        public const double Delta = 0.03;
        public const int WORLD_HEIGHT = 600;
        public const int WORLD_WIDTH = 400;
        public const int PREPARED_PLATFORMS = 10;
        public const double GRAVITY = 15;
        public Player Player { get; private set; }
        public int Score => (int)_score / 100;
        private double _score = 0;
        public bool Paused { get; set; }
        public IPlatform[] Platforms => platformManager.Platforms;
        private bool toRight = false;
        private bool toLeft = false;
        private PlatformManager platformManager;

        public World()
        {
            Player = new Player();
            Player.X = WORLD_WIDTH / 2;
            Player.Y = 200;
            platformManager = new PlatformManager(PREPARED_PLATFORMS);
        }

        public void LoadNewWorld()
        {
            platformManager.SetStartingPlatfroms();
        }
        public void LoadWorld(int playerX, int playerY, int[] platformsX, int[] platformsY, int score)
        {
            Player.X = playerX; Player.Y = playerY;
            platformManager.SetPlatforms(platformsX, platformsY);
            _score = score * 100;
        }
        public void Update()
        {
            if (Paused) return;
            var horisontMove = 0.0;
            if (toRight) horisontMove += HorizontSpeed;
            if (toLeft) horisontMove -= HorizontSpeed;
            Player.MoveH(horisontMove * Delta);

            Player.Speed -= GRAVITY;
            if (Player.Speed < 0) Player.MoveV(Delta * Player.Speed);
            else
            {
                if (Player.Y < WORLD_HEIGHT / 2) Player.MoveV(Delta * Player.Speed);
                else
                {
                    platformManager.Move(Delta * Player.Speed);
                    _score += Delta * Player.Speed;
                }
            }

            foreach (var platform in Platforms)
            {
                if (platform.IsSteping(Player)) platform.Step(Player);
            }

            if (Player.Y < 0) Paused = true;
            Telepot();
        }

        public void SetRight() { toRight = true; }
        public void UnSetRight() { toRight = false; }
        public void SetLeft() { toLeft = true; }
        public void UnSetLeft() { toLeft = false; }
    }
}
