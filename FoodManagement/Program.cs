using FoodManagement.CardManagement.Business;
using FoodManagement.CardManagement.Repositories;
using FoodManagement.Core.Abstraction;
using Microsoft.Extensions.DependencyInjection;

var serviceProvider = new ServiceCollection()
    .AddSingleton<IFoodService, FoodService>()
    .AddSingleton<ICardRepository, InMemoryCardRepository>()
    .BuildServiceProvider();

var foodService = serviceProvider.GetRequiredService<IFoodService>();