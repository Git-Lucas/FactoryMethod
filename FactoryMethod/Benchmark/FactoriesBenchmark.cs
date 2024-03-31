using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using FactoryMethod.Entities;
using FactoryMethod.Enums;
using FactoryMethod.Factory;
using FactoryMethod.Stadium;

namespace FactoryMethod.Benchmark;

[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
public class FactoriesBenchmark
{
    private StadiumFactoryWithOPC _stadiumFactoryWithOPC;
    private Sport[] _sports;

    [Params(10, 100, 1000)]
    public int NumberOfElements { get; set; }

    [GlobalSetup]
    public void Setup()
    {
        _sports = GenerateSports();
        _stadiumFactoryWithOPC = new StadiumFactoryWithOPC();
    }

    [Benchmark]
    public IStadium[] FactoryWithoutOCP()
    {
        return _sports
            .Select(x => StadiumFactoryWithoutOPC.Create(x.Name))
            .ToArray();
    }

    [Benchmark]
    public IStadium[] FactoryWithOCP()
    {
        return _sports
            .Select(x => _stadiumFactoryWithOPC.Create(x.Name))
            .ToArray();
    }

    private Sport[] GenerateSports()
    {
        SportName[] sportNames = Enum.GetValues<SportName>();

        return Enumerable
            .Range(1, NumberOfElements)
            .Select(x => new Sport(sportNames[new Random().Next(sportNames.Length)]))
            .ToArray();
    }
}
