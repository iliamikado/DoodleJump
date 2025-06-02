using Model.Core;

namespace Model.Data;

public interface ISerializer
{
    bool SetFilePath(string filePath);
    void Save(World world);
    void Load(World world);
}
