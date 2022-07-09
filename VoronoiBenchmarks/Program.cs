using BenchmarkDotNet.Running;

namespace SharpVoronoiLib.Benchmarks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BenchmarkRunner.Run<RandomPointGenerationBenchmark>();
            
            // |   Method |     Mean |     Error |    StdDev |
            // |--------- |---------:|----------:|----------:|
            // |  Uniform | 1.504 ms | 0.0291 ms | 0.0272 ms |
            // | Gaussian | 2.159 ms | 0.0181 ms | 0.0160 ms |
        }
    }
}