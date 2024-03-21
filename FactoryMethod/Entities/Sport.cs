using FactoryMethod.Enums;

namespace FactoryMethod.Entities;
public class Sport(SportName sportName)
{
    public SportName SportName { get; private set; } = sportName;
}
