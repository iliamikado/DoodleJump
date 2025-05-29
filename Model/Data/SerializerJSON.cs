
using System.Runtime.CompilerServices;
using System.Text.Json.Nodes;
using Model.Core;

namespace Model.Data;

public class SerializerJSON : Serializer
{
    public override void Save(World world)
    {
        var json = JObject.FromObject(new WorldDTO(world));
        File.WriteAllText(FilePath,json.ToString());
    }
    public override void Load(World world)
    {
        var content = File.ReadAllText(FilePath);
        var deser = JObject.Parse(content);
    }
}
