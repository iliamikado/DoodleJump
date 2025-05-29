using Model.Core;

namespace Model.Data;

public interface ISerializer
{
    void SetFilePath(string filePath);
    void Save(World world);
}
