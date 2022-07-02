using NUnit.Framework;
using System.Collections.Generic;
using VoronoiLib;
using VoronoiLib.Structures;
using System;
using System.Linq;

namespace UnitTests
{
    [TestFixture]
    [Parallelizable(ParallelScope.Self)]
    public class EdgeNeighboursTest
    {
        [Test]
        public void OneSite()
        {
            List<FortuneSite> points = new List<FortuneSite>
            {
                new FortuneSite(100, 100)
            };
            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(points, 0, 0, 600, 600).ToList();

            Assume.That(edges.Count == 0);

            Assert.Pass(); // no edges, no neighbours; just a degenerate case to check our assumption
        }
        
        [Test]
        public void TwoSites()
        {
            List<FortuneSite> points = new List<FortuneSite>
            {
                new FortuneSite(100, 100), 
                new FortuneSite(200, 200)
            };
            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(points, 0, 0, 600, 600).ToList();

            Assume.That(edges.Count == 1);
            
            // Edge
            VoronoiEdge edge = edges[0];
            List<VoronoiEdge> neighbours = edge.Neighbours.ToList();
            Assert.NotNull(neighbours);
            Assert.AreEqual(0, neighbours.Count);
        }
        
        [Test]
        public void ThreeSites()
        {
            List<FortuneSite> points = new List<FortuneSite>
            {
                new FortuneSite(100, 100), 
                new FortuneSite(200, 200), 
                new FortuneSite(200, 150)
            };
            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(points, 0, 0, 600, 600).ToList();

            Assume.That(edges.Count == 3);
            
            // Edge 1
            VoronoiEdge edge = edges[0];
            List<VoronoiEdge> neighbours = edge.Neighbours.ToList();
            Assert.NotNull(neighbours);
            Assert.AreEqual(2, neighbours.Count);
            CollectionAssert.Contains(edges, neighbours[0]);
            CollectionAssert.Contains(edges, neighbours[1]);

            // Edge 2
            edge = edges[1];
            neighbours = edge.Neighbours.ToList();
            Assert.NotNull(neighbours);
            Assert.AreEqual(2, neighbours.Count);
            CollectionAssert.Contains(edges, neighbours[0]);
            CollectionAssert.Contains(edges, neighbours[1]);

            // Edge 3
            edge = edges[2];
            neighbours = edge.Neighbours.ToList();
            Assert.NotNull(neighbours);
            Assert.AreEqual(2, neighbours.Count);
            CollectionAssert.Contains(edges, neighbours[0]);
            CollectionAssert.Contains(edges, neighbours[1]);
        }        
        
        [Test]
        public void ThreeColinearSites()
        {
            List<FortuneSite> points = new List<FortuneSite>
            {
                new FortuneSite(300, 100),
                new FortuneSite(300, 300),
                new FortuneSite(300, 500)
            };
            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(points, 0, 0, 600, 600).ToList();

            Assume.That(edges.Count == 2);
            
            // Edge 1
            VoronoiEdge edge = edges[0];
            List<VoronoiEdge> neighbours = edge.Neighbours.ToList();
            Assert.NotNull(neighbours);
            Assert.AreEqual(0, neighbours.Count);

            // Edge 2
            edge = edges[1];
            neighbours = edge.Neighbours.ToList();
            Assert.NotNull(neighbours);
            Assert.AreEqual(0, neighbours.Count);
        } 
    }
}