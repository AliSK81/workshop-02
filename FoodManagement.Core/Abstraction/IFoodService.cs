using FoodManagement.Core.Models;

namespace FoodManagement.Core.Abstraction;

public interface IFoodService
{
    void AddFoodToCard(FoodId foodId, UserId userId);
}