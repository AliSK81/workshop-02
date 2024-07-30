using FoodManagement.Core.Abstraction;
using FoodManagement.Core.Models;

namespace FoodManagement.FileManagement.Business;

public class FoodJsonReader: IFileReader<Food>
{
    public List<Food> Read(string filePath)
    {
        throw new NotImplementedException();
    }
}