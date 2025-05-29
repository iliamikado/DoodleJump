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
            var PlayerX = deser.PosistionPlayerX;
            var PlayerY = deser.PosistionPlayerY;
            var PlatformX = deser.PositionPlatformX;
            var PlatformY = deser.PositionPlatformY;
            var Score = deser.Score;
            world.LoadWorld(PlayerX, PlayerY, PlatformX,PlatformY,Score);
        }
        
    }  
}
