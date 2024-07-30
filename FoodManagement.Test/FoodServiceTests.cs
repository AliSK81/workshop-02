using FoodManagement.CardManagement.Business;
using FoodManagement.Core.Abstraction;
using FoodManagement.Core.Exceptions;
using FoodManagement.Core.Models;
using NSubstitute;
using NSubstitute.ExceptionExtensions;

namespace FoodManagement.Test;

public class FoodServiceTests
{
    private readonly FoodService _sut;
    private readonly IFoodRepository _foodRepository;
    private readonly ICardRepository _cardRepository;

    public FoodServiceTests()
    {
        _foodRepository = Substitute.For<IFoodRepository>();
        _cardRepository = Substitute.For<ICardRepository>();
        _sut = new FoodService(_foodRepository, _cardRepository);
    }

    [Fact]
    public void AddFoodToCard_ShouldThrowAddFoodToCardFailedException_WhenFoodNotFound()
    {
        // Arrange
        var foodId = new FoodId(2);
        var userId = new UserId(1);
        _foodRepository.GetFoodById(foodId).Throws(new FoodNotFoundException());

        // Act
        var action = () => _sut.AddFoodToCard(foodId, userId);

        // Assert
        Assert.Throws<AddFoodToCardFailedException>(action);
    }
}