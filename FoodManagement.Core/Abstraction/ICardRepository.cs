using FoodManagement.Core.Models;

namespace FoodManagement.Core.Abstraction;

public interface ICardRepository
{
    void AddFoodToCard(UserId userId, Food food);
}