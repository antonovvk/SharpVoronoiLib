using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using static SharpVoronoiLib.UnitTests.CommonTestUtilities;

namespace SharpVoronoiLib.UnitTests
{
    /// <summary>
    /// These tests assert that <see cref="VoronoiSite"/>`s have expected clockwise-sorted <see cref="VoronoiEdge"/>`s.
    /// Specifically, that the <see cref="VoronoiSite.ClockwiseCell"/> contains the expected edges in clockwise order.
    /// These tests are run with generating the border edges, i.e. <see cref="BorderEdgeGeneration.MakeBorderEdges"/>.
    /// </summary>
    /// <remarks>
    /// This is an AUTO-GENERATED test fixture class from UnitTestGenerator.
    /// This is one of the several auto-generated fixture classes each checking a different part of the algorithm's result.
    /// It contains a bunch of known Voronoi site layouts, including many edge cases.
    /// </remarks>
    [Parallelizable(ParallelScope.All)]
    [TestFixture]
    public class GeneratedTest_SiteEdgesClockwise_ClosedBorders
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(4, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 1000, 0, 0)); // #1 has X-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 0, 1000, 0)); // #1 has Y-W
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 0, 1000, 1000)); // #1 has W-Z
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 1000, 0, 1000)); // #1 has Z-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 0, 1000, 0, 0)); // #1 X-Y
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 1000, 1000, 0, 1000)); // #1 Z-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 1000, 0, 1000, 1000)); // #1 W-Z
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(3), 0, 0, 1000, 0)); // #1 Y-W
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(4, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 1000, 0, 0)); // #1 has X-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 0, 1000, 0)); // #1 has Y-W
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 0, 1000, 1000)); // #1 has W-Z
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 1000, 0, 1000)); // #1 has Z-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 1000, 1000, 0, 1000)); // #1 Z-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 1000, 0, 1000, 1000)); // #1 W-Z
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 0, 0, 1000, 0)); // #1 Y-W
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(3), 0, 1000, 0, 0)); // #1 X-Y
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(4, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 1000, 0, 1000)); // #1 has X-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 1000, 0, 0)); // #1 has Y-W
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 0, 1000, 0)); // #1 has W-Z
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 0, 1000, 1000)); // #1 has Z-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 1000, 1000, 0, 1000)); // #1 X-Y
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 1000, 0, 1000, 1000)); // #1 Z-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 0, 0, 1000, 0)); // #1 W-Z
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(3), 0, 1000, 0, 0)); // #1 Y-W
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(4, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 0, 1000, 1000)); // #1 has X-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 1000, 0, 1000)); // #1 has Y-W
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 1000, 0, 0)); // #1 has W-Z
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 0, 1000, 0)); // #1 has Z-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 0, 1000, 0, 0)); // #1 W-Z
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 1000, 1000, 0, 1000)); // #1 Y-W
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 1000, 0, 1000, 1000)); // #1 X-Y
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(3), 0, 0, 1000, 0)); // #1 Z-X
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(4, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 0, 1000, 0)); // #1 has X-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 0, 1000, 1000)); // #1 has Y-W
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 1000, 0, 1000)); // #1 has W-Z
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 1000, 0, 0)); // #1 has Z-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 0, 1000, 0, 0)); // #1 Z-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 1000, 1000, 0, 1000)); // #1 W-Z
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 1000, 0, 1000, 1000)); // #1 Y-W
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(3), 0, 0, 1000, 0)); // #1 X-Y
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(4, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 1000, 0, 0)); // #1 has X-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 0, 1000, 0)); // #1 has Y-W
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 0, 1000, 1000)); // #1 has W-Z
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 1000, 0, 1000)); // #1 has Z-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 1000, 1000, 0, 1000)); // #1 Z-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 1000, 0, 1000, 1000)); // #1 W-Z
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 0, 0, 1000, 0)); // #1 Y-W
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(3), 0, 1000, 0, 0)); // #1 X-Y
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(4, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 1000, 0, 1000)); // #1 has X-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 1000, 0, 0)); // #1 has Y-W
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 0, 1000, 0)); // #1 has W-Z
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 0, 1000, 1000)); // #1 has Z-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 1000, 1000, 0, 1000)); // #1 X-Y
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 1000, 0, 1000, 1000)); // #1 Z-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 0, 0, 1000, 0)); // #1 W-Z
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(3), 0, 1000, 0, 0)); // #1 Y-W
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(4, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 0, 1000, 1000)); // #1 has X-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 1000, 0, 1000)); // #1 has Y-W
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 1000, 0, 0)); // #1 has W-Z
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 0, 1000, 0)); // #1 has Z-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 0, 1000, 0, 0)); // #1 W-Z
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 1000, 1000, 0, 1000)); // #1 Y-W
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 1000, 0, 1000, 1000)); // #1 X-Y
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(3), 0, 0, 1000, 0)); // #1 Z-X
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(4, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 0, 1000, 0)); // #1 has X-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 0, 1000, 1000)); // #1 has Y-W
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 1000, 0, 1000)); // #1 has W-Z
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 1000, 0, 0)); // #1 has Z-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 0, 1000, 0, 0)); // #1 Z-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 1000, 1000, 0, 1000)); // #1 W-Z
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 1000, 0, 1000, 1000)); // #1 Y-W
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(3), 0, 0, 1000, 0)); // #1 X-Y
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(4, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 1000, 0, 0)); // #1 has X-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 0, 1000, 0)); // #1 has Y-W
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 0, 1000, 1000)); // #1 has W-Z
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 1000, 0, 1000)); // #1 has Z-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 1000, 1000, 0, 1000)); // #1 Z-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 1000, 0, 1000, 1000)); // #1 W-Z
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 0, 0, 1000, 0)); // #1 Y-W
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(3), 0, 1000, 0, 0)); // #1 X-Y
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(4, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 1000, 0, 1000)); // #1 has X-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 1000, 0, 0)); // #1 has Y-W
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 0, 1000, 0)); // #1 has W-Z
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 0, 1000, 1000)); // #1 has Z-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 1000, 1000, 0, 1000)); // #1 X-Y
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 1000, 0, 1000, 1000)); // #1 Z-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 0, 0, 1000, 0)); // #1 W-Z
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(3), 0, 1000, 0, 0)); // #1 Y-W
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(4, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 0, 1000, 1000)); // #1 has X-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 1000, 0, 1000)); // #1 has Y-W
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 1000, 0, 0)); // #1 has W-Z
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 0, 1000, 0)); // #1 has Z-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 0, 1000, 0, 0)); // #1 W-Z
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 1000, 1000, 0, 1000)); // #1 Y-W
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 1000, 0, 1000, 1000)); // #1 X-Y
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(3), 0, 0, 1000, 0)); // #1 Z-X
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(4, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 0, 1000, 0)); // #1 has X-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 0, 1000, 1000)); // #1 has Y-W
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 1000, 0, 1000)); // #1 has W-Z
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 1000, 0, 0)); // #1 has Z-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 0, 1000, 0, 0)); // #1 Z-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 1000, 1000, 0, 1000)); // #1 W-Z
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 1000, 0, 1000, 1000)); // #1 Y-W
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(3), 0, 0, 1000, 0)); // #1 X-Y
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(4, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 1000, 0, 0)); // #1 has X-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 0, 1000, 0)); // #1 has Y-W
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 0, 1000, 1000)); // #1 has W-Z
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 1000, 0, 1000)); // #1 has Z-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 1000, 1000, 0, 1000)); // #1 Z-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 1000, 0, 1000, 1000)); // #1 W-Z
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 0, 0, 1000, 0)); // #1 Y-W
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(3), 0, 1000, 0, 0)); // #1 X-Y
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(4, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 1000, 0, 1000)); // #1 has X-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 1000, 0, 0)); // #1 has Y-W
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 0, 1000, 0)); // #1 has W-Z
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 0, 1000, 1000)); // #1 has Z-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 1000, 1000, 0, 1000)); // #1 X-Y
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 1000, 0, 1000, 1000)); // #1 Z-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 0, 0, 1000, 0)); // #1 W-Z
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(3), 0, 1000, 0, 0)); // #1 Y-W
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(4, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 0, 1000, 1000)); // #1 has X-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 1000, 0, 1000)); // #1 has Y-W
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 1000, 0, 0)); // #1 has W-Z
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 0, 1000, 0)); // #1 has Z-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 0, 1000, 0, 0)); // #1 W-Z
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 1000, 1000, 0, 1000)); // #1 Y-W
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 1000, 0, 1000, 1000)); // #1 X-Y
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(3), 0, 0, 1000, 0)); // #1 Z-X
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(4, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 0, 1000, 0)); // #1 has X-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 0, 1000, 1000)); // #1 has Y-W
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 1000, 0, 1000)); // #1 has W-Z
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 1000, 0, 0)); // #1 has Z-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 0, 1000, 0, 0)); // #1 Z-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 1000, 1000, 0, 1000)); // #1 W-Z
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 1000, 0, 1000, 1000)); // #1 Y-W
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(3), 0, 0, 1000, 0)); // #1 X-Y
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(4, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 1000, 0, 0)); // #1 has X-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 0, 1000, 0)); // #1 has Y-W
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 0, 1000, 1000)); // #1 has W-Z
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 1000, 0, 1000)); // #1 has Z-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 0, 1000, 0, 0)); // #1 X-Y
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 1000, 1000, 0, 1000)); // #1 Z-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 1000, 0, 1000, 1000)); // #1 W-Z
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(3), 0, 0, 1000, 0)); // #1 Y-W
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(4, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 1000, 0, 1000)); // #1 has X-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 1000, 0, 0)); // #1 has Y-W
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 0, 1000, 0)); // #1 has W-Z
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 0, 1000, 1000)); // #1 has Z-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 1000, 1000, 0, 1000)); // #1 X-Y
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 1000, 0, 1000, 1000)); // #1 Z-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 0, 0, 1000, 0)); // #1 W-Z
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(3), 0, 1000, 0, 0)); // #1 Y-W
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(4, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 0, 1000, 1000)); // #1 has X-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 1000, 0, 1000)); // #1 has Y-W
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 1000, 0, 0)); // #1 has W-Z
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 0, 1000, 0)); // #1 has Z-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 0, 1000, 0, 0)); // #1 W-Z
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 1000, 1000, 0, 1000)); // #1 Y-W
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 1000, 0, 1000, 1000)); // #1 X-Y
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(3), 0, 0, 1000, 0)); // #1 Z-X
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(4, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 0, 1000, 0)); // #1 has X-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 0, 1000, 1000)); // #1 has Y-W
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 1000, 0, 1000)); // #1 has W-Z
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 1000, 0, 0)); // #1 has Z-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 0, 1000, 0, 0)); // #1 Z-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 1000, 1000, 0, 1000)); // #1 W-Z
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 1000, 0, 1000, 1000)); // #1 Y-W
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(3), 0, 0, 1000, 0)); // #1 X-Y
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(4, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 500, 1000, 500)); // #1 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 1000, 0, 500)); // #1 has X-A
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 500, 1000, 1000)); // #1 has B-Z
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 1000, 0, 1000)); // #1 has Z-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 0, 1000, 0, 500)); // #1 X-A
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 1000, 1000, 0, 1000)); // #1 Z-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 1000, 500, 1000, 1000)); // #1 B-Z
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(3), 0, 500, 1000, 500)); // #1 A-B
            Assert.AreEqual(4, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 0, 500, 1000, 500)); // #2 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 0, 500, 0, 0)); // #2 has A-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 0, 0, 1000, 0)); // #2 has Y-W
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 1000, 0, 1000, 500)); // #2 has W-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 0, 500, 0, 0)); // #2 A-Y
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 0, 500, 1000, 500)); // #2 A-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(2), 1000, 0, 1000, 500)); // #2 W-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(3), 0, 0, 1000, 0)); // #2 Y-W
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(4, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 500, 1000, 500, 0)); // #1 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 1000, 500, 1000)); // #1 has X-A
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 500, 0, 1000, 0)); // #1 has B-Z
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 0, 1000, 1000)); // #1 has Z-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 1000, 1000, 500, 1000)); // #1 X-A
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 1000, 0, 1000, 1000)); // #1 Z-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 500, 0, 1000, 0)); // #1 B-Z
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(3), 500, 1000, 500, 0)); // #1 A-B
            Assert.AreEqual(4, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 500, 1000, 500, 0)); // #2 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 500, 1000, 0, 1000)); // #2 has A-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 0, 1000, 0, 0)); // #2 has Y-W
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 0, 0, 500, 0)); // #2 has W-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 500, 1000, 0, 1000)); // #2 A-Y
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 500, 1000, 500, 0)); // #2 A-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(2), 0, 0, 500, 0)); // #2 W-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(3), 0, 1000, 0, 0)); // #2 Y-W
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(4, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 700, 1000, 700)); // #1 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 1000, 0, 700)); // #1 has X-A
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 700, 1000, 1000)); // #1 has B-Z
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 1000, 0, 1000)); // #1 has Z-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 0, 1000, 0, 700)); // #1 X-A
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 1000, 1000, 0, 1000)); // #1 Z-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 1000, 700, 1000, 1000)); // #1 B-Z
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(3), 0, 700, 1000, 700)); // #1 A-B
            Assert.AreEqual(4, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 0, 700, 1000, 700)); // #2 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 0, 700, 0, 0)); // #2 has A-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 0, 0, 1000, 0)); // #2 has Y-W
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 1000, 0, 1000, 700)); // #2 has W-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 0, 700, 0, 0)); // #2 A-Y
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 0, 700, 1000, 700)); // #2 A-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(2), 1000, 0, 1000, 700)); // #2 W-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(3), 0, 0, 1000, 0)); // #2 Y-W
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(4, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 700, 1000, 700, 0)); // #1 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 1000, 700, 1000)); // #1 has X-A
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 700, 0, 1000, 0)); // #1 has B-Z
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 0, 1000, 1000)); // #1 has Z-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 1000, 1000, 700, 1000)); // #1 X-A
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 1000, 0, 1000, 1000)); // #1 Z-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 700, 0, 1000, 0)); // #1 B-Z
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(3), 700, 1000, 700, 0)); // #1 A-B
            Assert.AreEqual(4, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 700, 1000, 700, 0)); // #2 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 700, 1000, 0, 1000)); // #2 has A-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 0, 1000, 0, 0)); // #2 has Y-W
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 0, 0, 700, 0)); // #2 has W-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 0, 1000, 0, 0)); // #2 Y-W
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 700, 1000, 0, 1000)); // #2 A-Y
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(2), 700, 1000, 700, 0)); // #2 A-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(3), 0, 0, 700, 0)); // #2 W-B
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(4, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 700, 1000, 700)); // #1 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 1000, 0, 700)); // #1 has X-A
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 700, 1000, 1000)); // #1 has B-Z
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 1000, 0, 1000)); // #1 has Z-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 0, 1000, 0, 700)); // #1 X-A
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 1000, 1000, 0, 1000)); // #1 Z-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 1000, 700, 1000, 1000)); // #1 B-Z
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(3), 0, 700, 1000, 700)); // #1 A-B
            Assert.AreEqual(4, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 0, 700, 1000, 700)); // #2 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 0, 300, 1000, 300)); // #2 has C-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 0, 700, 0, 300)); // #2 has A-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 1000, 300, 1000, 700)); // #2 has D-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 0, 700, 0, 300)); // #2 A-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 0, 700, 1000, 700)); // #2 A-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(2), 1000, 300, 1000, 700)); // #2 D-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(3), 0, 300, 1000, 300)); // #2 C-D
            Assert.AreEqual(4, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 0, 300, 1000, 300)); // #3 has C-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 0, 300, 0, 0)); // #3 has C-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 0, 0, 1000, 0)); // #3 has Y-W
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 1000, 0, 1000, 300)); // #3 has W-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 0, 300, 0, 0)); // #3 C-Y
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 0, 300, 1000, 300)); // #3 C-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(2), 1000, 0, 1000, 300)); // #3 W-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(3), 0, 0, 1000, 0)); // #3 Y-W
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(4, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 700, 1000, 700, 0)); // #1 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 1000, 700, 1000)); // #1 has X-A
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 700, 0, 1000, 0)); // #1 has B-Z
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 0, 1000, 1000)); // #1 has Z-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 1000, 1000, 700, 1000)); // #1 X-A
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 1000, 0, 1000, 1000)); // #1 Z-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 700, 0, 1000, 0)); // #1 B-Z
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(3), 700, 1000, 700, 0)); // #1 A-B
            Assert.AreEqual(4, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 700, 1000, 700, 0)); // #2 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 300, 1000, 300, 0)); // #2 has C-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 700, 1000, 300, 1000)); // #2 has A-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 300, 0, 700, 0)); // #2 has D-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 700, 1000, 300, 1000)); // #2 A-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 700, 1000, 700, 0)); // #2 A-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(2), 300, 0, 700, 0)); // #2 D-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(3), 300, 1000, 300, 0)); // #2 C-D
            Assert.AreEqual(4, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 300, 1000, 300, 0)); // #3 has C-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 300, 1000, 0, 1000)); // #3 has C-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 0, 1000, 0, 0)); // #3 has Y-W
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 0, 0, 300, 0)); // #3 has W-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 300, 1000, 0, 1000)); // #3 C-Y
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 300, 1000, 300, 0)); // #3 C-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(2), 0, 0, 300, 0)); // #3 W-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(3), 0, 1000, 0, 0)); // #3 Y-W
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(4, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 700, 1000, 700)); // #1 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 1000, 0, 700)); // #1 has X-A
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 700, 1000, 1000)); // #1 has B-Z
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 1000, 0, 1000)); // #1 has Z-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 0, 1000, 0, 700)); // #1 X-A
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 1000, 1000, 0, 1000)); // #1 Z-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 1000, 700, 1000, 1000)); // #1 B-Z
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(3), 0, 700, 1000, 700)); // #1 A-B
            Assert.AreEqual(4, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 0, 700, 1000, 700)); // #2 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 0, 500, 1000, 500)); // #2 has C-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 0, 700, 0, 500)); // #2 has A-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 1000, 500, 1000, 700)); // #2 has D-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 0, 700, 0, 500)); // #2 A-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 0, 700, 1000, 700)); // #2 A-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(2), 1000, 500, 1000, 700)); // #2 D-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(3), 0, 500, 1000, 500)); // #2 C-D
            Assert.AreEqual(4, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 0, 500, 1000, 500)); // #3 has C-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 0, 300, 1000, 300)); // #3 has E-F
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 0, 500, 0, 300)); // #3 has C-E
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 1000, 300, 1000, 500)); // #3 has F-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 0, 500, 0, 300)); // #3 C-E
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 0, 500, 1000, 500)); // #3 C-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(2), 1000, 300, 1000, 500)); // #3 F-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(3), 0, 300, 1000, 300)); // #3 E-F
            Assert.AreEqual(4, sites[3].ClockwiseCell.Count()); // #4
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 0, 300, 1000, 300)); // #4 has E-F
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 0, 300, 0, 0)); // #4 has E-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 0, 0, 1000, 0)); // #4 has Y-W
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 1000, 0, 1000, 300)); // #4 has W-F
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(0), 0, 300, 0, 0)); // #4 E-Y
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(1), 0, 300, 1000, 300)); // #4 E-F
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(2), 1000, 0, 1000, 300)); // #4 W-F
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(3), 0, 0, 1000, 0)); // #4 Y-W
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(4, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 700, 1000, 700, 0)); // #1 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 1000, 700, 1000)); // #1 has X-A
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 700, 0, 1000, 0)); // #1 has B-Z
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 0, 1000, 1000)); // #1 has Z-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 1000, 1000, 700, 1000)); // #1 X-A
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 1000, 0, 1000, 1000)); // #1 Z-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 700, 0, 1000, 0)); // #1 B-Z
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(3), 700, 1000, 700, 0)); // #1 A-B
            Assert.AreEqual(4, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 700, 1000, 700, 0)); // #2 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 500, 1000, 500, 0)); // #2 has C-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 700, 1000, 500, 1000)); // #2 has A-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 500, 0, 700, 0)); // #2 has D-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 700, 1000, 500, 1000)); // #2 A-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 700, 1000, 700, 0)); // #2 A-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(2), 500, 0, 700, 0)); // #2 D-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(3), 500, 1000, 500, 0)); // #2 C-D
            Assert.AreEqual(4, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 500, 1000, 500, 0)); // #3 has C-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 300, 1000, 300, 0)); // #3 has E-F
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 500, 1000, 300, 1000)); // #3 has C-E
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 300, 0, 500, 0)); // #3 has F-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 500, 1000, 300, 1000)); // #3 C-E
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 500, 1000, 500, 0)); // #3 C-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(2), 300, 0, 500, 0)); // #3 F-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(3), 300, 1000, 300, 0)); // #3 E-F
            Assert.AreEqual(4, sites[3].ClockwiseCell.Count()); // #4
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 300, 1000, 300, 0)); // #4 has E-F
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 300, 1000, 0, 1000)); // #4 has E-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 0, 1000, 0, 0)); // #4 has Y-W
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 0, 0, 300, 0)); // #4 has W-F
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(0), 300, 1000, 0, 1000)); // #4 E-Y
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(1), 300, 1000, 300, 0)); // #4 E-F
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(2), 0, 0, 300, 0)); // #4 W-F
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(3), 0, 1000, 0, 0)); // #4 Y-W
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(3, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 0, 1000, 1000)); // #1 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 1000, 0, 0)); // #1 has X-A
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 1000, 0, 1000)); // #1 has B-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 1000, 1000, 0, 1000)); // #1 B-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 0, 0, 1000, 1000)); // #1 A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 0, 1000, 0, 0)); // #1 X-A
            Assert.AreEqual(3, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 0, 0, 1000, 1000)); // #2 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 0, 0, 1000, 0)); // #2 has A-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 1000, 0, 1000, 1000)); // #2 has Y-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 0, 0, 1000, 1000)); // #2 A-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 1000, 0, 1000, 1000)); // #2 Y-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(2), 0, 0, 1000, 0)); // #2 A-Y
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(3, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 1000, 1000, 0)); // #1 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 1000, 0, 1000)); // #1 has X-A
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 0, 1000, 1000)); // #1 has B-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 1000, 1000, 0, 1000)); // #1 X-A
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 1000, 0, 1000, 1000)); // #1 B-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 0, 1000, 1000, 0)); // #1 A-B
            Assert.AreEqual(3, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 0, 1000, 1000, 0)); // #2 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 0, 1000, 0, 0)); // #2 has A-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 0, 0, 1000, 0)); // #2 has Y-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 0, 1000, 0, 0)); // #2 A-Y
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 0, 1000, 1000, 0)); // #2 A-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(2), 0, 0, 1000, 0)); // #2 Y-B
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(3, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 200, 800, 1000)); // #1 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 1000, 0, 200)); // #1 has X-A
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 800, 1000, 0, 1000)); // #1 has B-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 800, 1000, 0, 1000)); // #1 B-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 0, 200, 800, 1000)); // #1 A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 0, 1000, 0, 200)); // #1 X-A
            Assert.AreEqual(5, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 0, 200, 800, 1000)); // #2 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 0, 200, 0, 0)); // #2 has A-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 0, 0, 1000, 0)); // #2 has Y-W
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 1000, 0, 1000, 1000)); // #2 has W-Z
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 1000, 1000, 800, 1000)); // #2 has Z-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 0, 200, 0, 0)); // #2 A-Y
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 0, 200, 800, 1000)); // #2 A-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(2), 1000, 1000, 800, 1000)); // #2 Z-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(3), 1000, 0, 1000, 1000)); // #2 W-Z
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(4), 0, 0, 1000, 0)); // #2 Y-W
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(3, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 200, 1000, 1000, 200)); // #1 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 1000, 200, 1000)); // #1 has X-A
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 200, 1000, 1000)); // #1 has B-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 1000, 1000, 200, 1000)); // #1 X-A
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 1000, 200, 1000, 1000)); // #1 B-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 200, 1000, 1000, 200)); // #1 A-B
            Assert.AreEqual(5, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 200, 1000, 1000, 200)); // #2 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 200, 1000, 0, 1000)); // #2 has A-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 0, 1000, 0, 0)); // #2 has Y-W
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 0, 0, 1000, 0)); // #2 has W-Z
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 1000, 0, 1000, 200)); // #2 has Z-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 0, 1000, 0, 0)); // #2 Y-W
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 200, 1000, 0, 1000)); // #2 A-Y
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(2), 200, 1000, 1000, 200)); // #2 A-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(3), 1000, 0, 1000, 200)); // #2 Z-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(4), 0, 0, 1000, 0)); // #2 W-Z
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(3, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 800, 200, 0)); // #1 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 0, 1000, 800)); // #1 has X-A
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 200, 0, 1000, 0)); // #1 has B-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 1000, 800, 200, 0)); // #1 A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 1000, 0, 1000, 800)); // #1 X-A
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 200, 0, 1000, 0)); // #1 B-X
            Assert.AreEqual(5, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 1000, 800, 200, 0)); // #2 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 1000, 800, 1000, 1000)); // #2 has A-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 1000, 1000, 0, 1000)); // #2 has Y-W
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 0, 1000, 0, 0)); // #2 has W-Z
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 0, 0, 200, 0)); // #2 has Z-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 1000, 1000, 0, 1000)); // #2 Y-W
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 1000, 800, 1000, 1000)); // #2 A-Y
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(2), 1000, 800, 200, 0)); // #2 A-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(3), 0, 0, 200, 0)); // #2 Z-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(4), 0, 1000, 0, 0)); // #2 W-Z
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(3, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 800, 0, 0, 800)); // #1 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 0, 800, 0)); // #1 has X-A
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 800, 0, 0)); // #1 has B-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 0, 800, 0, 0)); // #1 B-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 800, 0, 0, 800)); // #1 A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 0, 0, 800, 0)); // #1 X-A
            Assert.AreEqual(5, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 800, 0, 0, 800)); // #2 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 800, 0, 1000, 0)); // #2 has A-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 1000, 0, 1000, 1000)); // #2 has Y-W
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 1000, 1000, 0, 1000)); // #2 has W-Z
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 0, 1000, 0, 800)); // #2 has Z-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 0, 1000, 0, 800)); // #2 Z-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 1000, 1000, 0, 1000)); // #2 W-Z
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(2), 1000, 0, 1000, 1000)); // #2 Y-W
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(3), 800, 0, 1000, 0)); // #2 A-Y
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(4), 800, 0, 0, 800)); // #2 A-B
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(3, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 300, 700, 1000)); // #1 has A-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 1000, 0, 300)); // #1 has X-A
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 700, 1000, 0, 1000)); // #1 has D-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 700, 1000, 0, 1000)); // #1 D-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 0, 300, 700, 1000)); // #1 A-D
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 0, 1000, 0, 300)); // #1 X-A
            Assert.AreEqual(6, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 0, 300, 700, 1000)); // #2 has A-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 300, 0, 1000, 700)); // #2 has B-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 0, 300, 0, 0)); // #2 has A-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 0, 0, 300, 0)); // #2 has Y-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 1000, 700, 1000, 1000)); // #2 has C-Z
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 1000, 1000, 700, 1000)); // #2 has Z-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 0, 300, 0, 0)); // #2 A-Y
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 0, 300, 700, 1000)); // #2 A-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(2), 1000, 1000, 700, 1000)); // #2 Z-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(3), 1000, 700, 1000, 1000)); // #2 C-Z
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(4), 300, 0, 1000, 700)); // #2 B-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(5), 0, 0, 300, 0)); // #2 Y-B
            Assert.AreEqual(3, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 300, 0, 1000, 700)); // #3 has B-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 300, 0, 1000, 0)); // #3 has B-W
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 1000, 0, 1000, 700)); // #3 has W-C
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 300, 0, 1000, 700)); // #3 B-C
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 1000, 0, 1000, 700)); // #3 W-C
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(2), 300, 0, 1000, 0)); // #3 B-W
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(3, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 300, 1000, 1000, 300)); // #1 has A-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 1000, 300, 1000)); // #1 has X-A
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 300, 1000, 1000)); // #1 has D-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 1000, 1000, 300, 1000)); // #1 X-A
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 1000, 300, 1000, 1000)); // #1 D-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 300, 1000, 1000, 300)); // #1 A-D
            Assert.AreEqual(6, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 300, 1000, 1000, 300)); // #2 has A-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 0, 700, 700, 0)); // #2 has B-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 300, 1000, 0, 1000)); // #2 has A-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 0, 1000, 0, 700)); // #2 has Y-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 700, 0, 1000, 0)); // #2 has C-Z
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 1000, 0, 1000, 300)); // #2 has Z-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 0, 1000, 0, 700)); // #2 Y-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 300, 1000, 0, 1000)); // #2 A-Y
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(2), 300, 1000, 1000, 300)); // #2 A-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(3), 1000, 0, 1000, 300)); // #2 Z-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(4), 700, 0, 1000, 0)); // #2 C-Z
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(5), 0, 700, 700, 0)); // #2 B-C
            Assert.AreEqual(3, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 0, 700, 700, 0)); // #3 has B-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 0, 700, 0, 0)); // #3 has B-W
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 0, 0, 700, 0)); // #3 has W-C
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 0, 700, 0, 0)); // #3 B-W
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 0, 700, 700, 0)); // #3 B-C
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(2), 0, 0, 700, 0)); // #3 W-C
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(3, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 400, 600, 1000)); // #1 has A-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 1000, 0, 400)); // #1 has X-A
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 600, 1000, 0, 1000)); // #1 has D-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 600, 1000, 0, 1000)); // #1 D-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 0, 400, 600, 1000)); // #1 A-D
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 0, 1000, 0, 400)); // #1 X-A
            Assert.AreEqual(4, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 0, 400, 600, 1000)); // #2 has A-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 0, 0, 1000, 1000)); // #2 has B-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 0, 400, 0, 0)); // #2 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 1000, 1000, 600, 1000)); // #2 has C-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 0, 400, 600, 1000)); // #2 A-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 1000, 1000, 600, 1000)); // #2 C-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(2), 0, 0, 1000, 1000)); // #2 B-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(3), 0, 400, 0, 0)); // #2 A-B
            Assert.AreEqual(3, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 0, 0, 1000, 1000)); // #3 has B-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 0, 0, 1000, 0)); // #3 has B-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 1000, 0, 1000, 1000)); // #3 has Y-C
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 0, 0, 1000, 1000)); // #3 B-C
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 1000, 0, 1000, 1000)); // #3 Y-C
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(2), 0, 0, 1000, 0)); // #3 B-Y
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(3, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 400, 1000, 1000, 400)); // #1 has A-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 1000, 400, 1000)); // #1 has X-A
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 400, 1000, 1000)); // #1 has D-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 1000, 1000, 400, 1000)); // #1 X-A
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 1000, 400, 1000, 1000)); // #1 D-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 400, 1000, 1000, 400)); // #1 A-D
            Assert.AreEqual(4, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 400, 1000, 1000, 400)); // #2 has A-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 0, 1000, 1000, 0)); // #2 has B-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 400, 1000, 0, 1000)); // #2 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 1000, 0, 1000, 400)); // #2 has C-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 400, 1000, 0, 1000)); // #2 A-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 400, 1000, 1000, 400)); // #2 A-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(2), 1000, 0, 1000, 400)); // #2 C-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(3), 0, 1000, 1000, 0)); // #2 B-C
            Assert.AreEqual(3, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 0, 1000, 1000, 0)); // #3 has B-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 0, 1000, 0, 0)); // #3 has B-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 0, 0, 1000, 0)); // #3 has Y-C
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 0, 1000, 0, 0)); // #3 B-Y
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 0, 1000, 1000, 0)); // #3 B-C
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(2), 0, 0, 1000, 0)); // #3 Y-C
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(3, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 600, 400, 0)); // #1 has A-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 0, 1000, 600)); // #1 has X-A
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 400, 0, 1000, 0)); // #1 has D-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 1000, 600, 400, 0)); // #1 A-D
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 1000, 0, 1000, 600)); // #1 X-A
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 400, 0, 1000, 0)); // #1 D-X
            Assert.AreEqual(4, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 1000, 600, 400, 0)); // #2 has A-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 1000, 1000, 0, 0)); // #2 has B-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 1000, 600, 1000, 1000)); // #2 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 0, 0, 400, 0)); // #2 has C-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 1000, 1000, 0, 0)); // #2 B-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 1000, 600, 1000, 1000)); // #2 A-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(2), 1000, 600, 400, 0)); // #2 A-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(3), 0, 0, 400, 0)); // #2 C-D
            Assert.AreEqual(3, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 1000, 1000, 0, 0)); // #3 has B-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 1000, 1000, 0, 1000)); // #3 has B-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 0, 1000, 0, 0)); // #3 has Y-C
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 1000, 1000, 0, 1000)); // #3 B-Y
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 1000, 1000, 0, 0)); // #3 B-C
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(2), 0, 1000, 0, 0)); // #3 Y-C
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(3, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 600, 0, 0, 600)); // #1 has A-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 0, 600, 0)); // #1 has X-A
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 600, 0, 0)); // #1 has D-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 0, 600, 0, 0)); // #1 D-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 600, 0, 0, 600)); // #1 A-D
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 0, 0, 600, 0)); // #1 X-A
            Assert.AreEqual(4, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 600, 0, 0, 600)); // #2 has A-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 1000, 0, 0, 1000)); // #2 has B-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 600, 0, 1000, 0)); // #2 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 0, 1000, 0, 600)); // #2 has C-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 0, 1000, 0, 600)); // #2 C-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 1000, 0, 0, 1000)); // #2 B-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(2), 600, 0, 1000, 0)); // #2 A-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(3), 600, 0, 0, 600)); // #2 A-D
            Assert.AreEqual(3, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 1000, 0, 0, 1000)); // #3 has B-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 1000, 0, 1000, 1000)); // #3 has B-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 1000, 1000, 0, 1000)); // #3 has Y-C
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 1000, 1000, 0, 1000)); // #3 Y-C
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 1000, 0, 1000, 1000)); // #3 B-Y
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(2), 1000, 0, 0, 1000)); // #3 B-C
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(3, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 400, 600, 1000)); // #1 has A-F
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 1000, 0, 400)); // #1 has X-A
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 600, 1000, 0, 1000)); // #1 has F-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 600, 1000, 0, 1000)); // #1 F-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 0, 400, 600, 1000)); // #1 A-F
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 0, 1000, 0, 400)); // #1 X-A
            Assert.AreEqual(4, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 0, 400, 600, 1000)); // #2 has A-F
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 0, 0, 1000, 1000)); // #2 has B-E
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 0, 400, 0, 0)); // #2 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 1000, 1000, 600, 1000)); // #2 has E-F
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 0, 400, 600, 1000)); // #2 A-F
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 1000, 1000, 600, 1000)); // #2 E-F
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(2), 0, 0, 1000, 1000)); // #2 B-E
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(3), 0, 400, 0, 0)); // #2 A-B
            Assert.AreEqual(4, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 0, 0, 1000, 1000)); // #3 has B-E
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 400, 0, 1000, 600)); // #3 has C-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 0, 0, 400, 0)); // #3 has B-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 1000, 600, 1000, 1000)); // #3 has D-E
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 0, 0, 1000, 1000)); // #3 B-E
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 1000, 600, 1000, 1000)); // #3 D-E
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(2), 400, 0, 1000, 600)); // #3 C-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(3), 0, 0, 400, 0)); // #3 B-C
            Assert.AreEqual(3, sites[3].ClockwiseCell.Count()); // #4
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 400, 0, 1000, 600)); // #4 has C-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 400, 0, 1000, 0)); // #4 has C-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 1000, 0, 1000, 600)); // #4 has Y-D
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(0), 400, 0, 1000, 600)); // #4 C-D
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(1), 1000, 0, 1000, 600)); // #4 Y-D
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(2), 400, 0, 1000, 0)); // #4 C-Y
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(3, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 400, 1000, 1000, 400)); // #1 has A-F
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 1000, 400, 1000)); // #1 has X-A
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 400, 1000, 1000)); // #1 has F-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 1000, 1000, 400, 1000)); // #1 X-A
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 1000, 400, 1000, 1000)); // #1 F-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 400, 1000, 1000, 400)); // #1 A-F
            Assert.AreEqual(4, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 400, 1000, 1000, 400)); // #2 has A-F
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 0, 1000, 1000, 0)); // #2 has B-E
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 400, 1000, 0, 1000)); // #2 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 1000, 0, 1000, 400)); // #2 has E-F
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 400, 1000, 0, 1000)); // #2 A-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 400, 1000, 1000, 400)); // #2 A-F
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(2), 1000, 0, 1000, 400)); // #2 E-F
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(3), 0, 1000, 1000, 0)); // #2 B-E
            Assert.AreEqual(4, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 0, 1000, 1000, 0)); // #3 has B-E
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 0, 600, 600, 0)); // #3 has C-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 0, 1000, 0, 600)); // #3 has B-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 600, 0, 1000, 0)); // #3 has D-E
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 0, 1000, 0, 600)); // #3 B-C
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 0, 1000, 1000, 0)); // #3 B-E
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(2), 600, 0, 1000, 0)); // #3 D-E
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(3), 0, 600, 600, 0)); // #3 C-D
            Assert.AreEqual(3, sites[3].ClockwiseCell.Count()); // #4
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 0, 600, 600, 0)); // #4 has C-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 0, 600, 0, 0)); // #4 has C-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 0, 0, 600, 0)); // #4 has Y-D
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(0), 0, 600, 0, 0)); // #4 C-Y
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(1), 0, 600, 600, 0)); // #4 C-D
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(2), 0, 0, 600, 0)); // #4 Y-D
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(4, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 400, 400, 0, 400)); // #1 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 400, 400, 1000, 1000)); // #1 has A-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 1000, 0, 400)); // #1 has X-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 1000, 0, 1000)); // #1 has D-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 0, 1000, 0, 400)); // #1 X-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 1000, 1000, 0, 1000)); // #1 D-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 400, 400, 1000, 1000)); // #1 A-D
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(3), 400, 400, 0, 400)); // #1 A-B
            Assert.AreEqual(4, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 400, 400, 0, 400)); // #2 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 400, 400, 400, 0)); // #2 has A-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 0, 400, 0, 0)); // #2 has B-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 0, 0, 400, 0)); // #2 has Y-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 0, 400, 0, 0)); // #2 B-Y
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 400, 400, 0, 400)); // #2 A-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(2), 400, 400, 400, 0)); // #2 A-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(3), 0, 0, 400, 0)); // #2 Y-C
            Assert.AreEqual(4, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 400, 400, 400, 0)); // #3 has A-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 400, 400, 1000, 1000)); // #3 has A-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 400, 0, 1000, 0)); // #3 has C-W
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 1000, 0, 1000, 1000)); // #3 has W-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 400, 400, 1000, 1000)); // #3 A-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 1000, 0, 1000, 1000)); // #3 W-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(2), 400, 0, 1000, 0)); // #3 C-W
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(3), 400, 400, 400, 0)); // #3 A-C
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(4, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 400, 600, 400, 1000)); // #1 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 400, 600, 1000, 0)); // #1 has A-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 1000, 400, 1000)); // #1 has X-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 0, 1000, 1000)); // #1 has D-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 400, 600, 400, 1000)); // #1 A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 1000, 1000, 400, 1000)); // #1 X-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 1000, 0, 1000, 1000)); // #1 D-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(3), 400, 600, 1000, 0)); // #1 A-D
            Assert.AreEqual(4, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 400, 600, 400, 1000)); // #2 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 400, 600, 0, 600)); // #2 has A-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 400, 1000, 0, 1000)); // #2 has B-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 0, 1000, 0, 600)); // #2 has Y-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 0, 1000, 0, 600)); // #2 Y-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 400, 1000, 0, 1000)); // #2 B-Y
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(2), 400, 600, 400, 1000)); // #2 A-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(3), 400, 600, 0, 600)); // #2 A-C
            Assert.AreEqual(4, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 400, 600, 0, 600)); // #3 has A-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 400, 600, 1000, 0)); // #3 has A-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 0, 600, 0, 0)); // #3 has C-W
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 0, 0, 1000, 0)); // #3 has W-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 400, 600, 0, 600)); // #3 A-C
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 400, 600, 1000, 0)); // #3 A-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(2), 0, 0, 1000, 0)); // #3 W-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(3), 0, 600, 0, 0)); // #3 C-W
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(4, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 600, 600, 1000, 600)); // #1 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 600, 600, 0, 0)); // #1 has A-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 0, 1000, 600)); // #1 has X-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 0, 1000, 0)); // #1 has D-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 600, 600, 0, 0)); // #1 A-D
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 600, 600, 1000, 600)); // #1 A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 1000, 0, 1000, 600)); // #1 X-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(3), 0, 0, 1000, 0)); // #1 D-X
            Assert.AreEqual(4, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 600, 600, 1000, 600)); // #2 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 600, 600, 600, 1000)); // #2 has A-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 1000, 600, 1000, 1000)); // #2 has B-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 1000, 1000, 600, 1000)); // #2 has Y-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 600, 600, 600, 1000)); // #2 A-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 1000, 1000, 600, 1000)); // #2 Y-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(2), 1000, 600, 1000, 1000)); // #2 B-Y
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(3), 600, 600, 1000, 600)); // #2 A-B
            Assert.AreEqual(4, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 600, 600, 600, 1000)); // #3 has A-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 600, 600, 0, 0)); // #3 has A-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 600, 1000, 0, 1000)); // #3 has C-W
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 0, 1000, 0, 0)); // #3 has W-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 600, 1000, 0, 1000)); // #3 C-W
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 600, 600, 600, 1000)); // #3 A-C
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(2), 600, 600, 0, 0)); // #3 A-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(3), 0, 1000, 0, 0)); // #3 W-D
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(4, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 600, 400, 600, 0)); // #1 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 600, 400, 0, 1000)); // #1 has A-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 0, 600, 0)); // #1 has X-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 1000, 0, 0)); // #1 has D-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 0, 1000, 0, 0)); // #1 D-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 600, 400, 0, 1000)); // #1 A-D
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 600, 400, 600, 0)); // #1 A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(3), 0, 0, 600, 0)); // #1 X-B
            Assert.AreEqual(4, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 600, 400, 600, 0)); // #2 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 600, 400, 1000, 400)); // #2 has A-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 600, 0, 1000, 0)); // #2 has B-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 1000, 0, 1000, 400)); // #2 has Y-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 600, 400, 1000, 400)); // #2 A-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 1000, 0, 1000, 400)); // #2 Y-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(2), 600, 0, 1000, 0)); // #2 B-Y
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(3), 600, 400, 600, 0)); // #2 A-B
            Assert.AreEqual(4, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 600, 400, 1000, 400)); // #3 has A-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 600, 400, 0, 1000)); // #3 has A-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 1000, 400, 1000, 1000)); // #3 has C-W
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 1000, 1000, 0, 1000)); // #3 has W-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 600, 400, 0, 1000)); // #3 A-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 1000, 1000, 0, 1000)); // #3 W-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(2), 1000, 400, 1000, 1000)); // #3 C-W
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(3), 600, 400, 1000, 400)); // #3 A-C
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(3, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 500, 500, 0, 0)); // #1 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 500, 500, 1000, 0)); // #1 has A-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 0, 1000, 0)); // #1 has B-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 500, 500, 0, 0)); // #1 A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 500, 500, 1000, 0)); // #1 A-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 0, 0, 1000, 0)); // #1 B-C
            Assert.AreEqual(4, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 500, 500, 1000, 0)); // #2 has A-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 500, 500, 500, 1000)); // #2 has A-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 1000, 0, 1000, 1000)); // #2 has C-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 1000, 1000, 500, 1000)); // #2 has Y-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 500, 500, 500, 1000)); // #2 A-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 1000, 1000, 500, 1000)); // #2 Y-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(2), 1000, 0, 1000, 1000)); // #2 C-Y
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(3), 500, 500, 1000, 0)); // #2 A-C
            Assert.AreEqual(4, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 500, 500, 0, 0)); // #3 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 500, 500, 500, 1000)); // #3 has A-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 0, 1000, 0, 0)); // #3 has X-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 500, 1000, 0, 1000)); // #3 has D-X
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 500, 1000, 0, 1000)); // #3 D-X
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 500, 500, 500, 1000)); // #3 A-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(2), 500, 500, 0, 0)); // #3 A-B
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(3), 0, 1000, 0, 0)); // #3 X-B
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(3, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 500, 500, 0, 1000)); // #1 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 500, 500, 0, 0)); // #1 has A-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 1000, 0, 0)); // #1 has B-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 500, 500, 0, 1000)); // #1 A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 500, 500, 0, 0)); // #1 A-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 0, 1000, 0, 0)); // #1 B-C
            Assert.AreEqual(4, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 500, 500, 0, 0)); // #2 has A-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 500, 500, 1000, 500)); // #2 has A-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 0, 0, 1000, 0)); // #2 has C-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 1000, 0, 1000, 500)); // #2 has Y-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 500, 500, 0, 0)); // #2 A-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 500, 500, 1000, 500)); // #2 A-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(2), 1000, 0, 1000, 500)); // #2 Y-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(3), 0, 0, 1000, 0)); // #2 C-Y
            Assert.AreEqual(4, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 500, 500, 0, 1000)); // #3 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 500, 500, 1000, 500)); // #3 has A-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 1000, 1000, 0, 1000)); // #3 has X-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 1000, 500, 1000, 1000)); // #3 has D-X
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 1000, 1000, 0, 1000)); // #3 X-B
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 1000, 500, 1000, 1000)); // #3 D-X
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(2), 500, 500, 1000, 500)); // #3 A-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(3), 500, 500, 0, 1000)); // #3 A-B
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(3, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 500, 500, 1000, 1000)); // #1 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 500, 500, 0, 1000)); // #1 has A-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 1000, 0, 1000)); // #1 has B-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 1000, 1000, 0, 1000)); // #1 B-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 500, 500, 1000, 1000)); // #1 A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 500, 500, 0, 1000)); // #1 A-C
            Assert.AreEqual(4, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 500, 500, 0, 1000)); // #2 has A-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 500, 500, 500, 0)); // #2 has A-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 0, 1000, 0, 0)); // #2 has C-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 0, 0, 500, 0)); // #2 has Y-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 500, 500, 0, 1000)); // #2 A-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 500, 500, 500, 0)); // #2 A-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(2), 0, 0, 500, 0)); // #2 Y-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(3), 0, 1000, 0, 0)); // #2 C-Y
            Assert.AreEqual(4, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 500, 500, 1000, 1000)); // #3 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 500, 500, 500, 0)); // #3 has A-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 1000, 0, 1000, 1000)); // #3 has X-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 500, 0, 1000, 0)); // #3 has D-X
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 500, 500, 1000, 1000)); // #3 A-B
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 1000, 0, 1000, 1000)); // #3 X-B
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(2), 500, 0, 1000, 0)); // #3 D-X
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(3), 500, 500, 500, 0)); // #3 A-D
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(3, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 500, 500, 1000, 0)); // #1 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 500, 500, 1000, 1000)); // #1 has A-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 0, 1000, 1000)); // #1 has B-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 500, 500, 1000, 1000)); // #1 A-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 1000, 0, 1000, 1000)); // #1 B-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 500, 500, 1000, 0)); // #1 A-B
            Assert.AreEqual(4, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 500, 500, 1000, 1000)); // #2 has A-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 500, 500, 0, 500)); // #2 has A-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 1000, 1000, 0, 1000)); // #2 has C-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 0, 1000, 0, 500)); // #2 has Y-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 0, 1000, 0, 500)); // #2 Y-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 1000, 1000, 0, 1000)); // #2 C-Y
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(2), 500, 500, 1000, 1000)); // #2 A-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(3), 500, 500, 0, 500)); // #2 A-D
            Assert.AreEqual(4, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 500, 500, 1000, 0)); // #3 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 500, 500, 0, 500)); // #3 has A-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 0, 0, 1000, 0)); // #3 has X-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 0, 500, 0, 0)); // #3 has D-X
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 0, 500, 0, 0)); // #3 D-X
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 500, 500, 0, 500)); // #3 A-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(2), 500, 500, 1000, 0)); // #3 A-B
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(3), 0, 0, 1000, 0)); // #3 X-B
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(3, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 500, 300, 200, 0)); // #1 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 500, 300, 800, 0)); // #1 has A-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 200, 0, 800, 0)); // #1 has B-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 500, 300, 200, 0)); // #1 A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 500, 300, 800, 0)); // #1 A-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 200, 0, 800, 0)); // #1 B-C
            Assert.AreEqual(5, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 500, 300, 800, 0)); // #2 has A-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 500, 300, 500, 1000)); // #2 has A-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 800, 0, 1000, 0)); // #2 has C-W
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 1000, 0, 1000, 1000)); // #2 has W-Z
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 1000, 1000, 500, 1000)); // #2 has Z-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 500, 300, 500, 1000)); // #2 A-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 1000, 1000, 500, 1000)); // #2 Z-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(2), 1000, 0, 1000, 1000)); // #2 W-Z
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(3), 800, 0, 1000, 0)); // #2 C-W
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(4), 500, 300, 800, 0)); // #2 A-C
            Assert.AreEqual(5, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 500, 300, 200, 0)); // #3 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 500, 300, 500, 1000)); // #3 has A-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 0, 1000, 0, 0)); // #3 has X-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 0, 0, 200, 0)); // #3 has Y-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 500, 1000, 0, 1000)); // #3 has D-X
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 0, 1000, 0, 0)); // #3 X-Y
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 500, 1000, 0, 1000)); // #3 D-X
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(2), 500, 300, 500, 1000)); // #3 A-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(3), 500, 300, 200, 0)); // #3 A-B
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(4), 0, 0, 200, 0)); // #3 Y-B
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(3, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 300, 500, 0, 800)); // #1 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 300, 500, 0, 200)); // #1 has A-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 800, 0, 200)); // #1 has B-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 300, 500, 0, 800)); // #1 A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 300, 500, 0, 200)); // #1 A-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 0, 800, 0, 200)); // #1 B-C
            Assert.AreEqual(5, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 300, 500, 0, 200)); // #2 has A-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 300, 500, 1000, 500)); // #2 has A-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 0, 200, 0, 0)); // #2 has C-W
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 0, 0, 1000, 0)); // #2 has W-Z
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 1000, 0, 1000, 500)); // #2 has Z-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 0, 200, 0, 0)); // #2 C-W
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 300, 500, 0, 200)); // #2 A-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(2), 300, 500, 1000, 500)); // #2 A-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(3), 1000, 0, 1000, 500)); // #2 Z-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(4), 0, 0, 1000, 0)); // #2 W-Z
            Assert.AreEqual(5, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 300, 500, 0, 800)); // #3 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 300, 500, 1000, 500)); // #3 has A-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 1000, 1000, 0, 1000)); // #3 has X-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 0, 1000, 0, 800)); // #3 has Y-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 1000, 500, 1000, 1000)); // #3 has D-X
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 0, 1000, 0, 800)); // #3 Y-B
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 1000, 1000, 0, 1000)); // #3 X-Y
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(2), 1000, 500, 1000, 1000)); // #3 D-X
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(3), 300, 500, 1000, 500)); // #3 A-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(4), 300, 500, 0, 800)); // #3 A-B
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(3, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 500, 700, 800, 1000)); // #1 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 500, 700, 200, 1000)); // #1 has A-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 800, 1000, 200, 1000)); // #1 has B-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 800, 1000, 200, 1000)); // #1 B-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 500, 700, 800, 1000)); // #1 A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 500, 700, 200, 1000)); // #1 A-C
            Assert.AreEqual(5, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 500, 700, 200, 1000)); // #2 has A-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 500, 700, 500, 0)); // #2 has A-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 200, 1000, 0, 1000)); // #2 has C-W
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 0, 1000, 0, 0)); // #2 has W-Z
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 0, 0, 500, 0)); // #2 has Z-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 200, 1000, 0, 1000)); // #2 C-W
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 500, 700, 200, 1000)); // #2 A-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(2), 500, 700, 500, 0)); // #2 A-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(3), 0, 0, 500, 0)); // #2 Z-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(4), 0, 1000, 0, 0)); // #2 W-Z
            Assert.AreEqual(5, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 500, 700, 800, 1000)); // #3 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 500, 700, 500, 0)); // #3 has A-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 1000, 0, 1000, 1000)); // #3 has X-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 1000, 1000, 800, 1000)); // #3 has Y-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 500, 0, 1000, 0)); // #3 has D-X
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 500, 700, 800, 1000)); // #3 A-B
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 1000, 1000, 800, 1000)); // #3 Y-B
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(2), 1000, 0, 1000, 1000)); // #3 X-Y
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(3), 500, 0, 1000, 0)); // #3 D-X
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(4), 500, 700, 500, 0)); // #3 A-D
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(3, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 700, 500, 1000, 200)); // #1 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 700, 500, 1000, 800)); // #1 has A-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 200, 1000, 800)); // #1 has B-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 700, 500, 1000, 800)); // #1 A-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 1000, 200, 1000, 800)); // #1 B-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 700, 500, 1000, 200)); // #1 A-B
            Assert.AreEqual(5, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 700, 500, 1000, 800)); // #2 has A-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 700, 500, 0, 500)); // #2 has A-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 1000, 800, 1000, 1000)); // #2 has C-W
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 1000, 1000, 0, 1000)); // #2 has W-Z
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 0, 1000, 0, 500)); // #2 has Z-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 0, 1000, 0, 500)); // #2 Z-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 1000, 1000, 0, 1000)); // #2 W-Z
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(2), 1000, 800, 1000, 1000)); // #2 C-W
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(3), 700, 500, 1000, 800)); // #2 A-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(4), 700, 500, 0, 500)); // #2 A-D
            Assert.AreEqual(5, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 700, 500, 1000, 200)); // #3 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 700, 500, 0, 500)); // #3 has A-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 0, 0, 1000, 0)); // #3 has X-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 1000, 0, 1000, 200)); // #3 has Y-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 0, 500, 0, 0)); // #3 has D-X
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 0, 500, 0, 0)); // #3 D-X
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 700, 500, 0, 500)); // #3 A-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(2), 700, 500, 1000, 200)); // #3 A-B
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(3), 1000, 0, 1000, 200)); // #3 Y-B
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(4), 0, 0, 1000, 0)); // #3 X-Y
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(5, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 500, 700, 0, 200)); // #1 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 500, 700, 1000, 200)); // #1 has A-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 200, 0, 0)); // #1 has B-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 0, 1000, 0)); // #1 has Y-W
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 0, 1000, 200)); // #1 has W-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 0, 200, 0, 0)); // #1 B-Y
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 500, 700, 0, 200)); // #1 A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 500, 700, 1000, 200)); // #1 A-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(3), 1000, 0, 1000, 200)); // #1 W-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(4), 0, 0, 1000, 0)); // #1 Y-W
            Assert.AreEqual(4, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 500, 700, 1000, 200)); // #2 has A-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 500, 700, 500, 1000)); // #2 has A-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 1000, 200, 1000, 1000)); // #2 has C-Z
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 1000, 1000, 500, 1000)); // #2 has Z-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 500, 700, 500, 1000)); // #2 A-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 1000, 1000, 500, 1000)); // #2 Z-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(2), 1000, 200, 1000, 1000)); // #2 C-Z
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(3), 500, 700, 1000, 200)); // #2 A-C
            Assert.AreEqual(4, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 500, 700, 0, 200)); // #3 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 500, 700, 500, 1000)); // #3 has A-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 0, 1000, 0, 200)); // #3 has X-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 500, 1000, 0, 1000)); // #3 has D-X
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 500, 1000, 0, 1000)); // #3 D-X
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 500, 700, 500, 1000)); // #3 A-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(2), 500, 700, 0, 200)); // #3 A-B
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(3), 0, 1000, 0, 200)); // #3 X-B
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(5, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 700, 500, 200, 1000)); // #1 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 700, 500, 200, 0)); // #1 has A-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 200, 1000, 0, 1000)); // #1 has B-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 1000, 0, 0)); // #1 has Y-W
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 0, 200, 0)); // #1 has W-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 0, 1000, 0, 0)); // #1 Y-W
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 200, 1000, 0, 1000)); // #1 B-Y
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 700, 500, 200, 1000)); // #1 A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(3), 700, 500, 200, 0)); // #1 A-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(4), 0, 0, 200, 0)); // #1 W-C
            Assert.AreEqual(4, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 700, 500, 200, 0)); // #2 has A-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 700, 500, 1000, 500)); // #2 has A-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 200, 0, 1000, 0)); // #2 has C-Z
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 1000, 0, 1000, 500)); // #2 has Z-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 700, 500, 200, 0)); // #2 A-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 700, 500, 1000, 500)); // #2 A-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(2), 1000, 0, 1000, 500)); // #2 Z-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(3), 200, 0, 1000, 0)); // #2 C-Z
            Assert.AreEqual(4, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 700, 500, 200, 1000)); // #3 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 700, 500, 1000, 500)); // #3 has A-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 1000, 1000, 200, 1000)); // #3 has X-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 1000, 500, 1000, 1000)); // #3 has D-X
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 1000, 1000, 200, 1000)); // #3 X-B
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 1000, 500, 1000, 1000)); // #3 D-X
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(2), 700, 500, 1000, 500)); // #3 A-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(3), 700, 500, 200, 1000)); // #3 A-B
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(5, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 500, 300, 1000, 800)); // #1 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 500, 300, 0, 800)); // #1 has A-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 800, 1000, 1000)); // #1 has B-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 1000, 0, 1000)); // #1 has Y-W
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 1000, 0, 800)); // #1 has W-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 0, 1000, 0, 800)); // #1 W-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 1000, 1000, 0, 1000)); // #1 Y-W
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 1000, 800, 1000, 1000)); // #1 B-Y
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(3), 500, 300, 1000, 800)); // #1 A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(4), 500, 300, 0, 800)); // #1 A-C
            Assert.AreEqual(4, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 500, 300, 0, 800)); // #2 has A-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 500, 300, 500, 0)); // #2 has A-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 0, 800, 0, 0)); // #2 has C-Z
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 0, 0, 500, 0)); // #2 has Z-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 0, 800, 0, 0)); // #2 C-Z
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 500, 300, 0, 800)); // #2 A-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(2), 500, 300, 500, 0)); // #2 A-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(3), 0, 0, 500, 0)); // #2 Z-D
            Assert.AreEqual(4, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 500, 300, 1000, 800)); // #3 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 500, 300, 500, 0)); // #3 has A-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 1000, 0, 1000, 800)); // #3 has X-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 500, 0, 1000, 0)); // #3 has D-X
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 500, 300, 1000, 800)); // #3 A-B
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 1000, 0, 1000, 800)); // #3 X-B
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(2), 500, 0, 1000, 0)); // #3 D-X
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(3), 500, 300, 500, 0)); // #3 A-D
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(5, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 300, 500, 800, 0)); // #1 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 300, 500, 800, 1000)); // #1 has A-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 800, 0, 1000, 0)); // #1 has B-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 0, 1000, 1000)); // #1 has Y-W
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 1000, 800, 1000)); // #1 has W-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 300, 500, 800, 1000)); // #1 A-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 1000, 1000, 800, 1000)); // #1 W-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 1000, 0, 1000, 1000)); // #1 Y-W
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(3), 800, 0, 1000, 0)); // #1 B-Y
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(4), 300, 500, 800, 0)); // #1 A-B
            Assert.AreEqual(4, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 300, 500, 800, 1000)); // #2 has A-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 300, 500, 0, 500)); // #2 has A-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 800, 1000, 0, 1000)); // #2 has C-Z
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 0, 1000, 0, 500)); // #2 has Z-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 0, 1000, 0, 500)); // #2 Z-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 800, 1000, 0, 1000)); // #2 C-Z
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(2), 300, 500, 800, 1000)); // #2 A-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(3), 300, 500, 0, 500)); // #2 A-D
            Assert.AreEqual(4, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 300, 500, 800, 0)); // #3 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 300, 500, 0, 500)); // #3 has A-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 0, 0, 800, 0)); // #3 has X-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 0, 500, 0, 0)); // #3 has D-X
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 0, 500, 0, 0)); // #3 D-X
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 300, 500, 0, 500)); // #3 A-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(2), 300, 500, 800, 0)); // #3 A-B
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(3), 0, 0, 800, 0)); // #3 X-B
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(4, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 400, 600, 400, 400)); // #1 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 400, 400, 600, 400)); // #1 has B-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 600, 400, 600, 600)); // #1 has C-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 600, 600, 400, 600)); // #1 has D-A
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 400, 600, 400, 400)); // #1 A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 600, 600, 400, 600)); // #1 D-A
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 600, 400, 600, 600)); // #1 C-D
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(3), 400, 400, 600, 400)); // #1 B-C
            Assert.AreEqual(4, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 400, 600, 400, 400)); // #2 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 400, 600, 0, 1000)); // #2 has A-E
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 400, 400, 0, 0)); // #2 has B-F
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 0, 1000, 0, 0)); // #2 has E-F
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 400, 600, 0, 1000)); // #2 A-E
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 400, 600, 400, 400)); // #2 A-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(2), 400, 400, 0, 0)); // #2 B-F
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(3), 0, 1000, 0, 0)); // #2 E-F
            Assert.AreEqual(4, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 400, 400, 600, 400)); // #3 has B-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 400, 400, 0, 0)); // #3 has B-F
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 600, 400, 1000, 0)); // #3 has C-G
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 0, 0, 1000, 0)); // #3 has F-G
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 400, 400, 0, 0)); // #3 B-F
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 400, 400, 600, 400)); // #3 B-C
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(2), 600, 400, 1000, 0)); // #3 C-G
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(3), 0, 0, 1000, 0)); // #3 F-G
            Assert.AreEqual(4, sites[3].ClockwiseCell.Count()); // #4
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 600, 400, 600, 600)); // #4 has C-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 600, 400, 1000, 0)); // #4 has C-G
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 600, 600, 1000, 1000)); // #4 has D-H
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 1000, 0, 1000, 1000)); // #4 has G-H
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(0), 600, 400, 600, 600)); // #4 C-D
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(1), 600, 600, 1000, 1000)); // #4 D-H
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(2), 1000, 0, 1000, 1000)); // #4 G-H
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(3), 600, 400, 1000, 0)); // #4 C-G
            Assert.AreEqual(4, sites[4].ClockwiseCell.Count()); // #5
            Assert.IsTrue(SiteHasClockwiseEdge(sites[4], 600, 600, 400, 600)); // #5 has D-A
            Assert.IsTrue(SiteHasClockwiseEdge(sites[4], 400, 600, 0, 1000)); // #5 has A-E
            Assert.IsTrue(SiteHasClockwiseEdge(sites[4], 600, 600, 1000, 1000)); // #5 has D-H
            Assert.IsTrue(SiteHasClockwiseEdge(sites[4], 1000, 1000, 0, 1000)); // #5 has H-E
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(0), 400, 600, 0, 1000)); // #5 A-E
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(1), 1000, 1000, 0, 1000)); // #5 H-E
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(2), 600, 600, 1000, 1000)); // #5 D-H
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(3), 600, 600, 400, 600)); // #5 D-A
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(4, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 400, 400, 400, 200)); // #1 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 400, 200, 600, 200)); // #1 has B-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 600, 200, 600, 400)); // #1 has C-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 600, 400, 400, 400)); // #1 has D-A
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 400, 400, 400, 200)); // #1 A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 600, 400, 400, 400)); // #1 D-A
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 600, 200, 600, 400)); // #1 C-D
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(3), 400, 200, 600, 200)); // #1 B-C
            Assert.AreEqual(5, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 400, 400, 400, 200)); // #2 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 400, 400, 0, 800)); // #2 has A-E
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 400, 200, 200, 0)); // #2 has B-F
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 0, 800, 0, 0)); // #2 has E-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 0, 0, 200, 0)); // #2 has Y-F
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 0, 800, 0, 0)); // #2 E-Y
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 400, 400, 0, 800)); // #2 A-E
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(2), 400, 400, 400, 200)); // #2 A-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(3), 400, 200, 200, 0)); // #2 B-F
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(4), 0, 0, 200, 0)); // #2 Y-F
            Assert.AreEqual(4, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 400, 200, 600, 200)); // #3 has B-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 400, 200, 200, 0)); // #3 has B-F
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 600, 200, 800, 0)); // #3 has C-G
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 200, 0, 800, 0)); // #3 has F-G
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 400, 200, 200, 0)); // #3 B-F
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 400, 200, 600, 200)); // #3 B-C
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(2), 600, 200, 800, 0)); // #3 C-G
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(3), 200, 0, 800, 0)); // #3 F-G
            Assert.AreEqual(5, sites[3].ClockwiseCell.Count()); // #4
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 600, 200, 600, 400)); // #4 has C-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 600, 200, 800, 0)); // #4 has C-G
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 600, 400, 1000, 800)); // #4 has D-H
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 800, 0, 1000, 0)); // #4 has G-W
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 1000, 0, 1000, 800)); // #4 has W-H
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(0), 600, 200, 600, 400)); // #4 C-D
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(1), 600, 400, 1000, 800)); // #4 D-H
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(2), 1000, 0, 1000, 800)); // #4 W-H
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(3), 800, 0, 1000, 0)); // #4 G-W
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(4), 600, 200, 800, 0)); // #4 C-G
            Assert.AreEqual(6, sites[4].ClockwiseCell.Count()); // #5
            Assert.IsTrue(SiteHasClockwiseEdge(sites[4], 600, 400, 400, 400)); // #5 has D-A
            Assert.IsTrue(SiteHasClockwiseEdge(sites[4], 400, 400, 0, 800)); // #5 has A-E
            Assert.IsTrue(SiteHasClockwiseEdge(sites[4], 600, 400, 1000, 800)); // #5 has D-H
            Assert.IsTrue(SiteHasClockwiseEdge(sites[4], 0, 1000, 0, 800)); // #5 has X-E
            Assert.IsTrue(SiteHasClockwiseEdge(sites[4], 1000, 800, 1000, 1000)); // #5 has H-Z
            Assert.IsTrue(SiteHasClockwiseEdge(sites[4], 1000, 1000, 0, 1000)); // #5 has Z-X
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(0), 400, 400, 0, 800)); // #5 A-E
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(1), 0, 1000, 0, 800)); // #5 X-E
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(2), 1000, 1000, 0, 1000)); // #5 Z-X
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(3), 1000, 800, 1000, 1000)); // #5 H-Z
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(4), 600, 400, 1000, 800)); // #5 D-H
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(5), 600, 400, 400, 400)); // #5 D-A
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(4, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 400, 600, 200, 600)); // #1 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 200, 600, 200, 400)); // #1 has B-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 200, 400, 400, 400)); // #1 has C-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 400, 400, 400, 600)); // #1 has D-A
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 200, 600, 200, 400)); // #1 B-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 400, 600, 200, 600)); // #1 A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 400, 400, 400, 600)); // #1 D-A
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(3), 200, 400, 400, 400)); // #1 C-D
            Assert.AreEqual(5, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 400, 600, 200, 600)); // #2 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 400, 600, 800, 1000)); // #2 has A-E
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 200, 600, 0, 800)); // #2 has B-F
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 800, 1000, 0, 1000)); // #2 has E-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 0, 1000, 0, 800)); // #2 has Y-F
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 200, 600, 0, 800)); // #2 B-F
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 0, 1000, 0, 800)); // #2 Y-F
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(2), 800, 1000, 0, 1000)); // #2 E-Y
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(3), 400, 600, 800, 1000)); // #2 A-E
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(4), 400, 600, 200, 600)); // #2 A-B
            Assert.AreEqual(4, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 200, 600, 200, 400)); // #3 has B-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 200, 600, 0, 800)); // #3 has B-F
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 200, 400, 0, 200)); // #3 has C-G
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 0, 800, 0, 200)); // #3 has F-G
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 200, 600, 0, 800)); // #3 B-F
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 200, 600, 200, 400)); // #3 B-C
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(2), 200, 400, 0, 200)); // #3 C-G
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(3), 0, 800, 0, 200)); // #3 F-G
            Assert.AreEqual(5, sites[3].ClockwiseCell.Count()); // #4
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 200, 400, 400, 400)); // #4 has C-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 200, 400, 0, 200)); // #4 has C-G
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 400, 400, 800, 0)); // #4 has D-H
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 0, 200, 0, 0)); // #4 has G-W
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 0, 0, 800, 0)); // #4 has W-H
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(0), 0, 200, 0, 0)); // #4 G-W
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(1), 200, 400, 0, 200)); // #4 C-G
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(2), 200, 400, 400, 400)); // #4 C-D
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(3), 400, 400, 800, 0)); // #4 D-H
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(4), 0, 0, 800, 0)); // #4 W-H
            Assert.AreEqual(6, sites[4].ClockwiseCell.Count()); // #5
            Assert.IsTrue(SiteHasClockwiseEdge(sites[4], 400, 400, 400, 600)); // #5 has D-A
            Assert.IsTrue(SiteHasClockwiseEdge(sites[4], 400, 600, 800, 1000)); // #5 has A-E
            Assert.IsTrue(SiteHasClockwiseEdge(sites[4], 400, 400, 800, 0)); // #5 has D-H
            Assert.IsTrue(SiteHasClockwiseEdge(sites[4], 1000, 1000, 800, 1000)); // #5 has X-E
            Assert.IsTrue(SiteHasClockwiseEdge(sites[4], 800, 0, 1000, 0)); // #5 has H-Z
            Assert.IsTrue(SiteHasClockwiseEdge(sites[4], 1000, 0, 1000, 1000)); // #5 has Z-X
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(0), 400, 400, 400, 600)); // #5 D-A
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(1), 400, 600, 800, 1000)); // #5 A-E
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(2), 1000, 1000, 800, 1000)); // #5 X-E
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(3), 1000, 0, 1000, 1000)); // #5 Z-X
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(4), 800, 0, 1000, 0)); // #5 H-Z
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(5), 400, 400, 800, 0)); // #5 D-H
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(4, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 600, 600, 600, 800)); // #1 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 600, 800, 400, 800)); // #1 has B-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 400, 800, 400, 600)); // #1 has C-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 400, 600, 600, 600)); // #1 has D-A
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 400, 800, 400, 600)); // #1 C-D
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 600, 800, 400, 800)); // #1 B-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 600, 600, 600, 800)); // #1 A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(3), 400, 600, 600, 600)); // #1 D-A
            Assert.AreEqual(5, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 600, 600, 600, 800)); // #2 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 600, 600, 1000, 200)); // #2 has A-E
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 600, 800, 800, 1000)); // #2 has B-F
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 1000, 200, 1000, 1000)); // #2 has E-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 1000, 1000, 800, 1000)); // #2 has Y-F
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 600, 600, 600, 800)); // #2 A-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 600, 800, 800, 1000)); // #2 B-F
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(2), 1000, 1000, 800, 1000)); // #2 Y-F
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(3), 1000, 200, 1000, 1000)); // #2 E-Y
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(4), 600, 600, 1000, 200)); // #2 A-E
            Assert.AreEqual(4, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 600, 800, 400, 800)); // #3 has B-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 600, 800, 800, 1000)); // #3 has B-F
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 400, 800, 200, 1000)); // #3 has C-G
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 800, 1000, 200, 1000)); // #3 has F-G
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 400, 800, 200, 1000)); // #3 C-G
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 800, 1000, 200, 1000)); // #3 F-G
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(2), 600, 800, 800, 1000)); // #3 B-F
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(3), 600, 800, 400, 800)); // #3 B-C
            Assert.AreEqual(5, sites[3].ClockwiseCell.Count()); // #4
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 400, 800, 400, 600)); // #4 has C-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 400, 800, 200, 1000)); // #4 has C-G
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 400, 600, 0, 200)); // #4 has D-H
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 200, 1000, 0, 1000)); // #4 has G-W
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 0, 1000, 0, 200)); // #4 has W-H
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(0), 200, 1000, 0, 1000)); // #4 G-W
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(1), 400, 800, 200, 1000)); // #4 C-G
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(2), 400, 800, 400, 600)); // #4 C-D
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(3), 400, 600, 0, 200)); // #4 D-H
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(4), 0, 1000, 0, 200)); // #4 W-H
            Assert.AreEqual(6, sites[4].ClockwiseCell.Count()); // #5
            Assert.IsTrue(SiteHasClockwiseEdge(sites[4], 400, 600, 600, 600)); // #5 has D-A
            Assert.IsTrue(SiteHasClockwiseEdge(sites[4], 600, 600, 1000, 200)); // #5 has A-E
            Assert.IsTrue(SiteHasClockwiseEdge(sites[4], 400, 600, 0, 200)); // #5 has D-H
            Assert.IsTrue(SiteHasClockwiseEdge(sites[4], 1000, 0, 1000, 200)); // #5 has X-E
            Assert.IsTrue(SiteHasClockwiseEdge(sites[4], 0, 200, 0, 0)); // #5 has H-Z
            Assert.IsTrue(SiteHasClockwiseEdge(sites[4], 0, 0, 1000, 0)); // #5 has Z-X
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(0), 0, 200, 0, 0)); // #5 H-Z
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(1), 400, 600, 0, 200)); // #5 D-H
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(2), 400, 600, 600, 600)); // #5 D-A
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(3), 600, 600, 1000, 200)); // #5 A-E
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(4), 1000, 0, 1000, 200)); // #5 X-E
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(5), 0, 0, 1000, 0)); // #5 Z-X
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(4, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 600, 400, 800, 400)); // #1 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 800, 400, 800, 600)); // #1 has B-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 800, 600, 600, 600)); // #1 has C-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 600, 600, 600, 400)); // #1 has D-A
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 600, 600, 600, 400)); // #1 D-A
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 800, 600, 600, 600)); // #1 C-D
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 800, 400, 800, 600)); // #1 B-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(3), 600, 400, 800, 400)); // #1 A-B
            Assert.AreEqual(5, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 600, 400, 800, 400)); // #2 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 600, 400, 200, 0)); // #2 has A-E
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 800, 400, 1000, 200)); // #2 has B-F
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 200, 0, 1000, 0)); // #2 has E-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 1000, 0, 1000, 200)); // #2 has Y-F
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 600, 400, 200, 0)); // #2 A-E
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 600, 400, 800, 400)); // #2 A-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(2), 800, 400, 1000, 200)); // #2 B-F
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(3), 1000, 0, 1000, 200)); // #2 Y-F
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(4), 200, 0, 1000, 0)); // #2 E-Y
            Assert.AreEqual(4, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 800, 400, 800, 600)); // #3 has B-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 800, 400, 1000, 200)); // #3 has B-F
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 800, 600, 1000, 800)); // #3 has C-G
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 1000, 200, 1000, 800)); // #3 has F-G
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 800, 400, 800, 600)); // #3 B-C
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 800, 600, 1000, 800)); // #3 C-G
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(2), 1000, 200, 1000, 800)); // #3 F-G
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(3), 800, 400, 1000, 200)); // #3 B-F
            Assert.AreEqual(5, sites[3].ClockwiseCell.Count()); // #4
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 800, 600, 600, 600)); // #4 has C-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 800, 600, 1000, 800)); // #4 has C-G
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 600, 600, 200, 1000)); // #4 has D-H
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 1000, 800, 1000, 1000)); // #4 has G-W
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 1000, 1000, 200, 1000)); // #4 has W-H
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(0), 600, 600, 200, 1000)); // #4 D-H
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(1), 1000, 1000, 200, 1000)); // #4 W-H
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(2), 1000, 800, 1000, 1000)); // #4 G-W
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(3), 800, 600, 1000, 800)); // #4 C-G
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(4), 800, 600, 600, 600)); // #4 C-D
            Assert.AreEqual(6, sites[4].ClockwiseCell.Count()); // #5
            Assert.IsTrue(SiteHasClockwiseEdge(sites[4], 600, 600, 600, 400)); // #5 has D-A
            Assert.IsTrue(SiteHasClockwiseEdge(sites[4], 600, 400, 200, 0)); // #5 has A-E
            Assert.IsTrue(SiteHasClockwiseEdge(sites[4], 600, 600, 200, 1000)); // #5 has D-H
            Assert.IsTrue(SiteHasClockwiseEdge(sites[4], 0, 0, 200, 0)); // #5 has X-E
            Assert.IsTrue(SiteHasClockwiseEdge(sites[4], 200, 1000, 0, 1000)); // #5 has H-Z
            Assert.IsTrue(SiteHasClockwiseEdge(sites[4], 0, 1000, 0, 0)); // #5 has Z-X
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(0), 0, 1000, 0, 0)); // #5 Z-X
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(1), 200, 1000, 0, 1000)); // #5 H-Z
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(2), 600, 600, 200, 1000)); // #5 D-H
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(3), 600, 600, 600, 400)); // #5 D-A
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(4), 600, 400, 200, 0)); // #5 A-E
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(5), 0, 0, 200, 0)); // #5 X-E
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(4, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 500, 500, 500, 1000)); // #1 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 500, 500, 0, 500)); // #1 has A-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 1000, 0, 500)); // #1 has X-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 500, 1000, 0, 1000)); // #1 has B-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 0, 1000, 0, 500)); // #1 X-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 500, 1000, 0, 1000)); // #1 B-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 500, 500, 500, 1000)); // #1 A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(3), 500, 500, 0, 500)); // #1 A-C
            Assert.AreEqual(4, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 500, 500, 0, 500)); // #2 has A-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 500, 500, 500, 0)); // #2 has A-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 0, 500, 0, 0)); // #2 has C-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 0, 0, 500, 0)); // #2 has Y-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 0, 500, 0, 0)); // #2 C-Y
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 500, 500, 0, 500)); // #2 A-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(2), 500, 500, 500, 0)); // #2 A-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(3), 0, 0, 500, 0)); // #2 Y-D
            Assert.AreEqual(4, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 500, 500, 500, 0)); // #3 has A-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 500, 500, 1000, 500)); // #3 has A-E
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 500, 0, 1000, 0)); // #3 has D-W
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 1000, 0, 1000, 500)); // #3 has W-E
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 500, 500, 1000, 500)); // #3 A-E
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 1000, 0, 1000, 500)); // #3 W-E
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(2), 500, 0, 1000, 0)); // #3 D-W
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(3), 500, 500, 500, 0)); // #3 A-D
            Assert.AreEqual(4, sites[3].ClockwiseCell.Count()); // #4
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 500, 500, 500, 1000)); // #4 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 500, 500, 1000, 500)); // #4 has A-E
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 1000, 500, 1000, 1000)); // #4 has E-Z
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 1000, 1000, 500, 1000)); // #4 has Z-B
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(0), 500, 500, 500, 1000)); // #4 A-B
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(1), 1000, 1000, 500, 1000)); // #4 Z-B
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(2), 1000, 500, 1000, 1000)); // #4 E-Z
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(3), 500, 500, 1000, 500)); // #4 A-E
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(4, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 500, 500, 500, 1000)); // #1 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 500, 500, 0, 500)); // #1 has A-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 1000, 0, 500)); // #1 has X-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 500, 1000, 0, 1000)); // #1 has B-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 0, 1000, 0, 500)); // #1 X-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 500, 1000, 0, 1000)); // #1 B-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 500, 500, 500, 1000)); // #1 A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(3), 500, 500, 0, 500)); // #1 A-C
            Assert.AreEqual(4, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 500, 500, 0, 500)); // #2 has A-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 500, 500, 500, 0)); // #2 has A-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 0, 500, 0, 0)); // #2 has C-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 0, 0, 500, 0)); // #2 has Y-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 0, 500, 0, 0)); // #2 C-Y
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 500, 500, 0, 500)); // #2 A-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(2), 500, 500, 500, 0)); // #2 A-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(3), 0, 0, 500, 0)); // #2 Y-D
            Assert.AreEqual(4, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 500, 500, 500, 0)); // #3 has A-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 500, 500, 1000, 500)); // #3 has A-E
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 500, 0, 1000, 0)); // #3 has D-W
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 1000, 0, 1000, 500)); // #3 has W-E
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 500, 500, 1000, 500)); // #3 A-E
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 1000, 0, 1000, 500)); // #3 W-E
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(2), 500, 0, 1000, 0)); // #3 D-W
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(3), 500, 500, 500, 0)); // #3 A-D
            Assert.AreEqual(4, sites[3].ClockwiseCell.Count()); // #4
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 500, 500, 500, 1000)); // #4 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 500, 500, 1000, 500)); // #4 has A-E
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 1000, 500, 1000, 1000)); // #4 has E-Z
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 1000, 1000, 500, 1000)); // #4 has Z-B
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(0), 1000, 1000, 500, 1000)); // #4 Z-B
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(1), 1000, 500, 1000, 1000)); // #4 E-Z
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(2), 500, 500, 1000, 500)); // #4 A-E
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(3), 500, 500, 500, 1000)); // #4 A-B
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(4, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 500, 500, 1000, 500)); // #1 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 500, 500, 500, 1000)); // #1 has A-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 1000, 500, 1000)); // #1 has X-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 500, 1000, 1000)); // #1 has B-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 500, 500, 500, 1000)); // #1 A-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 1000, 1000, 500, 1000)); // #1 X-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 1000, 500, 1000, 1000)); // #1 B-X
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(3), 500, 500, 1000, 500)); // #1 A-B
            Assert.AreEqual(4, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 500, 500, 500, 1000)); // #2 has A-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 500, 500, 0, 500)); // #2 has A-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 500, 1000, 0, 1000)); // #2 has C-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 0, 1000, 0, 500)); // #2 has Y-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 0, 1000, 0, 500)); // #2 Y-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 500, 1000, 0, 1000)); // #2 C-Y
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(2), 500, 500, 500, 1000)); // #2 A-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(3), 500, 500, 0, 500)); // #2 A-D
            Assert.AreEqual(4, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 500, 500, 0, 500)); // #3 has A-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 500, 500, 500, 0)); // #3 has A-E
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 0, 500, 0, 0)); // #3 has D-W
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 0, 0, 500, 0)); // #3 has W-E
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 500, 500, 0, 500)); // #3 A-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 500, 500, 500, 0)); // #3 A-E
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(2), 0, 0, 500, 0)); // #3 W-E
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(3), 0, 500, 0, 0)); // #3 D-W
            Assert.AreEqual(4, sites[3].ClockwiseCell.Count()); // #4
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 500, 500, 1000, 500)); // #4 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 500, 500, 500, 0)); // #4 has A-E
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 500, 0, 1000, 0)); // #4 has E-Z
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 1000, 0, 1000, 500)); // #4 has Z-B
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(0), 500, 500, 1000, 500)); // #4 A-B
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(1), 1000, 0, 1000, 500)); // #4 Z-B
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(2), 500, 0, 1000, 0)); // #4 E-Z
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(3), 500, 500, 500, 0)); // #4 A-E
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(3, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 500, 700, 200, 1000)); // #1 has B-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 500, 700, 800, 1000)); // #1 has B-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 800, 1000, 200, 1000)); // #1 has D-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 800, 1000, 200, 1000)); // #1 D-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 500, 700, 800, 1000)); // #1 B-D
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 500, 700, 200, 1000)); // #1 B-C
            Assert.AreEqual(5, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 500, 400, 500, 700)); // #2 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 500, 700, 200, 1000)); // #2 has B-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 500, 400, 0, 400)); // #2 has A-E
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 200, 1000, 0, 1000)); // #2 has C-W
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 0, 1000, 0, 400)); // #2 has W-E
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 0, 1000, 0, 400)); // #2 W-E
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 200, 1000, 0, 1000)); // #2 C-W
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(2), 500, 700, 200, 1000)); // #2 B-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(3), 500, 400, 500, 700)); // #2 A-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(4), 500, 400, 0, 400)); // #2 A-E
            Assert.AreEqual(4, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 500, 400, 0, 400)); // #3 has A-E
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 500, 400, 500, 0)); // #3 has A-G
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 0, 400, 0, 0)); // #3 has E-X
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 0, 0, 500, 0)); // #3 has X-G
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 0, 400, 0, 0)); // #3 E-X
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 500, 400, 0, 400)); // #3 A-E
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(2), 500, 400, 500, 0)); // #3 A-G
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(3), 0, 0, 500, 0)); // #3 X-G
            Assert.AreEqual(4, sites[3].ClockwiseCell.Count()); // #4
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 500, 400, 1000, 400)); // #4 has A-F
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 500, 400, 500, 0)); // #4 has A-G
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 500, 0, 1000, 0)); // #4 has G-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 1000, 0, 1000, 400)); // #4 has Y-F
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(0), 500, 400, 500, 0)); // #4 A-G
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(1), 500, 400, 1000, 400)); // #4 A-F
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(2), 1000, 0, 1000, 400)); // #4 Y-F
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(3), 500, 0, 1000, 0)); // #4 G-Y
            Assert.AreEqual(5, sites[4].ClockwiseCell.Count()); // #5
            Assert.IsTrue(SiteHasClockwiseEdge(sites[4], 500, 400, 500, 700)); // #5 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[4], 500, 700, 800, 1000)); // #5 has B-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[4], 500, 400, 1000, 400)); // #5 has A-F
            Assert.IsTrue(SiteHasClockwiseEdge(sites[4], 1000, 400, 1000, 1000)); // #5 has F-Z
            Assert.IsTrue(SiteHasClockwiseEdge(sites[4], 1000, 1000, 800, 1000)); // #5 has Z-D
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(0), 500, 700, 800, 1000)); // #5 B-D
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(1), 1000, 1000, 800, 1000)); // #5 Z-D
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(2), 1000, 400, 1000, 1000)); // #5 F-Z
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(3), 500, 400, 1000, 400)); // #5 A-F
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(4), 500, 400, 500, 700)); // #5 A-B
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(3, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 700, 500, 1000, 800)); // #1 has B-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 700, 500, 1000, 200)); // #1 has B-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 200, 1000, 800)); // #1 has D-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 700, 500, 1000, 800)); // #1 B-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 1000, 200, 1000, 800)); // #1 D-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 700, 500, 1000, 200)); // #1 B-D
            Assert.AreEqual(5, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 400, 500, 700, 500)); // #2 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 700, 500, 1000, 800)); // #2 has B-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 400, 500, 400, 1000)); // #2 has A-E
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 1000, 800, 1000, 1000)); // #2 has C-W
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 1000, 1000, 400, 1000)); // #2 has W-E
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 400, 500, 400, 1000)); // #2 A-E
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 1000, 1000, 400, 1000)); // #2 W-E
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(2), 1000, 800, 1000, 1000)); // #2 C-W
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(3), 700, 500, 1000, 800)); // #2 B-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(4), 400, 500, 700, 500)); // #2 A-B
            Assert.AreEqual(4, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 400, 500, 400, 1000)); // #3 has A-E
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 400, 500, 0, 500)); // #3 has A-G
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 400, 1000, 0, 1000)); // #3 has E-X
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 0, 1000, 0, 500)); // #3 has X-G
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 400, 1000, 0, 1000)); // #3 E-X
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 400, 500, 400, 1000)); // #3 A-E
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(2), 400, 500, 0, 500)); // #3 A-G
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(3), 0, 1000, 0, 500)); // #3 X-G
            Assert.AreEqual(4, sites[3].ClockwiseCell.Count()); // #4
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 400, 500, 400, 0)); // #4 has A-F
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 400, 500, 0, 500)); // #4 has A-G
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 0, 500, 0, 0)); // #4 has G-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 0, 0, 400, 0)); // #4 has Y-F
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(0), 400, 500, 0, 500)); // #4 A-G
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(1), 400, 500, 400, 0)); // #4 A-F
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(2), 0, 0, 400, 0)); // #4 Y-F
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(3), 0, 500, 0, 0)); // #4 G-Y
            Assert.AreEqual(5, sites[4].ClockwiseCell.Count()); // #5
            Assert.IsTrue(SiteHasClockwiseEdge(sites[4], 400, 500, 700, 500)); // #5 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[4], 700, 500, 1000, 200)); // #5 has B-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[4], 400, 500, 400, 0)); // #5 has A-F
            Assert.IsTrue(SiteHasClockwiseEdge(sites[4], 400, 0, 1000, 0)); // #5 has F-Z
            Assert.IsTrue(SiteHasClockwiseEdge(sites[4], 1000, 0, 1000, 200)); // #5 has Z-D
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(0), 400, 500, 400, 0)); // #5 A-F
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(1), 400, 500, 700, 500)); // #5 A-B
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(2), 700, 500, 1000, 200)); // #5 B-D
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(3), 1000, 0, 1000, 200)); // #5 Z-D
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(4), 400, 0, 1000, 0)); // #5 F-Z
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(3, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 500, 300, 800, 0)); // #1 has B-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 500, 300, 200, 0)); // #1 has B-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 200, 0, 800, 0)); // #1 has D-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 500, 300, 200, 0)); // #1 B-D
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 500, 300, 800, 0)); // #1 B-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 200, 0, 800, 0)); // #1 D-C
            Assert.AreEqual(5, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 500, 600, 500, 300)); // #2 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 500, 300, 800, 0)); // #2 has B-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 500, 600, 1000, 600)); // #2 has A-E
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 800, 0, 1000, 0)); // #2 has C-W
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 1000, 0, 1000, 600)); // #2 has W-E
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 500, 600, 500, 300)); // #2 A-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 500, 600, 1000, 600)); // #2 A-E
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(2), 1000, 0, 1000, 600)); // #2 W-E
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(3), 800, 0, 1000, 0)); // #2 C-W
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(4), 500, 300, 800, 0)); // #2 B-C
            Assert.AreEqual(4, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 500, 600, 1000, 600)); // #3 has A-E
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 500, 600, 500, 1000)); // #3 has A-G
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 1000, 600, 1000, 1000)); // #3 has E-X
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 1000, 1000, 500, 1000)); // #3 has X-G
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 1000, 1000, 500, 1000)); // #3 X-G
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 1000, 600, 1000, 1000)); // #3 E-X
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(2), 500, 600, 1000, 600)); // #3 A-E
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(3), 500, 600, 500, 1000)); // #3 A-G
            Assert.AreEqual(4, sites[3].ClockwiseCell.Count()); // #4
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 500, 600, 0, 600)); // #4 has A-F
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 500, 600, 500, 1000)); // #4 has A-G
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 500, 1000, 0, 1000)); // #4 has G-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 0, 1000, 0, 600)); // #4 has Y-F
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(0), 0, 1000, 0, 600)); // #4 Y-F
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(1), 500, 1000, 0, 1000)); // #4 G-Y
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(2), 500, 600, 500, 1000)); // #4 A-G
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(3), 500, 600, 0, 600)); // #4 A-F
            Assert.AreEqual(5, sites[4].ClockwiseCell.Count()); // #5
            Assert.IsTrue(SiteHasClockwiseEdge(sites[4], 500, 600, 500, 300)); // #5 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[4], 500, 300, 200, 0)); // #5 has B-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[4], 500, 600, 0, 600)); // #5 has A-F
            Assert.IsTrue(SiteHasClockwiseEdge(sites[4], 0, 600, 0, 0)); // #5 has F-Z
            Assert.IsTrue(SiteHasClockwiseEdge(sites[4], 0, 0, 200, 0)); // #5 has Z-D
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(0), 0, 600, 0, 0)); // #5 F-Z
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(1), 500, 600, 0, 600)); // #5 A-F
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(2), 500, 600, 500, 300)); // #5 A-B
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(3), 500, 300, 200, 0)); // #5 B-D
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(4), 0, 0, 200, 0)); // #5 Z-D
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(3, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 300, 500, 0, 200)); // #1 has B-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 300, 500, 0, 800)); // #1 has B-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 800, 0, 200)); // #1 has D-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 300, 500, 0, 800)); // #1 B-D
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 300, 500, 0, 200)); // #1 B-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 0, 800, 0, 200)); // #1 D-C
            Assert.AreEqual(5, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 600, 500, 300, 500)); // #2 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 300, 500, 0, 200)); // #2 has B-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 600, 500, 600, 0)); // #2 has A-E
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 0, 200, 0, 0)); // #2 has C-W
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 0, 0, 600, 0)); // #2 has W-E
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 0, 200, 0, 0)); // #2 C-W
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 300, 500, 0, 200)); // #2 B-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(2), 600, 500, 300, 500)); // #2 A-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(3), 600, 500, 600, 0)); // #2 A-E
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(4), 0, 0, 600, 0)); // #2 W-E
            Assert.AreEqual(4, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 600, 500, 600, 0)); // #3 has A-E
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 600, 500, 1000, 500)); // #3 has A-G
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 600, 0, 1000, 0)); // #3 has E-X
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 1000, 0, 1000, 500)); // #3 has X-G
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 600, 500, 600, 0)); // #3 A-E
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 600, 500, 1000, 500)); // #3 A-G
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(2), 1000, 0, 1000, 500)); // #3 X-G
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(3), 600, 0, 1000, 0)); // #3 E-X
            Assert.AreEqual(4, sites[3].ClockwiseCell.Count()); // #4
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 600, 500, 600, 1000)); // #4 has A-F
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 600, 500, 1000, 500)); // #4 has A-G
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 1000, 500, 1000, 1000)); // #4 has G-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 1000, 1000, 600, 1000)); // #4 has Y-F
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(0), 600, 500, 600, 1000)); // #4 A-F
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(1), 1000, 1000, 600, 1000)); // #4 Y-F
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(2), 1000, 500, 1000, 1000)); // #4 G-Y
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(3), 600, 500, 1000, 500)); // #4 A-G
            Assert.AreEqual(5, sites[4].ClockwiseCell.Count()); // #5
            Assert.IsTrue(SiteHasClockwiseEdge(sites[4], 600, 500, 300, 500)); // #5 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[4], 300, 500, 0, 800)); // #5 has B-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[4], 600, 500, 600, 1000)); // #5 has A-F
            Assert.IsTrue(SiteHasClockwiseEdge(sites[4], 600, 1000, 0, 1000)); // #5 has F-Z
            Assert.IsTrue(SiteHasClockwiseEdge(sites[4], 0, 1000, 0, 800)); // #5 has Z-D
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(0), 0, 1000, 0, 800)); // #5 Z-D
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(1), 600, 1000, 0, 1000)); // #5 F-Z
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(2), 600, 500, 600, 1000)); // #5 A-F
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(3), 600, 500, 300, 500)); // #5 A-B
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(4), 300, 500, 0, 800)); // #5 B-D
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(3, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 500, 500, 0, 1000)); // #1 has B-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 500, 500, 1000, 1000)); // #1 has B-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 1000, 0, 1000)); // #1 has D-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 1000, 1000, 0, 1000)); // #1 D-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 500, 500, 1000, 1000)); // #1 B-D
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 500, 500, 0, 1000)); // #1 B-C
            Assert.AreEqual(4, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 500, 300, 500, 500)); // #2 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 500, 500, 0, 1000)); // #2 has B-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 500, 300, 0, 300)); // #2 has A-E
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 0, 1000, 0, 300)); // #2 has C-E
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 0, 1000, 0, 300)); // #2 C-E
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 500, 500, 0, 1000)); // #2 B-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(2), 500, 300, 500, 500)); // #2 A-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(3), 500, 300, 0, 300)); // #2 A-E
            Assert.AreEqual(4, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 500, 300, 0, 300)); // #3 has A-E
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 500, 300, 500, 0)); // #3 has A-G
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 0, 300, 0, 0)); // #3 has E-X
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 0, 0, 500, 0)); // #3 has X-G
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 0, 300, 0, 0)); // #3 E-X
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 500, 300, 0, 300)); // #3 A-E
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(2), 500, 300, 500, 0)); // #3 A-G
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(3), 0, 0, 500, 0)); // #3 X-G
            Assert.AreEqual(4, sites[3].ClockwiseCell.Count()); // #4
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 500, 300, 1000, 300)); // #4 has A-F
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 500, 300, 500, 0)); // #4 has A-G
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 500, 0, 1000, 0)); // #4 has G-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 1000, 0, 1000, 300)); // #4 has Y-F
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(0), 500, 300, 500, 0)); // #4 A-G
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(1), 500, 300, 1000, 300)); // #4 A-F
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(2), 1000, 0, 1000, 300)); // #4 Y-F
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(3), 500, 0, 1000, 0)); // #4 G-Y
            Assert.AreEqual(4, sites[4].ClockwiseCell.Count()); // #5
            Assert.IsTrue(SiteHasClockwiseEdge(sites[4], 500, 300, 500, 500)); // #5 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[4], 500, 500, 1000, 1000)); // #5 has B-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[4], 500, 300, 1000, 300)); // #5 has A-F
            Assert.IsTrue(SiteHasClockwiseEdge(sites[4], 1000, 300, 1000, 1000)); // #5 has F-D
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(0), 500, 300, 500, 500)); // #5 A-B
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(1), 500, 500, 1000, 1000)); // #5 B-D
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(2), 1000, 300, 1000, 1000)); // #5 F-D
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(3), 500, 300, 1000, 300)); // #5 A-F
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(3, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 500, 500, 1000, 1000)); // #1 has B-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 500, 500, 1000, 0)); // #1 has B-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 0, 1000, 1000)); // #1 has D-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 500, 500, 1000, 1000)); // #1 B-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 1000, 0, 1000, 1000)); // #1 D-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 500, 500, 1000, 0)); // #1 B-D
            Assert.AreEqual(4, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 300, 500, 500, 500)); // #2 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 500, 500, 1000, 1000)); // #2 has B-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 300, 500, 300, 1000)); // #2 has A-E
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 1000, 1000, 300, 1000)); // #2 has C-E
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 300, 500, 300, 1000)); // #2 A-E
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 1000, 1000, 300, 1000)); // #2 C-E
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(2), 500, 500, 1000, 1000)); // #2 B-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(3), 300, 500, 500, 500)); // #2 A-B
            Assert.AreEqual(4, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 300, 500, 300, 1000)); // #3 has A-E
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 300, 500, 0, 500)); // #3 has A-G
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 300, 1000, 0, 1000)); // #3 has E-X
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 0, 1000, 0, 500)); // #3 has X-G
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 300, 1000, 0, 1000)); // #3 E-X
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 300, 500, 300, 1000)); // #3 A-E
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(2), 300, 500, 0, 500)); // #3 A-G
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(3), 0, 1000, 0, 500)); // #3 X-G
            Assert.AreEqual(4, sites[3].ClockwiseCell.Count()); // #4
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 300, 500, 300, 0)); // #4 has A-F
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 300, 500, 0, 500)); // #4 has A-G
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 0, 500, 0, 0)); // #4 has G-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 0, 0, 300, 0)); // #4 has Y-F
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(0), 300, 500, 0, 500)); // #4 A-G
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(1), 300, 500, 300, 0)); // #4 A-F
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(2), 0, 0, 300, 0)); // #4 Y-F
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(3), 0, 500, 0, 0)); // #4 G-Y
            Assert.AreEqual(4, sites[4].ClockwiseCell.Count()); // #5
            Assert.IsTrue(SiteHasClockwiseEdge(sites[4], 300, 500, 500, 500)); // #5 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[4], 500, 500, 1000, 0)); // #5 has B-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[4], 300, 500, 300, 0)); // #5 has A-F
            Assert.IsTrue(SiteHasClockwiseEdge(sites[4], 300, 0, 1000, 0)); // #5 has F-D
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(0), 300, 500, 500, 500)); // #5 A-B
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(1), 500, 500, 1000, 0)); // #5 B-D
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(2), 300, 0, 1000, 0)); // #5 F-D
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(3), 300, 500, 300, 0)); // #5 A-F
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(4, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 500, 700, 0, 700)); // #1 has B-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 500, 700, 500, 1000)); // #1 has B-H
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 0, 1000, 0, 700)); // #1 has W-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 500, 1000, 0, 1000)); // #1 has H-W
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 0, 1000, 0, 700)); // #1 W-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 500, 1000, 0, 1000)); // #1 H-W
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 500, 700, 500, 1000)); // #1 B-H
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(3), 500, 700, 0, 700)); // #1 B-C
            Assert.AreEqual(4, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 500, 700, 1000, 700)); // #2 has B-G
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 500, 700, 500, 1000)); // #2 has B-H
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 1000, 700, 1000, 1000)); // #2 has G-Z
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 1000, 1000, 500, 1000)); // #2 has Z-H
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 500, 700, 500, 1000)); // #2 B-H
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 1000, 1000, 500, 1000)); // #2 Z-H
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(2), 1000, 700, 1000, 1000)); // #2 G-Z
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(3), 500, 700, 1000, 700)); // #2 B-G
            Assert.AreEqual(4, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 500, 300, 500, 700)); // #3 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 500, 700, 0, 700)); // #3 has B-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 500, 300, 0, 300)); // #3 has A-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 0, 700, 0, 300)); // #3 has C-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 0, 700, 0, 300)); // #3 C-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 500, 700, 0, 700)); // #3 B-C
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(2), 500, 300, 500, 700)); // #3 A-B
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(3), 500, 300, 0, 300)); // #3 A-D
            Assert.AreEqual(4, sites[3].ClockwiseCell.Count()); // #4
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 500, 300, 500, 700)); // #4 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 500, 700, 1000, 700)); // #4 has B-G
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 500, 300, 1000, 300)); // #4 has A-F
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 1000, 300, 1000, 700)); // #4 has F-G
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(0), 500, 300, 500, 700)); // #4 A-B
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(1), 500, 700, 1000, 700)); // #4 B-G
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(2), 1000, 300, 1000, 700)); // #4 F-G
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(3), 500, 300, 1000, 300)); // #4 A-F
            Assert.AreEqual(4, sites[4].ClockwiseCell.Count()); // #5
            Assert.IsTrue(SiteHasClockwiseEdge(sites[4], 500, 300, 0, 300)); // #5 has A-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[4], 500, 300, 500, 0)); // #5 has A-E
            Assert.IsTrue(SiteHasClockwiseEdge(sites[4], 0, 300, 0, 0)); // #5 has D-X
            Assert.IsTrue(SiteHasClockwiseEdge(sites[4], 0, 0, 500, 0)); // #5 has X-E
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(0), 0, 300, 0, 0)); // #5 D-X
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(1), 500, 300, 0, 300)); // #5 A-D
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(2), 500, 300, 500, 0)); // #5 A-E
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(3), 0, 0, 500, 0)); // #5 X-E
            Assert.AreEqual(4, sites[5].ClockwiseCell.Count()); // #6
            Assert.IsTrue(SiteHasClockwiseEdge(sites[5], 500, 300, 1000, 300)); // #6 has A-F
            Assert.IsTrue(SiteHasClockwiseEdge(sites[5], 500, 300, 500, 0)); // #6 has A-E
            Assert.IsTrue(SiteHasClockwiseEdge(sites[5], 500, 0, 1000, 0)); // #6 has E-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[5], 1000, 0, 1000, 300)); // #6 has Y-F
            Assert.IsTrue(EdgeIs(sites[5].ClockwiseCell.ElementAt(0), 500, 300, 500, 0)); // #6 A-E
            Assert.IsTrue(EdgeIs(sites[5].ClockwiseCell.ElementAt(1), 500, 300, 1000, 300)); // #6 A-F
            Assert.IsTrue(EdgeIs(sites[5].ClockwiseCell.ElementAt(2), 1000, 0, 1000, 300)); // #6 Y-F
            Assert.IsTrue(EdgeIs(sites[5].ClockwiseCell.ElementAt(3), 500, 0, 1000, 0)); // #6 E-Y
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

            VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges);

            // Assert

            Assert.AreEqual(4, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 700, 500, 700, 1000)); // #1 has B-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 700, 500, 1000, 500)); // #1 has B-H
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 1000, 700, 1000)); // #1 has W-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[0], 1000, 500, 1000, 1000)); // #1 has H-W
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 700, 500, 700, 1000)); // #1 B-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 1000, 1000, 700, 1000)); // #1 W-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 1000, 500, 1000, 1000)); // #1 H-W
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(3), 700, 500, 1000, 500)); // #1 B-H
            Assert.AreEqual(4, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 700, 500, 700, 0)); // #2 has B-G
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 700, 500, 1000, 500)); // #2 has B-H
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 700, 0, 1000, 0)); // #2 has G-Z
            Assert.IsTrue(SiteHasClockwiseEdge(sites[1], 1000, 0, 1000, 500)); // #2 has Z-H
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 700, 500, 1000, 500)); // #2 B-H
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 1000, 0, 1000, 500)); // #2 Z-H
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(2), 700, 0, 1000, 0)); // #2 G-Z
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(3), 700, 500, 700, 0)); // #2 B-G
            Assert.AreEqual(4, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 300, 500, 700, 500)); // #3 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 700, 500, 700, 1000)); // #3 has B-C
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 300, 500, 300, 1000)); // #3 has A-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[2], 700, 1000, 300, 1000)); // #3 has C-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 300, 500, 300, 1000)); // #3 A-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 700, 1000, 300, 1000)); // #3 C-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(2), 700, 500, 700, 1000)); // #3 B-C
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(3), 300, 500, 700, 500)); // #3 A-B
            Assert.AreEqual(4, sites[3].ClockwiseCell.Count()); // #4
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 300, 500, 700, 500)); // #4 has A-B
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 700, 500, 700, 0)); // #4 has B-G
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 300, 500, 300, 0)); // #4 has A-F
            Assert.IsTrue(SiteHasClockwiseEdge(sites[3], 300, 0, 700, 0)); // #4 has F-G
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(0), 300, 500, 700, 500)); // #4 A-B
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(1), 700, 500, 700, 0)); // #4 B-G
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(2), 300, 0, 700, 0)); // #4 F-G
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(3), 300, 500, 300, 0)); // #4 A-F
            Assert.AreEqual(4, sites[4].ClockwiseCell.Count()); // #5
            Assert.IsTrue(SiteHasClockwiseEdge(sites[4], 300, 500, 300, 1000)); // #5 has A-D
            Assert.IsTrue(SiteHasClockwiseEdge(sites[4], 300, 500, 0, 500)); // #5 has A-E
            Assert.IsTrue(SiteHasClockwiseEdge(sites[4], 300, 1000, 0, 1000)); // #5 has D-X
            Assert.IsTrue(SiteHasClockwiseEdge(sites[4], 0, 1000, 0, 500)); // #5 has X-E
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(0), 300, 1000, 0, 1000)); // #5 D-X
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(1), 300, 500, 300, 1000)); // #5 A-D
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(2), 300, 500, 0, 500)); // #5 A-E
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(3), 0, 1000, 0, 500)); // #5 X-E
            Assert.AreEqual(4, sites[5].ClockwiseCell.Count()); // #6
            Assert.IsTrue(SiteHasClockwiseEdge(sites[5], 300, 500, 300, 0)); // #6 has A-F
            Assert.IsTrue(SiteHasClockwiseEdge(sites[5], 300, 500, 0, 500)); // #6 has A-E
            Assert.IsTrue(SiteHasClockwiseEdge(sites[5], 0, 500, 0, 0)); // #6 has E-Y
            Assert.IsTrue(SiteHasClockwiseEdge(sites[5], 0, 0, 300, 0)); // #6 has Y-F
            Assert.IsTrue(EdgeIs(sites[5].ClockwiseCell.ElementAt(0), 300, 500, 0, 500)); // #6 A-E
            Assert.IsTrue(EdgeIs(sites[5].ClockwiseCell.ElementAt(1), 300, 500, 300, 0)); // #6 A-F
            Assert.IsTrue(EdgeIs(sites[5].ClockwiseCell.ElementAt(2), 0, 0, 300, 0)); // #6 Y-F
            Assert.IsTrue(EdgeIs(sites[5].ClockwiseCell.ElementAt(3), 0, 500, 0, 0)); // #6 E-Y
        }

    }
}
