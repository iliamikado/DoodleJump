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
            var deser = serializer.Deserialize(reader);
        }
    }  
}
