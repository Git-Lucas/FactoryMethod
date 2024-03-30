using FactoryMethod.Enums;
using FactoryMethod.Factory.Extensions;
using FactoryMethod.Factory.IFactory;
using FactoryMethod.Stadium;
using System.Reflection;

namespace FactoryMethod.Factory;
public static class StadiumFactory
{
    public static IStadium Create(SportName sportName)
    {
        IEnumerable<IStadiumFactory> stadiumFactories = Assembly.GetExecutingAssembly().GetStadiumFactories();

        IStadium? stadium = stadiumFactories
            .Select(factory => factory.Create(sportName))
            .FirstOrDefault(iStadium => iStadium is not null);

        return stadium ?? throw new Exception($"{nameof(SportName)} not found.");
    }
}
