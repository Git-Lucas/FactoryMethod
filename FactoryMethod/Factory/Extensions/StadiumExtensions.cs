using System.Reflection;
using FactoryMethod.Factory.IFactory;

namespace FactoryMethod.Factory.Extensions;
public static class StadiumExtensions
{
    public static IEnumerable<IStadiumFactory> GetStadiumFactories(this Assembly assembly)
    {
        return assembly
            .GetTypes()
            .Where(x => !x.IsInterface && x.IsAssignableTo(typeof(IStadiumFactory)))
            .Select(x => Activator.CreateInstance(x) as IStadiumFactory)!;
    }
}
