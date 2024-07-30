namespace FoodManagement.Core.Abstraction;

public interface IFileReader<TOut>
{
    List<TOut> Read(string filePath);
}