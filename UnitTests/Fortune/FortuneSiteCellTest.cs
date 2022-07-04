using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using VoronoiLib;
using VoronoiLib.Structures;

namespace UnitTests
{
    [TestFixture]
    [Parallelizable(ParallelScope.Self)]
    public class FortuneSiteCellTest
    {
        [Test]
        public void FourPointsInASquare()
        {
            List<VoronoiSite> points = new List<VoronoiSite>
            {
                new VoronoiSite(200, 300), // 1
                new VoronoiSite(300, 400), // 2
                new VoronoiSite(300, 200), // 3
                new VoronoiSite(400, 300) // 4
            };

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(points, 0, 0, 600, 600, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // 600 B                                   E
            //     |\                                 /
            // 500 |    \                         /
            //     |        \                 /
            // 400 |            \    2    /
            //     |               \   /
            // 300 |           1     A     4
            //     |               /   \
            // 200 |            /    3    \
            //     |        /                 \
            // 100 |    /                         \
            //     |/                                 \
            //   0 C-----------------------------------D
            //     0    100   200   300   400   500   600

            foreach (VoronoiEdge edge in edges)
                Console.WriteLine(edge.ToString("F0"));

            Assert.AreEqual(5, edges.Count);

            Assume.That(() => CommonTestUtilities.AnyEdgeBetween(edges, 300, 300, 000, 600)); // A-B
            Assume.That(() => CommonTestUtilities.AnyEdgeBetween(edges, 300, 300, 000, 000)); // A-C
            Assume.That(() => CommonTestUtilities.AnyEdgeBetween(edges, 300, 300, 600, 000)); // A-D
            Assume.That(() => CommonTestUtilities.AnyEdgeBetween(edges, 300, 300, 600, 600)); // A-E
            Assume.That(() => CommonTestUtilities.AnyEdgeBetween(edges, 300, 300, 300, 300)); // A-A - because that's how this algorithm works
            
            Assert.IsTrue(CommonTestUtilities.SiteHasEdge(points[0], 300, 300, 000, 600)); // 1 has A-B
            Assert.IsTrue(CommonTestUtilities.SiteHasEdge(points[0], 300, 300, 000, 000)); // 1 has A-C
            Assert.IsTrue(CommonTestUtilities.SiteHasEdge(points[1], 300, 300, 000, 600)); // 2 has A-B
            Assert.IsTrue(CommonTestUtilities.SiteHasEdge(points[1], 300, 300, 600, 600)); // 2 has A-E
            Assert.IsTrue(CommonTestUtilities.SiteHasEdge(points[2], 300, 300, 000, 000)); // 3 has A-C
            Assert.IsTrue(CommonTestUtilities.SiteHasEdge(points[2], 300, 300, 600, 000)); // 3 has A-D
            Assert.IsTrue(CommonTestUtilities.SiteHasEdge(points[3], 300, 300, 600, 000)); // 4 has A-D
            Assert.IsTrue(CommonTestUtilities.SiteHasEdge(points[3], 300, 300, 600, 600)); // 4 has A-E
        }
    }
}