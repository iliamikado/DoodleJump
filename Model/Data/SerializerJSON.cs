
using System.Runtime.CompilerServices;
using System.Text.Json.Nodes;
using Model.Core;

namespace Model.Data;

public class SerializerJSON : Serializer
{
    public void Save(World world)
    {
        var json = JObject.FromObject(world);
        File.WriteAllText(FilePath,json.ToString());
    }
    public void Load(World world)
    {
        var content = File.ReadAllText(FilePath);
        var deser = JObject.Parse(content);
    }
}
