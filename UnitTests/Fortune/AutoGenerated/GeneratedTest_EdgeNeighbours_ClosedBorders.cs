using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using VoronoiLib;
using VoronoiLib.Structures;
using static UnitTests.CommonTestUtilities;

namespace UnitTests
{
    /// <summary>
    /// These tests assert that <see cref="VoronoiEdge"/>`s have expected neighbouring edges.
    /// Specifically, that the <see cref="VoronoiEdge.Neighbours"/> contains the expected <see cref="VoronoiEdge"/>`s.
    /// </summary>
    /// <remarks>
    /// This is an AUTO-GENERATED test fixture class from UnitTestGenerator.
    /// This is one of the several auto-generated fixture classes each checking a different part of the algorithm's result.
    /// It contains a bunch of known Voronoi site layouts, including many edge cases.
    /// </remarks>
    [Parallelizable(ParallelScope.All)]
    [TestFixture]
    public class GeneratedTest_EdgeNeighbours_ClosedBorders
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

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            VoronoiEdge edge = FindEdge(edges, 0, 1000, 0, 0); // X-Y
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // X-Y neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // X-Y neighbours Z-X
            edge = FindEdge(edges, 0, 0, 1000, 0); // Y-W
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // Y-W neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // Y-W neighbours W-Z
            edge = FindEdge(edges, 1000, 0, 1000, 1000); // W-Z
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // W-Z neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // W-Z neighbours Z-X
            edge = FindEdge(edges, 1000, 1000, 0, 1000); // Z-X
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // Z-X neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // Z-X neighbours W-Z
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

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            VoronoiEdge edge = FindEdge(edges, 0, 500, 1000, 500); // A-B
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 500))); // A-B neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 0, 0))); // A-B neighbours A-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 500))); // A-B neighbours W-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 500, 1000, 1000))); // A-B neighbours B-Z
            edge = FindEdge(edges, 0, 1000, 0, 500); // X-A
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 1000, 500))); // X-A neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 0, 0))); // X-A neighbours A-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // X-A neighbours Z-X
            edge = FindEdge(edges, 0, 500, 0, 0); // A-Y
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 1000, 500))); // A-Y neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 500))); // A-Y neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // A-Y neighbours Y-W
            edge = FindEdge(edges, 0, 0, 1000, 0); // Y-W
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 0, 0))); // Y-W neighbours A-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 500))); // Y-W neighbours W-B
            edge = FindEdge(edges, 1000, 0, 1000, 500); // W-B
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 1000, 500))); // W-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // W-B neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 500, 1000, 1000))); // W-B neighbours B-Z
            edge = FindEdge(edges, 1000, 500, 1000, 1000); // B-Z
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 1000, 500))); // B-Z neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 500))); // B-Z neighbours W-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // B-Z neighbours Z-X
            edge = FindEdge(edges, 1000, 1000, 0, 1000); // Z-X
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 500))); // Z-X neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 500, 1000, 1000))); // Z-X neighbours B-Z
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

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            VoronoiEdge edge = FindEdge(edges, 500, 1000, 500, 0); // A-B
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 500, 1000))); // A-B neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 1000, 0, 1000))); // A-B neighbours A-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 500, 0))); // A-B neighbours W-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 0, 1000, 0))); // A-B neighbours B-Z
            edge = FindEdge(edges, 1000, 1000, 500, 1000); // X-A
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 1000, 500, 0))); // X-A neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 1000, 0, 1000))); // X-A neighbours A-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // X-A neighbours Z-X
            edge = FindEdge(edges, 500, 1000, 0, 1000); // A-Y
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 1000, 500, 0))); // A-Y neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 500, 1000))); // A-Y neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // A-Y neighbours Y-W
            edge = FindEdge(edges, 0, 1000, 0, 0); // Y-W
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 1000, 0, 1000))); // Y-W neighbours A-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 500, 0))); // Y-W neighbours W-B
            edge = FindEdge(edges, 0, 0, 500, 0); // W-B
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 1000, 500, 0))); // W-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // W-B neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 0, 1000, 0))); // W-B neighbours B-Z
            edge = FindEdge(edges, 500, 0, 1000, 0); // B-Z
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 1000, 500, 0))); // B-Z neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 500, 0))); // B-Z neighbours W-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // B-Z neighbours Z-X
            edge = FindEdge(edges, 1000, 0, 1000, 1000); // Z-X
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 500, 1000))); // Z-X neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 0, 1000, 0))); // Z-X neighbours B-Z
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

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            VoronoiEdge edge = FindEdge(edges, 0, 700, 1000, 700); // A-B
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 700))); // A-B neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 0, 0))); // A-B neighbours A-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 700))); // A-B neighbours W-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 700, 1000, 1000))); // A-B neighbours B-Z
            edge = FindEdge(edges, 0, 1000, 0, 700); // X-A
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 1000, 700))); // X-A neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 0, 0))); // X-A neighbours A-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // X-A neighbours Z-X
            edge = FindEdge(edges, 0, 700, 0, 0); // A-Y
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 1000, 700))); // A-Y neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 700))); // A-Y neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // A-Y neighbours Y-W
            edge = FindEdge(edges, 0, 0, 1000, 0); // Y-W
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 0, 0))); // Y-W neighbours A-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 700))); // Y-W neighbours W-B
            edge = FindEdge(edges, 1000, 0, 1000, 700); // W-B
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 1000, 700))); // W-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // W-B neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 700, 1000, 1000))); // W-B neighbours B-Z
            edge = FindEdge(edges, 1000, 700, 1000, 1000); // B-Z
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 1000, 700))); // B-Z neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 700))); // B-Z neighbours W-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // B-Z neighbours Z-X
            edge = FindEdge(edges, 1000, 1000, 0, 1000); // Z-X
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 700))); // Z-X neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 700, 1000, 1000))); // Z-X neighbours B-Z
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

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            VoronoiEdge edge = FindEdge(edges, 700, 1000, 700, 0); // A-B
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 700, 1000))); // A-B neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 1000, 0, 1000))); // A-B neighbours A-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 700, 0))); // A-B neighbours W-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 0, 1000, 0))); // A-B neighbours B-Z
            edge = FindEdge(edges, 1000, 1000, 700, 1000); // X-A
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 1000, 700, 0))); // X-A neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 1000, 0, 1000))); // X-A neighbours A-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // X-A neighbours Z-X
            edge = FindEdge(edges, 700, 1000, 0, 1000); // A-Y
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 1000, 700, 0))); // A-Y neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 700, 1000))); // A-Y neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // A-Y neighbours Y-W
            edge = FindEdge(edges, 0, 1000, 0, 0); // Y-W
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 1000, 0, 1000))); // Y-W neighbours A-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 700, 0))); // Y-W neighbours W-B
            edge = FindEdge(edges, 0, 0, 700, 0); // W-B
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 1000, 700, 0))); // W-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // W-B neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 0, 1000, 0))); // W-B neighbours B-Z
            edge = FindEdge(edges, 700, 0, 1000, 0); // B-Z
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 1000, 700, 0))); // B-Z neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 700, 0))); // B-Z neighbours W-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // B-Z neighbours Z-X
            edge = FindEdge(edges, 1000, 0, 1000, 1000); // Z-X
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 700, 1000))); // Z-X neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 0, 1000, 0))); // Z-X neighbours B-Z
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

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            VoronoiEdge edge = FindEdge(edges, 0, 700, 1000, 700); // A-B
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 700))); // A-B neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 0, 300))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 300, 1000, 700))); // A-B neighbours D-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 700, 1000, 1000))); // A-B neighbours B-Z
            edge = FindEdge(edges, 0, 300, 1000, 300); // C-D
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 0, 300))); // C-D neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 300, 0, 0))); // C-D neighbours C-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 300))); // C-D neighbours W-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 300, 1000, 700))); // C-D neighbours D-B
            edge = FindEdge(edges, 0, 1000, 0, 700); // X-A
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 1000, 700))); // X-A neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 0, 300))); // X-A neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // X-A neighbours Z-X
            edge = FindEdge(edges, 0, 700, 0, 300); // A-C
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 1000, 700))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 300, 1000, 300))); // A-C neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 700))); // A-C neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 300, 0, 0))); // A-C neighbours C-Y
            edge = FindEdge(edges, 0, 300, 0, 0); // C-Y
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 300, 1000, 300))); // C-Y neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 0, 300))); // C-Y neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // C-Y neighbours Y-W
            edge = FindEdge(edges, 0, 0, 1000, 0); // Y-W
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 300, 0, 0))); // Y-W neighbours C-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 300))); // Y-W neighbours W-D
            edge = FindEdge(edges, 1000, 0, 1000, 300); // W-D
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 300, 1000, 300))); // W-D neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // W-D neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 300, 1000, 700))); // W-D neighbours D-B
            edge = FindEdge(edges, 1000, 300, 1000, 700); // D-B
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 1000, 700))); // D-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 300, 1000, 300))); // D-B neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 300))); // D-B neighbours W-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 700, 1000, 1000))); // D-B neighbours B-Z
            edge = FindEdge(edges, 1000, 700, 1000, 1000); // B-Z
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 1000, 700))); // B-Z neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 300, 1000, 700))); // B-Z neighbours D-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // B-Z neighbours Z-X
            edge = FindEdge(edges, 1000, 1000, 0, 1000); // Z-X
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 700))); // Z-X neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 700, 1000, 1000))); // Z-X neighbours B-Z
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

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            VoronoiEdge edge = FindEdge(edges, 700, 1000, 700, 0); // A-B
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 700, 1000))); // A-B neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 1000, 300, 1000))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 0, 700, 0))); // A-B neighbours D-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 0, 1000, 0))); // A-B neighbours B-Z
            edge = FindEdge(edges, 300, 1000, 300, 0); // C-D
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 1000, 300, 1000))); // C-D neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 1000, 0, 1000))); // C-D neighbours C-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 300, 0))); // C-D neighbours W-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 0, 700, 0))); // C-D neighbours D-B
            edge = FindEdge(edges, 1000, 1000, 700, 1000); // X-A
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 1000, 700, 0))); // X-A neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 1000, 300, 1000))); // X-A neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // X-A neighbours Z-X
            edge = FindEdge(edges, 700, 1000, 300, 1000); // A-C
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 1000, 700, 0))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 1000, 300, 0))); // A-C neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 700, 1000))); // A-C neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 1000, 0, 1000))); // A-C neighbours C-Y
            edge = FindEdge(edges, 300, 1000, 0, 1000); // C-Y
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 1000, 300, 0))); // C-Y neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 1000, 300, 1000))); // C-Y neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // C-Y neighbours Y-W
            edge = FindEdge(edges, 0, 1000, 0, 0); // Y-W
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 1000, 0, 1000))); // Y-W neighbours C-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 300, 0))); // Y-W neighbours W-D
            edge = FindEdge(edges, 0, 0, 300, 0); // W-D
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 1000, 300, 0))); // W-D neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // W-D neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 0, 700, 0))); // W-D neighbours D-B
            edge = FindEdge(edges, 300, 0, 700, 0); // D-B
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 1000, 700, 0))); // D-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 1000, 300, 0))); // D-B neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 300, 0))); // D-B neighbours W-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 0, 1000, 0))); // D-B neighbours B-Z
            edge = FindEdge(edges, 700, 0, 1000, 0); // B-Z
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 1000, 700, 0))); // B-Z neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 0, 700, 0))); // B-Z neighbours D-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // B-Z neighbours Z-X
            edge = FindEdge(edges, 1000, 0, 1000, 1000); // Z-X
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 700, 1000))); // Z-X neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 0, 1000, 0))); // Z-X neighbours B-Z
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

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            VoronoiEdge edge = FindEdge(edges, 0, 700, 1000, 700); // A-B
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 700))); // A-B neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 0, 500))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 500, 1000, 700))); // A-B neighbours D-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 700, 1000, 1000))); // A-B neighbours B-Z
            edge = FindEdge(edges, 0, 500, 1000, 500); // C-D
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 0, 500))); // C-D neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 0, 300))); // C-D neighbours C-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 300, 1000, 500))); // C-D neighbours F-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 500, 1000, 700))); // C-D neighbours D-B
            edge = FindEdge(edges, 0, 300, 1000, 300); // E-F
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 0, 300))); // E-F neighbours C-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 300, 0, 0))); // E-F neighbours E-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 300))); // E-F neighbours W-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 300, 1000, 500))); // E-F neighbours F-D
            edge = FindEdge(edges, 0, 1000, 0, 700); // X-A
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 1000, 700))); // X-A neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 0, 500))); // X-A neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // X-A neighbours Z-X
            edge = FindEdge(edges, 0, 700, 0, 500); // A-C
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 1000, 700))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 1000, 500))); // A-C neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 700))); // A-C neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 0, 300))); // A-C neighbours C-E
            edge = FindEdge(edges, 0, 500, 0, 300); // C-E
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 1000, 500))); // C-E neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 300, 1000, 300))); // C-E neighbours E-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 0, 500))); // C-E neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 300, 0, 0))); // C-E neighbours E-Y
            edge = FindEdge(edges, 0, 300, 0, 0); // E-Y
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 300, 1000, 300))); // E-Y neighbours E-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 0, 300))); // E-Y neighbours C-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // E-Y neighbours Y-W
            edge = FindEdge(edges, 0, 0, 1000, 0); // Y-W
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 300, 0, 0))); // Y-W neighbours E-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 300))); // Y-W neighbours W-F
            edge = FindEdge(edges, 1000, 0, 1000, 300); // W-F
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 300, 1000, 300))); // W-F neighbours E-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // W-F neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 300, 1000, 500))); // W-F neighbours F-D
            edge = FindEdge(edges, 1000, 300, 1000, 500); // F-D
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 1000, 500))); // F-D neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 300, 1000, 300))); // F-D neighbours E-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 300))); // F-D neighbours W-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 500, 1000, 700))); // F-D neighbours D-B
            edge = FindEdge(edges, 1000, 500, 1000, 700); // D-B
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 1000, 700))); // D-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 1000, 500))); // D-B neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 300, 1000, 500))); // D-B neighbours F-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 700, 1000, 1000))); // D-B neighbours B-Z
            edge = FindEdge(edges, 1000, 700, 1000, 1000); // B-Z
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 1000, 700))); // B-Z neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 500, 1000, 700))); // B-Z neighbours D-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // B-Z neighbours Z-X
            edge = FindEdge(edges, 1000, 1000, 0, 1000); // Z-X
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 700))); // Z-X neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 700, 1000, 1000))); // Z-X neighbours B-Z
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

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            VoronoiEdge edge = FindEdge(edges, 700, 1000, 700, 0); // A-B
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 700, 1000))); // A-B neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 1000, 500, 1000))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 0, 700, 0))); // A-B neighbours D-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 0, 1000, 0))); // A-B neighbours B-Z
            edge = FindEdge(edges, 500, 1000, 500, 0); // C-D
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 1000, 500, 1000))); // C-D neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 1000, 300, 1000))); // C-D neighbours C-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 0, 500, 0))); // C-D neighbours F-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 0, 700, 0))); // C-D neighbours D-B
            edge = FindEdge(edges, 300, 1000, 300, 0); // E-F
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 1000, 300, 1000))); // E-F neighbours C-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 1000, 0, 1000))); // E-F neighbours E-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 300, 0))); // E-F neighbours W-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 0, 500, 0))); // E-F neighbours F-D
            edge = FindEdge(edges, 1000, 1000, 700, 1000); // X-A
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 1000, 700, 0))); // X-A neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 1000, 500, 1000))); // X-A neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // X-A neighbours Z-X
            edge = FindEdge(edges, 700, 1000, 500, 1000); // A-C
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 1000, 700, 0))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 1000, 500, 0))); // A-C neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 700, 1000))); // A-C neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 1000, 300, 1000))); // A-C neighbours C-E
            edge = FindEdge(edges, 500, 1000, 300, 1000); // C-E
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 1000, 500, 0))); // C-E neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 1000, 300, 0))); // C-E neighbours E-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 1000, 500, 1000))); // C-E neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 1000, 0, 1000))); // C-E neighbours E-Y
            edge = FindEdge(edges, 300, 1000, 0, 1000); // E-Y
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 1000, 300, 0))); // E-Y neighbours E-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 1000, 300, 1000))); // E-Y neighbours C-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // E-Y neighbours Y-W
            edge = FindEdge(edges, 0, 1000, 0, 0); // Y-W
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 1000, 0, 1000))); // Y-W neighbours E-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 300, 0))); // Y-W neighbours W-F
            edge = FindEdge(edges, 0, 0, 300, 0); // W-F
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 1000, 300, 0))); // W-F neighbours E-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // W-F neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 0, 500, 0))); // W-F neighbours F-D
            edge = FindEdge(edges, 300, 0, 500, 0); // F-D
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 1000, 500, 0))); // F-D neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 1000, 300, 0))); // F-D neighbours E-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 300, 0))); // F-D neighbours W-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 0, 700, 0))); // F-D neighbours D-B
            edge = FindEdge(edges, 500, 0, 700, 0); // D-B
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 1000, 700, 0))); // D-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 1000, 500, 0))); // D-B neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 0, 500, 0))); // D-B neighbours F-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 0, 1000, 0))); // D-B neighbours B-Z
            edge = FindEdge(edges, 700, 0, 1000, 0); // B-Z
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 1000, 700, 0))); // B-Z neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 0, 700, 0))); // B-Z neighbours D-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // B-Z neighbours Z-X
            edge = FindEdge(edges, 1000, 0, 1000, 1000); // Z-X
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 700, 1000))); // Z-X neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 0, 1000, 0))); // Z-X neighbours B-Z
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

            // 1000 X------------------------------------------------⁕B
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
            //    0 A⁕------------------------------------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            VoronoiEdge edge = FindEdge(edges, 0, 0, 1000, 1000); // A-B
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // A-B neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // A-B neighbours A-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // A-B neighbours Y-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // A-B neighbours B-X
            edge = FindEdge(edges, 0, 1000, 0, 0); // X-A
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 1000))); // X-A neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // X-A neighbours A-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // X-A neighbours B-X
            edge = FindEdge(edges, 0, 0, 1000, 0); // A-Y
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 1000))); // A-Y neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // A-Y neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // A-Y neighbours Y-B
            edge = FindEdge(edges, 1000, 0, 1000, 1000); // Y-B
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 1000))); // Y-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // Y-B neighbours A-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // Y-B neighbours B-X
            edge = FindEdge(edges, 1000, 1000, 0, 1000); // B-X
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 1000))); // B-X neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // B-X neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // B-X neighbours Y-B
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

            // 1000 A⁕------------------------------------------------X
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
            //    0 Y------------------------------------------------⁕B
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            VoronoiEdge edge = FindEdge(edges, 0, 1000, 1000, 0); // A-B
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // A-B neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // A-B neighbours A-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // A-B neighbours Y-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // A-B neighbours B-X
            edge = FindEdge(edges, 1000, 1000, 0, 1000); // X-A
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 1000, 0))); // X-A neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // X-A neighbours A-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // X-A neighbours B-X
            edge = FindEdge(edges, 0, 1000, 0, 0); // A-Y
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 1000, 0))); // A-Y neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // A-Y neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // A-Y neighbours Y-B
            edge = FindEdge(edges, 0, 0, 1000, 0); // Y-B
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 1000, 0))); // Y-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // Y-B neighbours A-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // Y-B neighbours B-X
            edge = FindEdge(edges, 1000, 0, 1000, 1000); // B-X
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 1000, 0))); // B-X neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // B-X neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // B-X neighbours Y-B
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

            // 1000 X--------------------------------------⁕B---------Z
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

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            VoronoiEdge edge = FindEdge(edges, 0, 200, 800, 1000); // A-B
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 200))); // A-B neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 200, 0, 0))); // A-B neighbours A-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 800, 1000))); // A-B neighbours Z-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 1000, 0, 1000))); // A-B neighbours B-X
            edge = FindEdge(edges, 0, 1000, 0, 200); // X-A
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 200, 800, 1000))); // X-A neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 200, 0, 0))); // X-A neighbours A-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 1000, 0, 1000))); // X-A neighbours B-X
            edge = FindEdge(edges, 0, 200, 0, 0); // A-Y
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 200, 800, 1000))); // A-Y neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 200))); // A-Y neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // A-Y neighbours Y-W
            edge = FindEdge(edges, 0, 0, 1000, 0); // Y-W
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 200, 0, 0))); // Y-W neighbours A-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // Y-W neighbours W-Z
            edge = FindEdge(edges, 1000, 0, 1000, 1000); // W-Z
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // W-Z neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 800, 1000))); // W-Z neighbours Z-B
            edge = FindEdge(edges, 1000, 1000, 800, 1000); // Z-B
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 200, 800, 1000))); // Z-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // Z-B neighbours W-Z
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 1000, 0, 1000))); // Z-B neighbours B-X
            edge = FindEdge(edges, 800, 1000, 0, 1000); // B-X
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 200, 800, 1000))); // B-X neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 200))); // B-X neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 800, 1000))); // B-X neighbours Z-B
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

            // 1000 Y---------A⁕--------------------------------------X
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

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            VoronoiEdge edge = FindEdge(edges, 200, 1000, 1000, 200); // A-B
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 200, 1000))); // A-B neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 1000, 0, 1000))); // A-B neighbours A-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 200))); // A-B neighbours Z-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 200, 1000, 1000))); // A-B neighbours B-X
            edge = FindEdge(edges, 1000, 1000, 200, 1000); // X-A
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 1000, 1000, 200))); // X-A neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 1000, 0, 1000))); // X-A neighbours A-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 200, 1000, 1000))); // X-A neighbours B-X
            edge = FindEdge(edges, 200, 1000, 0, 1000); // A-Y
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 1000, 1000, 200))); // A-Y neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 200, 1000))); // A-Y neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // A-Y neighbours Y-W
            edge = FindEdge(edges, 0, 1000, 0, 0); // Y-W
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 1000, 0, 1000))); // Y-W neighbours A-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // Y-W neighbours W-Z
            edge = FindEdge(edges, 0, 0, 1000, 0); // W-Z
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // W-Z neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 200))); // W-Z neighbours Z-B
            edge = FindEdge(edges, 1000, 0, 1000, 200); // Z-B
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 1000, 1000, 200))); // Z-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // Z-B neighbours W-Z
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 200, 1000, 1000))); // Z-B neighbours B-X
            edge = FindEdge(edges, 1000, 200, 1000, 1000); // B-X
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 1000, 1000, 200))); // B-X neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 200, 1000))); // B-X neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 200))); // B-X neighbours Z-B
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
            //    0 Z---------B⁕--------------------------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            VoronoiEdge edge = FindEdge(edges, 1000, 800, 200, 0); // A-B
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 800))); // A-B neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 800, 1000, 1000))); // A-B neighbours A-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 200, 0))); // A-B neighbours Z-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 0, 1000, 0))); // A-B neighbours B-X
            edge = FindEdge(edges, 1000, 0, 1000, 800); // X-A
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 800, 200, 0))); // X-A neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 800, 1000, 1000))); // X-A neighbours A-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 0, 1000, 0))); // X-A neighbours B-X
            edge = FindEdge(edges, 1000, 800, 1000, 1000); // A-Y
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 800, 200, 0))); // A-Y neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 800))); // A-Y neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // A-Y neighbours Y-W
            edge = FindEdge(edges, 1000, 1000, 0, 1000); // Y-W
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 800, 1000, 1000))); // Y-W neighbours A-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // Y-W neighbours W-Z
            edge = FindEdge(edges, 0, 1000, 0, 0); // W-Z
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // W-Z neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 200, 0))); // W-Z neighbours Z-B
            edge = FindEdge(edges, 0, 0, 200, 0); // Z-B
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 800, 200, 0))); // Z-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // Z-B neighbours W-Z
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 0, 1000, 0))); // Z-B neighbours B-X
            edge = FindEdge(edges, 200, 0, 1000, 0); // B-X
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 800, 200, 0))); // B-X neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 800))); // B-X neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 200, 0))); // B-X neighbours Z-B
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
            //    0 X--------------------------------------⁕A---------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            VoronoiEdge edge = FindEdge(edges, 800, 0, 0, 800); // A-B
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 800, 0))); // A-B neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 0, 1000, 0))); // A-B neighbours A-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 800))); // A-B neighbours Z-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 800, 0, 0))); // A-B neighbours B-X
            edge = FindEdge(edges, 0, 0, 800, 0); // X-A
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 0, 0, 800))); // X-A neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 0, 1000, 0))); // X-A neighbours A-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 800, 0, 0))); // X-A neighbours B-X
            edge = FindEdge(edges, 800, 0, 1000, 0); // A-Y
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 0, 0, 800))); // A-Y neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 800, 0))); // A-Y neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // A-Y neighbours Y-W
            edge = FindEdge(edges, 1000, 0, 1000, 1000); // Y-W
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 0, 1000, 0))); // Y-W neighbours A-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // Y-W neighbours W-Z
            edge = FindEdge(edges, 1000, 1000, 0, 1000); // W-Z
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // W-Z neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 800))); // W-Z neighbours Z-B
            edge = FindEdge(edges, 0, 1000, 0, 800); // Z-B
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 0, 0, 800))); // Z-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // Z-B neighbours W-Z
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 800, 0, 0))); // Z-B neighbours B-X
            edge = FindEdge(edges, 0, 800, 0, 0); // B-X
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 0, 0, 800))); // B-X neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 800, 0))); // B-X neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 800))); // B-X neighbours Z-B
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

            // 1000 X---------------------------------⁕D--------------Z
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
            //    0 Y--------------B⁕---------------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            VoronoiEdge edge = FindEdge(edges, 0, 300, 700, 1000); // A-D
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 300))); // A-D neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 300, 0, 0))); // A-D neighbours A-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 700, 1000))); // A-D neighbours Z-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 1000, 0, 1000))); // A-D neighbours D-X
            edge = FindEdge(edges, 300, 0, 1000, 700); // B-C
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 300, 0))); // B-C neighbours Y-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 0, 1000, 0))); // B-C neighbours B-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 700))); // B-C neighbours W-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 700, 1000, 1000))); // B-C neighbours C-Z
            edge = FindEdge(edges, 0, 1000, 0, 300); // X-A
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 300, 700, 1000))); // X-A neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 300, 0, 0))); // X-A neighbours A-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 1000, 0, 1000))); // X-A neighbours D-X
            edge = FindEdge(edges, 0, 300, 0, 0); // A-Y
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 300, 700, 1000))); // A-Y neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 300))); // A-Y neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 300, 0))); // A-Y neighbours Y-B
            edge = FindEdge(edges, 0, 0, 300, 0); // Y-B
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 0, 1000, 700))); // Y-B neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 300, 0, 0))); // Y-B neighbours A-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 0, 1000, 0))); // Y-B neighbours B-W
            edge = FindEdge(edges, 300, 0, 1000, 0); // B-W
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 0, 1000, 700))); // B-W neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 300, 0))); // B-W neighbours Y-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 700))); // B-W neighbours W-C
            edge = FindEdge(edges, 1000, 0, 1000, 700); // W-C
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 0, 1000, 700))); // W-C neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 0, 1000, 0))); // W-C neighbours B-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 700, 1000, 1000))); // W-C neighbours C-Z
            edge = FindEdge(edges, 1000, 700, 1000, 1000); // C-Z
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 0, 1000, 700))); // C-Z neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 700))); // C-Z neighbours W-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 700, 1000))); // C-Z neighbours Z-D
            edge = FindEdge(edges, 1000, 1000, 700, 1000); // Z-D
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 300, 700, 1000))); // Z-D neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 700, 1000, 1000))); // Z-D neighbours C-Z
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 1000, 0, 1000))); // Z-D neighbours D-X
            edge = FindEdge(edges, 700, 1000, 0, 1000); // D-X
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 300, 700, 1000))); // D-X neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 300))); // D-X neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 700, 1000))); // D-X neighbours Z-D
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

            // 1000 Y--------------A⁕---------------------------------X
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
            //    0 W---------------------------------⁕C--------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            VoronoiEdge edge = FindEdge(edges, 300, 1000, 1000, 300); // A-D
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 300, 1000))); // A-D neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 1000, 0, 1000))); // A-D neighbours A-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 300))); // A-D neighbours Z-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 300, 1000, 1000))); // A-D neighbours D-X
            edge = FindEdge(edges, 0, 700, 700, 0); // B-C
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 700))); // B-C neighbours Y-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 0, 0))); // B-C neighbours B-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 700, 0))); // B-C neighbours W-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 0, 1000, 0))); // B-C neighbours C-Z
            edge = FindEdge(edges, 1000, 1000, 300, 1000); // X-A
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 1000, 1000, 300))); // X-A neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 1000, 0, 1000))); // X-A neighbours A-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 300, 1000, 1000))); // X-A neighbours D-X
            edge = FindEdge(edges, 300, 1000, 0, 1000); // A-Y
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 1000, 1000, 300))); // A-Y neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 300, 1000))); // A-Y neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 700))); // A-Y neighbours Y-B
            edge = FindEdge(edges, 0, 1000, 0, 700); // Y-B
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 700, 0))); // Y-B neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 1000, 0, 1000))); // Y-B neighbours A-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 0, 0))); // Y-B neighbours B-W
            edge = FindEdge(edges, 0, 700, 0, 0); // B-W
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 700, 0))); // B-W neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 700))); // B-W neighbours Y-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 700, 0))); // B-W neighbours W-C
            edge = FindEdge(edges, 0, 0, 700, 0); // W-C
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 700, 0))); // W-C neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 0, 0))); // W-C neighbours B-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 0, 1000, 0))); // W-C neighbours C-Z
            edge = FindEdge(edges, 700, 0, 1000, 0); // C-Z
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 700, 0))); // C-Z neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 700, 0))); // C-Z neighbours W-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 300))); // C-Z neighbours Z-D
            edge = FindEdge(edges, 1000, 0, 1000, 300); // Z-D
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 1000, 1000, 300))); // Z-D neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 0, 1000, 0))); // Z-D neighbours C-Z
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 300, 1000, 1000))); // Z-D neighbours D-X
            edge = FindEdge(edges, 1000, 300, 1000, 1000); // D-X
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 1000, 1000, 300))); // D-X neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 300, 1000))); // D-X neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 300))); // D-X neighbours Z-D
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

            // 1000 X----------------------------⁕D------------------⁕C
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
            //    0 B⁕------------------------------------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            VoronoiEdge edge = FindEdge(edges, 0, 400, 600, 1000); // A-D
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 400))); // A-D neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 400, 0, 0))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 600, 1000))); // A-D neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 1000, 0, 1000))); // A-D neighbours D-X
            edge = FindEdge(edges, 0, 0, 1000, 1000); // B-C
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 400, 0, 0))); // B-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // B-C neighbours B-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // B-C neighbours Y-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 600, 1000))); // B-C neighbours C-D
            edge = FindEdge(edges, 0, 1000, 0, 400); // X-A
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 400, 600, 1000))); // X-A neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 400, 0, 0))); // X-A neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 1000, 0, 1000))); // X-A neighbours D-X
            edge = FindEdge(edges, 0, 400, 0, 0); // A-B
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 400, 600, 1000))); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 1000))); // A-B neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 400))); // A-B neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // A-B neighbours B-Y
            edge = FindEdge(edges, 0, 0, 1000, 0); // B-Y
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 1000))); // B-Y neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 400, 0, 0))); // B-Y neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // B-Y neighbours Y-C
            edge = FindEdge(edges, 1000, 0, 1000, 1000); // Y-C
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 1000))); // Y-C neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // Y-C neighbours B-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 600, 1000))); // Y-C neighbours C-D
            edge = FindEdge(edges, 1000, 1000, 600, 1000); // C-D
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 400, 600, 1000))); // C-D neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 1000))); // C-D neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // C-D neighbours Y-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 1000, 0, 1000))); // C-D neighbours D-X
            edge = FindEdge(edges, 600, 1000, 0, 1000); // D-X
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 400, 600, 1000))); // D-X neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 400))); // D-X neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 600, 1000))); // D-X neighbours C-D
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

            // 1000 B⁕------------------A⁕----------------------------X
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
            //    0 Y------------------------------------------------⁕C
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            VoronoiEdge edge = FindEdge(edges, 400, 1000, 1000, 400); // A-D
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 400, 1000))); // A-D neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 1000, 0, 1000))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 400))); // A-D neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 400, 1000, 1000))); // A-D neighbours D-X
            edge = FindEdge(edges, 0, 1000, 1000, 0); // B-C
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 1000, 0, 1000))); // B-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // B-C neighbours B-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // B-C neighbours Y-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 400))); // B-C neighbours C-D
            edge = FindEdge(edges, 1000, 1000, 400, 1000); // X-A
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 1000, 1000, 400))); // X-A neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 1000, 0, 1000))); // X-A neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 400, 1000, 1000))); // X-A neighbours D-X
            edge = FindEdge(edges, 400, 1000, 0, 1000); // A-B
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 1000, 1000, 400))); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 1000, 0))); // A-B neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 400, 1000))); // A-B neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // A-B neighbours B-Y
            edge = FindEdge(edges, 0, 1000, 0, 0); // B-Y
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 1000, 0))); // B-Y neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 1000, 0, 1000))); // B-Y neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // B-Y neighbours Y-C
            edge = FindEdge(edges, 0, 0, 1000, 0); // Y-C
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 1000, 0))); // Y-C neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // Y-C neighbours B-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 400))); // Y-C neighbours C-D
            edge = FindEdge(edges, 1000, 0, 1000, 400); // C-D
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 1000, 1000, 400))); // C-D neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 1000, 0))); // C-D neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // C-D neighbours Y-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 400, 1000, 1000))); // C-D neighbours D-X
            edge = FindEdge(edges, 1000, 400, 1000, 1000); // D-X
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 1000, 1000, 400))); // D-X neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 400, 1000))); // D-X neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 400))); // D-X neighbours C-D
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

            // 1000 Y------------------------------------------------⁕B
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
            //    0 C⁕------------------D⁕----------------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            VoronoiEdge edge = FindEdge(edges, 1000, 600, 400, 0); // A-D
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 600))); // A-D neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 600, 1000, 1000))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 400, 0))); // A-D neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 0, 1000, 0))); // A-D neighbours D-X
            edge = FindEdge(edges, 1000, 1000, 0, 0); // B-C
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 600, 1000, 1000))); // B-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // B-C neighbours B-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // B-C neighbours Y-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 400, 0))); // B-C neighbours C-D
            edge = FindEdge(edges, 1000, 0, 1000, 600); // X-A
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 600, 400, 0))); // X-A neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 600, 1000, 1000))); // X-A neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 0, 1000, 0))); // X-A neighbours D-X
            edge = FindEdge(edges, 1000, 600, 1000, 1000); // A-B
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 600, 400, 0))); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 0))); // A-B neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 600))); // A-B neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // A-B neighbours B-Y
            edge = FindEdge(edges, 1000, 1000, 0, 1000); // B-Y
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 0))); // B-Y neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 600, 1000, 1000))); // B-Y neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // B-Y neighbours Y-C
            edge = FindEdge(edges, 0, 1000, 0, 0); // Y-C
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 0))); // Y-C neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // Y-C neighbours B-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 400, 0))); // Y-C neighbours C-D
            edge = FindEdge(edges, 0, 0, 400, 0); // C-D
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 600, 400, 0))); // C-D neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 0))); // C-D neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // C-D neighbours Y-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 0, 1000, 0))); // C-D neighbours D-X
            edge = FindEdge(edges, 400, 0, 1000, 0); // D-X
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 600, 400, 0))); // D-X neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 600))); // D-X neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 400, 0))); // D-X neighbours C-D
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

            // 1000 C⁕------------------------------------------------Y
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
            //    0 X----------------------------⁕A------------------⁕B
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            VoronoiEdge edge = FindEdge(edges, 600, 0, 0, 600); // A-D
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 600, 0))); // A-D neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 0, 1000, 0))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 600))); // A-D neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 600, 0, 0))); // A-D neighbours D-X
            edge = FindEdge(edges, 1000, 0, 0, 1000); // B-C
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 0, 1000, 0))); // B-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // B-C neighbours B-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // B-C neighbours Y-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 600))); // B-C neighbours C-D
            edge = FindEdge(edges, 0, 0, 600, 0); // X-A
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 0, 0, 600))); // X-A neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 0, 1000, 0))); // X-A neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 600, 0, 0))); // X-A neighbours D-X
            edge = FindEdge(edges, 600, 0, 1000, 0); // A-B
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 0, 0, 600))); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 0, 1000))); // A-B neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 600, 0))); // A-B neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // A-B neighbours B-Y
            edge = FindEdge(edges, 1000, 0, 1000, 1000); // B-Y
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 0, 1000))); // B-Y neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 0, 1000, 0))); // B-Y neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // B-Y neighbours Y-C
            edge = FindEdge(edges, 1000, 1000, 0, 1000); // Y-C
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 0, 1000))); // Y-C neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // Y-C neighbours B-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 600))); // Y-C neighbours C-D
            edge = FindEdge(edges, 0, 1000, 0, 600); // C-D
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 0, 0, 600))); // C-D neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 0, 1000))); // C-D neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // C-D neighbours Y-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 600, 0, 0))); // C-D neighbours D-X
            edge = FindEdge(edges, 0, 600, 0, 0); // D-X
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 0, 0, 600))); // D-X neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 600, 0))); // D-X neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 600))); // D-X neighbours C-D
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

            // 1000 X----------------------------⁕F------------------⁕E
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
            //    0 B⁕------------------C⁕----------------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            VoronoiEdge edge = FindEdge(edges, 0, 400, 600, 1000); // A-F
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 400))); // A-F neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 400, 0, 0))); // A-F neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 600, 1000))); // A-F neighbours E-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 1000, 0, 1000))); // A-F neighbours F-X
            edge = FindEdge(edges, 0, 0, 1000, 1000); // B-E
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 400, 0, 0))); // B-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 400, 0))); // B-E neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 600, 1000, 1000))); // B-E neighbours D-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 600, 1000))); // B-E neighbours E-F
            edge = FindEdge(edges, 400, 0, 1000, 600); // C-D
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 400, 0))); // C-D neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 0, 1000, 0))); // C-D neighbours C-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 600))); // C-D neighbours Y-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 600, 1000, 1000))); // C-D neighbours D-E
            edge = FindEdge(edges, 0, 1000, 0, 400); // X-A
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 400, 600, 1000))); // X-A neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 400, 0, 0))); // X-A neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 1000, 0, 1000))); // X-A neighbours F-X
            edge = FindEdge(edges, 0, 400, 0, 0); // A-B
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 400, 600, 1000))); // A-B neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 1000))); // A-B neighbours B-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 400))); // A-B neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 400, 0))); // A-B neighbours B-C
            edge = FindEdge(edges, 0, 0, 400, 0); // B-C
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 1000))); // B-C neighbours B-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 0, 1000, 600))); // B-C neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 400, 0, 0))); // B-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 0, 1000, 0))); // B-C neighbours C-Y
            edge = FindEdge(edges, 400, 0, 1000, 0); // C-Y
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 0, 1000, 600))); // C-Y neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 400, 0))); // C-Y neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 600))); // C-Y neighbours Y-D
            edge = FindEdge(edges, 1000, 0, 1000, 600); // Y-D
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 0, 1000, 600))); // Y-D neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 0, 1000, 0))); // Y-D neighbours C-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 600, 1000, 1000))); // Y-D neighbours D-E
            edge = FindEdge(edges, 1000, 600, 1000, 1000); // D-E
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 1000))); // D-E neighbours B-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 0, 1000, 600))); // D-E neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 600))); // D-E neighbours Y-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 600, 1000))); // D-E neighbours E-F
            edge = FindEdge(edges, 1000, 1000, 600, 1000); // E-F
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 400, 600, 1000))); // E-F neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 1000))); // E-F neighbours B-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 600, 1000, 1000))); // E-F neighbours D-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 1000, 0, 1000))); // E-F neighbours F-X
            edge = FindEdge(edges, 600, 1000, 0, 1000); // F-X
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 400, 600, 1000))); // F-X neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 400))); // F-X neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 600, 1000))); // F-X neighbours E-F
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

            // 1000 B⁕------------------A⁕----------------------------X
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
            //    0 Y----------------------------⁕D------------------⁕E
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            VoronoiEdge edge = FindEdge(edges, 400, 1000, 1000, 400); // A-F
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 400, 1000))); // A-F neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 1000, 0, 1000))); // A-F neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 400))); // A-F neighbours E-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 400, 1000, 1000))); // A-F neighbours F-X
            edge = FindEdge(edges, 0, 1000, 1000, 0); // B-E
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 1000, 0, 1000))); // B-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 600))); // B-E neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 0, 1000, 0))); // B-E neighbours D-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 400))); // B-E neighbours E-F
            edge = FindEdge(edges, 0, 600, 600, 0); // C-D
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 600))); // C-D neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 600, 0, 0))); // C-D neighbours C-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 600, 0))); // C-D neighbours Y-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 0, 1000, 0))); // C-D neighbours D-E
            edge = FindEdge(edges, 1000, 1000, 400, 1000); // X-A
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 1000, 1000, 400))); // X-A neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 1000, 0, 1000))); // X-A neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 400, 1000, 1000))); // X-A neighbours F-X
            edge = FindEdge(edges, 400, 1000, 0, 1000); // A-B
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 1000, 1000, 400))); // A-B neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 1000, 0))); // A-B neighbours B-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 400, 1000))); // A-B neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 600))); // A-B neighbours B-C
            edge = FindEdge(edges, 0, 1000, 0, 600); // B-C
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 1000, 0))); // B-C neighbours B-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 600, 600, 0))); // B-C neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 1000, 0, 1000))); // B-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 600, 0, 0))); // B-C neighbours C-Y
            edge = FindEdge(edges, 0, 600, 0, 0); // C-Y
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 600, 600, 0))); // C-Y neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 600))); // C-Y neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 600, 0))); // C-Y neighbours Y-D
            edge = FindEdge(edges, 0, 0, 600, 0); // Y-D
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 600, 600, 0))); // Y-D neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 600, 0, 0))); // Y-D neighbours C-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 0, 1000, 0))); // Y-D neighbours D-E
            edge = FindEdge(edges, 600, 0, 1000, 0); // D-E
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 1000, 0))); // D-E neighbours B-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 600, 600, 0))); // D-E neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 600, 0))); // D-E neighbours Y-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 400))); // D-E neighbours E-F
            edge = FindEdge(edges, 1000, 0, 1000, 400); // E-F
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 1000, 1000, 400))); // E-F neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 1000, 0))); // E-F neighbours B-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 0, 1000, 0))); // E-F neighbours D-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 400, 1000, 1000))); // E-F neighbours F-X
            edge = FindEdge(edges, 1000, 400, 1000, 1000); // F-X
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 1000, 1000, 400))); // F-X neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 400, 1000))); // F-X neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 400))); // F-X neighbours E-F
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

            // 1000 X------------------------------------------------⁕D
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

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            VoronoiEdge edge = FindEdge(edges, 400, 400, 0, 400); // A-B
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 400, 0))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 1000, 1000))); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 400))); // A-B neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 400, 0, 0))); // A-B neighbours B-Y
            edge = FindEdge(edges, 400, 400, 400, 0); // A-C
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 0, 400))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 1000, 1000))); // A-C neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 400, 0))); // A-C neighbours Y-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 0, 1000, 0))); // A-C neighbours C-W
            edge = FindEdge(edges, 400, 400, 1000, 1000); // A-D
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 0, 400))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 400, 0))); // A-D neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // A-D neighbours W-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // A-D neighbours D-X
            edge = FindEdge(edges, 0, 1000, 0, 400); // X-B
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 0, 400))); // X-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 400, 0, 0))); // X-B neighbours B-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // X-B neighbours D-X
            edge = FindEdge(edges, 0, 400, 0, 0); // B-Y
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 0, 400))); // B-Y neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 400))); // B-Y neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 400, 0))); // B-Y neighbours Y-C
            edge = FindEdge(edges, 0, 0, 400, 0); // Y-C
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 400, 0))); // Y-C neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 400, 0, 0))); // Y-C neighbours B-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 0, 1000, 0))); // Y-C neighbours C-W
            edge = FindEdge(edges, 400, 0, 1000, 0); // C-W
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 400, 0))); // C-W neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 400, 0))); // C-W neighbours Y-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // C-W neighbours W-D
            edge = FindEdge(edges, 1000, 0, 1000, 1000); // W-D
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 1000, 1000))); // W-D neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 0, 1000, 0))); // W-D neighbours C-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // W-D neighbours D-X
            edge = FindEdge(edges, 1000, 1000, 0, 1000); // D-X
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 1000, 1000))); // D-X neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 400))); // D-X neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // D-X neighbours W-D
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
            //    0 W------------------------------------------------⁕D
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            VoronoiEdge edge = FindEdge(edges, 400, 600, 400, 1000); // A-B
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 0, 600))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 1000, 0))); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 400, 1000))); // A-B neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 1000, 0, 1000))); // A-B neighbours B-Y
            edge = FindEdge(edges, 400, 600, 0, 600); // A-C
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 400, 1000))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 1000, 0))); // A-C neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 600))); // A-C neighbours Y-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 600, 0, 0))); // A-C neighbours C-W
            edge = FindEdge(edges, 400, 600, 1000, 0); // A-D
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 400, 1000))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 0, 600))); // A-D neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // A-D neighbours W-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // A-D neighbours D-X
            edge = FindEdge(edges, 1000, 1000, 400, 1000); // X-B
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 400, 1000))); // X-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 1000, 0, 1000))); // X-B neighbours B-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // X-B neighbours D-X
            edge = FindEdge(edges, 400, 1000, 0, 1000); // B-Y
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 400, 1000))); // B-Y neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 400, 1000))); // B-Y neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 600))); // B-Y neighbours Y-C
            edge = FindEdge(edges, 0, 1000, 0, 600); // Y-C
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 0, 600))); // Y-C neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 1000, 0, 1000))); // Y-C neighbours B-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 600, 0, 0))); // Y-C neighbours C-W
            edge = FindEdge(edges, 0, 600, 0, 0); // C-W
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 0, 600))); // C-W neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 600))); // C-W neighbours Y-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // C-W neighbours W-D
            edge = FindEdge(edges, 0, 0, 1000, 0); // W-D
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 1000, 0))); // W-D neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 600, 0, 0))); // W-D neighbours C-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // W-D neighbours D-X
            edge = FindEdge(edges, 1000, 0, 1000, 1000); // D-X
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 1000, 0))); // D-X neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 400, 1000))); // D-X neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // D-X neighbours W-D
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
            //    0 D⁕------------------------------------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            VoronoiEdge edge = FindEdge(edges, 600, 600, 1000, 600); // A-B
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 600, 1000))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 0, 0))); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 600))); // A-B neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 600, 1000, 1000))); // A-B neighbours B-Y
            edge = FindEdge(edges, 600, 600, 600, 1000); // A-C
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 1000, 600))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 0, 0))); // A-C neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 600, 1000))); // A-C neighbours Y-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 1000, 0, 1000))); // A-C neighbours C-W
            edge = FindEdge(edges, 600, 600, 0, 0); // A-D
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 1000, 600))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 600, 1000))); // A-D neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // A-D neighbours W-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // A-D neighbours D-X
            edge = FindEdge(edges, 1000, 0, 1000, 600); // X-B
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 1000, 600))); // X-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 600, 1000, 1000))); // X-B neighbours B-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // X-B neighbours D-X
            edge = FindEdge(edges, 1000, 600, 1000, 1000); // B-Y
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 1000, 600))); // B-Y neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 600))); // B-Y neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 600, 1000))); // B-Y neighbours Y-C
            edge = FindEdge(edges, 1000, 1000, 600, 1000); // Y-C
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 600, 1000))); // Y-C neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 600, 1000, 1000))); // Y-C neighbours B-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 1000, 0, 1000))); // Y-C neighbours C-W
            edge = FindEdge(edges, 600, 1000, 0, 1000); // C-W
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 600, 1000))); // C-W neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 600, 1000))); // C-W neighbours Y-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // C-W neighbours W-D
            edge = FindEdge(edges, 0, 1000, 0, 0); // W-D
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 0, 0))); // W-D neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 1000, 0, 1000))); // W-D neighbours C-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // W-D neighbours D-X
            edge = FindEdge(edges, 0, 0, 1000, 0); // D-X
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 0, 0))); // D-X neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 600))); // D-X neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // D-X neighbours W-D
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

            // 1000 D⁕------------------------------------------------W
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

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            VoronoiEdge edge = FindEdge(edges, 600, 400, 600, 0); // A-B
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 1000, 400))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 0, 1000))); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 600, 0))); // A-B neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 0, 1000, 0))); // A-B neighbours B-Y
            edge = FindEdge(edges, 600, 400, 1000, 400); // A-C
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 600, 0))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 0, 1000))); // A-C neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 400))); // A-C neighbours Y-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 400, 1000, 1000))); // A-C neighbours C-W
            edge = FindEdge(edges, 600, 400, 0, 1000); // A-D
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 600, 0))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 1000, 400))); // A-D neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // A-D neighbours W-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // A-D neighbours D-X
            edge = FindEdge(edges, 0, 0, 600, 0); // X-B
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 600, 0))); // X-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 0, 1000, 0))); // X-B neighbours B-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // X-B neighbours D-X
            edge = FindEdge(edges, 600, 0, 1000, 0); // B-Y
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 600, 0))); // B-Y neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 600, 0))); // B-Y neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 400))); // B-Y neighbours Y-C
            edge = FindEdge(edges, 1000, 0, 1000, 400); // Y-C
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 1000, 400))); // Y-C neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 0, 1000, 0))); // Y-C neighbours B-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 400, 1000, 1000))); // Y-C neighbours C-W
            edge = FindEdge(edges, 1000, 400, 1000, 1000); // C-W
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 1000, 400))); // C-W neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 400))); // C-W neighbours Y-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // C-W neighbours W-D
            edge = FindEdge(edges, 1000, 1000, 0, 1000); // W-D
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 0, 1000))); // W-D neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 400, 1000, 1000))); // W-D neighbours C-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // W-D neighbours D-X
            edge = FindEdge(edges, 0, 1000, 0, 0); // D-X
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 0, 1000))); // D-X neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 600, 0))); // D-X neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // D-X neighbours W-D
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
            //    0 B⁕-----------------------------------------------⁕C
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            VoronoiEdge edge = FindEdge(edges, 500, 500, 0, 0); // A-B
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 0))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 1000))); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // A-B neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // A-B neighbours B-C
            edge = FindEdge(edges, 500, 500, 1000, 0); // A-C
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 0))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 1000))); // A-C neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // A-C neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // A-C neighbours C-Y
            edge = FindEdge(edges, 500, 500, 500, 1000); // A-D
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 0))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 0))); // A-D neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 500, 1000))); // A-D neighbours Y-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 1000, 0, 1000))); // A-D neighbours D-X
            edge = FindEdge(edges, 0, 1000, 0, 0); // X-B
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 0))); // X-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // X-B neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 1000, 0, 1000))); // X-B neighbours D-X
            edge = FindEdge(edges, 0, 0, 1000, 0); // B-C
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 0))); // B-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 0))); // B-C neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // B-C neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // B-C neighbours C-Y
            edge = FindEdge(edges, 1000, 0, 1000, 1000); // C-Y
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 0))); // C-Y neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // C-Y neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 500, 1000))); // C-Y neighbours Y-D
            edge = FindEdge(edges, 1000, 1000, 500, 1000); // Y-D
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 1000))); // Y-D neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // Y-D neighbours C-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 1000, 0, 1000))); // Y-D neighbours D-X
            edge = FindEdge(edges, 500, 1000, 0, 1000); // D-X
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 1000))); // D-X neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // D-X neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 500, 1000))); // D-X neighbours Y-D
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

            // 1000 B⁕------------------------------------------------X
            //      | ',                                              |
            //  900 |   '·,                                           |
            //      |      ',                                         |
            //  800 |        '·,                                      |
            //      |           ',                                    |
            //  700 |             '·,        3                        |
            //      |                ',                               |
            //  600 |                  '·,                            |
            //      |                     ',                          |
            //  500 |              1        ⁕A------------------------D
            //      |                     ,'                          |
            //  400 |                  ,·'                            |
            //      |                ,'                               |
            //  300 |             ,·'        2                        |
            //      |           ,'                                    |
            //  200 |        ,·'                                      |
            //      |      ,'                                         |
            //  100 |   ,·'                                           |
            //      | ,'                                              |
            //    0 C⁕------------------------------------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            VoronoiEdge edge = FindEdge(edges, 500, 500, 0, 1000); // A-B
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 0))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 500))); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // A-B neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // A-B neighbours B-C
            edge = FindEdge(edges, 500, 500, 0, 0); // A-C
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 1000))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 500))); // A-C neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // A-C neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // A-C neighbours C-Y
            edge = FindEdge(edges, 500, 500, 1000, 500); // A-D
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 1000))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 0))); // A-D neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 500))); // A-D neighbours Y-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 500, 1000, 1000))); // A-D neighbours D-X
            edge = FindEdge(edges, 1000, 1000, 0, 1000); // X-B
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 1000))); // X-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // X-B neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 500, 1000, 1000))); // X-B neighbours D-X
            edge = FindEdge(edges, 0, 1000, 0, 0); // B-C
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 1000))); // B-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 0))); // B-C neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // B-C neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // B-C neighbours C-Y
            edge = FindEdge(edges, 0, 0, 1000, 0); // C-Y
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 0))); // C-Y neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // C-Y neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 500))); // C-Y neighbours Y-D
            edge = FindEdge(edges, 1000, 0, 1000, 500); // Y-D
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 500))); // Y-D neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // Y-D neighbours C-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 500, 1000, 1000))); // Y-D neighbours D-X
            edge = FindEdge(edges, 1000, 500, 1000, 1000); // D-X
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 500))); // D-X neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // D-X neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 500))); // D-X neighbours Y-D
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

            // 1000 C⁕-----------------------------------------------⁕B
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

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            VoronoiEdge edge = FindEdge(edges, 500, 500, 1000, 1000); // A-B
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 1000))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 0))); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // A-B neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // A-B neighbours B-C
            edge = FindEdge(edges, 500, 500, 0, 1000); // A-C
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 1000))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 0))); // A-C neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // A-C neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // A-C neighbours C-Y
            edge = FindEdge(edges, 500, 500, 500, 0); // A-D
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 1000))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 1000))); // A-D neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 500, 0))); // A-D neighbours Y-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 0, 1000, 0))); // A-D neighbours D-X
            edge = FindEdge(edges, 1000, 0, 1000, 1000); // X-B
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 1000))); // X-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // X-B neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 0, 1000, 0))); // X-B neighbours D-X
            edge = FindEdge(edges, 1000, 1000, 0, 1000); // B-C
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 1000))); // B-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 1000))); // B-C neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // B-C neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // B-C neighbours C-Y
            edge = FindEdge(edges, 0, 1000, 0, 0); // C-Y
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 1000))); // C-Y neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // C-Y neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 500, 0))); // C-Y neighbours Y-D
            edge = FindEdge(edges, 0, 0, 500, 0); // Y-D
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 0))); // Y-D neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // Y-D neighbours C-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 0, 1000, 0))); // Y-D neighbours D-X
            edge = FindEdge(edges, 500, 0, 1000, 0); // D-X
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 0))); // D-X neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // D-X neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 500, 0))); // D-X neighbours Y-D
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

            // 1000 Y------------------------------------------------⁕C
            //      |                                              ,' |
            //  900 |                                           ,·'   |
            //      |                                         ,'      |
            //  800 |                                      ,·'        |
            //      |                                    ,'           |
            //  700 |                        2        ,·'             |
            //      |                               ,'                |
            //  600 |                            ,·'                  |
            //      |                          ,'                     |
            //  500 D------------------------A⁕        1              |
            //      |                          ',                     |
            //  400 |                            '·,                  |
            //      |                               ',                |
            //  300 |                        3        '·,             |
            //      |                                    ',           |
            //  200 |                                      '·,        |
            //      |                                         ',      |
            //  100 |                                           '·,   |
            //      |                                              ', |
            //    0 X------------------------------------------------⁕B
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            VoronoiEdge edge = FindEdge(edges, 500, 500, 1000, 0); // A-B
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 1000))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 500))); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // A-B neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // A-B neighbours B-C
            edge = FindEdge(edges, 500, 500, 1000, 1000); // A-C
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 0))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 500))); // A-C neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // A-C neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // A-C neighbours C-Y
            edge = FindEdge(edges, 500, 500, 0, 500); // A-D
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 0))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 1000))); // A-D neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 500))); // A-D neighbours Y-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 0, 0))); // A-D neighbours D-X
            edge = FindEdge(edges, 0, 0, 1000, 0); // X-B
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 0))); // X-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // X-B neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 0, 0))); // X-B neighbours D-X
            edge = FindEdge(edges, 1000, 0, 1000, 1000); // B-C
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 0))); // B-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 1000))); // B-C neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // B-C neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // B-C neighbours C-Y
            edge = FindEdge(edges, 1000, 1000, 0, 1000); // C-Y
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 1000))); // C-Y neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // C-Y neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 500))); // C-Y neighbours Y-D
            edge = FindEdge(edges, 0, 1000, 0, 500); // Y-D
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 500))); // Y-D neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // Y-D neighbours C-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 0, 0))); // Y-D neighbours D-X
            edge = FindEdge(edges, 0, 500, 0, 0); // D-X
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 500))); // D-X neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // D-X neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 500))); // D-X neighbours Y-D
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
            //    0 Y---------B⁕---------------------------⁕C---------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            VoronoiEdge edge = FindEdge(edges, 500, 300, 200, 0); // A-B
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 800, 0))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 1000))); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 200, 0))); // A-B neighbours Y-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 0, 800, 0))); // A-B neighbours B-C
            edge = FindEdge(edges, 500, 300, 800, 0); // A-C
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 200, 0))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 1000))); // A-C neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 0, 800, 0))); // A-C neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 0, 1000, 0))); // A-C neighbours C-W
            edge = FindEdge(edges, 500, 300, 500, 1000); // A-D
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 200, 0))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 800, 0))); // A-D neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 500, 1000))); // A-D neighbours Z-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 1000, 0, 1000))); // A-D neighbours D-X
            edge = FindEdge(edges, 0, 1000, 0, 0); // X-Y
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 200, 0))); // X-Y neighbours Y-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 1000, 0, 1000))); // X-Y neighbours D-X
            edge = FindEdge(edges, 0, 0, 200, 0); // Y-B
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 200, 0))); // Y-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // Y-B neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 0, 800, 0))); // Y-B neighbours B-C
            edge = FindEdge(edges, 200, 0, 800, 0); // B-C
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 200, 0))); // B-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 800, 0))); // B-C neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 200, 0))); // B-C neighbours Y-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 0, 1000, 0))); // B-C neighbours C-W
            edge = FindEdge(edges, 800, 0, 1000, 0); // C-W
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 800, 0))); // C-W neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 0, 800, 0))); // C-W neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // C-W neighbours W-Z
            edge = FindEdge(edges, 1000, 0, 1000, 1000); // W-Z
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 0, 1000, 0))); // W-Z neighbours C-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 500, 1000))); // W-Z neighbours Z-D
            edge = FindEdge(edges, 1000, 1000, 500, 1000); // Z-D
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 1000))); // Z-D neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // Z-D neighbours W-Z
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 1000, 0, 1000))); // Z-D neighbours D-X
            edge = FindEdge(edges, 500, 1000, 0, 1000); // D-X
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 1000))); // D-X neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // D-X neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 500, 1000))); // D-X neighbours Z-D
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
            //  500 |    1        ⁕A----------------------------------D
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

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            VoronoiEdge edge = FindEdge(edges, 300, 500, 0, 800); // A-B
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 0, 200))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 1000, 500))); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 800))); // A-B neighbours Y-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 800, 0, 200))); // A-B neighbours B-C
            edge = FindEdge(edges, 300, 500, 0, 200); // A-C
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 0, 800))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 1000, 500))); // A-C neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 800, 0, 200))); // A-C neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 200, 0, 0))); // A-C neighbours C-W
            edge = FindEdge(edges, 300, 500, 1000, 500); // A-D
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 0, 800))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 0, 200))); // A-D neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 500))); // A-D neighbours Z-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 500, 1000, 1000))); // A-D neighbours D-X
            edge = FindEdge(edges, 1000, 1000, 0, 1000); // X-Y
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 800))); // X-Y neighbours Y-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 500, 1000, 1000))); // X-Y neighbours D-X
            edge = FindEdge(edges, 0, 1000, 0, 800); // Y-B
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 0, 800))); // Y-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // Y-B neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 800, 0, 200))); // Y-B neighbours B-C
            edge = FindEdge(edges, 0, 800, 0, 200); // B-C
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 0, 800))); // B-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 0, 200))); // B-C neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 800))); // B-C neighbours Y-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 200, 0, 0))); // B-C neighbours C-W
            edge = FindEdge(edges, 0, 200, 0, 0); // C-W
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 0, 200))); // C-W neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 800, 0, 200))); // C-W neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // C-W neighbours W-Z
            edge = FindEdge(edges, 0, 0, 1000, 0); // W-Z
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 200, 0, 0))); // W-Z neighbours C-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 500))); // W-Z neighbours Z-D
            edge = FindEdge(edges, 1000, 0, 1000, 500); // Z-D
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 1000, 500))); // Z-D neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // Z-D neighbours W-Z
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 500, 1000, 1000))); // Z-D neighbours D-X
            edge = FindEdge(edges, 1000, 500, 1000, 1000); // D-X
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 1000, 500))); // D-X neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // D-X neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 500))); // D-X neighbours Z-D
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

            // 1000 W---------C⁕---------------------------⁕B---------Y
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

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            VoronoiEdge edge = FindEdge(edges, 500, 700, 800, 1000); // A-B
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 200, 1000))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 500, 0))); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 800, 1000))); // A-B neighbours Y-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 1000, 200, 1000))); // A-B neighbours B-C
            edge = FindEdge(edges, 500, 700, 200, 1000); // A-C
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 800, 1000))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 500, 0))); // A-C neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 1000, 200, 1000))); // A-C neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 1000, 0, 1000))); // A-C neighbours C-W
            edge = FindEdge(edges, 500, 700, 500, 0); // A-D
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 800, 1000))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 200, 1000))); // A-D neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 500, 0))); // A-D neighbours Z-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 0, 1000, 0))); // A-D neighbours D-X
            edge = FindEdge(edges, 1000, 0, 1000, 1000); // X-Y
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 800, 1000))); // X-Y neighbours Y-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 0, 1000, 0))); // X-Y neighbours D-X
            edge = FindEdge(edges, 1000, 1000, 800, 1000); // Y-B
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 800, 1000))); // Y-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // Y-B neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 1000, 200, 1000))); // Y-B neighbours B-C
            edge = FindEdge(edges, 800, 1000, 200, 1000); // B-C
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 800, 1000))); // B-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 200, 1000))); // B-C neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 800, 1000))); // B-C neighbours Y-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 1000, 0, 1000))); // B-C neighbours C-W
            edge = FindEdge(edges, 200, 1000, 0, 1000); // C-W
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 200, 1000))); // C-W neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 1000, 200, 1000))); // C-W neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // C-W neighbours W-Z
            edge = FindEdge(edges, 0, 1000, 0, 0); // W-Z
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 1000, 0, 1000))); // W-Z neighbours C-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 500, 0))); // W-Z neighbours Z-D
            edge = FindEdge(edges, 0, 0, 500, 0); // Z-D
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 500, 0))); // Z-D neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // Z-D neighbours W-Z
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 0, 1000, 0))); // Z-D neighbours D-X
            edge = FindEdge(edges, 500, 0, 1000, 0); // D-X
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 500, 0))); // D-X neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // D-X neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 500, 0))); // D-X neighbours Z-D
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
            //  500 D----------------------------------A⁕        1    |
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

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            VoronoiEdge edge = FindEdge(edges, 700, 500, 1000, 200); // A-B
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 1000, 800))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 0, 500))); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 200))); // A-B neighbours Y-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 200, 1000, 800))); // A-B neighbours B-C
            edge = FindEdge(edges, 700, 500, 1000, 800); // A-C
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 1000, 200))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 0, 500))); // A-C neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 200, 1000, 800))); // A-C neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 800, 1000, 1000))); // A-C neighbours C-W
            edge = FindEdge(edges, 700, 500, 0, 500); // A-D
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 1000, 200))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 1000, 800))); // A-D neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 500))); // A-D neighbours Z-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 0, 0))); // A-D neighbours D-X
            edge = FindEdge(edges, 0, 0, 1000, 0); // X-Y
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 200))); // X-Y neighbours Y-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 0, 0))); // X-Y neighbours D-X
            edge = FindEdge(edges, 1000, 0, 1000, 200); // Y-B
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 1000, 200))); // Y-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // Y-B neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 200, 1000, 800))); // Y-B neighbours B-C
            edge = FindEdge(edges, 1000, 200, 1000, 800); // B-C
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 1000, 200))); // B-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 1000, 800))); // B-C neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 200))); // B-C neighbours Y-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 800, 1000, 1000))); // B-C neighbours C-W
            edge = FindEdge(edges, 1000, 800, 1000, 1000); // C-W
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 1000, 800))); // C-W neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 200, 1000, 800))); // C-W neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // C-W neighbours W-Z
            edge = FindEdge(edges, 1000, 1000, 0, 1000); // W-Z
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 800, 1000, 1000))); // W-Z neighbours C-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 500))); // W-Z neighbours Z-D
            edge = FindEdge(edges, 0, 1000, 0, 500); // Z-D
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 0, 500))); // Z-D neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // Z-D neighbours W-Z
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 0, 0))); // Z-D neighbours D-X
            edge = FindEdge(edges, 0, 500, 0, 0); // D-X
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 0, 500))); // D-X neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // D-X neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 500))); // D-X neighbours Z-D
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

            // 1000 E⁕-----------------------------------------------⁕H
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
            //    0 F⁕-----------------------------------------------⁕G
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            VoronoiEdge edge = FindEdge(edges, 400, 600, 400, 400); // A-B
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 600, 400))); // A-B neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 400, 600))); // A-B neighbours D-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 0, 1000))); // A-B neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 0, 0))); // A-B neighbours B-F
            edge = FindEdge(edges, 400, 400, 600, 400); // B-C
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 400, 400))); // B-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 600, 600))); // B-C neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 0, 0))); // B-C neighbours B-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 1000, 0))); // B-C neighbours C-G
            edge = FindEdge(edges, 600, 400, 600, 600); // C-D
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 600, 400))); // C-D neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 400, 600))); // C-D neighbours D-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 1000, 0))); // C-D neighbours C-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 1000, 1000))); // C-D neighbours D-H
            edge = FindEdge(edges, 600, 600, 400, 600); // D-A
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 400, 400))); // D-A neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 600, 600))); // D-A neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 0, 1000))); // D-A neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 1000, 1000))); // D-A neighbours D-H
            edge = FindEdge(edges, 400, 600, 0, 1000); // A-E
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 400, 400))); // A-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 400, 600))); // A-E neighbours D-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // A-E neighbours E-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // A-E neighbours H-E
            edge = FindEdge(edges, 400, 400, 0, 0); // B-F
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 400, 400))); // B-F neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 600, 400))); // B-F neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // B-F neighbours E-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // B-F neighbours F-G
            edge = FindEdge(edges, 600, 400, 1000, 0); // C-G
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 600, 400))); // C-G neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 600, 600))); // C-G neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // C-G neighbours F-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // C-G neighbours G-H
            edge = FindEdge(edges, 600, 600, 1000, 1000); // D-H
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 600, 600))); // D-H neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 400, 600))); // D-H neighbours D-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // D-H neighbours G-H
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // D-H neighbours H-E
            edge = FindEdge(edges, 0, 1000, 0, 0); // E-F
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 0, 1000))); // E-F neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 0, 0))); // E-F neighbours B-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // E-F neighbours F-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // E-F neighbours H-E
            edge = FindEdge(edges, 0, 0, 1000, 0); // F-G
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 0, 0))); // F-G neighbours B-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 1000, 0))); // F-G neighbours C-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // F-G neighbours E-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // F-G neighbours G-H
            edge = FindEdge(edges, 1000, 0, 1000, 1000); // G-H
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 1000, 0))); // G-H neighbours C-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 1000, 1000))); // G-H neighbours D-H
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // G-H neighbours F-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // G-H neighbours H-E
            edge = FindEdge(edges, 1000, 1000, 0, 1000); // H-E
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 0, 1000))); // H-E neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 1000, 1000))); // H-E neighbours D-H
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // H-E neighbours E-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // H-E neighbours G-H
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
            //    0 Y---------F⁕---------------------------⁕G---------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            VoronoiEdge edge = FindEdge(edges, 400, 400, 400, 200); // A-B
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 200, 600, 200))); // A-B neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 400, 400))); // A-B neighbours D-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 0, 800))); // A-B neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 200, 200, 0))); // A-B neighbours B-F
            edge = FindEdge(edges, 400, 200, 600, 200); // B-C
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 400, 200))); // B-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 200, 600, 400))); // B-C neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 200, 200, 0))); // B-C neighbours B-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 200, 800, 0))); // B-C neighbours C-G
            edge = FindEdge(edges, 600, 200, 600, 400); // C-D
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 200, 600, 200))); // C-D neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 400, 400))); // C-D neighbours D-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 200, 800, 0))); // C-D neighbours C-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 1000, 800))); // C-D neighbours D-H
            edge = FindEdge(edges, 600, 400, 400, 400); // D-A
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 400, 200))); // D-A neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 200, 600, 400))); // D-A neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 0, 800))); // D-A neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 1000, 800))); // D-A neighbours D-H
            edge = FindEdge(edges, 400, 400, 0, 800); // A-E
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 400, 200))); // A-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 400, 400))); // A-E neighbours D-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 800))); // A-E neighbours X-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 800, 0, 0))); // A-E neighbours E-Y
            edge = FindEdge(edges, 400, 200, 200, 0); // B-F
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 400, 200))); // B-F neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 200, 600, 200))); // B-F neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 200, 0))); // B-F neighbours Y-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 0, 800, 0))); // B-F neighbours F-G
            edge = FindEdge(edges, 600, 200, 800, 0); // C-G
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 200, 600, 200))); // C-G neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 200, 600, 400))); // C-G neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 0, 800, 0))); // C-G neighbours F-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 0, 1000, 0))); // C-G neighbours G-W
            edge = FindEdge(edges, 600, 400, 1000, 800); // D-H
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 200, 600, 400))); // D-H neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 400, 400))); // D-H neighbours D-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 800))); // D-H neighbours W-H
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 800, 1000, 1000))); // D-H neighbours H-Z
            edge = FindEdge(edges, 0, 1000, 0, 800); // X-E
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 0, 800))); // X-E neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 800, 0, 0))); // X-E neighbours E-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // X-E neighbours Z-X
            edge = FindEdge(edges, 0, 800, 0, 0); // E-Y
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 0, 800))); // E-Y neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 800))); // E-Y neighbours X-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 200, 0))); // E-Y neighbours Y-F
            edge = FindEdge(edges, 0, 0, 200, 0); // Y-F
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 200, 200, 0))); // Y-F neighbours B-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 800, 0, 0))); // Y-F neighbours E-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 0, 800, 0))); // Y-F neighbours F-G
            edge = FindEdge(edges, 200, 0, 800, 0); // F-G
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 200, 200, 0))); // F-G neighbours B-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 200, 800, 0))); // F-G neighbours C-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 200, 0))); // F-G neighbours Y-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 0, 1000, 0))); // F-G neighbours G-W
            edge = FindEdge(edges, 800, 0, 1000, 0); // G-W
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 200, 800, 0))); // G-W neighbours C-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 0, 800, 0))); // G-W neighbours F-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 800))); // G-W neighbours W-H
            edge = FindEdge(edges, 1000, 0, 1000, 800); // W-H
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 1000, 800))); // W-H neighbours D-H
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 0, 1000, 0))); // W-H neighbours G-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 800, 1000, 1000))); // W-H neighbours H-Z
            edge = FindEdge(edges, 1000, 800, 1000, 1000); // H-Z
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 1000, 800))); // H-Z neighbours D-H
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 800))); // H-Z neighbours W-H
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // H-Z neighbours Z-X
            edge = FindEdge(edges, 1000, 1000, 0, 1000); // Z-X
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 800))); // Z-X neighbours X-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 800, 1000, 1000))); // Z-X neighbours H-Z
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

            // 1000 Y--------------------------------------⁕E---------X
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
            //    0 W--------------------------------------⁕H---------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            VoronoiEdge edge = FindEdge(edges, 400, 600, 200, 600); // A-B
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 600, 200, 400))); // A-B neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 400, 600))); // A-B neighbours D-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 800, 1000))); // A-B neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 600, 0, 800))); // A-B neighbours B-F
            edge = FindEdge(edges, 200, 600, 200, 400); // B-C
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 200, 600))); // B-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 400, 400, 400))); // B-C neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 600, 0, 800))); // B-C neighbours B-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 400, 0, 200))); // B-C neighbours C-G
            edge = FindEdge(edges, 200, 400, 400, 400); // C-D
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 600, 200, 400))); // C-D neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 400, 600))); // C-D neighbours D-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 400, 0, 200))); // C-D neighbours C-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 800, 0))); // C-D neighbours D-H
            edge = FindEdge(edges, 400, 400, 400, 600); // D-A
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 200, 600))); // D-A neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 400, 400, 400))); // D-A neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 800, 1000))); // D-A neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 800, 0))); // D-A neighbours D-H
            edge = FindEdge(edges, 400, 600, 800, 1000); // A-E
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 200, 600))); // A-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 400, 600))); // A-E neighbours D-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 800, 1000))); // A-E neighbours X-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 1000, 0, 1000))); // A-E neighbours E-Y
            edge = FindEdge(edges, 200, 600, 0, 800); // B-F
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 200, 600))); // B-F neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 600, 200, 400))); // B-F neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 800))); // B-F neighbours Y-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 800, 0, 200))); // B-F neighbours F-G
            edge = FindEdge(edges, 200, 400, 0, 200); // C-G
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 600, 200, 400))); // C-G neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 400, 400, 400))); // C-G neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 800, 0, 200))); // C-G neighbours F-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 200, 0, 0))); // C-G neighbours G-W
            edge = FindEdge(edges, 400, 400, 800, 0); // D-H
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 400, 400, 400))); // D-H neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 400, 600))); // D-H neighbours D-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 800, 0))); // D-H neighbours W-H
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 0, 1000, 0))); // D-H neighbours H-Z
            edge = FindEdge(edges, 1000, 1000, 800, 1000); // X-E
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 800, 1000))); // X-E neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 1000, 0, 1000))); // X-E neighbours E-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // X-E neighbours Z-X
            edge = FindEdge(edges, 800, 1000, 0, 1000); // E-Y
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 800, 1000))); // E-Y neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 800, 1000))); // E-Y neighbours X-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 800))); // E-Y neighbours Y-F
            edge = FindEdge(edges, 0, 1000, 0, 800); // Y-F
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 600, 0, 800))); // Y-F neighbours B-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 1000, 0, 1000))); // Y-F neighbours E-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 800, 0, 200))); // Y-F neighbours F-G
            edge = FindEdge(edges, 0, 800, 0, 200); // F-G
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 600, 0, 800))); // F-G neighbours B-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 400, 0, 200))); // F-G neighbours C-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 800))); // F-G neighbours Y-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 200, 0, 0))); // F-G neighbours G-W
            edge = FindEdge(edges, 0, 200, 0, 0); // G-W
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 400, 0, 200))); // G-W neighbours C-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 800, 0, 200))); // G-W neighbours F-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 800, 0))); // G-W neighbours W-H
            edge = FindEdge(edges, 0, 0, 800, 0); // W-H
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 800, 0))); // W-H neighbours D-H
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 200, 0, 0))); // W-H neighbours G-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 0, 1000, 0))); // W-H neighbours H-Z
            edge = FindEdge(edges, 800, 0, 1000, 0); // H-Z
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 800, 0))); // H-Z neighbours D-H
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 800, 0))); // H-Z neighbours W-H
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // H-Z neighbours Z-X
            edge = FindEdge(edges, 1000, 0, 1000, 1000); // Z-X
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 800, 1000))); // Z-X neighbours X-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 0, 1000, 0))); // Z-X neighbours H-Z
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

            // 1000 W---------G⁕---------------------------⁕F---------Y
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

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            VoronoiEdge edge = FindEdge(edges, 600, 600, 600, 800); // A-B
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 800, 400, 800))); // A-B neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 600, 600))); // A-B neighbours D-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 1000, 200))); // A-B neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 800, 800, 1000))); // A-B neighbours B-F
            edge = FindEdge(edges, 600, 800, 400, 800); // B-C
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 600, 800))); // B-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 800, 400, 600))); // B-C neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 800, 800, 1000))); // B-C neighbours B-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 800, 200, 1000))); // B-C neighbours C-G
            edge = FindEdge(edges, 400, 800, 400, 600); // C-D
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 800, 400, 800))); // C-D neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 600, 600))); // C-D neighbours D-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 800, 200, 1000))); // C-D neighbours C-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 0, 200))); // C-D neighbours D-H
            edge = FindEdge(edges, 400, 600, 600, 600); // D-A
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 600, 800))); // D-A neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 800, 400, 600))); // D-A neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 1000, 200))); // D-A neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 0, 200))); // D-A neighbours D-H
            edge = FindEdge(edges, 600, 600, 1000, 200); // A-E
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 600, 800))); // A-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 600, 600))); // A-E neighbours D-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 200))); // A-E neighbours X-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 200, 1000, 1000))); // A-E neighbours E-Y
            edge = FindEdge(edges, 600, 800, 800, 1000); // B-F
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 600, 800))); // B-F neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 800, 400, 800))); // B-F neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 800, 1000))); // B-F neighbours Y-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 1000, 200, 1000))); // B-F neighbours F-G
            edge = FindEdge(edges, 400, 800, 200, 1000); // C-G
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 800, 400, 800))); // C-G neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 800, 400, 600))); // C-G neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 1000, 200, 1000))); // C-G neighbours F-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 1000, 0, 1000))); // C-G neighbours G-W
            edge = FindEdge(edges, 400, 600, 0, 200); // D-H
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 800, 400, 600))); // D-H neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 600, 600))); // D-H neighbours D-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 200))); // D-H neighbours W-H
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 200, 0, 0))); // D-H neighbours H-Z
            edge = FindEdge(edges, 1000, 0, 1000, 200); // X-E
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 1000, 200))); // X-E neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 200, 1000, 1000))); // X-E neighbours E-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // X-E neighbours Z-X
            edge = FindEdge(edges, 1000, 200, 1000, 1000); // E-Y
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 1000, 200))); // E-Y neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 200))); // E-Y neighbours X-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 800, 1000))); // E-Y neighbours Y-F
            edge = FindEdge(edges, 1000, 1000, 800, 1000); // Y-F
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 800, 800, 1000))); // Y-F neighbours B-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 200, 1000, 1000))); // Y-F neighbours E-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 1000, 200, 1000))); // Y-F neighbours F-G
            edge = FindEdge(edges, 800, 1000, 200, 1000); // F-G
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 800, 800, 1000))); // F-G neighbours B-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 800, 200, 1000))); // F-G neighbours C-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 800, 1000))); // F-G neighbours Y-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 1000, 0, 1000))); // F-G neighbours G-W
            edge = FindEdge(edges, 200, 1000, 0, 1000); // G-W
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 800, 200, 1000))); // G-W neighbours C-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 1000, 200, 1000))); // G-W neighbours F-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 200))); // G-W neighbours W-H
            edge = FindEdge(edges, 0, 1000, 0, 200); // W-H
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 0, 200))); // W-H neighbours D-H
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 1000, 0, 1000))); // W-H neighbours G-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 200, 0, 0))); // W-H neighbours H-Z
            edge = FindEdge(edges, 0, 200, 0, 0); // H-Z
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 0, 200))); // H-Z neighbours D-H
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 200))); // H-Z neighbours W-H
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // H-Z neighbours Z-X
            edge = FindEdge(edges, 0, 0, 1000, 0); // Z-X
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 200))); // Z-X neighbours X-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 200, 0, 0))); // Z-X neighbours H-Z
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

            // 1000 Z---------H⁕--------------------------------------W
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
            //    0 X---------E⁕--------------------------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            VoronoiEdge edge = FindEdge(edges, 600, 400, 800, 400); // A-B
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 400, 800, 600))); // A-B neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 600, 400))); // A-B neighbours D-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 200, 0))); // A-B neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 400, 1000, 200))); // A-B neighbours B-F
            edge = FindEdge(edges, 800, 400, 800, 600); // B-C
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 800, 400))); // B-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 600, 600, 600))); // B-C neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 400, 1000, 200))); // B-C neighbours B-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 600, 1000, 800))); // B-C neighbours C-G
            edge = FindEdge(edges, 800, 600, 600, 600); // C-D
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 400, 800, 600))); // C-D neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 600, 400))); // C-D neighbours D-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 600, 1000, 800))); // C-D neighbours C-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 200, 1000))); // C-D neighbours D-H
            edge = FindEdge(edges, 600, 600, 600, 400); // D-A
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 800, 400))); // D-A neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 600, 600, 600))); // D-A neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 200, 0))); // D-A neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 200, 1000))); // D-A neighbours D-H
            edge = FindEdge(edges, 600, 400, 200, 0); // A-E
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 800, 400))); // A-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 600, 400))); // A-E neighbours D-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 200, 0))); // A-E neighbours X-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 0, 1000, 0))); // A-E neighbours E-Y
            edge = FindEdge(edges, 800, 400, 1000, 200); // B-F
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 800, 400))); // B-F neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 400, 800, 600))); // B-F neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 200))); // B-F neighbours Y-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 200, 1000, 800))); // B-F neighbours F-G
            edge = FindEdge(edges, 800, 600, 1000, 800); // C-G
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 400, 800, 600))); // C-G neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 600, 600, 600))); // C-G neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 200, 1000, 800))); // C-G neighbours F-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 800, 1000, 1000))); // C-G neighbours G-W
            edge = FindEdge(edges, 600, 600, 200, 1000); // D-H
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 600, 600, 600))); // D-H neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 600, 400))); // D-H neighbours D-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 200, 1000))); // D-H neighbours W-H
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 1000, 0, 1000))); // D-H neighbours H-Z
            edge = FindEdge(edges, 0, 0, 200, 0); // X-E
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 200, 0))); // X-E neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 0, 1000, 0))); // X-E neighbours E-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // X-E neighbours Z-X
            edge = FindEdge(edges, 200, 0, 1000, 0); // E-Y
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 200, 0))); // E-Y neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 200, 0))); // E-Y neighbours X-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 200))); // E-Y neighbours Y-F
            edge = FindEdge(edges, 1000, 0, 1000, 200); // Y-F
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 400, 1000, 200))); // Y-F neighbours B-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 0, 1000, 0))); // Y-F neighbours E-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 200, 1000, 800))); // Y-F neighbours F-G
            edge = FindEdge(edges, 1000, 200, 1000, 800); // F-G
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 400, 1000, 200))); // F-G neighbours B-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 600, 1000, 800))); // F-G neighbours C-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 200))); // F-G neighbours Y-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 800, 1000, 1000))); // F-G neighbours G-W
            edge = FindEdge(edges, 1000, 800, 1000, 1000); // G-W
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 600, 1000, 800))); // G-W neighbours C-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 200, 1000, 800))); // G-W neighbours F-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 200, 1000))); // G-W neighbours W-H
            edge = FindEdge(edges, 1000, 1000, 200, 1000); // W-H
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 200, 1000))); // W-H neighbours D-H
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 800, 1000, 1000))); // W-H neighbours G-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 1000, 0, 1000))); // W-H neighbours H-Z
            edge = FindEdge(edges, 200, 1000, 0, 1000); // H-Z
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 200, 1000))); // H-Z neighbours D-H
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 200, 1000))); // H-Z neighbours W-H
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // H-Z neighbours Z-X
            edge = FindEdge(edges, 0, 1000, 0, 0); // Z-X
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 200, 0))); // Z-X neighbours X-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 1000, 0, 1000))); // Z-X neighbours H-Z
        }

    }
}
