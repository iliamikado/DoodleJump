using Model.Core;
using System.Xml.Serialization;

namespace Model.Data;

public class SerializerXML : Serializer
{
    public override void Save(World world)
    {
        var serializer = new XmlSerializer(typeof(WorldDTO));
        using (var writer = new StreamWriter(FilePath))
        {
            serializer.Serialize(writer, new WorldDTO(world));
        }
    }

    public override void Load(World world)
    {
        var serializer = new XmlSerializer(typeof(WorldDTO));
        using (var reader = new StreamReader(FilePath))
        {
            var deser = (WorldDTO)serializer.Deserialize(reader);
            var PlayerX = deser.PositionPlayerX;
            var PlayerY = deser.PositionPlayerY;
            var PlatformX = deser.PositionPlatformX;
            var PlatformY = deser.PositionPlatformY;
            var Score = deser.Score;
            var Platformtypes = deser.PlatformTypes;
            world.LoadWorld(PlayerX, PlayerY, PlatformX,PlatformY,Score,Platformtypes);
        }
        
    }  
}
