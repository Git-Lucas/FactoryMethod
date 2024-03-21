using FactoryMethod.Enums;
using FactoryMethod.Stadium;

namespace FactoryMethod;
public static class StadiumFactory
{
    public static IStadium Create(SportName sportName)
    {
        if (sportName == SportName.Soccer)
        {
            return new StadiumSoccer();
        }
        else if (sportName == SportName.Basketball)
        {
            return new StadiumBasketball();
        }

        throw new Exception($"{nameof(SportName)} not found.");
    }
}
