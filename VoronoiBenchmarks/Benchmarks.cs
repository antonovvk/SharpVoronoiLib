using BenchmarkDotNet.Running;

namespace SharpVoronoiLib.Benchmarks
{
    public class Benchmarks
    {
        public static void Main(string[] args)
        {
            // Uncomment whichever benchmark is needed.
            
            
            //BenchmarkRunner.Run<TesselationBenchmark>();
            
            // |        Method | NumberOfSites |      Mean |    Error |   StdDev |
            // |-------------- |-------------- |----------:|---------:|---------:|
            // | WithoutBorder |           100 |  73.77 ns | 0.934 ns | 0.874 ns |
            // |    WithBorder |           100 | 803.58 ns | 8.783 ns | 7.786 ns |
            // | WithoutBorder |          1000 |  70.14 ns | 0.885 ns | 0.785 ns |
            // |    WithBorder |          1000 | 819.79 ns | 6.213 ns | 5.508 ns |
            
            
            //BenchmarkRunner.Run<RandomPointGenerationBenchmark>();
            
            // |   Method |     Mean |     Error |    StdDev |
            // |--------- |---------:|----------:|----------:|
            // |  Uniform | 1.504 ms | 0.0291 ms | 0.0272 ms |
            // | Gaussian | 2.159 ms | 0.0181 ms | 0.0160 ms |
        }
    }
}