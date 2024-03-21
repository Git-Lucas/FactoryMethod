using FactoryMethod;
using FactoryMethod.Entities;
using FactoryMethod.Enums;
using FactoryMethod.Stadium;

Sport sport = new(SportName.Soccer);

IStadium stadium = StadiumFactory.Create(sport.SportName);

Console.WriteLine(stadium.Name);