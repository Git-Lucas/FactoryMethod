using FactoryMethod.Enums;
using FactoryMethod.Stadium;

namespace FactoryMethod.Factory.IFactory;
public class TennisFactory : IStadiumFactory
{
    public IStadium? Create(SportName sportName)
    {
        if (sportName == SportName.Tennis)
        {
            return new StadiumTennis();
        }

        return null;
    }
}
