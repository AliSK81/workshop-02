using FoodManagement.Core.Abstraction;
using Newtonsoft.Json;

namespace FoodManagement.FileManagement.Business;

public class JsonReader<TOut> : IFileReader<TOut>
{
    public List<TOut> Read(string filePath)
    {
        using var r = new StreamReader(filePath);
        var json = r.ReadToEnd();
        return JsonConvert.DeserializeObject<List<TOut>>(json);
    }
}