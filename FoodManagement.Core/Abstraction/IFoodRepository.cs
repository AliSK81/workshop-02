using FoodManagement.Core.Models;

namespace FoodManagement.Core.Abstraction;

public interface IFoodRepository
{
    Food AddFood(Food food);
    void DeleteFood(FoodId foodId);
    IEnumerable<Food> GetFoods();
    Food GetFoodById(FoodId id);
}