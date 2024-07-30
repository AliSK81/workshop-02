namespace FoodManagement.Core.Exceptions;

public class AddFoodToCardFailedException : Exception
{
    public AddFoodToCardFailedException(string? message) : base(message)
    {
    }

    public AddFoodToCardFailedException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
    
    
}