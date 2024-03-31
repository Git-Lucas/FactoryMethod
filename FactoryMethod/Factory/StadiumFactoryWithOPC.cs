using FactoryMethod.Enums;
using FactoryMethod.Factory.Extensions;
using FactoryMethod.Factory.IFactory;
using FactoryMethod.Stadium;
using System.Reflection;

namespace FactoryMethod.Factory;
public class StadiumFactoryWithOPC
{
    private readonly IEnumerable<IStadiumFactory> _stadiumFactories = Assembly.GetExecutingAssembly().GetStadiumFactories();

    public IStadium Create(SportName sportName)
    {
        IStadium? stadium = _stadiumFactories
            .Select(factory => factory.Create(sportName))
            .FirstOrDefault(iStadium => iStadium is not null);

        return stadium ?? throw new Exception($"{nameof(SportName)} not found.");
    }
}
