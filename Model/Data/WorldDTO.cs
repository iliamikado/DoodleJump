
using Model.Core;

namespace Model.Data;

public class WorldDTO
{
    public int PosistionPLayerX { get; set; }
    public int PosistionPlayerY { get; set; }
    public int[] PositionPlatformX { get; set; }
    public int[] PositionPlatformY { get; set; }
    public int Score { get; set; }
    public WorldDTO() { }
    public WorldDTO(World world)
    {
        PosistionPLayerX = (int)world.Player.X;
        PosistionPlayerY = (int)world.Player.Y;
        int dlinamassiva = world.Platforms.Length;
        for (int i = 0; i < dlinamassiva; i++)
        {
            PositionPlatformX[i] = (int)world.Platforms[i].X;
            PositionPlatformY[i] = (int)world.Platforms[i].Y;
        }
        Score = 0;
    }
}
