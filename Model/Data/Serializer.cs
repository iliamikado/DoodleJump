using Model.Core;

namespace Model.Data;

public abstract class Serializer : ISerializer
{
    protected string FilePath;
    public void SetFilePath(string filePath)
    {
        if (filePath == null) filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        FilePath = filePath;
    }
    public virtual void Save(World world){}
    public virtual void Load(World world){}
}
