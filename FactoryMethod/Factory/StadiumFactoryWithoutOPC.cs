using FactoryMethod.Enums;
using FactoryMethod.Stadium;

namespace FactoryMethod.Factory;
public static class StadiumFactoryWithoutOPC
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
        else if (sportName == SportName.Tennis)
        {
            return new StadiumTennis();
        }

        throw new Exception($"{nameof(SportName)} not found.");
    }

}
