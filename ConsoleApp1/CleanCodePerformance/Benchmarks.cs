using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Toolchains.CsProj;
using BenchmarkDotNet.Toolchains.DotNetCli;

namespace ConsoleApp1;

[Config(typeof(BenchmarkConfig))]
public class Benchmarks
{
    public class BenchmarkConfig : ManualConfig
    {
        public BenchmarkConfig() 
        {
            var dotnetCli64bit = NetCoreAppSettings
                .NetCoreApp70
                .WithCustomDotNetCliPath("/Users/johnhershberg/.dotnet/dotnet", "64 bit cli");

            Add(Job.Default.With(CsProjCoreToolchain.From(dotnetCli64bit)).WithId("64 bit cli"));
        }
    }

    [Benchmark]
    public float TotalArea()
    {
        float result = 0;
        foreach (var shape in CleanCodePerformance.Shapes)
        {
            result += shape.Area();
        }

        return result;
    }
    
    [Benchmark]
    public float TotalAreaNoPoly()
    {
        float result = 0;
        foreach (var shape in NoPolymorphism.ShapesStruct)
        {
            result += NoPolymorphism.TotalAreaSwitch(shape);
        }

        return result;
    }
    
    [Benchmark]
    public float TotalAreaNoInternals()
    {
        float result = 0;
        foreach (var shape in NoInternals.ShapesStruct)
        {
            result += NoInternals.TotalAreaSwitchNoInternals(shape);
        }

        return result;
    }
}