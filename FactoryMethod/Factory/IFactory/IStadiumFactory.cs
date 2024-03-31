using FactoryMethod.Enums;
using FactoryMethod.Stadium;

namespace FactoryMethod.Factory.IFactory;
public interface IStadiumFactory
{
    IStadium? Create(SportName sportName);
}
