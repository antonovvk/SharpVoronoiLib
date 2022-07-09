using System.Collections.Generic;
using BenchmarkDotNet.Attributes;

namespace SharpVoronoiLib.Benchmarks
{
    public class RandomPointGenerationBenchmark
    {
        [Benchmark]
        public List<VoronoiSite> Uniform()
        {
            VoronoiPlane plane = new VoronoiPlane(0, 0, 1000, 1000);
            return plane.GenerateRandomSites(10000, PointGenerationMethod.Uniform);
        }

        [Benchmark]
        public List<VoronoiSite> Gaussian()
        {
            VoronoiPlane plane = new VoronoiPlane(0, 0, 1000, 1000);
            return plane.GenerateRandomSites(10000, PointGenerationMethod.Gaussian);
        }
    }
}