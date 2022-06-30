using NUnit.Framework;
using System.Collections.Generic;
using VoronoiLib;
using VoronoiLib.Structures;

namespace UnitTests
{
    [TestFixture]
    [Parallelizable(ParallelScope.Self)]
    public class FortuneSiteCellTest
    {
        [Test]
        public void ThreeFortuneSites()
        {
            List<FortuneSite> points = new List<FortuneSite> {new FortuneSite(100, 100), new FortuneSite(200, 200), new FortuneSite(200, 150)};
            FortunesAlgorithm.Run(points, 0, 0, 600, 600);

            // Site 1
            FortuneSite site = points[0];
            List<VEdge> edges = site.ClockwiseCell;
            Assert.NotNull(edges);
            Assert.AreEqual(2, edges.Count);
            Assert.AreEqual(212.5, edges[0].Start.X);
            Assert.AreEqual(0, edges[0].Start.Y);
            Assert.AreEqual(125, edges[0].End.X);
            Assert.AreEqual(175, edges[0].End.Y);
            Assert.AreEqual(125, edges[1].Start.X);
            Assert.AreEqual(175, edges[1].Start.Y);
            Assert.AreEqual(0, edges[1].End.X);
            Assert.AreEqual(300, edges[1].End.Y);

            // Site 2
            site = points[1];
            edges = site.ClockwiseCell;
            Assert.NotNull(edges);
            Assert.AreEqual(2, edges.Count);
            Assert.AreEqual(600, edges[0].Start.X);
            Assert.AreEqual(175, edges[0].Start.Y);
            Assert.AreEqual(125, edges[0].End.X);
            Assert.AreEqual(175, edges[0].End.Y);
            Assert.AreEqual(125, edges[1].Start.X);
            Assert.AreEqual(175, edges[1].Start.Y);
            Assert.AreEqual(0, edges[1].End.X);
            Assert.AreEqual(300, edges[1].End.Y);

            // Site 3
            site = points[2];
            edges = site.ClockwiseCell;
            Assert.NotNull(edges);
            Assert.AreEqual(2, edges.Count);
            Assert.AreEqual(212.5, edges[0].Start.X);
            Assert.AreEqual(0, edges[0].Start.Y);
            Assert.AreEqual(125, edges[0].End.X);
            Assert.AreEqual(175, edges[0].End.Y);
            Assert.AreEqual(600, edges[1].Start.X);
            Assert.AreEqual(175, edges[1].Start.Y);
            Assert.AreEqual(125, edges[1].End.X);
            Assert.AreEqual(175, edges[1].End.Y);
        }
    }
}