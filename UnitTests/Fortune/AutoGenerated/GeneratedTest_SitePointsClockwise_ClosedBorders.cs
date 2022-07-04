using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using static SharpVoronoiLib.UnitTests.CommonTestUtilities;

namespace SharpVoronoiLib.UnitTests
{
    /// <summary>
    /// These tests assert that <see cref="VoronoiSite"/>`s have expected clockwise-sorted <see cref="VoronoiPoint"/>`s.
    /// Specifically, that the <see cref="VoronoiSite.ClockwisePoints"/> contains the expected points in clockwise order.
    /// These tests are run with generating the border edges, i.e. <see cref="BorderEdgeGeneration.MakeBorderEdges"/>.
    /// </summary>
    /// <remarks>
    /// This is an AUTO-GENERATED test fixture class from UnitTestGenerator.
    /// This is one of the several auto-generated fixture classes each checking a different part of the algorithm's result.
    /// It contains a bunch of known Voronoi site layouts, including many edge cases.
    /// </remarks>
    [Parallelizable(ParallelScope.All)]
    [TestFixture]
    public class GeneratedTest_SitePointsClockwise_ClosedBorders
    {
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

            Assert.AreEqual(4, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 1000, 0)); // #1 has W
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 0, 1000)); // #1 has X
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 0, 0)); // #1 has Y
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 1000, 1000)); // #1 has Z
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(0), 0, 0)); // #1 Y
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(1), 0, 1000)); // #1 X
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(2), 1000, 1000)); // #1 Z
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(3), 1000, 0)); // #1 W
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

            Assert.AreEqual(4, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 0, 500)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 1000, 500)); // #1 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 0, 1000)); // #1 has X
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 1000, 1000)); // #1 has Z
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(0), 0, 500)); // #1 A
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(1), 0, 1000)); // #1 X
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(2), 1000, 1000)); // #1 Z
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(3), 1000, 500)); // #1 B
            Assert.AreEqual(4, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 500)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 500)); // #2 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 0)); // #2 has W
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 0)); // #2 has Y
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(0), 0, 0)); // #2 Y
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(1), 0, 500)); // #2 A
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(2), 1000, 500)); // #2 B
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(3), 1000, 0)); // #2 W
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

            Assert.AreEqual(4, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 500, 1000)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 500, 0)); // #1 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 1000, 1000)); // #1 has X
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 1000, 0)); // #1 has Z
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(0), 500, 1000)); // #1 A
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(1), 1000, 1000)); // #1 X
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(2), 1000, 0)); // #1 Z
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(3), 500, 0)); // #1 B
            Assert.AreEqual(4, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 500, 1000)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 500, 0)); // #2 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 0)); // #2 has W
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 1000)); // #2 has Y
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(0), 0, 1000)); // #2 Y
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(1), 500, 1000)); // #2 A
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(2), 500, 0)); // #2 B
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(3), 0, 0)); // #2 W
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

            Assert.AreEqual(4, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 0, 700)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 1000, 700)); // #1 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 0, 1000)); // #1 has X
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 1000, 1000)); // #1 has Z
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(0), 0, 700)); // #1 A
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(1), 0, 1000)); // #1 X
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(2), 1000, 1000)); // #1 Z
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(3), 1000, 700)); // #1 B
            Assert.AreEqual(4, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 700)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 700)); // #2 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 0)); // #2 has W
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 0)); // #2 has Y
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(0), 0, 0)); // #2 Y
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(1), 0, 700)); // #2 A
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(2), 1000, 700)); // #2 B
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(3), 1000, 0)); // #2 W
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

            Assert.AreEqual(4, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 700, 1000)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 700, 0)); // #1 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 1000, 1000)); // #1 has X
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 1000, 0)); // #1 has Z
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(0), 700, 1000)); // #1 A
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(1), 1000, 1000)); // #1 X
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(2), 1000, 0)); // #1 Z
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(3), 700, 0)); // #1 B
            Assert.AreEqual(4, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 700, 1000)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 700, 0)); // #2 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 0)); // #2 has W
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 1000)); // #2 has Y
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(0), 0, 0)); // #2 W
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(1), 0, 1000)); // #2 Y
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(2), 700, 1000)); // #2 A
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(3), 700, 0)); // #2 B
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

            Assert.AreEqual(4, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 0, 700)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 1000, 700)); // #1 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 0, 1000)); // #1 has X
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 1000, 1000)); // #1 has Z
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(0), 0, 700)); // #1 A
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(1), 0, 1000)); // #1 X
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(2), 1000, 1000)); // #1 Z
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(3), 1000, 700)); // #1 B
            Assert.AreEqual(4, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 700)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 700)); // #2 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 300)); // #2 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 300)); // #2 has D
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(0), 0, 300)); // #2 C
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(1), 0, 700)); // #2 A
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(2), 1000, 700)); // #2 B
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(3), 1000, 300)); // #2 D
            Assert.AreEqual(4, sites[2].ClockwisePoints.Count()); // #3
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 0, 300)); // #3 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 1000, 300)); // #3 has D
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 1000, 0)); // #3 has W
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 0, 0)); // #3 has Y
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(0), 0, 0)); // #3 Y
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(1), 0, 300)); // #3 C
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(2), 1000, 300)); // #3 D
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(3), 1000, 0)); // #3 W
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

            Assert.AreEqual(4, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 700, 1000)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 700, 0)); // #1 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 1000, 1000)); // #1 has X
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 1000, 0)); // #1 has Z
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(0), 700, 1000)); // #1 A
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(1), 1000, 1000)); // #1 X
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(2), 1000, 0)); // #1 Z
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(3), 700, 0)); // #1 B
            Assert.AreEqual(4, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 700, 1000)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 700, 0)); // #2 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 300, 1000)); // #2 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 300, 0)); // #2 has D
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(0), 300, 1000)); // #2 C
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(1), 700, 1000)); // #2 A
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(2), 700, 0)); // #2 B
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(3), 300, 0)); // #2 D
            Assert.AreEqual(4, sites[2].ClockwisePoints.Count()); // #3
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 300, 1000)); // #3 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 300, 0)); // #3 has D
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 0, 0)); // #3 has W
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 0, 1000)); // #3 has Y
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(0), 0, 1000)); // #3 Y
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(1), 300, 1000)); // #3 C
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(2), 300, 0)); // #3 D
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(3), 0, 0)); // #3 W
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

            Assert.AreEqual(4, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 0, 700)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 1000, 700)); // #1 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 0, 1000)); // #1 has X
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 1000, 1000)); // #1 has Z
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(0), 0, 700)); // #1 A
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(1), 0, 1000)); // #1 X
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(2), 1000, 1000)); // #1 Z
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(3), 1000, 700)); // #1 B
            Assert.AreEqual(4, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 700)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 700)); // #2 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 500)); // #2 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 500)); // #2 has D
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(0), 0, 500)); // #2 C
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(1), 0, 700)); // #2 A
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(2), 1000, 700)); // #2 B
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(3), 1000, 500)); // #2 D
            Assert.AreEqual(4, sites[2].ClockwisePoints.Count()); // #3
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 0, 500)); // #3 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 1000, 500)); // #3 has D
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 0, 300)); // #3 has E
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 1000, 300)); // #3 has F
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(0), 0, 300)); // #3 E
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(1), 0, 500)); // #3 C
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(2), 1000, 500)); // #3 D
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(3), 1000, 300)); // #3 F
            Assert.AreEqual(4, sites[3].ClockwisePoints.Count()); // #4
            Assert.IsTrue(SiteHasClockwisePoint(sites[3], 0, 300)); // #4 has E
            Assert.IsTrue(SiteHasClockwisePoint(sites[3], 1000, 300)); // #4 has F
            Assert.IsTrue(SiteHasClockwisePoint(sites[3], 1000, 0)); // #4 has W
            Assert.IsTrue(SiteHasClockwisePoint(sites[3], 0, 0)); // #4 has Y
            Assert.IsTrue(PointIs(sites[3].ClockwisePoints.ElementAt(0), 0, 0)); // #4 Y
            Assert.IsTrue(PointIs(sites[3].ClockwisePoints.ElementAt(1), 0, 300)); // #4 E
            Assert.IsTrue(PointIs(sites[3].ClockwisePoints.ElementAt(2), 1000, 300)); // #4 F
            Assert.IsTrue(PointIs(sites[3].ClockwisePoints.ElementAt(3), 1000, 0)); // #4 W
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

            Assert.AreEqual(4, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 700, 1000)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 700, 0)); // #1 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 1000, 1000)); // #1 has X
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 1000, 0)); // #1 has Z
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(0), 700, 1000)); // #1 A
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(1), 1000, 1000)); // #1 X
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(2), 1000, 0)); // #1 Z
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(3), 700, 0)); // #1 B
            Assert.AreEqual(4, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 700, 1000)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 700, 0)); // #2 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 500, 1000)); // #2 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 500, 0)); // #2 has D
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(0), 500, 1000)); // #2 C
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(1), 700, 1000)); // #2 A
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(2), 700, 0)); // #2 B
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(3), 500, 0)); // #2 D
            Assert.AreEqual(4, sites[2].ClockwisePoints.Count()); // #3
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 500, 1000)); // #3 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 500, 0)); // #3 has D
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 300, 1000)); // #3 has E
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 300, 0)); // #3 has F
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(0), 300, 1000)); // #3 E
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(1), 500, 1000)); // #3 C
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(2), 500, 0)); // #3 D
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(3), 300, 0)); // #3 F
            Assert.AreEqual(4, sites[3].ClockwisePoints.Count()); // #4
            Assert.IsTrue(SiteHasClockwisePoint(sites[3], 300, 1000)); // #4 has E
            Assert.IsTrue(SiteHasClockwisePoint(sites[3], 300, 0)); // #4 has F
            Assert.IsTrue(SiteHasClockwisePoint(sites[3], 0, 0)); // #4 has W
            Assert.IsTrue(SiteHasClockwisePoint(sites[3], 0, 1000)); // #4 has Y
            Assert.IsTrue(PointIs(sites[3].ClockwisePoints.ElementAt(0), 0, 1000)); // #4 Y
            Assert.IsTrue(PointIs(sites[3].ClockwisePoints.ElementAt(1), 300, 1000)); // #4 E
            Assert.IsTrue(PointIs(sites[3].ClockwisePoints.ElementAt(2), 300, 0)); // #4 F
            Assert.IsTrue(PointIs(sites[3].ClockwisePoints.ElementAt(3), 0, 0)); // #4 W
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

            Assert.AreEqual(3, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 0, 0)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 1000, 1000)); // #1 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 0, 1000)); // #1 has X
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(0), 0, 1000)); // #1 X
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(1), 1000, 1000)); // #1 B
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(2), 0, 0)); // #1 A
            Assert.AreEqual(3, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 0)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 1000)); // #2 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 0)); // #2 has Y
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(0), 0, 0)); // #2 A
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(1), 1000, 1000)); // #2 B
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(2), 1000, 0)); // #2 Y
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

            Assert.AreEqual(3, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 0, 1000)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 1000, 0)); // #1 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 1000, 1000)); // #1 has X
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(0), 0, 1000)); // #1 A
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(1), 1000, 1000)); // #1 X
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(2), 1000, 0)); // #1 B
            Assert.AreEqual(3, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 1000)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 0)); // #2 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 0)); // #2 has Y
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(0), 0, 0)); // #2 Y
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(1), 0, 1000)); // #2 A
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(2), 1000, 0)); // #2 B
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

            Assert.AreEqual(3, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 0, 200)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 800, 1000)); // #1 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 0, 1000)); // #1 has X
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(0), 0, 1000)); // #1 X
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(1), 800, 1000)); // #1 B
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(2), 0, 200)); // #1 A
            Assert.AreEqual(5, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 200)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 800, 1000)); // #2 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 0)); // #2 has W
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 0)); // #2 has Y
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 1000)); // #2 has Z
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(0), 0, 0)); // #2 Y
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(1), 0, 200)); // #2 A
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(2), 800, 1000)); // #2 B
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(3), 1000, 1000)); // #2 Z
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(4), 1000, 0)); // #2 W
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

            Assert.AreEqual(3, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 200, 1000)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 1000, 200)); // #1 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 1000, 1000)); // #1 has X
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(0), 200, 1000)); // #1 A
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(1), 1000, 1000)); // #1 X
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(2), 1000, 200)); // #1 B
            Assert.AreEqual(5, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 200, 1000)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 200)); // #2 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 0)); // #2 has W
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 1000)); // #2 has Y
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 0)); // #2 has Z
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(0), 0, 0)); // #2 W
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(1), 0, 1000)); // #2 Y
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(2), 200, 1000)); // #2 A
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(3), 1000, 200)); // #2 B
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(4), 1000, 0)); // #2 Z
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

            Assert.AreEqual(3, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 1000, 800)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 200, 0)); // #1 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 1000, 0)); // #1 has X
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(0), 200, 0)); // #1 B
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(1), 1000, 800)); // #1 A
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(2), 1000, 0)); // #1 X
            Assert.AreEqual(5, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 800)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 200, 0)); // #2 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 1000)); // #2 has W
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 1000)); // #2 has Y
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 0)); // #2 has Z
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(0), 0, 1000)); // #2 W
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(1), 1000, 1000)); // #2 Y
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(2), 1000, 800)); // #2 A
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(3), 200, 0)); // #2 B
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(4), 0, 0)); // #2 Z
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

            Assert.AreEqual(3, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 800, 0)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 0, 800)); // #1 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 0, 0)); // #1 has X
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(0), 0, 0)); // #1 X
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(1), 0, 800)); // #1 B
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(2), 800, 0)); // #1 A
            Assert.AreEqual(5, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 800, 0)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 800)); // #2 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 1000)); // #2 has W
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 0)); // #2 has Y
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 1000)); // #2 has Z
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(0), 0, 800)); // #2 B
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(1), 0, 1000)); // #2 Z
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(2), 1000, 1000)); // #2 W
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(3), 1000, 0)); // #2 Y
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(4), 800, 0)); // #2 A
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

            Assert.AreEqual(3, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 0, 300)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 700, 1000)); // #1 has D
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 0, 1000)); // #1 has X
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(0), 0, 1000)); // #1 X
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(1), 700, 1000)); // #1 D
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(2), 0, 300)); // #1 A
            Assert.AreEqual(6, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 300)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 300, 0)); // #2 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 700)); // #2 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 700, 1000)); // #2 has D
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 0)); // #2 has Y
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 1000)); // #2 has Z
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(0), 0, 0)); // #2 Y
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(1), 0, 300)); // #2 A
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(2), 700, 1000)); // #2 D
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(3), 1000, 1000)); // #2 Z
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(4), 1000, 700)); // #2 C
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(5), 300, 0)); // #2 B
            Assert.AreEqual(3, sites[2].ClockwisePoints.Count()); // #3
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 300, 0)); // #3 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 1000, 700)); // #3 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 1000, 0)); // #3 has W
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(0), 300, 0)); // #3 B
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(1), 1000, 700)); // #3 C
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(2), 1000, 0)); // #3 W
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

            Assert.AreEqual(3, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 300, 1000)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 1000, 300)); // #1 has D
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 1000, 1000)); // #1 has X
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(0), 300, 1000)); // #1 A
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(1), 1000, 1000)); // #1 X
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(2), 1000, 300)); // #1 D
            Assert.AreEqual(6, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 300, 1000)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 700)); // #2 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 700, 0)); // #2 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 300)); // #2 has D
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 1000)); // #2 has Y
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 0)); // #2 has Z
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(0), 0, 700)); // #2 B
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(1), 0, 1000)); // #2 Y
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(2), 300, 1000)); // #2 A
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(3), 1000, 300)); // #2 D
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(4), 1000, 0)); // #2 Z
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(5), 700, 0)); // #2 C
            Assert.AreEqual(3, sites[2].ClockwisePoints.Count()); // #3
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 0, 700)); // #3 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 700, 0)); // #3 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 0, 0)); // #3 has W
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(0), 0, 0)); // #3 W
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(1), 0, 700)); // #3 B
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(2), 700, 0)); // #3 C
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

            Assert.AreEqual(3, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 0, 400)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 600, 1000)); // #1 has D
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 0, 1000)); // #1 has X
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(0), 0, 1000)); // #1 X
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(1), 600, 1000)); // #1 D
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(2), 0, 400)); // #1 A
            Assert.AreEqual(4, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 400)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 0)); // #2 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 1000)); // #2 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 600, 1000)); // #2 has D
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(0), 0, 400)); // #2 A
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(1), 600, 1000)); // #2 D
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(2), 1000, 1000)); // #2 C
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(3), 0, 0)); // #2 B
            Assert.AreEqual(3, sites[2].ClockwisePoints.Count()); // #3
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 0, 0)); // #3 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 1000, 1000)); // #3 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 1000, 0)); // #3 has Y
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(0), 0, 0)); // #3 B
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(1), 1000, 1000)); // #3 C
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(2), 1000, 0)); // #3 Y
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

            Assert.AreEqual(3, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 400, 1000)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 1000, 400)); // #1 has D
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 1000, 1000)); // #1 has X
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(0), 400, 1000)); // #1 A
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(1), 1000, 1000)); // #1 X
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(2), 1000, 400)); // #1 D
            Assert.AreEqual(4, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 400, 1000)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 1000)); // #2 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 0)); // #2 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 400)); // #2 has D
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(0), 0, 1000)); // #2 B
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(1), 400, 1000)); // #2 A
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(2), 1000, 400)); // #2 D
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(3), 1000, 0)); // #2 C
            Assert.AreEqual(3, sites[2].ClockwisePoints.Count()); // #3
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 0, 1000)); // #3 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 1000, 0)); // #3 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 0, 0)); // #3 has Y
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(0), 0, 0)); // #3 Y
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(1), 0, 1000)); // #3 B
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(2), 1000, 0)); // #3 C
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

            Assert.AreEqual(3, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 1000, 600)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 400, 0)); // #1 has D
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 1000, 0)); // #1 has X
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(0), 400, 0)); // #1 D
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(1), 1000, 600)); // #1 A
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(2), 1000, 0)); // #1 X
            Assert.AreEqual(4, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 600)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 1000)); // #2 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 0)); // #2 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 400, 0)); // #2 has D
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(0), 0, 0)); // #2 C
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(1), 1000, 1000)); // #2 B
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(2), 1000, 600)); // #2 A
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(3), 400, 0)); // #2 D
            Assert.AreEqual(3, sites[2].ClockwisePoints.Count()); // #3
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 1000, 1000)); // #3 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 0, 0)); // #3 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 0, 1000)); // #3 has Y
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(0), 0, 1000)); // #3 Y
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(1), 1000, 1000)); // #3 B
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(2), 0, 0)); // #3 C
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

            Assert.AreEqual(3, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 600, 0)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 0, 600)); // #1 has D
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 0, 0)); // #1 has X
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(0), 0, 0)); // #1 X
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(1), 0, 600)); // #1 D
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(2), 600, 0)); // #1 A
            Assert.AreEqual(4, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 600, 0)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 0)); // #2 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 1000)); // #2 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 600)); // #2 has D
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(0), 0, 600)); // #2 D
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(1), 0, 1000)); // #2 C
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(2), 1000, 0)); // #2 B
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(3), 600, 0)); // #2 A
            Assert.AreEqual(3, sites[2].ClockwisePoints.Count()); // #3
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 1000, 0)); // #3 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 0, 1000)); // #3 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 1000, 1000)); // #3 has Y
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(0), 0, 1000)); // #3 C
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(1), 1000, 1000)); // #3 Y
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(2), 1000, 0)); // #3 B
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

            Assert.AreEqual(3, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 0, 400)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 600, 1000)); // #1 has F
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 0, 1000)); // #1 has X
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(0), 0, 1000)); // #1 X
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(1), 600, 1000)); // #1 F
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(2), 0, 400)); // #1 A
            Assert.AreEqual(4, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 400)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 0)); // #2 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 1000)); // #2 has E
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 600, 1000)); // #2 has F
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(0), 0, 400)); // #2 A
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(1), 600, 1000)); // #2 F
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(2), 1000, 1000)); // #2 E
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(3), 0, 0)); // #2 B
            Assert.AreEqual(4, sites[2].ClockwisePoints.Count()); // #3
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 0, 0)); // #3 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 400, 0)); // #3 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 1000, 600)); // #3 has D
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 1000, 1000)); // #3 has E
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(0), 0, 0)); // #3 B
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(1), 1000, 1000)); // #3 E
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(2), 1000, 600)); // #3 D
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(3), 400, 0)); // #3 C
            Assert.AreEqual(3, sites[3].ClockwisePoints.Count()); // #4
            Assert.IsTrue(SiteHasClockwisePoint(sites[3], 400, 0)); // #4 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[3], 1000, 600)); // #4 has D
            Assert.IsTrue(SiteHasClockwisePoint(sites[3], 1000, 0)); // #4 has Y
            Assert.IsTrue(PointIs(sites[3].ClockwisePoints.ElementAt(0), 400, 0)); // #4 C
            Assert.IsTrue(PointIs(sites[3].ClockwisePoints.ElementAt(1), 1000, 600)); // #4 D
            Assert.IsTrue(PointIs(sites[3].ClockwisePoints.ElementAt(2), 1000, 0)); // #4 Y
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

            Assert.AreEqual(3, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 400, 1000)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 1000, 400)); // #1 has F
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 1000, 1000)); // #1 has X
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(0), 400, 1000)); // #1 A
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(1), 1000, 1000)); // #1 X
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(2), 1000, 400)); // #1 F
            Assert.AreEqual(4, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 400, 1000)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 1000)); // #2 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 0)); // #2 has E
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 400)); // #2 has F
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(0), 0, 1000)); // #2 B
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(1), 400, 1000)); // #2 A
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(2), 1000, 400)); // #2 F
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(3), 1000, 0)); // #2 E
            Assert.AreEqual(4, sites[2].ClockwisePoints.Count()); // #3
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 0, 1000)); // #3 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 0, 600)); // #3 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 600, 0)); // #3 has D
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 1000, 0)); // #3 has E
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(0), 0, 600)); // #3 C
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(1), 0, 1000)); // #3 B
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(2), 1000, 0)); // #3 E
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(3), 600, 0)); // #3 D
            Assert.AreEqual(3, sites[3].ClockwisePoints.Count()); // #4
            Assert.IsTrue(SiteHasClockwisePoint(sites[3], 0, 600)); // #4 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[3], 600, 0)); // #4 has D
            Assert.IsTrue(SiteHasClockwisePoint(sites[3], 0, 0)); // #4 has Y
            Assert.IsTrue(PointIs(sites[3].ClockwisePoints.ElementAt(0), 0, 0)); // #4 Y
            Assert.IsTrue(PointIs(sites[3].ClockwisePoints.ElementAt(1), 0, 600)); // #4 C
            Assert.IsTrue(PointIs(sites[3].ClockwisePoints.ElementAt(2), 600, 0)); // #4 D
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

            Assert.AreEqual(4, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 400, 400)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 0, 400)); // #1 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 1000, 1000)); // #1 has D
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 0, 1000)); // #1 has X
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(0), 0, 400)); // #1 B
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(1), 0, 1000)); // #1 X
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(2), 1000, 1000)); // #1 D
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(3), 400, 400)); // #1 A
            Assert.AreEqual(4, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 400, 400)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 400)); // #2 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 400, 0)); // #2 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 0)); // #2 has Y
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(0), 0, 0)); // #2 Y
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(1), 0, 400)); // #2 B
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(2), 400, 400)); // #2 A
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(3), 400, 0)); // #2 C
            Assert.AreEqual(4, sites[2].ClockwisePoints.Count()); // #3
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 400, 400)); // #3 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 400, 0)); // #3 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 1000, 1000)); // #3 has D
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 1000, 0)); // #3 has W
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(0), 400, 400)); // #3 A
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(1), 1000, 1000)); // #3 D
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(2), 1000, 0)); // #3 W
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(3), 400, 0)); // #3 C
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

            Assert.AreEqual(4, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 400, 600)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 400, 1000)); // #1 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 1000, 0)); // #1 has D
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 1000, 1000)); // #1 has X
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(0), 400, 600)); // #1 A
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(1), 400, 1000)); // #1 B
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(2), 1000, 1000)); // #1 X
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(3), 1000, 0)); // #1 D
            Assert.AreEqual(4, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 400, 600)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 400, 1000)); // #2 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 600)); // #2 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 1000)); // #2 has Y
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(0), 0, 600)); // #2 C
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(1), 0, 1000)); // #2 Y
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(2), 400, 1000)); // #2 B
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(3), 400, 600)); // #2 A
            Assert.AreEqual(4, sites[2].ClockwisePoints.Count()); // #3
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 400, 600)); // #3 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 0, 600)); // #3 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 1000, 0)); // #3 has D
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 0, 0)); // #3 has W
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(0), 0, 600)); // #3 C
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(1), 400, 600)); // #3 A
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(2), 1000, 0)); // #3 D
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(3), 0, 0)); // #3 W
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

            Assert.AreEqual(4, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 600, 600)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 1000, 600)); // #1 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 0, 0)); // #1 has D
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 1000, 0)); // #1 has X
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(0), 0, 0)); // #1 D
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(1), 600, 600)); // #1 A
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(2), 1000, 600)); // #1 B
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(3), 1000, 0)); // #1 X
            Assert.AreEqual(4, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 600, 600)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 600)); // #2 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 600, 1000)); // #2 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 1000)); // #2 has Y
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(0), 600, 600)); // #2 A
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(1), 600, 1000)); // #2 C
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(2), 1000, 1000)); // #2 Y
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(3), 1000, 600)); // #2 B
            Assert.AreEqual(4, sites[2].ClockwisePoints.Count()); // #3
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 600, 600)); // #3 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 600, 1000)); // #3 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 0, 0)); // #3 has D
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 0, 1000)); // #3 has W
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(0), 0, 1000)); // #3 W
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(1), 600, 1000)); // #3 C
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(2), 600, 600)); // #3 A
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(3), 0, 0)); // #3 D
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

            Assert.AreEqual(4, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 600, 400)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 600, 0)); // #1 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 0, 1000)); // #1 has D
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 0, 0)); // #1 has X
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(0), 0, 0)); // #1 X
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(1), 0, 1000)); // #1 D
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(2), 600, 400)); // #1 A
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(3), 600, 0)); // #1 B
            Assert.AreEqual(4, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 600, 400)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 600, 0)); // #2 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 400)); // #2 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 0)); // #2 has Y
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(0), 600, 400)); // #2 A
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(1), 1000, 400)); // #2 C
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(2), 1000, 0)); // #2 Y
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(3), 600, 0)); // #2 B
            Assert.AreEqual(4, sites[2].ClockwisePoints.Count()); // #3
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 600, 400)); // #3 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 1000, 400)); // #3 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 0, 1000)); // #3 has D
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 1000, 1000)); // #3 has W
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(0), 600, 400)); // #3 A
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(1), 0, 1000)); // #3 D
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(2), 1000, 1000)); // #3 W
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(3), 1000, 400)); // #3 C
        }

        [Test]
        public void ThreePointsInAWedgeAroundMiddleTowardsSide()
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

            Assert.AreEqual(3, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 500, 500)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 0, 0)); // #1 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 1000, 0)); // #1 has C
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(0), 0, 0)); // #1 B
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(1), 500, 500)); // #1 A
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(2), 1000, 0)); // #1 C
            Assert.AreEqual(4, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 500, 500)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 0)); // #2 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 500, 1000)); // #2 has D
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 1000)); // #2 has Y
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(0), 500, 500)); // #2 A
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(1), 500, 1000)); // #2 D
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(2), 1000, 1000)); // #2 Y
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(3), 1000, 0)); // #2 C
            Assert.AreEqual(4, sites[2].ClockwisePoints.Count()); // #3
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 500, 500)); // #3 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 0, 0)); // #3 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 500, 1000)); // #3 has D
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 0, 1000)); // #3 has X
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(0), 0, 1000)); // #3 X
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(1), 500, 1000)); // #3 D
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(2), 500, 500)); // #3 A
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(3), 0, 0)); // #3 B
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeAroundMiddleTowardsSide"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeAroundMiddleTowardsSide_Rotated90()
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

            Assert.AreEqual(3, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 500, 500)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 0, 1000)); // #1 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 0, 0)); // #1 has C
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(0), 0, 1000)); // #1 B
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(1), 500, 500)); // #1 A
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(2), 0, 0)); // #1 C
            Assert.AreEqual(4, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 500, 500)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 0)); // #2 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 500)); // #2 has D
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 0)); // #2 has Y
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(0), 0, 0)); // #2 C
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(1), 500, 500)); // #2 A
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(2), 1000, 500)); // #2 D
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(3), 1000, 0)); // #2 Y
            Assert.AreEqual(4, sites[2].ClockwisePoints.Count()); // #3
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 500, 500)); // #3 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 0, 1000)); // #3 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 1000, 500)); // #3 has D
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 1000, 1000)); // #3 has X
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(0), 0, 1000)); // #3 B
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(1), 1000, 1000)); // #3 X
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(2), 1000, 500)); // #3 D
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(3), 500, 500)); // #3 A
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeAroundMiddleTowardsSide"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeAroundMiddleTowardsSide_Rotated180()
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

            Assert.AreEqual(3, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 500, 500)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 1000, 1000)); // #1 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 0, 1000)); // #1 has C
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(0), 0, 1000)); // #1 C
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(1), 1000, 1000)); // #1 B
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(2), 500, 500)); // #1 A
            Assert.AreEqual(4, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 500, 500)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 1000)); // #2 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 500, 0)); // #2 has D
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 0)); // #2 has Y
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(0), 0, 1000)); // #2 C
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(1), 500, 500)); // #2 A
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(2), 500, 0)); // #2 D
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(3), 0, 0)); // #2 Y
            Assert.AreEqual(4, sites[2].ClockwisePoints.Count()); // #3
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 500, 500)); // #3 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 1000, 1000)); // #3 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 500, 0)); // #3 has D
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 1000, 0)); // #3 has X
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(0), 500, 500)); // #3 A
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(1), 1000, 1000)); // #3 B
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(2), 1000, 0)); // #3 X
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(3), 500, 0)); // #3 D
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeAroundMiddleTowardsSide"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeAroundMiddleTowardsSide_Rotated270()
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

            Assert.AreEqual(3, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 500, 500)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 1000, 0)); // #1 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 1000, 1000)); // #1 has C
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(0), 500, 500)); // #1 A
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(1), 1000, 1000)); // #1 C
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(2), 1000, 0)); // #1 B
            Assert.AreEqual(4, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 500, 500)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 1000)); // #2 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 500)); // #2 has D
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 1000)); // #2 has Y
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(0), 0, 500)); // #2 D
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(1), 0, 1000)); // #2 Y
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(2), 1000, 1000)); // #2 C
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(3), 500, 500)); // #2 A
            Assert.AreEqual(4, sites[2].ClockwisePoints.Count()); // #3
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 500, 500)); // #3 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 1000, 0)); // #3 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 0, 500)); // #3 has D
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 0, 0)); // #3 has X
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(0), 0, 0)); // #3 X
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(1), 0, 500)); // #3 D
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(2), 500, 500)); // #3 A
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(3), 1000, 0)); // #3 B
        }

        [Test]
        public void ThreePointsInAWedgeOffsetFromMiddleTowardsSide()
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

            Assert.AreEqual(3, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 500, 300)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 200, 0)); // #1 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 800, 0)); // #1 has C
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(0), 200, 0)); // #1 B
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(1), 500, 300)); // #1 A
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(2), 800, 0)); // #1 C
            Assert.AreEqual(5, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 500, 300)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 800, 0)); // #2 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 500, 1000)); // #2 has D
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 0)); // #2 has W
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 1000)); // #2 has Z
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(0), 500, 300)); // #2 A
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(1), 500, 1000)); // #2 D
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(2), 1000, 1000)); // #2 Z
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(3), 1000, 0)); // #2 W
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(4), 800, 0)); // #2 C
            Assert.AreEqual(5, sites[2].ClockwisePoints.Count()); // #3
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 500, 300)); // #3 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 200, 0)); // #3 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 500, 1000)); // #3 has D
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 0, 1000)); // #3 has X
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 0, 0)); // #3 has Y
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(0), 0, 0)); // #3 Y
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(1), 0, 1000)); // #3 X
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(2), 500, 1000)); // #3 D
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(3), 500, 300)); // #3 A
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(4), 200, 0)); // #3 B
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeOffsetFromMiddleTowardsSide"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeOffsetFromMiddleTowardsSide_Rotated90()
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

            Assert.AreEqual(3, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 300, 500)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 0, 800)); // #1 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 0, 200)); // #1 has C
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(0), 0, 800)); // #1 B
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(1), 300, 500)); // #1 A
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(2), 0, 200)); // #1 C
            Assert.AreEqual(5, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 300, 500)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 200)); // #2 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 500)); // #2 has D
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 0)); // #2 has W
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 0)); // #2 has Z
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(0), 0, 0)); // #2 W
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(1), 0, 200)); // #2 C
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(2), 300, 500)); // #2 A
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(3), 1000, 500)); // #2 D
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(4), 1000, 0)); // #2 Z
            Assert.AreEqual(5, sites[2].ClockwisePoints.Count()); // #3
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 300, 500)); // #3 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 0, 800)); // #3 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 1000, 500)); // #3 has D
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 1000, 1000)); // #3 has X
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 0, 1000)); // #3 has Y
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(0), 0, 800)); // #3 B
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(1), 0, 1000)); // #3 Y
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(2), 1000, 1000)); // #3 X
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(3), 1000, 500)); // #3 D
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(4), 300, 500)); // #3 A
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeOffsetFromMiddleTowardsSide"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeOffsetFromMiddleTowardsSide_Rotated180()
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

            Assert.AreEqual(3, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 500, 700)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 800, 1000)); // #1 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 200, 1000)); // #1 has C
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(0), 200, 1000)); // #1 C
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(1), 800, 1000)); // #1 B
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(2), 500, 700)); // #1 A
            Assert.AreEqual(5, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 500, 700)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 200, 1000)); // #2 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 500, 0)); // #2 has D
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 1000)); // #2 has W
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 0)); // #2 has Z
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(0), 0, 1000)); // #2 W
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(1), 200, 1000)); // #2 C
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(2), 500, 700)); // #2 A
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(3), 500, 0)); // #2 D
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(4), 0, 0)); // #2 Z
            Assert.AreEqual(5, sites[2].ClockwisePoints.Count()); // #3
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 500, 700)); // #3 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 800, 1000)); // #3 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 500, 0)); // #3 has D
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 1000, 0)); // #3 has X
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 1000, 1000)); // #3 has Y
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(0), 500, 700)); // #3 A
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(1), 800, 1000)); // #3 B
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(2), 1000, 1000)); // #3 Y
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(3), 1000, 0)); // #3 X
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(4), 500, 0)); // #3 D
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeOffsetFromMiddleTowardsSide"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeOffsetFromMiddleTowardsSide_Rotated270()
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

            Assert.AreEqual(3, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 700, 500)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 1000, 200)); // #1 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 1000, 800)); // #1 has C
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(0), 700, 500)); // #1 A
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(1), 1000, 800)); // #1 C
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(2), 1000, 200)); // #1 B
            Assert.AreEqual(5, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 700, 500)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 800)); // #2 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 500)); // #2 has D
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 1000)); // #2 has W
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 1000)); // #2 has Z
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(0), 0, 500)); // #2 D
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(1), 0, 1000)); // #2 Z
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(2), 1000, 1000)); // #2 W
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(3), 1000, 800)); // #2 C
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(4), 700, 500)); // #2 A
            Assert.AreEqual(5, sites[2].ClockwisePoints.Count()); // #3
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 700, 500)); // #3 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 1000, 200)); // #3 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 0, 500)); // #3 has D
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 0, 0)); // #3 has X
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 1000, 0)); // #3 has Y
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(0), 0, 0)); // #3 X
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(1), 0, 500)); // #3 D
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(2), 700, 500)); // #3 A
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(3), 1000, 200)); // #3 B
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(4), 1000, 0)); // #3 Y
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

            Assert.AreEqual(4, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 400, 600)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 400, 400)); // #1 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 600, 400)); // #1 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 600, 600)); // #1 has D
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(0), 400, 400)); // #1 B
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(1), 400, 600)); // #1 A
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(2), 600, 600)); // #1 D
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(3), 600, 400)); // #1 C
            Assert.AreEqual(4, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 400, 600)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 400, 400)); // #2 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 1000)); // #2 has E
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 0)); // #2 has F
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(0), 0, 1000)); // #2 E
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(1), 400, 600)); // #2 A
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(2), 400, 400)); // #2 B
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(3), 0, 0)); // #2 F
            Assert.AreEqual(4, sites[2].ClockwisePoints.Count()); // #3
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 400, 400)); // #3 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 600, 400)); // #3 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 0, 0)); // #3 has F
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 1000, 0)); // #3 has G
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(0), 0, 0)); // #3 F
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(1), 400, 400)); // #3 B
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(2), 600, 400)); // #3 C
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(3), 1000, 0)); // #3 G
            Assert.AreEqual(4, sites[3].ClockwisePoints.Count()); // #4
            Assert.IsTrue(SiteHasClockwisePoint(sites[3], 600, 400)); // #4 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[3], 600, 600)); // #4 has D
            Assert.IsTrue(SiteHasClockwisePoint(sites[3], 1000, 0)); // #4 has G
            Assert.IsTrue(SiteHasClockwisePoint(sites[3], 1000, 1000)); // #4 has H
            Assert.IsTrue(PointIs(sites[3].ClockwisePoints.ElementAt(0), 600, 400)); // #4 C
            Assert.IsTrue(PointIs(sites[3].ClockwisePoints.ElementAt(1), 600, 600)); // #4 D
            Assert.IsTrue(PointIs(sites[3].ClockwisePoints.ElementAt(2), 1000, 1000)); // #4 H
            Assert.IsTrue(PointIs(sites[3].ClockwisePoints.ElementAt(3), 1000, 0)); // #4 G
            Assert.AreEqual(4, sites[4].ClockwisePoints.Count()); // #5
            Assert.IsTrue(SiteHasClockwisePoint(sites[4], 400, 600)); // #5 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[4], 600, 600)); // #5 has D
            Assert.IsTrue(SiteHasClockwisePoint(sites[4], 0, 1000)); // #5 has E
            Assert.IsTrue(SiteHasClockwisePoint(sites[4], 1000, 1000)); // #5 has H
            Assert.IsTrue(PointIs(sites[4].ClockwisePoints.ElementAt(0), 400, 600)); // #5 A
            Assert.IsTrue(PointIs(sites[4].ClockwisePoints.ElementAt(1), 0, 1000)); // #5 E
            Assert.IsTrue(PointIs(sites[4].ClockwisePoints.ElementAt(2), 1000, 1000)); // #5 H
            Assert.IsTrue(PointIs(sites[4].ClockwisePoints.ElementAt(3), 600, 600)); // #5 D
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

            Assert.AreEqual(4, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 400, 400)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 400, 200)); // #1 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 600, 200)); // #1 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 600, 400)); // #1 has D
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(0), 400, 200)); // #1 B
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(1), 400, 400)); // #1 A
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(2), 600, 400)); // #1 D
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(3), 600, 200)); // #1 C
            Assert.AreEqual(5, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 400, 400)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 400, 200)); // #2 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 800)); // #2 has E
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 200, 0)); // #2 has F
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 0)); // #2 has Y
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(0), 0, 0)); // #2 Y
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(1), 0, 800)); // #2 E
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(2), 400, 400)); // #2 A
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(3), 400, 200)); // #2 B
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(4), 200, 0)); // #2 F
            Assert.AreEqual(4, sites[2].ClockwisePoints.Count()); // #3
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 400, 200)); // #3 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 600, 200)); // #3 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 200, 0)); // #3 has F
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 800, 0)); // #3 has G
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(0), 200, 0)); // #3 F
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(1), 400, 200)); // #3 B
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(2), 600, 200)); // #3 C
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(3), 800, 0)); // #3 G
            Assert.AreEqual(5, sites[3].ClockwisePoints.Count()); // #4
            Assert.IsTrue(SiteHasClockwisePoint(sites[3], 600, 200)); // #4 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[3], 600, 400)); // #4 has D
            Assert.IsTrue(SiteHasClockwisePoint(sites[3], 800, 0)); // #4 has G
            Assert.IsTrue(SiteHasClockwisePoint(sites[3], 1000, 800)); // #4 has H
            Assert.IsTrue(SiteHasClockwisePoint(sites[3], 1000, 0)); // #4 has W
            Assert.IsTrue(PointIs(sites[3].ClockwisePoints.ElementAt(0), 600, 200)); // #4 C
            Assert.IsTrue(PointIs(sites[3].ClockwisePoints.ElementAt(1), 600, 400)); // #4 D
            Assert.IsTrue(PointIs(sites[3].ClockwisePoints.ElementAt(2), 1000, 800)); // #4 H
            Assert.IsTrue(PointIs(sites[3].ClockwisePoints.ElementAt(3), 1000, 0)); // #4 W
            Assert.IsTrue(PointIs(sites[3].ClockwisePoints.ElementAt(4), 800, 0)); // #4 G
            Assert.AreEqual(6, sites[4].ClockwisePoints.Count()); // #5
            Assert.IsTrue(SiteHasClockwisePoint(sites[4], 400, 400)); // #5 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[4], 600, 400)); // #5 has D
            Assert.IsTrue(SiteHasClockwisePoint(sites[4], 0, 800)); // #5 has E
            Assert.IsTrue(SiteHasClockwisePoint(sites[4], 1000, 800)); // #5 has H
            Assert.IsTrue(SiteHasClockwisePoint(sites[4], 0, 1000)); // #5 has X
            Assert.IsTrue(SiteHasClockwisePoint(sites[4], 1000, 1000)); // #5 has Z
            Assert.IsTrue(PointIs(sites[4].ClockwisePoints.ElementAt(0), 400, 400)); // #5 A
            Assert.IsTrue(PointIs(sites[4].ClockwisePoints.ElementAt(1), 0, 800)); // #5 E
            Assert.IsTrue(PointIs(sites[4].ClockwisePoints.ElementAt(2), 0, 1000)); // #5 X
            Assert.IsTrue(PointIs(sites[4].ClockwisePoints.ElementAt(3), 1000, 1000)); // #5 Z
            Assert.IsTrue(PointIs(sites[4].ClockwisePoints.ElementAt(4), 1000, 800)); // #5 H
            Assert.IsTrue(PointIs(sites[4].ClockwisePoints.ElementAt(5), 600, 400)); // #5 D
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

            Assert.AreEqual(4, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 400, 600)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 200, 600)); // #1 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 200, 400)); // #1 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 400, 400)); // #1 has D
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(0), 200, 400)); // #1 C
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(1), 200, 600)); // #1 B
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(2), 400, 600)); // #1 A
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(3), 400, 400)); // #1 D
            Assert.AreEqual(5, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 400, 600)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 200, 600)); // #2 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 800, 1000)); // #2 has E
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 800)); // #2 has F
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 1000)); // #2 has Y
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(0), 200, 600)); // #2 B
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(1), 0, 800)); // #2 F
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(2), 0, 1000)); // #2 Y
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(3), 800, 1000)); // #2 E
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(4), 400, 600)); // #2 A
            Assert.AreEqual(4, sites[2].ClockwisePoints.Count()); // #3
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 200, 600)); // #3 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 200, 400)); // #3 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 0, 800)); // #3 has F
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 0, 200)); // #3 has G
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(0), 0, 800)); // #3 F
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(1), 200, 600)); // #3 B
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(2), 200, 400)); // #3 C
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(3), 0, 200)); // #3 G
            Assert.AreEqual(5, sites[3].ClockwisePoints.Count()); // #4
            Assert.IsTrue(SiteHasClockwisePoint(sites[3], 200, 400)); // #4 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[3], 400, 400)); // #4 has D
            Assert.IsTrue(SiteHasClockwisePoint(sites[3], 0, 200)); // #4 has G
            Assert.IsTrue(SiteHasClockwisePoint(sites[3], 800, 0)); // #4 has H
            Assert.IsTrue(SiteHasClockwisePoint(sites[3], 0, 0)); // #4 has W
            Assert.IsTrue(PointIs(sites[3].ClockwisePoints.ElementAt(0), 0, 0)); // #4 W
            Assert.IsTrue(PointIs(sites[3].ClockwisePoints.ElementAt(1), 0, 200)); // #4 G
            Assert.IsTrue(PointIs(sites[3].ClockwisePoints.ElementAt(2), 200, 400)); // #4 C
            Assert.IsTrue(PointIs(sites[3].ClockwisePoints.ElementAt(3), 400, 400)); // #4 D
            Assert.IsTrue(PointIs(sites[3].ClockwisePoints.ElementAt(4), 800, 0)); // #4 H
            Assert.AreEqual(6, sites[4].ClockwisePoints.Count()); // #5
            Assert.IsTrue(SiteHasClockwisePoint(sites[4], 400, 600)); // #5 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[4], 400, 400)); // #5 has D
            Assert.IsTrue(SiteHasClockwisePoint(sites[4], 800, 1000)); // #5 has E
            Assert.IsTrue(SiteHasClockwisePoint(sites[4], 800, 0)); // #5 has H
            Assert.IsTrue(SiteHasClockwisePoint(sites[4], 1000, 1000)); // #5 has X
            Assert.IsTrue(SiteHasClockwisePoint(sites[4], 1000, 0)); // #5 has Z
            Assert.IsTrue(PointIs(sites[4].ClockwisePoints.ElementAt(0), 400, 400)); // #5 D
            Assert.IsTrue(PointIs(sites[4].ClockwisePoints.ElementAt(1), 400, 600)); // #5 A
            Assert.IsTrue(PointIs(sites[4].ClockwisePoints.ElementAt(2), 800, 1000)); // #5 E
            Assert.IsTrue(PointIs(sites[4].ClockwisePoints.ElementAt(3), 1000, 1000)); // #5 X
            Assert.IsTrue(PointIs(sites[4].ClockwisePoints.ElementAt(4), 1000, 0)); // #5 Z
            Assert.IsTrue(PointIs(sites[4].ClockwisePoints.ElementAt(5), 800, 0)); // #5 H
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

            Assert.AreEqual(4, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 600, 600)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 600, 800)); // #1 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 400, 800)); // #1 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 400, 600)); // #1 has D
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(0), 400, 600)); // #1 D
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(1), 400, 800)); // #1 C
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(2), 600, 800)); // #1 B
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(3), 600, 600)); // #1 A
            Assert.AreEqual(5, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 600, 600)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 600, 800)); // #2 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 200)); // #2 has E
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 800, 1000)); // #2 has F
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 1000)); // #2 has Y
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(0), 600, 600)); // #2 A
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(1), 600, 800)); // #2 B
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(2), 800, 1000)); // #2 F
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(3), 1000, 1000)); // #2 Y
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(4), 1000, 200)); // #2 E
            Assert.AreEqual(4, sites[2].ClockwisePoints.Count()); // #3
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 600, 800)); // #3 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 400, 800)); // #3 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 800, 1000)); // #3 has F
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 200, 1000)); // #3 has G
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(0), 400, 800)); // #3 C
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(1), 200, 1000)); // #3 G
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(2), 800, 1000)); // #3 F
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(3), 600, 800)); // #3 B
            Assert.AreEqual(5, sites[3].ClockwisePoints.Count()); // #4
            Assert.IsTrue(SiteHasClockwisePoint(sites[3], 400, 800)); // #4 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[3], 400, 600)); // #4 has D
            Assert.IsTrue(SiteHasClockwisePoint(sites[3], 200, 1000)); // #4 has G
            Assert.IsTrue(SiteHasClockwisePoint(sites[3], 0, 200)); // #4 has H
            Assert.IsTrue(SiteHasClockwisePoint(sites[3], 0, 1000)); // #4 has W
            Assert.IsTrue(PointIs(sites[3].ClockwisePoints.ElementAt(0), 0, 1000)); // #4 W
            Assert.IsTrue(PointIs(sites[3].ClockwisePoints.ElementAt(1), 200, 1000)); // #4 G
            Assert.IsTrue(PointIs(sites[3].ClockwisePoints.ElementAt(2), 400, 800)); // #4 C
            Assert.IsTrue(PointIs(sites[3].ClockwisePoints.ElementAt(3), 400, 600)); // #4 D
            Assert.IsTrue(PointIs(sites[3].ClockwisePoints.ElementAt(4), 0, 200)); // #4 H
            Assert.AreEqual(6, sites[4].ClockwisePoints.Count()); // #5
            Assert.IsTrue(SiteHasClockwisePoint(sites[4], 600, 600)); // #5 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[4], 400, 600)); // #5 has D
            Assert.IsTrue(SiteHasClockwisePoint(sites[4], 1000, 200)); // #5 has E
            Assert.IsTrue(SiteHasClockwisePoint(sites[4], 0, 200)); // #5 has H
            Assert.IsTrue(SiteHasClockwisePoint(sites[4], 1000, 0)); // #5 has X
            Assert.IsTrue(SiteHasClockwisePoint(sites[4], 0, 0)); // #5 has Z
            Assert.IsTrue(PointIs(sites[4].ClockwisePoints.ElementAt(0), 0, 0)); // #5 Z
            Assert.IsTrue(PointIs(sites[4].ClockwisePoints.ElementAt(1), 0, 200)); // #5 H
            Assert.IsTrue(PointIs(sites[4].ClockwisePoints.ElementAt(2), 400, 600)); // #5 D
            Assert.IsTrue(PointIs(sites[4].ClockwisePoints.ElementAt(3), 600, 600)); // #5 A
            Assert.IsTrue(PointIs(sites[4].ClockwisePoints.ElementAt(4), 1000, 200)); // #5 E
            Assert.IsTrue(PointIs(sites[4].ClockwisePoints.ElementAt(5), 1000, 0)); // #5 X
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

            Assert.AreEqual(4, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 600, 400)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 800, 400)); // #1 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 800, 600)); // #1 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 600, 600)); // #1 has D
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(0), 600, 400)); // #1 A
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(1), 600, 600)); // #1 D
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(2), 800, 600)); // #1 C
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(3), 800, 400)); // #1 B
            Assert.AreEqual(5, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 600, 400)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 800, 400)); // #2 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 200, 0)); // #2 has E
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 200)); // #2 has F
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 1000, 0)); // #2 has Y
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(0), 200, 0)); // #2 E
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(1), 600, 400)); // #2 A
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(2), 800, 400)); // #2 B
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(3), 1000, 200)); // #2 F
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(4), 1000, 0)); // #2 Y
            Assert.AreEqual(4, sites[2].ClockwisePoints.Count()); // #3
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 800, 400)); // #3 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 800, 600)); // #3 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 1000, 200)); // #3 has F
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 1000, 800)); // #3 has G
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(0), 800, 400)); // #3 B
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(1), 800, 600)); // #3 C
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(2), 1000, 800)); // #3 G
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(3), 1000, 200)); // #3 F
            Assert.AreEqual(5, sites[3].ClockwisePoints.Count()); // #4
            Assert.IsTrue(SiteHasClockwisePoint(sites[3], 800, 600)); // #4 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[3], 600, 600)); // #4 has D
            Assert.IsTrue(SiteHasClockwisePoint(sites[3], 1000, 800)); // #4 has G
            Assert.IsTrue(SiteHasClockwisePoint(sites[3], 200, 1000)); // #4 has H
            Assert.IsTrue(SiteHasClockwisePoint(sites[3], 1000, 1000)); // #4 has W
            Assert.IsTrue(PointIs(sites[3].ClockwisePoints.ElementAt(0), 600, 600)); // #4 D
            Assert.IsTrue(PointIs(sites[3].ClockwisePoints.ElementAt(1), 200, 1000)); // #4 H
            Assert.IsTrue(PointIs(sites[3].ClockwisePoints.ElementAt(2), 1000, 1000)); // #4 W
            Assert.IsTrue(PointIs(sites[3].ClockwisePoints.ElementAt(3), 1000, 800)); // #4 G
            Assert.IsTrue(PointIs(sites[3].ClockwisePoints.ElementAt(4), 800, 600)); // #4 C
            Assert.AreEqual(6, sites[4].ClockwisePoints.Count()); // #5
            Assert.IsTrue(SiteHasClockwisePoint(sites[4], 600, 400)); // #5 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[4], 600, 600)); // #5 has D
            Assert.IsTrue(SiteHasClockwisePoint(sites[4], 200, 0)); // #5 has E
            Assert.IsTrue(SiteHasClockwisePoint(sites[4], 200, 1000)); // #5 has H
            Assert.IsTrue(SiteHasClockwisePoint(sites[4], 0, 0)); // #5 has X
            Assert.IsTrue(SiteHasClockwisePoint(sites[4], 0, 1000)); // #5 has Z
            Assert.IsTrue(PointIs(sites[4].ClockwisePoints.ElementAt(0), 0, 0)); // #5 X
            Assert.IsTrue(PointIs(sites[4].ClockwisePoints.ElementAt(1), 0, 1000)); // #5 Z
            Assert.IsTrue(PointIs(sites[4].ClockwisePoints.ElementAt(2), 200, 1000)); // #5 H
            Assert.IsTrue(PointIs(sites[4].ClockwisePoints.ElementAt(3), 600, 600)); // #5 D
            Assert.IsTrue(PointIs(sites[4].ClockwisePoints.ElementAt(4), 600, 400)); // #5 A
            Assert.IsTrue(PointIs(sites[4].ClockwisePoints.ElementAt(5), 200, 0)); // #5 E
        }

        [Test]
        public void FourEquidistantPointsAroundMiddle()
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

            Assert.AreEqual(4, sites[0].ClockwisePoints.Count()); // #1
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 500, 500)); // #1 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 500, 1000)); // #1 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 0, 500)); // #1 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[0], 0, 1000)); // #1 has X
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(0), 0, 500)); // #1 C
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(1), 0, 1000)); // #1 X
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(2), 500, 1000)); // #1 B
            Assert.IsTrue(PointIs(sites[0].ClockwisePoints.ElementAt(3), 500, 500)); // #1 A
            Assert.AreEqual(4, sites[1].ClockwisePoints.Count()); // #2
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 500, 500)); // #2 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 500)); // #2 has C
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 500, 0)); // #2 has D
            Assert.IsTrue(SiteHasClockwisePoint(sites[1], 0, 0)); // #2 has Y
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(0), 0, 0)); // #2 Y
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(1), 0, 500)); // #2 C
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(2), 500, 500)); // #2 A
            Assert.IsTrue(PointIs(sites[1].ClockwisePoints.ElementAt(3), 500, 0)); // #2 D
            Assert.AreEqual(4, sites[2].ClockwisePoints.Count()); // #3
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 500, 500)); // #3 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 500, 0)); // #3 has D
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 1000, 500)); // #3 has E
            Assert.IsTrue(SiteHasClockwisePoint(sites[2], 1000, 0)); // #3 has W
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(0), 500, 500)); // #3 A
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(1), 1000, 500)); // #3 E
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(2), 1000, 0)); // #3 W
            Assert.IsTrue(PointIs(sites[2].ClockwisePoints.ElementAt(3), 500, 0)); // #3 D
            Assert.AreEqual(4, sites[3].ClockwisePoints.Count()); // #4
            Assert.IsTrue(SiteHasClockwisePoint(sites[3], 500, 500)); // #4 has A
            Assert.IsTrue(SiteHasClockwisePoint(sites[3], 500, 1000)); // #4 has B
            Assert.IsTrue(SiteHasClockwisePoint(sites[3], 1000, 500)); // #4 has E
            Assert.IsTrue(SiteHasClockwisePoint(sites[3], 1000, 1000)); // #4 has Z
            Assert.IsTrue(PointIs(sites[3].ClockwisePoints.ElementAt(0), 500, 500)); // #4 A
            Assert.IsTrue(PointIs(sites[3].ClockwisePoints.ElementAt(1), 500, 1000)); // #4 B
            Assert.IsTrue(PointIs(sites[3].ClockwisePoints.ElementAt(2), 1000, 1000)); // #4 Z
            Assert.IsTrue(PointIs(sites[3].ClockwisePoints.ElementAt(3), 1000, 500)); // #4 E
        }

    }
}
