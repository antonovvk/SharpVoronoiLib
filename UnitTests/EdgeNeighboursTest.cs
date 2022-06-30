using NUnit.Framework;
using System.Collections.Generic;
using VoronoiLib;
using VoronoiLib.Structures;

namespace UnitTests
{
    using System.Linq;

    [TestFixture]
    [Parallelizable(ParallelScope.Self)]
    public class EdgeNeighboursTest
    {
        [Test]
        public void ThreeFortuneSites()
        {
            List<FortuneSite> points = new List<FortuneSite> {new FortuneSite(100, 100), new FortuneSite(200, 200), new FortuneSite(200, 150)};
            List<VEdge> edges = FortunesAlgorithm.Run(points, 0, 0, 600, 600).ToList();

            Assume.That(edges.Count == 3);
            
            // Site 1
            VEdge edge = edges[0];
            List<VEdge> neighbours = edge.Neighbours;
            Assert.NotNull(neighbours);
            Assert.AreEqual(2, neighbours.Count);
            CollectionAssert.Contains(edges, neighbours[0]);
            CollectionAssert.Contains(edges, neighbours[1]);

            // Site 2
            edge = edges[1];
            neighbours = edge.Neighbours;
            Assert.NotNull(neighbours);
            Assert.AreEqual(2, neighbours.Count);
            CollectionAssert.Contains(edges, neighbours[0]);
            CollectionAssert.Contains(edges, neighbours[1]);

            // Site 3
            edge = edges[2];
            neighbours = edge.Neighbours;
            Assert.NotNull(neighbours);
            Assert.AreEqual(2, neighbours.Count);
            CollectionAssert.Contains(edges, neighbours[0]);
            CollectionAssert.Contains(edges, neighbours[1]);
        }
    }
}