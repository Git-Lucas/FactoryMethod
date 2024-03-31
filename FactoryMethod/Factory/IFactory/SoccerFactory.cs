using FactoryMethod.Enums;
using FactoryMethod.Stadium;

namespace FactoryMethod.Factory.IFactory;
public class SoccerFactory : IStadiumFactory
{
    public IStadium? Create(SportName sportName)
    {
        if (sportName == SportName.Soccer)
        {
            return new StadiumSoccer();
        }

        return null;
    }
}
