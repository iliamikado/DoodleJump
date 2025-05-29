
using Model.Core;

namespace Model.Data;

public class WorldDTO
{
    public int PosistionPlayerX { get; set; }
    public int PosistionPlayerY { get; set; }
    public int[] PositionPlatformX { get; set; }
    public int[] PositionPlatformY { get; set; }
    public int Score { get; set; }
    public WorldDTO() { }
    public WorldDTO(World world)
    {
        PosistionPlayerX = (int)world.Player.X;
        PosistionPlayerY = (int)world.Player.Y;
        int dlinamassiva = world.Platforms.Length;
        PositionPlatformX = new int[dlinamassiva];
        PositionPlatformY = new int[dlinamassiva];
        for (int i = 0; i < dlinamassiva; i++)
        {
            PositionPlatformX[i] = (int)world.Platforms[i].X;
            PositionPlatformY[i] = (int)world.Platforms[i].Y;
        }
        Score = world.Score;
    }
}
