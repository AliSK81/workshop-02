using FoodManagement.Core.Abstraction;
using FoodManagement.Core.Models;

namespace FoodManagement.CardManagement.Repositories;

public class InMemoryCardRepository : ICardRepository
{
    private readonly Dictionary<UserId, List<Food>> _foodsByUserId = new();

    public void AddFoodToCard(UserId userId, Food food)
    {
        _foodsByUserId[userId].Add(food);
    }
}