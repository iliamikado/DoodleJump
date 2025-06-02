using System.Runtime.CompilerServices;
using System.Text.Json.Nodes;
using Model.Core;
using Newtonsoft.Json.Linq;

namespace Model.Data;

public class SerializerJSON : Serializer
{
    public override void Save(World world)
    {
        var json = JObject.FromObject(new WorldDTO(world));
        File.WriteAllText(FilePath, json.ToString());
    }
    public override void Load(World world)
    {
        var content = File.ReadAllText(FilePath);
        var deser = JObject.Parse(content);
        var PlayerX = deser["PositionPlayerX"].ToObject<int>();
        var PlayerY = deser["PositionPlayerY"].ToObject<int>();
        var PlatformX = deser["PositionPlatformX"].ToObject<int[]>();
        var PlatformY = deser["PositionPlatformY"].ToObject<int[]>();
        var Score = deser["Score"].ToObject<int>();
        var Platformtypes = deser["PlatformTypes"].ToObject<string[]>();
        world.LoadWorld(PlayerX, PlayerY, PlatformX,PlatformY,Score,Platformtypes);
        
    }
    
}
