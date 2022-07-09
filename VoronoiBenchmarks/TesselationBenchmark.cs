using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using JetBrains.Annotations;

namespace SharpVoronoiLib.Benchmarks
{
    public class TesselationBenchmark
    {
        [Params(100, 1000)]
        [UsedImplicitly]
        public int NumberOfSites { get; set; }

        
        private readonly VoronoiPlane _plane;


        public TesselationBenchmark()
        {
            _plane = new VoronoiPlane(0, 0, 1000, 1000);
            _plane.GenerateRandomSites(NumberOfSites);
        }
        
        
        [Benchmark]
        public List<VoronoiEdge> WithoutBorder()
        {
            return _plane.Tessellate(BorderEdgeGeneration.DoNotMakeBorderEdges);
        }
        
        [Benchmark]
        public List<VoronoiEdge> WithBorder()
        {
            return _plane.Tessellate(BorderEdgeGeneration.MakeBorderEdges);
        }
    }
}