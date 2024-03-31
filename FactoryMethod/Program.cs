using FactoryMethod.Entities;
using FactoryMethod.Enums;
using FactoryMethod.Factory;
using FactoryMethod.Stadium;

Sport sport = new(SportName.Soccer);
IStadium stadium = StadiumFactory.Create(sport.Name);
Console.WriteLine($"SPORT: {sport.Name} | " +
                  $"STADIUM: {stadium.Name}");

Sport sport1 = new(SportName.Tennis);
stadium = StadiumFactory.Create(sport1.Name);
Console.WriteLine($"SPORT: {sport1.Name} | " +
                  $"STADIUM: {stadium.Name}");
