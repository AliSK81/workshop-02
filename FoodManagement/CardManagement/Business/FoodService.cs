using FoodManagement.Core.Abstraction;
using FoodManagement.Core.Exceptions;
using FoodManagement.Core.Models;
using FoodManagement.Core.Resources;

namespace FoodManagement.CardManagement.Business;

public class FoodService : IFoodService
{
    private IFoodRepository _foodRepository;
    private ICardRepository _cardRepository;

    public FoodService(IFoodRepository foodRepository, ICardRepository cardRepository)
    {
        _foodRepository = foodRepository ?? throw new ArgumentNullException(nameof(foodRepository));
        _cardRepository = cardRepository ?? throw new ArgumentNullException(nameof(cardRepository));
    }

    public void AddFoodToCard(FoodId foodId, UserId userId)
    {
        try
        {
            var food = _foodRepository.GetFoodById(foodId);
            _cardRepository.AddFoodToCard(userId, food);
        }
        catch (FoodNotFoundException e)
        {
            throw new AddFoodToCardFailedException("ErrorMessages.AddFoodToCardFailedMessage", e);
        }
    }
}