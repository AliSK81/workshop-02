using FoodManagement.Core.Abstraction;
using FoodManagement.Core.Exceptions;
using FoodManagement.Core.Models;
using FoodManagement.Resources;
using Newtonsoft.Json;

namespace FoodManagement.CardManagement.Repositories;

public class FileFoodRepository : IFoodRepository
{
    private readonly IFileReader<Food> _fileReader;

    public FileFoodRepository(IFileReader<Food> fileReader)
    {
        _fileReader = fileReader ?? throw new ArgumentNullException(nameof(fileReader));
    }
    

    public Food AddFood(Food food)
    {
        throw new NotImplementedException();
    }

    public void DeleteFood(FoodId foodId)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Food> GetFoods()
    {
        throw new NotImplementedException();
    }

    public Food GetFoodById(FoodId id)
    {
        var foods = _fileReader.Read(DataPaths.FoodsPath);

        var food = foods.SingleOrDefault(f => f.Id == id);

        if (food == null)
        {
            throw new FoodNotFoundException();
        }
        
        return food;
    }

}