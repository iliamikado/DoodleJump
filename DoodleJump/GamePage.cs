using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model.Core;

namespace DoodleJump
{
    public partial class GamePage : Form
    {
        private System.Windows.Forms.Timer gameTimer;
        private World world;

        private Image rightImage;
        private Image leftImage;
        private PictureBox[] platformsPics;
        private PlayerIcon playerIcon;
        public GamePage()
        {
            InitializeComponent();

            // Главное API с логикой
            world = new World();

            // Размеры игрового поля
            Width = World.WORLD_WIDTH;
            Height = World.WORLD_HEIGHT;

            // Настройка таймера для вызова функции update
            gameTimer = new System.Windows.Forms.Timer();
            gameTimer.Interval = (int)(World.Delta * 100);
            gameTimer.Tick += Update;
            gameTimer.Start();

            // Настройка клавиатуры
            KeyPreview = true;
            KeyDown += MyKeyDown;
            KeyUp += MyKeyUp;

            // Две картинки для отзеркаливания персонажа
            string imagePath = Path.Combine(Application.StartupPath, "assets/player.png");
            var img = Image.FromFile(imagePath);
            rightImage = (Image)img.Clone();
            leftImage = (Image)img.Clone();
            leftImage.RotateFlip(RotateFlipType.RotateNoneFlipX);

            // Предсоздание платформ
            platformsPics = new PictureBox[World.PREPARED_PLATFORMS];
            for (int i = 0; i < World.PREPARED_PLATFORMS; i++)
            {
                var p = new PictureBox();
                p.Size = new Size((int)IPlatform.WIDTH, (int)IPlatform.HEIGHT);
                p.BackColor = Color.Green;
                platformsPics[i] = p;
                Controls.Add(p);
            }

            // Создание персонажа
            playerIcon = new PlayerIcon();
            playerIcon.Image = img;
            playerIcon.Size = new Size(Player.WIDTH, Player.HEIGHT);
            playerIcon.Show();
            playerIcon.BackColor = Color.Transparent;
            Controls.Add(playerIcon);
        }

        private void GamePage_Load(object sender, EventArgs e)
        {

        }

        private void Update(object? sender, EventArgs e)
        {
            world.Update();
            Redraw();
        }

        private void Redraw()
        {
            playerIcon.Left = (int)world.Player.X;
            playerIcon.Top = (int)(World.WORLD_HEIGHT - world.Player.Y - Player.HEIGHT);
            playerIcon.Image = world.Player.IsMirrored ? leftImage : rightImage;

            for (int i = 0; i < platformsPics.Length; i++)
            {
                platformsPics[i].Location = new Point((int)world.Platforms[i].X, (int)(World.WORLD_HEIGHT - world.Platforms[i].Y));
                platformsPics[i].BackColor = world.Platforms[i].Color;
            }
        }

        private void MyKeyDown(object? sender, KeyEventArgs e)
        {
            Console.WriteLine("Key down");
            switch (e.KeyCode)
            {
                case Keys.A:
                    world.SetLeft();
                    break;
                case Keys.D:
                    world.SetRight();
                    break;
                case Keys.Space:
                    world.Paused = !world.Paused;
                    break;
            }
        }
        private void MyKeyUp(object? sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    world.UnSetLeft();
                    break;
                case Keys.D:
                    world.UnSetRight();
                    break;
            }
        }
    }
    public class PlayerIcon : PictureBox
    {
        public PlayerIcon()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            if (Image != null)
            {
                e.Graphics.DrawImage(Image,
                    new Rectangle(0, 0, this.Width, this.Height),
                    0, 0, Image.Width, Image.Height,
                    GraphicsUnit.Pixel);
            }
        }
    }
}
