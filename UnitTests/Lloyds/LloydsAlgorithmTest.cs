using System.Collections.Generic;
using NUnit.Framework;

namespace SharpVoronoiLib.UnitTests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class LloydsAlgorithmTest
    {
        [Test]
        public void TestRelax()
        {
            // Arrange
            
            List<VoronoiSite> points = new List<VoronoiSite>
            {
                new VoronoiSite(-100, 300),
                new VoronoiSite(300, -100),
                new VoronoiSite(800, 300),
                new VoronoiSite(300, 800)
            };

            // Act

            VoronoiPlane plane = new VoronoiPlane(0, 0, 600, 600);

            plane.SetSites(points);

            plane.Tessellate();

            List<VoronoiEdge> edges = plane.Relax();

            // Assert
            
            // TODO: actual tests
            
            Assert.Pass();
        }
    }
}