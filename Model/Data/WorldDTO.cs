
using Model.Core;

namespace Model.Data;

public class WorldDTO
{
    public int PositionPlayerX { get; set; }
    public int PositionPlayerY { get; set; }
    public int[] PositionPlatformX { get; set; }
    public int[] PositionPlatformY { get; set; }
    public int Score { get; set; }
    public string[] PlatformTypes { get; set; }
    public WorldDTO() { }
    public WorldDTO(World world)
    {
        PositionPlayerX = (int)world.Player.X;
        PositionPlayerY = (int)world.Player.Y;
        int dlinamassiva = world.Platforms.Length;
        PositionPlatformX = new int[dlinamassiva];
        PositionPlatformY = new int[dlinamassiva];
        PlatformTypes = new string[dlinamassiva];
        for (int i = 0; i < dlinamassiva; i++)
        {
            PositionPlatformX[i] = (int)world.Platforms[i].X;
            PositionPlatformY[i] = (int)world.Platforms[i].Y;
        }
        Score = world.Score;
        for (int i = 0; i < dlinamassiva; i++)
        {
            PlatformTypes[i] = world.Platforms[i].GetType().Name;
        }
    }
}
