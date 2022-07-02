using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using VoronoiLib;
using VoronoiLib.Structures;

namespace UnitTests
{
    [TestFixture]
    [Parallelizable(ParallelScope.Self)]
    public class FortuneSitePointsTest
    {
        [Test]
        public void ThreeFortuneSites()
        {
            List<FortuneSite> points = new List<FortuneSite> {new FortuneSite(100, 100), new FortuneSite(200, 200), new FortuneSite(200, 150)};
            FortunesAlgorithm.RunOnce(points, 0, 0, 600, 600);

            // Site 1
            FortuneSite site = points[0];
            List<VPoint> corners = site.Points.ToList();
            Assert.NotNull(corners);
            Assert.AreEqual(3, corners.Count);
            Assert.AreEqual(212.5, corners[0].X);
            Assert.AreEqual(0, corners[0].Y);
            Assert.AreEqual(125, corners[1].X);
            Assert.AreEqual(175, corners[1].Y);
            Assert.AreEqual(0, corners[2].X);
            Assert.AreEqual(300, corners[2].Y);

            // Site 2
            site = points[1];
            corners = site.Points.ToList();
            Assert.NotNull(corners);
            Assert.AreEqual(3, corners.Count);
            Assert.AreEqual(125, corners[0].X);
            Assert.AreEqual(175, corners[0].Y);
            Assert.AreEqual(600, corners[1].X);
            Assert.AreEqual(175, corners[1].Y);
            Assert.AreEqual(0, corners[2].X);
            Assert.AreEqual(300, corners[2].Y);

            // Site 3
            site = points[2];
            corners = site.Points.ToList();
            Assert.NotNull(corners);
            Assert.AreEqual(3, corners.Count);
            Assert.AreEqual(212.5, corners[0].X);
            Assert.AreEqual(0, corners[0].Y);
            Assert.AreEqual(600, corners[1].X);
            Assert.AreEqual(175, corners[1].Y);
            Assert.AreEqual(125, corners[2].X);
            Assert.AreEqual(175, corners[2].Y);
        }
    }
}