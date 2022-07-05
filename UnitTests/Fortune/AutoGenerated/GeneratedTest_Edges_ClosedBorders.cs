using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using static SharpVoronoiLib.UnitTests.CommonTestUtilities;

namespace SharpVoronoiLib.UnitTests
{
    /// <summary>
    /// These tests assert that <see cref="VoronoiEdge"/>`s are returned as expected
    /// Specifically, that the result of <see cref="VoronoiPlane.Tessellate"/>() contains the expected edges.
    /// These tests are run with generating the border edges, i.e. <see cref="BorderEdgeGeneration.MakeBorderEdges"/>.
    /// </summary>
    /// <remarks>
    /// This is an AUTO-GENERATED test fixture class from UnitTestGenerator.
    /// This is one of the several auto-generated fixture classes each checking a different part of the algorithm's result.
    /// It contains a bunch of known Voronoi site layouts, including many edge cases.
    /// </remarks>
    [Parallelizable(ParallelScope.All)]
    [TestFixture]
    public class GeneratedTest_Edges_ClosedBorders
    {
        [Test]
        public void NoPoints()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
            };

            // 1000 X-------------------------------------------------Z
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                                                 |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 Y-------------------------------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(4, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 0)); // X-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 1000, 0)); // Y-W
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 1000)); // W-Z
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 0, 1000)); // Z-X
        }

        [Test]
        public void OnePointInMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 500), // #1
            };

            // 1000 X-------------------------------------------------Z
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                        1                        |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 Y-------------------------------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(4, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 0)); // X-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 1000, 0)); // Y-W
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 1000)); // W-Z
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 0, 1000)); // Z-X
        }

        [Test]
        public void OnePointOffsetFromMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(200, 500), // #1
            };

            // 1000 X-------------------------------------------------Z
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |         1                                       |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 Y-------------------------------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(4, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 0)); // X-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 1000, 0)); // Y-W
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 1000)); // W-Z
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 0, 1000)); // Z-X
        }

        /// <summary>
        /// This test basically repeats <see cref="OnePointOffsetFromMiddle"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void OnePointOffsetFromMiddle_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 800), // #1
            };

            // 1000 Y-------------------------------------------------X
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                        1                        |
            //      |                                                 |
            //  700 |                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                                                 |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 W-------------------------------------------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(4, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 0, 1000)); // X-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 0)); // Y-W
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 1000, 0)); // W-Z
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 1000)); // Z-X
        }

        /// <summary>
        /// This test basically repeats <see cref="OnePointOffsetFromMiddle"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void OnePointOffsetFromMiddle_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(800, 500), // #1
            };

            // 1000 W-------------------------------------------------Y
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                                       1         |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 Z-------------------------------------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(4, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 1000)); // X-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 0, 1000)); // Y-W
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 0)); // W-Z
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 1000, 0)); // Z-X
        }

        /// <summary>
        /// This test basically repeats <see cref="OnePointOffsetFromMiddle"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void OnePointOffsetFromMiddle_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 200), // #1
            };

            // 1000 Z-------------------------------------------------W
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                                                 |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |                        1                        |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 X-------------------------------------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(4, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 1000, 0)); // X-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 1000)); // Y-W
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 0, 1000)); // W-Z
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 0)); // Z-X
        }

        [Test]
        public void OnePointArbitrary()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(200, 700), // #1
            };

            // 1000 X-------------------------------------------------Z
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |         1                                       |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                                                 |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 Y-------------------------------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(4, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 0)); // X-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 1000, 0)); // Y-W
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 1000)); // W-Z
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 0, 1000)); // Z-X
        }

        /// <summary>
        /// This test basically repeats <see cref="OnePointArbitrary"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void OnePointArbitrary_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(700, 800), // #1
            };

            // 1000 Y-------------------------------------------------X
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                  1              |
            //      |                                                 |
            //  700 |                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                                                 |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 W-------------------------------------------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(4, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 0, 1000)); // X-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 0)); // Y-W
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 1000, 0)); // W-Z
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 1000)); // Z-X
        }

        /// <summary>
        /// This test basically repeats <see cref="OnePointArbitrary"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void OnePointArbitrary_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(800, 300), // #1
            };

            // 1000 W-------------------------------------------------Y
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                                                 |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                       1         |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 Z-------------------------------------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(4, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 1000)); // X-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 0, 1000)); // Y-W
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 0)); // W-Z
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 1000, 0)); // Z-X
        }

        /// <summary>
        /// This test basically repeats <see cref="OnePointArbitrary"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void OnePointArbitrary_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(300, 200), // #1
            };

            // 1000 Z-------------------------------------------------W
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                                                 |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |              1                                  |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 X-------------------------------------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(4, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 1000, 0)); // X-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 1000)); // Y-W
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 0, 1000)); // W-Z
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 0)); // Z-X
        }

        [Test]
        public void OnePointOnBorderCentered()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(0, 500), // #1
            };

            // 1000 X-------------------------------------------------Z
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 1                                                 |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 Y-------------------------------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(4, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 0)); // X-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 1000, 0)); // Y-W
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 1000)); // W-Z
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 0, 1000)); // Z-X
        }

        /// <summary>
        /// This test basically repeats <see cref="OnePointOnBorderCentered"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void OnePointOnBorderCentered_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 1000), // #1
            };

            // 1000 Y------------------------1------------------------X
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                                                 |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 W-------------------------------------------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(4, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 0, 1000)); // X-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 0)); // Y-W
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 1000, 0)); // W-Z
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 1000)); // Z-X
        }

        /// <summary>
        /// This test basically repeats <see cref="OnePointOnBorderCentered"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void OnePointOnBorderCentered_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(1000, 500), // #1
            };

            // 1000 W-------------------------------------------------Y
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                                                 1
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 Z-------------------------------------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(4, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 1000)); // X-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 0, 1000)); // Y-W
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 0)); // W-Z
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 1000, 0)); // Z-X
        }

        /// <summary>
        /// This test basically repeats <see cref="OnePointOnBorderCentered"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void OnePointOnBorderCentered_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 0), // #1
            };

            // 1000 Z-------------------------------------------------W
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                                                 |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 X------------------------1------------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(4, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 1000, 0)); // X-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 1000)); // Y-W
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 0, 1000)); // W-Z
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 0)); // Z-X
        }

        [Test]
        public void OnePointOnBorderOffset()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(0, 700), // #1
            };

            // 1000 X-------------------------------------------------Z
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 1                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                                                 |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 Y-------------------------------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(4, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 0)); // X-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 1000, 0)); // Y-W
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 1000)); // W-Z
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 0, 1000)); // Z-X
        }

        /// <summary>
        /// This test basically repeats <see cref="OnePointOnBorderOffset"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void OnePointOnBorderOffset_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(700, 1000), // #1
            };

            // 1000 Y----------------------------------1--------------X
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                                                 |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 W-------------------------------------------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(4, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 0, 1000)); // X-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 0)); // Y-W
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 1000, 0)); // W-Z
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 1000)); // Z-X
        }

        /// <summary>
        /// This test basically repeats <see cref="OnePointOnBorderOffset"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void OnePointOnBorderOffset_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(1000, 300), // #1
            };

            // 1000 W-------------------------------------------------Y
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                                                 |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 1
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 Z-------------------------------------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(4, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 1000)); // X-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 0, 1000)); // Y-W
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 0)); // W-Z
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 1000, 0)); // Z-X
        }

        /// <summary>
        /// This test basically repeats <see cref="OnePointOnBorderOffset"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void OnePointOnBorderOffset_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(300, 0), // #1
            };

            // 1000 Z-------------------------------------------------W
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                                                 |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 X--------------1----------------------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(4, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 1000, 0)); // X-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 1000)); // Y-W
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 0, 1000)); // W-Z
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 0)); // Z-X
        }

        [Test]
        public void OnePointInCorner()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(0, 0), // #1
            };

            // 1000 X-------------------------------------------------Z
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                                                 |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 1-------------------------------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(4, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 0)); // X-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 1000, 0)); // Y-W
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 1000)); // W-Z
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 0, 1000)); // Z-X
        }

        /// <summary>
        /// This test basically repeats <see cref="OnePointInCorner"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void OnePointInCorner_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(0, 1000), // #1
            };

            // 1000 1-------------------------------------------------X
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                                                 |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 W-------------------------------------------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(4, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 0, 1000)); // X-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 0)); // Y-W
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 1000, 0)); // W-Z
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 1000)); // Z-X
        }

        /// <summary>
        /// This test basically repeats <see cref="OnePointInCorner"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void OnePointInCorner_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(1000, 1000), // #1
            };

            // 1000 W-------------------------------------------------1
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                                                 |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 Z-------------------------------------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(4, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 1000)); // X-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 0, 1000)); // Y-W
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 0)); // W-Z
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 1000, 0)); // Z-X
        }

        /// <summary>
        /// This test basically repeats <see cref="OnePointInCorner"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void OnePointInCorner_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(1000, 0), // #1
            };

            // 1000 Z-------------------------------------------------W
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                                                 |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 X-------------------------------------------------1
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(4, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 1000, 0)); // X-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 1000)); // Y-W
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 0, 1000)); // W-Z
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 0)); // Z-X
        }

        [Test]
        public void TwoPointsVerticalAroundMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 700), // #1
                new VoronoiSite(500, 300), // #2
            };

            // 1000 X-------------------------------------------------Z
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                        1                        |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 A-------------------------------------------------B
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                        2                        |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 Y-------------------------------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(7, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 500, 1000, 500)); // A-B
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 500)); // X-A
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 500, 0, 0)); // A-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 1000, 0)); // Y-W
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 500)); // W-B
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 500, 1000, 1000)); // B-Z
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 0, 1000)); // Z-X
        }

        /// <summary>
        /// This test basically repeats <see cref="TwoPointsVerticalAroundMiddle"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void TwoPointsHorizontalAroundMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(700, 500), // #1
                new VoronoiSite(300, 500), // #2
            };

            // 1000 Y------------------------A------------------------X
            //      |                        |                        |
            //  900 |                        |                        |
            //      |                        |                        |
            //  800 |                        |                        |
            //      |                        |                        |
            //  700 |                        |                        |
            //      |                        |                        |
            //  600 |                        |                        |
            //      |                        |                        |
            //  500 |              2         |         1              |
            //      |                        |                        |
            //  400 |                        |                        |
            //      |                        |                        |
            //  300 |                        |                        |
            //      |                        |                        |
            //  200 |                        |                        |
            //      |                        |                        |
            //  100 |                        |                        |
            //      |                        |                        |
            //    0 W------------------------B------------------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(7, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 1000, 500, 0)); // A-B
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 500, 1000)); // X-A
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 1000, 0, 1000)); // A-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 0)); // Y-W
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 500, 0)); // W-B
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 0, 1000, 0)); // B-Z
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 1000)); // Z-X
        }

        [Test]
        public void TwoPointsVerticalOffsetFromMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 900), // #1
                new VoronoiSite(500, 500), // #2
            };

            // 1000 X-------------------------------------------------Z
            //      |                                                 |
            //  900 |                        1                        |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 A-------------------------------------------------B
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                        2                        |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 Y-------------------------------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(7, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 700, 1000, 700)); // A-B
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 700)); // X-A
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 700, 0, 0)); // A-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 1000, 0)); // Y-W
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 700)); // W-B
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 700, 1000, 1000)); // B-Z
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 0, 1000)); // Z-X
        }

        /// <summary>
        /// This test basically repeats <see cref="TwoPointsVerticalOffsetFromMiddle"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void TwoPointsHorizontalOffsetFromMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(900, 500), // #1
                new VoronoiSite(500, 500), // #2
            };

            // 1000 Y----------------------------------A--------------X
            //      |                                  |              |
            //  900 |                                  |              |
            //      |                                  |              |
            //  800 |                                  |              |
            //      |                                  |              |
            //  700 |                                  |              |
            //      |                                  |              |
            //  600 |                                  |              |
            //      |                                  |              |
            //  500 |                        2         |         1    |
            //      |                                  |              |
            //  400 |                                  |              |
            //      |                                  |              |
            //  300 |                                  |              |
            //      |                                  |              |
            //  200 |                                  |              |
            //      |                                  |              |
            //  100 |                                  |              |
            //      |                                  |              |
            //    0 W----------------------------------B--------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(7, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 700, 1000, 700, 0)); // A-B
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 700, 1000)); // X-A
            Assert.IsTrue(AnyEdgeBetween(edges, 700, 1000, 0, 1000)); // A-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 0)); // Y-W
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 700, 0)); // W-B
            Assert.IsTrue(AnyEdgeBetween(edges, 700, 0, 1000, 0)); // B-Z
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 1000)); // Z-X
        }

        [Test]
        public void ThreeConcentricPointsVerticalAroundMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 900), // #1
                new VoronoiSite(500, 500), // #2
                new VoronoiSite(500, 100), // #3
            };

            // 1000 X-------------------------------------------------Z
            //      |                                                 |
            //  900 |                        1                        |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 A-------------------------------------------------B
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                        2                        |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 C-------------------------------------------------D
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                        3                        |
            //      |                                                 |
            //    0 Y-------------------------------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(10, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 700, 1000, 700)); // A-B
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 300, 1000, 300)); // C-D
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 700)); // X-A
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 700, 0, 300)); // A-C
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 300, 0, 0)); // C-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 1000, 0)); // Y-W
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 300)); // W-D
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 300, 1000, 700)); // D-B
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 700, 1000, 1000)); // B-Z
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 0, 1000)); // Z-X
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreeConcentricPointsVerticalAroundMiddle"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreeConcentricPointsHorizontalAroundMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(900, 500), // #1
                new VoronoiSite(500, 500), // #2
                new VoronoiSite(100, 500), // #3
            };

            // 1000 Y--------------C-------------------A--------------X
            //      |              |                   |              |
            //  900 |              |                   |              |
            //      |              |                   |              |
            //  800 |              |                   |              |
            //      |              |                   |              |
            //  700 |              |                   |              |
            //      |              |                   |              |
            //  600 |              |                   |              |
            //      |              |                   |              |
            //  500 |    3         |         2         |         1    |
            //      |              |                   |              |
            //  400 |              |                   |              |
            //      |              |                   |              |
            //  300 |              |                   |              |
            //      |              |                   |              |
            //  200 |              |                   |              |
            //      |              |                   |              |
            //  100 |              |                   |              |
            //      |              |                   |              |
            //    0 W--------------D-------------------B--------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(10, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 700, 1000, 700, 0)); // A-B
            Assert.IsTrue(AnyEdgeBetween(edges, 300, 1000, 300, 0)); // C-D
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 700, 1000)); // X-A
            Assert.IsTrue(AnyEdgeBetween(edges, 700, 1000, 300, 1000)); // A-C
            Assert.IsTrue(AnyEdgeBetween(edges, 300, 1000, 0, 1000)); // C-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 0)); // Y-W
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 300, 0)); // W-D
            Assert.IsTrue(AnyEdgeBetween(edges, 300, 0, 700, 0)); // D-B
            Assert.IsTrue(AnyEdgeBetween(edges, 700, 0, 1000, 0)); // B-Z
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 1000)); // Z-X
        }

        [Test]
        public void FourConcentricPointsVerticalAroundMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 800), // #1
                new VoronoiSite(500, 600), // #2
                new VoronoiSite(500, 400), // #3
                new VoronoiSite(500, 200), // #4
            };

            // 1000 X-------------------------------------------------Z
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                        1                        |
            //      |                                                 |
            //  700 A-------------------------------------------------B
            //      |                                                 |
            //  600 |                        2                        |
            //      |                                                 |
            //  500 C-------------------------------------------------D
            //      |                                                 |
            //  400 |                        3                        |
            //      |                                                 |
            //  300 E-------------------------------------------------F
            //      |                                                 |
            //  200 |                        4                        |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 Y-------------------------------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(13, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 700, 1000, 700)); // A-B
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 500, 1000, 500)); // C-D
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 300, 1000, 300)); // E-F
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 700)); // X-A
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 700, 0, 500)); // A-C
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 500, 0, 300)); // C-E
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 300, 0, 0)); // E-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 1000, 0)); // Y-W
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 300)); // W-F
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 300, 1000, 500)); // F-D
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 500, 1000, 700)); // D-B
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 700, 1000, 1000)); // B-Z
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 0, 1000)); // Z-X
        }

        /// <summary>
        /// This test basically repeats <see cref="FourConcentricPointsVerticalAroundMiddle"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void FourConcentricPointsHorizontalAroundMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(800, 500), // #1
                new VoronoiSite(600, 500), // #2
                new VoronoiSite(400, 500), // #3
                new VoronoiSite(200, 500), // #4
            };

            // 1000 Y--------------E---------C---------A--------------X
            //      |              |         |         |              |
            //  900 |              |         |         |              |
            //      |              |         |         |              |
            //  800 |              |         |         |              |
            //      |              |         |         |              |
            //  700 |              |         |         |              |
            //      |              |         |         |              |
            //  600 |              |         |         |              |
            //      |              |         |         |              |
            //  500 |         4    |    3    |    2    |    1         |
            //      |              |         |         |              |
            //  400 |              |         |         |              |
            //      |              |         |         |              |
            //  300 |              |         |         |              |
            //      |              |         |         |              |
            //  200 |              |         |         |              |
            //      |              |         |         |              |
            //  100 |              |         |         |              |
            //      |              |         |         |              |
            //    0 W--------------F---------D---------B--------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(13, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 700, 1000, 700, 0)); // A-B
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 1000, 500, 0)); // C-D
            Assert.IsTrue(AnyEdgeBetween(edges, 300, 1000, 300, 0)); // E-F
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 700, 1000)); // X-A
            Assert.IsTrue(AnyEdgeBetween(edges, 700, 1000, 500, 1000)); // A-C
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 1000, 300, 1000)); // C-E
            Assert.IsTrue(AnyEdgeBetween(edges, 300, 1000, 0, 1000)); // E-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 0)); // Y-W
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 300, 0)); // W-F
            Assert.IsTrue(AnyEdgeBetween(edges, 300, 0, 500, 0)); // F-D
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 0, 700, 0)); // D-B
            Assert.IsTrue(AnyEdgeBetween(edges, 700, 0, 1000, 0)); // B-Z
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 1000)); // Z-X
        }

        [Test]
        public void TwoDiagonalPointsAroundMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(300, 700), // #1
                new VoronoiSite(700, 300), // #2
            };

            // 1000 X------------------------------------------------#B
            //      |                                              ,' |
            //  900 |                                           ,·'   |
            //      |                                         ,'      |
            //  800 |                                      ,·'        |
            //      |                                    ,'           |
            //  700 |              1                  ,·'             |
            //      |                               ,'                |
            //  600 |                            ,·'                  |
            //      |                          ,'                     |
            //  500 |                       ,·'                       |
            //      |                     ,'                          |
            //  400 |                  ,·'                            |
            //      |                ,'                               |
            //  300 |             ,·'                  2              |
            //      |           ,'                                    |
            //  200 |        ,·'                                      |
            //      |      ,'                                         |
            //  100 |   ,·'                                           |
            //      | ,'                                              |
            //    0 A#------------------------------------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(5, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 1000, 1000)); // A-B
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 0)); // X-A
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 1000, 0)); // A-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 1000)); // Y-B
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 0, 1000)); // B-X
        }

        /// <summary>
        /// This test basically repeats <see cref="TwoDiagonalPointsAroundMiddle"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void TwoDiagonalPointsAroundMiddle_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(700, 700), // #1
                new VoronoiSite(300, 300), // #2
            };

            // 1000 A#------------------------------------------------X
            //      | ',                                              |
            //  900 |   '·,                                           |
            //      |      ',                                         |
            //  800 |        '·,                                      |
            //      |           ',                                    |
            //  700 |             '·,                  1              |
            //      |                ',                               |
            //  600 |                  '·,                            |
            //      |                     ',                          |
            //  500 |                       '·,                       |
            //      |                          ',                     |
            //  400 |                            '·,                  |
            //      |                               ',                |
            //  300 |              2                  '·,             |
            //      |                                    ',           |
            //  200 |                                      '·,        |
            //      |                                         ',      |
            //  100 |                                           '·,   |
            //      |                                              ', |
            //    0 Y------------------------------------------------#B
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(5, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 1000, 0)); // A-B
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 0, 1000)); // X-A
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 0)); // A-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 1000, 0)); // Y-B
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 1000)); // B-X
        }

        [Test]
        public void TwoDiagonalPointsOffsetFromMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(200, 800), // #1
                new VoronoiSite(600, 400), // #2
            };

            // 1000 X--------------------------------------#B---------Z
            //      |                                    ,'           |
            //  900 |                                 ,·'             |
            //      |                               ,'                |
            //  800 |         1                  ,·'                  |
            //      |                          ,'                     |
            //  700 |                       ,·'                       |
            //      |                     ,'                          |
            //  600 |                  ,·'                            |
            //      |                ,'                               |
            //  500 |             ,·'                                 |
            //      |           ,'                                    |
            //  400 |        ,·'                  2                   |
            //      |      ,'                                         |
            //  300 |   ,·'                                           |
            //      | ,'                                              |
            //  200 A'                                                |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 Y-------------------------------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(7, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 200, 800, 1000)); // A-B
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 200)); // X-A
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 200, 0, 0)); // A-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 1000, 0)); // Y-W
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 1000)); // W-Z
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 800, 1000)); // Z-B
            Assert.IsTrue(AnyEdgeBetween(edges, 800, 1000, 0, 1000)); // B-X
        }

        /// <summary>
        /// This test basically repeats <see cref="TwoDiagonalPointsOffsetFromMiddle"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void TwoDiagonalPointsOffsetFromMiddle_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(800, 800), // #1
                new VoronoiSite(400, 400), // #2
            };

            // 1000 Y---------A#--------------------------------------X
            //      |           ',                                    |
            //  900 |             '·,                                 |
            //      |                ',                               |
            //  800 |                  '·,                  1         |
            //      |                     ',                          |
            //  700 |                       '·,                       |
            //      |                          ',                     |
            //  600 |                            '·,                  |
            //      |                               ',                |
            //  500 |                                 '·,             |
            //      |                                    ',           |
            //  400 |                   2                  '·,        |
            //      |                                         ',      |
            //  300 |                                           '·,   |
            //      |                                              ', |
            //  200 |                                                'B
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 W-------------------------------------------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(7, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 200, 1000, 1000, 200)); // A-B
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 200, 1000)); // X-A
            Assert.IsTrue(AnyEdgeBetween(edges, 200, 1000, 0, 1000)); // A-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 0)); // Y-W
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 1000, 0)); // W-Z
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 200)); // Z-B
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 200, 1000, 1000)); // B-X
        }

        /// <summary>
        /// This test basically repeats <see cref="TwoDiagonalPointsOffsetFromMiddle"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void TwoDiagonalPointsOffsetFromMiddle_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(800, 200), // #1
                new VoronoiSite(400, 600), // #2
            };

            // 1000 W-------------------------------------------------Y
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                ,A
            //      |                                              ,' |
            //  700 |                                           ,·'   |
            //      |                                         ,'      |
            //  600 |                   2                  ,·'        |
            //      |                                    ,'           |
            //  500 |                                 ,·'             |
            //      |                               ,'                |
            //  400 |                            ,·'                  |
            //      |                          ,'                     |
            //  300 |                       ,·'                       |
            //      |                     ,'                          |
            //  200 |                  ,·'                  1         |
            //      |                ,'                               |
            //  100 |             ,·'                                 |
            //      |           ,'                                    |
            //    0 Z---------B#--------------------------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(7, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 800, 200, 0)); // A-B
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 800)); // X-A
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 800, 1000, 1000)); // A-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 0, 1000)); // Y-W
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 0)); // W-Z
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 200, 0)); // Z-B
            Assert.IsTrue(AnyEdgeBetween(edges, 200, 0, 1000, 0)); // B-X
        }

        /// <summary>
        /// This test basically repeats <see cref="TwoDiagonalPointsOffsetFromMiddle"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void TwoDiagonalPointsOffsetFromMiddle_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(200, 200), // #1
                new VoronoiSite(600, 600), // #2
            };

            // 1000 Z-------------------------------------------------W
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 B,                                                |
            //      | ',                                              |
            //  700 |   '·,                                           |
            //      |      ',                                         |
            //  600 |        '·,                  2                   |
            //      |           ',                                    |
            //  500 |             '·,                                 |
            //      |                ',                               |
            //  400 |                  '·,                            |
            //      |                     ',                          |
            //  300 |                       '·,                       |
            //      |                          ',                     |
            //  200 |         1                  '·,                  |
            //      |                               ',                |
            //  100 |                                 '·,             |
            //      |                                    ',           |
            //    0 X--------------------------------------#A---------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(7, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 800, 0, 0, 800)); // A-B
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 800, 0)); // X-A
            Assert.IsTrue(AnyEdgeBetween(edges, 800, 0, 1000, 0)); // A-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 1000)); // Y-W
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 0, 1000)); // W-Z
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 800)); // Z-B
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 800, 0, 0)); // B-X
        }

        [Test]
        public void ThreeConcentricPointsDiagonalAroundMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(200, 800), // #1
                new VoronoiSite(500, 500), // #2
                new VoronoiSite(800, 200), // #3
            };

            // 1000 X---------------------------------#D--------------Z
            //      |                               ,'                |
            //  900 |                            ,·'                  |
            //      |                          ,'                     |
            //  800 |         1             ,·'                       |
            //      |                     ,'                          |
            //  700 |                  ,·'                           ,C
            //      |                ,'                            ,' |
            //  600 |             ,·'                           ,·'   |
            //      |           ,'                            ,'      |
            //  500 |        ,·'             2             ,·'        |
            //      |      ,'                            ,'           |
            //  400 |   ,·'                           ,·'             |
            //      | ,'                            ,'                |
            //  300 A'                           ,·'                  |
            //      |                          ,'                     |
            //  200 |                       ,·'             3         |
            //      |                     ,'                          |
            //  100 |                  ,·'                            |
            //      |                ,'                               |
            //    0 Y--------------B#---------------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(10, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 300, 700, 1000)); // A-D
            Assert.IsTrue(AnyEdgeBetween(edges, 300, 0, 1000, 700)); // B-C
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 300)); // X-A
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 300, 0, 0)); // A-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 300, 0)); // Y-B
            Assert.IsTrue(AnyEdgeBetween(edges, 300, 0, 1000, 0)); // B-W
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 700)); // W-C
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 700, 1000, 1000)); // C-Z
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 700, 1000)); // Z-D
            Assert.IsTrue(AnyEdgeBetween(edges, 700, 1000, 0, 1000)); // D-X
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreeConcentricPointsDiagonalAroundMiddle"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreeConcentricPointsDiagonalAroundMiddle_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(800, 800), // #1
                new VoronoiSite(500, 500), // #2
                new VoronoiSite(200, 200), // #3
            };

            // 1000 Y--------------A#---------------------------------X
            //      |                ',                               |
            //  900 |                  '·,                            |
            //      |                     ',                          |
            //  800 |                       '·,             1         |
            //      |                          ',                     |
            //  700 B,                           '·,                  |
            //      | ',                            ',                |
            //  600 |   '·,                           '·,             |
            //      |      ',                            ',           |
            //  500 |        '·,             2             '·,        |
            //      |           ',                            ',      |
            //  400 |             '·,                           '·,   |
            //      |                ',                            ', |
            //  300 |                  '·,                           'D
            //      |                     ',                          |
            //  200 |         3             '·,                       |
            //      |                          ',                     |
            //  100 |                            '·,                  |
            //      |                               ',                |
            //    0 W---------------------------------#C--------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(10, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 300, 1000, 1000, 300)); // A-D
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 700, 700, 0)); // B-C
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 300, 1000)); // X-A
            Assert.IsTrue(AnyEdgeBetween(edges, 300, 1000, 0, 1000)); // A-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 700)); // Y-B
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 700, 0, 0)); // B-W
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 700, 0)); // W-C
            Assert.IsTrue(AnyEdgeBetween(edges, 700, 0, 1000, 0)); // C-Z
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 300)); // Z-D
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 300, 1000, 1000)); // D-X
        }

        [Test]
        public void ThreeConcentricPointsDiagonalOffsetFromMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(200, 800), // #1
                new VoronoiSite(400, 600), // #2
                new VoronoiSite(600, 400), // #3
            };

            // 1000 X----------------------------#D------------------#C
            //      |                          ,'                  ,' |
            //  900 |                       ,·'                 ,·'   |
            //      |                     ,'                  ,'      |
            //  800 |         1        ,·'                 ,·'        |
            //      |                ,'                  ,'           |
            //  700 |             ,·'                 ,·'             |
            //      |           ,'                  ,'                |
            //  600 |        ,·'        2        ,·'                  |
            //      |      ,'                  ,'                     |
            //  500 |   ,·'                 ,·'                       |
            //      | ,'                  ,'                          |
            //  400 A'                 ,·'        3                   |
            //      |                ,'                               |
            //  300 |             ,·'                                 |
            //      |           ,'                                    |
            //  200 |        ,·'                                      |
            //      |      ,'                                         |
            //  100 |   ,·'                                           |
            //      | ,'                                              |
            //    0 B#------------------------------------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(8, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 400, 600, 1000)); // A-D
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 1000, 1000)); // B-C
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 400)); // X-A
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 400, 0, 0)); // A-B
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 1000, 0)); // B-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 1000)); // Y-C
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 600, 1000)); // C-D
            Assert.IsTrue(AnyEdgeBetween(edges, 600, 1000, 0, 1000)); // D-X
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreeConcentricPointsDiagonalOffsetFromMiddle"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreeConcentricPointsDiagonalOffsetFromMiddle_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(800, 800), // #1
                new VoronoiSite(600, 600), // #2
                new VoronoiSite(400, 400), // #3
            };

            // 1000 B#------------------A#----------------------------X
            //      | ',                  ',                          |
            //  900 |   '·,                 '·,                       |
            //      |      ',                  ',                     |
            //  800 |        '·,                 '·,        1         |
            //      |           ',                  ',                |
            //  700 |             '·,                 '·,             |
            //      |                ',                  ',           |
            //  600 |                  '·,        2        '·,        |
            //      |                     ',                  ',      |
            //  500 |                       '·,                 '·,   |
            //      |                          ',                  ', |
            //  400 |                   3        '·,                 'D
            //      |                               ',                |
            //  300 |                                 '·,             |
            //      |                                    ',           |
            //  200 |                                      '·,        |
            //      |                                         ',      |
            //  100 |                                           '·,   |
            //      |                                              ', |
            //    0 Y------------------------------------------------#C
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(8, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 400, 1000, 1000, 400)); // A-D
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 1000, 0)); // B-C
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 400, 1000)); // X-A
            Assert.IsTrue(AnyEdgeBetween(edges, 400, 1000, 0, 1000)); // A-B
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 0)); // B-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 1000, 0)); // Y-C
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 400)); // C-D
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 400, 1000, 1000)); // D-X
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreeConcentricPointsDiagonalOffsetFromMiddle"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreeConcentricPointsDiagonalOffsetFromMiddle_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(800, 200), // #1
                new VoronoiSite(600, 400), // #2
                new VoronoiSite(400, 600), // #3
            };

            // 1000 Y------------------------------------------------#B
            //      |                                              ,' |
            //  900 |                                           ,·'   |
            //      |                                         ,'      |
            //  800 |                                      ,·'        |
            //      |                                    ,'           |
            //  700 |                                 ,·'             |
            //      |                               ,'                |
            //  600 |                   3        ,·'                 ,A
            //      |                          ,'                  ,' |
            //  500 |                       ,·'                 ,·'   |
            //      |                     ,'                  ,'      |
            //  400 |                  ,·'        2        ,·'        |
            //      |                ,'                  ,'           |
            //  300 |             ,·'                 ,·'             |
            //      |           ,'                  ,'                |
            //  200 |        ,·'                 ,·'        1         |
            //      |      ,'                  ,'                     |
            //  100 |   ,·'                 ,·'                       |
            //      | ,'                  ,'                          |
            //    0 C#------------------D#----------------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(8, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 600, 400, 0)); // A-D
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 0, 0)); // B-C
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 600)); // X-A
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 600, 1000, 1000)); // A-B
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 0, 1000)); // B-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 0)); // Y-C
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 400, 0)); // C-D
            Assert.IsTrue(AnyEdgeBetween(edges, 400, 0, 1000, 0)); // D-X
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreeConcentricPointsDiagonalOffsetFromMiddle"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreeConcentricPointsDiagonalOffsetFromMiddle_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(200, 200), // #1
                new VoronoiSite(400, 400), // #2
                new VoronoiSite(600, 600), // #3
            };

            // 1000 C#------------------------------------------------Y
            //      | ',                                              |
            //  900 |   '·,                                           |
            //      |      ',                                         |
            //  800 |        '·,                                      |
            //      |           ',                                    |
            //  700 |             '·,                                 |
            //      |                ',                               |
            //  600 D,                 '·,        3                   |
            //      | ',                  ',                          |
            //  500 |   '·,                 '·,                       |
            //      |      ',                  ',                     |
            //  400 |        '·,        2        '·,                  |
            //      |           ',                  ',                |
            //  300 |             '·,                 '·,             |
            //      |                ',                  ',           |
            //  200 |         1        '·,                 '·,        |
            //      |                     ',                  ',      |
            //  100 |                       '·,                 '·,   |
            //      |                          ',                  ', |
            //    0 X----------------------------#A------------------#B
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(8, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 600, 0, 0, 600)); // A-D
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 0, 1000)); // B-C
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 600, 0)); // X-A
            Assert.IsTrue(AnyEdgeBetween(edges, 600, 0, 1000, 0)); // A-B
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 1000)); // B-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 0, 1000)); // Y-C
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 600)); // C-D
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 600, 0, 0)); // D-X
        }

        [Test]
        public void FourConcentricPointsDiagonalAroundMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(200, 800), // #1
                new VoronoiSite(400, 600), // #2
                new VoronoiSite(600, 400), // #3
                new VoronoiSite(800, 200), // #4
            };

            // 1000 X----------------------------#F------------------#E
            //      |                          ,'                  ,' |
            //  900 |                       ,·'                 ,·'   |
            //      |                     ,'                  ,'      |
            //  800 |         1        ,·'                 ,·'        |
            //      |                ,'                  ,'           |
            //  700 |             ,·'                 ,·'             |
            //      |           ,'                  ,'                |
            //  600 |        ,·'        2        ,·'                 ,D
            //      |      ,'                  ,'                  ,' |
            //  500 |   ,·'                 ,·'                 ,·'   |
            //      | ,'                  ,'                  ,'      |
            //  400 A'                 ,·'        3        ,·'        |
            //      |                ,'                  ,'           |
            //  300 |             ,·'                 ,·'             |
            //      |           ,'                  ,'                |
            //  200 |        ,·'                 ,·'        4         |
            //      |      ,'                  ,'                     |
            //  100 |   ,·'                 ,·'                       |
            //      | ,'                  ,'                          |
            //    0 B#------------------C#----------------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(11, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 400, 600, 1000)); // A-F
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 1000, 1000)); // B-E
            Assert.IsTrue(AnyEdgeBetween(edges, 400, 0, 1000, 600)); // C-D
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 400)); // X-A
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 400, 0, 0)); // A-B
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 400, 0)); // B-C
            Assert.IsTrue(AnyEdgeBetween(edges, 400, 0, 1000, 0)); // C-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 600)); // Y-D
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 600, 1000, 1000)); // D-E
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 600, 1000)); // E-F
            Assert.IsTrue(AnyEdgeBetween(edges, 600, 1000, 0, 1000)); // F-X
        }

        /// <summary>
        /// This test basically repeats <see cref="FourConcentricPointsDiagonalAroundMiddle"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void FourConcentricPointsDiagonalAroundMiddle_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(800, 800), // #1
                new VoronoiSite(600, 600), // #2
                new VoronoiSite(400, 400), // #3
                new VoronoiSite(200, 200), // #4
            };

            // 1000 B#------------------A#----------------------------X
            //      | ',                  ',                          |
            //  900 |   '·,                 '·,                       |
            //      |      ',                  ',                     |
            //  800 |        '·,                 '·,        1         |
            //      |           ',                  ',                |
            //  700 |             '·,                 '·,             |
            //      |                ',                  ',           |
            //  600 C,                 '·,        2        '·,        |
            //      | ',                  ',                  ',      |
            //  500 |   '·,                 '·,                 '·,   |
            //      |      ',                  ',                  ', |
            //  400 |        '·,        3        '·,                 'F
            //      |           ',                  ',                |
            //  300 |             '·,                 '·,             |
            //      |                ',                  ',           |
            //  200 |         4        '·,                 '·,        |
            //      |                     ',                  ',      |
            //  100 |                       '·,                 '·,   |
            //      |                          ',                  ', |
            //    0 Y----------------------------#D------------------#E
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(11, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 400, 1000, 1000, 400)); // A-F
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 1000, 0)); // B-E
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 600, 600, 0)); // C-D
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 400, 1000)); // X-A
            Assert.IsTrue(AnyEdgeBetween(edges, 400, 1000, 0, 1000)); // A-B
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 600)); // B-C
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 600, 0, 0)); // C-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 600, 0)); // Y-D
            Assert.IsTrue(AnyEdgeBetween(edges, 600, 0, 1000, 0)); // D-E
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 400)); // E-F
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 400, 1000, 1000)); // F-X
        }

        [Test]
        public void ThreePointsInAWedgeTowardsCorner()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(300, 500), // #1
                new VoronoiSite(300, 300), // #2
                new VoronoiSite(500, 300), // #3
            };

            // 1000 X------------------------------------------------#D
            //      |                                              ,' |
            //  900 |                                           ,·'   |
            //      |                                         ,'      |
            //  800 |                                      ,·'        |
            //      |                                    ,'           |
            //  700 |                                 ,·'             |
            //      |                               ,'                |
            //  600 |                            ,·'                  |
            //      |                          ,'                     |
            //  500 |              1        ,·'                       |
            //      |                     ,'                          |
            //  400 B-------------------A'                            |
            //      |                   |                             |
            //  300 |              2    |    3                        |
            //      |                   |                             |
            //  200 |                   |                             |
            //      |                   |                             |
            //  100 |                   |                             |
            //      |                   |                             |
            //    0 Y-------------------C-----------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(9, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 400, 400, 0, 400)); // A-B
            Assert.IsTrue(AnyEdgeBetween(edges, 400, 400, 400, 0)); // A-C
            Assert.IsTrue(AnyEdgeBetween(edges, 400, 400, 1000, 1000)); // A-D
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 400)); // X-B
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 400, 0, 0)); // B-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 400, 0)); // Y-C
            Assert.IsTrue(AnyEdgeBetween(edges, 400, 0, 1000, 0)); // C-W
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 1000)); // W-D
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 0, 1000)); // D-X
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeTowardsCorner"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeTowardsCorner_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 700), // #1
                new VoronoiSite(300, 700), // #2
                new VoronoiSite(300, 500), // #3
            };

            // 1000 Y-------------------B-----------------------------X
            //      |                   |                             |
            //  900 |                   |                             |
            //      |                   |                             |
            //  800 |                   |                             |
            //      |                   |                             |
            //  700 |              2    |    1                        |
            //      |                   |                             |
            //  600 C-------------------A,                            |
            //      |                     ',                          |
            //  500 |              3        '·,                       |
            //      |                          ',                     |
            //  400 |                            '·,                  |
            //      |                               ',                |
            //  300 |                                 '·,             |
            //      |                                    ',           |
            //  200 |                                      '·,        |
            //      |                                         ',      |
            //  100 |                                           '·,   |
            //      |                                              ', |
            //    0 W------------------------------------------------#D
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(9, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 400, 600, 400, 1000)); // A-B
            Assert.IsTrue(AnyEdgeBetween(edges, 400, 600, 0, 600)); // A-C
            Assert.IsTrue(AnyEdgeBetween(edges, 400, 600, 1000, 0)); // A-D
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 400, 1000)); // X-B
            Assert.IsTrue(AnyEdgeBetween(edges, 400, 1000, 0, 1000)); // B-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 600)); // Y-C
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 600, 0, 0)); // C-W
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 1000, 0)); // W-D
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 1000)); // D-X
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeTowardsCorner"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeTowardsCorner_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(700, 500), // #1
                new VoronoiSite(700, 700), // #2
                new VoronoiSite(500, 700), // #3
            };

            // 1000 W-----------------------------C-------------------Y
            //      |                             |                   |
            //  900 |                             |                   |
            //      |                             |                   |
            //  800 |                             |                   |
            //      |                             |                   |
            //  700 |                        3    |    2              |
            //      |                             |                   |
            //  600 |                            ,A-------------------B
            //      |                          ,'                     |
            //  500 |                       ,·'        1              |
            //      |                     ,'                          |
            //  400 |                  ,·'                            |
            //      |                ,'                               |
            //  300 |             ,·'                                 |
            //      |           ,'                                    |
            //  200 |        ,·'                                      |
            //      |      ,'                                         |
            //  100 |   ,·'                                           |
            //      | ,'                                              |
            //    0 D#------------------------------------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(9, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 600, 600, 1000, 600)); // A-B
            Assert.IsTrue(AnyEdgeBetween(edges, 600, 600, 600, 1000)); // A-C
            Assert.IsTrue(AnyEdgeBetween(edges, 600, 600, 0, 0)); // A-D
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 600)); // X-B
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 600, 1000, 1000)); // B-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 600, 1000)); // Y-C
            Assert.IsTrue(AnyEdgeBetween(edges, 600, 1000, 0, 1000)); // C-W
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 0)); // W-D
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 1000, 0)); // D-X
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeTowardsCorner"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeTowardsCorner_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 300), // #1
                new VoronoiSite(700, 300), // #2
                new VoronoiSite(700, 500), // #3
            };

            // 1000 D#------------------------------------------------W
            //      | ',                                              |
            //  900 |   '·,                                           |
            //      |      ',                                         |
            //  800 |        '·,                                      |
            //      |           ',                                    |
            //  700 |             '·,                                 |
            //      |                ',                               |
            //  600 |                  '·,                            |
            //      |                     ',                          |
            //  500 |                       '·,        3              |
            //      |                          ',                     |
            //  400 |                            'A-------------------C
            //      |                             |                   |
            //  300 |                        1    |    2              |
            //      |                             |                   |
            //  200 |                             |                   |
            //      |                             |                   |
            //  100 |                             |                   |
            //      |                             |                   |
            //    0 X-----------------------------B-------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(9, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 600, 400, 600, 0)); // A-B
            Assert.IsTrue(AnyEdgeBetween(edges, 600, 400, 1000, 400)); // A-C
            Assert.IsTrue(AnyEdgeBetween(edges, 600, 400, 0, 1000)); // A-D
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 600, 0)); // X-B
            Assert.IsTrue(AnyEdgeBetween(edges, 600, 0, 1000, 0)); // B-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 400)); // Y-C
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 400, 1000, 1000)); // C-W
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 0, 1000)); // W-D
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 0)); // D-X
        }

        [Test]
        public void ThreePointsInAWedgeTowardsSideAroundMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 300), // #1
                new VoronoiSite(700, 500), // #2
                new VoronoiSite(300, 500), // #3
            };

            // 1000 X------------------------D------------------------Y
            //      |                        |                        |
            //  900 |                        |                        |
            //      |                        |                        |
            //  800 |                        |                        |
            //      |                        |                        |
            //  700 |                        |                        |
            //      |                        |                        |
            //  600 |                        |                        |
            //      |                        |                        |
            //  500 |              3        ,A,        2              |
            //      |                     ,'   ',                     |
            //  400 |                  ,·'       '·,                  |
            //      |                ,'             ',                |
            //  300 |             ,·'        1        '·,             |
            //      |           ,'                       ',           |
            //  200 |        ,·'                           '·,        |
            //      |      ,'                                 ',      |
            //  100 |   ,·'                                     '·,   |
            //      | ,'                                           ', |
            //    0 B#-----------------------------------------------#C
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(8, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 500, 0, 0)); // A-B
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 500, 1000, 0)); // A-C
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 500, 500, 1000)); // A-D
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 0)); // X-B
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 1000, 0)); // B-C
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 1000)); // C-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 500, 1000)); // Y-D
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 1000, 0, 1000)); // D-X
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeTowardsSideAroundMiddle"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeTowardsSideAroundMiddle_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(300, 500), // #1
                new VoronoiSite(500, 300), // #2
                new VoronoiSite(500, 700), // #3
            };

            // 1000 B#------------------------------------------------X
            //      | ',                                              |
            //  900 |   '·,                                           |
            //      |      ',                                         |
            //  800 |        '·,                                      |
            //      |           ',                                    |
            //  700 |             '·,        3                        |
            //      |                ',                               |
            //  600 |                  '·,                            |
            //      |                     ',                          |
            //  500 |              1        #A------------------------D
            //      |                     ,'                          |
            //  400 |                  ,·'                            |
            //      |                ,'                               |
            //  300 |             ,·'        2                        |
            //      |           ,'                                    |
            //  200 |        ,·'                                      |
            //      |      ,'                                         |
            //  100 |   ,·'                                           |
            //      | ,'                                              |
            //    0 C#------------------------------------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(8, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 500, 0, 1000)); // A-B
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 500, 0, 0)); // A-C
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 500, 1000, 500)); // A-D
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 0, 1000)); // X-B
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 0)); // B-C
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 1000, 0)); // C-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 500)); // Y-D
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 500, 1000, 1000)); // D-X
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeTowardsSideAroundMiddle"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeTowardsSideAroundMiddle_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 700), // #1
                new VoronoiSite(300, 500), // #2
                new VoronoiSite(700, 500), // #3
            };

            // 1000 C#-----------------------------------------------#B
            //      | ',                                           ,' |
            //  900 |   '·,                                     ,·'   |
            //      |      ',                                 ,'      |
            //  800 |        '·,                           ,·'        |
            //      |           ',                       ,'           |
            //  700 |             '·,        1        ,·'             |
            //      |                ',             ,'                |
            //  600 |                  '·,       ,·'                  |
            //      |                     ',   ,'                     |
            //  500 |              2        'A'        3              |
            //      |                        |                        |
            //  400 |                        |                        |
            //      |                        |                        |
            //  300 |                        |                        |
            //      |                        |                        |
            //  200 |                        |                        |
            //      |                        |                        |
            //  100 |                        |                        |
            //      |                        |                        |
            //    0 Y------------------------D------------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(8, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 500, 1000, 1000)); // A-B
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 500, 0, 1000)); // A-C
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 500, 500, 0)); // A-D
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 1000)); // X-B
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 0, 1000)); // B-C
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 0)); // C-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 500, 0)); // Y-D
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 0, 1000, 0)); // D-X
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeTowardsSideAroundMiddle"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeTowardsSideAroundMiddle_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(700, 500), // #1
                new VoronoiSite(500, 700), // #2
                new VoronoiSite(500, 300), // #3
            };

            // 1000 Y------------------------------------------------#C
            //      |                                              ,' |
            //  900 |                                           ,·'   |
            //      |                                         ,'      |
            //  800 |                                      ,·'        |
            //      |                                    ,'           |
            //  700 |                        2        ,·'             |
            //      |                               ,'                |
            //  600 |                            ,·'                  |
            //      |                          ,'                     |
            //  500 D------------------------A#        1              |
            //      |                          ',                     |
            //  400 |                            '·,                  |
            //      |                               ',                |
            //  300 |                        3        '·,             |
            //      |                                    ',           |
            //  200 |                                      '·,        |
            //      |                                         ',      |
            //  100 |                                           '·,   |
            //      |                                              ', |
            //    0 X------------------------------------------------#B
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(8, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 500, 1000, 0)); // A-B
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 500, 1000, 1000)); // A-C
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 500, 0, 500)); // A-D
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 1000, 0)); // X-B
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 1000)); // B-C
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 0, 1000)); // C-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 500)); // Y-D
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 500, 0, 0)); // D-X
        }

        [Test]
        public void ThreePointsInAWedgeTowardsSideOffsetFromMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 100), // #1
                new VoronoiSite(700, 300), // #2
                new VoronoiSite(300, 300), // #3
            };

            // 1000 X------------------------D------------------------Z
            //      |                        |                        |
            //  900 |                        |                        |
            //      |                        |                        |
            //  800 |                        |                        |
            //      |                        |                        |
            //  700 |                        |                        |
            //      |                        |                        |
            //  600 |                        |                        |
            //      |                        |                        |
            //  500 |                        |                        |
            //      |                        |                        |
            //  400 |                        |                        |
            //      |                        |                        |
            //  300 |              3        ,A,        2              |
            //      |                     ,'   ',                     |
            //  200 |                  ,·'       '·,                  |
            //      |                ,'             ',                |
            //  100 |             ,·'        1        '·,             |
            //      |           ,'                       ',           |
            //    0 Y---------B#---------------------------#C---------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(10, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 300, 200, 0)); // A-B
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 300, 800, 0)); // A-C
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 300, 500, 1000)); // A-D
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 0)); // X-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 200, 0)); // Y-B
            Assert.IsTrue(AnyEdgeBetween(edges, 200, 0, 800, 0)); // B-C
            Assert.IsTrue(AnyEdgeBetween(edges, 800, 0, 1000, 0)); // C-W
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 1000)); // W-Z
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 500, 1000)); // Z-D
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 1000, 0, 1000)); // D-X
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeTowardsSideOffsetFromMiddle"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeTowardsSideOffsetFromMiddle_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(100, 500), // #1
                new VoronoiSite(300, 300), // #2
                new VoronoiSite(300, 700), // #3
            };

            // 1000 Y-------------------------------------------------X
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 B,                                                |
            //      | ',                                              |
            //  700 |   '·,        3                                  |
            //      |      ',                                         |
            //  600 |        '·,                                      |
            //      |           ',                                    |
            //  500 |    1        #A----------------------------------D
            //      |           ,'                                    |
            //  400 |        ,·'                                      |
            //      |      ,'                                         |
            //  300 |   ,·'        2                                  |
            //      | ,'                                              |
            //  200 C'                                                |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 W-------------------------------------------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(10, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 300, 500, 0, 800)); // A-B
            Assert.IsTrue(AnyEdgeBetween(edges, 300, 500, 0, 200)); // A-C
            Assert.IsTrue(AnyEdgeBetween(edges, 300, 500, 1000, 500)); // A-D
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 0, 1000)); // X-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 800)); // Y-B
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 800, 0, 200)); // B-C
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 200, 0, 0)); // C-W
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 1000, 0)); // W-Z
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 500)); // Z-D
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 500, 1000, 1000)); // D-X
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeTowardsSideOffsetFromMiddle"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeTowardsSideOffsetFromMiddle_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 900), // #1
                new VoronoiSite(300, 700), // #2
                new VoronoiSite(700, 700), // #3
            };

            // 1000 W---------C#---------------------------#B---------Y
            //      |           ',                       ,'           |
            //  900 |             '·,        1        ,·'             |
            //      |                ',             ,'                |
            //  800 |                  '·,       ,·'                  |
            //      |                     ',   ,'                     |
            //  700 |              2        'A'        3              |
            //      |                        |                        |
            //  600 |                        |                        |
            //      |                        |                        |
            //  500 |                        |                        |
            //      |                        |                        |
            //  400 |                        |                        |
            //      |                        |                        |
            //  300 |                        |                        |
            //      |                        |                        |
            //  200 |                        |                        |
            //      |                        |                        |
            //  100 |                        |                        |
            //      |                        |                        |
            //    0 Z------------------------D------------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(10, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 700, 800, 1000)); // A-B
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 700, 200, 1000)); // A-C
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 700, 500, 0)); // A-D
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 1000)); // X-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 800, 1000)); // Y-B
            Assert.IsTrue(AnyEdgeBetween(edges, 800, 1000, 200, 1000)); // B-C
            Assert.IsTrue(AnyEdgeBetween(edges, 200, 1000, 0, 1000)); // C-W
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 0)); // W-Z
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 500, 0)); // Z-D
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 0, 1000, 0)); // D-X
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeTowardsSideOffsetFromMiddle"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeTowardsSideOffsetFromMiddle_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(900, 500), // #1
                new VoronoiSite(700, 700), // #2
                new VoronoiSite(700, 300), // #3
            };

            // 1000 Z-------------------------------------------------W
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                ,C
            //      |                                              ,' |
            //  700 |                                  2        ,·'   |
            //      |                                         ,'      |
            //  600 |                                      ,·'        |
            //      |                                    ,'           |
            //  500 D----------------------------------A#        1    |
            //      |                                    ',           |
            //  400 |                                      '·,        |
            //      |                                         ',      |
            //  300 |                                  3        '·,   |
            //      |                                              ', |
            //  200 |                                                'B
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 X-------------------------------------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(10, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 700, 500, 1000, 200)); // A-B
            Assert.IsTrue(AnyEdgeBetween(edges, 700, 500, 1000, 800)); // A-C
            Assert.IsTrue(AnyEdgeBetween(edges, 700, 500, 0, 500)); // A-D
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 1000, 0)); // X-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 200)); // Y-B
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 200, 1000, 800)); // B-C
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 800, 1000, 1000)); // C-W
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 0, 1000)); // W-Z
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 500)); // Z-D
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 500, 0, 0)); // D-X
        }

        [Test]
        public void ThreePointsInAWedgeTowardsSideOffsetIntoMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 500), // #1
                new VoronoiSite(700, 700), // #2
                new VoronoiSite(300, 700), // #3
            };

            // 1000 X------------------------D------------------------Z
            //      |                        |                        |
            //  900 |                        |                        |
            //      |                        |                        |
            //  800 |                        |                        |
            //      |                        |                        |
            //  700 |              3        ,A,        2              |
            //      |                     ,'   ',                     |
            //  600 |                  ,·'       '·,                  |
            //      |                ,'             ',                |
            //  500 |             ,·'        1        '·,             |
            //      |           ,'                       ',           |
            //  400 |        ,·'                           '·,        |
            //      |      ,'                                 ',      |
            //  300 |   ,·'                                     '·,   |
            //      | ,'                                           ', |
            //  200 B'                                               'C
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 Y-------------------------------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(10, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 700, 0, 200)); // A-B
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 700, 1000, 200)); // A-C
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 700, 500, 1000)); // A-D
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 200)); // X-B
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 200, 0, 0)); // B-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 1000, 0)); // Y-W
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 200)); // W-C
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 200, 1000, 1000)); // C-Z
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 500, 1000)); // Z-D
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 1000, 0, 1000)); // D-X
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeTowardsSideOffsetIntoMiddle"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeTowardsSideOffsetIntoMiddle_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 500), // #1
                new VoronoiSite(700, 300), // #2
                new VoronoiSite(700, 700), // #3
            };

            // 1000 Y---------B#--------------------------------------X
            //      |           ',                                    |
            //  900 |             '·,                                 |
            //      |                ',                               |
            //  800 |                  '·,                            |
            //      |                     ',                          |
            //  700 |                       '·,        3              |
            //      |                          ',                     |
            //  600 |                            '·,                  |
            //      |                               ',                |
            //  500 |                        1        #A--------------D
            //      |                               ,'                |
            //  400 |                            ,·'                  |
            //      |                          ,'                     |
            //  300 |                       ,·'        2              |
            //      |                     ,'                          |
            //  200 |                  ,·'                            |
            //      |                ,'                               |
            //  100 |             ,·'                                 |
            //      |           ,'                                    |
            //    0 W---------C#--------------------------------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(10, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 700, 500, 200, 1000)); // A-B
            Assert.IsTrue(AnyEdgeBetween(edges, 700, 500, 200, 0)); // A-C
            Assert.IsTrue(AnyEdgeBetween(edges, 700, 500, 1000, 500)); // A-D
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 200, 1000)); // X-B
            Assert.IsTrue(AnyEdgeBetween(edges, 200, 1000, 0, 1000)); // B-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 0)); // Y-W
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 200, 0)); // W-C
            Assert.IsTrue(AnyEdgeBetween(edges, 200, 0, 1000, 0)); // C-Z
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 500)); // Z-D
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 500, 1000, 1000)); // D-X
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeTowardsSideOffsetIntoMiddle"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeTowardsSideOffsetIntoMiddle_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 500), // #1
                new VoronoiSite(300, 300), // #2
                new VoronoiSite(700, 300), // #3
            };

            // 1000 W-------------------------------------------------Y
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 C,                                               ,B
            //      | ',                                           ,' |
            //  700 |   '·,                                     ,·'   |
            //      |      ',                                 ,'      |
            //  600 |        '·,                           ,·'        |
            //      |           ',                       ,'           |
            //  500 |             '·,        1        ,·'             |
            //      |                ',             ,'                |
            //  400 |                  '·,       ,·'                  |
            //      |                     ',   ,'                     |
            //  300 |              2        'A'        3              |
            //      |                        |                        |
            //  200 |                        |                        |
            //      |                        |                        |
            //  100 |                        |                        |
            //      |                        |                        |
            //    0 Z------------------------D------------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(10, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 300, 1000, 800)); // A-B
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 300, 0, 800)); // A-C
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 300, 500, 0)); // A-D
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 800)); // X-B
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 800, 1000, 1000)); // B-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 0, 1000)); // Y-W
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 800)); // W-C
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 800, 0, 0)); // C-Z
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 500, 0)); // Z-D
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 0, 1000, 0)); // D-X
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeTowardsSideOffsetIntoMiddle"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeTowardsSideOffsetIntoMiddle_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 500), // #1
                new VoronoiSite(300, 700), // #2
                new VoronoiSite(300, 300), // #3
            };

            // 1000 Z--------------------------------------#C---------W
            //      |                                    ,'           |
            //  900 |                                 ,·'             |
            //      |                               ,'                |
            //  800 |                            ,·'                  |
            //      |                          ,'                     |
            //  700 |              2        ,·'                       |
            //      |                     ,'                          |
            //  600 |                  ,·'                            |
            //      |                ,'                               |
            //  500 D--------------A#        1                        |
            //      |                ',                               |
            //  400 |                  '·,                            |
            //      |                     ',                          |
            //  300 |              3        '·,                       |
            //      |                          ',                     |
            //  200 |                            '·,                  |
            //      |                               ',                |
            //  100 |                                 '·,             |
            //      |                                    ',           |
            //    0 X--------------------------------------#B---------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(10, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 300, 500, 800, 0)); // A-B
            Assert.IsTrue(AnyEdgeBetween(edges, 300, 500, 800, 1000)); // A-C
            Assert.IsTrue(AnyEdgeBetween(edges, 300, 500, 0, 500)); // A-D
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 800, 0)); // X-B
            Assert.IsTrue(AnyEdgeBetween(edges, 800, 0, 1000, 0)); // B-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 1000)); // Y-W
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 800, 1000)); // W-C
            Assert.IsTrue(AnyEdgeBetween(edges, 800, 1000, 0, 1000)); // C-Z
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 500)); // Z-D
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 500, 0, 0)); // D-X
        }

        [Test]
        public void FourPointsSurroundingAPointInMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 500), // #1
                new VoronoiSite(300, 500), // #2
                new VoronoiSite(500, 300), // #3
                new VoronoiSite(700, 500), // #4
                new VoronoiSite(500, 700), // #5
            };

            // 1000 E#-----------------------------------------------#H
            //      | ',                                           ,' |
            //  900 |   '·,                                     ,·'   |
            //      |      ',                                 ,'      |
            //  800 |        '·,                           ,·'        |
            //      |           ',                       ,'           |
            //  700 |             '·,        5        ,·'             |
            //      |                ',             ,'                |
            //  600 |                  'A---------D'                  |
            //      |                   |         |                   |
            //  500 |              2    |    1    |    4              |
            //      |                   |         |                   |
            //  400 |                  ,B---------C,                  |
            //      |                ,'             ',                |
            //  300 |             ,·'        3        '·,             |
            //      |           ,'                       ',           |
            //  200 |        ,·'                           '·,        |
            //      |      ,'                                 ',      |
            //  100 |   ,·'                                     '·,   |
            //      | ,'                                           ', |
            //    0 F#-----------------------------------------------#G
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(12, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 400, 600, 400, 400)); // A-B
            Assert.IsTrue(AnyEdgeBetween(edges, 400, 400, 600, 400)); // B-C
            Assert.IsTrue(AnyEdgeBetween(edges, 600, 400, 600, 600)); // C-D
            Assert.IsTrue(AnyEdgeBetween(edges, 600, 600, 400, 600)); // D-A
            Assert.IsTrue(AnyEdgeBetween(edges, 400, 600, 0, 1000)); // A-E
            Assert.IsTrue(AnyEdgeBetween(edges, 400, 400, 0, 0)); // B-F
            Assert.IsTrue(AnyEdgeBetween(edges, 600, 400, 1000, 0)); // C-G
            Assert.IsTrue(AnyEdgeBetween(edges, 600, 600, 1000, 1000)); // D-H
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 0)); // E-F
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 1000, 0)); // F-G
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 1000)); // G-H
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 0, 1000)); // H-E
        }

        [Test]
        public void FourPointsSurroundingAPointOffsetFromMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 300), // #1
                new VoronoiSite(300, 300), // #2
                new VoronoiSite(500, 100), // #3
                new VoronoiSite(700, 300), // #4
                new VoronoiSite(500, 500), // #5
            };

            // 1000 X-------------------------------------------------Z
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 E,                                               ,H
            //      | ',                                           ,' |
            //  700 |   '·,                                     ,·'   |
            //      |      ',                                 ,'      |
            //  600 |        '·,                           ,·'        |
            //      |           ',                       ,'           |
            //  500 |             '·,        5        ,·'             |
            //      |                ',             ,'                |
            //  400 |                  'A---------D'                  |
            //      |                   |         |                   |
            //  300 |              2    |    1    |    4              |
            //      |                   |         |                   |
            //  200 |                  ,B---------C,                  |
            //      |                ,'             ',                |
            //  100 |             ,·'        3        '·,             |
            //      |           ,'                       ',           |
            //    0 Y---------F#---------------------------#G---------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(16, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 400, 400, 400, 200)); // A-B
            Assert.IsTrue(AnyEdgeBetween(edges, 400, 200, 600, 200)); // B-C
            Assert.IsTrue(AnyEdgeBetween(edges, 600, 200, 600, 400)); // C-D
            Assert.IsTrue(AnyEdgeBetween(edges, 600, 400, 400, 400)); // D-A
            Assert.IsTrue(AnyEdgeBetween(edges, 400, 400, 0, 800)); // A-E
            Assert.IsTrue(AnyEdgeBetween(edges, 400, 200, 200, 0)); // B-F
            Assert.IsTrue(AnyEdgeBetween(edges, 600, 200, 800, 0)); // C-G
            Assert.IsTrue(AnyEdgeBetween(edges, 600, 400, 1000, 800)); // D-H
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 800)); // X-E
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 800, 0, 0)); // E-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 200, 0)); // Y-F
            Assert.IsTrue(AnyEdgeBetween(edges, 200, 0, 800, 0)); // F-G
            Assert.IsTrue(AnyEdgeBetween(edges, 800, 0, 1000, 0)); // G-W
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 800)); // W-H
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 800, 1000, 1000)); // H-Z
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 0, 1000)); // Z-X
        }

        /// <summary>
        /// This test basically repeats <see cref="FourPointsSurroundingAPointOffsetFromMiddle"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void FourPointsSurroundingAPointOffsetFromMiddle_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(300, 500), // #1
                new VoronoiSite(300, 700), // #2
                new VoronoiSite(100, 500), // #3
                new VoronoiSite(300, 300), // #4
                new VoronoiSite(500, 500), // #5
            };

            // 1000 Y--------------------------------------#E---------X
            //      |                                    ,'           |
            //  900 |                                 ,·'             |
            //      |                               ,'                |
            //  800 F,                           ,·'                  |
            //      | ',                       ,'                     |
            //  700 |   '·,        2        ,·'                       |
            //      |      ',             ,'                          |
            //  600 |        'B---------A'                            |
            //      |         |         |                             |
            //  500 |    3    |    1    |    5                        |
            //      |         |         |                             |
            //  400 |        ,C---------D,                            |
            //      |      ,'             ',                          |
            //  300 |   ,·'        4        '·,                       |
            //      | ,'                       ',                     |
            //  200 G'                           '·,                  |
            //      |                               ',                |
            //  100 |                                 '·,             |
            //      |                                    ',           |
            //    0 W--------------------------------------#H---------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(16, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 400, 600, 200, 600)); // A-B
            Assert.IsTrue(AnyEdgeBetween(edges, 200, 600, 200, 400)); // B-C
            Assert.IsTrue(AnyEdgeBetween(edges, 200, 400, 400, 400)); // C-D
            Assert.IsTrue(AnyEdgeBetween(edges, 400, 400, 400, 600)); // D-A
            Assert.IsTrue(AnyEdgeBetween(edges, 400, 600, 800, 1000)); // A-E
            Assert.IsTrue(AnyEdgeBetween(edges, 200, 600, 0, 800)); // B-F
            Assert.IsTrue(AnyEdgeBetween(edges, 200, 400, 0, 200)); // C-G
            Assert.IsTrue(AnyEdgeBetween(edges, 400, 400, 800, 0)); // D-H
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 800, 1000)); // X-E
            Assert.IsTrue(AnyEdgeBetween(edges, 800, 1000, 0, 1000)); // E-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 800)); // Y-F
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 800, 0, 200)); // F-G
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 200, 0, 0)); // G-W
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 800, 0)); // W-H
            Assert.IsTrue(AnyEdgeBetween(edges, 800, 0, 1000, 0)); // H-Z
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 1000)); // Z-X
        }

        /// <summary>
        /// This test basically repeats <see cref="FourPointsSurroundingAPointOffsetFromMiddle"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void FourPointsSurroundingAPointOffsetFromMiddle_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 700), // #1
                new VoronoiSite(700, 700), // #2
                new VoronoiSite(500, 900), // #3
                new VoronoiSite(300, 700), // #4
                new VoronoiSite(500, 500), // #5
            };

            // 1000 W---------G#---------------------------#F---------Y
            //      |           ',                       ,'           |
            //  900 |             '·,        3        ,·'             |
            //      |                ',             ,'                |
            //  800 |                  'C---------B'                  |
            //      |                   |         |                   |
            //  700 |              4    |    1    |    2              |
            //      |                   |         |                   |
            //  600 |                  ,D---------A,                  |
            //      |                ,'             ',                |
            //  500 |             ,·'        5        '·,             |
            //      |           ,'                       ',           |
            //  400 |        ,·'                           '·,        |
            //      |      ,'                                 ',      |
            //  300 |   ,·'                                     '·,   |
            //      | ,'                                           ', |
            //  200 H'                                               'E
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 Z-------------------------------------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(16, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 600, 600, 600, 800)); // A-B
            Assert.IsTrue(AnyEdgeBetween(edges, 600, 800, 400, 800)); // B-C
            Assert.IsTrue(AnyEdgeBetween(edges, 400, 800, 400, 600)); // C-D
            Assert.IsTrue(AnyEdgeBetween(edges, 400, 600, 600, 600)); // D-A
            Assert.IsTrue(AnyEdgeBetween(edges, 600, 600, 1000, 200)); // A-E
            Assert.IsTrue(AnyEdgeBetween(edges, 600, 800, 800, 1000)); // B-F
            Assert.IsTrue(AnyEdgeBetween(edges, 400, 800, 200, 1000)); // C-G
            Assert.IsTrue(AnyEdgeBetween(edges, 400, 600, 0, 200)); // D-H
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 200)); // X-E
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 200, 1000, 1000)); // E-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 800, 1000)); // Y-F
            Assert.IsTrue(AnyEdgeBetween(edges, 800, 1000, 200, 1000)); // F-G
            Assert.IsTrue(AnyEdgeBetween(edges, 200, 1000, 0, 1000)); // G-W
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 200)); // W-H
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 200, 0, 0)); // H-Z
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 1000, 0)); // Z-X
        }

        /// <summary>
        /// This test basically repeats <see cref="FourPointsSurroundingAPointOffsetFromMiddle"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void FourPointsSurroundingAPointOffsetFromMiddle_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(700, 500), // #1
                new VoronoiSite(700, 300), // #2
                new VoronoiSite(900, 500), // #3
                new VoronoiSite(700, 700), // #4
                new VoronoiSite(500, 500), // #5
            };

            // 1000 Z---------H#--------------------------------------W
            //      |           ',                                    |
            //  900 |             '·,                                 |
            //      |                ',                               |
            //  800 |                  '·,                           ,G
            //      |                     ',                       ,' |
            //  700 |                       '·,        4        ,·'   |
            //      |                          ',             ,'      |
            //  600 |                            'D---------C'        |
            //      |                             |         |         |
            //  500 |                        5    |    1    |    3    |
            //      |                             |         |         |
            //  400 |                            ,A---------B,        |
            //      |                          ,'             ',      |
            //  300 |                       ,·'        2        '·,   |
            //      |                     ,'                       ', |
            //  200 |                  ,·'                           'F
            //      |                ,'                               |
            //  100 |             ,·'                                 |
            //      |           ,'                                    |
            //    0 X---------E#--------------------------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(16, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 600, 400, 800, 400)); // A-B
            Assert.IsTrue(AnyEdgeBetween(edges, 800, 400, 800, 600)); // B-C
            Assert.IsTrue(AnyEdgeBetween(edges, 800, 600, 600, 600)); // C-D
            Assert.IsTrue(AnyEdgeBetween(edges, 600, 600, 600, 400)); // D-A
            Assert.IsTrue(AnyEdgeBetween(edges, 600, 400, 200, 0)); // A-E
            Assert.IsTrue(AnyEdgeBetween(edges, 800, 400, 1000, 200)); // B-F
            Assert.IsTrue(AnyEdgeBetween(edges, 800, 600, 1000, 800)); // C-G
            Assert.IsTrue(AnyEdgeBetween(edges, 600, 600, 200, 1000)); // D-H
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 200, 0)); // X-E
            Assert.IsTrue(AnyEdgeBetween(edges, 200, 0, 1000, 0)); // E-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 200)); // Y-F
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 200, 1000, 800)); // F-G
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 800, 1000, 1000)); // G-W
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 200, 1000)); // W-H
            Assert.IsTrue(AnyEdgeBetween(edges, 200, 1000, 0, 1000)); // H-Z
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 0)); // Z-X
        }

        [Test]
        public void FourEquidistantPointsInASquareAroundMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(300, 700), // #1
                new VoronoiSite(300, 300), // #2
                new VoronoiSite(700, 300), // #3
                new VoronoiSite(700, 700), // #4
            };

            // 1000 X------------------------B------------------------Z
            //      |                        |                        |
            //  900 |                        |                        |
            //      |                        |                        |
            //  800 |                        |                        |
            //      |                        |                        |
            //  700 |              1         |         4              |
            //      |                        |                        |
            //  600 |                        |                        |
            //      |                        |                        |
            //  500 C------------------------A------------------------E
            //      |                        |                        |
            //  400 |                        |                        |
            //      |                        |                        |
            //  300 |              2         |         3              |
            //      |                        |                        |
            //  200 |                        |                        |
            //      |                        |                        |
            //  100 |                        |                        |
            //      |                        |                        |
            //    0 Y------------------------D------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(12, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 500, 500, 1000)); // A-B
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 500, 0, 500)); // A-C
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 500, 500, 0)); // A-D
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 500, 1000, 500)); // A-E
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 500)); // X-C
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 500, 0, 0)); // C-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 500, 0)); // Y-D
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 0, 1000, 0)); // D-W
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 500)); // W-E
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 500, 1000, 1000)); // E-Z
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 500, 1000)); // Z-B
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 1000, 0, 1000)); // B-X
        }

        [Test]
        public void FourEquidistantPointsInARectangleAroundMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(400, 800), // #1
                new VoronoiSite(400, 200), // #2
                new VoronoiSite(600, 200), // #3
                new VoronoiSite(600, 800), // #4
            };

            // 1000 X------------------------B------------------------Z
            //      |                        |                        |
            //  900 |                        |                        |
            //      |                        |                        |
            //  800 |                   1    |    4                   |
            //      |                        |                        |
            //  700 |                        |                        |
            //      |                        |                        |
            //  600 |                        |                        |
            //      |                        |                        |
            //  500 C------------------------A------------------------E
            //      |                        |                        |
            //  400 |                        |                        |
            //      |                        |                        |
            //  300 |                        |                        |
            //      |                        |                        |
            //  200 |                   2    |    3                   |
            //      |                        |                        |
            //  100 |                        |                        |
            //      |                        |                        |
            //    0 Y------------------------D------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(12, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 500, 500, 1000)); // A-B
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 500, 0, 500)); // A-C
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 500, 500, 0)); // A-D
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 500, 1000, 500)); // A-E
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 500)); // X-C
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 500, 0, 0)); // C-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 500, 0)); // Y-D
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 0, 1000, 0)); // D-W
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 500)); // W-E
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 500, 1000, 1000)); // E-Z
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 500, 1000)); // Z-B
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 1000, 0, 1000)); // B-X
        }

        /// <summary>
        /// This test basically repeats <see cref="FourEquidistantPointsInARectangleAroundMiddle"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void FourEquidistantPointsInARectangleAroundMiddle_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(800, 600), // #1
                new VoronoiSite(200, 600), // #2
                new VoronoiSite(200, 400), // #3
                new VoronoiSite(800, 400), // #4
            };

            // 1000 Y------------------------C------------------------X
            //      |                        |                        |
            //  900 |                        |                        |
            //      |                        |                        |
            //  800 |                        |                        |
            //      |                        |                        |
            //  700 |                        |                        |
            //      |                        |                        |
            //  600 |         2              |              1         |
            //      |                        |                        |
            //  500 D------------------------A------------------------B
            //      |                        |                        |
            //  400 |         3              |              4         |
            //      |                        |                        |
            //  300 |                        |                        |
            //      |                        |                        |
            //  200 |                        |                        |
            //      |                        |                        |
            //  100 |                        |                        |
            //      |                        |                        |
            //    0 W------------------------E------------------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(12, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 500, 1000, 500)); // A-B
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 500, 500, 1000)); // A-C
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 500, 0, 500)); // A-D
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 500, 500, 0)); // A-E
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 500, 1000)); // X-C
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 1000, 0, 1000)); // C-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 500)); // Y-D
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 500, 0, 0)); // D-W
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 500, 0)); // W-E
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 0, 1000, 0)); // E-Z
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 500)); // Z-B
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 500, 1000, 1000)); // B-X
        }

        [Test]
        public void FivePointsInAForkedTallCross()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 900), // #1
                new VoronoiSite(300, 700), // #2
                new VoronoiSite(300, 100), // #3
                new VoronoiSite(700, 100), // #4
                new VoronoiSite(700, 700), // #5
            };

            // 1000 W---------C#---------------------------#D---------Z
            //      |           ',                       ,'           |
            //  900 |             '·,        1        ,·'             |
            //      |                ',             ,'                |
            //  800 |                  '·,       ,·'                  |
            //      |                     ',   ,'                     |
            //  700 |              2        'B'        5              |
            //      |                        |                        |
            //  600 |                        |                        |
            //      |                        |                        |
            //  500 |                        |                        |
            //      |                        |                        |
            //  400 E------------------------A------------------------F
            //      |                        |                        |
            //  300 |                        |                        |
            //      |                        |                        |
            //  200 |                        |                        |
            //      |                        |                        |
            //  100 |              3         |         4              |
            //      |                        |                        |
            //    0 X------------------------G------------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(15, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 400, 500, 700)); // A-B
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 700, 200, 1000)); // B-C
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 700, 800, 1000)); // B-D
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 400, 0, 400)); // A-E
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 400, 1000, 400)); // A-F
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 400, 500, 0)); // A-G
            Assert.IsTrue(AnyEdgeBetween(edges, 200, 1000, 0, 1000)); // C-W
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 400)); // W-E
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 400, 0, 0)); // E-X
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 500, 0)); // X-G
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 0, 1000, 0)); // G-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 400)); // Y-F
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 400, 1000, 1000)); // F-Z
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 800, 1000)); // Z-D
            Assert.IsTrue(AnyEdgeBetween(edges, 800, 1000, 200, 1000)); // D-C
        }

        /// <summary>
        /// This test basically repeats <see cref="FivePointsInAForkedTallCross"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void FivePointsInAForkedTallCross_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(900, 500), // #1
                new VoronoiSite(700, 700), // #2
                new VoronoiSite(100, 700), // #3
                new VoronoiSite(100, 300), // #4
                new VoronoiSite(700, 300), // #5
            };

            // 1000 X-------------------E-----------------------------W
            //      |                   |                             |
            //  900 |                   |                             |
            //      |                   |                             |
            //  800 |                   |                            ,C
            //      |                   |                          ,' |
            //  700 |    3              |              2        ,·'   |
            //      |                   |                     ,'      |
            //  600 |                   |                  ,·'        |
            //      |                   |                ,'           |
            //  500 G-------------------A--------------B#        1    |
            //      |                   |                ',           |
            //  400 |                   |                  '·,        |
            //      |                   |                     ',      |
            //  300 |    4              |              5        '·,   |
            //      |                   |                          ', |
            //  200 |                   |                            'D
            //      |                   |                             |
            //  100 |                   |                             |
            //      |                   |                             |
            //    0 Y-------------------F-----------------------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(15, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 400, 500, 700, 500)); // A-B
            Assert.IsTrue(AnyEdgeBetween(edges, 700, 500, 1000, 800)); // B-C
            Assert.IsTrue(AnyEdgeBetween(edges, 700, 500, 1000, 200)); // B-D
            Assert.IsTrue(AnyEdgeBetween(edges, 400, 500, 400, 1000)); // A-E
            Assert.IsTrue(AnyEdgeBetween(edges, 400, 500, 400, 0)); // A-F
            Assert.IsTrue(AnyEdgeBetween(edges, 400, 500, 0, 500)); // A-G
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 800, 1000, 1000)); // C-W
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 400, 1000)); // W-E
            Assert.IsTrue(AnyEdgeBetween(edges, 400, 1000, 0, 1000)); // E-X
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 500)); // X-G
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 500, 0, 0)); // G-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 400, 0)); // Y-F
            Assert.IsTrue(AnyEdgeBetween(edges, 400, 0, 1000, 0)); // F-Z
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 200)); // Z-D
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 200, 1000, 800)); // D-C
        }

        /// <summary>
        /// This test basically repeats <see cref="FivePointsInAForkedTallCross"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void FivePointsInAForkedTallCross_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 100), // #1
                new VoronoiSite(700, 300), // #2
                new VoronoiSite(700, 900), // #3
                new VoronoiSite(300, 900), // #4
                new VoronoiSite(300, 300), // #5
            };

            // 1000 Y------------------------G------------------------X
            //      |                        |                        |
            //  900 |              4         |         3              |
            //      |                        |                        |
            //  800 |                        |                        |
            //      |                        |                        |
            //  700 |                        |                        |
            //      |                        |                        |
            //  600 F------------------------A------------------------E
            //      |                        |                        |
            //  500 |                        |                        |
            //      |                        |                        |
            //  400 |                        |                        |
            //      |                        |                        |
            //  300 |              5        ,B,        2              |
            //      |                     ,'   ',                     |
            //  200 |                  ,·'       '·,                  |
            //      |                ,'             ',                |
            //  100 |             ,·'        1        '·,             |
            //      |           ,'                       ',           |
            //    0 Z---------D#---------------------------#C---------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(15, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 600, 500, 300)); // A-B
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 300, 800, 0)); // B-C
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 300, 200, 0)); // B-D
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 600, 1000, 600)); // A-E
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 600, 0, 600)); // A-F
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 600, 500, 1000)); // A-G
            Assert.IsTrue(AnyEdgeBetween(edges, 800, 0, 1000, 0)); // C-W
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 600)); // W-E
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 600, 1000, 1000)); // E-X
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 500, 1000)); // X-G
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 1000, 0, 1000)); // G-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 600)); // Y-F
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 600, 0, 0)); // F-Z
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 200, 0)); // Z-D
            Assert.IsTrue(AnyEdgeBetween(edges, 200, 0, 800, 0)); // D-C
        }

        /// <summary>
        /// This test basically repeats <see cref="FivePointsInAForkedTallCross"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void FivePointsInAForkedTallCross_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(100, 500), // #1
                new VoronoiSite(300, 300), // #2
                new VoronoiSite(900, 300), // #3
                new VoronoiSite(900, 700), // #4
                new VoronoiSite(300, 700), // #5
            };

            // 1000 Z-----------------------------F-------------------Y
            //      |                             |                   |
            //  900 |                             |                   |
            //      |                             |                   |
            //  800 D,                            |                   |
            //      | ',                          |                   |
            //  700 |   '·,        5              |              4    |
            //      |      ',                     |                   |
            //  600 |        '·,                  |                   |
            //      |           ',                |                   |
            //  500 |    1        #B--------------A-------------------G
            //      |           ,'                |                   |
            //  400 |        ,·'                  |                   |
            //      |      ,'                     |                   |
            //  300 |   ,·'        2              |              3    |
            //      | ,'                          |                   |
            //  200 C'                            |                   |
            //      |                             |                   |
            //  100 |                             |                   |
            //      |                             |                   |
            //    0 W-----------------------------E-------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(15, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 600, 500, 300, 500)); // A-B
            Assert.IsTrue(AnyEdgeBetween(edges, 300, 500, 0, 200)); // B-C
            Assert.IsTrue(AnyEdgeBetween(edges, 300, 500, 0, 800)); // B-D
            Assert.IsTrue(AnyEdgeBetween(edges, 600, 500, 600, 0)); // A-E
            Assert.IsTrue(AnyEdgeBetween(edges, 600, 500, 600, 1000)); // A-F
            Assert.IsTrue(AnyEdgeBetween(edges, 600, 500, 1000, 500)); // A-G
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 200, 0, 0)); // C-W
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 600, 0)); // W-E
            Assert.IsTrue(AnyEdgeBetween(edges, 600, 0, 1000, 0)); // E-X
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 500)); // X-G
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 500, 1000, 1000)); // G-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 600, 1000)); // Y-F
            Assert.IsTrue(AnyEdgeBetween(edges, 600, 1000, 0, 1000)); // F-Z
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 800)); // Z-D
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 800, 0, 200)); // D-C
        }

        [Test]
        public void FivePointsInAForkedStubbyCross()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 700), // #1
                new VoronoiSite(300, 500), // #2
                new VoronoiSite(300, 100), // #3
                new VoronoiSite(700, 100), // #4
                new VoronoiSite(700, 500), // #5
            };

            // 1000 C#-----------------------------------------------#D
            //      | ',                                           ,' |
            //  900 |   '·,                                     ,·'   |
            //      |      ',                                 ,'      |
            //  800 |        '·,                           ,·'        |
            //      |           ',                       ,'           |
            //  700 |             '·,        1        ,·'             |
            //      |                ',             ,'                |
            //  600 |                  '·,       ,·'                  |
            //      |                     ',   ,'                     |
            //  500 |              2        'B'        5              |
            //      |                        |                        |
            //  400 |                        |                        |
            //      |                        |                        |
            //  300 E------------------------A------------------------F
            //      |                        |                        |
            //  200 |                        |                        |
            //      |                        |                        |
            //  100 |              3         |         4              |
            //      |                        |                        |
            //    0 X------------------------G------------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(13, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 300, 500, 500)); // A-B
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 500, 0, 1000)); // B-C
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 500, 1000, 1000)); // B-D
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 300, 0, 300)); // A-E
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 300, 1000, 300)); // A-F
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 300, 500, 0)); // A-G
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 300)); // C-E
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 300, 0, 0)); // E-X
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 500, 0)); // X-G
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 0, 1000, 0)); // G-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 300)); // Y-F
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 300, 1000, 1000)); // F-D
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 0, 1000)); // D-C
        }

        /// <summary>
        /// This test basically repeats <see cref="FivePointsInAForkedStubbyCross"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void FivePointsInAForkedStubbyCross_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(700, 500), // #1
                new VoronoiSite(500, 700), // #2
                new VoronoiSite(100, 700), // #3
                new VoronoiSite(100, 300), // #4
                new VoronoiSite(500, 300), // #5
            };

            // 1000 X--------------E---------------------------------#C
            //      |              |                               ,' |
            //  900 |              |                            ,·'   |
            //      |              |                          ,'      |
            //  800 |              |                       ,·'        |
            //      |              |                     ,'           |
            //  700 |    3         |         2        ,·'             |
            //      |              |                ,'                |
            //  600 |              |             ,·'                  |
            //      |              |           ,'                     |
            //  500 G--------------A---------B#        1              |
            //      |              |           ',                     |
            //  400 |              |             '·,                  |
            //      |              |                ',                |
            //  300 |    4         |         5        '·,             |
            //      |              |                     ',           |
            //  200 |              |                       '·,        |
            //      |              |                          ',      |
            //  100 |              |                            '·,   |
            //      |              |                               ', |
            //    0 Y--------------F---------------------------------#D
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(13, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 300, 500, 500, 500)); // A-B
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 500, 1000, 1000)); // B-C
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 500, 1000, 0)); // B-D
            Assert.IsTrue(AnyEdgeBetween(edges, 300, 500, 300, 1000)); // A-E
            Assert.IsTrue(AnyEdgeBetween(edges, 300, 500, 300, 0)); // A-F
            Assert.IsTrue(AnyEdgeBetween(edges, 300, 500, 0, 500)); // A-G
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 300, 1000)); // C-E
            Assert.IsTrue(AnyEdgeBetween(edges, 300, 1000, 0, 1000)); // E-X
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 500)); // X-G
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 500, 0, 0)); // G-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 300, 0)); // Y-F
            Assert.IsTrue(AnyEdgeBetween(edges, 300, 0, 1000, 0)); // F-D
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 1000)); // D-C
        }

        [Test]
        public void SixPointsInADoubleCross()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(300, 900), // #1
                new VoronoiSite(700, 900), // #2
                new VoronoiSite(300, 500), // #3
                new VoronoiSite(700, 500), // #4
                new VoronoiSite(300, 100), // #5
                new VoronoiSite(700, 100), // #6
            };

            // 1000 W------------------------H------------------------Z
            //      |                        |                        |
            //  900 |              1         |         2              |
            //      |                        |                        |
            //  800 |                        |                        |
            //      |                        |                        |
            //  700 C------------------------B------------------------G
            //      |                        |                        |
            //  600 |                        |                        |
            //      |                        |                        |
            //  500 |              3         |         4              |
            //      |                        |                        |
            //  400 |                        |                        |
            //      |                        |                        |
            //  300 D------------------------A------------------------F
            //      |                        |                        |
            //  200 |                        |                        |
            //      |                        |                        |
            //  100 |              5         |         6              |
            //      |                        |                        |
            //    0 X------------------------E------------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(17, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 300, 500, 700)); // A-B
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 700, 0, 700)); // B-C
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 700, 1000, 700)); // B-G
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 300, 0, 300)); // A-D
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 300, 1000, 300)); // A-F
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 300, 500, 0)); // A-E
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 700, 500, 1000)); // B-H
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 700)); // W-C
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 700, 0, 300)); // C-D
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 300, 0, 0)); // D-X
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 500, 0)); // X-E
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 0, 1000, 0)); // E-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 300)); // Y-F
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 300, 1000, 700)); // F-G
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 700, 1000, 1000)); // G-Z
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 500, 1000)); // Z-H
            Assert.IsTrue(AnyEdgeBetween(edges, 500, 1000, 0, 1000)); // H-W
        }

        /// <summary>
        /// This test basically repeats <see cref="SixPointsInADoubleCross"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void SixPointsInADoubleCross_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(900, 700), // #1
                new VoronoiSite(900, 300), // #2
                new VoronoiSite(500, 700), // #3
                new VoronoiSite(500, 300), // #4
                new VoronoiSite(100, 700), // #5
                new VoronoiSite(100, 300), // #6
            };

            // 1000 X--------------D-------------------C--------------W
            //      |              |                   |              |
            //  900 |              |                   |              |
            //      |              |                   |              |
            //  800 |              |                   |              |
            //      |              |                   |              |
            //  700 |    5         |         3         |         1    |
            //      |              |                   |              |
            //  600 |              |                   |              |
            //      |              |                   |              |
            //  500 E--------------A-------------------B--------------H
            //      |              |                   |              |
            //  400 |              |                   |              |
            //      |              |                   |              |
            //  300 |    6         |         4         |         2    |
            //      |              |                   |              |
            //  200 |              |                   |              |
            //      |              |                   |              |
            //  100 |              |                   |              |
            //      |              |                   |              |
            //    0 Y--------------F-------------------G--------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(17, edges.Count);
            Assert.IsTrue(AnyEdgeBetween(edges, 300, 500, 700, 500)); // A-B
            Assert.IsTrue(AnyEdgeBetween(edges, 700, 500, 700, 1000)); // B-C
            Assert.IsTrue(AnyEdgeBetween(edges, 700, 500, 700, 0)); // B-G
            Assert.IsTrue(AnyEdgeBetween(edges, 300, 500, 300, 1000)); // A-D
            Assert.IsTrue(AnyEdgeBetween(edges, 300, 500, 300, 0)); // A-F
            Assert.IsTrue(AnyEdgeBetween(edges, 300, 500, 0, 500)); // A-E
            Assert.IsTrue(AnyEdgeBetween(edges, 700, 500, 1000, 500)); // B-H
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 1000, 700, 1000)); // W-C
            Assert.IsTrue(AnyEdgeBetween(edges, 700, 1000, 300, 1000)); // C-D
            Assert.IsTrue(AnyEdgeBetween(edges, 300, 1000, 0, 1000)); // D-X
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 1000, 0, 500)); // X-E
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 500, 0, 0)); // E-Y
            Assert.IsTrue(AnyEdgeBetween(edges, 0, 0, 300, 0)); // Y-F
            Assert.IsTrue(AnyEdgeBetween(edges, 300, 0, 700, 0)); // F-G
            Assert.IsTrue(AnyEdgeBetween(edges, 700, 0, 1000, 0)); // G-Z
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 0, 1000, 500)); // Z-H
            Assert.IsTrue(AnyEdgeBetween(edges, 1000, 500, 1000, 1000)); // H-W
        }

    }
}
