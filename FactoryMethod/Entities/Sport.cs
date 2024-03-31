using FactoryMethod.Enums;

namespace FactoryMethod.Entities;
public class Sport(SportName sportName)
{
    public SportName Name { get; private set; } = sportName;
}
