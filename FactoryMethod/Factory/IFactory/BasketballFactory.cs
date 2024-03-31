using FactoryMethod.Enums;
using FactoryMethod.Stadium;

namespace FactoryMethod.Factory.IFactory;
public class BasketballFactory : IStadiumFactory
{
    public IStadium? Create(SportName sportName)
    {
        if (sportName == SportName.Basketball)
        {
            return new StadiumBasketball();
        }

        return null;
    }
}
