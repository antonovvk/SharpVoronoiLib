using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using static SharpVoronoiLib.UnitTests.CommonTestUtilities;

#pragma warning disable
// ReSharper disable All

namespace SharpVoronoiLib.UnitTests
{
    /// <summary>
    /// These tests assert that <see cref="VoronoiSite"/>`s have expected neighbouring sites.
    /// Specifically, that the <see cref="VoronoiSite.Neighbours"/> contains the expected <see cref="VoronoiSite"/>`s.
    /// These tests are run with generating the border edges, i.e. <see cref="BorderEdgeGeneration.MakeBorderEdges"/>.
    /// </summary>
    /// <remarks>
    /// This is an AUTO-GENERATED test fixture class from UnitTestGenerator.
    /// This is one of the several auto-generated fixture classes each checking a different part of the algorithm's result.
    /// It contains a bunch of known Voronoi site layouts, including many edge cases.
    /// </remarks>
    [Parallelizable(ParallelScope.All)]
    [TestFixture]
    public class GeneratedTest_SiteNeighbours_ClosedBorders
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume


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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 4 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 1000, 0)); // #1 has W
            Assume.That(() => SiteHasPoint(sites[0], 0, 1000)); // #1 has X
            Assume.That(() => SiteHasPoint(sites[0], 0, 0)); // #1 has Y
            Assume.That(() => SiteHasPoint(sites[0], 1000, 1000)); // #1 has Z

            // Assert

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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 4 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 1000, 0)); // #1 has W
            Assume.That(() => SiteHasPoint(sites[0], 0, 1000)); // #1 has X
            Assume.That(() => SiteHasPoint(sites[0], 0, 0)); // #1 has Y
            Assume.That(() => SiteHasPoint(sites[0], 1000, 1000)); // #1 has Z

            // Assert

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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 4 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 0, 0)); // #1 has W
            Assume.That(() => SiteHasPoint(sites[0], 1000, 1000)); // #1 has X
            Assume.That(() => SiteHasPoint(sites[0], 0, 1000)); // #1 has Y
            Assume.That(() => SiteHasPoint(sites[0], 1000, 0)); // #1 has Z

            // Assert

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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 4 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 0, 1000)); // #1 has W
            Assume.That(() => SiteHasPoint(sites[0], 1000, 0)); // #1 has X
            Assume.That(() => SiteHasPoint(sites[0], 1000, 1000)); // #1 has Y
            Assume.That(() => SiteHasPoint(sites[0], 0, 0)); // #1 has Z

            // Assert

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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 4 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 1000, 1000)); // #1 has W
            Assume.That(() => SiteHasPoint(sites[0], 0, 0)); // #1 has X
            Assume.That(() => SiteHasPoint(sites[0], 1000, 0)); // #1 has Y
            Assume.That(() => SiteHasPoint(sites[0], 0, 1000)); // #1 has Z

            // Assert

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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 4 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 1000, 0)); // #1 has W
            Assume.That(() => SiteHasPoint(sites[0], 0, 1000)); // #1 has X
            Assume.That(() => SiteHasPoint(sites[0], 0, 0)); // #1 has Y
            Assume.That(() => SiteHasPoint(sites[0], 1000, 1000)); // #1 has Z

            // Assert

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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 4 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 0, 0)); // #1 has W
            Assume.That(() => SiteHasPoint(sites[0], 1000, 1000)); // #1 has X
            Assume.That(() => SiteHasPoint(sites[0], 0, 1000)); // #1 has Y
            Assume.That(() => SiteHasPoint(sites[0], 1000, 0)); // #1 has Z

            // Assert

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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 4 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 0, 1000)); // #1 has W
            Assume.That(() => SiteHasPoint(sites[0], 1000, 0)); // #1 has X
            Assume.That(() => SiteHasPoint(sites[0], 1000, 1000)); // #1 has Y
            Assume.That(() => SiteHasPoint(sites[0], 0, 0)); // #1 has Z

            // Assert

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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 4 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 1000, 1000)); // #1 has W
            Assume.That(() => SiteHasPoint(sites[0], 0, 0)); // #1 has X
            Assume.That(() => SiteHasPoint(sites[0], 1000, 0)); // #1 has Y
            Assume.That(() => SiteHasPoint(sites[0], 0, 1000)); // #1 has Z

            // Assert

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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 4 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 1000, 0)); // #1 has W
            Assume.That(() => SiteHasPoint(sites[0], 0, 1000)); // #1 has X
            Assume.That(() => SiteHasPoint(sites[0], 0, 0)); // #1 has Y
            Assume.That(() => SiteHasPoint(sites[0], 1000, 1000)); // #1 has Z

            // Assert

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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 4 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 0, 0)); // #1 has W
            Assume.That(() => SiteHasPoint(sites[0], 1000, 1000)); // #1 has X
            Assume.That(() => SiteHasPoint(sites[0], 0, 1000)); // #1 has Y
            Assume.That(() => SiteHasPoint(sites[0], 1000, 0)); // #1 has Z

            // Assert

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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 4 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 0, 1000)); // #1 has W
            Assume.That(() => SiteHasPoint(sites[0], 1000, 0)); // #1 has X
            Assume.That(() => SiteHasPoint(sites[0], 1000, 1000)); // #1 has Y
            Assume.That(() => SiteHasPoint(sites[0], 0, 0)); // #1 has Z

            // Assert

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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 4 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 1000, 1000)); // #1 has W
            Assume.That(() => SiteHasPoint(sites[0], 0, 0)); // #1 has X
            Assume.That(() => SiteHasPoint(sites[0], 1000, 0)); // #1 has Y
            Assume.That(() => SiteHasPoint(sites[0], 0, 1000)); // #1 has Z

            // Assert

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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 4 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 1000, 0)); // #1 has W
            Assume.That(() => SiteHasPoint(sites[0], 0, 1000)); // #1 has X
            Assume.That(() => SiteHasPoint(sites[0], 0, 0)); // #1 has Y
            Assume.That(() => SiteHasPoint(sites[0], 1000, 1000)); // #1 has Z

            // Assert

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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 4 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 0, 0)); // #1 has W
            Assume.That(() => SiteHasPoint(sites[0], 1000, 1000)); // #1 has X
            Assume.That(() => SiteHasPoint(sites[0], 0, 1000)); // #1 has Y
            Assume.That(() => SiteHasPoint(sites[0], 1000, 0)); // #1 has Z

            // Assert

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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 4 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 0, 1000)); // #1 has W
            Assume.That(() => SiteHasPoint(sites[0], 1000, 0)); // #1 has X
            Assume.That(() => SiteHasPoint(sites[0], 1000, 1000)); // #1 has Y
            Assume.That(() => SiteHasPoint(sites[0], 0, 0)); // #1 has Z

            // Assert

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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 4 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 1000, 1000)); // #1 has W
            Assume.That(() => SiteHasPoint(sites[0], 0, 0)); // #1 has X
            Assume.That(() => SiteHasPoint(sites[0], 1000, 0)); // #1 has Y
            Assume.That(() => SiteHasPoint(sites[0], 0, 1000)); // #1 has Z

            // Assert

        }

        /// <summary>
        /// This test basically repeats <see cref="OnePointOnBorderOffset"/> above,
        /// but all coordinates are mirrored horizontally.
        /// </summary>
        [Test]
        public void OnePointOnBorderOffset_Mirrored()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(1000, 700), // #1
            };

            // 1000 Z-------------------------------------------------X
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                                                 1
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
            //    0 W-------------------------------------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 4 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 0, 0)); // #1 has W
            Assume.That(() => SiteHasPoint(sites[0], 1000, 1000)); // #1 has X
            Assume.That(() => SiteHasPoint(sites[0], 1000, 0)); // #1 has Y
            Assume.That(() => SiteHasPoint(sites[0], 0, 1000)); // #1 has Z

            // Assert

        }

        /// <summary>
        /// This test basically repeats <see cref="OnePointOnBorderOffset"/> above,
        /// but all coordinates are mirrored horizontally and then rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void OnePointOnBorderOffset_MirroredAndRotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(700, 0), // #1
            };

            // 1000 W-------------------------------------------------Z
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
            //    0 Y----------------------------------1--------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 4 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 0, 1000)); // #1 has W
            Assume.That(() => SiteHasPoint(sites[0], 1000, 0)); // #1 has X
            Assume.That(() => SiteHasPoint(sites[0], 0, 0)); // #1 has Y
            Assume.That(() => SiteHasPoint(sites[0], 1000, 1000)); // #1 has Z

            // Assert

        }

        /// <summary>
        /// This test basically repeats <see cref="OnePointOnBorderOffset"/> above,
        /// but all coordinates are mirrored horizontally and then rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void OnePointOnBorderOffset_MirroredAndRotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(0, 300), // #1
            };

            // 1000 Y-------------------------------------------------W
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
            //  300 1                                                 |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 X-------------------------------------------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 4 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 1000, 1000)); // #1 has W
            Assume.That(() => SiteHasPoint(sites[0], 0, 0)); // #1 has X
            Assume.That(() => SiteHasPoint(sites[0], 0, 1000)); // #1 has Y
            Assume.That(() => SiteHasPoint(sites[0], 1000, 0)); // #1 has Z

            // Assert

        }

        /// <summary>
        /// This test basically repeats <see cref="OnePointOnBorderOffset"/> above,
        /// but all coordinates are mirrored horizontally and then rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void OnePointOnBorderOffset_MirroredAndRotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(300, 1000), // #1
            };

            // 1000 X--------------1----------------------------------Y
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
            //    0 Z-------------------------------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 4 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 1000, 0)); // #1 has W
            Assume.That(() => SiteHasPoint(sites[0], 0, 1000)); // #1 has X
            Assume.That(() => SiteHasPoint(sites[0], 1000, 1000)); // #1 has Y
            Assume.That(() => SiteHasPoint(sites[0], 0, 0)); // #1 has Z

            // Assert

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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 4 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 1000, 0)); // #1 has W
            Assume.That(() => SiteHasPoint(sites[0], 0, 1000)); // #1 has X
            Assume.That(() => SiteHasPoint(sites[0], 0, 0)); // #1 has Y
            Assume.That(() => SiteHasPoint(sites[0], 1000, 1000)); // #1 has Z

            // Assert

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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 4 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 0, 0)); // #1 has W
            Assume.That(() => SiteHasPoint(sites[0], 1000, 1000)); // #1 has X
            Assume.That(() => SiteHasPoint(sites[0], 0, 1000)); // #1 has Y
            Assume.That(() => SiteHasPoint(sites[0], 1000, 0)); // #1 has Z

            // Assert

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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 4 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 0, 1000)); // #1 has W
            Assume.That(() => SiteHasPoint(sites[0], 1000, 0)); // #1 has X
            Assume.That(() => SiteHasPoint(sites[0], 1000, 1000)); // #1 has Y
            Assume.That(() => SiteHasPoint(sites[0], 0, 0)); // #1 has Z

            // Assert

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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 4 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 1000, 1000)); // #1 has W
            Assume.That(() => SiteHasPoint(sites[0], 0, 0)); // #1 has X
            Assume.That(() => SiteHasPoint(sites[0], 1000, 0)); // #1 has Y
            Assume.That(() => SiteHasPoint(sites[0], 0, 1000)); // #1 has Z

            // Assert

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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 4 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 0, 500)); // #1 has A
            Assume.That(() => SiteHasPoint(sites[0], 1000, 500)); // #1 has B
            Assume.That(() => SiteHasPoint(sites[0], 0, 1000)); // #1 has X
            Assume.That(() => SiteHasPoint(sites[0], 1000, 1000)); // #1 has Z
            Assume.That(() => 4 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 0, 500)); // #2 has A
            Assume.That(() => SiteHasPoint(sites[1], 1000, 500)); // #2 has B
            Assume.That(() => SiteHasPoint(sites[1], 1000, 0)); // #2 has W
            Assume.That(() => SiteHasPoint(sites[1], 0, 0)); // #2 has Y

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 4 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 500, 1000)); // #1 has A
            Assume.That(() => SiteHasPoint(sites[0], 500, 0)); // #1 has B
            Assume.That(() => SiteHasPoint(sites[0], 1000, 1000)); // #1 has X
            Assume.That(() => SiteHasPoint(sites[0], 1000, 0)); // #1 has Z
            Assume.That(() => 4 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 500, 1000)); // #2 has A
            Assume.That(() => SiteHasPoint(sites[1], 500, 0)); // #2 has B
            Assume.That(() => SiteHasPoint(sites[1], 0, 0)); // #2 has W
            Assume.That(() => SiteHasPoint(sites[1], 0, 1000)); // #2 has Y

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 4 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 0, 700)); // #1 has A
            Assume.That(() => SiteHasPoint(sites[0], 1000, 700)); // #1 has B
            Assume.That(() => SiteHasPoint(sites[0], 0, 1000)); // #1 has X
            Assume.That(() => SiteHasPoint(sites[0], 1000, 1000)); // #1 has Z
            Assume.That(() => 4 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 0, 700)); // #2 has A
            Assume.That(() => SiteHasPoint(sites[1], 1000, 700)); // #2 has B
            Assume.That(() => SiteHasPoint(sites[1], 1000, 0)); // #2 has W
            Assume.That(() => SiteHasPoint(sites[1], 0, 0)); // #2 has Y

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 4 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 700, 1000)); // #1 has A
            Assume.That(() => SiteHasPoint(sites[0], 700, 0)); // #1 has B
            Assume.That(() => SiteHasPoint(sites[0], 1000, 1000)); // #1 has X
            Assume.That(() => SiteHasPoint(sites[0], 1000, 0)); // #1 has Z
            Assume.That(() => 4 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 700, 1000)); // #2 has A
            Assume.That(() => SiteHasPoint(sites[1], 700, 0)); // #2 has B
            Assume.That(() => SiteHasPoint(sites[1], 0, 0)); // #2 has W
            Assume.That(() => SiteHasPoint(sites[1], 0, 1000)); // #2 has Y

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 4 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 0, 700)); // #1 has A
            Assume.That(() => SiteHasPoint(sites[0], 1000, 700)); // #1 has B
            Assume.That(() => SiteHasPoint(sites[0], 0, 1000)); // #1 has X
            Assume.That(() => SiteHasPoint(sites[0], 1000, 1000)); // #1 has Z
            Assume.That(() => 4 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 0, 700)); // #2 has A
            Assume.That(() => SiteHasPoint(sites[1], 1000, 700)); // #2 has B
            Assume.That(() => SiteHasPoint(sites[1], 0, 300)); // #2 has C
            Assume.That(() => SiteHasPoint(sites[1], 1000, 300)); // #2 has D
            Assume.That(() => 4 == sites[2].Points.Count()); // #3
            Assume.That(() => SiteHasPoint(sites[2], 0, 300)); // #3 has C
            Assume.That(() => SiteHasPoint(sites[2], 1000, 300)); // #3 has D
            Assume.That(() => SiteHasPoint(sites[2], 1000, 0)); // #3 has W
            Assume.That(() => SiteHasPoint(sites[2], 0, 0)); // #3 has Y

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[2])); // 2 neighbours 3
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[1])); // 3 neighbours 2
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 4 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 700, 1000)); // #1 has A
            Assume.That(() => SiteHasPoint(sites[0], 700, 0)); // #1 has B
            Assume.That(() => SiteHasPoint(sites[0], 1000, 1000)); // #1 has X
            Assume.That(() => SiteHasPoint(sites[0], 1000, 0)); // #1 has Z
            Assume.That(() => 4 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 700, 1000)); // #2 has A
            Assume.That(() => SiteHasPoint(sites[1], 700, 0)); // #2 has B
            Assume.That(() => SiteHasPoint(sites[1], 300, 1000)); // #2 has C
            Assume.That(() => SiteHasPoint(sites[1], 300, 0)); // #2 has D
            Assume.That(() => 4 == sites[2].Points.Count()); // #3
            Assume.That(() => SiteHasPoint(sites[2], 300, 1000)); // #3 has C
            Assume.That(() => SiteHasPoint(sites[2], 300, 0)); // #3 has D
            Assume.That(() => SiteHasPoint(sites[2], 0, 0)); // #3 has W
            Assume.That(() => SiteHasPoint(sites[2], 0, 1000)); // #3 has Y

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[2])); // 2 neighbours 3
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[1])); // 3 neighbours 2
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 4 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 0, 700)); // #1 has A
            Assume.That(() => SiteHasPoint(sites[0], 1000, 700)); // #1 has B
            Assume.That(() => SiteHasPoint(sites[0], 0, 1000)); // #1 has X
            Assume.That(() => SiteHasPoint(sites[0], 1000, 1000)); // #1 has Z
            Assume.That(() => 4 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 0, 700)); // #2 has A
            Assume.That(() => SiteHasPoint(sites[1], 1000, 700)); // #2 has B
            Assume.That(() => SiteHasPoint(sites[1], 0, 500)); // #2 has C
            Assume.That(() => SiteHasPoint(sites[1], 1000, 500)); // #2 has D
            Assume.That(() => 4 == sites[2].Points.Count()); // #3
            Assume.That(() => SiteHasPoint(sites[2], 0, 500)); // #3 has C
            Assume.That(() => SiteHasPoint(sites[2], 1000, 500)); // #3 has D
            Assume.That(() => SiteHasPoint(sites[2], 0, 300)); // #3 has E
            Assume.That(() => SiteHasPoint(sites[2], 1000, 300)); // #3 has F
            Assume.That(() => 4 == sites[3].Points.Count()); // #4
            Assume.That(() => SiteHasPoint(sites[3], 0, 300)); // #4 has E
            Assume.That(() => SiteHasPoint(sites[3], 1000, 300)); // #4 has F
            Assume.That(() => SiteHasPoint(sites[3], 1000, 0)); // #4 has W
            Assume.That(() => SiteHasPoint(sites[3], 0, 0)); // #4 has Y

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[2])); // 2 neighbours 3
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[1])); // 3 neighbours 2
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[3])); // 3 neighbours 4
            Assert.IsTrue(sites[3].Neighbours.Contains(sites[2])); // 4 neighbours 3
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 4 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 700, 1000)); // #1 has A
            Assume.That(() => SiteHasPoint(sites[0], 700, 0)); // #1 has B
            Assume.That(() => SiteHasPoint(sites[0], 1000, 1000)); // #1 has X
            Assume.That(() => SiteHasPoint(sites[0], 1000, 0)); // #1 has Z
            Assume.That(() => 4 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 700, 1000)); // #2 has A
            Assume.That(() => SiteHasPoint(sites[1], 700, 0)); // #2 has B
            Assume.That(() => SiteHasPoint(sites[1], 500, 1000)); // #2 has C
            Assume.That(() => SiteHasPoint(sites[1], 500, 0)); // #2 has D
            Assume.That(() => 4 == sites[2].Points.Count()); // #3
            Assume.That(() => SiteHasPoint(sites[2], 500, 1000)); // #3 has C
            Assume.That(() => SiteHasPoint(sites[2], 500, 0)); // #3 has D
            Assume.That(() => SiteHasPoint(sites[2], 300, 1000)); // #3 has E
            Assume.That(() => SiteHasPoint(sites[2], 300, 0)); // #3 has F
            Assume.That(() => 4 == sites[3].Points.Count()); // #4
            Assume.That(() => SiteHasPoint(sites[3], 300, 1000)); // #4 has E
            Assume.That(() => SiteHasPoint(sites[3], 300, 0)); // #4 has F
            Assume.That(() => SiteHasPoint(sites[3], 0, 0)); // #4 has W
            Assume.That(() => SiteHasPoint(sites[3], 0, 1000)); // #4 has Y

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[2])); // 2 neighbours 3
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[1])); // 3 neighbours 2
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[3])); // 3 neighbours 4
            Assert.IsTrue(sites[3].Neighbours.Contains(sites[2])); // 4 neighbours 3
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 3 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 0, 0)); // #1 has A
            Assume.That(() => SiteHasPoint(sites[0], 1000, 1000)); // #1 has B
            Assume.That(() => SiteHasPoint(sites[0], 0, 1000)); // #1 has X
            Assume.That(() => 3 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 0, 0)); // #2 has A
            Assume.That(() => SiteHasPoint(sites[1], 1000, 1000)); // #2 has B
            Assume.That(() => SiteHasPoint(sites[1], 1000, 0)); // #2 has Y

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 3 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 0, 1000)); // #1 has A
            Assume.That(() => SiteHasPoint(sites[0], 1000, 0)); // #1 has B
            Assume.That(() => SiteHasPoint(sites[0], 1000, 1000)); // #1 has X
            Assume.That(() => 3 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 0, 1000)); // #2 has A
            Assume.That(() => SiteHasPoint(sites[1], 1000, 0)); // #2 has B
            Assume.That(() => SiteHasPoint(sites[1], 0, 0)); // #2 has Y

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 3 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 0, 200)); // #1 has A
            Assume.That(() => SiteHasPoint(sites[0], 800, 1000)); // #1 has B
            Assume.That(() => SiteHasPoint(sites[0], 0, 1000)); // #1 has X
            Assume.That(() => 5 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 0, 200)); // #2 has A
            Assume.That(() => SiteHasPoint(sites[1], 800, 1000)); // #2 has B
            Assume.That(() => SiteHasPoint(sites[1], 1000, 0)); // #2 has W
            Assume.That(() => SiteHasPoint(sites[1], 0, 0)); // #2 has Y
            Assume.That(() => SiteHasPoint(sites[1], 1000, 1000)); // #2 has Z

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 3 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 200, 1000)); // #1 has A
            Assume.That(() => SiteHasPoint(sites[0], 1000, 200)); // #1 has B
            Assume.That(() => SiteHasPoint(sites[0], 1000, 1000)); // #1 has X
            Assume.That(() => 5 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 200, 1000)); // #2 has A
            Assume.That(() => SiteHasPoint(sites[1], 1000, 200)); // #2 has B
            Assume.That(() => SiteHasPoint(sites[1], 0, 0)); // #2 has W
            Assume.That(() => SiteHasPoint(sites[1], 0, 1000)); // #2 has Y
            Assume.That(() => SiteHasPoint(sites[1], 1000, 0)); // #2 has Z

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 3 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 1000, 800)); // #1 has A
            Assume.That(() => SiteHasPoint(sites[0], 200, 0)); // #1 has B
            Assume.That(() => SiteHasPoint(sites[0], 1000, 0)); // #1 has X
            Assume.That(() => 5 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 1000, 800)); // #2 has A
            Assume.That(() => SiteHasPoint(sites[1], 200, 0)); // #2 has B
            Assume.That(() => SiteHasPoint(sites[1], 0, 1000)); // #2 has W
            Assume.That(() => SiteHasPoint(sites[1], 1000, 1000)); // #2 has Y
            Assume.That(() => SiteHasPoint(sites[1], 0, 0)); // #2 has Z

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 3 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 800, 0)); // #1 has A
            Assume.That(() => SiteHasPoint(sites[0], 0, 800)); // #1 has B
            Assume.That(() => SiteHasPoint(sites[0], 0, 0)); // #1 has X
            Assume.That(() => 5 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 800, 0)); // #2 has A
            Assume.That(() => SiteHasPoint(sites[1], 0, 800)); // #2 has B
            Assume.That(() => SiteHasPoint(sites[1], 1000, 1000)); // #2 has W
            Assume.That(() => SiteHasPoint(sites[1], 1000, 0)); // #2 has Y
            Assume.That(() => SiteHasPoint(sites[1], 0, 1000)); // #2 has Z

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
        }

        [Test]
        public void TwoPointsAgainstCorner()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(200, 400), // #1
                new VoronoiSite(600, 800), // #2
            };

            // 1000 A#------------------------------------------------Y
            //      | ',                                              |
            //  900 |   '·,                                           |
            //      |      ',                                         |
            //  800 |        '·,                  2                   |
            //      |           ',                                    |
            //  700 |             '·,                                 |
            //      |                ',                               |
            //  600 |                  '·,                            |
            //      |                     ',                          |
            //  500 |                       '·,                       |
            //      |                          ',                     |
            //  400 |         1                  '·,                  |
            //      |                               ',                |
            //  300 |                                 '·,             |
            //      |                                    ',           |
            //  200 |                                      '·,        |
            //      |                                         ',      |
            //  100 |                                           '·,   |
            //      |                                              ', |
            //    0 X------------------------------------------------#B
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 3 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 0, 1000)); // #1 has A
            Assume.That(() => SiteHasPoint(sites[0], 1000, 0)); // #1 has B
            Assume.That(() => SiteHasPoint(sites[0], 0, 0)); // #1 has X
            Assume.That(() => 3 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 0, 1000)); // #2 has A
            Assume.That(() => SiteHasPoint(sites[1], 1000, 0)); // #2 has B
            Assume.That(() => SiteHasPoint(sites[1], 1000, 1000)); // #2 has Y

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
        }

        /// <summary>
        /// This test basically repeats <see cref="TwoPointsAgainstCorner"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void TwoPointsAgainstCorner_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(400, 800), // #1
                new VoronoiSite(800, 400), // #2
            };

            // 1000 X------------------------------------------------#A
            //      |                                              ,' |
            //  900 |                                           ,·'   |
            //      |                                         ,'      |
            //  800 |                   1                  ,·'        |
            //      |                                    ,'           |
            //  700 |                                 ,·'             |
            //      |                               ,'                |
            //  600 |                            ,·'                  |
            //      |                          ,'                     |
            //  500 |                       ,·'                       |
            //      |                     ,'                          |
            //  400 |                  ,·'                  2         |
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 3 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 1000, 1000)); // #1 has A
            Assume.That(() => SiteHasPoint(sites[0], 0, 0)); // #1 has B
            Assume.That(() => SiteHasPoint(sites[0], 0, 1000)); // #1 has X
            Assume.That(() => 3 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 1000, 1000)); // #2 has A
            Assume.That(() => SiteHasPoint(sites[1], 0, 0)); // #2 has B
            Assume.That(() => SiteHasPoint(sites[1], 1000, 0)); // #2 has Y

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
        }

        /// <summary>
        /// This test basically repeats <see cref="TwoPointsAgainstCorner"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void TwoPointsAgainstCorner_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(800, 600), // #1
                new VoronoiSite(400, 200), // #2
            };

            // 1000 B#------------------------------------------------X
            //      | ',                                              |
            //  900 |   '·,                                           |
            //      |      ',                                         |
            //  800 |        '·,                                      |
            //      |           ',                                    |
            //  700 |             '·,                                 |
            //      |                ',                               |
            //  600 |                  '·,                  1         |
            //      |                     ',                          |
            //  500 |                       '·,                       |
            //      |                          ',                     |
            //  400 |                            '·,                  |
            //      |                               ',                |
            //  300 |                                 '·,             |
            //      |                                    ',           |
            //  200 |                   2                  '·,        |
            //      |                                         ',      |
            //  100 |                                           '·,   |
            //      |                                              ', |
            //    0 Y------------------------------------------------#A
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 3 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 1000, 0)); // #1 has A
            Assume.That(() => SiteHasPoint(sites[0], 0, 1000)); // #1 has B
            Assume.That(() => SiteHasPoint(sites[0], 1000, 1000)); // #1 has X
            Assume.That(() => 3 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 1000, 0)); // #2 has A
            Assume.That(() => SiteHasPoint(sites[1], 0, 1000)); // #2 has B
            Assume.That(() => SiteHasPoint(sites[1], 0, 0)); // #2 has Y

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
        }

        /// <summary>
        /// This test basically repeats <see cref="TwoPointsAgainstCorner"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void TwoPointsAgainstCorner_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(600, 200), // #1
                new VoronoiSite(200, 600), // #2
            };

            // 1000 Y------------------------------------------------#B
            //      |                                              ,' |
            //  900 |                                           ,·'   |
            //      |                                         ,'      |
            //  800 |                                      ,·'        |
            //      |                                    ,'           |
            //  700 |                                 ,·'             |
            //      |                               ,'                |
            //  600 |         2                  ,·'                  |
            //      |                          ,'                     |
            //  500 |                       ,·'                       |
            //      |                     ,'                          |
            //  400 |                  ,·'                            |
            //      |                ,'                               |
            //  300 |             ,·'                                 |
            //      |           ,'                                    |
            //  200 |        ,·'                  1                   |
            //      |      ,'                                         |
            //  100 |   ,·'                                           |
            //      | ,'                                              |
            //    0 A#------------------------------------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 3 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 0, 0)); // #1 has A
            Assume.That(() => SiteHasPoint(sites[0], 1000, 1000)); // #1 has B
            Assume.That(() => SiteHasPoint(sites[0], 1000, 0)); // #1 has X
            Assume.That(() => 3 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 0, 0)); // #2 has A
            Assume.That(() => SiteHasPoint(sites[1], 1000, 1000)); // #2 has B
            Assume.That(() => SiteHasPoint(sites[1], 0, 1000)); // #2 has Y

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
        }

        [Test]
        public void TwoPointsAgainstCornerSlanted()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 500), // #1
                new VoronoiSite(700, 900), // #2
            };

            // 1000 A##-----------------------------------------------Z
            //      |  ''·,,                                          |
            //  900 |       ''·,,                      2              |
            //      |            ''·,,                                |
            //  800 |                 ''·,,                           |
            //      |                      ''·,,                      |
            //  700 |                           ''·,,                 |
            //      |                                ''·,,            |
            //  600 |                                     ''·,,       |
            //      |                                          ''·,,  |
            //  500 |                        1                      ''B
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 X-------------------------------------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 4 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 0, 1000)); // #1 has A
            Assume.That(() => SiteHasPoint(sites[0], 1000, 500)); // #1 has B
            Assume.That(() => SiteHasPoint(sites[0], 0, 0)); // #1 has X
            Assume.That(() => SiteHasPoint(sites[0], 1000, 0)); // #1 has Y
            Assume.That(() => 3 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 0, 1000)); // #2 has A
            Assume.That(() => SiteHasPoint(sites[1], 1000, 500)); // #2 has B
            Assume.That(() => SiteHasPoint(sites[1], 1000, 1000)); // #2 has Z

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
        }

        /// <summary>
        /// This test basically repeats <see cref="TwoPointsAgainstCornerSlanted"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void TwoPointsAgainstCornerSlanted_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 500), // #1
                new VoronoiSite(900, 300), // #2
            };

            // 1000 X-------------------------------------------------A
            //      |                                                '|
            //  900 |                                              ,' |
            //      |                                             ,   |
            //  800 |                                            ·    |
            //      |                                           '     |
            //  700 |                                         ,'      |
            //      |                                        ,        |
            //  600 |                                       ·         |
            //      |                                      '          |
            //  500 |                        1           ,'           |
            //      |                                   ,             |
            //  400 |                                  ·              |
            //      |                                 '               |
            //  300 |                               ,'           2    |
            //      |                              ,                  |
            //  200 |                             ·                   |
            //      |                            '                    |
            //  100 |                          ,'                     |
            //      |                         ,                       |
            //    0 Y------------------------B------------------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 4 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 1000, 1000)); // #1 has A
            Assume.That(() => SiteHasPoint(sites[0], 500, 0)); // #1 has B
            Assume.That(() => SiteHasPoint(sites[0], 0, 1000)); // #1 has X
            Assume.That(() => SiteHasPoint(sites[0], 0, 0)); // #1 has Y
            Assume.That(() => 3 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 1000, 1000)); // #2 has A
            Assume.That(() => SiteHasPoint(sites[1], 500, 0)); // #2 has B
            Assume.That(() => SiteHasPoint(sites[1], 1000, 0)); // #2 has Z

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
        }

        /// <summary>
        /// This test basically repeats <see cref="TwoPointsAgainstCornerSlanted"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void TwoPointsAgainstCornerSlanted_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 500), // #1
                new VoronoiSite(300, 100), // #2
            };

            // 1000 Y-------------------------------------------------X
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 B,,                      1                        |
            //      |  ''·,,                                          |
            //  400 |       ''·,,                                     |
            //      |            ''·,,                                |
            //  300 |                 ''·,,                           |
            //      |                      ''·,,                      |
            //  200 |                           ''·,,                 |
            //      |                                ''·,,            |
            //  100 |              2                      ''·,,       |
            //      |                                          ''·,,  |
            //    0 Z-----------------------------------------------##A
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 4 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 1000, 0)); // #1 has A
            Assume.That(() => SiteHasPoint(sites[0], 0, 500)); // #1 has B
            Assume.That(() => SiteHasPoint(sites[0], 1000, 1000)); // #1 has X
            Assume.That(() => SiteHasPoint(sites[0], 0, 1000)); // #1 has Y
            Assume.That(() => 3 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 1000, 0)); // #2 has A
            Assume.That(() => SiteHasPoint(sites[1], 0, 500)); // #2 has B
            Assume.That(() => SiteHasPoint(sites[1], 0, 0)); // #2 has Z

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
        }

        /// <summary>
        /// This test basically repeats <see cref="TwoPointsAgainstCornerSlanted"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void TwoPointsAgainstCornerSlanted_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 500), // #1
                new VoronoiSite(100, 700), // #2
            };

            // 1000 Z------------------------B------------------------Y
            //      |                       '                         |
            //  900 |                     ,'                          |
            //      |                    ,                            |
            //  800 |                   ·                             |
            //      |                  '                              |
            //  700 |    2           ,'                               |
            //      |               ,                                 |
            //  600 |              ·                                  |
            //      |             '                                   |
            //  500 |           ,'           1                        |
            //      |          ,                                      |
            //  400 |         ·                                       |
            //      |        '                                        |
            //  300 |      ,'                                         |
            //      |     ,                                           |
            //  200 |    ·                                            |
            //      |   '                                             |
            //  100 | ,'                                              |
            //      |,                                                |
            //    0 A-------------------------------------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 4 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 0, 0)); // #1 has A
            Assume.That(() => SiteHasPoint(sites[0], 500, 1000)); // #1 has B
            Assume.That(() => SiteHasPoint(sites[0], 1000, 0)); // #1 has X
            Assume.That(() => SiteHasPoint(sites[0], 1000, 1000)); // #1 has Y
            Assume.That(() => 3 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 0, 0)); // #2 has A
            Assume.That(() => SiteHasPoint(sites[1], 500, 1000)); // #2 has B
            Assume.That(() => SiteHasPoint(sites[1], 0, 1000)); // #2 has Z

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
        }

        /// <summary>
        /// This test basically repeats <see cref="TwoPointsAgainstCornerSlanted"/> above,
        /// but all coordinates are mirrored horizontally.
        /// </summary>
        [Test]
        public void TwoPointsAgainstCornerSlanted_Mirrored()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 500), // #1
                new VoronoiSite(300, 900), // #2
            };

            // 1000 Z-----------------------------------------------##A
            //      |                                          ,,·''  |
            //  900 |              2                      ,,·''       |
            //      |                                ,,·''            |
            //  800 |                           ,,·''                 |
            //      |                      ,,·''                      |
            //  700 |                 ,,·''                           |
            //      |            ,,·''                                |
            //  600 |       ,,·''                                     |
            //      |  ,,·''                                          |
            //  500 B''                      1                        |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 Y-------------------------------------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 4 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 1000, 1000)); // #1 has A
            Assume.That(() => SiteHasPoint(sites[0], 0, 500)); // #1 has B
            Assume.That(() => SiteHasPoint(sites[0], 1000, 0)); // #1 has X
            Assume.That(() => SiteHasPoint(sites[0], 0, 0)); // #1 has Y
            Assume.That(() => 3 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 1000, 1000)); // #2 has A
            Assume.That(() => SiteHasPoint(sites[1], 0, 500)); // #2 has B
            Assume.That(() => SiteHasPoint(sites[1], 0, 1000)); // #2 has Z

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
        }

        /// <summary>
        /// This test basically repeats <see cref="TwoPointsAgainstCornerSlanted"/> above,
        /// but all coordinates are mirrored horizontally and then rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void TwoPointsAgainstCornerSlanted_MirroredAndRotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 500), // #1
                new VoronoiSite(900, 700), // #2
            };

            // 1000 Y------------------------B------------------------Z
            //      |                         '                       |
            //  900 |                          ',                     |
            //      |                            ,                    |
            //  800 |                             ·                   |
            //      |                              '                  |
            //  700 |                               ',           2    |
            //      |                                 ,               |
            //  600 |                                  ·              |
            //      |                                   '             |
            //  500 |                        1           ',           |
            //      |                                      ,          |
            //  400 |                                       ·         |
            //      |                                        '        |
            //  300 |                                         ',      |
            //      |                                           ,     |
            //  200 |                                            ·    |
            //      |                                             '   |
            //  100 |                                              ', |
            //      |                                                ,|
            //    0 X-------------------------------------------------A
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 4 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 1000, 0)); // #1 has A
            Assume.That(() => SiteHasPoint(sites[0], 500, 1000)); // #1 has B
            Assume.That(() => SiteHasPoint(sites[0], 0, 0)); // #1 has X
            Assume.That(() => SiteHasPoint(sites[0], 0, 1000)); // #1 has Y
            Assume.That(() => 3 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 1000, 0)); // #2 has A
            Assume.That(() => SiteHasPoint(sites[1], 500, 1000)); // #2 has B
            Assume.That(() => SiteHasPoint(sites[1], 1000, 1000)); // #2 has Z

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
        }

        /// <summary>
        /// This test basically repeats <see cref="TwoPointsAgainstCornerSlanted"/> above,
        /// but all coordinates are mirrored horizontally and then rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void TwoPointsAgainstCornerSlanted_MirroredAndRotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 500), // #1
                new VoronoiSite(700, 100), // #2
            };

            // 1000 X-------------------------------------------------Y
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                        1                      ,,B
            //      |                                          ,,·''  |
            //  400 |                                     ,,·''       |
            //      |                                ,,·''            |
            //  300 |                           ,,·''                 |
            //      |                      ,,·''                      |
            //  200 |                 ,,·''                           |
            //      |            ,,·''                                |
            //  100 |       ,,·''                      2              |
            //      |  ,,·''                                          |
            //    0 A##-----------------------------------------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 4 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 0, 0)); // #1 has A
            Assume.That(() => SiteHasPoint(sites[0], 1000, 500)); // #1 has B
            Assume.That(() => SiteHasPoint(sites[0], 0, 1000)); // #1 has X
            Assume.That(() => SiteHasPoint(sites[0], 1000, 1000)); // #1 has Y
            Assume.That(() => 3 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 0, 0)); // #2 has A
            Assume.That(() => SiteHasPoint(sites[1], 1000, 500)); // #2 has B
            Assume.That(() => SiteHasPoint(sites[1], 1000, 0)); // #2 has Z

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
        }

        /// <summary>
        /// This test basically repeats <see cref="TwoPointsAgainstCornerSlanted"/> above,
        /// but all coordinates are mirrored horizontally and then rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void TwoPointsAgainstCornerSlanted_MirroredAndRotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 500), // #1
                new VoronoiSite(100, 300), // #2
            };

            // 1000 A-------------------------------------------------X
            //      |'                                                |
            //  900 | ',                                              |
            //      |   ,                                             |
            //  800 |    ·                                            |
            //      |     '                                           |
            //  700 |      ',                                         |
            //      |        ,                                        |
            //  600 |         ·                                       |
            //      |          '                                      |
            //  500 |           ',           1                        |
            //      |             ,                                   |
            //  400 |              ·                                  |
            //      |               '                                 |
            //  300 |    2           ',                               |
            //      |                  ,                              |
            //  200 |                   ·                             |
            //      |                    '                            |
            //  100 |                     ',                          |
            //      |                       ,                         |
            //    0 Z------------------------B------------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 4 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 0, 1000)); // #1 has A
            Assume.That(() => SiteHasPoint(sites[0], 500, 0)); // #1 has B
            Assume.That(() => SiteHasPoint(sites[0], 1000, 1000)); // #1 has X
            Assume.That(() => SiteHasPoint(sites[0], 1000, 0)); // #1 has Y
            Assume.That(() => 3 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 0, 1000)); // #2 has A
            Assume.That(() => SiteHasPoint(sites[1], 500, 0)); // #2 has B
            Assume.That(() => SiteHasPoint(sites[1], 0, 0)); // #2 has Z

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 3 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 0, 300)); // #1 has A
            Assume.That(() => SiteHasPoint(sites[0], 700, 1000)); // #1 has D
            Assume.That(() => SiteHasPoint(sites[0], 0, 1000)); // #1 has X
            Assume.That(() => 6 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 0, 300)); // #2 has A
            Assume.That(() => SiteHasPoint(sites[1], 300, 0)); // #2 has B
            Assume.That(() => SiteHasPoint(sites[1], 1000, 700)); // #2 has C
            Assume.That(() => SiteHasPoint(sites[1], 700, 1000)); // #2 has D
            Assume.That(() => SiteHasPoint(sites[1], 0, 0)); // #2 has Y
            Assume.That(() => SiteHasPoint(sites[1], 1000, 1000)); // #2 has Z
            Assume.That(() => 3 == sites[2].Points.Count()); // #3
            Assume.That(() => SiteHasPoint(sites[2], 300, 0)); // #3 has B
            Assume.That(() => SiteHasPoint(sites[2], 1000, 700)); // #3 has C
            Assume.That(() => SiteHasPoint(sites[2], 1000, 0)); // #3 has W

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[2])); // 2 neighbours 3
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[1])); // 3 neighbours 2
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 3 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 300, 1000)); // #1 has A
            Assume.That(() => SiteHasPoint(sites[0], 1000, 300)); // #1 has D
            Assume.That(() => SiteHasPoint(sites[0], 1000, 1000)); // #1 has X
            Assume.That(() => 6 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 300, 1000)); // #2 has A
            Assume.That(() => SiteHasPoint(sites[1], 0, 700)); // #2 has B
            Assume.That(() => SiteHasPoint(sites[1], 700, 0)); // #2 has C
            Assume.That(() => SiteHasPoint(sites[1], 1000, 300)); // #2 has D
            Assume.That(() => SiteHasPoint(sites[1], 0, 1000)); // #2 has Y
            Assume.That(() => SiteHasPoint(sites[1], 1000, 0)); // #2 has Z
            Assume.That(() => 3 == sites[2].Points.Count()); // #3
            Assume.That(() => SiteHasPoint(sites[2], 0, 700)); // #3 has B
            Assume.That(() => SiteHasPoint(sites[2], 700, 0)); // #3 has C
            Assume.That(() => SiteHasPoint(sites[2], 0, 0)); // #3 has W

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[2])); // 2 neighbours 3
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[1])); // 3 neighbours 2
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 3 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 0, 400)); // #1 has A
            Assume.That(() => SiteHasPoint(sites[0], 600, 1000)); // #1 has D
            Assume.That(() => SiteHasPoint(sites[0], 0, 1000)); // #1 has X
            Assume.That(() => 4 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 0, 400)); // #2 has A
            Assume.That(() => SiteHasPoint(sites[1], 0, 0)); // #2 has B
            Assume.That(() => SiteHasPoint(sites[1], 1000, 1000)); // #2 has C
            Assume.That(() => SiteHasPoint(sites[1], 600, 1000)); // #2 has D
            Assume.That(() => 3 == sites[2].Points.Count()); // #3
            Assume.That(() => SiteHasPoint(sites[2], 0, 0)); // #3 has B
            Assume.That(() => SiteHasPoint(sites[2], 1000, 1000)); // #3 has C
            Assume.That(() => SiteHasPoint(sites[2], 1000, 0)); // #3 has Y

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[2])); // 2 neighbours 3
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[1])); // 3 neighbours 2
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 3 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 400, 1000)); // #1 has A
            Assume.That(() => SiteHasPoint(sites[0], 1000, 400)); // #1 has D
            Assume.That(() => SiteHasPoint(sites[0], 1000, 1000)); // #1 has X
            Assume.That(() => 4 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 400, 1000)); // #2 has A
            Assume.That(() => SiteHasPoint(sites[1], 0, 1000)); // #2 has B
            Assume.That(() => SiteHasPoint(sites[1], 1000, 0)); // #2 has C
            Assume.That(() => SiteHasPoint(sites[1], 1000, 400)); // #2 has D
            Assume.That(() => 3 == sites[2].Points.Count()); // #3
            Assume.That(() => SiteHasPoint(sites[2], 0, 1000)); // #3 has B
            Assume.That(() => SiteHasPoint(sites[2], 1000, 0)); // #3 has C
            Assume.That(() => SiteHasPoint(sites[2], 0, 0)); // #3 has Y

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[2])); // 2 neighbours 3
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[1])); // 3 neighbours 2
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 3 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 1000, 600)); // #1 has A
            Assume.That(() => SiteHasPoint(sites[0], 400, 0)); // #1 has D
            Assume.That(() => SiteHasPoint(sites[0], 1000, 0)); // #1 has X
            Assume.That(() => 4 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 1000, 600)); // #2 has A
            Assume.That(() => SiteHasPoint(sites[1], 1000, 1000)); // #2 has B
            Assume.That(() => SiteHasPoint(sites[1], 0, 0)); // #2 has C
            Assume.That(() => SiteHasPoint(sites[1], 400, 0)); // #2 has D
            Assume.That(() => 3 == sites[2].Points.Count()); // #3
            Assume.That(() => SiteHasPoint(sites[2], 1000, 1000)); // #3 has B
            Assume.That(() => SiteHasPoint(sites[2], 0, 0)); // #3 has C
            Assume.That(() => SiteHasPoint(sites[2], 0, 1000)); // #3 has Y

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[2])); // 2 neighbours 3
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[1])); // 3 neighbours 2
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 3 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 600, 0)); // #1 has A
            Assume.That(() => SiteHasPoint(sites[0], 0, 600)); // #1 has D
            Assume.That(() => SiteHasPoint(sites[0], 0, 0)); // #1 has X
            Assume.That(() => 4 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 600, 0)); // #2 has A
            Assume.That(() => SiteHasPoint(sites[1], 1000, 0)); // #2 has B
            Assume.That(() => SiteHasPoint(sites[1], 0, 1000)); // #2 has C
            Assume.That(() => SiteHasPoint(sites[1], 0, 600)); // #2 has D
            Assume.That(() => 3 == sites[2].Points.Count()); // #3
            Assume.That(() => SiteHasPoint(sites[2], 1000, 0)); // #3 has B
            Assume.That(() => SiteHasPoint(sites[2], 0, 1000)); // #3 has C
            Assume.That(() => SiteHasPoint(sites[2], 1000, 1000)); // #3 has Y

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[2])); // 2 neighbours 3
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[1])); // 3 neighbours 2
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 3 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 0, 400)); // #1 has A
            Assume.That(() => SiteHasPoint(sites[0], 600, 1000)); // #1 has F
            Assume.That(() => SiteHasPoint(sites[0], 0, 1000)); // #1 has X
            Assume.That(() => 4 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 0, 400)); // #2 has A
            Assume.That(() => SiteHasPoint(sites[1], 0, 0)); // #2 has B
            Assume.That(() => SiteHasPoint(sites[1], 1000, 1000)); // #2 has E
            Assume.That(() => SiteHasPoint(sites[1], 600, 1000)); // #2 has F
            Assume.That(() => 4 == sites[2].Points.Count()); // #3
            Assume.That(() => SiteHasPoint(sites[2], 0, 0)); // #3 has B
            Assume.That(() => SiteHasPoint(sites[2], 400, 0)); // #3 has C
            Assume.That(() => SiteHasPoint(sites[2], 1000, 600)); // #3 has D
            Assume.That(() => SiteHasPoint(sites[2], 1000, 1000)); // #3 has E
            Assume.That(() => 3 == sites[3].Points.Count()); // #4
            Assume.That(() => SiteHasPoint(sites[3], 400, 0)); // #4 has C
            Assume.That(() => SiteHasPoint(sites[3], 1000, 600)); // #4 has D
            Assume.That(() => SiteHasPoint(sites[3], 1000, 0)); // #4 has Y

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[2])); // 2 neighbours 3
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[1])); // 3 neighbours 2
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[3])); // 3 neighbours 4
            Assert.IsTrue(sites[3].Neighbours.Contains(sites[2])); // 4 neighbours 3
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 3 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 400, 1000)); // #1 has A
            Assume.That(() => SiteHasPoint(sites[0], 1000, 400)); // #1 has F
            Assume.That(() => SiteHasPoint(sites[0], 1000, 1000)); // #1 has X
            Assume.That(() => 4 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 400, 1000)); // #2 has A
            Assume.That(() => SiteHasPoint(sites[1], 0, 1000)); // #2 has B
            Assume.That(() => SiteHasPoint(sites[1], 1000, 0)); // #2 has E
            Assume.That(() => SiteHasPoint(sites[1], 1000, 400)); // #2 has F
            Assume.That(() => 4 == sites[2].Points.Count()); // #3
            Assume.That(() => SiteHasPoint(sites[2], 0, 1000)); // #3 has B
            Assume.That(() => SiteHasPoint(sites[2], 0, 600)); // #3 has C
            Assume.That(() => SiteHasPoint(sites[2], 600, 0)); // #3 has D
            Assume.That(() => SiteHasPoint(sites[2], 1000, 0)); // #3 has E
            Assume.That(() => 3 == sites[3].Points.Count()); // #4
            Assume.That(() => SiteHasPoint(sites[3], 0, 600)); // #4 has C
            Assume.That(() => SiteHasPoint(sites[3], 600, 0)); // #4 has D
            Assume.That(() => SiteHasPoint(sites[3], 0, 0)); // #4 has Y

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[2])); // 2 neighbours 3
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[1])); // 3 neighbours 2
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[3])); // 3 neighbours 4
            Assert.IsTrue(sites[3].Neighbours.Contains(sites[2])); // 4 neighbours 3
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 4 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 400, 400)); // #1 has A
            Assume.That(() => SiteHasPoint(sites[0], 0, 400)); // #1 has B
            Assume.That(() => SiteHasPoint(sites[0], 1000, 1000)); // #1 has D
            Assume.That(() => SiteHasPoint(sites[0], 0, 1000)); // #1 has X
            Assume.That(() => 4 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 400, 400)); // #2 has A
            Assume.That(() => SiteHasPoint(sites[1], 0, 400)); // #2 has B
            Assume.That(() => SiteHasPoint(sites[1], 400, 0)); // #2 has C
            Assume.That(() => SiteHasPoint(sites[1], 0, 0)); // #2 has Y
            Assume.That(() => 4 == sites[2].Points.Count()); // #3
            Assume.That(() => SiteHasPoint(sites[2], 400, 400)); // #3 has A
            Assume.That(() => SiteHasPoint(sites[2], 400, 0)); // #3 has C
            Assume.That(() => SiteHasPoint(sites[2], 1000, 1000)); // #3 has D
            Assume.That(() => SiteHasPoint(sites[2], 1000, 0)); // #3 has W

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[0].Neighbours.Contains(sites[2])); // 1 neighbours 3
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[2])); // 2 neighbours 3
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[0])); // 3 neighbours 1
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[1])); // 3 neighbours 2
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 4 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 400, 600)); // #1 has A
            Assume.That(() => SiteHasPoint(sites[0], 400, 1000)); // #1 has B
            Assume.That(() => SiteHasPoint(sites[0], 1000, 0)); // #1 has D
            Assume.That(() => SiteHasPoint(sites[0], 1000, 1000)); // #1 has X
            Assume.That(() => 4 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 400, 600)); // #2 has A
            Assume.That(() => SiteHasPoint(sites[1], 400, 1000)); // #2 has B
            Assume.That(() => SiteHasPoint(sites[1], 0, 600)); // #2 has C
            Assume.That(() => SiteHasPoint(sites[1], 0, 1000)); // #2 has Y
            Assume.That(() => 4 == sites[2].Points.Count()); // #3
            Assume.That(() => SiteHasPoint(sites[2], 400, 600)); // #3 has A
            Assume.That(() => SiteHasPoint(sites[2], 0, 600)); // #3 has C
            Assume.That(() => SiteHasPoint(sites[2], 1000, 0)); // #3 has D
            Assume.That(() => SiteHasPoint(sites[2], 0, 0)); // #3 has W

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[0].Neighbours.Contains(sites[2])); // 1 neighbours 3
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[2])); // 2 neighbours 3
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[0])); // 3 neighbours 1
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[1])); // 3 neighbours 2
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 4 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 600, 600)); // #1 has A
            Assume.That(() => SiteHasPoint(sites[0], 1000, 600)); // #1 has B
            Assume.That(() => SiteHasPoint(sites[0], 0, 0)); // #1 has D
            Assume.That(() => SiteHasPoint(sites[0], 1000, 0)); // #1 has X
            Assume.That(() => 4 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 600, 600)); // #2 has A
            Assume.That(() => SiteHasPoint(sites[1], 1000, 600)); // #2 has B
            Assume.That(() => SiteHasPoint(sites[1], 600, 1000)); // #2 has C
            Assume.That(() => SiteHasPoint(sites[1], 1000, 1000)); // #2 has Y
            Assume.That(() => 4 == sites[2].Points.Count()); // #3
            Assume.That(() => SiteHasPoint(sites[2], 600, 600)); // #3 has A
            Assume.That(() => SiteHasPoint(sites[2], 600, 1000)); // #3 has C
            Assume.That(() => SiteHasPoint(sites[2], 0, 0)); // #3 has D
            Assume.That(() => SiteHasPoint(sites[2], 0, 1000)); // #3 has W

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[0].Neighbours.Contains(sites[2])); // 1 neighbours 3
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[2])); // 2 neighbours 3
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[0])); // 3 neighbours 1
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[1])); // 3 neighbours 2
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 4 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 600, 400)); // #1 has A
            Assume.That(() => SiteHasPoint(sites[0], 600, 0)); // #1 has B
            Assume.That(() => SiteHasPoint(sites[0], 0, 1000)); // #1 has D
            Assume.That(() => SiteHasPoint(sites[0], 0, 0)); // #1 has X
            Assume.That(() => 4 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 600, 400)); // #2 has A
            Assume.That(() => SiteHasPoint(sites[1], 600, 0)); // #2 has B
            Assume.That(() => SiteHasPoint(sites[1], 1000, 400)); // #2 has C
            Assume.That(() => SiteHasPoint(sites[1], 1000, 0)); // #2 has Y
            Assume.That(() => 4 == sites[2].Points.Count()); // #3
            Assume.That(() => SiteHasPoint(sites[2], 600, 400)); // #3 has A
            Assume.That(() => SiteHasPoint(sites[2], 1000, 400)); // #3 has C
            Assume.That(() => SiteHasPoint(sites[2], 0, 1000)); // #3 has D
            Assume.That(() => SiteHasPoint(sites[2], 1000, 1000)); // #3 has W

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[0].Neighbours.Contains(sites[2])); // 1 neighbours 3
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[2])); // 2 neighbours 3
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[0])); // 3 neighbours 1
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[1])); // 3 neighbours 2
        }

        [Test]
        public void ThreePointsInAWedgeTowardsCornerOffset()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(100, 800), // #1
                new VoronoiSite(100, 400), // #2
                new VoronoiSite(500, 400), // #3
            };

            // 1000 X---------------------------------#D--------------Z
            //      |                               ,'                |
            //  900 |                            ,·'                  |
            //      |                          ,'                     |
            //  800 |    1                  ,·'                       |
            //      |                     ,'                          |
            //  700 |                  ,·'                            |
            //      |                ,'                               |
            //  600 B--------------A'                                 |
            //      |              |                                  |
            //  500 |              |                                  |
            //      |              |                                  |
            //  400 |    2         |         3                        |
            //      |              |                                  |
            //  300 |              |                                  |
            //      |              |                                  |
            //  200 |              |                                  |
            //      |              |                                  |
            //  100 |              |                                  |
            //      |              |                                  |
            //    0 Y--------------C----------------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 4 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 300, 600)); // #1 has A
            Assume.That(() => SiteHasPoint(sites[0], 0, 600)); // #1 has B
            Assume.That(() => SiteHasPoint(sites[0], 700, 1000)); // #1 has D
            Assume.That(() => SiteHasPoint(sites[0], 0, 1000)); // #1 has X
            Assume.That(() => 4 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 300, 600)); // #2 has A
            Assume.That(() => SiteHasPoint(sites[1], 0, 600)); // #2 has B
            Assume.That(() => SiteHasPoint(sites[1], 300, 0)); // #2 has C
            Assume.That(() => SiteHasPoint(sites[1], 0, 0)); // #2 has Y
            Assume.That(() => 5 == sites[2].Points.Count()); // #3
            Assume.That(() => SiteHasPoint(sites[2], 300, 600)); // #3 has A
            Assume.That(() => SiteHasPoint(sites[2], 300, 0)); // #3 has C
            Assume.That(() => SiteHasPoint(sites[2], 700, 1000)); // #3 has D
            Assume.That(() => SiteHasPoint(sites[2], 1000, 0)); // #3 has W
            Assume.That(() => SiteHasPoint(sites[2], 1000, 1000)); // #3 has Z

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[0].Neighbours.Contains(sites[2])); // 1 neighbours 3
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[2])); // 2 neighbours 3
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[0])); // 3 neighbours 1
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[1])); // 3 neighbours 2
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeTowardsCornerOffset"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeTowardsCornerOffset_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(800, 900), // #1
                new VoronoiSite(400, 900), // #2
                new VoronoiSite(400, 500), // #3
            };

            // 1000 Y-----------------------------B-------------------X
            //      |                             |                   |
            //  900 |                   2         |         1         |
            //      |                             |                   |
            //  800 |                             |                   |
            //      |                             |                   |
            //  700 C-----------------------------A,                  |
            //      |                               ',                |
            //  600 |                                 '·,             |
            //      |                                    ',           |
            //  500 |                   3                  '·,        |
            //      |                                         ',      |
            //  400 |                                           '·,   |
            //      |                                              ', |
            //  300 |                                                'D
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 W-------------------------------------------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 4 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 600, 700)); // #1 has A
            Assume.That(() => SiteHasPoint(sites[0], 600, 1000)); // #1 has B
            Assume.That(() => SiteHasPoint(sites[0], 1000, 300)); // #1 has D
            Assume.That(() => SiteHasPoint(sites[0], 1000, 1000)); // #1 has X
            Assume.That(() => 4 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 600, 700)); // #2 has A
            Assume.That(() => SiteHasPoint(sites[1], 600, 1000)); // #2 has B
            Assume.That(() => SiteHasPoint(sites[1], 0, 700)); // #2 has C
            Assume.That(() => SiteHasPoint(sites[1], 0, 1000)); // #2 has Y
            Assume.That(() => 5 == sites[2].Points.Count()); // #3
            Assume.That(() => SiteHasPoint(sites[2], 600, 700)); // #3 has A
            Assume.That(() => SiteHasPoint(sites[2], 0, 700)); // #3 has C
            Assume.That(() => SiteHasPoint(sites[2], 1000, 300)); // #3 has D
            Assume.That(() => SiteHasPoint(sites[2], 0, 0)); // #3 has W
            Assume.That(() => SiteHasPoint(sites[2], 1000, 0)); // #3 has Z

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[0].Neighbours.Contains(sites[2])); // 1 neighbours 3
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[2])); // 2 neighbours 3
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[0])); // 3 neighbours 1
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[1])); // 3 neighbours 2
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeTowardsCornerOffset"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeTowardsCornerOffset_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(900, 200), // #1
                new VoronoiSite(900, 600), // #2
                new VoronoiSite(500, 600), // #3
            };

            // 1000 W----------------------------------C--------------Y
            //      |                                  |              |
            //  900 |                                  |              |
            //      |                                  |              |
            //  800 |                                  |              |
            //      |                                  |              |
            //  700 |                                  |              |
            //      |                                  |              |
            //  600 |                        3         |         2    |
            //      |                                  |              |
            //  500 |                                  |              |
            //      |                                  |              |
            //  400 |                                 ,A--------------B
            //      |                               ,'                |
            //  300 |                            ,·'                  |
            //      |                          ,'                     |
            //  200 |                       ,·'                  1    |
            //      |                     ,'                          |
            //  100 |                  ,·'                            |
            //      |                ,'                               |
            //    0 Z--------------D#---------------------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 4 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 700, 400)); // #1 has A
            Assume.That(() => SiteHasPoint(sites[0], 1000, 400)); // #1 has B
            Assume.That(() => SiteHasPoint(sites[0], 300, 0)); // #1 has D
            Assume.That(() => SiteHasPoint(sites[0], 1000, 0)); // #1 has X
            Assume.That(() => 4 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 700, 400)); // #2 has A
            Assume.That(() => SiteHasPoint(sites[1], 1000, 400)); // #2 has B
            Assume.That(() => SiteHasPoint(sites[1], 700, 1000)); // #2 has C
            Assume.That(() => SiteHasPoint(sites[1], 1000, 1000)); // #2 has Y
            Assume.That(() => 5 == sites[2].Points.Count()); // #3
            Assume.That(() => SiteHasPoint(sites[2], 700, 400)); // #3 has A
            Assume.That(() => SiteHasPoint(sites[2], 700, 1000)); // #3 has C
            Assume.That(() => SiteHasPoint(sites[2], 300, 0)); // #3 has D
            Assume.That(() => SiteHasPoint(sites[2], 0, 1000)); // #3 has W
            Assume.That(() => SiteHasPoint(sites[2], 0, 0)); // #3 has Z

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[0].Neighbours.Contains(sites[2])); // 1 neighbours 3
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[2])); // 2 neighbours 3
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[0])); // 3 neighbours 1
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[1])); // 3 neighbours 2
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeTowardsCornerOffset"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeTowardsCornerOffset_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(200, 100), // #1
                new VoronoiSite(600, 100), // #2
                new VoronoiSite(600, 500), // #3
            };

            // 1000 Z-------------------------------------------------W
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 D,                                                |
            //      | ',                                              |
            //  600 |   '·,                                           |
            //      |      ',                                         |
            //  500 |        '·,                  3                   |
            //      |           ',                                    |
            //  400 |             '·,                                 |
            //      |                ',                               |
            //  300 |                  'A-----------------------------C
            //      |                   |                             |
            //  200 |                   |                             |
            //      |                   |                             |
            //  100 |         1         |         2                   |
            //      |                   |                             |
            //    0 X-------------------B-----------------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 4 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 400, 300)); // #1 has A
            Assume.That(() => SiteHasPoint(sites[0], 400, 0)); // #1 has B
            Assume.That(() => SiteHasPoint(sites[0], 0, 700)); // #1 has D
            Assume.That(() => SiteHasPoint(sites[0], 0, 0)); // #1 has X
            Assume.That(() => 4 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 400, 300)); // #2 has A
            Assume.That(() => SiteHasPoint(sites[1], 400, 0)); // #2 has B
            Assume.That(() => SiteHasPoint(sites[1], 1000, 300)); // #2 has C
            Assume.That(() => SiteHasPoint(sites[1], 1000, 0)); // #2 has Y
            Assume.That(() => 5 == sites[2].Points.Count()); // #3
            Assume.That(() => SiteHasPoint(sites[2], 400, 300)); // #3 has A
            Assume.That(() => SiteHasPoint(sites[2], 1000, 300)); // #3 has C
            Assume.That(() => SiteHasPoint(sites[2], 0, 700)); // #3 has D
            Assume.That(() => SiteHasPoint(sites[2], 1000, 1000)); // #3 has W
            Assume.That(() => SiteHasPoint(sites[2], 0, 1000)); // #3 has Z

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[0].Neighbours.Contains(sites[2])); // 1 neighbours 3
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[2])); // 2 neighbours 3
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[0])); // 3 neighbours 1
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[1])); // 3 neighbours 2
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeTowardsCornerOffset"/> above,
        /// but all coordinates are mirrored horizontally.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeTowardsCornerOffset_Mirrored()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(900, 800), // #1
                new VoronoiSite(900, 400), // #2
                new VoronoiSite(500, 400), // #3
            };

            // 1000 Z--------------D#---------------------------------X
            //      |                ',                               |
            //  900 |                  '·,                            |
            //      |                     ',                          |
            //  800 |                       '·,                  1    |
            //      |                          ',                     |
            //  700 |                            '·,                  |
            //      |                               ',                |
            //  600 |                                 'A--------------B
            //      |                                  |              |
            //  500 |                                  |              |
            //      |                                  |              |
            //  400 |                        3         |         2    |
            //      |                                  |              |
            //  300 |                                  |              |
            //      |                                  |              |
            //  200 |                                  |              |
            //      |                                  |              |
            //  100 |                                  |              |
            //      |                                  |              |
            //    0 W----------------------------------C--------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 4 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 700, 600)); // #1 has A
            Assume.That(() => SiteHasPoint(sites[0], 1000, 600)); // #1 has B
            Assume.That(() => SiteHasPoint(sites[0], 300, 1000)); // #1 has D
            Assume.That(() => SiteHasPoint(sites[0], 1000, 1000)); // #1 has X
            Assume.That(() => 4 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 700, 600)); // #2 has A
            Assume.That(() => SiteHasPoint(sites[1], 1000, 600)); // #2 has B
            Assume.That(() => SiteHasPoint(sites[1], 700, 0)); // #2 has C
            Assume.That(() => SiteHasPoint(sites[1], 1000, 0)); // #2 has Y
            Assume.That(() => 5 == sites[2].Points.Count()); // #3
            Assume.That(() => SiteHasPoint(sites[2], 700, 600)); // #3 has A
            Assume.That(() => SiteHasPoint(sites[2], 700, 0)); // #3 has C
            Assume.That(() => SiteHasPoint(sites[2], 300, 1000)); // #3 has D
            Assume.That(() => SiteHasPoint(sites[2], 0, 0)); // #3 has W
            Assume.That(() => SiteHasPoint(sites[2], 0, 1000)); // #3 has Z

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[0].Neighbours.Contains(sites[2])); // 1 neighbours 3
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[2])); // 2 neighbours 3
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[0])); // 3 neighbours 1
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[1])); // 3 neighbours 2
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeTowardsCornerOffset"/> above,
        /// but all coordinates are mirrored horizontally and then rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeTowardsCornerOffset_MirroredAndRotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(800, 100), // #1
                new VoronoiSite(400, 100), // #2
                new VoronoiSite(400, 500), // #3
            };

            // 1000 W-------------------------------------------------Z
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                                                ,D
            //      |                                              ,' |
            //  600 |                                           ,·'   |
            //      |                                         ,'      |
            //  500 |                   3                  ,·'        |
            //      |                                    ,'           |
            //  400 |                                 ,·'             |
            //      |                               ,'                |
            //  300 C-----------------------------A'                  |
            //      |                             |                   |
            //  200 |                             |                   |
            //      |                             |                   |
            //  100 |                   2         |         1         |
            //      |                             |                   |
            //    0 Y-----------------------------B-------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 4 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 600, 300)); // #1 has A
            Assume.That(() => SiteHasPoint(sites[0], 600, 0)); // #1 has B
            Assume.That(() => SiteHasPoint(sites[0], 1000, 700)); // #1 has D
            Assume.That(() => SiteHasPoint(sites[0], 1000, 0)); // #1 has X
            Assume.That(() => 4 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 600, 300)); // #2 has A
            Assume.That(() => SiteHasPoint(sites[1], 600, 0)); // #2 has B
            Assume.That(() => SiteHasPoint(sites[1], 0, 300)); // #2 has C
            Assume.That(() => SiteHasPoint(sites[1], 0, 0)); // #2 has Y
            Assume.That(() => 5 == sites[2].Points.Count()); // #3
            Assume.That(() => SiteHasPoint(sites[2], 600, 300)); // #3 has A
            Assume.That(() => SiteHasPoint(sites[2], 0, 300)); // #3 has C
            Assume.That(() => SiteHasPoint(sites[2], 1000, 700)); // #3 has D
            Assume.That(() => SiteHasPoint(sites[2], 0, 1000)); // #3 has W
            Assume.That(() => SiteHasPoint(sites[2], 1000, 1000)); // #3 has Z

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[0].Neighbours.Contains(sites[2])); // 1 neighbours 3
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[2])); // 2 neighbours 3
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[0])); // 3 neighbours 1
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[1])); // 3 neighbours 2
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeTowardsCornerOffset"/> above,
        /// but all coordinates are mirrored horizontally and then rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeTowardsCornerOffset_MirroredAndRotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(100, 200), // #1
                new VoronoiSite(100, 600), // #2
                new VoronoiSite(500, 600), // #3
            };

            // 1000 Y--------------C----------------------------------W
            //      |              |                                  |
            //  900 |              |                                  |
            //      |              |                                  |
            //  800 |              |                                  |
            //      |              |                                  |
            //  700 |              |                                  |
            //      |              |                                  |
            //  600 |    2         |         3                        |
            //      |              |                                  |
            //  500 |              |                                  |
            //      |              |                                  |
            //  400 B--------------A,                                 |
            //      |                ',                               |
            //  300 |                  '·,                            |
            //      |                     ',                          |
            //  200 |    1                  '·,                       |
            //      |                          ',                     |
            //  100 |                            '·,                  |
            //      |                               ',                |
            //    0 X---------------------------------#D--------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 4 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 300, 400)); // #1 has A
            Assume.That(() => SiteHasPoint(sites[0], 0, 400)); // #1 has B
            Assume.That(() => SiteHasPoint(sites[0], 700, 0)); // #1 has D
            Assume.That(() => SiteHasPoint(sites[0], 0, 0)); // #1 has X
            Assume.That(() => 4 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 300, 400)); // #2 has A
            Assume.That(() => SiteHasPoint(sites[1], 0, 400)); // #2 has B
            Assume.That(() => SiteHasPoint(sites[1], 300, 1000)); // #2 has C
            Assume.That(() => SiteHasPoint(sites[1], 0, 1000)); // #2 has Y
            Assume.That(() => 5 == sites[2].Points.Count()); // #3
            Assume.That(() => SiteHasPoint(sites[2], 300, 400)); // #3 has A
            Assume.That(() => SiteHasPoint(sites[2], 300, 1000)); // #3 has C
            Assume.That(() => SiteHasPoint(sites[2], 700, 0)); // #3 has D
            Assume.That(() => SiteHasPoint(sites[2], 1000, 1000)); // #3 has W
            Assume.That(() => SiteHasPoint(sites[2], 1000, 0)); // #3 has Z

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[0].Neighbours.Contains(sites[2])); // 1 neighbours 3
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[2])); // 2 neighbours 3
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[0])); // 3 neighbours 1
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[1])); // 3 neighbours 2
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeTowardsCornerOffset"/> above,
        /// but all coordinates are mirrored horizontally and then rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeTowardsCornerOffset_MirroredAndRotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(200, 900), // #1
                new VoronoiSite(600, 900), // #2
                new VoronoiSite(600, 500), // #3
            };

            // 1000 X-------------------B-----------------------------Y
            //      |                   |                             |
            //  900 |         1         |         2                   |
            //      |                   |                             |
            //  800 |                   |                             |
            //      |                   |                             |
            //  700 |                  ,A-----------------------------C
            //      |                ,'                               |
            //  600 |             ,·'                                 |
            //      |           ,'                                    |
            //  500 |        ,·'                  3                   |
            //      |      ,'                                         |
            //  400 |   ,·'                                           |
            //      | ,'                                              |
            //  300 D'                                                |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 Z-------------------------------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 4 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 400, 700)); // #1 has A
            Assume.That(() => SiteHasPoint(sites[0], 400, 1000)); // #1 has B
            Assume.That(() => SiteHasPoint(sites[0], 0, 300)); // #1 has D
            Assume.That(() => SiteHasPoint(sites[0], 0, 1000)); // #1 has X
            Assume.That(() => 4 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 400, 700)); // #2 has A
            Assume.That(() => SiteHasPoint(sites[1], 400, 1000)); // #2 has B
            Assume.That(() => SiteHasPoint(sites[1], 1000, 700)); // #2 has C
            Assume.That(() => SiteHasPoint(sites[1], 1000, 1000)); // #2 has Y
            Assume.That(() => 5 == sites[2].Points.Count()); // #3
            Assume.That(() => SiteHasPoint(sites[2], 400, 700)); // #3 has A
            Assume.That(() => SiteHasPoint(sites[2], 1000, 700)); // #3 has C
            Assume.That(() => SiteHasPoint(sites[2], 0, 300)); // #3 has D
            Assume.That(() => SiteHasPoint(sites[2], 1000, 0)); // #3 has W
            Assume.That(() => SiteHasPoint(sites[2], 0, 0)); // #3 has Z

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[0].Neighbours.Contains(sites[2])); // 1 neighbours 3
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[2])); // 2 neighbours 3
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[0])); // 3 neighbours 1
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[1])); // 3 neighbours 2
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 3 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 500, 500)); // #1 has A
            Assume.That(() => SiteHasPoint(sites[0], 0, 0)); // #1 has B
            Assume.That(() => SiteHasPoint(sites[0], 1000, 0)); // #1 has C
            Assume.That(() => 4 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 500, 500)); // #2 has A
            Assume.That(() => SiteHasPoint(sites[1], 1000, 0)); // #2 has C
            Assume.That(() => SiteHasPoint(sites[1], 500, 1000)); // #2 has D
            Assume.That(() => SiteHasPoint(sites[1], 1000, 1000)); // #2 has Y
            Assume.That(() => 4 == sites[2].Points.Count()); // #3
            Assume.That(() => SiteHasPoint(sites[2], 500, 500)); // #3 has A
            Assume.That(() => SiteHasPoint(sites[2], 0, 0)); // #3 has B
            Assume.That(() => SiteHasPoint(sites[2], 500, 1000)); // #3 has D
            Assume.That(() => SiteHasPoint(sites[2], 0, 1000)); // #3 has X

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[0].Neighbours.Contains(sites[2])); // 1 neighbours 3
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[2])); // 2 neighbours 3
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[0])); // 3 neighbours 1
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[1])); // 3 neighbours 2
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 3 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 500, 500)); // #1 has A
            Assume.That(() => SiteHasPoint(sites[0], 0, 1000)); // #1 has B
            Assume.That(() => SiteHasPoint(sites[0], 0, 0)); // #1 has C
            Assume.That(() => 4 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 500, 500)); // #2 has A
            Assume.That(() => SiteHasPoint(sites[1], 0, 0)); // #2 has C
            Assume.That(() => SiteHasPoint(sites[1], 1000, 500)); // #2 has D
            Assume.That(() => SiteHasPoint(sites[1], 1000, 0)); // #2 has Y
            Assume.That(() => 4 == sites[2].Points.Count()); // #3
            Assume.That(() => SiteHasPoint(sites[2], 500, 500)); // #3 has A
            Assume.That(() => SiteHasPoint(sites[2], 0, 1000)); // #3 has B
            Assume.That(() => SiteHasPoint(sites[2], 1000, 500)); // #3 has D
            Assume.That(() => SiteHasPoint(sites[2], 1000, 1000)); // #3 has X

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[0].Neighbours.Contains(sites[2])); // 1 neighbours 3
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[2])); // 2 neighbours 3
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[0])); // 3 neighbours 1
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[1])); // 3 neighbours 2
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 3 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 500, 500)); // #1 has A
            Assume.That(() => SiteHasPoint(sites[0], 1000, 1000)); // #1 has B
            Assume.That(() => SiteHasPoint(sites[0], 0, 1000)); // #1 has C
            Assume.That(() => 4 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 500, 500)); // #2 has A
            Assume.That(() => SiteHasPoint(sites[1], 0, 1000)); // #2 has C
            Assume.That(() => SiteHasPoint(sites[1], 500, 0)); // #2 has D
            Assume.That(() => SiteHasPoint(sites[1], 0, 0)); // #2 has Y
            Assume.That(() => 4 == sites[2].Points.Count()); // #3
            Assume.That(() => SiteHasPoint(sites[2], 500, 500)); // #3 has A
            Assume.That(() => SiteHasPoint(sites[2], 1000, 1000)); // #3 has B
            Assume.That(() => SiteHasPoint(sites[2], 500, 0)); // #3 has D
            Assume.That(() => SiteHasPoint(sites[2], 1000, 0)); // #3 has X

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[0].Neighbours.Contains(sites[2])); // 1 neighbours 3
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[2])); // 2 neighbours 3
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[0])); // 3 neighbours 1
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[1])); // 3 neighbours 2
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 3 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 500, 500)); // #1 has A
            Assume.That(() => SiteHasPoint(sites[0], 1000, 0)); // #1 has B
            Assume.That(() => SiteHasPoint(sites[0], 1000, 1000)); // #1 has C
            Assume.That(() => 4 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 500, 500)); // #2 has A
            Assume.That(() => SiteHasPoint(sites[1], 1000, 1000)); // #2 has C
            Assume.That(() => SiteHasPoint(sites[1], 0, 500)); // #2 has D
            Assume.That(() => SiteHasPoint(sites[1], 0, 1000)); // #2 has Y
            Assume.That(() => 4 == sites[2].Points.Count()); // #3
            Assume.That(() => SiteHasPoint(sites[2], 500, 500)); // #3 has A
            Assume.That(() => SiteHasPoint(sites[2], 1000, 0)); // #3 has B
            Assume.That(() => SiteHasPoint(sites[2], 0, 500)); // #3 has D
            Assume.That(() => SiteHasPoint(sites[2], 0, 0)); // #3 has X

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[0].Neighbours.Contains(sites[2])); // 1 neighbours 3
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[2])); // 2 neighbours 3
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[0])); // 3 neighbours 1
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[1])); // 3 neighbours 2
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 3 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 500, 300)); // #1 has A
            Assume.That(() => SiteHasPoint(sites[0], 200, 0)); // #1 has B
            Assume.That(() => SiteHasPoint(sites[0], 800, 0)); // #1 has C
            Assume.That(() => 5 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 500, 300)); // #2 has A
            Assume.That(() => SiteHasPoint(sites[1], 800, 0)); // #2 has C
            Assume.That(() => SiteHasPoint(sites[1], 500, 1000)); // #2 has D
            Assume.That(() => SiteHasPoint(sites[1], 1000, 0)); // #2 has W
            Assume.That(() => SiteHasPoint(sites[1], 1000, 1000)); // #2 has Z
            Assume.That(() => 5 == sites[2].Points.Count()); // #3
            Assume.That(() => SiteHasPoint(sites[2], 500, 300)); // #3 has A
            Assume.That(() => SiteHasPoint(sites[2], 200, 0)); // #3 has B
            Assume.That(() => SiteHasPoint(sites[2], 500, 1000)); // #3 has D
            Assume.That(() => SiteHasPoint(sites[2], 0, 1000)); // #3 has X
            Assume.That(() => SiteHasPoint(sites[2], 0, 0)); // #3 has Y

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[0].Neighbours.Contains(sites[2])); // 1 neighbours 3
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[2])); // 2 neighbours 3
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[0])); // 3 neighbours 1
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[1])); // 3 neighbours 2
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 3 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 300, 500)); // #1 has A
            Assume.That(() => SiteHasPoint(sites[0], 0, 800)); // #1 has B
            Assume.That(() => SiteHasPoint(sites[0], 0, 200)); // #1 has C
            Assume.That(() => 5 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 300, 500)); // #2 has A
            Assume.That(() => SiteHasPoint(sites[1], 0, 200)); // #2 has C
            Assume.That(() => SiteHasPoint(sites[1], 1000, 500)); // #2 has D
            Assume.That(() => SiteHasPoint(sites[1], 0, 0)); // #2 has W
            Assume.That(() => SiteHasPoint(sites[1], 1000, 0)); // #2 has Z
            Assume.That(() => 5 == sites[2].Points.Count()); // #3
            Assume.That(() => SiteHasPoint(sites[2], 300, 500)); // #3 has A
            Assume.That(() => SiteHasPoint(sites[2], 0, 800)); // #3 has B
            Assume.That(() => SiteHasPoint(sites[2], 1000, 500)); // #3 has D
            Assume.That(() => SiteHasPoint(sites[2], 1000, 1000)); // #3 has X
            Assume.That(() => SiteHasPoint(sites[2], 0, 1000)); // #3 has Y

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[0].Neighbours.Contains(sites[2])); // 1 neighbours 3
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[2])); // 2 neighbours 3
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[0])); // 3 neighbours 1
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[1])); // 3 neighbours 2
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 3 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 500, 700)); // #1 has A
            Assume.That(() => SiteHasPoint(sites[0], 800, 1000)); // #1 has B
            Assume.That(() => SiteHasPoint(sites[0], 200, 1000)); // #1 has C
            Assume.That(() => 5 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 500, 700)); // #2 has A
            Assume.That(() => SiteHasPoint(sites[1], 200, 1000)); // #2 has C
            Assume.That(() => SiteHasPoint(sites[1], 500, 0)); // #2 has D
            Assume.That(() => SiteHasPoint(sites[1], 0, 1000)); // #2 has W
            Assume.That(() => SiteHasPoint(sites[1], 0, 0)); // #2 has Z
            Assume.That(() => 5 == sites[2].Points.Count()); // #3
            Assume.That(() => SiteHasPoint(sites[2], 500, 700)); // #3 has A
            Assume.That(() => SiteHasPoint(sites[2], 800, 1000)); // #3 has B
            Assume.That(() => SiteHasPoint(sites[2], 500, 0)); // #3 has D
            Assume.That(() => SiteHasPoint(sites[2], 1000, 0)); // #3 has X
            Assume.That(() => SiteHasPoint(sites[2], 1000, 1000)); // #3 has Y

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[0].Neighbours.Contains(sites[2])); // 1 neighbours 3
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[2])); // 2 neighbours 3
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[0])); // 3 neighbours 1
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[1])); // 3 neighbours 2
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 3 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 700, 500)); // #1 has A
            Assume.That(() => SiteHasPoint(sites[0], 1000, 200)); // #1 has B
            Assume.That(() => SiteHasPoint(sites[0], 1000, 800)); // #1 has C
            Assume.That(() => 5 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 700, 500)); // #2 has A
            Assume.That(() => SiteHasPoint(sites[1], 1000, 800)); // #2 has C
            Assume.That(() => SiteHasPoint(sites[1], 0, 500)); // #2 has D
            Assume.That(() => SiteHasPoint(sites[1], 1000, 1000)); // #2 has W
            Assume.That(() => SiteHasPoint(sites[1], 0, 1000)); // #2 has Z
            Assume.That(() => 5 == sites[2].Points.Count()); // #3
            Assume.That(() => SiteHasPoint(sites[2], 700, 500)); // #3 has A
            Assume.That(() => SiteHasPoint(sites[2], 1000, 200)); // #3 has B
            Assume.That(() => SiteHasPoint(sites[2], 0, 500)); // #3 has D
            Assume.That(() => SiteHasPoint(sites[2], 0, 0)); // #3 has X
            Assume.That(() => SiteHasPoint(sites[2], 1000, 0)); // #3 has Y

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[0].Neighbours.Contains(sites[2])); // 1 neighbours 3
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[2])); // 2 neighbours 3
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[0])); // 3 neighbours 1
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[1])); // 3 neighbours 2
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 5 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 500, 700)); // #1 has A
            Assume.That(() => SiteHasPoint(sites[0], 0, 200)); // #1 has B
            Assume.That(() => SiteHasPoint(sites[0], 1000, 200)); // #1 has C
            Assume.That(() => SiteHasPoint(sites[0], 1000, 0)); // #1 has W
            Assume.That(() => SiteHasPoint(sites[0], 0, 0)); // #1 has Y
            Assume.That(() => 4 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 500, 700)); // #2 has A
            Assume.That(() => SiteHasPoint(sites[1], 1000, 200)); // #2 has C
            Assume.That(() => SiteHasPoint(sites[1], 500, 1000)); // #2 has D
            Assume.That(() => SiteHasPoint(sites[1], 1000, 1000)); // #2 has Z
            Assume.That(() => 4 == sites[2].Points.Count()); // #3
            Assume.That(() => SiteHasPoint(sites[2], 500, 700)); // #3 has A
            Assume.That(() => SiteHasPoint(sites[2], 0, 200)); // #3 has B
            Assume.That(() => SiteHasPoint(sites[2], 500, 1000)); // #3 has D
            Assume.That(() => SiteHasPoint(sites[2], 0, 1000)); // #3 has X

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[0].Neighbours.Contains(sites[2])); // 1 neighbours 3
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[2])); // 2 neighbours 3
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[0])); // 3 neighbours 1
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[1])); // 3 neighbours 2
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 5 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 700, 500)); // #1 has A
            Assume.That(() => SiteHasPoint(sites[0], 200, 1000)); // #1 has B
            Assume.That(() => SiteHasPoint(sites[0], 200, 0)); // #1 has C
            Assume.That(() => SiteHasPoint(sites[0], 0, 0)); // #1 has W
            Assume.That(() => SiteHasPoint(sites[0], 0, 1000)); // #1 has Y
            Assume.That(() => 4 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 700, 500)); // #2 has A
            Assume.That(() => SiteHasPoint(sites[1], 200, 0)); // #2 has C
            Assume.That(() => SiteHasPoint(sites[1], 1000, 500)); // #2 has D
            Assume.That(() => SiteHasPoint(sites[1], 1000, 0)); // #2 has Z
            Assume.That(() => 4 == sites[2].Points.Count()); // #3
            Assume.That(() => SiteHasPoint(sites[2], 700, 500)); // #3 has A
            Assume.That(() => SiteHasPoint(sites[2], 200, 1000)); // #3 has B
            Assume.That(() => SiteHasPoint(sites[2], 1000, 500)); // #3 has D
            Assume.That(() => SiteHasPoint(sites[2], 1000, 1000)); // #3 has X

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[0].Neighbours.Contains(sites[2])); // 1 neighbours 3
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[2])); // 2 neighbours 3
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[0])); // 3 neighbours 1
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[1])); // 3 neighbours 2
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 5 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 500, 300)); // #1 has A
            Assume.That(() => SiteHasPoint(sites[0], 1000, 800)); // #1 has B
            Assume.That(() => SiteHasPoint(sites[0], 0, 800)); // #1 has C
            Assume.That(() => SiteHasPoint(sites[0], 0, 1000)); // #1 has W
            Assume.That(() => SiteHasPoint(sites[0], 1000, 1000)); // #1 has Y
            Assume.That(() => 4 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 500, 300)); // #2 has A
            Assume.That(() => SiteHasPoint(sites[1], 0, 800)); // #2 has C
            Assume.That(() => SiteHasPoint(sites[1], 500, 0)); // #2 has D
            Assume.That(() => SiteHasPoint(sites[1], 0, 0)); // #2 has Z
            Assume.That(() => 4 == sites[2].Points.Count()); // #3
            Assume.That(() => SiteHasPoint(sites[2], 500, 300)); // #3 has A
            Assume.That(() => SiteHasPoint(sites[2], 1000, 800)); // #3 has B
            Assume.That(() => SiteHasPoint(sites[2], 500, 0)); // #3 has D
            Assume.That(() => SiteHasPoint(sites[2], 1000, 0)); // #3 has X

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[0].Neighbours.Contains(sites[2])); // 1 neighbours 3
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[2])); // 2 neighbours 3
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[0])); // 3 neighbours 1
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[1])); // 3 neighbours 2
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 5 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 300, 500)); // #1 has A
            Assume.That(() => SiteHasPoint(sites[0], 800, 0)); // #1 has B
            Assume.That(() => SiteHasPoint(sites[0], 800, 1000)); // #1 has C
            Assume.That(() => SiteHasPoint(sites[0], 1000, 1000)); // #1 has W
            Assume.That(() => SiteHasPoint(sites[0], 1000, 0)); // #1 has Y
            Assume.That(() => 4 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 300, 500)); // #2 has A
            Assume.That(() => SiteHasPoint(sites[1], 800, 1000)); // #2 has C
            Assume.That(() => SiteHasPoint(sites[1], 0, 500)); // #2 has D
            Assume.That(() => SiteHasPoint(sites[1], 0, 1000)); // #2 has Z
            Assume.That(() => 4 == sites[2].Points.Count()); // #3
            Assume.That(() => SiteHasPoint(sites[2], 300, 500)); // #3 has A
            Assume.That(() => SiteHasPoint(sites[2], 800, 0)); // #3 has B
            Assume.That(() => SiteHasPoint(sites[2], 0, 500)); // #3 has D
            Assume.That(() => SiteHasPoint(sites[2], 0, 0)); // #3 has X

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[0].Neighbours.Contains(sites[2])); // 1 neighbours 3
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[2])); // 2 neighbours 3
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[0])); // 3 neighbours 1
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[1])); // 3 neighbours 2
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 4 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 400, 600)); // #1 has A
            Assume.That(() => SiteHasPoint(sites[0], 400, 400)); // #1 has B
            Assume.That(() => SiteHasPoint(sites[0], 600, 400)); // #1 has C
            Assume.That(() => SiteHasPoint(sites[0], 600, 600)); // #1 has D
            Assume.That(() => 4 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 400, 600)); // #2 has A
            Assume.That(() => SiteHasPoint(sites[1], 400, 400)); // #2 has B
            Assume.That(() => SiteHasPoint(sites[1], 0, 1000)); // #2 has E
            Assume.That(() => SiteHasPoint(sites[1], 0, 0)); // #2 has F
            Assume.That(() => 4 == sites[2].Points.Count()); // #3
            Assume.That(() => SiteHasPoint(sites[2], 400, 400)); // #3 has B
            Assume.That(() => SiteHasPoint(sites[2], 600, 400)); // #3 has C
            Assume.That(() => SiteHasPoint(sites[2], 0, 0)); // #3 has F
            Assume.That(() => SiteHasPoint(sites[2], 1000, 0)); // #3 has G
            Assume.That(() => 4 == sites[3].Points.Count()); // #4
            Assume.That(() => SiteHasPoint(sites[3], 600, 400)); // #4 has C
            Assume.That(() => SiteHasPoint(sites[3], 600, 600)); // #4 has D
            Assume.That(() => SiteHasPoint(sites[3], 1000, 0)); // #4 has G
            Assume.That(() => SiteHasPoint(sites[3], 1000, 1000)); // #4 has H
            Assume.That(() => 4 == sites[4].Points.Count()); // #5
            Assume.That(() => SiteHasPoint(sites[4], 400, 600)); // #5 has A
            Assume.That(() => SiteHasPoint(sites[4], 600, 600)); // #5 has D
            Assume.That(() => SiteHasPoint(sites[4], 0, 1000)); // #5 has E
            Assume.That(() => SiteHasPoint(sites[4], 1000, 1000)); // #5 has H

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[0].Neighbours.Contains(sites[2])); // 1 neighbours 3
            Assert.IsTrue(sites[0].Neighbours.Contains(sites[3])); // 1 neighbours 4
            Assert.IsTrue(sites[0].Neighbours.Contains(sites[4])); // 1 neighbours 5
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[2])); // 2 neighbours 3
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[4])); // 2 neighbours 5
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[0])); // 3 neighbours 1
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[1])); // 3 neighbours 2
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[3])); // 3 neighbours 4
            Assert.IsTrue(sites[3].Neighbours.Contains(sites[0])); // 4 neighbours 1
            Assert.IsTrue(sites[3].Neighbours.Contains(sites[2])); // 4 neighbours 3
            Assert.IsTrue(sites[3].Neighbours.Contains(sites[4])); // 4 neighbours 5
            Assert.IsTrue(sites[4].Neighbours.Contains(sites[0])); // 5 neighbours 1
            Assert.IsTrue(sites[4].Neighbours.Contains(sites[1])); // 5 neighbours 2
            Assert.IsTrue(sites[4].Neighbours.Contains(sites[3])); // 5 neighbours 4
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 4 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 400, 400)); // #1 has A
            Assume.That(() => SiteHasPoint(sites[0], 400, 200)); // #1 has B
            Assume.That(() => SiteHasPoint(sites[0], 600, 200)); // #1 has C
            Assume.That(() => SiteHasPoint(sites[0], 600, 400)); // #1 has D
            Assume.That(() => 5 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 400, 400)); // #2 has A
            Assume.That(() => SiteHasPoint(sites[1], 400, 200)); // #2 has B
            Assume.That(() => SiteHasPoint(sites[1], 0, 800)); // #2 has E
            Assume.That(() => SiteHasPoint(sites[1], 200, 0)); // #2 has F
            Assume.That(() => SiteHasPoint(sites[1], 0, 0)); // #2 has Y
            Assume.That(() => 4 == sites[2].Points.Count()); // #3
            Assume.That(() => SiteHasPoint(sites[2], 400, 200)); // #3 has B
            Assume.That(() => SiteHasPoint(sites[2], 600, 200)); // #3 has C
            Assume.That(() => SiteHasPoint(sites[2], 200, 0)); // #3 has F
            Assume.That(() => SiteHasPoint(sites[2], 800, 0)); // #3 has G
            Assume.That(() => 5 == sites[3].Points.Count()); // #4
            Assume.That(() => SiteHasPoint(sites[3], 600, 200)); // #4 has C
            Assume.That(() => SiteHasPoint(sites[3], 600, 400)); // #4 has D
            Assume.That(() => SiteHasPoint(sites[3], 800, 0)); // #4 has G
            Assume.That(() => SiteHasPoint(sites[3], 1000, 800)); // #4 has H
            Assume.That(() => SiteHasPoint(sites[3], 1000, 0)); // #4 has W
            Assume.That(() => 6 == sites[4].Points.Count()); // #5
            Assume.That(() => SiteHasPoint(sites[4], 400, 400)); // #5 has A
            Assume.That(() => SiteHasPoint(sites[4], 600, 400)); // #5 has D
            Assume.That(() => SiteHasPoint(sites[4], 0, 800)); // #5 has E
            Assume.That(() => SiteHasPoint(sites[4], 1000, 800)); // #5 has H
            Assume.That(() => SiteHasPoint(sites[4], 0, 1000)); // #5 has X
            Assume.That(() => SiteHasPoint(sites[4], 1000, 1000)); // #5 has Z

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[0].Neighbours.Contains(sites[2])); // 1 neighbours 3
            Assert.IsTrue(sites[0].Neighbours.Contains(sites[3])); // 1 neighbours 4
            Assert.IsTrue(sites[0].Neighbours.Contains(sites[4])); // 1 neighbours 5
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[2])); // 2 neighbours 3
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[4])); // 2 neighbours 5
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[0])); // 3 neighbours 1
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[1])); // 3 neighbours 2
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[3])); // 3 neighbours 4
            Assert.IsTrue(sites[3].Neighbours.Contains(sites[0])); // 4 neighbours 1
            Assert.IsTrue(sites[3].Neighbours.Contains(sites[2])); // 4 neighbours 3
            Assert.IsTrue(sites[3].Neighbours.Contains(sites[4])); // 4 neighbours 5
            Assert.IsTrue(sites[4].Neighbours.Contains(sites[0])); // 5 neighbours 1
            Assert.IsTrue(sites[4].Neighbours.Contains(sites[1])); // 5 neighbours 2
            Assert.IsTrue(sites[4].Neighbours.Contains(sites[3])); // 5 neighbours 4
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 4 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 400, 600)); // #1 has A
            Assume.That(() => SiteHasPoint(sites[0], 200, 600)); // #1 has B
            Assume.That(() => SiteHasPoint(sites[0], 200, 400)); // #1 has C
            Assume.That(() => SiteHasPoint(sites[0], 400, 400)); // #1 has D
            Assume.That(() => 5 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 400, 600)); // #2 has A
            Assume.That(() => SiteHasPoint(sites[1], 200, 600)); // #2 has B
            Assume.That(() => SiteHasPoint(sites[1], 800, 1000)); // #2 has E
            Assume.That(() => SiteHasPoint(sites[1], 0, 800)); // #2 has F
            Assume.That(() => SiteHasPoint(sites[1], 0, 1000)); // #2 has Y
            Assume.That(() => 4 == sites[2].Points.Count()); // #3
            Assume.That(() => SiteHasPoint(sites[2], 200, 600)); // #3 has B
            Assume.That(() => SiteHasPoint(sites[2], 200, 400)); // #3 has C
            Assume.That(() => SiteHasPoint(sites[2], 0, 800)); // #3 has F
            Assume.That(() => SiteHasPoint(sites[2], 0, 200)); // #3 has G
            Assume.That(() => 5 == sites[3].Points.Count()); // #4
            Assume.That(() => SiteHasPoint(sites[3], 200, 400)); // #4 has C
            Assume.That(() => SiteHasPoint(sites[3], 400, 400)); // #4 has D
            Assume.That(() => SiteHasPoint(sites[3], 0, 200)); // #4 has G
            Assume.That(() => SiteHasPoint(sites[3], 800, 0)); // #4 has H
            Assume.That(() => SiteHasPoint(sites[3], 0, 0)); // #4 has W
            Assume.That(() => 6 == sites[4].Points.Count()); // #5
            Assume.That(() => SiteHasPoint(sites[4], 400, 600)); // #5 has A
            Assume.That(() => SiteHasPoint(sites[4], 400, 400)); // #5 has D
            Assume.That(() => SiteHasPoint(sites[4], 800, 1000)); // #5 has E
            Assume.That(() => SiteHasPoint(sites[4], 800, 0)); // #5 has H
            Assume.That(() => SiteHasPoint(sites[4], 1000, 1000)); // #5 has X
            Assume.That(() => SiteHasPoint(sites[4], 1000, 0)); // #5 has Z

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[0].Neighbours.Contains(sites[2])); // 1 neighbours 3
            Assert.IsTrue(sites[0].Neighbours.Contains(sites[3])); // 1 neighbours 4
            Assert.IsTrue(sites[0].Neighbours.Contains(sites[4])); // 1 neighbours 5
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[2])); // 2 neighbours 3
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[4])); // 2 neighbours 5
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[0])); // 3 neighbours 1
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[1])); // 3 neighbours 2
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[3])); // 3 neighbours 4
            Assert.IsTrue(sites[3].Neighbours.Contains(sites[0])); // 4 neighbours 1
            Assert.IsTrue(sites[3].Neighbours.Contains(sites[2])); // 4 neighbours 3
            Assert.IsTrue(sites[3].Neighbours.Contains(sites[4])); // 4 neighbours 5
            Assert.IsTrue(sites[4].Neighbours.Contains(sites[0])); // 5 neighbours 1
            Assert.IsTrue(sites[4].Neighbours.Contains(sites[1])); // 5 neighbours 2
            Assert.IsTrue(sites[4].Neighbours.Contains(sites[3])); // 5 neighbours 4
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 4 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 600, 600)); // #1 has A
            Assume.That(() => SiteHasPoint(sites[0], 600, 800)); // #1 has B
            Assume.That(() => SiteHasPoint(sites[0], 400, 800)); // #1 has C
            Assume.That(() => SiteHasPoint(sites[0], 400, 600)); // #1 has D
            Assume.That(() => 5 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 600, 600)); // #2 has A
            Assume.That(() => SiteHasPoint(sites[1], 600, 800)); // #2 has B
            Assume.That(() => SiteHasPoint(sites[1], 1000, 200)); // #2 has E
            Assume.That(() => SiteHasPoint(sites[1], 800, 1000)); // #2 has F
            Assume.That(() => SiteHasPoint(sites[1], 1000, 1000)); // #2 has Y
            Assume.That(() => 4 == sites[2].Points.Count()); // #3
            Assume.That(() => SiteHasPoint(sites[2], 600, 800)); // #3 has B
            Assume.That(() => SiteHasPoint(sites[2], 400, 800)); // #3 has C
            Assume.That(() => SiteHasPoint(sites[2], 800, 1000)); // #3 has F
            Assume.That(() => SiteHasPoint(sites[2], 200, 1000)); // #3 has G
            Assume.That(() => 5 == sites[3].Points.Count()); // #4
            Assume.That(() => SiteHasPoint(sites[3], 400, 800)); // #4 has C
            Assume.That(() => SiteHasPoint(sites[3], 400, 600)); // #4 has D
            Assume.That(() => SiteHasPoint(sites[3], 200, 1000)); // #4 has G
            Assume.That(() => SiteHasPoint(sites[3], 0, 200)); // #4 has H
            Assume.That(() => SiteHasPoint(sites[3], 0, 1000)); // #4 has W
            Assume.That(() => 6 == sites[4].Points.Count()); // #5
            Assume.That(() => SiteHasPoint(sites[4], 600, 600)); // #5 has A
            Assume.That(() => SiteHasPoint(sites[4], 400, 600)); // #5 has D
            Assume.That(() => SiteHasPoint(sites[4], 1000, 200)); // #5 has E
            Assume.That(() => SiteHasPoint(sites[4], 0, 200)); // #5 has H
            Assume.That(() => SiteHasPoint(sites[4], 1000, 0)); // #5 has X
            Assume.That(() => SiteHasPoint(sites[4], 0, 0)); // #5 has Z

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[0].Neighbours.Contains(sites[2])); // 1 neighbours 3
            Assert.IsTrue(sites[0].Neighbours.Contains(sites[3])); // 1 neighbours 4
            Assert.IsTrue(sites[0].Neighbours.Contains(sites[4])); // 1 neighbours 5
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[2])); // 2 neighbours 3
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[4])); // 2 neighbours 5
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[0])); // 3 neighbours 1
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[1])); // 3 neighbours 2
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[3])); // 3 neighbours 4
            Assert.IsTrue(sites[3].Neighbours.Contains(sites[0])); // 4 neighbours 1
            Assert.IsTrue(sites[3].Neighbours.Contains(sites[2])); // 4 neighbours 3
            Assert.IsTrue(sites[3].Neighbours.Contains(sites[4])); // 4 neighbours 5
            Assert.IsTrue(sites[4].Neighbours.Contains(sites[0])); // 5 neighbours 1
            Assert.IsTrue(sites[4].Neighbours.Contains(sites[1])); // 5 neighbours 2
            Assert.IsTrue(sites[4].Neighbours.Contains(sites[3])); // 5 neighbours 4
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 4 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 600, 400)); // #1 has A
            Assume.That(() => SiteHasPoint(sites[0], 800, 400)); // #1 has B
            Assume.That(() => SiteHasPoint(sites[0], 800, 600)); // #1 has C
            Assume.That(() => SiteHasPoint(sites[0], 600, 600)); // #1 has D
            Assume.That(() => 5 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 600, 400)); // #2 has A
            Assume.That(() => SiteHasPoint(sites[1], 800, 400)); // #2 has B
            Assume.That(() => SiteHasPoint(sites[1], 200, 0)); // #2 has E
            Assume.That(() => SiteHasPoint(sites[1], 1000, 200)); // #2 has F
            Assume.That(() => SiteHasPoint(sites[1], 1000, 0)); // #2 has Y
            Assume.That(() => 4 == sites[2].Points.Count()); // #3
            Assume.That(() => SiteHasPoint(sites[2], 800, 400)); // #3 has B
            Assume.That(() => SiteHasPoint(sites[2], 800, 600)); // #3 has C
            Assume.That(() => SiteHasPoint(sites[2], 1000, 200)); // #3 has F
            Assume.That(() => SiteHasPoint(sites[2], 1000, 800)); // #3 has G
            Assume.That(() => 5 == sites[3].Points.Count()); // #4
            Assume.That(() => SiteHasPoint(sites[3], 800, 600)); // #4 has C
            Assume.That(() => SiteHasPoint(sites[3], 600, 600)); // #4 has D
            Assume.That(() => SiteHasPoint(sites[3], 1000, 800)); // #4 has G
            Assume.That(() => SiteHasPoint(sites[3], 200, 1000)); // #4 has H
            Assume.That(() => SiteHasPoint(sites[3], 1000, 1000)); // #4 has W
            Assume.That(() => 6 == sites[4].Points.Count()); // #5
            Assume.That(() => SiteHasPoint(sites[4], 600, 400)); // #5 has A
            Assume.That(() => SiteHasPoint(sites[4], 600, 600)); // #5 has D
            Assume.That(() => SiteHasPoint(sites[4], 200, 0)); // #5 has E
            Assume.That(() => SiteHasPoint(sites[4], 200, 1000)); // #5 has H
            Assume.That(() => SiteHasPoint(sites[4], 0, 0)); // #5 has X
            Assume.That(() => SiteHasPoint(sites[4], 0, 1000)); // #5 has Z

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[0].Neighbours.Contains(sites[2])); // 1 neighbours 3
            Assert.IsTrue(sites[0].Neighbours.Contains(sites[3])); // 1 neighbours 4
            Assert.IsTrue(sites[0].Neighbours.Contains(sites[4])); // 1 neighbours 5
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[2])); // 2 neighbours 3
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[4])); // 2 neighbours 5
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[0])); // 3 neighbours 1
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[1])); // 3 neighbours 2
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[3])); // 3 neighbours 4
            Assert.IsTrue(sites[3].Neighbours.Contains(sites[0])); // 4 neighbours 1
            Assert.IsTrue(sites[3].Neighbours.Contains(sites[2])); // 4 neighbours 3
            Assert.IsTrue(sites[3].Neighbours.Contains(sites[4])); // 4 neighbours 5
            Assert.IsTrue(sites[4].Neighbours.Contains(sites[0])); // 5 neighbours 1
            Assert.IsTrue(sites[4].Neighbours.Contains(sites[1])); // 5 neighbours 2
            Assert.IsTrue(sites[4].Neighbours.Contains(sites[3])); // 5 neighbours 4
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 4 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 500, 500)); // #1 has A
            Assume.That(() => SiteHasPoint(sites[0], 500, 1000)); // #1 has B
            Assume.That(() => SiteHasPoint(sites[0], 0, 500)); // #1 has C
            Assume.That(() => SiteHasPoint(sites[0], 0, 1000)); // #1 has X
            Assume.That(() => 4 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 500, 500)); // #2 has A
            Assume.That(() => SiteHasPoint(sites[1], 0, 500)); // #2 has C
            Assume.That(() => SiteHasPoint(sites[1], 500, 0)); // #2 has D
            Assume.That(() => SiteHasPoint(sites[1], 0, 0)); // #2 has Y
            Assume.That(() => 4 == sites[2].Points.Count()); // #3
            Assume.That(() => SiteHasPoint(sites[2], 500, 500)); // #3 has A
            Assume.That(() => SiteHasPoint(sites[2], 500, 0)); // #3 has D
            Assume.That(() => SiteHasPoint(sites[2], 1000, 500)); // #3 has E
            Assume.That(() => SiteHasPoint(sites[2], 1000, 0)); // #3 has W
            Assume.That(() => 4 == sites[3].Points.Count()); // #4
            Assume.That(() => SiteHasPoint(sites[3], 500, 500)); // #4 has A
            Assume.That(() => SiteHasPoint(sites[3], 500, 1000)); // #4 has B
            Assume.That(() => SiteHasPoint(sites[3], 1000, 500)); // #4 has E
            Assume.That(() => SiteHasPoint(sites[3], 1000, 1000)); // #4 has Z

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[0].Neighbours.Contains(sites[3])); // 1 neighbours 4
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[2])); // 2 neighbours 3
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[1])); // 3 neighbours 2
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[3])); // 3 neighbours 4
            Assert.IsTrue(sites[3].Neighbours.Contains(sites[0])); // 4 neighbours 1
            Assert.IsTrue(sites[3].Neighbours.Contains(sites[2])); // 4 neighbours 3
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 4 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 500, 500)); // #1 has A
            Assume.That(() => SiteHasPoint(sites[0], 500, 1000)); // #1 has B
            Assume.That(() => SiteHasPoint(sites[0], 0, 500)); // #1 has C
            Assume.That(() => SiteHasPoint(sites[0], 0, 1000)); // #1 has X
            Assume.That(() => 4 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 500, 500)); // #2 has A
            Assume.That(() => SiteHasPoint(sites[1], 0, 500)); // #2 has C
            Assume.That(() => SiteHasPoint(sites[1], 500, 0)); // #2 has D
            Assume.That(() => SiteHasPoint(sites[1], 0, 0)); // #2 has Y
            Assume.That(() => 4 == sites[2].Points.Count()); // #3
            Assume.That(() => SiteHasPoint(sites[2], 500, 500)); // #3 has A
            Assume.That(() => SiteHasPoint(sites[2], 500, 0)); // #3 has D
            Assume.That(() => SiteHasPoint(sites[2], 1000, 500)); // #3 has E
            Assume.That(() => SiteHasPoint(sites[2], 1000, 0)); // #3 has W
            Assume.That(() => 4 == sites[3].Points.Count()); // #4
            Assume.That(() => SiteHasPoint(sites[3], 500, 500)); // #4 has A
            Assume.That(() => SiteHasPoint(sites[3], 500, 1000)); // #4 has B
            Assume.That(() => SiteHasPoint(sites[3], 1000, 500)); // #4 has E
            Assume.That(() => SiteHasPoint(sites[3], 1000, 1000)); // #4 has Z

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[0].Neighbours.Contains(sites[3])); // 1 neighbours 4
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[2])); // 2 neighbours 3
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[1])); // 3 neighbours 2
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[3])); // 3 neighbours 4
            Assert.IsTrue(sites[3].Neighbours.Contains(sites[0])); // 4 neighbours 1
            Assert.IsTrue(sites[3].Neighbours.Contains(sites[2])); // 4 neighbours 3
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 4 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 500, 500)); // #1 has A
            Assume.That(() => SiteHasPoint(sites[0], 1000, 500)); // #1 has B
            Assume.That(() => SiteHasPoint(sites[0], 500, 1000)); // #1 has C
            Assume.That(() => SiteHasPoint(sites[0], 1000, 1000)); // #1 has X
            Assume.That(() => 4 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 500, 500)); // #2 has A
            Assume.That(() => SiteHasPoint(sites[1], 500, 1000)); // #2 has C
            Assume.That(() => SiteHasPoint(sites[1], 0, 500)); // #2 has D
            Assume.That(() => SiteHasPoint(sites[1], 0, 1000)); // #2 has Y
            Assume.That(() => 4 == sites[2].Points.Count()); // #3
            Assume.That(() => SiteHasPoint(sites[2], 500, 500)); // #3 has A
            Assume.That(() => SiteHasPoint(sites[2], 0, 500)); // #3 has D
            Assume.That(() => SiteHasPoint(sites[2], 500, 0)); // #3 has E
            Assume.That(() => SiteHasPoint(sites[2], 0, 0)); // #3 has W
            Assume.That(() => 4 == sites[3].Points.Count()); // #4
            Assume.That(() => SiteHasPoint(sites[3], 500, 500)); // #4 has A
            Assume.That(() => SiteHasPoint(sites[3], 1000, 500)); // #4 has B
            Assume.That(() => SiteHasPoint(sites[3], 500, 0)); // #4 has E
            Assume.That(() => SiteHasPoint(sites[3], 1000, 0)); // #4 has Z

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[0].Neighbours.Contains(sites[3])); // 1 neighbours 4
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[2])); // 2 neighbours 3
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[1])); // 3 neighbours 2
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[3])); // 3 neighbours 4
            Assert.IsTrue(sites[3].Neighbours.Contains(sites[0])); // 4 neighbours 1
            Assert.IsTrue(sites[3].Neighbours.Contains(sites[2])); // 4 neighbours 3
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 3 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 500, 700)); // #1 has B
            Assume.That(() => SiteHasPoint(sites[0], 200, 1000)); // #1 has C
            Assume.That(() => SiteHasPoint(sites[0], 800, 1000)); // #1 has D
            Assume.That(() => 5 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 500, 400)); // #2 has A
            Assume.That(() => SiteHasPoint(sites[1], 500, 700)); // #2 has B
            Assume.That(() => SiteHasPoint(sites[1], 200, 1000)); // #2 has C
            Assume.That(() => SiteHasPoint(sites[1], 0, 400)); // #2 has E
            Assume.That(() => SiteHasPoint(sites[1], 0, 1000)); // #2 has W
            Assume.That(() => 4 == sites[2].Points.Count()); // #3
            Assume.That(() => SiteHasPoint(sites[2], 500, 400)); // #3 has A
            Assume.That(() => SiteHasPoint(sites[2], 0, 400)); // #3 has E
            Assume.That(() => SiteHasPoint(sites[2], 500, 0)); // #3 has G
            Assume.That(() => SiteHasPoint(sites[2], 0, 0)); // #3 has X
            Assume.That(() => 4 == sites[3].Points.Count()); // #4
            Assume.That(() => SiteHasPoint(sites[3], 500, 400)); // #4 has A
            Assume.That(() => SiteHasPoint(sites[3], 1000, 400)); // #4 has F
            Assume.That(() => SiteHasPoint(sites[3], 500, 0)); // #4 has G
            Assume.That(() => SiteHasPoint(sites[3], 1000, 0)); // #4 has Y
            Assume.That(() => 5 == sites[4].Points.Count()); // #5
            Assume.That(() => SiteHasPoint(sites[4], 500, 400)); // #5 has A
            Assume.That(() => SiteHasPoint(sites[4], 500, 700)); // #5 has B
            Assume.That(() => SiteHasPoint(sites[4], 800, 1000)); // #5 has D
            Assume.That(() => SiteHasPoint(sites[4], 1000, 400)); // #5 has F
            Assume.That(() => SiteHasPoint(sites[4], 1000, 1000)); // #5 has Z

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[0].Neighbours.Contains(sites[4])); // 1 neighbours 5
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[2])); // 2 neighbours 3
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[4])); // 2 neighbours 5
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[1])); // 3 neighbours 2
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[3])); // 3 neighbours 4
            Assert.IsTrue(sites[3].Neighbours.Contains(sites[2])); // 4 neighbours 3
            Assert.IsTrue(sites[3].Neighbours.Contains(sites[4])); // 4 neighbours 5
            Assert.IsTrue(sites[4].Neighbours.Contains(sites[0])); // 5 neighbours 1
            Assert.IsTrue(sites[4].Neighbours.Contains(sites[1])); // 5 neighbours 2
            Assert.IsTrue(sites[4].Neighbours.Contains(sites[3])); // 5 neighbours 4
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 3 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 700, 500)); // #1 has B
            Assume.That(() => SiteHasPoint(sites[0], 1000, 800)); // #1 has C
            Assume.That(() => SiteHasPoint(sites[0], 1000, 200)); // #1 has D
            Assume.That(() => 5 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 400, 500)); // #2 has A
            Assume.That(() => SiteHasPoint(sites[1], 700, 500)); // #2 has B
            Assume.That(() => SiteHasPoint(sites[1], 1000, 800)); // #2 has C
            Assume.That(() => SiteHasPoint(sites[1], 400, 1000)); // #2 has E
            Assume.That(() => SiteHasPoint(sites[1], 1000, 1000)); // #2 has W
            Assume.That(() => 4 == sites[2].Points.Count()); // #3
            Assume.That(() => SiteHasPoint(sites[2], 400, 500)); // #3 has A
            Assume.That(() => SiteHasPoint(sites[2], 400, 1000)); // #3 has E
            Assume.That(() => SiteHasPoint(sites[2], 0, 500)); // #3 has G
            Assume.That(() => SiteHasPoint(sites[2], 0, 1000)); // #3 has X
            Assume.That(() => 4 == sites[3].Points.Count()); // #4
            Assume.That(() => SiteHasPoint(sites[3], 400, 500)); // #4 has A
            Assume.That(() => SiteHasPoint(sites[3], 400, 0)); // #4 has F
            Assume.That(() => SiteHasPoint(sites[3], 0, 500)); // #4 has G
            Assume.That(() => SiteHasPoint(sites[3], 0, 0)); // #4 has Y
            Assume.That(() => 5 == sites[4].Points.Count()); // #5
            Assume.That(() => SiteHasPoint(sites[4], 400, 500)); // #5 has A
            Assume.That(() => SiteHasPoint(sites[4], 700, 500)); // #5 has B
            Assume.That(() => SiteHasPoint(sites[4], 1000, 200)); // #5 has D
            Assume.That(() => SiteHasPoint(sites[4], 400, 0)); // #5 has F
            Assume.That(() => SiteHasPoint(sites[4], 1000, 0)); // #5 has Z

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[0].Neighbours.Contains(sites[4])); // 1 neighbours 5
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[2])); // 2 neighbours 3
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[4])); // 2 neighbours 5
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[1])); // 3 neighbours 2
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[3])); // 3 neighbours 4
            Assert.IsTrue(sites[3].Neighbours.Contains(sites[2])); // 4 neighbours 3
            Assert.IsTrue(sites[3].Neighbours.Contains(sites[4])); // 4 neighbours 5
            Assert.IsTrue(sites[4].Neighbours.Contains(sites[0])); // 5 neighbours 1
            Assert.IsTrue(sites[4].Neighbours.Contains(sites[1])); // 5 neighbours 2
            Assert.IsTrue(sites[4].Neighbours.Contains(sites[3])); // 5 neighbours 4
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 3 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 500, 300)); // #1 has B
            Assume.That(() => SiteHasPoint(sites[0], 800, 0)); // #1 has C
            Assume.That(() => SiteHasPoint(sites[0], 200, 0)); // #1 has D
            Assume.That(() => 5 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 500, 600)); // #2 has A
            Assume.That(() => SiteHasPoint(sites[1], 500, 300)); // #2 has B
            Assume.That(() => SiteHasPoint(sites[1], 800, 0)); // #2 has C
            Assume.That(() => SiteHasPoint(sites[1], 1000, 600)); // #2 has E
            Assume.That(() => SiteHasPoint(sites[1], 1000, 0)); // #2 has W
            Assume.That(() => 4 == sites[2].Points.Count()); // #3
            Assume.That(() => SiteHasPoint(sites[2], 500, 600)); // #3 has A
            Assume.That(() => SiteHasPoint(sites[2], 1000, 600)); // #3 has E
            Assume.That(() => SiteHasPoint(sites[2], 500, 1000)); // #3 has G
            Assume.That(() => SiteHasPoint(sites[2], 1000, 1000)); // #3 has X
            Assume.That(() => 4 == sites[3].Points.Count()); // #4
            Assume.That(() => SiteHasPoint(sites[3], 500, 600)); // #4 has A
            Assume.That(() => SiteHasPoint(sites[3], 0, 600)); // #4 has F
            Assume.That(() => SiteHasPoint(sites[3], 500, 1000)); // #4 has G
            Assume.That(() => SiteHasPoint(sites[3], 0, 1000)); // #4 has Y
            Assume.That(() => 5 == sites[4].Points.Count()); // #5
            Assume.That(() => SiteHasPoint(sites[4], 500, 600)); // #5 has A
            Assume.That(() => SiteHasPoint(sites[4], 500, 300)); // #5 has B
            Assume.That(() => SiteHasPoint(sites[4], 200, 0)); // #5 has D
            Assume.That(() => SiteHasPoint(sites[4], 0, 600)); // #5 has F
            Assume.That(() => SiteHasPoint(sites[4], 0, 0)); // #5 has Z

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[0].Neighbours.Contains(sites[4])); // 1 neighbours 5
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[2])); // 2 neighbours 3
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[4])); // 2 neighbours 5
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[1])); // 3 neighbours 2
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[3])); // 3 neighbours 4
            Assert.IsTrue(sites[3].Neighbours.Contains(sites[2])); // 4 neighbours 3
            Assert.IsTrue(sites[3].Neighbours.Contains(sites[4])); // 4 neighbours 5
            Assert.IsTrue(sites[4].Neighbours.Contains(sites[0])); // 5 neighbours 1
            Assert.IsTrue(sites[4].Neighbours.Contains(sites[1])); // 5 neighbours 2
            Assert.IsTrue(sites[4].Neighbours.Contains(sites[3])); // 5 neighbours 4
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 3 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 300, 500)); // #1 has B
            Assume.That(() => SiteHasPoint(sites[0], 0, 200)); // #1 has C
            Assume.That(() => SiteHasPoint(sites[0], 0, 800)); // #1 has D
            Assume.That(() => 5 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 600, 500)); // #2 has A
            Assume.That(() => SiteHasPoint(sites[1], 300, 500)); // #2 has B
            Assume.That(() => SiteHasPoint(sites[1], 0, 200)); // #2 has C
            Assume.That(() => SiteHasPoint(sites[1], 600, 0)); // #2 has E
            Assume.That(() => SiteHasPoint(sites[1], 0, 0)); // #2 has W
            Assume.That(() => 4 == sites[2].Points.Count()); // #3
            Assume.That(() => SiteHasPoint(sites[2], 600, 500)); // #3 has A
            Assume.That(() => SiteHasPoint(sites[2], 600, 0)); // #3 has E
            Assume.That(() => SiteHasPoint(sites[2], 1000, 500)); // #3 has G
            Assume.That(() => SiteHasPoint(sites[2], 1000, 0)); // #3 has X
            Assume.That(() => 4 == sites[3].Points.Count()); // #4
            Assume.That(() => SiteHasPoint(sites[3], 600, 500)); // #4 has A
            Assume.That(() => SiteHasPoint(sites[3], 600, 1000)); // #4 has F
            Assume.That(() => SiteHasPoint(sites[3], 1000, 500)); // #4 has G
            Assume.That(() => SiteHasPoint(sites[3], 1000, 1000)); // #4 has Y
            Assume.That(() => 5 == sites[4].Points.Count()); // #5
            Assume.That(() => SiteHasPoint(sites[4], 600, 500)); // #5 has A
            Assume.That(() => SiteHasPoint(sites[4], 300, 500)); // #5 has B
            Assume.That(() => SiteHasPoint(sites[4], 0, 800)); // #5 has D
            Assume.That(() => SiteHasPoint(sites[4], 600, 1000)); // #5 has F
            Assume.That(() => SiteHasPoint(sites[4], 0, 1000)); // #5 has Z

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[0].Neighbours.Contains(sites[4])); // 1 neighbours 5
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[2])); // 2 neighbours 3
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[4])); // 2 neighbours 5
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[1])); // 3 neighbours 2
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[3])); // 3 neighbours 4
            Assert.IsTrue(sites[3].Neighbours.Contains(sites[2])); // 4 neighbours 3
            Assert.IsTrue(sites[3].Neighbours.Contains(sites[4])); // 4 neighbours 5
            Assert.IsTrue(sites[4].Neighbours.Contains(sites[0])); // 5 neighbours 1
            Assert.IsTrue(sites[4].Neighbours.Contains(sites[1])); // 5 neighbours 2
            Assert.IsTrue(sites[4].Neighbours.Contains(sites[3])); // 5 neighbours 4
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 3 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 500, 500)); // #1 has B
            Assume.That(() => SiteHasPoint(sites[0], 0, 1000)); // #1 has C
            Assume.That(() => SiteHasPoint(sites[0], 1000, 1000)); // #1 has D
            Assume.That(() => 4 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 500, 300)); // #2 has A
            Assume.That(() => SiteHasPoint(sites[1], 500, 500)); // #2 has B
            Assume.That(() => SiteHasPoint(sites[1], 0, 1000)); // #2 has C
            Assume.That(() => SiteHasPoint(sites[1], 0, 300)); // #2 has E
            Assume.That(() => 4 == sites[2].Points.Count()); // #3
            Assume.That(() => SiteHasPoint(sites[2], 500, 300)); // #3 has A
            Assume.That(() => SiteHasPoint(sites[2], 0, 300)); // #3 has E
            Assume.That(() => SiteHasPoint(sites[2], 500, 0)); // #3 has G
            Assume.That(() => SiteHasPoint(sites[2], 0, 0)); // #3 has X
            Assume.That(() => 4 == sites[3].Points.Count()); // #4
            Assume.That(() => SiteHasPoint(sites[3], 500, 300)); // #4 has A
            Assume.That(() => SiteHasPoint(sites[3], 1000, 300)); // #4 has F
            Assume.That(() => SiteHasPoint(sites[3], 500, 0)); // #4 has G
            Assume.That(() => SiteHasPoint(sites[3], 1000, 0)); // #4 has Y
            Assume.That(() => 4 == sites[4].Points.Count()); // #5
            Assume.That(() => SiteHasPoint(sites[4], 500, 300)); // #5 has A
            Assume.That(() => SiteHasPoint(sites[4], 500, 500)); // #5 has B
            Assume.That(() => SiteHasPoint(sites[4], 1000, 1000)); // #5 has D
            Assume.That(() => SiteHasPoint(sites[4], 1000, 300)); // #5 has F

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[0].Neighbours.Contains(sites[4])); // 1 neighbours 5
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[2])); // 2 neighbours 3
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[4])); // 2 neighbours 5
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[1])); // 3 neighbours 2
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[3])); // 3 neighbours 4
            Assert.IsTrue(sites[3].Neighbours.Contains(sites[2])); // 4 neighbours 3
            Assert.IsTrue(sites[3].Neighbours.Contains(sites[4])); // 4 neighbours 5
            Assert.IsTrue(sites[4].Neighbours.Contains(sites[0])); // 5 neighbours 1
            Assert.IsTrue(sites[4].Neighbours.Contains(sites[1])); // 5 neighbours 2
            Assert.IsTrue(sites[4].Neighbours.Contains(sites[3])); // 5 neighbours 4
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 3 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 500, 500)); // #1 has B
            Assume.That(() => SiteHasPoint(sites[0], 1000, 1000)); // #1 has C
            Assume.That(() => SiteHasPoint(sites[0], 1000, 0)); // #1 has D
            Assume.That(() => 4 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 300, 500)); // #2 has A
            Assume.That(() => SiteHasPoint(sites[1], 500, 500)); // #2 has B
            Assume.That(() => SiteHasPoint(sites[1], 1000, 1000)); // #2 has C
            Assume.That(() => SiteHasPoint(sites[1], 300, 1000)); // #2 has E
            Assume.That(() => 4 == sites[2].Points.Count()); // #3
            Assume.That(() => SiteHasPoint(sites[2], 300, 500)); // #3 has A
            Assume.That(() => SiteHasPoint(sites[2], 300, 1000)); // #3 has E
            Assume.That(() => SiteHasPoint(sites[2], 0, 500)); // #3 has G
            Assume.That(() => SiteHasPoint(sites[2], 0, 1000)); // #3 has X
            Assume.That(() => 4 == sites[3].Points.Count()); // #4
            Assume.That(() => SiteHasPoint(sites[3], 300, 500)); // #4 has A
            Assume.That(() => SiteHasPoint(sites[3], 300, 0)); // #4 has F
            Assume.That(() => SiteHasPoint(sites[3], 0, 500)); // #4 has G
            Assume.That(() => SiteHasPoint(sites[3], 0, 0)); // #4 has Y
            Assume.That(() => 4 == sites[4].Points.Count()); // #5
            Assume.That(() => SiteHasPoint(sites[4], 300, 500)); // #5 has A
            Assume.That(() => SiteHasPoint(sites[4], 500, 500)); // #5 has B
            Assume.That(() => SiteHasPoint(sites[4], 1000, 0)); // #5 has D
            Assume.That(() => SiteHasPoint(sites[4], 300, 0)); // #5 has F

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[0].Neighbours.Contains(sites[4])); // 1 neighbours 5
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[2])); // 2 neighbours 3
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[4])); // 2 neighbours 5
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[1])); // 3 neighbours 2
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[3])); // 3 neighbours 4
            Assert.IsTrue(sites[3].Neighbours.Contains(sites[2])); // 4 neighbours 3
            Assert.IsTrue(sites[3].Neighbours.Contains(sites[4])); // 4 neighbours 5
            Assert.IsTrue(sites[4].Neighbours.Contains(sites[0])); // 5 neighbours 1
            Assert.IsTrue(sites[4].Neighbours.Contains(sites[1])); // 5 neighbours 2
            Assert.IsTrue(sites[4].Neighbours.Contains(sites[3])); // 5 neighbours 4
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 4 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 500, 700)); // #1 has B
            Assume.That(() => SiteHasPoint(sites[0], 0, 700)); // #1 has C
            Assume.That(() => SiteHasPoint(sites[0], 500, 1000)); // #1 has H
            Assume.That(() => SiteHasPoint(sites[0], 0, 1000)); // #1 has W
            Assume.That(() => 4 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 500, 700)); // #2 has B
            Assume.That(() => SiteHasPoint(sites[1], 1000, 700)); // #2 has G
            Assume.That(() => SiteHasPoint(sites[1], 500, 1000)); // #2 has H
            Assume.That(() => SiteHasPoint(sites[1], 1000, 1000)); // #2 has Z
            Assume.That(() => 4 == sites[2].Points.Count()); // #3
            Assume.That(() => SiteHasPoint(sites[2], 500, 300)); // #3 has A
            Assume.That(() => SiteHasPoint(sites[2], 500, 700)); // #3 has B
            Assume.That(() => SiteHasPoint(sites[2], 0, 700)); // #3 has C
            Assume.That(() => SiteHasPoint(sites[2], 0, 300)); // #3 has D
            Assume.That(() => 4 == sites[3].Points.Count()); // #4
            Assume.That(() => SiteHasPoint(sites[3], 500, 300)); // #4 has A
            Assume.That(() => SiteHasPoint(sites[3], 500, 700)); // #4 has B
            Assume.That(() => SiteHasPoint(sites[3], 1000, 300)); // #4 has F
            Assume.That(() => SiteHasPoint(sites[3], 1000, 700)); // #4 has G
            Assume.That(() => 4 == sites[4].Points.Count()); // #5
            Assume.That(() => SiteHasPoint(sites[4], 500, 300)); // #5 has A
            Assume.That(() => SiteHasPoint(sites[4], 0, 300)); // #5 has D
            Assume.That(() => SiteHasPoint(sites[4], 500, 0)); // #5 has E
            Assume.That(() => SiteHasPoint(sites[4], 0, 0)); // #5 has X
            Assume.That(() => 4 == sites[5].Points.Count()); // #6
            Assume.That(() => SiteHasPoint(sites[5], 500, 300)); // #6 has A
            Assume.That(() => SiteHasPoint(sites[5], 500, 0)); // #6 has E
            Assume.That(() => SiteHasPoint(sites[5], 1000, 300)); // #6 has F
            Assume.That(() => SiteHasPoint(sites[5], 1000, 0)); // #6 has Y

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[0].Neighbours.Contains(sites[2])); // 1 neighbours 3
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[3])); // 2 neighbours 4
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[0])); // 3 neighbours 1
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[3])); // 3 neighbours 4
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[4])); // 3 neighbours 5
            Assert.IsTrue(sites[3].Neighbours.Contains(sites[1])); // 4 neighbours 2
            Assert.IsTrue(sites[3].Neighbours.Contains(sites[2])); // 4 neighbours 3
            Assert.IsTrue(sites[3].Neighbours.Contains(sites[5])); // 4 neighbours 6
            Assert.IsTrue(sites[4].Neighbours.Contains(sites[2])); // 5 neighbours 3
            Assert.IsTrue(sites[4].Neighbours.Contains(sites[5])); // 5 neighbours 6
            Assert.IsTrue(sites[5].Neighbours.Contains(sites[3])); // 6 neighbours 4
            Assert.IsTrue(sites[5].Neighbours.Contains(sites[4])); // 6 neighbours 5
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 4 == sites[0].Points.Count()); // #1
            Assume.That(() => SiteHasPoint(sites[0], 700, 500)); // #1 has B
            Assume.That(() => SiteHasPoint(sites[0], 700, 1000)); // #1 has C
            Assume.That(() => SiteHasPoint(sites[0], 1000, 500)); // #1 has H
            Assume.That(() => SiteHasPoint(sites[0], 1000, 1000)); // #1 has W
            Assume.That(() => 4 == sites[1].Points.Count()); // #2
            Assume.That(() => SiteHasPoint(sites[1], 700, 500)); // #2 has B
            Assume.That(() => SiteHasPoint(sites[1], 700, 0)); // #2 has G
            Assume.That(() => SiteHasPoint(sites[1], 1000, 500)); // #2 has H
            Assume.That(() => SiteHasPoint(sites[1], 1000, 0)); // #2 has Z
            Assume.That(() => 4 == sites[2].Points.Count()); // #3
            Assume.That(() => SiteHasPoint(sites[2], 300, 500)); // #3 has A
            Assume.That(() => SiteHasPoint(sites[2], 700, 500)); // #3 has B
            Assume.That(() => SiteHasPoint(sites[2], 700, 1000)); // #3 has C
            Assume.That(() => SiteHasPoint(sites[2], 300, 1000)); // #3 has D
            Assume.That(() => 4 == sites[3].Points.Count()); // #4
            Assume.That(() => SiteHasPoint(sites[3], 300, 500)); // #4 has A
            Assume.That(() => SiteHasPoint(sites[3], 700, 500)); // #4 has B
            Assume.That(() => SiteHasPoint(sites[3], 300, 0)); // #4 has F
            Assume.That(() => SiteHasPoint(sites[3], 700, 0)); // #4 has G
            Assume.That(() => 4 == sites[4].Points.Count()); // #5
            Assume.That(() => SiteHasPoint(sites[4], 300, 500)); // #5 has A
            Assume.That(() => SiteHasPoint(sites[4], 300, 1000)); // #5 has D
            Assume.That(() => SiteHasPoint(sites[4], 0, 500)); // #5 has E
            Assume.That(() => SiteHasPoint(sites[4], 0, 1000)); // #5 has X
            Assume.That(() => 4 == sites[5].Points.Count()); // #6
            Assume.That(() => SiteHasPoint(sites[5], 300, 500)); // #6 has A
            Assume.That(() => SiteHasPoint(sites[5], 0, 500)); // #6 has E
            Assume.That(() => SiteHasPoint(sites[5], 300, 0)); // #6 has F
            Assume.That(() => SiteHasPoint(sites[5], 0, 0)); // #6 has Y

            // Assert

            Assert.IsTrue(sites[0].Neighbours.Contains(sites[1])); // 1 neighbours 2
            Assert.IsTrue(sites[0].Neighbours.Contains(sites[2])); // 1 neighbours 3
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[0])); // 2 neighbours 1
            Assert.IsTrue(sites[1].Neighbours.Contains(sites[3])); // 2 neighbours 4
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[0])); // 3 neighbours 1
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[3])); // 3 neighbours 4
            Assert.IsTrue(sites[2].Neighbours.Contains(sites[4])); // 3 neighbours 5
            Assert.IsTrue(sites[3].Neighbours.Contains(sites[1])); // 4 neighbours 2
            Assert.IsTrue(sites[3].Neighbours.Contains(sites[2])); // 4 neighbours 3
            Assert.IsTrue(sites[3].Neighbours.Contains(sites[5])); // 4 neighbours 6
            Assert.IsTrue(sites[4].Neighbours.Contains(sites[2])); // 5 neighbours 3
            Assert.IsTrue(sites[4].Neighbours.Contains(sites[5])); // 5 neighbours 6
            Assert.IsTrue(sites[5].Neighbours.Contains(sites[3])); // 6 neighbours 4
            Assert.IsTrue(sites[5].Neighbours.Contains(sites[4])); // 6 neighbours 5
        }

    }
}
