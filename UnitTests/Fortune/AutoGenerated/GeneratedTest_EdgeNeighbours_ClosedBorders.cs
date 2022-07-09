using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using static SharpVoronoiLib.UnitTests.CommonTestUtilities;

#pragma warning disable
// ReSharper disable All

namespace SharpVoronoiLib.UnitTests
{
    /// <summary>
    /// These tests assert that <see cref="VoronoiEdge"/>`s have expected neighbouring edges.
    /// Specifically, that the <see cref="VoronoiEdge.Neighbours"/> contains the expected <see cref="VoronoiEdge"/>`s.
    /// These tests are run with generating the border edges, i.e. <see cref="BorderEdgeGeneration.MakeBorderEdges"/>.
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

            Assume.That(() => 4 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0)); // X-Y
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0)); // Y-W
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000)); // W-Z
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000)); // Z-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 0, 1000, 0, 0); // X-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // X-Y neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // X-Y neighbours Z-X
            edge = FindEdge(edges, 0, 0, 1000, 0); // Y-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // Y-W neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // Y-W neighbours W-Z
            edge = FindEdge(edges, 1000, 0, 1000, 1000); // W-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // W-Z neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // W-Z neighbours Z-X
            edge = FindEdge(edges, 1000, 1000, 0, 1000); // Z-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // Z-X neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // Z-X neighbours W-Z
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

            Assume.That(() => 4 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0)); // X-Y
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0)); // Y-W
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000)); // W-Z
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000)); // Z-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 0, 1000, 0, 0); // X-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // X-Y neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // X-Y neighbours Z-X
            edge = FindEdge(edges, 0, 0, 1000, 0); // Y-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // Y-W neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // Y-W neighbours W-Z
            edge = FindEdge(edges, 1000, 0, 1000, 1000); // W-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // W-Z neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // W-Z neighbours Z-X
            edge = FindEdge(edges, 1000, 1000, 0, 1000); // Z-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // Z-X neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // Z-X neighbours W-Z
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

            Assume.That(() => 4 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0)); // X-Y
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0)); // Y-W
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000)); // W-Z
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000)); // Z-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 0, 1000, 0, 0); // X-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // X-Y neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // X-Y neighbours Z-X
            edge = FindEdge(edges, 0, 0, 1000, 0); // Y-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // Y-W neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // Y-W neighbours W-Z
            edge = FindEdge(edges, 1000, 0, 1000, 1000); // W-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // W-Z neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // W-Z neighbours Z-X
            edge = FindEdge(edges, 1000, 1000, 0, 1000); // Z-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // Z-X neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // Z-X neighbours W-Z
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

            Assume.That(() => 4 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000)); // X-Y
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0)); // Y-W
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0)); // W-Z
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000)); // Z-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 1000, 1000, 0, 1000); // X-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // X-Y neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // X-Y neighbours Z-X
            edge = FindEdge(edges, 0, 1000, 0, 0); // Y-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // Y-W neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // Y-W neighbours W-Z
            edge = FindEdge(edges, 0, 0, 1000, 0); // W-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // W-Z neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // W-Z neighbours Z-X
            edge = FindEdge(edges, 1000, 0, 1000, 1000); // Z-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // Z-X neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // Z-X neighbours W-Z
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

            Assume.That(() => 4 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000)); // X-Y
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000)); // Y-W
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0)); // W-Z
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0)); // Z-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 1000, 0, 1000, 1000); // X-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // X-Y neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // X-Y neighbours Z-X
            edge = FindEdge(edges, 1000, 1000, 0, 1000); // Y-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // Y-W neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // Y-W neighbours W-Z
            edge = FindEdge(edges, 0, 1000, 0, 0); // W-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // W-Z neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // W-Z neighbours Z-X
            edge = FindEdge(edges, 0, 0, 1000, 0); // Z-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // Z-X neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // Z-X neighbours W-Z
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

            Assume.That(() => 4 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0)); // X-Y
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000)); // Y-W
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000)); // W-Z
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0)); // Z-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 0, 0, 1000, 0); // X-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // X-Y neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // X-Y neighbours Z-X
            edge = FindEdge(edges, 1000, 0, 1000, 1000); // Y-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // Y-W neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // Y-W neighbours W-Z
            edge = FindEdge(edges, 1000, 1000, 0, 1000); // W-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // W-Z neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // W-Z neighbours Z-X
            edge = FindEdge(edges, 0, 1000, 0, 0); // Z-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // Z-X neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // Z-X neighbours W-Z
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

            Assume.That(() => 4 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0)); // X-Y
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0)); // Y-W
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000)); // W-Z
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000)); // Z-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 0, 1000, 0, 0); // X-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // X-Y neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // X-Y neighbours Z-X
            edge = FindEdge(edges, 0, 0, 1000, 0); // Y-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // Y-W neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // Y-W neighbours W-Z
            edge = FindEdge(edges, 1000, 0, 1000, 1000); // W-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // W-Z neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // W-Z neighbours Z-X
            edge = FindEdge(edges, 1000, 1000, 0, 1000); // Z-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // Z-X neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // Z-X neighbours W-Z
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

            Assume.That(() => 4 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000)); // X-Y
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0)); // Y-W
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0)); // W-Z
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000)); // Z-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 1000, 1000, 0, 1000); // X-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // X-Y neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // X-Y neighbours Z-X
            edge = FindEdge(edges, 0, 1000, 0, 0); // Y-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // Y-W neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // Y-W neighbours W-Z
            edge = FindEdge(edges, 0, 0, 1000, 0); // W-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // W-Z neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // W-Z neighbours Z-X
            edge = FindEdge(edges, 1000, 0, 1000, 1000); // Z-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // Z-X neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // Z-X neighbours W-Z
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

            Assume.That(() => 4 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000)); // X-Y
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000)); // Y-W
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0)); // W-Z
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0)); // Z-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 1000, 0, 1000, 1000); // X-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // X-Y neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // X-Y neighbours Z-X
            edge = FindEdge(edges, 1000, 1000, 0, 1000); // Y-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // Y-W neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // Y-W neighbours W-Z
            edge = FindEdge(edges, 0, 1000, 0, 0); // W-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // W-Z neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // W-Z neighbours Z-X
            edge = FindEdge(edges, 0, 0, 1000, 0); // Z-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // Z-X neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // Z-X neighbours W-Z
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

            Assume.That(() => 4 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0)); // X-Y
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000)); // Y-W
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000)); // W-Z
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0)); // Z-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 0, 0, 1000, 0); // X-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // X-Y neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // X-Y neighbours Z-X
            edge = FindEdge(edges, 1000, 0, 1000, 1000); // Y-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // Y-W neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // Y-W neighbours W-Z
            edge = FindEdge(edges, 1000, 1000, 0, 1000); // W-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // W-Z neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // W-Z neighbours Z-X
            edge = FindEdge(edges, 0, 1000, 0, 0); // Z-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // Z-X neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // Z-X neighbours W-Z
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

            Assume.That(() => 4 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0)); // X-Y
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0)); // Y-W
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000)); // W-Z
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000)); // Z-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 0, 1000, 0, 0); // X-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // X-Y neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // X-Y neighbours Z-X
            edge = FindEdge(edges, 0, 0, 1000, 0); // Y-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // Y-W neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // Y-W neighbours W-Z
            edge = FindEdge(edges, 1000, 0, 1000, 1000); // W-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // W-Z neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // W-Z neighbours Z-X
            edge = FindEdge(edges, 1000, 1000, 0, 1000); // Z-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // Z-X neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // Z-X neighbours W-Z
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

            Assume.That(() => 4 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000)); // X-Y
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0)); // Y-W
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0)); // W-Z
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000)); // Z-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 1000, 1000, 0, 1000); // X-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // X-Y neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // X-Y neighbours Z-X
            edge = FindEdge(edges, 0, 1000, 0, 0); // Y-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // Y-W neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // Y-W neighbours W-Z
            edge = FindEdge(edges, 0, 0, 1000, 0); // W-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // W-Z neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // W-Z neighbours Z-X
            edge = FindEdge(edges, 1000, 0, 1000, 1000); // Z-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // Z-X neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // Z-X neighbours W-Z
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

            Assume.That(() => 4 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000)); // X-Y
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000)); // Y-W
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0)); // W-Z
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0)); // Z-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 1000, 0, 1000, 1000); // X-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // X-Y neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // X-Y neighbours Z-X
            edge = FindEdge(edges, 1000, 1000, 0, 1000); // Y-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // Y-W neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // Y-W neighbours W-Z
            edge = FindEdge(edges, 0, 1000, 0, 0); // W-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // W-Z neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // W-Z neighbours Z-X
            edge = FindEdge(edges, 0, 0, 1000, 0); // Z-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // Z-X neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // Z-X neighbours W-Z
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

            Assume.That(() => 4 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0)); // X-Y
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000)); // Y-W
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000)); // W-Z
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0)); // Z-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 0, 0, 1000, 0); // X-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // X-Y neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // X-Y neighbours Z-X
            edge = FindEdge(edges, 1000, 0, 1000, 1000); // Y-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // Y-W neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // Y-W neighbours W-Z
            edge = FindEdge(edges, 1000, 1000, 0, 1000); // W-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // W-Z neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // W-Z neighbours Z-X
            edge = FindEdge(edges, 0, 1000, 0, 0); // Z-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // Z-X neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // Z-X neighbours W-Z
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

            Assume.That(() => 4 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0)); // X-Y
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0)); // Y-W
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000)); // W-Z
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000)); // Z-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 0, 1000, 0, 0); // X-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // X-Y neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // X-Y neighbours Z-X
            edge = FindEdge(edges, 0, 0, 1000, 0); // Y-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // Y-W neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // Y-W neighbours W-Z
            edge = FindEdge(edges, 1000, 0, 1000, 1000); // W-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // W-Z neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // W-Z neighbours Z-X
            edge = FindEdge(edges, 1000, 1000, 0, 1000); // Z-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // Z-X neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // Z-X neighbours W-Z
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

            Assume.That(() => 4 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000)); // X-Y
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0)); // Y-W
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0)); // W-Z
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000)); // Z-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 1000, 1000, 0, 1000); // X-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // X-Y neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // X-Y neighbours Z-X
            edge = FindEdge(edges, 0, 1000, 0, 0); // Y-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // Y-W neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // Y-W neighbours W-Z
            edge = FindEdge(edges, 0, 0, 1000, 0); // W-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // W-Z neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // W-Z neighbours Z-X
            edge = FindEdge(edges, 1000, 0, 1000, 1000); // Z-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // Z-X neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // Z-X neighbours W-Z
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

            Assume.That(() => 4 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000)); // X-Y
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000)); // Y-W
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0)); // W-Z
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0)); // Z-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 1000, 0, 1000, 1000); // X-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // X-Y neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // X-Y neighbours Z-X
            edge = FindEdge(edges, 1000, 1000, 0, 1000); // Y-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // Y-W neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // Y-W neighbours W-Z
            edge = FindEdge(edges, 0, 1000, 0, 0); // W-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // W-Z neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // W-Z neighbours Z-X
            edge = FindEdge(edges, 0, 0, 1000, 0); // Z-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // Z-X neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // Z-X neighbours W-Z
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

            Assume.That(() => 4 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0)); // X-Y
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000)); // Y-W
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000)); // W-Z
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0)); // Z-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 0, 0, 1000, 0); // X-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // X-Y neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // X-Y neighbours Z-X
            edge = FindEdge(edges, 1000, 0, 1000, 1000); // Y-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // Y-W neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // Y-W neighbours W-Z
            edge = FindEdge(edges, 1000, 1000, 0, 1000); // W-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // W-Z neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // W-Z neighbours Z-X
            edge = FindEdge(edges, 0, 1000, 0, 0); // Z-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // Z-X neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // Z-X neighbours W-Z
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

            Assume.That(() => 4 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 1000, 1000, 1000, 0)); // X-Y
            Assume.That(() => HasEdge(edges, 1000, 0, 0, 0)); // Y-W
            Assume.That(() => HasEdge(edges, 0, 0, 0, 1000)); // W-Z
            Assume.That(() => HasEdge(edges, 0, 1000, 1000, 1000)); // Z-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 1000, 1000, 1000, 0); // X-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 0, 0))); // X-Y neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 1000, 1000))); // X-Y neighbours Z-X
            edge = FindEdge(edges, 1000, 0, 0, 0); // Y-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 1000, 0))); // Y-W neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 0, 1000))); // Y-W neighbours W-Z
            edge = FindEdge(edges, 0, 0, 0, 1000); // W-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 0, 0))); // W-Z neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 1000, 1000))); // W-Z neighbours Z-X
            edge = FindEdge(edges, 0, 1000, 1000, 1000); // Z-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 1000, 0))); // Z-X neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 0, 1000))); // Z-X neighbours W-Z
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

            Assume.That(() => 4 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 1000, 0, 0, 0)); // X-Y
            Assume.That(() => HasEdge(edges, 0, 0, 0, 1000)); // Y-W
            Assume.That(() => HasEdge(edges, 0, 1000, 1000, 1000)); // W-Z
            Assume.That(() => HasEdge(edges, 1000, 1000, 1000, 0)); // Z-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 1000, 0, 0, 0); // X-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 0, 1000))); // X-Y neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 1000, 0))); // X-Y neighbours Z-X
            edge = FindEdge(edges, 0, 0, 0, 1000); // Y-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 0, 0))); // Y-W neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 1000, 1000))); // Y-W neighbours W-Z
            edge = FindEdge(edges, 0, 1000, 1000, 1000); // W-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 0, 1000))); // W-Z neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 1000, 0))); // W-Z neighbours Z-X
            edge = FindEdge(edges, 1000, 1000, 1000, 0); // Z-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 0, 0))); // Z-X neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 1000, 1000))); // Z-X neighbours W-Z
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

            Assume.That(() => 4 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 0, 0, 1000)); // X-Y
            Assume.That(() => HasEdge(edges, 0, 1000, 1000, 1000)); // Y-W
            Assume.That(() => HasEdge(edges, 1000, 1000, 1000, 0)); // W-Z
            Assume.That(() => HasEdge(edges, 1000, 0, 0, 0)); // Z-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 0, 0, 0, 1000); // X-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 1000, 1000))); // X-Y neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 0, 0))); // X-Y neighbours Z-X
            edge = FindEdge(edges, 0, 1000, 1000, 1000); // Y-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 0, 1000))); // Y-W neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 1000, 0))); // Y-W neighbours W-Z
            edge = FindEdge(edges, 1000, 1000, 1000, 0); // W-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 1000, 1000))); // W-Z neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 0, 0))); // W-Z neighbours Z-X
            edge = FindEdge(edges, 1000, 0, 0, 0); // Z-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 0, 1000))); // Z-X neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 1000, 0))); // Z-X neighbours W-Z
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

            Assume.That(() => 4 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 1000, 1000, 1000)); // X-Y
            Assume.That(() => HasEdge(edges, 1000, 1000, 1000, 0)); // Y-W
            Assume.That(() => HasEdge(edges, 1000, 0, 0, 0)); // W-Z
            Assume.That(() => HasEdge(edges, 0, 0, 0, 1000)); // Z-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 0, 1000, 1000, 1000); // X-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 1000, 0))); // X-Y neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 0, 1000))); // X-Y neighbours Z-X
            edge = FindEdge(edges, 1000, 1000, 1000, 0); // Y-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 1000, 1000))); // Y-W neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 0, 0))); // Y-W neighbours W-Z
            edge = FindEdge(edges, 1000, 0, 0, 0); // W-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 1000, 0))); // W-Z neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 0, 1000))); // W-Z neighbours Z-X
            edge = FindEdge(edges, 0, 0, 0, 1000); // Z-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 1000, 1000))); // Z-X neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 0, 0))); // Z-X neighbours W-Z
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

            Assume.That(() => 4 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0)); // X-Y
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0)); // Y-W
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000)); // W-Z
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000)); // Z-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 0, 1000, 0, 0); // X-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // X-Y neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // X-Y neighbours Z-X
            edge = FindEdge(edges, 0, 0, 1000, 0); // Y-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // Y-W neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // Y-W neighbours W-Z
            edge = FindEdge(edges, 1000, 0, 1000, 1000); // W-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // W-Z neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // W-Z neighbours Z-X
            edge = FindEdge(edges, 1000, 1000, 0, 1000); // Z-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // Z-X neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // Z-X neighbours W-Z
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

            Assume.That(() => 4 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000)); // X-Y
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0)); // Y-W
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0)); // W-Z
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000)); // Z-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 1000, 1000, 0, 1000); // X-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // X-Y neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // X-Y neighbours Z-X
            edge = FindEdge(edges, 0, 1000, 0, 0); // Y-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // Y-W neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // Y-W neighbours W-Z
            edge = FindEdge(edges, 0, 0, 1000, 0); // W-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // W-Z neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // W-Z neighbours Z-X
            edge = FindEdge(edges, 1000, 0, 1000, 1000); // Z-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // Z-X neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // Z-X neighbours W-Z
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

            Assume.That(() => 4 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000)); // X-Y
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000)); // Y-W
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0)); // W-Z
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0)); // Z-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 1000, 0, 1000, 1000); // X-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // X-Y neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // X-Y neighbours Z-X
            edge = FindEdge(edges, 1000, 1000, 0, 1000); // Y-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // Y-W neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // Y-W neighbours W-Z
            edge = FindEdge(edges, 0, 1000, 0, 0); // W-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // W-Z neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // W-Z neighbours Z-X
            edge = FindEdge(edges, 0, 0, 1000, 0); // Z-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // Z-X neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // Z-X neighbours W-Z
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

            Assume.That(() => 4 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0)); // X-Y
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000)); // Y-W
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000)); // W-Z
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0)); // Z-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 0, 0, 1000, 0); // X-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // X-Y neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // X-Y neighbours Z-X
            edge = FindEdge(edges, 1000, 0, 1000, 1000); // Y-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // Y-W neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // Y-W neighbours W-Z
            edge = FindEdge(edges, 1000, 1000, 0, 1000); // W-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // W-Z neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // W-Z neighbours Z-X
            edge = FindEdge(edges, 0, 1000, 0, 0); // Z-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // Z-X neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // Z-X neighbours W-Z
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

            Assume.That(() => 7 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 500, 1000, 500)); // A-B
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 500)); // X-A
            Assume.That(() => HasEdge(edges, 0, 500, 0, 0)); // A-Y
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0)); // Y-W
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 500)); // W-B
            Assume.That(() => HasEdge(edges, 1000, 500, 1000, 1000)); // B-Z
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000)); // Z-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 0, 500, 1000, 500); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 500))); // A-B neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 0, 0))); // A-B neighbours A-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 500))); // A-B neighbours W-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 500, 1000, 1000))); // A-B neighbours B-Z
            edge = FindEdge(edges, 0, 1000, 0, 500); // X-A
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 1000, 500))); // X-A neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 0, 0))); // X-A neighbours A-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // X-A neighbours Z-X
            edge = FindEdge(edges, 0, 500, 0, 0); // A-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 1000, 500))); // A-Y neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 500))); // A-Y neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // A-Y neighbours Y-W
            edge = FindEdge(edges, 0, 0, 1000, 0); // Y-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 0, 0))); // Y-W neighbours A-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 500))); // Y-W neighbours W-B
            edge = FindEdge(edges, 1000, 0, 1000, 500); // W-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 1000, 500))); // W-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // W-B neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 500, 1000, 1000))); // W-B neighbours B-Z
            edge = FindEdge(edges, 1000, 500, 1000, 1000); // B-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 1000, 500))); // B-Z neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 500))); // B-Z neighbours W-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // B-Z neighbours Z-X
            edge = FindEdge(edges, 1000, 1000, 0, 1000); // Z-X
            Assert.NotNull(edge.Neighbours);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 7 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 500, 1000, 500, 0)); // A-B
            Assume.That(() => HasEdge(edges, 1000, 1000, 500, 1000)); // X-A
            Assume.That(() => HasEdge(edges, 500, 1000, 0, 1000)); // A-Y
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0)); // Y-W
            Assume.That(() => HasEdge(edges, 0, 0, 500, 0)); // W-B
            Assume.That(() => HasEdge(edges, 500, 0, 1000, 0)); // B-Z
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000)); // Z-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 500, 1000, 500, 0); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 500, 1000))); // A-B neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 1000, 0, 1000))); // A-B neighbours A-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 500, 0))); // A-B neighbours W-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 0, 1000, 0))); // A-B neighbours B-Z
            edge = FindEdge(edges, 1000, 1000, 500, 1000); // X-A
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 1000, 500, 0))); // X-A neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 1000, 0, 1000))); // X-A neighbours A-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // X-A neighbours Z-X
            edge = FindEdge(edges, 500, 1000, 0, 1000); // A-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 1000, 500, 0))); // A-Y neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 500, 1000))); // A-Y neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // A-Y neighbours Y-W
            edge = FindEdge(edges, 0, 1000, 0, 0); // Y-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 1000, 0, 1000))); // Y-W neighbours A-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 500, 0))); // Y-W neighbours W-B
            edge = FindEdge(edges, 0, 0, 500, 0); // W-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 1000, 500, 0))); // W-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // W-B neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 0, 1000, 0))); // W-B neighbours B-Z
            edge = FindEdge(edges, 500, 0, 1000, 0); // B-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 1000, 500, 0))); // B-Z neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 500, 0))); // B-Z neighbours W-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // B-Z neighbours Z-X
            edge = FindEdge(edges, 1000, 0, 1000, 1000); // Z-X
            Assert.NotNull(edge.Neighbours);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 7 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 700, 1000, 700)); // A-B
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 700)); // X-A
            Assume.That(() => HasEdge(edges, 0, 700, 0, 0)); // A-Y
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0)); // Y-W
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 700)); // W-B
            Assume.That(() => HasEdge(edges, 1000, 700, 1000, 1000)); // B-Z
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000)); // Z-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 0, 700, 1000, 700); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 700))); // A-B neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 0, 0))); // A-B neighbours A-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 700))); // A-B neighbours W-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 700, 1000, 1000))); // A-B neighbours B-Z
            edge = FindEdge(edges, 0, 1000, 0, 700); // X-A
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 1000, 700))); // X-A neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 0, 0))); // X-A neighbours A-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // X-A neighbours Z-X
            edge = FindEdge(edges, 0, 700, 0, 0); // A-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 1000, 700))); // A-Y neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 700))); // A-Y neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // A-Y neighbours Y-W
            edge = FindEdge(edges, 0, 0, 1000, 0); // Y-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 0, 0))); // Y-W neighbours A-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 700))); // Y-W neighbours W-B
            edge = FindEdge(edges, 1000, 0, 1000, 700); // W-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 1000, 700))); // W-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // W-B neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 700, 1000, 1000))); // W-B neighbours B-Z
            edge = FindEdge(edges, 1000, 700, 1000, 1000); // B-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 1000, 700))); // B-Z neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 700))); // B-Z neighbours W-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // B-Z neighbours Z-X
            edge = FindEdge(edges, 1000, 1000, 0, 1000); // Z-X
            Assert.NotNull(edge.Neighbours);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 7 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 700, 1000, 700, 0)); // A-B
            Assume.That(() => HasEdge(edges, 1000, 1000, 700, 1000)); // X-A
            Assume.That(() => HasEdge(edges, 700, 1000, 0, 1000)); // A-Y
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0)); // Y-W
            Assume.That(() => HasEdge(edges, 0, 0, 700, 0)); // W-B
            Assume.That(() => HasEdge(edges, 700, 0, 1000, 0)); // B-Z
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000)); // Z-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 700, 1000, 700, 0); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 700, 1000))); // A-B neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 1000, 0, 1000))); // A-B neighbours A-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 700, 0))); // A-B neighbours W-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 0, 1000, 0))); // A-B neighbours B-Z
            edge = FindEdge(edges, 1000, 1000, 700, 1000); // X-A
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 1000, 700, 0))); // X-A neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 1000, 0, 1000))); // X-A neighbours A-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // X-A neighbours Z-X
            edge = FindEdge(edges, 700, 1000, 0, 1000); // A-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 1000, 700, 0))); // A-Y neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 700, 1000))); // A-Y neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // A-Y neighbours Y-W
            edge = FindEdge(edges, 0, 1000, 0, 0); // Y-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 1000, 0, 1000))); // Y-W neighbours A-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 700, 0))); // Y-W neighbours W-B
            edge = FindEdge(edges, 0, 0, 700, 0); // W-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 1000, 700, 0))); // W-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // W-B neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 0, 1000, 0))); // W-B neighbours B-Z
            edge = FindEdge(edges, 700, 0, 1000, 0); // B-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 1000, 700, 0))); // B-Z neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 700, 0))); // B-Z neighbours W-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // B-Z neighbours Z-X
            edge = FindEdge(edges, 1000, 0, 1000, 1000); // Z-X
            Assert.NotNull(edge.Neighbours);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 10 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 700, 1000, 700)); // A-B
            Assume.That(() => HasEdge(edges, 0, 300, 1000, 300)); // C-D
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 700)); // X-A
            Assume.That(() => HasEdge(edges, 0, 700, 0, 300)); // A-C
            Assume.That(() => HasEdge(edges, 0, 300, 0, 0)); // C-Y
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0)); // Y-W
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 300)); // W-D
            Assume.That(() => HasEdge(edges, 1000, 300, 1000, 700)); // D-B
            Assume.That(() => HasEdge(edges, 1000, 700, 1000, 1000)); // B-Z
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000)); // Z-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 0, 700, 1000, 700); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 700))); // A-B neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 0, 300))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 300, 1000, 700))); // A-B neighbours D-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 700, 1000, 1000))); // A-B neighbours B-Z
            edge = FindEdge(edges, 0, 300, 1000, 300); // C-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 0, 300))); // C-D neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 300, 0, 0))); // C-D neighbours C-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 300))); // C-D neighbours W-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 300, 1000, 700))); // C-D neighbours D-B
            edge = FindEdge(edges, 0, 1000, 0, 700); // X-A
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 1000, 700))); // X-A neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 0, 300))); // X-A neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // X-A neighbours Z-X
            edge = FindEdge(edges, 0, 700, 0, 300); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 1000, 700))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 300, 1000, 300))); // A-C neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 700))); // A-C neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 300, 0, 0))); // A-C neighbours C-Y
            edge = FindEdge(edges, 0, 300, 0, 0); // C-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 300, 1000, 300))); // C-Y neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 0, 300))); // C-Y neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // C-Y neighbours Y-W
            edge = FindEdge(edges, 0, 0, 1000, 0); // Y-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 300, 0, 0))); // Y-W neighbours C-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 300))); // Y-W neighbours W-D
            edge = FindEdge(edges, 1000, 0, 1000, 300); // W-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 300, 1000, 300))); // W-D neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // W-D neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 300, 1000, 700))); // W-D neighbours D-B
            edge = FindEdge(edges, 1000, 300, 1000, 700); // D-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 1000, 700))); // D-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 300, 1000, 300))); // D-B neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 300))); // D-B neighbours W-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 700, 1000, 1000))); // D-B neighbours B-Z
            edge = FindEdge(edges, 1000, 700, 1000, 1000); // B-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 1000, 700))); // B-Z neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 300, 1000, 700))); // B-Z neighbours D-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // B-Z neighbours Z-X
            edge = FindEdge(edges, 1000, 1000, 0, 1000); // Z-X
            Assert.NotNull(edge.Neighbours);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 10 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 700, 1000, 700, 0)); // A-B
            Assume.That(() => HasEdge(edges, 300, 1000, 300, 0)); // C-D
            Assume.That(() => HasEdge(edges, 1000, 1000, 700, 1000)); // X-A
            Assume.That(() => HasEdge(edges, 700, 1000, 300, 1000)); // A-C
            Assume.That(() => HasEdge(edges, 300, 1000, 0, 1000)); // C-Y
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0)); // Y-W
            Assume.That(() => HasEdge(edges, 0, 0, 300, 0)); // W-D
            Assume.That(() => HasEdge(edges, 300, 0, 700, 0)); // D-B
            Assume.That(() => HasEdge(edges, 700, 0, 1000, 0)); // B-Z
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000)); // Z-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 700, 1000, 700, 0); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 700, 1000))); // A-B neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 1000, 300, 1000))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 0, 700, 0))); // A-B neighbours D-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 0, 1000, 0))); // A-B neighbours B-Z
            edge = FindEdge(edges, 300, 1000, 300, 0); // C-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 1000, 300, 1000))); // C-D neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 1000, 0, 1000))); // C-D neighbours C-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 300, 0))); // C-D neighbours W-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 0, 700, 0))); // C-D neighbours D-B
            edge = FindEdge(edges, 1000, 1000, 700, 1000); // X-A
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 1000, 700, 0))); // X-A neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 1000, 300, 1000))); // X-A neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // X-A neighbours Z-X
            edge = FindEdge(edges, 700, 1000, 300, 1000); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 1000, 700, 0))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 1000, 300, 0))); // A-C neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 700, 1000))); // A-C neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 1000, 0, 1000))); // A-C neighbours C-Y
            edge = FindEdge(edges, 300, 1000, 0, 1000); // C-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 1000, 300, 0))); // C-Y neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 1000, 300, 1000))); // C-Y neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // C-Y neighbours Y-W
            edge = FindEdge(edges, 0, 1000, 0, 0); // Y-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 1000, 0, 1000))); // Y-W neighbours C-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 300, 0))); // Y-W neighbours W-D
            edge = FindEdge(edges, 0, 0, 300, 0); // W-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 1000, 300, 0))); // W-D neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // W-D neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 0, 700, 0))); // W-D neighbours D-B
            edge = FindEdge(edges, 300, 0, 700, 0); // D-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 1000, 700, 0))); // D-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 1000, 300, 0))); // D-B neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 300, 0))); // D-B neighbours W-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 0, 1000, 0))); // D-B neighbours B-Z
            edge = FindEdge(edges, 700, 0, 1000, 0); // B-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 1000, 700, 0))); // B-Z neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 0, 700, 0))); // B-Z neighbours D-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // B-Z neighbours Z-X
            edge = FindEdge(edges, 1000, 0, 1000, 1000); // Z-X
            Assert.NotNull(edge.Neighbours);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 13 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 700, 1000, 700)); // A-B
            Assume.That(() => HasEdge(edges, 0, 500, 1000, 500)); // C-D
            Assume.That(() => HasEdge(edges, 0, 300, 1000, 300)); // E-F
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 700)); // X-A
            Assume.That(() => HasEdge(edges, 0, 700, 0, 500)); // A-C
            Assume.That(() => HasEdge(edges, 0, 500, 0, 300)); // C-E
            Assume.That(() => HasEdge(edges, 0, 300, 0, 0)); // E-Y
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0)); // Y-W
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 300)); // W-F
            Assume.That(() => HasEdge(edges, 1000, 300, 1000, 500)); // F-D
            Assume.That(() => HasEdge(edges, 1000, 500, 1000, 700)); // D-B
            Assume.That(() => HasEdge(edges, 1000, 700, 1000, 1000)); // B-Z
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000)); // Z-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 0, 700, 1000, 700); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 700))); // A-B neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 0, 500))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 500, 1000, 700))); // A-B neighbours D-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 700, 1000, 1000))); // A-B neighbours B-Z
            edge = FindEdge(edges, 0, 500, 1000, 500); // C-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 0, 500))); // C-D neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 0, 300))); // C-D neighbours C-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 300, 1000, 500))); // C-D neighbours F-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 500, 1000, 700))); // C-D neighbours D-B
            edge = FindEdge(edges, 0, 300, 1000, 300); // E-F
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 0, 300))); // E-F neighbours C-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 300, 0, 0))); // E-F neighbours E-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 300))); // E-F neighbours W-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 300, 1000, 500))); // E-F neighbours F-D
            edge = FindEdge(edges, 0, 1000, 0, 700); // X-A
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 1000, 700))); // X-A neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 0, 500))); // X-A neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // X-A neighbours Z-X
            edge = FindEdge(edges, 0, 700, 0, 500); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 1000, 700))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 1000, 500))); // A-C neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 700))); // A-C neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 0, 300))); // A-C neighbours C-E
            edge = FindEdge(edges, 0, 500, 0, 300); // C-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 1000, 500))); // C-E neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 300, 1000, 300))); // C-E neighbours E-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 0, 500))); // C-E neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 300, 0, 0))); // C-E neighbours E-Y
            edge = FindEdge(edges, 0, 300, 0, 0); // E-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 300, 1000, 300))); // E-Y neighbours E-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 0, 300))); // E-Y neighbours C-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // E-Y neighbours Y-W
            edge = FindEdge(edges, 0, 0, 1000, 0); // Y-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 300, 0, 0))); // Y-W neighbours E-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 300))); // Y-W neighbours W-F
            edge = FindEdge(edges, 1000, 0, 1000, 300); // W-F
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 300, 1000, 300))); // W-F neighbours E-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // W-F neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 300, 1000, 500))); // W-F neighbours F-D
            edge = FindEdge(edges, 1000, 300, 1000, 500); // F-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 1000, 500))); // F-D neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 300, 1000, 300))); // F-D neighbours E-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 300))); // F-D neighbours W-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 500, 1000, 700))); // F-D neighbours D-B
            edge = FindEdge(edges, 1000, 500, 1000, 700); // D-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 1000, 700))); // D-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 1000, 500))); // D-B neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 300, 1000, 500))); // D-B neighbours F-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 700, 1000, 1000))); // D-B neighbours B-Z
            edge = FindEdge(edges, 1000, 700, 1000, 1000); // B-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 1000, 700))); // B-Z neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 500, 1000, 700))); // B-Z neighbours D-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // B-Z neighbours Z-X
            edge = FindEdge(edges, 1000, 1000, 0, 1000); // Z-X
            Assert.NotNull(edge.Neighbours);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 13 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 700, 1000, 700, 0)); // A-B
            Assume.That(() => HasEdge(edges, 500, 1000, 500, 0)); // C-D
            Assume.That(() => HasEdge(edges, 300, 1000, 300, 0)); // E-F
            Assume.That(() => HasEdge(edges, 1000, 1000, 700, 1000)); // X-A
            Assume.That(() => HasEdge(edges, 700, 1000, 500, 1000)); // A-C
            Assume.That(() => HasEdge(edges, 500, 1000, 300, 1000)); // C-E
            Assume.That(() => HasEdge(edges, 300, 1000, 0, 1000)); // E-Y
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0)); // Y-W
            Assume.That(() => HasEdge(edges, 0, 0, 300, 0)); // W-F
            Assume.That(() => HasEdge(edges, 300, 0, 500, 0)); // F-D
            Assume.That(() => HasEdge(edges, 500, 0, 700, 0)); // D-B
            Assume.That(() => HasEdge(edges, 700, 0, 1000, 0)); // B-Z
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000)); // Z-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 700, 1000, 700, 0); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 700, 1000))); // A-B neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 1000, 500, 1000))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 0, 700, 0))); // A-B neighbours D-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 0, 1000, 0))); // A-B neighbours B-Z
            edge = FindEdge(edges, 500, 1000, 500, 0); // C-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 1000, 500, 1000))); // C-D neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 1000, 300, 1000))); // C-D neighbours C-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 0, 500, 0))); // C-D neighbours F-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 0, 700, 0))); // C-D neighbours D-B
            edge = FindEdge(edges, 300, 1000, 300, 0); // E-F
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 1000, 300, 1000))); // E-F neighbours C-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 1000, 0, 1000))); // E-F neighbours E-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 300, 0))); // E-F neighbours W-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 0, 500, 0))); // E-F neighbours F-D
            edge = FindEdge(edges, 1000, 1000, 700, 1000); // X-A
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 1000, 700, 0))); // X-A neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 1000, 500, 1000))); // X-A neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // X-A neighbours Z-X
            edge = FindEdge(edges, 700, 1000, 500, 1000); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 1000, 700, 0))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 1000, 500, 0))); // A-C neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 700, 1000))); // A-C neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 1000, 300, 1000))); // A-C neighbours C-E
            edge = FindEdge(edges, 500, 1000, 300, 1000); // C-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 1000, 500, 0))); // C-E neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 1000, 300, 0))); // C-E neighbours E-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 1000, 500, 1000))); // C-E neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 1000, 0, 1000))); // C-E neighbours E-Y
            edge = FindEdge(edges, 300, 1000, 0, 1000); // E-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 1000, 300, 0))); // E-Y neighbours E-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 1000, 300, 1000))); // E-Y neighbours C-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // E-Y neighbours Y-W
            edge = FindEdge(edges, 0, 1000, 0, 0); // Y-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 1000, 0, 1000))); // Y-W neighbours E-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 300, 0))); // Y-W neighbours W-F
            edge = FindEdge(edges, 0, 0, 300, 0); // W-F
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 1000, 300, 0))); // W-F neighbours E-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // W-F neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 0, 500, 0))); // W-F neighbours F-D
            edge = FindEdge(edges, 300, 0, 500, 0); // F-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 1000, 500, 0))); // F-D neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 1000, 300, 0))); // F-D neighbours E-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 300, 0))); // F-D neighbours W-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 0, 700, 0))); // F-D neighbours D-B
            edge = FindEdge(edges, 500, 0, 700, 0); // D-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 1000, 700, 0))); // D-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 1000, 500, 0))); // D-B neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 0, 500, 0))); // D-B neighbours F-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 0, 1000, 0))); // D-B neighbours B-Z
            edge = FindEdge(edges, 700, 0, 1000, 0); // B-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 1000, 700, 0))); // B-Z neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 0, 700, 0))); // B-Z neighbours D-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // B-Z neighbours Z-X
            edge = FindEdge(edges, 1000, 0, 1000, 1000); // Z-X
            Assert.NotNull(edge.Neighbours);
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

            Assume.That(() => 5 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 1000)); // A-B
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0)); // X-A
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0)); // A-Y
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000)); // Y-B
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000)); // B-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 0, 0, 1000, 1000); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // A-B neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // A-B neighbours A-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // A-B neighbours Y-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // A-B neighbours B-X
            edge = FindEdge(edges, 0, 1000, 0, 0); // X-A
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 1000))); // X-A neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // X-A neighbours A-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // X-A neighbours B-X
            edge = FindEdge(edges, 0, 0, 1000, 0); // A-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 1000))); // A-Y neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // A-Y neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // A-Y neighbours Y-B
            edge = FindEdge(edges, 1000, 0, 1000, 1000); // Y-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 1000))); // Y-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // Y-B neighbours A-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // Y-B neighbours B-X
            edge = FindEdge(edges, 1000, 1000, 0, 1000); // B-X
            Assert.NotNull(edge.Neighbours);
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

            Assume.That(() => 5 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 1000, 1000, 0)); // A-B
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000)); // X-A
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0)); // A-Y
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0)); // Y-B
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000)); // B-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 0, 1000, 1000, 0); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // A-B neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // A-B neighbours A-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // A-B neighbours Y-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // A-B neighbours B-X
            edge = FindEdge(edges, 1000, 1000, 0, 1000); // X-A
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 1000, 0))); // X-A neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // X-A neighbours A-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // X-A neighbours B-X
            edge = FindEdge(edges, 0, 1000, 0, 0); // A-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 1000, 0))); // A-Y neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // A-Y neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // A-Y neighbours Y-B
            edge = FindEdge(edges, 0, 0, 1000, 0); // Y-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 1000, 0))); // Y-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // Y-B neighbours A-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // Y-B neighbours B-X
            edge = FindEdge(edges, 1000, 0, 1000, 1000); // B-X
            Assert.NotNull(edge.Neighbours);
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

            Assume.That(() => 7 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 200, 800, 1000)); // A-B
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 200)); // X-A
            Assume.That(() => HasEdge(edges, 0, 200, 0, 0)); // A-Y
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0)); // Y-W
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000)); // W-Z
            Assume.That(() => HasEdge(edges, 1000, 1000, 800, 1000)); // Z-B
            Assume.That(() => HasEdge(edges, 800, 1000, 0, 1000)); // B-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 0, 200, 800, 1000); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 200))); // A-B neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 200, 0, 0))); // A-B neighbours A-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 800, 1000))); // A-B neighbours Z-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 1000, 0, 1000))); // A-B neighbours B-X
            edge = FindEdge(edges, 0, 1000, 0, 200); // X-A
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 200, 800, 1000))); // X-A neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 200, 0, 0))); // X-A neighbours A-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 1000, 0, 1000))); // X-A neighbours B-X
            edge = FindEdge(edges, 0, 200, 0, 0); // A-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 200, 800, 1000))); // A-Y neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 200))); // A-Y neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // A-Y neighbours Y-W
            edge = FindEdge(edges, 0, 0, 1000, 0); // Y-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 200, 0, 0))); // Y-W neighbours A-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // Y-W neighbours W-Z
            edge = FindEdge(edges, 1000, 0, 1000, 1000); // W-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // W-Z neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 800, 1000))); // W-Z neighbours Z-B
            edge = FindEdge(edges, 1000, 1000, 800, 1000); // Z-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 200, 800, 1000))); // Z-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // Z-B neighbours W-Z
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 1000, 0, 1000))); // Z-B neighbours B-X
            edge = FindEdge(edges, 800, 1000, 0, 1000); // B-X
            Assert.NotNull(edge.Neighbours);
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

            Assume.That(() => 7 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 200, 1000, 1000, 200)); // A-B
            Assume.That(() => HasEdge(edges, 1000, 1000, 200, 1000)); // X-A
            Assume.That(() => HasEdge(edges, 200, 1000, 0, 1000)); // A-Y
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0)); // Y-W
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0)); // W-Z
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 200)); // Z-B
            Assume.That(() => HasEdge(edges, 1000, 200, 1000, 1000)); // B-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 200, 1000, 1000, 200); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 200, 1000))); // A-B neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 1000, 0, 1000))); // A-B neighbours A-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 200))); // A-B neighbours Z-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 200, 1000, 1000))); // A-B neighbours B-X
            edge = FindEdge(edges, 1000, 1000, 200, 1000); // X-A
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 1000, 1000, 200))); // X-A neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 1000, 0, 1000))); // X-A neighbours A-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 200, 1000, 1000))); // X-A neighbours B-X
            edge = FindEdge(edges, 200, 1000, 0, 1000); // A-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 1000, 1000, 200))); // A-Y neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 200, 1000))); // A-Y neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // A-Y neighbours Y-W
            edge = FindEdge(edges, 0, 1000, 0, 0); // Y-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 1000, 0, 1000))); // Y-W neighbours A-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // Y-W neighbours W-Z
            edge = FindEdge(edges, 0, 0, 1000, 0); // W-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // W-Z neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 200))); // W-Z neighbours Z-B
            edge = FindEdge(edges, 1000, 0, 1000, 200); // Z-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 1000, 1000, 200))); // Z-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // Z-B neighbours W-Z
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 200, 1000, 1000))); // Z-B neighbours B-X
            edge = FindEdge(edges, 1000, 200, 1000, 1000); // B-X
            Assert.NotNull(edge.Neighbours);
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
            //    0 Z---------B#--------------------------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 7 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 1000, 800, 200, 0)); // A-B
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 800)); // X-A
            Assume.That(() => HasEdge(edges, 1000, 800, 1000, 1000)); // A-Y
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000)); // Y-W
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0)); // W-Z
            Assume.That(() => HasEdge(edges, 0, 0, 200, 0)); // Z-B
            Assume.That(() => HasEdge(edges, 200, 0, 1000, 0)); // B-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 1000, 800, 200, 0); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 800))); // A-B neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 800, 1000, 1000))); // A-B neighbours A-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 200, 0))); // A-B neighbours Z-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 0, 1000, 0))); // A-B neighbours B-X
            edge = FindEdge(edges, 1000, 0, 1000, 800); // X-A
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 800, 200, 0))); // X-A neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 800, 1000, 1000))); // X-A neighbours A-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 0, 1000, 0))); // X-A neighbours B-X
            edge = FindEdge(edges, 1000, 800, 1000, 1000); // A-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 800, 200, 0))); // A-Y neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 800))); // A-Y neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // A-Y neighbours Y-W
            edge = FindEdge(edges, 1000, 1000, 0, 1000); // Y-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 800, 1000, 1000))); // Y-W neighbours A-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // Y-W neighbours W-Z
            edge = FindEdge(edges, 0, 1000, 0, 0); // W-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // W-Z neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 200, 0))); // W-Z neighbours Z-B
            edge = FindEdge(edges, 0, 0, 200, 0); // Z-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 800, 200, 0))); // Z-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // Z-B neighbours W-Z
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 0, 1000, 0))); // Z-B neighbours B-X
            edge = FindEdge(edges, 200, 0, 1000, 0); // B-X
            Assert.NotNull(edge.Neighbours);
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
            //    0 X--------------------------------------#A---------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 7 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 800, 0, 0, 800)); // A-B
            Assume.That(() => HasEdge(edges, 0, 0, 800, 0)); // X-A
            Assume.That(() => HasEdge(edges, 800, 0, 1000, 0)); // A-Y
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000)); // Y-W
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000)); // W-Z
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 800)); // Z-B
            Assume.That(() => HasEdge(edges, 0, 800, 0, 0)); // B-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 800, 0, 0, 800); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 800, 0))); // A-B neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 0, 1000, 0))); // A-B neighbours A-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 800))); // A-B neighbours Z-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 800, 0, 0))); // A-B neighbours B-X
            edge = FindEdge(edges, 0, 0, 800, 0); // X-A
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 0, 0, 800))); // X-A neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 0, 1000, 0))); // X-A neighbours A-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 800, 0, 0))); // X-A neighbours B-X
            edge = FindEdge(edges, 800, 0, 1000, 0); // A-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 0, 0, 800))); // A-Y neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 800, 0))); // A-Y neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // A-Y neighbours Y-W
            edge = FindEdge(edges, 1000, 0, 1000, 1000); // Y-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 0, 1000, 0))); // Y-W neighbours A-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // Y-W neighbours W-Z
            edge = FindEdge(edges, 1000, 1000, 0, 1000); // W-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // W-Z neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 800))); // W-Z neighbours Z-B
            edge = FindEdge(edges, 0, 1000, 0, 800); // Z-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 0, 0, 800))); // Z-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // Z-B neighbours W-Z
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 800, 0, 0))); // Z-B neighbours B-X
            edge = FindEdge(edges, 0, 800, 0, 0); // B-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 0, 0, 800))); // B-X neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 800, 0))); // B-X neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 800))); // B-X neighbours Z-B
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

            Assume.That(() => 5 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 1000, 1000, 0)); // A-B
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0)); // A-X
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0)); // X-B
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000)); // B-Y
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000)); // Y-A

            // Assert

            VoronoiEdge edge = FindEdge(edges, 0, 1000, 1000, 0); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // A-B neighbours A-X
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // A-B neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // A-B neighbours B-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // A-B neighbours Y-A
            edge = FindEdge(edges, 0, 1000, 0, 0); // A-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 1000, 0))); // A-X neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // A-X neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // A-X neighbours Y-A
            edge = FindEdge(edges, 0, 0, 1000, 0); // X-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 1000, 0))); // X-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // X-B neighbours A-X
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // X-B neighbours B-Y
            edge = FindEdge(edges, 1000, 0, 1000, 1000); // B-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 1000, 0))); // B-Y neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // B-Y neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // B-Y neighbours Y-A
            edge = FindEdge(edges, 1000, 1000, 0, 1000); // Y-A
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 1000, 0))); // Y-A neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // Y-A neighbours A-X
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // Y-A neighbours B-Y
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

            Assume.That(() => 5 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 0)); // A-B
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000)); // A-X
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0)); // X-B
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0)); // B-Y
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000)); // Y-A

            // Assert

            VoronoiEdge edge = FindEdge(edges, 1000, 1000, 0, 0); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // A-B neighbours A-X
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // A-B neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // A-B neighbours B-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // A-B neighbours Y-A
            edge = FindEdge(edges, 1000, 1000, 0, 1000); // A-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 0))); // A-X neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // A-X neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // A-X neighbours Y-A
            edge = FindEdge(edges, 0, 1000, 0, 0); // X-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 0))); // X-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // X-B neighbours A-X
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // X-B neighbours B-Y
            edge = FindEdge(edges, 0, 0, 1000, 0); // B-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 0))); // B-Y neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // B-Y neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // B-Y neighbours Y-A
            edge = FindEdge(edges, 1000, 0, 1000, 1000); // Y-A
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 0))); // Y-A neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // Y-A neighbours A-X
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // Y-A neighbours B-Y
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

            Assume.That(() => 5 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 1000, 0, 0, 1000)); // A-B
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000)); // A-X
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000)); // X-B
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0)); // B-Y
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0)); // Y-A

            // Assert

            VoronoiEdge edge = FindEdge(edges, 1000, 0, 0, 1000); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // A-B neighbours A-X
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // A-B neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // A-B neighbours B-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // A-B neighbours Y-A
            edge = FindEdge(edges, 1000, 0, 1000, 1000); // A-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 0, 1000))); // A-X neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // A-X neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // A-X neighbours Y-A
            edge = FindEdge(edges, 1000, 1000, 0, 1000); // X-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 0, 1000))); // X-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // X-B neighbours A-X
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // X-B neighbours B-Y
            edge = FindEdge(edges, 0, 1000, 0, 0); // B-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 0, 1000))); // B-Y neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // B-Y neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // B-Y neighbours Y-A
            edge = FindEdge(edges, 0, 0, 1000, 0); // Y-A
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 0, 1000))); // Y-A neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // Y-A neighbours A-X
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // Y-A neighbours B-Y
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

            Assume.That(() => 5 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 1000)); // A-B
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0)); // A-X
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000)); // X-B
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000)); // B-Y
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0)); // Y-A

            // Assert

            VoronoiEdge edge = FindEdge(edges, 0, 0, 1000, 1000); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // A-B neighbours A-X
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // A-B neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // A-B neighbours B-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // A-B neighbours Y-A
            edge = FindEdge(edges, 0, 0, 1000, 0); // A-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 1000))); // A-X neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // A-X neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // A-X neighbours Y-A
            edge = FindEdge(edges, 1000, 0, 1000, 1000); // X-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 1000))); // X-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // X-B neighbours A-X
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // X-B neighbours B-Y
            edge = FindEdge(edges, 1000, 1000, 0, 1000); // B-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 1000))); // B-Y neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // B-Y neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // B-Y neighbours Y-A
            edge = FindEdge(edges, 0, 1000, 0, 0); // Y-A
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 1000))); // Y-A neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // Y-A neighbours A-X
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // Y-A neighbours B-Y
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

            Assume.That(() => 6 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 1000, 1000, 500)); // A-B
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0)); // A-X
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0)); // X-Y
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 500)); // Y-B
            Assume.That(() => HasEdge(edges, 1000, 500, 1000, 1000)); // B-Z
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000)); // Z-A

            // Assert

            VoronoiEdge edge = FindEdge(edges, 0, 1000, 1000, 500); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // A-B neighbours A-X
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 500))); // A-B neighbours Y-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 500, 1000, 1000))); // A-B neighbours B-Z
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // A-B neighbours Z-A
            edge = FindEdge(edges, 0, 1000, 0, 0); // A-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 1000, 500))); // A-X neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // A-X neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // A-X neighbours Z-A
            edge = FindEdge(edges, 0, 0, 1000, 0); // X-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // X-Y neighbours A-X
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 500))); // X-Y neighbours Y-B
            edge = FindEdge(edges, 1000, 0, 1000, 500); // Y-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 1000, 500))); // Y-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // Y-B neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 500, 1000, 1000))); // Y-B neighbours B-Z
            edge = FindEdge(edges, 1000, 500, 1000, 1000); // B-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 1000, 500))); // B-Z neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 500))); // B-Z neighbours Y-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // B-Z neighbours Z-A
            edge = FindEdge(edges, 1000, 1000, 0, 1000); // Z-A
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 1000, 500))); // Z-A neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // Z-A neighbours A-X
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 500, 1000, 1000))); // Z-A neighbours B-Z
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

            Assume.That(() => 6 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 1000, 1000, 500, 0)); // A-B
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000)); // A-X
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0)); // X-Y
            Assume.That(() => HasEdge(edges, 0, 0, 500, 0)); // Y-B
            Assume.That(() => HasEdge(edges, 500, 0, 1000, 0)); // B-Z
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000)); // Z-A

            // Assert

            VoronoiEdge edge = FindEdge(edges, 1000, 1000, 500, 0); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // A-B neighbours A-X
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 500, 0))); // A-B neighbours Y-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 0, 1000, 0))); // A-B neighbours B-Z
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // A-B neighbours Z-A
            edge = FindEdge(edges, 1000, 1000, 0, 1000); // A-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 500, 0))); // A-X neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // A-X neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // A-X neighbours Z-A
            edge = FindEdge(edges, 0, 1000, 0, 0); // X-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // X-Y neighbours A-X
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 500, 0))); // X-Y neighbours Y-B
            edge = FindEdge(edges, 0, 0, 500, 0); // Y-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 500, 0))); // Y-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // Y-B neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 0, 1000, 0))); // Y-B neighbours B-Z
            edge = FindEdge(edges, 500, 0, 1000, 0); // B-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 500, 0))); // B-Z neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 500, 0))); // B-Z neighbours Y-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // B-Z neighbours Z-A
            edge = FindEdge(edges, 1000, 0, 1000, 1000); // Z-A
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 500, 0))); // Z-A neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // Z-A neighbours A-X
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 0, 1000, 0))); // Z-A neighbours B-Z
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

            Assume.That(() => 6 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 1000, 0, 0, 500)); // A-B
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000)); // A-X
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000)); // X-Y
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 500)); // Y-B
            Assume.That(() => HasEdge(edges, 0, 500, 0, 0)); // B-Z
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0)); // Z-A

            // Assert

            VoronoiEdge edge = FindEdge(edges, 1000, 0, 0, 500); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // A-B neighbours A-X
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 500))); // A-B neighbours Y-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 0, 0))); // A-B neighbours B-Z
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // A-B neighbours Z-A
            edge = FindEdge(edges, 1000, 0, 1000, 1000); // A-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 0, 500))); // A-X neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // A-X neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // A-X neighbours Z-A
            edge = FindEdge(edges, 1000, 1000, 0, 1000); // X-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // X-Y neighbours A-X
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 500))); // X-Y neighbours Y-B
            edge = FindEdge(edges, 0, 1000, 0, 500); // Y-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 0, 500))); // Y-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // Y-B neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 0, 0))); // Y-B neighbours B-Z
            edge = FindEdge(edges, 0, 500, 0, 0); // B-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 0, 500))); // B-Z neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 500))); // B-Z neighbours Y-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // B-Z neighbours Z-A
            edge = FindEdge(edges, 0, 0, 1000, 0); // Z-A
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 0, 500))); // Z-A neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // Z-A neighbours A-X
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 0, 0))); // Z-A neighbours B-Z
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

            Assume.That(() => 6 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 0, 500, 1000)); // A-B
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0)); // A-X
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000)); // X-Y
            Assume.That(() => HasEdge(edges, 1000, 1000, 500, 1000)); // Y-B
            Assume.That(() => HasEdge(edges, 500, 1000, 0, 1000)); // B-Z
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0)); // Z-A

            // Assert

            VoronoiEdge edge = FindEdge(edges, 0, 0, 500, 1000); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // A-B neighbours A-X
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 500, 1000))); // A-B neighbours Y-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 1000, 0, 1000))); // A-B neighbours B-Z
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // A-B neighbours Z-A
            edge = FindEdge(edges, 0, 0, 1000, 0); // A-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 500, 1000))); // A-X neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // A-X neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // A-X neighbours Z-A
            edge = FindEdge(edges, 1000, 0, 1000, 1000); // X-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // X-Y neighbours A-X
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 500, 1000))); // X-Y neighbours Y-B
            edge = FindEdge(edges, 1000, 1000, 500, 1000); // Y-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 500, 1000))); // Y-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // Y-B neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 1000, 0, 1000))); // Y-B neighbours B-Z
            edge = FindEdge(edges, 500, 1000, 0, 1000); // B-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 500, 1000))); // B-Z neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 500, 1000))); // B-Z neighbours Y-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // B-Z neighbours Z-A
            edge = FindEdge(edges, 0, 1000, 0, 0); // Z-A
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 500, 1000))); // Z-A neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // Z-A neighbours A-X
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 1000, 0, 1000))); // Z-A neighbours B-Z
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

            Assume.That(() => 6 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 500)); // A-B
            Assume.That(() => HasEdge(edges, 1000, 1000, 1000, 0)); // A-X
            Assume.That(() => HasEdge(edges, 1000, 0, 0, 0)); // X-Y
            Assume.That(() => HasEdge(edges, 0, 0, 0, 500)); // Y-B
            Assume.That(() => HasEdge(edges, 0, 500, 0, 1000)); // B-Z
            Assume.That(() => HasEdge(edges, 0, 1000, 1000, 1000)); // Z-A

            // Assert

            VoronoiEdge edge = FindEdge(edges, 1000, 1000, 0, 500); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 1000, 0))); // A-B neighbours A-X
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 0, 500))); // A-B neighbours Y-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 0, 1000))); // A-B neighbours B-Z
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 1000, 1000))); // A-B neighbours Z-A
            edge = FindEdge(edges, 1000, 1000, 1000, 0); // A-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 500))); // A-X neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 0, 0))); // A-X neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 1000, 1000))); // A-X neighbours Z-A
            edge = FindEdge(edges, 1000, 0, 0, 0); // X-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 1000, 0))); // X-Y neighbours A-X
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 0, 500))); // X-Y neighbours Y-B
            edge = FindEdge(edges, 0, 0, 0, 500); // Y-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 500))); // Y-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 0, 0))); // Y-B neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 0, 1000))); // Y-B neighbours B-Z
            edge = FindEdge(edges, 0, 500, 0, 1000); // B-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 500))); // B-Z neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 0, 500))); // B-Z neighbours Y-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 1000, 1000))); // B-Z neighbours Z-A
            edge = FindEdge(edges, 0, 1000, 1000, 1000); // Z-A
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 500))); // Z-A neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 1000, 0))); // Z-A neighbours A-X
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 0, 1000))); // Z-A neighbours B-Z
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

            Assume.That(() => 6 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 1000, 0, 500, 1000)); // A-B
            Assume.That(() => HasEdge(edges, 1000, 0, 0, 0)); // A-X
            Assume.That(() => HasEdge(edges, 0, 0, 0, 1000)); // X-Y
            Assume.That(() => HasEdge(edges, 0, 1000, 500, 1000)); // Y-B
            Assume.That(() => HasEdge(edges, 500, 1000, 1000, 1000)); // B-Z
            Assume.That(() => HasEdge(edges, 1000, 1000, 1000, 0)); // Z-A

            // Assert

            VoronoiEdge edge = FindEdge(edges, 1000, 0, 500, 1000); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 0, 0))); // A-B neighbours A-X
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 500, 1000))); // A-B neighbours Y-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 1000, 1000, 1000))); // A-B neighbours B-Z
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 1000, 0))); // A-B neighbours Z-A
            edge = FindEdge(edges, 1000, 0, 0, 0); // A-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 500, 1000))); // A-X neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 0, 1000))); // A-X neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 1000, 0))); // A-X neighbours Z-A
            edge = FindEdge(edges, 0, 0, 0, 1000); // X-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 0, 0))); // X-Y neighbours A-X
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 500, 1000))); // X-Y neighbours Y-B
            edge = FindEdge(edges, 0, 1000, 500, 1000); // Y-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 500, 1000))); // Y-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 0, 1000))); // Y-B neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 1000, 1000, 1000))); // Y-B neighbours B-Z
            edge = FindEdge(edges, 500, 1000, 1000, 1000); // B-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 500, 1000))); // B-Z neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 500, 1000))); // B-Z neighbours Y-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 1000, 0))); // B-Z neighbours Z-A
            edge = FindEdge(edges, 1000, 1000, 1000, 0); // Z-A
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 500, 1000))); // Z-A neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 0, 0))); // Z-A neighbours A-X
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 1000, 1000, 1000))); // Z-A neighbours B-Z
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

            Assume.That(() => 6 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 500)); // A-B
            Assume.That(() => HasEdge(edges, 0, 0, 0, 1000)); // A-X
            Assume.That(() => HasEdge(edges, 0, 1000, 1000, 1000)); // X-Y
            Assume.That(() => HasEdge(edges, 1000, 1000, 1000, 500)); // Y-B
            Assume.That(() => HasEdge(edges, 1000, 500, 1000, 0)); // B-Z
            Assume.That(() => HasEdge(edges, 1000, 0, 0, 0)); // Z-A

            // Assert

            VoronoiEdge edge = FindEdge(edges, 0, 0, 1000, 500); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 0, 1000))); // A-B neighbours A-X
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 1000, 500))); // A-B neighbours Y-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 500, 1000, 0))); // A-B neighbours B-Z
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 0, 0))); // A-B neighbours Z-A
            edge = FindEdge(edges, 0, 0, 0, 1000); // A-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 500))); // A-X neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 1000, 1000))); // A-X neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 0, 0))); // A-X neighbours Z-A
            edge = FindEdge(edges, 0, 1000, 1000, 1000); // X-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 0, 1000))); // X-Y neighbours A-X
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 1000, 500))); // X-Y neighbours Y-B
            edge = FindEdge(edges, 1000, 1000, 1000, 500); // Y-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 500))); // Y-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 1000, 1000))); // Y-B neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 500, 1000, 0))); // Y-B neighbours B-Z
            edge = FindEdge(edges, 1000, 500, 1000, 0); // B-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 500))); // B-Z neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 1000, 500))); // B-Z neighbours Y-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 0, 0))); // B-Z neighbours Z-A
            edge = FindEdge(edges, 1000, 0, 0, 0); // Z-A
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 500))); // Z-A neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 0, 1000))); // Z-A neighbours A-X
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 500, 1000, 0))); // Z-A neighbours B-Z
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

            Assume.That(() => 6 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 1000, 500, 0)); // A-B
            Assume.That(() => HasEdge(edges, 0, 1000, 1000, 1000)); // A-X
            Assume.That(() => HasEdge(edges, 1000, 1000, 1000, 0)); // X-Y
            Assume.That(() => HasEdge(edges, 1000, 0, 500, 0)); // Y-B
            Assume.That(() => HasEdge(edges, 500, 0, 0, 0)); // B-Z
            Assume.That(() => HasEdge(edges, 0, 0, 0, 1000)); // Z-A

            // Assert

            VoronoiEdge edge = FindEdge(edges, 0, 1000, 500, 0); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 1000, 1000))); // A-B neighbours A-X
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 500, 0))); // A-B neighbours Y-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 0, 0, 0))); // A-B neighbours B-Z
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 0, 1000))); // A-B neighbours Z-A
            edge = FindEdge(edges, 0, 1000, 1000, 1000); // A-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 500, 0))); // A-X neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 1000, 0))); // A-X neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 0, 1000))); // A-X neighbours Z-A
            edge = FindEdge(edges, 1000, 1000, 1000, 0); // X-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 1000, 1000))); // X-Y neighbours A-X
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 500, 0))); // X-Y neighbours Y-B
            edge = FindEdge(edges, 1000, 0, 500, 0); // Y-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 500, 0))); // Y-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 1000, 0))); // Y-B neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 0, 0, 0))); // Y-B neighbours B-Z
            edge = FindEdge(edges, 500, 0, 0, 0); // B-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 500, 0))); // B-Z neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 500, 0))); // B-Z neighbours Y-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 0, 1000))); // B-Z neighbours Z-A
            edge = FindEdge(edges, 0, 0, 0, 1000); // Z-A
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 500, 0))); // Z-A neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 1000, 1000))); // Z-A neighbours A-X
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 0, 0, 0))); // Z-A neighbours B-Z
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

            Assume.That(() => 10 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 300, 700, 1000)); // A-D
            Assume.That(() => HasEdge(edges, 300, 0, 1000, 700)); // B-C
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 300)); // X-A
            Assume.That(() => HasEdge(edges, 0, 300, 0, 0)); // A-Y
            Assume.That(() => HasEdge(edges, 0, 0, 300, 0)); // Y-B
            Assume.That(() => HasEdge(edges, 300, 0, 1000, 0)); // B-W
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 700)); // W-C
            Assume.That(() => HasEdge(edges, 1000, 700, 1000, 1000)); // C-Z
            Assume.That(() => HasEdge(edges, 1000, 1000, 700, 1000)); // Z-D
            Assume.That(() => HasEdge(edges, 700, 1000, 0, 1000)); // D-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 0, 300, 700, 1000); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 300))); // A-D neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 300, 0, 0))); // A-D neighbours A-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 700, 1000))); // A-D neighbours Z-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 1000, 0, 1000))); // A-D neighbours D-X
            edge = FindEdge(edges, 300, 0, 1000, 700); // B-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 300, 0))); // B-C neighbours Y-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 0, 1000, 0))); // B-C neighbours B-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 700))); // B-C neighbours W-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 700, 1000, 1000))); // B-C neighbours C-Z
            edge = FindEdge(edges, 0, 1000, 0, 300); // X-A
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 300, 700, 1000))); // X-A neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 300, 0, 0))); // X-A neighbours A-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 1000, 0, 1000))); // X-A neighbours D-X
            edge = FindEdge(edges, 0, 300, 0, 0); // A-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 300, 700, 1000))); // A-Y neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 300))); // A-Y neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 300, 0))); // A-Y neighbours Y-B
            edge = FindEdge(edges, 0, 0, 300, 0); // Y-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 0, 1000, 700))); // Y-B neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 300, 0, 0))); // Y-B neighbours A-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 0, 1000, 0))); // Y-B neighbours B-W
            edge = FindEdge(edges, 300, 0, 1000, 0); // B-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 0, 1000, 700))); // B-W neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 300, 0))); // B-W neighbours Y-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 700))); // B-W neighbours W-C
            edge = FindEdge(edges, 1000, 0, 1000, 700); // W-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 0, 1000, 700))); // W-C neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 0, 1000, 0))); // W-C neighbours B-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 700, 1000, 1000))); // W-C neighbours C-Z
            edge = FindEdge(edges, 1000, 700, 1000, 1000); // C-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 0, 1000, 700))); // C-Z neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 700))); // C-Z neighbours W-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 700, 1000))); // C-Z neighbours Z-D
            edge = FindEdge(edges, 1000, 1000, 700, 1000); // Z-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 300, 700, 1000))); // Z-D neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 700, 1000, 1000))); // Z-D neighbours C-Z
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 1000, 0, 1000))); // Z-D neighbours D-X
            edge = FindEdge(edges, 700, 1000, 0, 1000); // D-X
            Assert.NotNull(edge.Neighbours);
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

            Assume.That(() => 10 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 300, 1000, 1000, 300)); // A-D
            Assume.That(() => HasEdge(edges, 0, 700, 700, 0)); // B-C
            Assume.That(() => HasEdge(edges, 1000, 1000, 300, 1000)); // X-A
            Assume.That(() => HasEdge(edges, 300, 1000, 0, 1000)); // A-Y
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 700)); // Y-B
            Assume.That(() => HasEdge(edges, 0, 700, 0, 0)); // B-W
            Assume.That(() => HasEdge(edges, 0, 0, 700, 0)); // W-C
            Assume.That(() => HasEdge(edges, 700, 0, 1000, 0)); // C-Z
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 300)); // Z-D
            Assume.That(() => HasEdge(edges, 1000, 300, 1000, 1000)); // D-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 300, 1000, 1000, 300); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 300, 1000))); // A-D neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 1000, 0, 1000))); // A-D neighbours A-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 300))); // A-D neighbours Z-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 300, 1000, 1000))); // A-D neighbours D-X
            edge = FindEdge(edges, 0, 700, 700, 0); // B-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 700))); // B-C neighbours Y-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 0, 0))); // B-C neighbours B-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 700, 0))); // B-C neighbours W-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 0, 1000, 0))); // B-C neighbours C-Z
            edge = FindEdge(edges, 1000, 1000, 300, 1000); // X-A
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 1000, 1000, 300))); // X-A neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 1000, 0, 1000))); // X-A neighbours A-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 300, 1000, 1000))); // X-A neighbours D-X
            edge = FindEdge(edges, 300, 1000, 0, 1000); // A-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 1000, 1000, 300))); // A-Y neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 300, 1000))); // A-Y neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 700))); // A-Y neighbours Y-B
            edge = FindEdge(edges, 0, 1000, 0, 700); // Y-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 700, 0))); // Y-B neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 1000, 0, 1000))); // Y-B neighbours A-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 0, 0))); // Y-B neighbours B-W
            edge = FindEdge(edges, 0, 700, 0, 0); // B-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 700, 0))); // B-W neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 700))); // B-W neighbours Y-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 700, 0))); // B-W neighbours W-C
            edge = FindEdge(edges, 0, 0, 700, 0); // W-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 700, 0))); // W-C neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 0, 0))); // W-C neighbours B-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 0, 1000, 0))); // W-C neighbours C-Z
            edge = FindEdge(edges, 700, 0, 1000, 0); // C-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 700, 0))); // C-Z neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 700, 0))); // C-Z neighbours W-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 300))); // C-Z neighbours Z-D
            edge = FindEdge(edges, 1000, 0, 1000, 300); // Z-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 1000, 1000, 300))); // Z-D neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 0, 1000, 0))); // Z-D neighbours C-Z
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 300, 1000, 1000))); // Z-D neighbours D-X
            edge = FindEdge(edges, 1000, 300, 1000, 1000); // D-X
            Assert.NotNull(edge.Neighbours);
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

            Assume.That(() => 8 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 400, 600, 1000)); // A-D
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 1000)); // B-C
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 400)); // X-A
            Assume.That(() => HasEdge(edges, 0, 400, 0, 0)); // A-B
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0)); // B-Y
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000)); // Y-C
            Assume.That(() => HasEdge(edges, 1000, 1000, 600, 1000)); // C-D
            Assume.That(() => HasEdge(edges, 600, 1000, 0, 1000)); // D-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 0, 400, 600, 1000); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 400))); // A-D neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 400, 0, 0))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 600, 1000))); // A-D neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 1000, 0, 1000))); // A-D neighbours D-X
            edge = FindEdge(edges, 0, 0, 1000, 1000); // B-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 400, 0, 0))); // B-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // B-C neighbours B-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // B-C neighbours Y-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 600, 1000))); // B-C neighbours C-D
            edge = FindEdge(edges, 0, 1000, 0, 400); // X-A
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 400, 600, 1000))); // X-A neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 400, 0, 0))); // X-A neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 1000, 0, 1000))); // X-A neighbours D-X
            edge = FindEdge(edges, 0, 400, 0, 0); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 400, 600, 1000))); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 1000))); // A-B neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 400))); // A-B neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // A-B neighbours B-Y
            edge = FindEdge(edges, 0, 0, 1000, 0); // B-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 1000))); // B-Y neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 400, 0, 0))); // B-Y neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // B-Y neighbours Y-C
            edge = FindEdge(edges, 1000, 0, 1000, 1000); // Y-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 1000))); // Y-C neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // Y-C neighbours B-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 600, 1000))); // Y-C neighbours C-D
            edge = FindEdge(edges, 1000, 1000, 600, 1000); // C-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 400, 600, 1000))); // C-D neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 1000))); // C-D neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // C-D neighbours Y-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 1000, 0, 1000))); // C-D neighbours D-X
            edge = FindEdge(edges, 600, 1000, 0, 1000); // D-X
            Assert.NotNull(edge.Neighbours);
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

            Assume.That(() => 8 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 400, 1000, 1000, 400)); // A-D
            Assume.That(() => HasEdge(edges, 0, 1000, 1000, 0)); // B-C
            Assume.That(() => HasEdge(edges, 1000, 1000, 400, 1000)); // X-A
            Assume.That(() => HasEdge(edges, 400, 1000, 0, 1000)); // A-B
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0)); // B-Y
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0)); // Y-C
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 400)); // C-D
            Assume.That(() => HasEdge(edges, 1000, 400, 1000, 1000)); // D-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 400, 1000, 1000, 400); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 400, 1000))); // A-D neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 1000, 0, 1000))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 400))); // A-D neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 400, 1000, 1000))); // A-D neighbours D-X
            edge = FindEdge(edges, 0, 1000, 1000, 0); // B-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 1000, 0, 1000))); // B-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // B-C neighbours B-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // B-C neighbours Y-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 400))); // B-C neighbours C-D
            edge = FindEdge(edges, 1000, 1000, 400, 1000); // X-A
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 1000, 1000, 400))); // X-A neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 1000, 0, 1000))); // X-A neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 400, 1000, 1000))); // X-A neighbours D-X
            edge = FindEdge(edges, 400, 1000, 0, 1000); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 1000, 1000, 400))); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 1000, 0))); // A-B neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 400, 1000))); // A-B neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // A-B neighbours B-Y
            edge = FindEdge(edges, 0, 1000, 0, 0); // B-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 1000, 0))); // B-Y neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 1000, 0, 1000))); // B-Y neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // B-Y neighbours Y-C
            edge = FindEdge(edges, 0, 0, 1000, 0); // Y-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 1000, 0))); // Y-C neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // Y-C neighbours B-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 400))); // Y-C neighbours C-D
            edge = FindEdge(edges, 1000, 0, 1000, 400); // C-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 1000, 1000, 400))); // C-D neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 1000, 0))); // C-D neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // C-D neighbours Y-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 400, 1000, 1000))); // C-D neighbours D-X
            edge = FindEdge(edges, 1000, 400, 1000, 1000); // D-X
            Assert.NotNull(edge.Neighbours);
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

            Assume.That(() => 8 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 1000, 600, 400, 0)); // A-D
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 0)); // B-C
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 600)); // X-A
            Assume.That(() => HasEdge(edges, 1000, 600, 1000, 1000)); // A-B
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000)); // B-Y
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0)); // Y-C
            Assume.That(() => HasEdge(edges, 0, 0, 400, 0)); // C-D
            Assume.That(() => HasEdge(edges, 400, 0, 1000, 0)); // D-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 1000, 600, 400, 0); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 600))); // A-D neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 600, 1000, 1000))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 400, 0))); // A-D neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 0, 1000, 0))); // A-D neighbours D-X
            edge = FindEdge(edges, 1000, 1000, 0, 0); // B-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 600, 1000, 1000))); // B-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // B-C neighbours B-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // B-C neighbours Y-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 400, 0))); // B-C neighbours C-D
            edge = FindEdge(edges, 1000, 0, 1000, 600); // X-A
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 600, 400, 0))); // X-A neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 600, 1000, 1000))); // X-A neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 0, 1000, 0))); // X-A neighbours D-X
            edge = FindEdge(edges, 1000, 600, 1000, 1000); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 600, 400, 0))); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 0))); // A-B neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 600))); // A-B neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // A-B neighbours B-Y
            edge = FindEdge(edges, 1000, 1000, 0, 1000); // B-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 0))); // B-Y neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 600, 1000, 1000))); // B-Y neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // B-Y neighbours Y-C
            edge = FindEdge(edges, 0, 1000, 0, 0); // Y-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 0))); // Y-C neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // Y-C neighbours B-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 400, 0))); // Y-C neighbours C-D
            edge = FindEdge(edges, 0, 0, 400, 0); // C-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 600, 400, 0))); // C-D neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 0))); // C-D neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // C-D neighbours Y-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 0, 1000, 0))); // C-D neighbours D-X
            edge = FindEdge(edges, 400, 0, 1000, 0); // D-X
            Assert.NotNull(edge.Neighbours);
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

            Assume.That(() => 8 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 600, 0, 0, 600)); // A-D
            Assume.That(() => HasEdge(edges, 1000, 0, 0, 1000)); // B-C
            Assume.That(() => HasEdge(edges, 0, 0, 600, 0)); // X-A
            Assume.That(() => HasEdge(edges, 600, 0, 1000, 0)); // A-B
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000)); // B-Y
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000)); // Y-C
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 600)); // C-D
            Assume.That(() => HasEdge(edges, 0, 600, 0, 0)); // D-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 600, 0, 0, 600); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 600, 0))); // A-D neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 0, 1000, 0))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 600))); // A-D neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 600, 0, 0))); // A-D neighbours D-X
            edge = FindEdge(edges, 1000, 0, 0, 1000); // B-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 0, 1000, 0))); // B-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // B-C neighbours B-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // B-C neighbours Y-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 600))); // B-C neighbours C-D
            edge = FindEdge(edges, 0, 0, 600, 0); // X-A
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 0, 0, 600))); // X-A neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 0, 1000, 0))); // X-A neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 600, 0, 0))); // X-A neighbours D-X
            edge = FindEdge(edges, 600, 0, 1000, 0); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 0, 0, 600))); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 0, 1000))); // A-B neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 600, 0))); // A-B neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // A-B neighbours B-Y
            edge = FindEdge(edges, 1000, 0, 1000, 1000); // B-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 0, 1000))); // B-Y neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 0, 1000, 0))); // B-Y neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // B-Y neighbours Y-C
            edge = FindEdge(edges, 1000, 1000, 0, 1000); // Y-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 0, 1000))); // Y-C neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // Y-C neighbours B-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 600))); // Y-C neighbours C-D
            edge = FindEdge(edges, 0, 1000, 0, 600); // C-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 0, 0, 600))); // C-D neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 0, 1000))); // C-D neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // C-D neighbours Y-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 600, 0, 0))); // C-D neighbours D-X
            edge = FindEdge(edges, 0, 600, 0, 0); // D-X
            Assert.NotNull(edge.Neighbours);
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

            Assume.That(() => 11 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 400, 600, 1000)); // A-F
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 1000)); // B-E
            Assume.That(() => HasEdge(edges, 400, 0, 1000, 600)); // C-D
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 400)); // X-A
            Assume.That(() => HasEdge(edges, 0, 400, 0, 0)); // A-B
            Assume.That(() => HasEdge(edges, 0, 0, 400, 0)); // B-C
            Assume.That(() => HasEdge(edges, 400, 0, 1000, 0)); // C-Y
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 600)); // Y-D
            Assume.That(() => HasEdge(edges, 1000, 600, 1000, 1000)); // D-E
            Assume.That(() => HasEdge(edges, 1000, 1000, 600, 1000)); // E-F
            Assume.That(() => HasEdge(edges, 600, 1000, 0, 1000)); // F-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 0, 400, 600, 1000); // A-F
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 400))); // A-F neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 400, 0, 0))); // A-F neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 600, 1000))); // A-F neighbours E-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 1000, 0, 1000))); // A-F neighbours F-X
            edge = FindEdge(edges, 0, 0, 1000, 1000); // B-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 400, 0, 0))); // B-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 400, 0))); // B-E neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 600, 1000, 1000))); // B-E neighbours D-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 600, 1000))); // B-E neighbours E-F
            edge = FindEdge(edges, 400, 0, 1000, 600); // C-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 400, 0))); // C-D neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 0, 1000, 0))); // C-D neighbours C-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 600))); // C-D neighbours Y-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 600, 1000, 1000))); // C-D neighbours D-E
            edge = FindEdge(edges, 0, 1000, 0, 400); // X-A
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 400, 600, 1000))); // X-A neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 400, 0, 0))); // X-A neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 1000, 0, 1000))); // X-A neighbours F-X
            edge = FindEdge(edges, 0, 400, 0, 0); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 400, 600, 1000))); // A-B neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 1000))); // A-B neighbours B-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 400))); // A-B neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 400, 0))); // A-B neighbours B-C
            edge = FindEdge(edges, 0, 0, 400, 0); // B-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 1000))); // B-C neighbours B-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 0, 1000, 600))); // B-C neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 400, 0, 0))); // B-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 0, 1000, 0))); // B-C neighbours C-Y
            edge = FindEdge(edges, 400, 0, 1000, 0); // C-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 0, 1000, 600))); // C-Y neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 400, 0))); // C-Y neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 600))); // C-Y neighbours Y-D
            edge = FindEdge(edges, 1000, 0, 1000, 600); // Y-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 0, 1000, 600))); // Y-D neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 0, 1000, 0))); // Y-D neighbours C-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 600, 1000, 1000))); // Y-D neighbours D-E
            edge = FindEdge(edges, 1000, 600, 1000, 1000); // D-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 1000))); // D-E neighbours B-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 0, 1000, 600))); // D-E neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 600))); // D-E neighbours Y-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 600, 1000))); // D-E neighbours E-F
            edge = FindEdge(edges, 1000, 1000, 600, 1000); // E-F
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 400, 600, 1000))); // E-F neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 1000))); // E-F neighbours B-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 600, 1000, 1000))); // E-F neighbours D-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 1000, 0, 1000))); // E-F neighbours F-X
            edge = FindEdge(edges, 600, 1000, 0, 1000); // F-X
            Assert.NotNull(edge.Neighbours);
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

            Assume.That(() => 11 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 400, 1000, 1000, 400)); // A-F
            Assume.That(() => HasEdge(edges, 0, 1000, 1000, 0)); // B-E
            Assume.That(() => HasEdge(edges, 0, 600, 600, 0)); // C-D
            Assume.That(() => HasEdge(edges, 1000, 1000, 400, 1000)); // X-A
            Assume.That(() => HasEdge(edges, 400, 1000, 0, 1000)); // A-B
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 600)); // B-C
            Assume.That(() => HasEdge(edges, 0, 600, 0, 0)); // C-Y
            Assume.That(() => HasEdge(edges, 0, 0, 600, 0)); // Y-D
            Assume.That(() => HasEdge(edges, 600, 0, 1000, 0)); // D-E
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 400)); // E-F
            Assume.That(() => HasEdge(edges, 1000, 400, 1000, 1000)); // F-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 400, 1000, 1000, 400); // A-F
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 400, 1000))); // A-F neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 1000, 0, 1000))); // A-F neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 400))); // A-F neighbours E-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 400, 1000, 1000))); // A-F neighbours F-X
            edge = FindEdge(edges, 0, 1000, 1000, 0); // B-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 1000, 0, 1000))); // B-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 600))); // B-E neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 0, 1000, 0))); // B-E neighbours D-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 400))); // B-E neighbours E-F
            edge = FindEdge(edges, 0, 600, 600, 0); // C-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 600))); // C-D neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 600, 0, 0))); // C-D neighbours C-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 600, 0))); // C-D neighbours Y-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 0, 1000, 0))); // C-D neighbours D-E
            edge = FindEdge(edges, 1000, 1000, 400, 1000); // X-A
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 1000, 1000, 400))); // X-A neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 1000, 0, 1000))); // X-A neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 400, 1000, 1000))); // X-A neighbours F-X
            edge = FindEdge(edges, 400, 1000, 0, 1000); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 1000, 1000, 400))); // A-B neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 1000, 0))); // A-B neighbours B-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 400, 1000))); // A-B neighbours X-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 600))); // A-B neighbours B-C
            edge = FindEdge(edges, 0, 1000, 0, 600); // B-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 1000, 0))); // B-C neighbours B-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 600, 600, 0))); // B-C neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 1000, 0, 1000))); // B-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 600, 0, 0))); // B-C neighbours C-Y
            edge = FindEdge(edges, 0, 600, 0, 0); // C-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 600, 600, 0))); // C-Y neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 600))); // C-Y neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 600, 0))); // C-Y neighbours Y-D
            edge = FindEdge(edges, 0, 0, 600, 0); // Y-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 600, 600, 0))); // Y-D neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 600, 0, 0))); // Y-D neighbours C-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 0, 1000, 0))); // Y-D neighbours D-E
            edge = FindEdge(edges, 600, 0, 1000, 0); // D-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 1000, 0))); // D-E neighbours B-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 600, 600, 0))); // D-E neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 600, 0))); // D-E neighbours Y-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 400))); // D-E neighbours E-F
            edge = FindEdge(edges, 1000, 0, 1000, 400); // E-F
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 1000, 1000, 400))); // E-F neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 1000, 0))); // E-F neighbours B-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 0, 1000, 0))); // E-F neighbours D-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 400, 1000, 1000))); // E-F neighbours F-X
            edge = FindEdge(edges, 1000, 400, 1000, 1000); // F-X
            Assert.NotNull(edge.Neighbours);
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

            Assume.That(() => 9 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 400, 400, 0, 400)); // A-B
            Assume.That(() => HasEdge(edges, 400, 400, 400, 0)); // A-C
            Assume.That(() => HasEdge(edges, 400, 400, 1000, 1000)); // A-D
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 400)); // X-B
            Assume.That(() => HasEdge(edges, 0, 400, 0, 0)); // B-Y
            Assume.That(() => HasEdge(edges, 0, 0, 400, 0)); // Y-C
            Assume.That(() => HasEdge(edges, 400, 0, 1000, 0)); // C-W
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000)); // W-D
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000)); // D-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 400, 400, 0, 400); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 400, 0))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 1000, 1000))); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 400))); // A-B neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 400, 0, 0))); // A-B neighbours B-Y
            edge = FindEdge(edges, 400, 400, 400, 0); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 0, 400))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 1000, 1000))); // A-C neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 400, 0))); // A-C neighbours Y-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 0, 1000, 0))); // A-C neighbours C-W
            edge = FindEdge(edges, 400, 400, 1000, 1000); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 0, 400))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 400, 0))); // A-D neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // A-D neighbours W-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // A-D neighbours D-X
            edge = FindEdge(edges, 0, 1000, 0, 400); // X-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 0, 400))); // X-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 400, 0, 0))); // X-B neighbours B-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // X-B neighbours D-X
            edge = FindEdge(edges, 0, 400, 0, 0); // B-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 0, 400))); // B-Y neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 400))); // B-Y neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 400, 0))); // B-Y neighbours Y-C
            edge = FindEdge(edges, 0, 0, 400, 0); // Y-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 400, 0))); // Y-C neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 400, 0, 0))); // Y-C neighbours B-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 0, 1000, 0))); // Y-C neighbours C-W
            edge = FindEdge(edges, 400, 0, 1000, 0); // C-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 400, 0))); // C-W neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 400, 0))); // C-W neighbours Y-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // C-W neighbours W-D
            edge = FindEdge(edges, 1000, 0, 1000, 1000); // W-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 1000, 1000))); // W-D neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 0, 1000, 0))); // W-D neighbours C-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // W-D neighbours D-X
            edge = FindEdge(edges, 1000, 1000, 0, 1000); // D-X
            Assert.NotNull(edge.Neighbours);
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
            //    0 W------------------------------------------------#D
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 9 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 400, 600, 400, 1000)); // A-B
            Assume.That(() => HasEdge(edges, 400, 600, 0, 600)); // A-C
            Assume.That(() => HasEdge(edges, 400, 600, 1000, 0)); // A-D
            Assume.That(() => HasEdge(edges, 1000, 1000, 400, 1000)); // X-B
            Assume.That(() => HasEdge(edges, 400, 1000, 0, 1000)); // B-Y
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 600)); // Y-C
            Assume.That(() => HasEdge(edges, 0, 600, 0, 0)); // C-W
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0)); // W-D
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000)); // D-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 400, 600, 400, 1000); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 0, 600))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 1000, 0))); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 400, 1000))); // A-B neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 1000, 0, 1000))); // A-B neighbours B-Y
            edge = FindEdge(edges, 400, 600, 0, 600); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 400, 1000))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 1000, 0))); // A-C neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 600))); // A-C neighbours Y-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 600, 0, 0))); // A-C neighbours C-W
            edge = FindEdge(edges, 400, 600, 1000, 0); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 400, 1000))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 0, 600))); // A-D neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // A-D neighbours W-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // A-D neighbours D-X
            edge = FindEdge(edges, 1000, 1000, 400, 1000); // X-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 400, 1000))); // X-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 1000, 0, 1000))); // X-B neighbours B-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // X-B neighbours D-X
            edge = FindEdge(edges, 400, 1000, 0, 1000); // B-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 400, 1000))); // B-Y neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 400, 1000))); // B-Y neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 600))); // B-Y neighbours Y-C
            edge = FindEdge(edges, 0, 1000, 0, 600); // Y-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 0, 600))); // Y-C neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 1000, 0, 1000))); // Y-C neighbours B-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 600, 0, 0))); // Y-C neighbours C-W
            edge = FindEdge(edges, 0, 600, 0, 0); // C-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 0, 600))); // C-W neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 600))); // C-W neighbours Y-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // C-W neighbours W-D
            edge = FindEdge(edges, 0, 0, 1000, 0); // W-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 1000, 0))); // W-D neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 600, 0, 0))); // W-D neighbours C-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // W-D neighbours D-X
            edge = FindEdge(edges, 1000, 0, 1000, 1000); // D-X
            Assert.NotNull(edge.Neighbours);
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
            //    0 D#------------------------------------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 9 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 600, 600, 1000, 600)); // A-B
            Assume.That(() => HasEdge(edges, 600, 600, 600, 1000)); // A-C
            Assume.That(() => HasEdge(edges, 600, 600, 0, 0)); // A-D
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 600)); // X-B
            Assume.That(() => HasEdge(edges, 1000, 600, 1000, 1000)); // B-Y
            Assume.That(() => HasEdge(edges, 1000, 1000, 600, 1000)); // Y-C
            Assume.That(() => HasEdge(edges, 600, 1000, 0, 1000)); // C-W
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0)); // W-D
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0)); // D-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 600, 600, 1000, 600); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 600, 1000))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 0, 0))); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 600))); // A-B neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 600, 1000, 1000))); // A-B neighbours B-Y
            edge = FindEdge(edges, 600, 600, 600, 1000); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 1000, 600))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 0, 0))); // A-C neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 600, 1000))); // A-C neighbours Y-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 1000, 0, 1000))); // A-C neighbours C-W
            edge = FindEdge(edges, 600, 600, 0, 0); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 1000, 600))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 600, 1000))); // A-D neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // A-D neighbours W-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // A-D neighbours D-X
            edge = FindEdge(edges, 1000, 0, 1000, 600); // X-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 1000, 600))); // X-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 600, 1000, 1000))); // X-B neighbours B-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // X-B neighbours D-X
            edge = FindEdge(edges, 1000, 600, 1000, 1000); // B-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 1000, 600))); // B-Y neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 600))); // B-Y neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 600, 1000))); // B-Y neighbours Y-C
            edge = FindEdge(edges, 1000, 1000, 600, 1000); // Y-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 600, 1000))); // Y-C neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 600, 1000, 1000))); // Y-C neighbours B-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 1000, 0, 1000))); // Y-C neighbours C-W
            edge = FindEdge(edges, 600, 1000, 0, 1000); // C-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 600, 1000))); // C-W neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 600, 1000))); // C-W neighbours Y-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // C-W neighbours W-D
            edge = FindEdge(edges, 0, 1000, 0, 0); // W-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 0, 0))); // W-D neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 1000, 0, 1000))); // W-D neighbours C-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // W-D neighbours D-X
            edge = FindEdge(edges, 0, 0, 1000, 0); // D-X
            Assert.NotNull(edge.Neighbours);
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

            Assume.That(() => 9 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 600, 400, 600, 0)); // A-B
            Assume.That(() => HasEdge(edges, 600, 400, 1000, 400)); // A-C
            Assume.That(() => HasEdge(edges, 600, 400, 0, 1000)); // A-D
            Assume.That(() => HasEdge(edges, 0, 0, 600, 0)); // X-B
            Assume.That(() => HasEdge(edges, 600, 0, 1000, 0)); // B-Y
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 400)); // Y-C
            Assume.That(() => HasEdge(edges, 1000, 400, 1000, 1000)); // C-W
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000)); // W-D
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0)); // D-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 600, 400, 600, 0); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 1000, 400))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 0, 1000))); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 600, 0))); // A-B neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 0, 1000, 0))); // A-B neighbours B-Y
            edge = FindEdge(edges, 600, 400, 1000, 400); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 600, 0))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 0, 1000))); // A-C neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 400))); // A-C neighbours Y-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 400, 1000, 1000))); // A-C neighbours C-W
            edge = FindEdge(edges, 600, 400, 0, 1000); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 600, 0))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 1000, 400))); // A-D neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // A-D neighbours W-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // A-D neighbours D-X
            edge = FindEdge(edges, 0, 0, 600, 0); // X-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 600, 0))); // X-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 0, 1000, 0))); // X-B neighbours B-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // X-B neighbours D-X
            edge = FindEdge(edges, 600, 0, 1000, 0); // B-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 600, 0))); // B-Y neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 600, 0))); // B-Y neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 400))); // B-Y neighbours Y-C
            edge = FindEdge(edges, 1000, 0, 1000, 400); // Y-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 1000, 400))); // Y-C neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 0, 1000, 0))); // Y-C neighbours B-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 400, 1000, 1000))); // Y-C neighbours C-W
            edge = FindEdge(edges, 1000, 400, 1000, 1000); // C-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 1000, 400))); // C-W neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 400))); // C-W neighbours Y-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // C-W neighbours W-D
            edge = FindEdge(edges, 1000, 1000, 0, 1000); // W-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 0, 1000))); // W-D neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 400, 1000, 1000))); // W-D neighbours C-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // W-D neighbours D-X
            edge = FindEdge(edges, 0, 1000, 0, 0); // D-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 0, 1000))); // D-X neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 600, 0))); // D-X neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // D-X neighbours W-D
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

            Assume.That(() => 10 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 300, 600, 0, 600)); // A-B
            Assume.That(() => HasEdge(edges, 300, 600, 300, 0)); // A-C
            Assume.That(() => HasEdge(edges, 300, 600, 700, 1000)); // A-D
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 600)); // X-B
            Assume.That(() => HasEdge(edges, 0, 600, 0, 0)); // B-Y
            Assume.That(() => HasEdge(edges, 0, 0, 300, 0)); // Y-C
            Assume.That(() => HasEdge(edges, 300, 0, 1000, 0)); // C-W
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000)); // W-Z
            Assume.That(() => HasEdge(edges, 1000, 1000, 700, 1000)); // Z-D
            Assume.That(() => HasEdge(edges, 700, 1000, 0, 1000)); // D-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 300, 600, 0, 600); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 600, 300, 0))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 600, 700, 1000))); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 600))); // A-B neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 600, 0, 0))); // A-B neighbours B-Y
            edge = FindEdge(edges, 300, 600, 300, 0); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 600, 0, 600))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 600, 700, 1000))); // A-C neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 300, 0))); // A-C neighbours Y-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 0, 1000, 0))); // A-C neighbours C-W
            edge = FindEdge(edges, 300, 600, 700, 1000); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 600, 0, 600))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 600, 300, 0))); // A-D neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 700, 1000))); // A-D neighbours Z-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 1000, 0, 1000))); // A-D neighbours D-X
            edge = FindEdge(edges, 0, 1000, 0, 600); // X-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 600, 0, 600))); // X-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 600, 0, 0))); // X-B neighbours B-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 1000, 0, 1000))); // X-B neighbours D-X
            edge = FindEdge(edges, 0, 600, 0, 0); // B-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 600, 0, 600))); // B-Y neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 600))); // B-Y neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 300, 0))); // B-Y neighbours Y-C
            edge = FindEdge(edges, 0, 0, 300, 0); // Y-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 600, 300, 0))); // Y-C neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 600, 0, 0))); // Y-C neighbours B-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 0, 1000, 0))); // Y-C neighbours C-W
            edge = FindEdge(edges, 300, 0, 1000, 0); // C-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 600, 300, 0))); // C-W neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 300, 0))); // C-W neighbours Y-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // C-W neighbours W-Z
            edge = FindEdge(edges, 1000, 0, 1000, 1000); // W-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 0, 1000, 0))); // W-Z neighbours C-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 700, 1000))); // W-Z neighbours Z-D
            edge = FindEdge(edges, 1000, 1000, 700, 1000); // Z-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 600, 700, 1000))); // Z-D neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // Z-D neighbours W-Z
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 1000, 0, 1000))); // Z-D neighbours D-X
            edge = FindEdge(edges, 700, 1000, 0, 1000); // D-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 600, 700, 1000))); // D-X neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 600))); // D-X neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 700, 1000))); // D-X neighbours Z-D
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

            Assume.That(() => 10 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 600, 700, 600, 1000)); // A-B
            Assume.That(() => HasEdge(edges, 600, 700, 0, 700)); // A-C
            Assume.That(() => HasEdge(edges, 600, 700, 1000, 300)); // A-D
            Assume.That(() => HasEdge(edges, 1000, 1000, 600, 1000)); // X-B
            Assume.That(() => HasEdge(edges, 600, 1000, 0, 1000)); // B-Y
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 700)); // Y-C
            Assume.That(() => HasEdge(edges, 0, 700, 0, 0)); // C-W
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0)); // W-Z
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 300)); // Z-D
            Assume.That(() => HasEdge(edges, 1000, 300, 1000, 1000)); // D-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 600, 700, 600, 1000); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 700, 0, 700))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 700, 1000, 300))); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 600, 1000))); // A-B neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 1000, 0, 1000))); // A-B neighbours B-Y
            edge = FindEdge(edges, 600, 700, 0, 700); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 700, 600, 1000))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 700, 1000, 300))); // A-C neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 700))); // A-C neighbours Y-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 0, 0))); // A-C neighbours C-W
            edge = FindEdge(edges, 600, 700, 1000, 300); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 700, 600, 1000))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 700, 0, 700))); // A-D neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 300))); // A-D neighbours Z-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 300, 1000, 1000))); // A-D neighbours D-X
            edge = FindEdge(edges, 1000, 1000, 600, 1000); // X-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 700, 600, 1000))); // X-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 1000, 0, 1000))); // X-B neighbours B-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 300, 1000, 1000))); // X-B neighbours D-X
            edge = FindEdge(edges, 600, 1000, 0, 1000); // B-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 700, 600, 1000))); // B-Y neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 600, 1000))); // B-Y neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 700))); // B-Y neighbours Y-C
            edge = FindEdge(edges, 0, 1000, 0, 700); // Y-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 700, 0, 700))); // Y-C neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 1000, 0, 1000))); // Y-C neighbours B-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 0, 0))); // Y-C neighbours C-W
            edge = FindEdge(edges, 0, 700, 0, 0); // C-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 700, 0, 700))); // C-W neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 700))); // C-W neighbours Y-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // C-W neighbours W-Z
            edge = FindEdge(edges, 0, 0, 1000, 0); // W-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 0, 0))); // W-Z neighbours C-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 300))); // W-Z neighbours Z-D
            edge = FindEdge(edges, 1000, 0, 1000, 300); // Z-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 700, 1000, 300))); // Z-D neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // Z-D neighbours W-Z
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 300, 1000, 1000))); // Z-D neighbours D-X
            edge = FindEdge(edges, 1000, 300, 1000, 1000); // D-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 700, 1000, 300))); // D-X neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 600, 1000))); // D-X neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 300))); // D-X neighbours Z-D
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

            Assume.That(() => 10 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 700, 400, 1000, 400)); // A-B
            Assume.That(() => HasEdge(edges, 700, 400, 700, 1000)); // A-C
            Assume.That(() => HasEdge(edges, 700, 400, 300, 0)); // A-D
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 400)); // X-B
            Assume.That(() => HasEdge(edges, 1000, 400, 1000, 1000)); // B-Y
            Assume.That(() => HasEdge(edges, 1000, 1000, 700, 1000)); // Y-C
            Assume.That(() => HasEdge(edges, 700, 1000, 0, 1000)); // C-W
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0)); // W-Z
            Assume.That(() => HasEdge(edges, 0, 0, 300, 0)); // Z-D
            Assume.That(() => HasEdge(edges, 300, 0, 1000, 0)); // D-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 700, 400, 1000, 400); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 400, 700, 1000))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 400, 300, 0))); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 400))); // A-B neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 400, 1000, 1000))); // A-B neighbours B-Y
            edge = FindEdge(edges, 700, 400, 700, 1000); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 400, 1000, 400))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 400, 300, 0))); // A-C neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 700, 1000))); // A-C neighbours Y-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 1000, 0, 1000))); // A-C neighbours C-W
            edge = FindEdge(edges, 700, 400, 300, 0); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 400, 1000, 400))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 400, 700, 1000))); // A-D neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 300, 0))); // A-D neighbours Z-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 0, 1000, 0))); // A-D neighbours D-X
            edge = FindEdge(edges, 1000, 0, 1000, 400); // X-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 400, 1000, 400))); // X-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 400, 1000, 1000))); // X-B neighbours B-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 0, 1000, 0))); // X-B neighbours D-X
            edge = FindEdge(edges, 1000, 400, 1000, 1000); // B-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 400, 1000, 400))); // B-Y neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 400))); // B-Y neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 700, 1000))); // B-Y neighbours Y-C
            edge = FindEdge(edges, 1000, 1000, 700, 1000); // Y-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 400, 700, 1000))); // Y-C neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 400, 1000, 1000))); // Y-C neighbours B-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 1000, 0, 1000))); // Y-C neighbours C-W
            edge = FindEdge(edges, 700, 1000, 0, 1000); // C-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 400, 700, 1000))); // C-W neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 700, 1000))); // C-W neighbours Y-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // C-W neighbours W-Z
            edge = FindEdge(edges, 0, 1000, 0, 0); // W-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 1000, 0, 1000))); // W-Z neighbours C-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 300, 0))); // W-Z neighbours Z-D
            edge = FindEdge(edges, 0, 0, 300, 0); // Z-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 400, 300, 0))); // Z-D neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // Z-D neighbours W-Z
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 0, 1000, 0))); // Z-D neighbours D-X
            edge = FindEdge(edges, 300, 0, 1000, 0); // D-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 400, 300, 0))); // D-X neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 400))); // D-X neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 300, 0))); // D-X neighbours Z-D
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

            Assume.That(() => 10 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 400, 300, 400, 0)); // A-B
            Assume.That(() => HasEdge(edges, 400, 300, 1000, 300)); // A-C
            Assume.That(() => HasEdge(edges, 400, 300, 0, 700)); // A-D
            Assume.That(() => HasEdge(edges, 0, 0, 400, 0)); // X-B
            Assume.That(() => HasEdge(edges, 400, 0, 1000, 0)); // B-Y
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 300)); // Y-C
            Assume.That(() => HasEdge(edges, 1000, 300, 1000, 1000)); // C-W
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000)); // W-Z
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 700)); // Z-D
            Assume.That(() => HasEdge(edges, 0, 700, 0, 0)); // D-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 400, 300, 400, 0); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 300, 1000, 300))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 300, 0, 700))); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 400, 0))); // A-B neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 0, 1000, 0))); // A-B neighbours B-Y
            edge = FindEdge(edges, 400, 300, 1000, 300); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 300, 400, 0))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 300, 0, 700))); // A-C neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 300))); // A-C neighbours Y-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 300, 1000, 1000))); // A-C neighbours C-W
            edge = FindEdge(edges, 400, 300, 0, 700); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 300, 400, 0))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 300, 1000, 300))); // A-D neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 700))); // A-D neighbours Z-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 0, 0))); // A-D neighbours D-X
            edge = FindEdge(edges, 0, 0, 400, 0); // X-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 300, 400, 0))); // X-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 0, 1000, 0))); // X-B neighbours B-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 0, 0))); // X-B neighbours D-X
            edge = FindEdge(edges, 400, 0, 1000, 0); // B-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 300, 400, 0))); // B-Y neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 400, 0))); // B-Y neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 300))); // B-Y neighbours Y-C
            edge = FindEdge(edges, 1000, 0, 1000, 300); // Y-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 300, 1000, 300))); // Y-C neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 0, 1000, 0))); // Y-C neighbours B-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 300, 1000, 1000))); // Y-C neighbours C-W
            edge = FindEdge(edges, 1000, 300, 1000, 1000); // C-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 300, 1000, 300))); // C-W neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 300))); // C-W neighbours Y-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // C-W neighbours W-Z
            edge = FindEdge(edges, 1000, 1000, 0, 1000); // W-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 300, 1000, 1000))); // W-Z neighbours C-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 700))); // W-Z neighbours Z-D
            edge = FindEdge(edges, 0, 1000, 0, 700); // Z-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 300, 0, 700))); // Z-D neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // Z-D neighbours W-Z
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 0, 0))); // Z-D neighbours D-X
            edge = FindEdge(edges, 0, 700, 0, 0); // D-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 300, 0, 700))); // D-X neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 400, 0))); // D-X neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 700))); // D-X neighbours Z-D
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

            Assume.That(() => 10 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 700, 600, 1000, 600)); // A-B
            Assume.That(() => HasEdge(edges, 700, 600, 700, 0)); // A-C
            Assume.That(() => HasEdge(edges, 700, 600, 300, 1000)); // A-D
            Assume.That(() => HasEdge(edges, 1000, 1000, 1000, 600)); // X-B
            Assume.That(() => HasEdge(edges, 1000, 600, 1000, 0)); // B-Y
            Assume.That(() => HasEdge(edges, 1000, 0, 700, 0)); // Y-C
            Assume.That(() => HasEdge(edges, 700, 0, 0, 0)); // C-W
            Assume.That(() => HasEdge(edges, 0, 0, 0, 1000)); // W-Z
            Assume.That(() => HasEdge(edges, 0, 1000, 300, 1000)); // Z-D
            Assume.That(() => HasEdge(edges, 300, 1000, 1000, 1000)); // D-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 700, 600, 1000, 600); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 600, 700, 0))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 600, 300, 1000))); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 1000, 600))); // A-B neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 600, 1000, 0))); // A-B neighbours B-Y
            edge = FindEdge(edges, 700, 600, 700, 0); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 600, 1000, 600))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 600, 300, 1000))); // A-C neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 700, 0))); // A-C neighbours Y-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 0, 0, 0))); // A-C neighbours C-W
            edge = FindEdge(edges, 700, 600, 300, 1000); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 600, 1000, 600))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 600, 700, 0))); // A-D neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 300, 1000))); // A-D neighbours Z-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 1000, 1000, 1000))); // A-D neighbours D-X
            edge = FindEdge(edges, 1000, 1000, 1000, 600); // X-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 600, 1000, 600))); // X-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 600, 1000, 0))); // X-B neighbours B-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 1000, 1000, 1000))); // X-B neighbours D-X
            edge = FindEdge(edges, 1000, 600, 1000, 0); // B-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 600, 1000, 600))); // B-Y neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 1000, 600))); // B-Y neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 700, 0))); // B-Y neighbours Y-C
            edge = FindEdge(edges, 1000, 0, 700, 0); // Y-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 600, 700, 0))); // Y-C neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 600, 1000, 0))); // Y-C neighbours B-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 0, 0, 0))); // Y-C neighbours C-W
            edge = FindEdge(edges, 700, 0, 0, 0); // C-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 600, 700, 0))); // C-W neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 700, 0))); // C-W neighbours Y-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 0, 1000))); // C-W neighbours W-Z
            edge = FindEdge(edges, 0, 0, 0, 1000); // W-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 0, 0, 0))); // W-Z neighbours C-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 300, 1000))); // W-Z neighbours Z-D
            edge = FindEdge(edges, 0, 1000, 300, 1000); // Z-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 600, 300, 1000))); // Z-D neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 0, 1000))); // Z-D neighbours W-Z
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 1000, 1000, 1000))); // Z-D neighbours D-X
            edge = FindEdge(edges, 300, 1000, 1000, 1000); // D-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 600, 300, 1000))); // D-X neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 1000, 600))); // D-X neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 300, 1000))); // D-X neighbours Z-D
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

            Assume.That(() => 10 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 600, 300, 600, 0)); // A-B
            Assume.That(() => HasEdge(edges, 600, 300, 0, 300)); // A-C
            Assume.That(() => HasEdge(edges, 600, 300, 1000, 700)); // A-D
            Assume.That(() => HasEdge(edges, 1000, 0, 600, 0)); // X-B
            Assume.That(() => HasEdge(edges, 600, 0, 0, 0)); // B-Y
            Assume.That(() => HasEdge(edges, 0, 0, 0, 300)); // Y-C
            Assume.That(() => HasEdge(edges, 0, 300, 0, 1000)); // C-W
            Assume.That(() => HasEdge(edges, 0, 1000, 1000, 1000)); // W-Z
            Assume.That(() => HasEdge(edges, 1000, 1000, 1000, 700)); // Z-D
            Assume.That(() => HasEdge(edges, 1000, 700, 1000, 0)); // D-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 600, 300, 600, 0); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 300, 0, 300))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 300, 1000, 700))); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 600, 0))); // A-B neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 0, 0, 0))); // A-B neighbours B-Y
            edge = FindEdge(edges, 600, 300, 0, 300); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 300, 600, 0))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 300, 1000, 700))); // A-C neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 0, 300))); // A-C neighbours Y-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 300, 0, 1000))); // A-C neighbours C-W
            edge = FindEdge(edges, 600, 300, 1000, 700); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 300, 600, 0))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 300, 0, 300))); // A-D neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 1000, 700))); // A-D neighbours Z-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 700, 1000, 0))); // A-D neighbours D-X
            edge = FindEdge(edges, 1000, 0, 600, 0); // X-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 300, 600, 0))); // X-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 0, 0, 0))); // X-B neighbours B-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 700, 1000, 0))); // X-B neighbours D-X
            edge = FindEdge(edges, 600, 0, 0, 0); // B-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 300, 600, 0))); // B-Y neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 600, 0))); // B-Y neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 0, 300))); // B-Y neighbours Y-C
            edge = FindEdge(edges, 0, 0, 0, 300); // Y-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 300, 0, 300))); // Y-C neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 0, 0, 0))); // Y-C neighbours B-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 300, 0, 1000))); // Y-C neighbours C-W
            edge = FindEdge(edges, 0, 300, 0, 1000); // C-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 300, 0, 300))); // C-W neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 0, 300))); // C-W neighbours Y-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 1000, 1000))); // C-W neighbours W-Z
            edge = FindEdge(edges, 0, 1000, 1000, 1000); // W-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 300, 0, 1000))); // W-Z neighbours C-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 1000, 700))); // W-Z neighbours Z-D
            edge = FindEdge(edges, 1000, 1000, 1000, 700); // Z-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 300, 1000, 700))); // Z-D neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 1000, 1000))); // Z-D neighbours W-Z
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 700, 1000, 0))); // Z-D neighbours D-X
            edge = FindEdge(edges, 1000, 700, 1000, 0); // D-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 300, 1000, 700))); // D-X neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 600, 0))); // D-X neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 1000, 700))); // D-X neighbours Z-D
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

            Assume.That(() => 10 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 300, 400, 0, 400)); // A-B
            Assume.That(() => HasEdge(edges, 300, 400, 300, 1000)); // A-C
            Assume.That(() => HasEdge(edges, 300, 400, 700, 0)); // A-D
            Assume.That(() => HasEdge(edges, 0, 0, 0, 400)); // X-B
            Assume.That(() => HasEdge(edges, 0, 400, 0, 1000)); // B-Y
            Assume.That(() => HasEdge(edges, 0, 1000, 300, 1000)); // Y-C
            Assume.That(() => HasEdge(edges, 300, 1000, 1000, 1000)); // C-W
            Assume.That(() => HasEdge(edges, 1000, 1000, 1000, 0)); // W-Z
            Assume.That(() => HasEdge(edges, 1000, 0, 700, 0)); // Z-D
            Assume.That(() => HasEdge(edges, 700, 0, 0, 0)); // D-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 300, 400, 0, 400); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 400, 300, 1000))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 400, 700, 0))); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 0, 400))); // A-B neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 400, 0, 1000))); // A-B neighbours B-Y
            edge = FindEdge(edges, 300, 400, 300, 1000); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 400, 0, 400))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 400, 700, 0))); // A-C neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 300, 1000))); // A-C neighbours Y-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 1000, 1000, 1000))); // A-C neighbours C-W
            edge = FindEdge(edges, 300, 400, 700, 0); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 400, 0, 400))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 400, 300, 1000))); // A-D neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 700, 0))); // A-D neighbours Z-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 0, 0, 0))); // A-D neighbours D-X
            edge = FindEdge(edges, 0, 0, 0, 400); // X-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 400, 0, 400))); // X-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 400, 0, 1000))); // X-B neighbours B-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 0, 0, 0))); // X-B neighbours D-X
            edge = FindEdge(edges, 0, 400, 0, 1000); // B-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 400, 0, 400))); // B-Y neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 0, 400))); // B-Y neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 300, 1000))); // B-Y neighbours Y-C
            edge = FindEdge(edges, 0, 1000, 300, 1000); // Y-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 400, 300, 1000))); // Y-C neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 400, 0, 1000))); // Y-C neighbours B-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 1000, 1000, 1000))); // Y-C neighbours C-W
            edge = FindEdge(edges, 300, 1000, 1000, 1000); // C-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 400, 300, 1000))); // C-W neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 300, 1000))); // C-W neighbours Y-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 1000, 0))); // C-W neighbours W-Z
            edge = FindEdge(edges, 1000, 1000, 1000, 0); // W-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 1000, 1000, 1000))); // W-Z neighbours C-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 700, 0))); // W-Z neighbours Z-D
            edge = FindEdge(edges, 1000, 0, 700, 0); // Z-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 400, 700, 0))); // Z-D neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 1000, 0))); // Z-D neighbours W-Z
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 0, 0, 0))); // Z-D neighbours D-X
            edge = FindEdge(edges, 700, 0, 0, 0); // D-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 400, 700, 0))); // D-X neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 0, 400))); // D-X neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 700, 0))); // D-X neighbours Z-D
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

            Assume.That(() => 10 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 400, 700, 400, 1000)); // A-B
            Assume.That(() => HasEdge(edges, 400, 700, 1000, 700)); // A-C
            Assume.That(() => HasEdge(edges, 400, 700, 0, 300)); // A-D
            Assume.That(() => HasEdge(edges, 0, 1000, 400, 1000)); // X-B
            Assume.That(() => HasEdge(edges, 400, 1000, 1000, 1000)); // B-Y
            Assume.That(() => HasEdge(edges, 1000, 1000, 1000, 700)); // Y-C
            Assume.That(() => HasEdge(edges, 1000, 700, 1000, 0)); // C-W
            Assume.That(() => HasEdge(edges, 1000, 0, 0, 0)); // W-Z
            Assume.That(() => HasEdge(edges, 0, 0, 0, 300)); // Z-D
            Assume.That(() => HasEdge(edges, 0, 300, 0, 1000)); // D-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 400, 700, 400, 1000); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 700, 1000, 700))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 700, 0, 300))); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 400, 1000))); // A-B neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 1000, 1000, 1000))); // A-B neighbours B-Y
            edge = FindEdge(edges, 400, 700, 1000, 700); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 700, 400, 1000))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 700, 0, 300))); // A-C neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 1000, 700))); // A-C neighbours Y-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 700, 1000, 0))); // A-C neighbours C-W
            edge = FindEdge(edges, 400, 700, 0, 300); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 700, 400, 1000))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 700, 1000, 700))); // A-D neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 0, 300))); // A-D neighbours Z-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 300, 0, 1000))); // A-D neighbours D-X
            edge = FindEdge(edges, 0, 1000, 400, 1000); // X-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 700, 400, 1000))); // X-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 1000, 1000, 1000))); // X-B neighbours B-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 300, 0, 1000))); // X-B neighbours D-X
            edge = FindEdge(edges, 400, 1000, 1000, 1000); // B-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 700, 400, 1000))); // B-Y neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 400, 1000))); // B-Y neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 1000, 700))); // B-Y neighbours Y-C
            edge = FindEdge(edges, 1000, 1000, 1000, 700); // Y-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 700, 1000, 700))); // Y-C neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 1000, 1000, 1000))); // Y-C neighbours B-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 700, 1000, 0))); // Y-C neighbours C-W
            edge = FindEdge(edges, 1000, 700, 1000, 0); // C-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 700, 1000, 700))); // C-W neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 1000, 700))); // C-W neighbours Y-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 0, 0))); // C-W neighbours W-Z
            edge = FindEdge(edges, 1000, 0, 0, 0); // W-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 700, 1000, 0))); // W-Z neighbours C-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 0, 300))); // W-Z neighbours Z-D
            edge = FindEdge(edges, 0, 0, 0, 300); // Z-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 700, 0, 300))); // Z-D neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 0, 0))); // Z-D neighbours W-Z
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 300, 0, 1000))); // Z-D neighbours D-X
            edge = FindEdge(edges, 0, 300, 0, 1000); // D-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 700, 0, 300))); // D-X neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 400, 1000))); // D-X neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 0, 300))); // D-X neighbours Z-D
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

            Assume.That(() => 8 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 500, 500, 0, 0)); // A-B
            Assume.That(() => HasEdge(edges, 500, 500, 1000, 0)); // A-C
            Assume.That(() => HasEdge(edges, 500, 500, 500, 1000)); // A-D
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0)); // X-B
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0)); // B-C
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000)); // C-Y
            Assume.That(() => HasEdge(edges, 1000, 1000, 500, 1000)); // Y-D
            Assume.That(() => HasEdge(edges, 500, 1000, 0, 1000)); // D-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 500, 500, 0, 0); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 0))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 1000))); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // A-B neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // A-B neighbours B-C
            edge = FindEdge(edges, 500, 500, 1000, 0); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 0))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 1000))); // A-C neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // A-C neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // A-C neighbours C-Y
            edge = FindEdge(edges, 500, 500, 500, 1000); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 0))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 0))); // A-D neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 500, 1000))); // A-D neighbours Y-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 1000, 0, 1000))); // A-D neighbours D-X
            edge = FindEdge(edges, 0, 1000, 0, 0); // X-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 0))); // X-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // X-B neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 1000, 0, 1000))); // X-B neighbours D-X
            edge = FindEdge(edges, 0, 0, 1000, 0); // B-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 0))); // B-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 0))); // B-C neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // B-C neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // B-C neighbours C-Y
            edge = FindEdge(edges, 1000, 0, 1000, 1000); // C-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 0))); // C-Y neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // C-Y neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 500, 1000))); // C-Y neighbours Y-D
            edge = FindEdge(edges, 1000, 1000, 500, 1000); // Y-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 1000))); // Y-D neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // Y-D neighbours C-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 1000, 0, 1000))); // Y-D neighbours D-X
            edge = FindEdge(edges, 500, 1000, 0, 1000); // D-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 1000))); // D-X neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // D-X neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 500, 1000))); // D-X neighbours Y-D
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

            Assume.That(() => 8 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 500, 500, 0, 1000)); // A-B
            Assume.That(() => HasEdge(edges, 500, 500, 0, 0)); // A-C
            Assume.That(() => HasEdge(edges, 500, 500, 1000, 500)); // A-D
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000)); // X-B
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0)); // B-C
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0)); // C-Y
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 500)); // Y-D
            Assume.That(() => HasEdge(edges, 1000, 500, 1000, 1000)); // D-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 500, 500, 0, 1000); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 0))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 500))); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // A-B neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // A-B neighbours B-C
            edge = FindEdge(edges, 500, 500, 0, 0); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 1000))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 500))); // A-C neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // A-C neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // A-C neighbours C-Y
            edge = FindEdge(edges, 500, 500, 1000, 500); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 1000))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 0))); // A-D neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 500))); // A-D neighbours Y-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 500, 1000, 1000))); // A-D neighbours D-X
            edge = FindEdge(edges, 1000, 1000, 0, 1000); // X-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 1000))); // X-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // X-B neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 500, 1000, 1000))); // X-B neighbours D-X
            edge = FindEdge(edges, 0, 1000, 0, 0); // B-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 1000))); // B-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 0))); // B-C neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // B-C neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // B-C neighbours C-Y
            edge = FindEdge(edges, 0, 0, 1000, 0); // C-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 0))); // C-Y neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // C-Y neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 500))); // C-Y neighbours Y-D
            edge = FindEdge(edges, 1000, 0, 1000, 500); // Y-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 500))); // Y-D neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // Y-D neighbours C-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 500, 1000, 1000))); // Y-D neighbours D-X
            edge = FindEdge(edges, 1000, 500, 1000, 1000); // D-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 500))); // D-X neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // D-X neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 500))); // D-X neighbours Y-D
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

            Assume.That(() => 8 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 500, 500, 1000, 1000)); // A-B
            Assume.That(() => HasEdge(edges, 500, 500, 0, 1000)); // A-C
            Assume.That(() => HasEdge(edges, 500, 500, 500, 0)); // A-D
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000)); // X-B
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000)); // B-C
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0)); // C-Y
            Assume.That(() => HasEdge(edges, 0, 0, 500, 0)); // Y-D
            Assume.That(() => HasEdge(edges, 500, 0, 1000, 0)); // D-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 500, 500, 1000, 1000); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 1000))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 0))); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // A-B neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // A-B neighbours B-C
            edge = FindEdge(edges, 500, 500, 0, 1000); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 1000))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 0))); // A-C neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // A-C neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // A-C neighbours C-Y
            edge = FindEdge(edges, 500, 500, 500, 0); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 1000))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 1000))); // A-D neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 500, 0))); // A-D neighbours Y-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 0, 1000, 0))); // A-D neighbours D-X
            edge = FindEdge(edges, 1000, 0, 1000, 1000); // X-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 1000))); // X-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // X-B neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 0, 1000, 0))); // X-B neighbours D-X
            edge = FindEdge(edges, 1000, 1000, 0, 1000); // B-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 1000))); // B-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 1000))); // B-C neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // B-C neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // B-C neighbours C-Y
            edge = FindEdge(edges, 0, 1000, 0, 0); // C-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 1000))); // C-Y neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // C-Y neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 500, 0))); // C-Y neighbours Y-D
            edge = FindEdge(edges, 0, 0, 500, 0); // Y-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 0))); // Y-D neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // Y-D neighbours C-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 0, 1000, 0))); // Y-D neighbours D-X
            edge = FindEdge(edges, 500, 0, 1000, 0); // D-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 0))); // D-X neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // D-X neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 500, 0))); // D-X neighbours Y-D
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

            Assume.That(() => 8 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 500, 500, 1000, 0)); // A-B
            Assume.That(() => HasEdge(edges, 500, 500, 1000, 1000)); // A-C
            Assume.That(() => HasEdge(edges, 500, 500, 0, 500)); // A-D
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0)); // X-B
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000)); // B-C
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000)); // C-Y
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 500)); // Y-D
            Assume.That(() => HasEdge(edges, 0, 500, 0, 0)); // D-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 500, 500, 1000, 0); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 1000))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 500))); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // A-B neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // A-B neighbours B-C
            edge = FindEdge(edges, 500, 500, 1000, 1000); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 0))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 500))); // A-C neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // A-C neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // A-C neighbours C-Y
            edge = FindEdge(edges, 500, 500, 0, 500); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 0))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 1000))); // A-D neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 500))); // A-D neighbours Y-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 0, 0))); // A-D neighbours D-X
            edge = FindEdge(edges, 0, 0, 1000, 0); // X-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 0))); // X-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // X-B neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 0, 0))); // X-B neighbours D-X
            edge = FindEdge(edges, 1000, 0, 1000, 1000); // B-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 0))); // B-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 1000))); // B-C neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // B-C neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // B-C neighbours C-Y
            edge = FindEdge(edges, 1000, 1000, 0, 1000); // C-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 1000))); // C-Y neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // C-Y neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 500))); // C-Y neighbours Y-D
            edge = FindEdge(edges, 0, 1000, 0, 500); // Y-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 500))); // Y-D neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // Y-D neighbours C-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 0, 0))); // Y-D neighbours D-X
            edge = FindEdge(edges, 0, 500, 0, 0); // D-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 500))); // D-X neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // D-X neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 500))); // D-X neighbours Y-D
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

            Assume.That(() => 10 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 500, 300, 200, 0)); // A-B
            Assume.That(() => HasEdge(edges, 500, 300, 800, 0)); // A-C
            Assume.That(() => HasEdge(edges, 500, 300, 500, 1000)); // A-D
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0)); // X-Y
            Assume.That(() => HasEdge(edges, 0, 0, 200, 0)); // Y-B
            Assume.That(() => HasEdge(edges, 200, 0, 800, 0)); // B-C
            Assume.That(() => HasEdge(edges, 800, 0, 1000, 0)); // C-W
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000)); // W-Z
            Assume.That(() => HasEdge(edges, 1000, 1000, 500, 1000)); // Z-D
            Assume.That(() => HasEdge(edges, 500, 1000, 0, 1000)); // D-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 500, 300, 200, 0); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 800, 0))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 1000))); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 200, 0))); // A-B neighbours Y-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 0, 800, 0))); // A-B neighbours B-C
            edge = FindEdge(edges, 500, 300, 800, 0); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 200, 0))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 1000))); // A-C neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 0, 800, 0))); // A-C neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 0, 1000, 0))); // A-C neighbours C-W
            edge = FindEdge(edges, 500, 300, 500, 1000); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 200, 0))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 800, 0))); // A-D neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 500, 1000))); // A-D neighbours Z-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 1000, 0, 1000))); // A-D neighbours D-X
            edge = FindEdge(edges, 0, 1000, 0, 0); // X-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 200, 0))); // X-Y neighbours Y-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 1000, 0, 1000))); // X-Y neighbours D-X
            edge = FindEdge(edges, 0, 0, 200, 0); // Y-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 200, 0))); // Y-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // Y-B neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 0, 800, 0))); // Y-B neighbours B-C
            edge = FindEdge(edges, 200, 0, 800, 0); // B-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 200, 0))); // B-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 800, 0))); // B-C neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 200, 0))); // B-C neighbours Y-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 0, 1000, 0))); // B-C neighbours C-W
            edge = FindEdge(edges, 800, 0, 1000, 0); // C-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 800, 0))); // C-W neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 0, 800, 0))); // C-W neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // C-W neighbours W-Z
            edge = FindEdge(edges, 1000, 0, 1000, 1000); // W-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 0, 1000, 0))); // W-Z neighbours C-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 500, 1000))); // W-Z neighbours Z-D
            edge = FindEdge(edges, 1000, 1000, 500, 1000); // Z-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 1000))); // Z-D neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // Z-D neighbours W-Z
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 1000, 0, 1000))); // Z-D neighbours D-X
            edge = FindEdge(edges, 500, 1000, 0, 1000); // D-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 1000))); // D-X neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // D-X neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 500, 1000))); // D-X neighbours Z-D
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

            Assume.That(() => 10 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 300, 500, 0, 800)); // A-B
            Assume.That(() => HasEdge(edges, 300, 500, 0, 200)); // A-C
            Assume.That(() => HasEdge(edges, 300, 500, 1000, 500)); // A-D
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000)); // X-Y
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 800)); // Y-B
            Assume.That(() => HasEdge(edges, 0, 800, 0, 200)); // B-C
            Assume.That(() => HasEdge(edges, 0, 200, 0, 0)); // C-W
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0)); // W-Z
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 500)); // Z-D
            Assume.That(() => HasEdge(edges, 1000, 500, 1000, 1000)); // D-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 300, 500, 0, 800); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 0, 200))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 1000, 500))); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 800))); // A-B neighbours Y-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 800, 0, 200))); // A-B neighbours B-C
            edge = FindEdge(edges, 300, 500, 0, 200); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 0, 800))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 1000, 500))); // A-C neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 800, 0, 200))); // A-C neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 200, 0, 0))); // A-C neighbours C-W
            edge = FindEdge(edges, 300, 500, 1000, 500); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 0, 800))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 0, 200))); // A-D neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 500))); // A-D neighbours Z-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 500, 1000, 1000))); // A-D neighbours D-X
            edge = FindEdge(edges, 1000, 1000, 0, 1000); // X-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 800))); // X-Y neighbours Y-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 500, 1000, 1000))); // X-Y neighbours D-X
            edge = FindEdge(edges, 0, 1000, 0, 800); // Y-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 0, 800))); // Y-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // Y-B neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 800, 0, 200))); // Y-B neighbours B-C
            edge = FindEdge(edges, 0, 800, 0, 200); // B-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 0, 800))); // B-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 0, 200))); // B-C neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 800))); // B-C neighbours Y-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 200, 0, 0))); // B-C neighbours C-W
            edge = FindEdge(edges, 0, 200, 0, 0); // C-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 0, 200))); // C-W neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 800, 0, 200))); // C-W neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // C-W neighbours W-Z
            edge = FindEdge(edges, 0, 0, 1000, 0); // W-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 200, 0, 0))); // W-Z neighbours C-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 500))); // W-Z neighbours Z-D
            edge = FindEdge(edges, 1000, 0, 1000, 500); // Z-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 1000, 500))); // Z-D neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // Z-D neighbours W-Z
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 500, 1000, 1000))); // Z-D neighbours D-X
            edge = FindEdge(edges, 1000, 500, 1000, 1000); // D-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 1000, 500))); // D-X neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // D-X neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 500))); // D-X neighbours Z-D
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

            Assume.That(() => 10 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 500, 700, 800, 1000)); // A-B
            Assume.That(() => HasEdge(edges, 500, 700, 200, 1000)); // A-C
            Assume.That(() => HasEdge(edges, 500, 700, 500, 0)); // A-D
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000)); // X-Y
            Assume.That(() => HasEdge(edges, 1000, 1000, 800, 1000)); // Y-B
            Assume.That(() => HasEdge(edges, 800, 1000, 200, 1000)); // B-C
            Assume.That(() => HasEdge(edges, 200, 1000, 0, 1000)); // C-W
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0)); // W-Z
            Assume.That(() => HasEdge(edges, 0, 0, 500, 0)); // Z-D
            Assume.That(() => HasEdge(edges, 500, 0, 1000, 0)); // D-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 500, 700, 800, 1000); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 200, 1000))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 500, 0))); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 800, 1000))); // A-B neighbours Y-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 1000, 200, 1000))); // A-B neighbours B-C
            edge = FindEdge(edges, 500, 700, 200, 1000); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 800, 1000))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 500, 0))); // A-C neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 1000, 200, 1000))); // A-C neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 1000, 0, 1000))); // A-C neighbours C-W
            edge = FindEdge(edges, 500, 700, 500, 0); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 800, 1000))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 200, 1000))); // A-D neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 500, 0))); // A-D neighbours Z-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 0, 1000, 0))); // A-D neighbours D-X
            edge = FindEdge(edges, 1000, 0, 1000, 1000); // X-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 800, 1000))); // X-Y neighbours Y-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 0, 1000, 0))); // X-Y neighbours D-X
            edge = FindEdge(edges, 1000, 1000, 800, 1000); // Y-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 800, 1000))); // Y-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // Y-B neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 1000, 200, 1000))); // Y-B neighbours B-C
            edge = FindEdge(edges, 800, 1000, 200, 1000); // B-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 800, 1000))); // B-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 200, 1000))); // B-C neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 800, 1000))); // B-C neighbours Y-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 1000, 0, 1000))); // B-C neighbours C-W
            edge = FindEdge(edges, 200, 1000, 0, 1000); // C-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 200, 1000))); // C-W neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 1000, 200, 1000))); // C-W neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // C-W neighbours W-Z
            edge = FindEdge(edges, 0, 1000, 0, 0); // W-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 1000, 0, 1000))); // W-Z neighbours C-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 500, 0))); // W-Z neighbours Z-D
            edge = FindEdge(edges, 0, 0, 500, 0); // Z-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 500, 0))); // Z-D neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // Z-D neighbours W-Z
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 0, 1000, 0))); // Z-D neighbours D-X
            edge = FindEdge(edges, 500, 0, 1000, 0); // D-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 500, 0))); // D-X neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // D-X neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 500, 0))); // D-X neighbours Z-D
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

            Assume.That(() => 10 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 700, 500, 1000, 200)); // A-B
            Assume.That(() => HasEdge(edges, 700, 500, 1000, 800)); // A-C
            Assume.That(() => HasEdge(edges, 700, 500, 0, 500)); // A-D
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0)); // X-Y
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 200)); // Y-B
            Assume.That(() => HasEdge(edges, 1000, 200, 1000, 800)); // B-C
            Assume.That(() => HasEdge(edges, 1000, 800, 1000, 1000)); // C-W
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000)); // W-Z
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 500)); // Z-D
            Assume.That(() => HasEdge(edges, 0, 500, 0, 0)); // D-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 700, 500, 1000, 200); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 1000, 800))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 0, 500))); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 200))); // A-B neighbours Y-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 200, 1000, 800))); // A-B neighbours B-C
            edge = FindEdge(edges, 700, 500, 1000, 800); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 1000, 200))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 0, 500))); // A-C neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 200, 1000, 800))); // A-C neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 800, 1000, 1000))); // A-C neighbours C-W
            edge = FindEdge(edges, 700, 500, 0, 500); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 1000, 200))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 1000, 800))); // A-D neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 500))); // A-D neighbours Z-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 0, 0))); // A-D neighbours D-X
            edge = FindEdge(edges, 0, 0, 1000, 0); // X-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 200))); // X-Y neighbours Y-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 0, 0))); // X-Y neighbours D-X
            edge = FindEdge(edges, 1000, 0, 1000, 200); // Y-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 1000, 200))); // Y-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // Y-B neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 200, 1000, 800))); // Y-B neighbours B-C
            edge = FindEdge(edges, 1000, 200, 1000, 800); // B-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 1000, 200))); // B-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 1000, 800))); // B-C neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 200))); // B-C neighbours Y-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 800, 1000, 1000))); // B-C neighbours C-W
            edge = FindEdge(edges, 1000, 800, 1000, 1000); // C-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 1000, 800))); // C-W neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 200, 1000, 800))); // C-W neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // C-W neighbours W-Z
            edge = FindEdge(edges, 1000, 1000, 0, 1000); // W-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 800, 1000, 1000))); // W-Z neighbours C-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 500))); // W-Z neighbours Z-D
            edge = FindEdge(edges, 0, 1000, 0, 500); // Z-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 0, 500))); // Z-D neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // Z-D neighbours W-Z
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 0, 0))); // Z-D neighbours D-X
            edge = FindEdge(edges, 0, 500, 0, 0); // D-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 0, 500))); // D-X neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // D-X neighbours X-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 500))); // D-X neighbours Z-D
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

            Assume.That(() => 10 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 500, 700, 0, 200)); // A-B
            Assume.That(() => HasEdge(edges, 500, 700, 1000, 200)); // A-C
            Assume.That(() => HasEdge(edges, 500, 700, 500, 1000)); // A-D
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 200)); // X-B
            Assume.That(() => HasEdge(edges, 0, 200, 0, 0)); // B-Y
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0)); // Y-W
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 200)); // W-C
            Assume.That(() => HasEdge(edges, 1000, 200, 1000, 1000)); // C-Z
            Assume.That(() => HasEdge(edges, 1000, 1000, 500, 1000)); // Z-D
            Assume.That(() => HasEdge(edges, 500, 1000, 0, 1000)); // D-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 500, 700, 0, 200); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 1000, 200))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 500, 1000))); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 200))); // A-B neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 200, 0, 0))); // A-B neighbours B-Y
            edge = FindEdge(edges, 500, 700, 1000, 200); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 0, 200))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 500, 1000))); // A-C neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 200))); // A-C neighbours W-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 200, 1000, 1000))); // A-C neighbours C-Z
            edge = FindEdge(edges, 500, 700, 500, 1000); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 0, 200))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 1000, 200))); // A-D neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 500, 1000))); // A-D neighbours Z-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 1000, 0, 1000))); // A-D neighbours D-X
            edge = FindEdge(edges, 0, 1000, 0, 200); // X-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 0, 200))); // X-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 200, 0, 0))); // X-B neighbours B-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 1000, 0, 1000))); // X-B neighbours D-X
            edge = FindEdge(edges, 0, 200, 0, 0); // B-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 0, 200))); // B-Y neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 200))); // B-Y neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // B-Y neighbours Y-W
            edge = FindEdge(edges, 0, 0, 1000, 0); // Y-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 200, 0, 0))); // Y-W neighbours B-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 200))); // Y-W neighbours W-C
            edge = FindEdge(edges, 1000, 0, 1000, 200); // W-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 1000, 200))); // W-C neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // W-C neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 200, 1000, 1000))); // W-C neighbours C-Z
            edge = FindEdge(edges, 1000, 200, 1000, 1000); // C-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 1000, 200))); // C-Z neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 200))); // C-Z neighbours W-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 500, 1000))); // C-Z neighbours Z-D
            edge = FindEdge(edges, 1000, 1000, 500, 1000); // Z-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 500, 1000))); // Z-D neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 200, 1000, 1000))); // Z-D neighbours C-Z
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 1000, 0, 1000))); // Z-D neighbours D-X
            edge = FindEdge(edges, 500, 1000, 0, 1000); // D-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 500, 1000))); // D-X neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 200))); // D-X neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 500, 1000))); // D-X neighbours Z-D
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

            Assume.That(() => 10 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 700, 500, 200, 1000)); // A-B
            Assume.That(() => HasEdge(edges, 700, 500, 200, 0)); // A-C
            Assume.That(() => HasEdge(edges, 700, 500, 1000, 500)); // A-D
            Assume.That(() => HasEdge(edges, 1000, 1000, 200, 1000)); // X-B
            Assume.That(() => HasEdge(edges, 200, 1000, 0, 1000)); // B-Y
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0)); // Y-W
            Assume.That(() => HasEdge(edges, 0, 0, 200, 0)); // W-C
            Assume.That(() => HasEdge(edges, 200, 0, 1000, 0)); // C-Z
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 500)); // Z-D
            Assume.That(() => HasEdge(edges, 1000, 500, 1000, 1000)); // D-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 700, 500, 200, 1000); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 200, 0))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 1000, 500))); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 200, 1000))); // A-B neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 1000, 0, 1000))); // A-B neighbours B-Y
            edge = FindEdge(edges, 700, 500, 200, 0); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 200, 1000))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 1000, 500))); // A-C neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 200, 0))); // A-C neighbours W-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 0, 1000, 0))); // A-C neighbours C-Z
            edge = FindEdge(edges, 700, 500, 1000, 500); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 200, 1000))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 200, 0))); // A-D neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 500))); // A-D neighbours Z-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 500, 1000, 1000))); // A-D neighbours D-X
            edge = FindEdge(edges, 1000, 1000, 200, 1000); // X-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 200, 1000))); // X-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 1000, 0, 1000))); // X-B neighbours B-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 500, 1000, 1000))); // X-B neighbours D-X
            edge = FindEdge(edges, 200, 1000, 0, 1000); // B-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 200, 1000))); // B-Y neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 200, 1000))); // B-Y neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // B-Y neighbours Y-W
            edge = FindEdge(edges, 0, 1000, 0, 0); // Y-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 1000, 0, 1000))); // Y-W neighbours B-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 200, 0))); // Y-W neighbours W-C
            edge = FindEdge(edges, 0, 0, 200, 0); // W-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 200, 0))); // W-C neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // W-C neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 0, 1000, 0))); // W-C neighbours C-Z
            edge = FindEdge(edges, 200, 0, 1000, 0); // C-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 200, 0))); // C-Z neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 200, 0))); // C-Z neighbours W-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 500))); // C-Z neighbours Z-D
            edge = FindEdge(edges, 1000, 0, 1000, 500); // Z-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 1000, 500))); // Z-D neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 0, 1000, 0))); // Z-D neighbours C-Z
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 500, 1000, 1000))); // Z-D neighbours D-X
            edge = FindEdge(edges, 1000, 500, 1000, 1000); // D-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 1000, 500))); // D-X neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 200, 1000))); // D-X neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 500))); // D-X neighbours Z-D
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

            Assume.That(() => 10 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 500, 300, 1000, 800)); // A-B
            Assume.That(() => HasEdge(edges, 500, 300, 0, 800)); // A-C
            Assume.That(() => HasEdge(edges, 500, 300, 500, 0)); // A-D
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 800)); // X-B
            Assume.That(() => HasEdge(edges, 1000, 800, 1000, 1000)); // B-Y
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000)); // Y-W
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 800)); // W-C
            Assume.That(() => HasEdge(edges, 0, 800, 0, 0)); // C-Z
            Assume.That(() => HasEdge(edges, 0, 0, 500, 0)); // Z-D
            Assume.That(() => HasEdge(edges, 500, 0, 1000, 0)); // D-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 500, 300, 1000, 800); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 0, 800))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 0))); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 800))); // A-B neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 800, 1000, 1000))); // A-B neighbours B-Y
            edge = FindEdge(edges, 500, 300, 0, 800); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 1000, 800))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 0))); // A-C neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 800))); // A-C neighbours W-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 800, 0, 0))); // A-C neighbours C-Z
            edge = FindEdge(edges, 500, 300, 500, 0); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 1000, 800))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 0, 800))); // A-D neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 500, 0))); // A-D neighbours Z-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 0, 1000, 0))); // A-D neighbours D-X
            edge = FindEdge(edges, 1000, 0, 1000, 800); // X-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 1000, 800))); // X-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 800, 1000, 1000))); // X-B neighbours B-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 0, 1000, 0))); // X-B neighbours D-X
            edge = FindEdge(edges, 1000, 800, 1000, 1000); // B-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 1000, 800))); // B-Y neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 800))); // B-Y neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // B-Y neighbours Y-W
            edge = FindEdge(edges, 1000, 1000, 0, 1000); // Y-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 800, 1000, 1000))); // Y-W neighbours B-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 800))); // Y-W neighbours W-C
            edge = FindEdge(edges, 0, 1000, 0, 800); // W-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 0, 800))); // W-C neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // W-C neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 800, 0, 0))); // W-C neighbours C-Z
            edge = FindEdge(edges, 0, 800, 0, 0); // C-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 0, 800))); // C-Z neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 800))); // C-Z neighbours W-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 500, 0))); // C-Z neighbours Z-D
            edge = FindEdge(edges, 0, 0, 500, 0); // Z-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 0))); // Z-D neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 800, 0, 0))); // Z-D neighbours C-Z
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 0, 1000, 0))); // Z-D neighbours D-X
            edge = FindEdge(edges, 500, 0, 1000, 0); // D-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 0))); // D-X neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 800))); // D-X neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 500, 0))); // D-X neighbours Z-D
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

            Assume.That(() => 10 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 300, 500, 800, 0)); // A-B
            Assume.That(() => HasEdge(edges, 300, 500, 800, 1000)); // A-C
            Assume.That(() => HasEdge(edges, 300, 500, 0, 500)); // A-D
            Assume.That(() => HasEdge(edges, 0, 0, 800, 0)); // X-B
            Assume.That(() => HasEdge(edges, 800, 0, 1000, 0)); // B-Y
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000)); // Y-W
            Assume.That(() => HasEdge(edges, 1000, 1000, 800, 1000)); // W-C
            Assume.That(() => HasEdge(edges, 800, 1000, 0, 1000)); // C-Z
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 500)); // Z-D
            Assume.That(() => HasEdge(edges, 0, 500, 0, 0)); // D-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 300, 500, 800, 0); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 800, 1000))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 0, 500))); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 800, 0))); // A-B neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 0, 1000, 0))); // A-B neighbours B-Y
            edge = FindEdge(edges, 300, 500, 800, 1000); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 800, 0))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 0, 500))); // A-C neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 800, 1000))); // A-C neighbours W-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 1000, 0, 1000))); // A-C neighbours C-Z
            edge = FindEdge(edges, 300, 500, 0, 500); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 800, 0))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 800, 1000))); // A-D neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 500))); // A-D neighbours Z-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 0, 0))); // A-D neighbours D-X
            edge = FindEdge(edges, 0, 0, 800, 0); // X-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 800, 0))); // X-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 0, 1000, 0))); // X-B neighbours B-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 0, 0))); // X-B neighbours D-X
            edge = FindEdge(edges, 800, 0, 1000, 0); // B-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 800, 0))); // B-Y neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 800, 0))); // B-Y neighbours X-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // B-Y neighbours Y-W
            edge = FindEdge(edges, 1000, 0, 1000, 1000); // Y-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 0, 1000, 0))); // Y-W neighbours B-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 800, 1000))); // Y-W neighbours W-C
            edge = FindEdge(edges, 1000, 1000, 800, 1000); // W-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 800, 1000))); // W-C neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // W-C neighbours Y-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 1000, 0, 1000))); // W-C neighbours C-Z
            edge = FindEdge(edges, 800, 1000, 0, 1000); // C-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 800, 1000))); // C-Z neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 800, 1000))); // C-Z neighbours W-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 500))); // C-Z neighbours Z-D
            edge = FindEdge(edges, 0, 1000, 0, 500); // Z-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 0, 500))); // Z-D neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 1000, 0, 1000))); // Z-D neighbours C-Z
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 0, 0))); // Z-D neighbours D-X
            edge = FindEdge(edges, 0, 500, 0, 0); // D-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 0, 500))); // D-X neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 800, 0))); // D-X neighbours X-B
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

            Assume.That(() => 12 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 400, 600, 400, 400)); // A-B
            Assume.That(() => HasEdge(edges, 400, 400, 600, 400)); // B-C
            Assume.That(() => HasEdge(edges, 600, 400, 600, 600)); // C-D
            Assume.That(() => HasEdge(edges, 600, 600, 400, 600)); // D-A
            Assume.That(() => HasEdge(edges, 400, 600, 0, 1000)); // A-E
            Assume.That(() => HasEdge(edges, 400, 400, 0, 0)); // B-F
            Assume.That(() => HasEdge(edges, 600, 400, 1000, 0)); // C-G
            Assume.That(() => HasEdge(edges, 600, 600, 1000, 1000)); // D-H
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0)); // E-F
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0)); // F-G
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000)); // G-H
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000)); // H-E

            // Assert

            VoronoiEdge edge = FindEdge(edges, 400, 600, 400, 400); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 600, 400))); // A-B neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 400, 600))); // A-B neighbours D-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 0, 1000))); // A-B neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 0, 0))); // A-B neighbours B-F
            edge = FindEdge(edges, 400, 400, 600, 400); // B-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 400, 400))); // B-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 600, 600))); // B-C neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 0, 0))); // B-C neighbours B-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 1000, 0))); // B-C neighbours C-G
            edge = FindEdge(edges, 600, 400, 600, 600); // C-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 600, 400))); // C-D neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 400, 600))); // C-D neighbours D-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 1000, 0))); // C-D neighbours C-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 1000, 1000))); // C-D neighbours D-H
            edge = FindEdge(edges, 600, 600, 400, 600); // D-A
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 400, 400))); // D-A neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 600, 600))); // D-A neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 0, 1000))); // D-A neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 1000, 1000))); // D-A neighbours D-H
            edge = FindEdge(edges, 400, 600, 0, 1000); // A-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 400, 400))); // A-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 400, 600))); // A-E neighbours D-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // A-E neighbours E-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // A-E neighbours H-E
            edge = FindEdge(edges, 400, 400, 0, 0); // B-F
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 400, 400))); // B-F neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 600, 400))); // B-F neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // B-F neighbours E-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // B-F neighbours F-G
            edge = FindEdge(edges, 600, 400, 1000, 0); // C-G
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 600, 400))); // C-G neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 600, 600))); // C-G neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // C-G neighbours F-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // C-G neighbours G-H
            edge = FindEdge(edges, 600, 600, 1000, 1000); // D-H
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 600, 600))); // D-H neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 400, 600))); // D-H neighbours D-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // D-H neighbours G-H
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // D-H neighbours H-E
            edge = FindEdge(edges, 0, 1000, 0, 0); // E-F
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 0, 1000))); // E-F neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 0, 0))); // E-F neighbours B-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // E-F neighbours F-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // E-F neighbours H-E
            edge = FindEdge(edges, 0, 0, 1000, 0); // F-G
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 0, 0))); // F-G neighbours B-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 1000, 0))); // F-G neighbours C-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // F-G neighbours E-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // F-G neighbours G-H
            edge = FindEdge(edges, 1000, 0, 1000, 1000); // G-H
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 1000, 0))); // G-H neighbours C-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 1000, 1000))); // G-H neighbours D-H
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // G-H neighbours F-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // G-H neighbours H-E
            edge = FindEdge(edges, 1000, 1000, 0, 1000); // H-E
            Assert.NotNull(edge.Neighbours);
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
            //    0 Y---------F#---------------------------#G---------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 16 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 400, 400, 400, 200)); // A-B
            Assume.That(() => HasEdge(edges, 400, 200, 600, 200)); // B-C
            Assume.That(() => HasEdge(edges, 600, 200, 600, 400)); // C-D
            Assume.That(() => HasEdge(edges, 600, 400, 400, 400)); // D-A
            Assume.That(() => HasEdge(edges, 400, 400, 0, 800)); // A-E
            Assume.That(() => HasEdge(edges, 400, 200, 200, 0)); // B-F
            Assume.That(() => HasEdge(edges, 600, 200, 800, 0)); // C-G
            Assume.That(() => HasEdge(edges, 600, 400, 1000, 800)); // D-H
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 800)); // X-E
            Assume.That(() => HasEdge(edges, 0, 800, 0, 0)); // E-Y
            Assume.That(() => HasEdge(edges, 0, 0, 200, 0)); // Y-F
            Assume.That(() => HasEdge(edges, 200, 0, 800, 0)); // F-G
            Assume.That(() => HasEdge(edges, 800, 0, 1000, 0)); // G-W
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 800)); // W-H
            Assume.That(() => HasEdge(edges, 1000, 800, 1000, 1000)); // H-Z
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000)); // Z-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 400, 400, 400, 200); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 200, 600, 200))); // A-B neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 400, 400))); // A-B neighbours D-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 0, 800))); // A-B neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 200, 200, 0))); // A-B neighbours B-F
            edge = FindEdge(edges, 400, 200, 600, 200); // B-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 400, 200))); // B-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 200, 600, 400))); // B-C neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 200, 200, 0))); // B-C neighbours B-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 200, 800, 0))); // B-C neighbours C-G
            edge = FindEdge(edges, 600, 200, 600, 400); // C-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 200, 600, 200))); // C-D neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 400, 400))); // C-D neighbours D-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 200, 800, 0))); // C-D neighbours C-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 1000, 800))); // C-D neighbours D-H
            edge = FindEdge(edges, 600, 400, 400, 400); // D-A
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 400, 200))); // D-A neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 200, 600, 400))); // D-A neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 0, 800))); // D-A neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 1000, 800))); // D-A neighbours D-H
            edge = FindEdge(edges, 400, 400, 0, 800); // A-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 400, 200))); // A-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 400, 400))); // A-E neighbours D-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 800))); // A-E neighbours X-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 800, 0, 0))); // A-E neighbours E-Y
            edge = FindEdge(edges, 400, 200, 200, 0); // B-F
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 400, 200))); // B-F neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 200, 600, 200))); // B-F neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 200, 0))); // B-F neighbours Y-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 0, 800, 0))); // B-F neighbours F-G
            edge = FindEdge(edges, 600, 200, 800, 0); // C-G
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 200, 600, 200))); // C-G neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 200, 600, 400))); // C-G neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 0, 800, 0))); // C-G neighbours F-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 0, 1000, 0))); // C-G neighbours G-W
            edge = FindEdge(edges, 600, 400, 1000, 800); // D-H
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 200, 600, 400))); // D-H neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 400, 400))); // D-H neighbours D-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 800))); // D-H neighbours W-H
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 800, 1000, 1000))); // D-H neighbours H-Z
            edge = FindEdge(edges, 0, 1000, 0, 800); // X-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 0, 800))); // X-E neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 800, 0, 0))); // X-E neighbours E-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // X-E neighbours Z-X
            edge = FindEdge(edges, 0, 800, 0, 0); // E-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 0, 800))); // E-Y neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 800))); // E-Y neighbours X-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 200, 0))); // E-Y neighbours Y-F
            edge = FindEdge(edges, 0, 0, 200, 0); // Y-F
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 200, 200, 0))); // Y-F neighbours B-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 800, 0, 0))); // Y-F neighbours E-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 0, 800, 0))); // Y-F neighbours F-G
            edge = FindEdge(edges, 200, 0, 800, 0); // F-G
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 200, 200, 0))); // F-G neighbours B-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 200, 800, 0))); // F-G neighbours C-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 200, 0))); // F-G neighbours Y-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 0, 1000, 0))); // F-G neighbours G-W
            edge = FindEdge(edges, 800, 0, 1000, 0); // G-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 200, 800, 0))); // G-W neighbours C-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 0, 800, 0))); // G-W neighbours F-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 800))); // G-W neighbours W-H
            edge = FindEdge(edges, 1000, 0, 1000, 800); // W-H
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 1000, 800))); // W-H neighbours D-H
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 0, 1000, 0))); // W-H neighbours G-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 800, 1000, 1000))); // W-H neighbours H-Z
            edge = FindEdge(edges, 1000, 800, 1000, 1000); // H-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 1000, 800))); // H-Z neighbours D-H
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 800))); // H-Z neighbours W-H
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // H-Z neighbours Z-X
            edge = FindEdge(edges, 1000, 1000, 0, 1000); // Z-X
            Assert.NotNull(edge.Neighbours);
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

            Assume.That(() => 16 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 400, 600, 200, 600)); // A-B
            Assume.That(() => HasEdge(edges, 200, 600, 200, 400)); // B-C
            Assume.That(() => HasEdge(edges, 200, 400, 400, 400)); // C-D
            Assume.That(() => HasEdge(edges, 400, 400, 400, 600)); // D-A
            Assume.That(() => HasEdge(edges, 400, 600, 800, 1000)); // A-E
            Assume.That(() => HasEdge(edges, 200, 600, 0, 800)); // B-F
            Assume.That(() => HasEdge(edges, 200, 400, 0, 200)); // C-G
            Assume.That(() => HasEdge(edges, 400, 400, 800, 0)); // D-H
            Assume.That(() => HasEdge(edges, 1000, 1000, 800, 1000)); // X-E
            Assume.That(() => HasEdge(edges, 800, 1000, 0, 1000)); // E-Y
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 800)); // Y-F
            Assume.That(() => HasEdge(edges, 0, 800, 0, 200)); // F-G
            Assume.That(() => HasEdge(edges, 0, 200, 0, 0)); // G-W
            Assume.That(() => HasEdge(edges, 0, 0, 800, 0)); // W-H
            Assume.That(() => HasEdge(edges, 800, 0, 1000, 0)); // H-Z
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000)); // Z-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 400, 600, 200, 600); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 600, 200, 400))); // A-B neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 400, 600))); // A-B neighbours D-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 800, 1000))); // A-B neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 600, 0, 800))); // A-B neighbours B-F
            edge = FindEdge(edges, 200, 600, 200, 400); // B-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 200, 600))); // B-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 400, 400, 400))); // B-C neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 600, 0, 800))); // B-C neighbours B-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 400, 0, 200))); // B-C neighbours C-G
            edge = FindEdge(edges, 200, 400, 400, 400); // C-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 600, 200, 400))); // C-D neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 400, 600))); // C-D neighbours D-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 400, 0, 200))); // C-D neighbours C-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 800, 0))); // C-D neighbours D-H
            edge = FindEdge(edges, 400, 400, 400, 600); // D-A
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 200, 600))); // D-A neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 400, 400, 400))); // D-A neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 800, 1000))); // D-A neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 800, 0))); // D-A neighbours D-H
            edge = FindEdge(edges, 400, 600, 800, 1000); // A-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 200, 600))); // A-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 400, 600))); // A-E neighbours D-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 800, 1000))); // A-E neighbours X-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 1000, 0, 1000))); // A-E neighbours E-Y
            edge = FindEdge(edges, 200, 600, 0, 800); // B-F
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 200, 600))); // B-F neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 600, 200, 400))); // B-F neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 800))); // B-F neighbours Y-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 800, 0, 200))); // B-F neighbours F-G
            edge = FindEdge(edges, 200, 400, 0, 200); // C-G
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 600, 200, 400))); // C-G neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 400, 400, 400))); // C-G neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 800, 0, 200))); // C-G neighbours F-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 200, 0, 0))); // C-G neighbours G-W
            edge = FindEdge(edges, 400, 400, 800, 0); // D-H
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 400, 400, 400))); // D-H neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 400, 600))); // D-H neighbours D-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 800, 0))); // D-H neighbours W-H
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 0, 1000, 0))); // D-H neighbours H-Z
            edge = FindEdge(edges, 1000, 1000, 800, 1000); // X-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 800, 1000))); // X-E neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 1000, 0, 1000))); // X-E neighbours E-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // X-E neighbours Z-X
            edge = FindEdge(edges, 800, 1000, 0, 1000); // E-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 800, 1000))); // E-Y neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 800, 1000))); // E-Y neighbours X-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 800))); // E-Y neighbours Y-F
            edge = FindEdge(edges, 0, 1000, 0, 800); // Y-F
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 600, 0, 800))); // Y-F neighbours B-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 1000, 0, 1000))); // Y-F neighbours E-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 800, 0, 200))); // Y-F neighbours F-G
            edge = FindEdge(edges, 0, 800, 0, 200); // F-G
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 600, 0, 800))); // F-G neighbours B-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 400, 0, 200))); // F-G neighbours C-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 800))); // F-G neighbours Y-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 200, 0, 0))); // F-G neighbours G-W
            edge = FindEdge(edges, 0, 200, 0, 0); // G-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 400, 0, 200))); // G-W neighbours C-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 800, 0, 200))); // G-W neighbours F-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 800, 0))); // G-W neighbours W-H
            edge = FindEdge(edges, 0, 0, 800, 0); // W-H
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 800, 0))); // W-H neighbours D-H
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 200, 0, 0))); // W-H neighbours G-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 0, 1000, 0))); // W-H neighbours H-Z
            edge = FindEdge(edges, 800, 0, 1000, 0); // H-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 800, 0))); // H-Z neighbours D-H
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 800, 0))); // H-Z neighbours W-H
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // H-Z neighbours Z-X
            edge = FindEdge(edges, 1000, 0, 1000, 1000); // Z-X
            Assert.NotNull(edge.Neighbours);
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

            Assume.That(() => 16 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 600, 600, 600, 800)); // A-B
            Assume.That(() => HasEdge(edges, 600, 800, 400, 800)); // B-C
            Assume.That(() => HasEdge(edges, 400, 800, 400, 600)); // C-D
            Assume.That(() => HasEdge(edges, 400, 600, 600, 600)); // D-A
            Assume.That(() => HasEdge(edges, 600, 600, 1000, 200)); // A-E
            Assume.That(() => HasEdge(edges, 600, 800, 800, 1000)); // B-F
            Assume.That(() => HasEdge(edges, 400, 800, 200, 1000)); // C-G
            Assume.That(() => HasEdge(edges, 400, 600, 0, 200)); // D-H
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 200)); // X-E
            Assume.That(() => HasEdge(edges, 1000, 200, 1000, 1000)); // E-Y
            Assume.That(() => HasEdge(edges, 1000, 1000, 800, 1000)); // Y-F
            Assume.That(() => HasEdge(edges, 800, 1000, 200, 1000)); // F-G
            Assume.That(() => HasEdge(edges, 200, 1000, 0, 1000)); // G-W
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 200)); // W-H
            Assume.That(() => HasEdge(edges, 0, 200, 0, 0)); // H-Z
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0)); // Z-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 600, 600, 600, 800); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 800, 400, 800))); // A-B neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 600, 600))); // A-B neighbours D-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 1000, 200))); // A-B neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 800, 800, 1000))); // A-B neighbours B-F
            edge = FindEdge(edges, 600, 800, 400, 800); // B-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 600, 800))); // B-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 800, 400, 600))); // B-C neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 800, 800, 1000))); // B-C neighbours B-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 800, 200, 1000))); // B-C neighbours C-G
            edge = FindEdge(edges, 400, 800, 400, 600); // C-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 800, 400, 800))); // C-D neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 600, 600))); // C-D neighbours D-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 800, 200, 1000))); // C-D neighbours C-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 0, 200))); // C-D neighbours D-H
            edge = FindEdge(edges, 400, 600, 600, 600); // D-A
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 600, 800))); // D-A neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 800, 400, 600))); // D-A neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 1000, 200))); // D-A neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 0, 200))); // D-A neighbours D-H
            edge = FindEdge(edges, 600, 600, 1000, 200); // A-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 600, 800))); // A-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 600, 600))); // A-E neighbours D-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 200))); // A-E neighbours X-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 200, 1000, 1000))); // A-E neighbours E-Y
            edge = FindEdge(edges, 600, 800, 800, 1000); // B-F
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 600, 800))); // B-F neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 800, 400, 800))); // B-F neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 800, 1000))); // B-F neighbours Y-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 1000, 200, 1000))); // B-F neighbours F-G
            edge = FindEdge(edges, 400, 800, 200, 1000); // C-G
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 800, 400, 800))); // C-G neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 800, 400, 600))); // C-G neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 1000, 200, 1000))); // C-G neighbours F-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 1000, 0, 1000))); // C-G neighbours G-W
            edge = FindEdge(edges, 400, 600, 0, 200); // D-H
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 800, 400, 600))); // D-H neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 600, 600))); // D-H neighbours D-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 200))); // D-H neighbours W-H
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 200, 0, 0))); // D-H neighbours H-Z
            edge = FindEdge(edges, 1000, 0, 1000, 200); // X-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 1000, 200))); // X-E neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 200, 1000, 1000))); // X-E neighbours E-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // X-E neighbours Z-X
            edge = FindEdge(edges, 1000, 200, 1000, 1000); // E-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 1000, 200))); // E-Y neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 200))); // E-Y neighbours X-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 800, 1000))); // E-Y neighbours Y-F
            edge = FindEdge(edges, 1000, 1000, 800, 1000); // Y-F
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 800, 800, 1000))); // Y-F neighbours B-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 200, 1000, 1000))); // Y-F neighbours E-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 1000, 200, 1000))); // Y-F neighbours F-G
            edge = FindEdge(edges, 800, 1000, 200, 1000); // F-G
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 800, 800, 1000))); // F-G neighbours B-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 800, 200, 1000))); // F-G neighbours C-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 800, 1000))); // F-G neighbours Y-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 1000, 0, 1000))); // F-G neighbours G-W
            edge = FindEdge(edges, 200, 1000, 0, 1000); // G-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 800, 200, 1000))); // G-W neighbours C-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 1000, 200, 1000))); // G-W neighbours F-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 200))); // G-W neighbours W-H
            edge = FindEdge(edges, 0, 1000, 0, 200); // W-H
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 0, 200))); // W-H neighbours D-H
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 1000, 0, 1000))); // W-H neighbours G-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 200, 0, 0))); // W-H neighbours H-Z
            edge = FindEdge(edges, 0, 200, 0, 0); // H-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 0, 200))); // H-Z neighbours D-H
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 200))); // H-Z neighbours W-H
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // H-Z neighbours Z-X
            edge = FindEdge(edges, 0, 0, 1000, 0); // Z-X
            Assert.NotNull(edge.Neighbours);
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

            Assume.That(() => 16 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 600, 400, 800, 400)); // A-B
            Assume.That(() => HasEdge(edges, 800, 400, 800, 600)); // B-C
            Assume.That(() => HasEdge(edges, 800, 600, 600, 600)); // C-D
            Assume.That(() => HasEdge(edges, 600, 600, 600, 400)); // D-A
            Assume.That(() => HasEdge(edges, 600, 400, 200, 0)); // A-E
            Assume.That(() => HasEdge(edges, 800, 400, 1000, 200)); // B-F
            Assume.That(() => HasEdge(edges, 800, 600, 1000, 800)); // C-G
            Assume.That(() => HasEdge(edges, 600, 600, 200, 1000)); // D-H
            Assume.That(() => HasEdge(edges, 0, 0, 200, 0)); // X-E
            Assume.That(() => HasEdge(edges, 200, 0, 1000, 0)); // E-Y
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 200)); // Y-F
            Assume.That(() => HasEdge(edges, 1000, 200, 1000, 800)); // F-G
            Assume.That(() => HasEdge(edges, 1000, 800, 1000, 1000)); // G-W
            Assume.That(() => HasEdge(edges, 1000, 1000, 200, 1000)); // W-H
            Assume.That(() => HasEdge(edges, 200, 1000, 0, 1000)); // H-Z
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0)); // Z-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 600, 400, 800, 400); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 400, 800, 600))); // A-B neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 600, 400))); // A-B neighbours D-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 200, 0))); // A-B neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 400, 1000, 200))); // A-B neighbours B-F
            edge = FindEdge(edges, 800, 400, 800, 600); // B-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 800, 400))); // B-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 600, 600, 600))); // B-C neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 400, 1000, 200))); // B-C neighbours B-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 600, 1000, 800))); // B-C neighbours C-G
            edge = FindEdge(edges, 800, 600, 600, 600); // C-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 400, 800, 600))); // C-D neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 600, 400))); // C-D neighbours D-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 600, 1000, 800))); // C-D neighbours C-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 200, 1000))); // C-D neighbours D-H
            edge = FindEdge(edges, 600, 600, 600, 400); // D-A
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 800, 400))); // D-A neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 600, 600, 600))); // D-A neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 200, 0))); // D-A neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 200, 1000))); // D-A neighbours D-H
            edge = FindEdge(edges, 600, 400, 200, 0); // A-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 800, 400))); // A-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 600, 400))); // A-E neighbours D-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 200, 0))); // A-E neighbours X-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 0, 1000, 0))); // A-E neighbours E-Y
            edge = FindEdge(edges, 800, 400, 1000, 200); // B-F
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 800, 400))); // B-F neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 400, 800, 600))); // B-F neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 200))); // B-F neighbours Y-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 200, 1000, 800))); // B-F neighbours F-G
            edge = FindEdge(edges, 800, 600, 1000, 800); // C-G
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 400, 800, 600))); // C-G neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 600, 600, 600))); // C-G neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 200, 1000, 800))); // C-G neighbours F-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 800, 1000, 1000))); // C-G neighbours G-W
            edge = FindEdge(edges, 600, 600, 200, 1000); // D-H
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 600, 600, 600))); // D-H neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 600, 400))); // D-H neighbours D-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 200, 1000))); // D-H neighbours W-H
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 1000, 0, 1000))); // D-H neighbours H-Z
            edge = FindEdge(edges, 0, 0, 200, 0); // X-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 200, 0))); // X-E neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 0, 1000, 0))); // X-E neighbours E-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // X-E neighbours Z-X
            edge = FindEdge(edges, 200, 0, 1000, 0); // E-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 200, 0))); // E-Y neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 200, 0))); // E-Y neighbours X-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 200))); // E-Y neighbours Y-F
            edge = FindEdge(edges, 1000, 0, 1000, 200); // Y-F
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 400, 1000, 200))); // Y-F neighbours B-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 0, 1000, 0))); // Y-F neighbours E-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 200, 1000, 800))); // Y-F neighbours F-G
            edge = FindEdge(edges, 1000, 200, 1000, 800); // F-G
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 400, 1000, 200))); // F-G neighbours B-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 600, 1000, 800))); // F-G neighbours C-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 200))); // F-G neighbours Y-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 800, 1000, 1000))); // F-G neighbours G-W
            edge = FindEdge(edges, 1000, 800, 1000, 1000); // G-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 600, 1000, 800))); // G-W neighbours C-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 200, 1000, 800))); // G-W neighbours F-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 200, 1000))); // G-W neighbours W-H
            edge = FindEdge(edges, 1000, 1000, 200, 1000); // W-H
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 200, 1000))); // W-H neighbours D-H
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 800, 1000, 1000))); // W-H neighbours G-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 1000, 0, 1000))); // W-H neighbours H-Z
            edge = FindEdge(edges, 200, 1000, 0, 1000); // H-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 200, 1000))); // H-Z neighbours D-H
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 200, 1000))); // H-Z neighbours W-H
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // H-Z neighbours Z-X
            edge = FindEdge(edges, 0, 1000, 0, 0); // Z-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 200, 0))); // Z-X neighbours X-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 1000, 0, 1000))); // Z-X neighbours H-Z
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

            Assume.That(() => 12 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 500, 500, 500, 1000)); // A-B
            Assume.That(() => HasEdge(edges, 500, 500, 0, 500)); // A-C
            Assume.That(() => HasEdge(edges, 500, 500, 500, 0)); // A-D
            Assume.That(() => HasEdge(edges, 500, 500, 1000, 500)); // A-E
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 500)); // X-C
            Assume.That(() => HasEdge(edges, 0, 500, 0, 0)); // C-Y
            Assume.That(() => HasEdge(edges, 0, 0, 500, 0)); // Y-D
            Assume.That(() => HasEdge(edges, 500, 0, 1000, 0)); // D-W
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 500)); // W-E
            Assume.That(() => HasEdge(edges, 1000, 500, 1000, 1000)); // E-Z
            Assume.That(() => HasEdge(edges, 1000, 1000, 500, 1000)); // Z-B
            Assume.That(() => HasEdge(edges, 500, 1000, 0, 1000)); // B-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 500, 500, 500, 1000); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 500))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 0))); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 500))); // A-B neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 500, 1000))); // A-B neighbours Z-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 1000, 0, 1000))); // A-B neighbours B-X
            edge = FindEdge(edges, 500, 500, 0, 500); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 1000))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 0))); // A-C neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 500))); // A-C neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 500))); // A-C neighbours X-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 0, 0))); // A-C neighbours C-Y
            edge = FindEdge(edges, 500, 500, 500, 0); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 1000))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 500))); // A-D neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 500))); // A-D neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 500, 0))); // A-D neighbours Y-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 0, 1000, 0))); // A-D neighbours D-W
            edge = FindEdge(edges, 500, 500, 1000, 500); // A-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 1000))); // A-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 500))); // A-E neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 0))); // A-E neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 500))); // A-E neighbours W-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 500, 1000, 1000))); // A-E neighbours E-Z
            edge = FindEdge(edges, 0, 1000, 0, 500); // X-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 500))); // X-C neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 0, 0))); // X-C neighbours C-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 1000, 0, 1000))); // X-C neighbours B-X
            edge = FindEdge(edges, 0, 500, 0, 0); // C-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 500))); // C-Y neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 500))); // C-Y neighbours X-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 500, 0))); // C-Y neighbours Y-D
            edge = FindEdge(edges, 0, 0, 500, 0); // Y-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 0))); // Y-D neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 0, 0))); // Y-D neighbours C-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 0, 1000, 0))); // Y-D neighbours D-W
            edge = FindEdge(edges, 500, 0, 1000, 0); // D-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 0))); // D-W neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 500, 0))); // D-W neighbours Y-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 500))); // D-W neighbours W-E
            edge = FindEdge(edges, 1000, 0, 1000, 500); // W-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 500))); // W-E neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 0, 1000, 0))); // W-E neighbours D-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 500, 1000, 1000))); // W-E neighbours E-Z
            edge = FindEdge(edges, 1000, 500, 1000, 1000); // E-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 500))); // E-Z neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 500))); // E-Z neighbours W-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 500, 1000))); // E-Z neighbours Z-B
            edge = FindEdge(edges, 1000, 1000, 500, 1000); // Z-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 1000))); // Z-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 500, 1000, 1000))); // Z-B neighbours E-Z
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 1000, 0, 1000))); // Z-B neighbours B-X
            edge = FindEdge(edges, 500, 1000, 0, 1000); // B-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 1000))); // B-X neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 500))); // B-X neighbours X-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 500, 1000))); // B-X neighbours Z-B
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

            Assume.That(() => 12 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 500, 500, 500, 1000)); // A-B
            Assume.That(() => HasEdge(edges, 500, 500, 0, 500)); // A-C
            Assume.That(() => HasEdge(edges, 500, 500, 500, 0)); // A-D
            Assume.That(() => HasEdge(edges, 500, 500, 1000, 500)); // A-E
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 500)); // X-C
            Assume.That(() => HasEdge(edges, 0, 500, 0, 0)); // C-Y
            Assume.That(() => HasEdge(edges, 0, 0, 500, 0)); // Y-D
            Assume.That(() => HasEdge(edges, 500, 0, 1000, 0)); // D-W
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 500)); // W-E
            Assume.That(() => HasEdge(edges, 1000, 500, 1000, 1000)); // E-Z
            Assume.That(() => HasEdge(edges, 1000, 1000, 500, 1000)); // Z-B
            Assume.That(() => HasEdge(edges, 500, 1000, 0, 1000)); // B-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 500, 500, 500, 1000); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 500))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 0))); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 500))); // A-B neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 500, 1000))); // A-B neighbours Z-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 1000, 0, 1000))); // A-B neighbours B-X
            edge = FindEdge(edges, 500, 500, 0, 500); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 1000))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 0))); // A-C neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 500))); // A-C neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 500))); // A-C neighbours X-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 0, 0))); // A-C neighbours C-Y
            edge = FindEdge(edges, 500, 500, 500, 0); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 1000))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 500))); // A-D neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 500))); // A-D neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 500, 0))); // A-D neighbours Y-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 0, 1000, 0))); // A-D neighbours D-W
            edge = FindEdge(edges, 500, 500, 1000, 500); // A-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 1000))); // A-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 500))); // A-E neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 0))); // A-E neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 500))); // A-E neighbours W-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 500, 1000, 1000))); // A-E neighbours E-Z
            edge = FindEdge(edges, 0, 1000, 0, 500); // X-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 500))); // X-C neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 0, 0))); // X-C neighbours C-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 1000, 0, 1000))); // X-C neighbours B-X
            edge = FindEdge(edges, 0, 500, 0, 0); // C-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 500))); // C-Y neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 500))); // C-Y neighbours X-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 500, 0))); // C-Y neighbours Y-D
            edge = FindEdge(edges, 0, 0, 500, 0); // Y-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 0))); // Y-D neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 0, 0))); // Y-D neighbours C-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 0, 1000, 0))); // Y-D neighbours D-W
            edge = FindEdge(edges, 500, 0, 1000, 0); // D-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 0))); // D-W neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 500, 0))); // D-W neighbours Y-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 500))); // D-W neighbours W-E
            edge = FindEdge(edges, 1000, 0, 1000, 500); // W-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 500))); // W-E neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 0, 1000, 0))); // W-E neighbours D-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 500, 1000, 1000))); // W-E neighbours E-Z
            edge = FindEdge(edges, 1000, 500, 1000, 1000); // E-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 500))); // E-Z neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 500))); // E-Z neighbours W-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 500, 1000))); // E-Z neighbours Z-B
            edge = FindEdge(edges, 1000, 1000, 500, 1000); // Z-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 1000))); // Z-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 500, 1000, 1000))); // Z-B neighbours E-Z
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 1000, 0, 1000))); // Z-B neighbours B-X
            edge = FindEdge(edges, 500, 1000, 0, 1000); // B-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 1000))); // B-X neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 500))); // B-X neighbours X-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 500, 1000))); // B-X neighbours Z-B
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

            Assume.That(() => 12 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 500, 500, 1000, 500)); // A-B
            Assume.That(() => HasEdge(edges, 500, 500, 500, 1000)); // A-C
            Assume.That(() => HasEdge(edges, 500, 500, 0, 500)); // A-D
            Assume.That(() => HasEdge(edges, 500, 500, 500, 0)); // A-E
            Assume.That(() => HasEdge(edges, 1000, 1000, 500, 1000)); // X-C
            Assume.That(() => HasEdge(edges, 500, 1000, 0, 1000)); // C-Y
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 500)); // Y-D
            Assume.That(() => HasEdge(edges, 0, 500, 0, 0)); // D-W
            Assume.That(() => HasEdge(edges, 0, 0, 500, 0)); // W-E
            Assume.That(() => HasEdge(edges, 500, 0, 1000, 0)); // E-Z
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 500)); // Z-B
            Assume.That(() => HasEdge(edges, 1000, 500, 1000, 1000)); // B-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 500, 500, 1000, 500); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 1000))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 500))); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 0))); // A-B neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 500))); // A-B neighbours Z-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 500, 1000, 1000))); // A-B neighbours B-X
            edge = FindEdge(edges, 500, 500, 500, 1000); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 500))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 500))); // A-C neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 0))); // A-C neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 500, 1000))); // A-C neighbours X-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 1000, 0, 1000))); // A-C neighbours C-Y
            edge = FindEdge(edges, 500, 500, 0, 500); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 500))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 1000))); // A-D neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 0))); // A-D neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 500))); // A-D neighbours Y-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 0, 0))); // A-D neighbours D-W
            edge = FindEdge(edges, 500, 500, 500, 0); // A-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 500))); // A-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 1000))); // A-E neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 500))); // A-E neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 500, 0))); // A-E neighbours W-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 0, 1000, 0))); // A-E neighbours E-Z
            edge = FindEdge(edges, 1000, 1000, 500, 1000); // X-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 1000))); // X-C neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 1000, 0, 1000))); // X-C neighbours C-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 500, 1000, 1000))); // X-C neighbours B-X
            edge = FindEdge(edges, 500, 1000, 0, 1000); // C-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 1000))); // C-Y neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 500, 1000))); // C-Y neighbours X-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 500))); // C-Y neighbours Y-D
            edge = FindEdge(edges, 0, 1000, 0, 500); // Y-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 500))); // Y-D neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 1000, 0, 1000))); // Y-D neighbours C-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 0, 0))); // Y-D neighbours D-W
            edge = FindEdge(edges, 0, 500, 0, 0); // D-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 500))); // D-W neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 500))); // D-W neighbours Y-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 500, 0))); // D-W neighbours W-E
            edge = FindEdge(edges, 0, 0, 500, 0); // W-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 0))); // W-E neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 0, 0))); // W-E neighbours D-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 0, 1000, 0))); // W-E neighbours E-Z
            edge = FindEdge(edges, 500, 0, 1000, 0); // E-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 0))); // E-Z neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 500, 0))); // E-Z neighbours W-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 500))); // E-Z neighbours Z-B
            edge = FindEdge(edges, 1000, 0, 1000, 500); // Z-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 500))); // Z-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 0, 1000, 0))); // Z-B neighbours E-Z
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 500, 1000, 1000))); // Z-B neighbours B-X
            edge = FindEdge(edges, 1000, 500, 1000, 1000); // B-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 500))); // B-X neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 500, 1000))); // B-X neighbours X-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 500))); // B-X neighbours Z-B
        }

        [Test]
        public void FourEquidistantPointsInAKiteAroundMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 700), // #1
                new VoronoiSite(700, 500), // #2
                new VoronoiSite(500, 300), // #3
                new VoronoiSite(300, 500), // #4
            };

            // 1000 B#-----------------------------------------------#E
            //      | ',                                           ,' |
            //  900 |   '·,                                     ,·'   |
            //      |      ',                                 ,'      |
            //  800 |        '·,                           ,·'        |
            //      |           ',                       ,'           |
            //  700 |             '·,        1        ,·'             |
            //      |                ',             ,'                |
            //  600 |                  '·,       ,·'                  |
            //      |                     ',   ,'                     |
            //  500 |              4        #A#        2              |
            //      |                     ,'   ',                     |
            //  400 |                  ,·'       '·,                  |
            //      |                ,'             ',                |
            //  300 |             ,·'        3        '·,             |
            //      |           ,'                       ',           |
            //  200 |        ,·'                           '·,        |
            //      |      ,'                                 ',      |
            //  100 |   ,·'                                     '·,   |
            //      | ,'                                           ', |
            //    0 C#-----------------------------------------------#D
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 8 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 500, 500, 0, 1000)); // A-B
            Assume.That(() => HasEdge(edges, 500, 500, 0, 0)); // A-C
            Assume.That(() => HasEdge(edges, 500, 500, 1000, 0)); // A-D
            Assume.That(() => HasEdge(edges, 500, 500, 1000, 1000)); // A-E
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0)); // B-C
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0)); // C-D
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000)); // D-E
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000)); // E-B

            // Assert

            VoronoiEdge edge = FindEdge(edges, 500, 500, 0, 1000); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 0))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 0))); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 1000))); // A-B neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // A-B neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // A-B neighbours E-B
            edge = FindEdge(edges, 500, 500, 0, 0); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 1000))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 0))); // A-C neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 1000))); // A-C neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // A-C neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // A-C neighbours C-D
            edge = FindEdge(edges, 500, 500, 1000, 0); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 1000))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 0))); // A-D neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 1000))); // A-D neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // A-D neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // A-D neighbours D-E
            edge = FindEdge(edges, 500, 500, 1000, 1000); // A-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 1000))); // A-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 0))); // A-E neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 0))); // A-E neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // A-E neighbours D-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // A-E neighbours E-B
            edge = FindEdge(edges, 0, 1000, 0, 0); // B-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 1000))); // B-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 0))); // B-C neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // B-C neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // B-C neighbours E-B
            edge = FindEdge(edges, 0, 0, 1000, 0); // C-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 0))); // C-D neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 0))); // C-D neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // C-D neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // C-D neighbours D-E
            edge = FindEdge(edges, 1000, 0, 1000, 1000); // D-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 0))); // D-E neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 1000))); // D-E neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 1000, 0))); // D-E neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // D-E neighbours E-B
            edge = FindEdge(edges, 1000, 1000, 0, 1000); // E-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 1000))); // E-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 1000))); // E-B neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 0))); // E-B neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // E-B neighbours D-E
        }

        [Test]
        public void FourEquidistantPointsInARotatedSquareOffset()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(100, 500), // #1
                new VoronoiSite(300, 100), // #2
                new VoronoiSite(700, 300), // #3
                new VoronoiSite(500, 700), // #4
            };

            // 1000 X----B--------------------------------------------Z
            //      |     '                                           |
            //  900 |      ',                                         |
            //      |        ,                                        |
            //  800 |         ·                                       |
            //      |          '                                      |
            //  700 |           ',           4                      ,,E
            //      |             ,                            ,,·''  |
            //  600 |              ·                      ,,·''       |
            //      |               '                ,,·''            |
            //  500 |    1           ',         ,,·''                 |
            //      |                  ,   ,,·''                      |
            //  400 |                 ,,A''                           |
            //      |            ,,·''   '                            |
            //  300 |       ,,·''         ',           3              |
            //      |  ,,·''                ,                         |
            //  200 C''                      ·                        |
            //      |                         '                       |
            //  100 |              2           ',                     |
            //      |                            ,                    |
            //    0 Y-----------------------------D-------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 12 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 400, 400, 100, 1000)); // A-B
            Assume.That(() => HasEdge(edges, 400, 400, 0, 200)); // A-C
            Assume.That(() => HasEdge(edges, 400, 400, 600, 0)); // A-D
            Assume.That(() => HasEdge(edges, 400, 400, 1000, 700)); // A-E
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 200)); // X-C
            Assume.That(() => HasEdge(edges, 0, 200, 0, 0)); // C-Y
            Assume.That(() => HasEdge(edges, 0, 0, 600, 0)); // Y-D
            Assume.That(() => HasEdge(edges, 600, 0, 1000, 0)); // D-W
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 700)); // W-E
            Assume.That(() => HasEdge(edges, 1000, 700, 1000, 1000)); // E-Z
            Assume.That(() => HasEdge(edges, 1000, 1000, 100, 1000)); // Z-B
            Assume.That(() => HasEdge(edges, 100, 1000, 0, 1000)); // B-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 400, 400, 100, 1000); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 0, 200))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 600, 0))); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 1000, 700))); // A-B neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 100, 1000))); // A-B neighbours Z-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 100, 1000, 0, 1000))); // A-B neighbours B-X
            edge = FindEdge(edges, 400, 400, 0, 200); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 100, 1000))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 600, 0))); // A-C neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 1000, 700))); // A-C neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 200))); // A-C neighbours X-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 200, 0, 0))); // A-C neighbours C-Y
            edge = FindEdge(edges, 400, 400, 600, 0); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 100, 1000))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 0, 200))); // A-D neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 1000, 700))); // A-D neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 600, 0))); // A-D neighbours Y-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 0, 1000, 0))); // A-D neighbours D-W
            edge = FindEdge(edges, 400, 400, 1000, 700); // A-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 100, 1000))); // A-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 0, 200))); // A-E neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 600, 0))); // A-E neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 700))); // A-E neighbours W-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 700, 1000, 1000))); // A-E neighbours E-Z
            edge = FindEdge(edges, 0, 1000, 0, 200); // X-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 0, 200))); // X-C neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 200, 0, 0))); // X-C neighbours C-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 100, 1000, 0, 1000))); // X-C neighbours B-X
            edge = FindEdge(edges, 0, 200, 0, 0); // C-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 0, 200))); // C-Y neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 200))); // C-Y neighbours X-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 600, 0))); // C-Y neighbours Y-D
            edge = FindEdge(edges, 0, 0, 600, 0); // Y-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 600, 0))); // Y-D neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 200, 0, 0))); // Y-D neighbours C-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 0, 1000, 0))); // Y-D neighbours D-W
            edge = FindEdge(edges, 600, 0, 1000, 0); // D-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 600, 0))); // D-W neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 600, 0))); // D-W neighbours Y-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 700))); // D-W neighbours W-E
            edge = FindEdge(edges, 1000, 0, 1000, 700); // W-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 1000, 700))); // W-E neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 0, 1000, 0))); // W-E neighbours D-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 700, 1000, 1000))); // W-E neighbours E-Z
            edge = FindEdge(edges, 1000, 700, 1000, 1000); // E-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 1000, 700))); // E-Z neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 700))); // E-Z neighbours W-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 100, 1000))); // E-Z neighbours Z-B
            edge = FindEdge(edges, 1000, 1000, 100, 1000); // Z-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 100, 1000))); // Z-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 700, 1000, 1000))); // Z-B neighbours E-Z
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 100, 1000, 0, 1000))); // Z-B neighbours B-X
            edge = FindEdge(edges, 100, 1000, 0, 1000); // B-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 100, 1000))); // B-X neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 200))); // B-X neighbours X-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 100, 1000))); // B-X neighbours Z-B
        }

        /// <summary>
        /// This test basically repeats <see cref="FourEquidistantPointsInARotatedSquareOffset"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void FourEquidistantPointsInARotatedSquareOffset_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 900), // #1
                new VoronoiSite(100, 700), // #2
                new VoronoiSite(300, 300), // #3
                new VoronoiSite(700, 500), // #4
            };

            // 1000 Y---------C---------------------------------------X
            //      |          '                                      |
            //  900 |           ',           1                      ,,B
            //      |             ,                            ,,·''  |
            //  800 |              ·                      ,,·''       |
            //      |               '                ,,·''            |
            //  700 |    2           ',         ,,·''                 |
            //      |                  ,   ,,·''                      |
            //  600 |                 ,,A''                           |
            //      |            ,,·''   '                            |
            //  500 |       ,,·''         ',           4              |
            //      |  ,,·''                ,                         |
            //  400 D''                      ·                        |
            //      |                         '                       |
            //  300 |              3           ',                     |
            //      |                            ,                    |
            //  200 |                             ·                   |
            //      |                              '                  |
            //  100 |                               ',                |
            //      |                                 ,               |
            //    0 W----------------------------------E--------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 12 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 400, 600, 1000, 900)); // A-B
            Assume.That(() => HasEdge(edges, 400, 600, 200, 1000)); // A-C
            Assume.That(() => HasEdge(edges, 400, 600, 0, 400)); // A-D
            Assume.That(() => HasEdge(edges, 400, 600, 700, 0)); // A-E
            Assume.That(() => HasEdge(edges, 1000, 1000, 200, 1000)); // X-C
            Assume.That(() => HasEdge(edges, 200, 1000, 0, 1000)); // C-Y
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 400)); // Y-D
            Assume.That(() => HasEdge(edges, 0, 400, 0, 0)); // D-W
            Assume.That(() => HasEdge(edges, 0, 0, 700, 0)); // W-E
            Assume.That(() => HasEdge(edges, 700, 0, 1000, 0)); // E-Z
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 900)); // Z-B
            Assume.That(() => HasEdge(edges, 1000, 900, 1000, 1000)); // B-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 400, 600, 1000, 900); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 200, 1000))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 0, 400))); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 700, 0))); // A-B neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 900))); // A-B neighbours Z-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 900, 1000, 1000))); // A-B neighbours B-X
            edge = FindEdge(edges, 400, 600, 200, 1000); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 1000, 900))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 0, 400))); // A-C neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 700, 0))); // A-C neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 200, 1000))); // A-C neighbours X-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 1000, 0, 1000))); // A-C neighbours C-Y
            edge = FindEdge(edges, 400, 600, 0, 400); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 1000, 900))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 200, 1000))); // A-D neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 700, 0))); // A-D neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 400))); // A-D neighbours Y-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 400, 0, 0))); // A-D neighbours D-W
            edge = FindEdge(edges, 400, 600, 700, 0); // A-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 1000, 900))); // A-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 200, 1000))); // A-E neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 0, 400))); // A-E neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 700, 0))); // A-E neighbours W-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 0, 1000, 0))); // A-E neighbours E-Z
            edge = FindEdge(edges, 1000, 1000, 200, 1000); // X-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 200, 1000))); // X-C neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 1000, 0, 1000))); // X-C neighbours C-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 900, 1000, 1000))); // X-C neighbours B-X
            edge = FindEdge(edges, 200, 1000, 0, 1000); // C-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 200, 1000))); // C-Y neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 200, 1000))); // C-Y neighbours X-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 400))); // C-Y neighbours Y-D
            edge = FindEdge(edges, 0, 1000, 0, 400); // Y-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 0, 400))); // Y-D neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 1000, 0, 1000))); // Y-D neighbours C-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 400, 0, 0))); // Y-D neighbours D-W
            edge = FindEdge(edges, 0, 400, 0, 0); // D-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 0, 400))); // D-W neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 400))); // D-W neighbours Y-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 700, 0))); // D-W neighbours W-E
            edge = FindEdge(edges, 0, 0, 700, 0); // W-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 700, 0))); // W-E neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 400, 0, 0))); // W-E neighbours D-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 0, 1000, 0))); // W-E neighbours E-Z
            edge = FindEdge(edges, 700, 0, 1000, 0); // E-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 700, 0))); // E-Z neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 700, 0))); // E-Z neighbours W-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 900))); // E-Z neighbours Z-B
            edge = FindEdge(edges, 1000, 0, 1000, 900); // Z-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 1000, 900))); // Z-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 0, 1000, 0))); // Z-B neighbours E-Z
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 900, 1000, 1000))); // Z-B neighbours B-X
            edge = FindEdge(edges, 1000, 900, 1000, 1000); // B-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 1000, 900))); // B-X neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 200, 1000))); // B-X neighbours X-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 900))); // B-X neighbours Z-B
        }

        /// <summary>
        /// This test basically repeats <see cref="FourEquidistantPointsInARotatedSquareOffset"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void FourEquidistantPointsInARotatedSquareOffset_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(900, 500), // #1
                new VoronoiSite(700, 900), // #2
                new VoronoiSite(300, 700), // #3
                new VoronoiSite(500, 300), // #4
            };

            // 1000 W-------------------D-----------------------------Y
            //      |                    '                            |
            //  900 |                     ',           2              |
            //      |                       ,                         |
            //  800 |                        ·                      ,,C
            //      |                         '                ,,·''  |
            //  700 |              3           ',         ,,·''       |
            //      |                            ,   ,,·''            |
            //  600 |                           ,,A''                 |
            //      |                      ,,·''   '                  |
            //  500 |                 ,,·''         ',           1    |
            //      |            ,,·''                ,               |
            //  400 |       ,,·''                      ·              |
            //      |  ,,·''                            '             |
            //  300 E''                      4           ',           |
            //      |                                      ,          |
            //  200 |                                       ·         |
            //      |                                        '        |
            //  100 |                                         ',      |
            //      |                                           ,     |
            //    0 Z--------------------------------------------B----X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 12 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 600, 600, 900, 0)); // A-B
            Assume.That(() => HasEdge(edges, 600, 600, 1000, 800)); // A-C
            Assume.That(() => HasEdge(edges, 600, 600, 400, 1000)); // A-D
            Assume.That(() => HasEdge(edges, 600, 600, 0, 300)); // A-E
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 800)); // X-C
            Assume.That(() => HasEdge(edges, 1000, 800, 1000, 1000)); // C-Y
            Assume.That(() => HasEdge(edges, 1000, 1000, 400, 1000)); // Y-D
            Assume.That(() => HasEdge(edges, 400, 1000, 0, 1000)); // D-W
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 300)); // W-E
            Assume.That(() => HasEdge(edges, 0, 300, 0, 0)); // E-Z
            Assume.That(() => HasEdge(edges, 0, 0, 900, 0)); // Z-B
            Assume.That(() => HasEdge(edges, 900, 0, 1000, 0)); // B-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 600, 600, 900, 0); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 1000, 800))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 400, 1000))); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 0, 300))); // A-B neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 900, 0))); // A-B neighbours Z-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 900, 0, 1000, 0))); // A-B neighbours B-X
            edge = FindEdge(edges, 600, 600, 1000, 800); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 900, 0))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 400, 1000))); // A-C neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 0, 300))); // A-C neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 800))); // A-C neighbours X-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 800, 1000, 1000))); // A-C neighbours C-Y
            edge = FindEdge(edges, 600, 600, 400, 1000); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 900, 0))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 1000, 800))); // A-D neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 0, 300))); // A-D neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 400, 1000))); // A-D neighbours Y-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 1000, 0, 1000))); // A-D neighbours D-W
            edge = FindEdge(edges, 600, 600, 0, 300); // A-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 900, 0))); // A-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 1000, 800))); // A-E neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 400, 1000))); // A-E neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 300))); // A-E neighbours W-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 300, 0, 0))); // A-E neighbours E-Z
            edge = FindEdge(edges, 1000, 0, 1000, 800); // X-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 1000, 800))); // X-C neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 800, 1000, 1000))); // X-C neighbours C-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 900, 0, 1000, 0))); // X-C neighbours B-X
            edge = FindEdge(edges, 1000, 800, 1000, 1000); // C-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 1000, 800))); // C-Y neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 800))); // C-Y neighbours X-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 400, 1000))); // C-Y neighbours Y-D
            edge = FindEdge(edges, 1000, 1000, 400, 1000); // Y-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 400, 1000))); // Y-D neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 800, 1000, 1000))); // Y-D neighbours C-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 1000, 0, 1000))); // Y-D neighbours D-W
            edge = FindEdge(edges, 400, 1000, 0, 1000); // D-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 400, 1000))); // D-W neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 400, 1000))); // D-W neighbours Y-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 300))); // D-W neighbours W-E
            edge = FindEdge(edges, 0, 1000, 0, 300); // W-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 0, 300))); // W-E neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 1000, 0, 1000))); // W-E neighbours D-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 300, 0, 0))); // W-E neighbours E-Z
            edge = FindEdge(edges, 0, 300, 0, 0); // E-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 0, 300))); // E-Z neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 300))); // E-Z neighbours W-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 900, 0))); // E-Z neighbours Z-B
            edge = FindEdge(edges, 0, 0, 900, 0); // Z-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 900, 0))); // Z-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 300, 0, 0))); // Z-B neighbours E-Z
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 900, 0, 1000, 0))); // Z-B neighbours B-X
            edge = FindEdge(edges, 900, 0, 1000, 0); // B-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 900, 0))); // B-X neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 800))); // B-X neighbours X-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 900, 0))); // B-X neighbours Z-B
        }

        /// <summary>
        /// This test basically repeats <see cref="FourEquidistantPointsInARotatedSquareOffset"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void FourEquidistantPointsInARotatedSquareOffset_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 100), // #1
                new VoronoiSite(900, 300), // #2
                new VoronoiSite(700, 700), // #3
                new VoronoiSite(300, 500), // #4
            };

            // 1000 Z--------------E----------------------------------W
            //      |               '                                 |
            //  900 |                ',                               |
            //      |                  ,                              |
            //  800 |                   ·                             |
            //      |                    '                            |
            //  700 |                     ',           3              |
            //      |                       ,                         |
            //  600 |                        ·                      ,,D
            //      |                         '                ,,·''  |
            //  500 |              4           ',         ,,·''       |
            //      |                            ,   ,,·''            |
            //  400 |                           ,,A''                 |
            //      |                      ,,·''   '                  |
            //  300 |                 ,,·''         ',           2    |
            //      |            ,,·''                ,               |
            //  200 |       ,,·''                      ·              |
            //      |  ,,·''                            '             |
            //  100 B''                      1           ',           |
            //      |                                      ,          |
            //    0 X---------------------------------------C---------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 12 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 600, 400, 0, 100)); // A-B
            Assume.That(() => HasEdge(edges, 600, 400, 800, 0)); // A-C
            Assume.That(() => HasEdge(edges, 600, 400, 1000, 600)); // A-D
            Assume.That(() => HasEdge(edges, 600, 400, 300, 1000)); // A-E
            Assume.That(() => HasEdge(edges, 0, 0, 800, 0)); // X-C
            Assume.That(() => HasEdge(edges, 800, 0, 1000, 0)); // C-Y
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 600)); // Y-D
            Assume.That(() => HasEdge(edges, 1000, 600, 1000, 1000)); // D-W
            Assume.That(() => HasEdge(edges, 1000, 1000, 300, 1000)); // W-E
            Assume.That(() => HasEdge(edges, 300, 1000, 0, 1000)); // E-Z
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 100)); // Z-B
            Assume.That(() => HasEdge(edges, 0, 100, 0, 0)); // B-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 600, 400, 0, 100); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 800, 0))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 1000, 600))); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 300, 1000))); // A-B neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 100))); // A-B neighbours Z-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 100, 0, 0))); // A-B neighbours B-X
            edge = FindEdge(edges, 600, 400, 800, 0); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 0, 100))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 1000, 600))); // A-C neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 300, 1000))); // A-C neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 800, 0))); // A-C neighbours X-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 0, 1000, 0))); // A-C neighbours C-Y
            edge = FindEdge(edges, 600, 400, 1000, 600); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 0, 100))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 800, 0))); // A-D neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 300, 1000))); // A-D neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 600))); // A-D neighbours Y-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 600, 1000, 1000))); // A-D neighbours D-W
            edge = FindEdge(edges, 600, 400, 300, 1000); // A-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 0, 100))); // A-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 800, 0))); // A-E neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 1000, 600))); // A-E neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 300, 1000))); // A-E neighbours W-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 1000, 0, 1000))); // A-E neighbours E-Z
            edge = FindEdge(edges, 0, 0, 800, 0); // X-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 800, 0))); // X-C neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 0, 1000, 0))); // X-C neighbours C-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 100, 0, 0))); // X-C neighbours B-X
            edge = FindEdge(edges, 800, 0, 1000, 0); // C-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 800, 0))); // C-Y neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 800, 0))); // C-Y neighbours X-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 600))); // C-Y neighbours Y-D
            edge = FindEdge(edges, 1000, 0, 1000, 600); // Y-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 1000, 600))); // Y-D neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 0, 1000, 0))); // Y-D neighbours C-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 600, 1000, 1000))); // Y-D neighbours D-W
            edge = FindEdge(edges, 1000, 600, 1000, 1000); // D-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 1000, 600))); // D-W neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 600))); // D-W neighbours Y-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 300, 1000))); // D-W neighbours W-E
            edge = FindEdge(edges, 1000, 1000, 300, 1000); // W-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 300, 1000))); // W-E neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 600, 1000, 1000))); // W-E neighbours D-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 1000, 0, 1000))); // W-E neighbours E-Z
            edge = FindEdge(edges, 300, 1000, 0, 1000); // E-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 300, 1000))); // E-Z neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 300, 1000))); // E-Z neighbours W-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 100))); // E-Z neighbours Z-B
            edge = FindEdge(edges, 0, 1000, 0, 100); // Z-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 0, 100))); // Z-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 1000, 0, 1000))); // Z-B neighbours E-Z
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 100, 0, 0))); // Z-B neighbours B-X
            edge = FindEdge(edges, 0, 100, 0, 0); // B-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 0, 100))); // B-X neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 800, 0))); // B-X neighbours X-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 100))); // B-X neighbours Z-B
        }

        /// <summary>
        /// This test basically repeats <see cref="FourEquidistantPointsInARotatedSquareOffset"/> above,
        /// but all coordinates are mirrored horizontally.
        /// </summary>
        [Test]
        public void FourEquidistantPointsInARotatedSquareOffset_Mirrored()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(900, 500), // #1
                new VoronoiSite(700, 100), // #2
                new VoronoiSite(300, 300), // #3
                new VoronoiSite(500, 700), // #4
            };

            // 1000 Z--------------------------------------------B----X
            //      |                                           '     |
            //  900 |                                         ,'      |
            //      |                                        ,        |
            //  800 |                                       ·         |
            //      |                                      '          |
            //  700 E,,                      4           ,'           |
            //      |  ''·,,                            ,             |
            //  600 |       ''·,,                      ·              |
            //      |            ''·,,                '               |
            //  500 |                 ''·,,         ,'           1    |
            //      |                      ''·,,   ,                  |
            //  400 |                           ''A,,                 |
            //      |                            '   ''·,,            |
            //  300 |              3           ,'         ''·,,       |
            //      |                         ,                ''·,,  |
            //  200 |                        ·                      ''C
            //      |                       '                         |
            //  100 |                     ,'           2              |
            //      |                    ,                            |
            //    0 W-------------------D-----------------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 12 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 600, 400, 900, 1000)); // A-B
            Assume.That(() => HasEdge(edges, 600, 400, 1000, 200)); // A-C
            Assume.That(() => HasEdge(edges, 600, 400, 400, 0)); // A-D
            Assume.That(() => HasEdge(edges, 600, 400, 0, 700)); // A-E
            Assume.That(() => HasEdge(edges, 1000, 1000, 1000, 200)); // X-C
            Assume.That(() => HasEdge(edges, 1000, 200, 1000, 0)); // C-Y
            Assume.That(() => HasEdge(edges, 1000, 0, 400, 0)); // Y-D
            Assume.That(() => HasEdge(edges, 400, 0, 0, 0)); // D-W
            Assume.That(() => HasEdge(edges, 0, 0, 0, 700)); // W-E
            Assume.That(() => HasEdge(edges, 0, 700, 0, 1000)); // E-Z
            Assume.That(() => HasEdge(edges, 0, 1000, 900, 1000)); // Z-B
            Assume.That(() => HasEdge(edges, 900, 1000, 1000, 1000)); // B-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 600, 400, 900, 1000); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 1000, 200))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 400, 0))); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 0, 700))); // A-B neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 900, 1000))); // A-B neighbours Z-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 900, 1000, 1000, 1000))); // A-B neighbours B-X
            edge = FindEdge(edges, 600, 400, 1000, 200); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 900, 1000))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 400, 0))); // A-C neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 0, 700))); // A-C neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 1000, 200))); // A-C neighbours X-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 200, 1000, 0))); // A-C neighbours C-Y
            edge = FindEdge(edges, 600, 400, 400, 0); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 900, 1000))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 1000, 200))); // A-D neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 0, 700))); // A-D neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 400, 0))); // A-D neighbours Y-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 0, 0, 0))); // A-D neighbours D-W
            edge = FindEdge(edges, 600, 400, 0, 700); // A-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 900, 1000))); // A-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 1000, 200))); // A-E neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 400, 0))); // A-E neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 0, 700))); // A-E neighbours W-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 0, 1000))); // A-E neighbours E-Z
            edge = FindEdge(edges, 1000, 1000, 1000, 200); // X-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 1000, 200))); // X-C neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 200, 1000, 0))); // X-C neighbours C-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 900, 1000, 1000, 1000))); // X-C neighbours B-X
            edge = FindEdge(edges, 1000, 200, 1000, 0); // C-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 1000, 200))); // C-Y neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 1000, 200))); // C-Y neighbours X-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 400, 0))); // C-Y neighbours Y-D
            edge = FindEdge(edges, 1000, 0, 400, 0); // Y-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 400, 0))); // Y-D neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 200, 1000, 0))); // Y-D neighbours C-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 0, 0, 0))); // Y-D neighbours D-W
            edge = FindEdge(edges, 400, 0, 0, 0); // D-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 400, 0))); // D-W neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 400, 0))); // D-W neighbours Y-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 0, 700))); // D-W neighbours W-E
            edge = FindEdge(edges, 0, 0, 0, 700); // W-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 0, 700))); // W-E neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 0, 0, 0))); // W-E neighbours D-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 0, 1000))); // W-E neighbours E-Z
            edge = FindEdge(edges, 0, 700, 0, 1000); // E-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 0, 700))); // E-Z neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 0, 700))); // E-Z neighbours W-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 900, 1000))); // E-Z neighbours Z-B
            edge = FindEdge(edges, 0, 1000, 900, 1000); // Z-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 900, 1000))); // Z-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 0, 1000))); // Z-B neighbours E-Z
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 900, 1000, 1000, 1000))); // Z-B neighbours B-X
            edge = FindEdge(edges, 900, 1000, 1000, 1000); // B-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 900, 1000))); // B-X neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 1000, 200))); // B-X neighbours X-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 900, 1000))); // B-X neighbours Z-B
        }

        /// <summary>
        /// This test basically repeats <see cref="FourEquidistantPointsInARotatedSquareOffset"/> above,
        /// but all coordinates are mirrored horizontally and then rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void FourEquidistantPointsInARotatedSquareOffset_MirroredAndRotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 100), // #1
                new VoronoiSite(100, 300), // #2
                new VoronoiSite(300, 700), // #3
                new VoronoiSite(700, 500), // #4
            };

            // 1000 W----------------------------------E--------------Z
            //      |                                 '               |
            //  900 |                               ,'                |
            //      |                              ,                  |
            //  800 |                             ·                   |
            //      |                            '                    |
            //  700 |              3           ,'                     |
            //      |                         ,                       |
            //  600 D,,                      ·                        |
            //      |  ''·,,                '                         |
            //  500 |       ''·,,         ,'           4              |
            //      |            ''·,,   ,                            |
            //  400 |                 ''A,,                           |
            //      |                  '   ''·,,                      |
            //  300 |    2           ,'         ''·,,                 |
            //      |               ,                ''·,,            |
            //  200 |              ·                      ''·,,       |
            //      |             '                            ''·,,  |
            //  100 |           ,'           1                      ''B
            //      |          ,                                      |
            //    0 Y---------C---------------------------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 12 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 400, 400, 1000, 100)); // A-B
            Assume.That(() => HasEdge(edges, 400, 400, 200, 0)); // A-C
            Assume.That(() => HasEdge(edges, 400, 400, 0, 600)); // A-D
            Assume.That(() => HasEdge(edges, 400, 400, 700, 1000)); // A-E
            Assume.That(() => HasEdge(edges, 1000, 0, 200, 0)); // X-C
            Assume.That(() => HasEdge(edges, 200, 0, 0, 0)); // C-Y
            Assume.That(() => HasEdge(edges, 0, 0, 0, 600)); // Y-D
            Assume.That(() => HasEdge(edges, 0, 600, 0, 1000)); // D-W
            Assume.That(() => HasEdge(edges, 0, 1000, 700, 1000)); // W-E
            Assume.That(() => HasEdge(edges, 700, 1000, 1000, 1000)); // E-Z
            Assume.That(() => HasEdge(edges, 1000, 1000, 1000, 100)); // Z-B
            Assume.That(() => HasEdge(edges, 1000, 100, 1000, 0)); // B-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 400, 400, 1000, 100); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 200, 0))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 0, 600))); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 700, 1000))); // A-B neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 1000, 100))); // A-B neighbours Z-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 100, 1000, 0))); // A-B neighbours B-X
            edge = FindEdge(edges, 400, 400, 200, 0); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 1000, 100))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 0, 600))); // A-C neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 700, 1000))); // A-C neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 200, 0))); // A-C neighbours X-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 0, 0, 0))); // A-C neighbours C-Y
            edge = FindEdge(edges, 400, 400, 0, 600); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 1000, 100))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 200, 0))); // A-D neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 700, 1000))); // A-D neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 0, 600))); // A-D neighbours Y-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 600, 0, 1000))); // A-D neighbours D-W
            edge = FindEdge(edges, 400, 400, 700, 1000); // A-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 1000, 100))); // A-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 200, 0))); // A-E neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 0, 600))); // A-E neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 700, 1000))); // A-E neighbours W-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 1000, 1000, 1000))); // A-E neighbours E-Z
            edge = FindEdge(edges, 1000, 0, 200, 0); // X-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 200, 0))); // X-C neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 0, 0, 0))); // X-C neighbours C-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 100, 1000, 0))); // X-C neighbours B-X
            edge = FindEdge(edges, 200, 0, 0, 0); // C-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 200, 0))); // C-Y neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 200, 0))); // C-Y neighbours X-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 0, 600))); // C-Y neighbours Y-D
            edge = FindEdge(edges, 0, 0, 0, 600); // Y-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 0, 600))); // Y-D neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 0, 0, 0))); // Y-D neighbours C-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 600, 0, 1000))); // Y-D neighbours D-W
            edge = FindEdge(edges, 0, 600, 0, 1000); // D-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 0, 600))); // D-W neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 0, 600))); // D-W neighbours Y-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 700, 1000))); // D-W neighbours W-E
            edge = FindEdge(edges, 0, 1000, 700, 1000); // W-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 700, 1000))); // W-E neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 600, 0, 1000))); // W-E neighbours D-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 1000, 1000, 1000))); // W-E neighbours E-Z
            edge = FindEdge(edges, 700, 1000, 1000, 1000); // E-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 700, 1000))); // E-Z neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 700, 1000))); // E-Z neighbours W-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 1000, 100))); // E-Z neighbours Z-B
            edge = FindEdge(edges, 1000, 1000, 1000, 100); // Z-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 1000, 100))); // Z-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 1000, 1000, 1000))); // Z-B neighbours E-Z
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 100, 1000, 0))); // Z-B neighbours B-X
            edge = FindEdge(edges, 1000, 100, 1000, 0); // B-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 1000, 100))); // B-X neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 200, 0))); // B-X neighbours X-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 1000, 100))); // B-X neighbours Z-B
        }

        /// <summary>
        /// This test basically repeats <see cref="FourEquidistantPointsInARotatedSquareOffset"/> above,
        /// but all coordinates are mirrored horizontally and then rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void FourEquidistantPointsInARotatedSquareOffset_MirroredAndRotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(100, 500), // #1
                new VoronoiSite(300, 900), // #2
                new VoronoiSite(700, 700), // #3
                new VoronoiSite(500, 300), // #4
            };

            // 1000 Y-----------------------------D-------------------W
            //      |                            '                    |
            //  900 |              2           ,'                     |
            //      |                         ,                       |
            //  800 C,,                      ·                        |
            //      |  ''·,,                '                         |
            //  700 |       ''·,,         ,'           3              |
            //      |            ''·,,   ,                            |
            //  600 |                 ''A,,                           |
            //      |                  '   ''·,,                      |
            //  500 |    1           ,'         ''·,,                 |
            //      |               ,                ''·,,            |
            //  400 |              ·                      ''·,,       |
            //      |             '                            ''·,,  |
            //  300 |           ,'           4                      ''E
            //      |          ,                                      |
            //  200 |         ·                                       |
            //      |        '                                        |
            //  100 |      ,'                                         |
            //      |     ,                                           |
            //    0 X----B--------------------------------------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 12 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 400, 600, 100, 0)); // A-B
            Assume.That(() => HasEdge(edges, 400, 600, 0, 800)); // A-C
            Assume.That(() => HasEdge(edges, 400, 600, 600, 1000)); // A-D
            Assume.That(() => HasEdge(edges, 400, 600, 1000, 300)); // A-E
            Assume.That(() => HasEdge(edges, 0, 0, 0, 800)); // X-C
            Assume.That(() => HasEdge(edges, 0, 800, 0, 1000)); // C-Y
            Assume.That(() => HasEdge(edges, 0, 1000, 600, 1000)); // Y-D
            Assume.That(() => HasEdge(edges, 600, 1000, 1000, 1000)); // D-W
            Assume.That(() => HasEdge(edges, 1000, 1000, 1000, 300)); // W-E
            Assume.That(() => HasEdge(edges, 1000, 300, 1000, 0)); // E-Z
            Assume.That(() => HasEdge(edges, 1000, 0, 100, 0)); // Z-B
            Assume.That(() => HasEdge(edges, 100, 0, 0, 0)); // B-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 400, 600, 100, 0); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 0, 800))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 600, 1000))); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 1000, 300))); // A-B neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 100, 0))); // A-B neighbours Z-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 100, 0, 0, 0))); // A-B neighbours B-X
            edge = FindEdge(edges, 400, 600, 0, 800); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 100, 0))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 600, 1000))); // A-C neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 1000, 300))); // A-C neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 0, 800))); // A-C neighbours X-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 800, 0, 1000))); // A-C neighbours C-Y
            edge = FindEdge(edges, 400, 600, 600, 1000); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 100, 0))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 0, 800))); // A-D neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 1000, 300))); // A-D neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 600, 1000))); // A-D neighbours Y-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 1000, 1000, 1000))); // A-D neighbours D-W
            edge = FindEdge(edges, 400, 600, 1000, 300); // A-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 100, 0))); // A-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 0, 800))); // A-E neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 600, 1000))); // A-E neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 1000, 300))); // A-E neighbours W-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 300, 1000, 0))); // A-E neighbours E-Z
            edge = FindEdge(edges, 0, 0, 0, 800); // X-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 0, 800))); // X-C neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 800, 0, 1000))); // X-C neighbours C-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 100, 0, 0, 0))); // X-C neighbours B-X
            edge = FindEdge(edges, 0, 800, 0, 1000); // C-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 0, 800))); // C-Y neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 0, 800))); // C-Y neighbours X-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 600, 1000))); // C-Y neighbours Y-D
            edge = FindEdge(edges, 0, 1000, 600, 1000); // Y-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 600, 1000))); // Y-D neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 800, 0, 1000))); // Y-D neighbours C-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 1000, 1000, 1000))); // Y-D neighbours D-W
            edge = FindEdge(edges, 600, 1000, 1000, 1000); // D-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 600, 1000))); // D-W neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 600, 1000))); // D-W neighbours Y-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 1000, 300))); // D-W neighbours W-E
            edge = FindEdge(edges, 1000, 1000, 1000, 300); // W-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 1000, 300))); // W-E neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 1000, 1000, 1000))); // W-E neighbours D-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 300, 1000, 0))); // W-E neighbours E-Z
            edge = FindEdge(edges, 1000, 300, 1000, 0); // E-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 1000, 300))); // E-Z neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 1000, 300))); // E-Z neighbours W-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 100, 0))); // E-Z neighbours Z-B
            edge = FindEdge(edges, 1000, 0, 100, 0); // Z-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 100, 0))); // Z-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 300, 1000, 0))); // Z-B neighbours E-Z
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 100, 0, 0, 0))); // Z-B neighbours B-X
            edge = FindEdge(edges, 100, 0, 0, 0); // B-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 100, 0))); // B-X neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 0, 800))); // B-X neighbours X-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 100, 0))); // B-X neighbours Z-B
        }

        /// <summary>
        /// This test basically repeats <see cref="FourEquidistantPointsInARotatedSquareOffset"/> above,
        /// but all coordinates are mirrored horizontally and then rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void FourEquidistantPointsInARotatedSquareOffset_MirroredAndRotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 900), // #1
                new VoronoiSite(900, 700), // #2
                new VoronoiSite(700, 300), // #3
                new VoronoiSite(300, 500), // #4
            };

            // 1000 X---------------------------------------C---------Y
            //      |                                      '          |
            //  900 B,,                      1           ,'           |
            //      |  ''·,,                            ,             |
            //  800 |       ''·,,                      ·              |
            //      |            ''·,,                '               |
            //  700 |                 ''·,,         ,'           2    |
            //      |                      ''·,,   ,                  |
            //  600 |                           ''A,,                 |
            //      |                            '   ''·,,            |
            //  500 |              4           ,'         ''·,,       |
            //      |                         ,                ''·,,  |
            //  400 |                        ·                      ''D
            //      |                       '                         |
            //  300 |                     ,'           3              |
            //      |                    ,                            |
            //  200 |                   ·                             |
            //      |                  '                              |
            //  100 |                ,'                               |
            //      |               ,                                 |
            //    0 Z--------------E----------------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000).ToList();

            // Assume

            Assume.That(() => 12 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 600, 600, 0, 900)); // A-B
            Assume.That(() => HasEdge(edges, 600, 600, 800, 1000)); // A-C
            Assume.That(() => HasEdge(edges, 600, 600, 1000, 400)); // A-D
            Assume.That(() => HasEdge(edges, 600, 600, 300, 0)); // A-E
            Assume.That(() => HasEdge(edges, 0, 1000, 800, 1000)); // X-C
            Assume.That(() => HasEdge(edges, 800, 1000, 1000, 1000)); // C-Y
            Assume.That(() => HasEdge(edges, 1000, 1000, 1000, 400)); // Y-D
            Assume.That(() => HasEdge(edges, 1000, 400, 1000, 0)); // D-W
            Assume.That(() => HasEdge(edges, 1000, 0, 300, 0)); // W-E
            Assume.That(() => HasEdge(edges, 300, 0, 0, 0)); // E-Z
            Assume.That(() => HasEdge(edges, 0, 0, 0, 900)); // Z-B
            Assume.That(() => HasEdge(edges, 0, 900, 0, 1000)); // B-X

            // Assert

            VoronoiEdge edge = FindEdge(edges, 600, 600, 0, 900); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 800, 1000))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 1000, 400))); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 300, 0))); // A-B neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 0, 900))); // A-B neighbours Z-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 900, 0, 1000))); // A-B neighbours B-X
            edge = FindEdge(edges, 600, 600, 800, 1000); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 0, 900))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 1000, 400))); // A-C neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 300, 0))); // A-C neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 800, 1000))); // A-C neighbours X-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 1000, 1000, 1000))); // A-C neighbours C-Y
            edge = FindEdge(edges, 600, 600, 1000, 400); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 0, 900))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 800, 1000))); // A-D neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 300, 0))); // A-D neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 1000, 400))); // A-D neighbours Y-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 400, 1000, 0))); // A-D neighbours D-W
            edge = FindEdge(edges, 600, 600, 300, 0); // A-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 0, 900))); // A-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 800, 1000))); // A-E neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 1000, 400))); // A-E neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 300, 0))); // A-E neighbours W-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 0, 0, 0))); // A-E neighbours E-Z
            edge = FindEdge(edges, 0, 1000, 800, 1000); // X-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 800, 1000))); // X-C neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 1000, 1000, 1000))); // X-C neighbours C-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 900, 0, 1000))); // X-C neighbours B-X
            edge = FindEdge(edges, 800, 1000, 1000, 1000); // C-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 800, 1000))); // C-Y neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 800, 1000))); // C-Y neighbours X-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 1000, 400))); // C-Y neighbours Y-D
            edge = FindEdge(edges, 1000, 1000, 1000, 400); // Y-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 1000, 400))); // Y-D neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 1000, 1000, 1000))); // Y-D neighbours C-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 400, 1000, 0))); // Y-D neighbours D-W
            edge = FindEdge(edges, 1000, 400, 1000, 0); // D-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 1000, 400))); // D-W neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 1000, 400))); // D-W neighbours Y-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 300, 0))); // D-W neighbours W-E
            edge = FindEdge(edges, 1000, 0, 300, 0); // W-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 300, 0))); // W-E neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 400, 1000, 0))); // W-E neighbours D-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 0, 0, 0))); // W-E neighbours E-Z
            edge = FindEdge(edges, 300, 0, 0, 0); // E-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 300, 0))); // E-Z neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 300, 0))); // E-Z neighbours W-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 0, 900))); // E-Z neighbours Z-B
            edge = FindEdge(edges, 0, 0, 0, 900); // Z-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 0, 900))); // Z-B neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 0, 0, 0))); // Z-B neighbours E-Z
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 900, 0, 1000))); // Z-B neighbours B-X
            edge = FindEdge(edges, 0, 900, 0, 1000); // B-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 0, 900))); // B-X neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 800, 1000))); // B-X neighbours X-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 0, 900))); // B-X neighbours Z-B
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

            Assume.That(() => 15 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 500, 400, 500, 700)); // A-B
            Assume.That(() => HasEdge(edges, 500, 700, 200, 1000)); // B-C
            Assume.That(() => HasEdge(edges, 500, 700, 800, 1000)); // B-D
            Assume.That(() => HasEdge(edges, 500, 400, 0, 400)); // A-E
            Assume.That(() => HasEdge(edges, 500, 400, 1000, 400)); // A-F
            Assume.That(() => HasEdge(edges, 500, 400, 500, 0)); // A-G
            Assume.That(() => HasEdge(edges, 200, 1000, 0, 1000)); // C-W
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 400)); // W-E
            Assume.That(() => HasEdge(edges, 0, 400, 0, 0)); // E-X
            Assume.That(() => HasEdge(edges, 0, 0, 500, 0)); // X-G
            Assume.That(() => HasEdge(edges, 500, 0, 1000, 0)); // G-Y
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 400)); // Y-F
            Assume.That(() => HasEdge(edges, 1000, 400, 1000, 1000)); // F-Z
            Assume.That(() => HasEdge(edges, 1000, 1000, 800, 1000)); // Z-D
            Assume.That(() => HasEdge(edges, 800, 1000, 200, 1000)); // D-C

            // Assert

            VoronoiEdge edge = FindEdge(edges, 500, 400, 500, 700); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 200, 1000))); // A-B neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 800, 1000))); // A-B neighbours B-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 400, 0, 400))); // A-B neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 400, 1000, 400))); // A-B neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 400, 500, 0))); // A-B neighbours A-G
            edge = FindEdge(edges, 500, 700, 200, 1000); // B-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 400, 500, 700))); // B-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 800, 1000))); // B-C neighbours B-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 1000, 0, 1000))); // B-C neighbours C-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 1000, 200, 1000))); // B-C neighbours D-C
            edge = FindEdge(edges, 500, 700, 800, 1000); // B-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 400, 500, 700))); // B-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 200, 1000))); // B-D neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 800, 1000))); // B-D neighbours Z-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 1000, 200, 1000))); // B-D neighbours D-C
            edge = FindEdge(edges, 500, 400, 0, 400); // A-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 400, 500, 700))); // A-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 400, 1000, 400))); // A-E neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 400, 500, 0))); // A-E neighbours A-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 400))); // A-E neighbours W-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 400, 0, 0))); // A-E neighbours E-X
            edge = FindEdge(edges, 500, 400, 1000, 400); // A-F
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 400, 500, 700))); // A-F neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 400, 0, 400))); // A-F neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 400, 500, 0))); // A-F neighbours A-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 400))); // A-F neighbours Y-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 400, 1000, 1000))); // A-F neighbours F-Z
            edge = FindEdge(edges, 500, 400, 500, 0); // A-G
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 400, 500, 700))); // A-G neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 400, 0, 400))); // A-G neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 400, 1000, 400))); // A-G neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 500, 0))); // A-G neighbours X-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 0, 1000, 0))); // A-G neighbours G-Y
            edge = FindEdge(edges, 200, 1000, 0, 1000); // C-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 200, 1000))); // C-W neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 400))); // C-W neighbours W-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 1000, 200, 1000))); // C-W neighbours D-C
            edge = FindEdge(edges, 0, 1000, 0, 400); // W-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 400, 0, 400))); // W-E neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 1000, 0, 1000))); // W-E neighbours C-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 400, 0, 0))); // W-E neighbours E-X
            edge = FindEdge(edges, 0, 400, 0, 0); // E-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 400, 0, 400))); // E-X neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 400))); // E-X neighbours W-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 500, 0))); // E-X neighbours X-G
            edge = FindEdge(edges, 0, 0, 500, 0); // X-G
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 400, 500, 0))); // X-G neighbours A-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 400, 0, 0))); // X-G neighbours E-X
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 0, 1000, 0))); // X-G neighbours G-Y
            edge = FindEdge(edges, 500, 0, 1000, 0); // G-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 400, 500, 0))); // G-Y neighbours A-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 500, 0))); // G-Y neighbours X-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 400))); // G-Y neighbours Y-F
            edge = FindEdge(edges, 1000, 0, 1000, 400); // Y-F
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 400, 1000, 400))); // Y-F neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 0, 1000, 0))); // Y-F neighbours G-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 400, 1000, 1000))); // Y-F neighbours F-Z
            edge = FindEdge(edges, 1000, 400, 1000, 1000); // F-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 400, 1000, 400))); // F-Z neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 400))); // F-Z neighbours Y-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 800, 1000))); // F-Z neighbours Z-D
            edge = FindEdge(edges, 1000, 1000, 800, 1000); // Z-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 800, 1000))); // Z-D neighbours B-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 400, 1000, 1000))); // Z-D neighbours F-Z
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 1000, 200, 1000))); // Z-D neighbours D-C
            edge = FindEdge(edges, 800, 1000, 200, 1000); // D-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 200, 1000))); // D-C neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 800, 1000))); // D-C neighbours B-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 1000, 0, 1000))); // D-C neighbours C-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 800, 1000))); // D-C neighbours Z-D
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

            Assume.That(() => 15 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 400, 500, 700, 500)); // A-B
            Assume.That(() => HasEdge(edges, 700, 500, 1000, 800)); // B-C
            Assume.That(() => HasEdge(edges, 700, 500, 1000, 200)); // B-D
            Assume.That(() => HasEdge(edges, 400, 500, 400, 1000)); // A-E
            Assume.That(() => HasEdge(edges, 400, 500, 400, 0)); // A-F
            Assume.That(() => HasEdge(edges, 400, 500, 0, 500)); // A-G
            Assume.That(() => HasEdge(edges, 1000, 800, 1000, 1000)); // C-W
            Assume.That(() => HasEdge(edges, 1000, 1000, 400, 1000)); // W-E
            Assume.That(() => HasEdge(edges, 400, 1000, 0, 1000)); // E-X
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 500)); // X-G
            Assume.That(() => HasEdge(edges, 0, 500, 0, 0)); // G-Y
            Assume.That(() => HasEdge(edges, 0, 0, 400, 0)); // Y-F
            Assume.That(() => HasEdge(edges, 400, 0, 1000, 0)); // F-Z
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 200)); // Z-D
            Assume.That(() => HasEdge(edges, 1000, 200, 1000, 800)); // D-C

            // Assert

            VoronoiEdge edge = FindEdge(edges, 400, 500, 700, 500); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 1000, 800))); // A-B neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 1000, 200))); // A-B neighbours B-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 500, 400, 1000))); // A-B neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 500, 400, 0))); // A-B neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 500, 0, 500))); // A-B neighbours A-G
            edge = FindEdge(edges, 700, 500, 1000, 800); // B-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 500, 700, 500))); // B-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 1000, 200))); // B-C neighbours B-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 800, 1000, 1000))); // B-C neighbours C-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 200, 1000, 800))); // B-C neighbours D-C
            edge = FindEdge(edges, 700, 500, 1000, 200); // B-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 500, 700, 500))); // B-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 1000, 800))); // B-D neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 200))); // B-D neighbours Z-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 200, 1000, 800))); // B-D neighbours D-C
            edge = FindEdge(edges, 400, 500, 400, 1000); // A-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 500, 700, 500))); // A-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 500, 400, 0))); // A-E neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 500, 0, 500))); // A-E neighbours A-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 400, 1000))); // A-E neighbours W-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 1000, 0, 1000))); // A-E neighbours E-X
            edge = FindEdge(edges, 400, 500, 400, 0); // A-F
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 500, 700, 500))); // A-F neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 500, 400, 1000))); // A-F neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 500, 0, 500))); // A-F neighbours A-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 400, 0))); // A-F neighbours Y-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 0, 1000, 0))); // A-F neighbours F-Z
            edge = FindEdge(edges, 400, 500, 0, 500); // A-G
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 500, 700, 500))); // A-G neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 500, 400, 1000))); // A-G neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 500, 400, 0))); // A-G neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 500))); // A-G neighbours X-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 0, 0))); // A-G neighbours G-Y
            edge = FindEdge(edges, 1000, 800, 1000, 1000); // C-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 1000, 800))); // C-W neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 400, 1000))); // C-W neighbours W-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 200, 1000, 800))); // C-W neighbours D-C
            edge = FindEdge(edges, 1000, 1000, 400, 1000); // W-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 500, 400, 1000))); // W-E neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 800, 1000, 1000))); // W-E neighbours C-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 1000, 0, 1000))); // W-E neighbours E-X
            edge = FindEdge(edges, 400, 1000, 0, 1000); // E-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 500, 400, 1000))); // E-X neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 400, 1000))); // E-X neighbours W-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 500))); // E-X neighbours X-G
            edge = FindEdge(edges, 0, 1000, 0, 500); // X-G
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 500, 0, 500))); // X-G neighbours A-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 1000, 0, 1000))); // X-G neighbours E-X
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 0, 0))); // X-G neighbours G-Y
            edge = FindEdge(edges, 0, 500, 0, 0); // G-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 500, 0, 500))); // G-Y neighbours A-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 500))); // G-Y neighbours X-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 400, 0))); // G-Y neighbours Y-F
            edge = FindEdge(edges, 0, 0, 400, 0); // Y-F
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 500, 400, 0))); // Y-F neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 0, 0))); // Y-F neighbours G-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 0, 1000, 0))); // Y-F neighbours F-Z
            edge = FindEdge(edges, 400, 0, 1000, 0); // F-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 500, 400, 0))); // F-Z neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 400, 0))); // F-Z neighbours Y-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 200))); // F-Z neighbours Z-D
            edge = FindEdge(edges, 1000, 0, 1000, 200); // Z-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 1000, 200))); // Z-D neighbours B-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 0, 1000, 0))); // Z-D neighbours F-Z
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 200, 1000, 800))); // Z-D neighbours D-C
            edge = FindEdge(edges, 1000, 200, 1000, 800); // D-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 1000, 800))); // D-C neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 1000, 200))); // D-C neighbours B-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 800, 1000, 1000))); // D-C neighbours C-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 200))); // D-C neighbours Z-D
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

            Assume.That(() => 15 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 500, 600, 500, 300)); // A-B
            Assume.That(() => HasEdge(edges, 500, 300, 800, 0)); // B-C
            Assume.That(() => HasEdge(edges, 500, 300, 200, 0)); // B-D
            Assume.That(() => HasEdge(edges, 500, 600, 1000, 600)); // A-E
            Assume.That(() => HasEdge(edges, 500, 600, 0, 600)); // A-F
            Assume.That(() => HasEdge(edges, 500, 600, 500, 1000)); // A-G
            Assume.That(() => HasEdge(edges, 800, 0, 1000, 0)); // C-W
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 600)); // W-E
            Assume.That(() => HasEdge(edges, 1000, 600, 1000, 1000)); // E-X
            Assume.That(() => HasEdge(edges, 1000, 1000, 500, 1000)); // X-G
            Assume.That(() => HasEdge(edges, 500, 1000, 0, 1000)); // G-Y
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 600)); // Y-F
            Assume.That(() => HasEdge(edges, 0, 600, 0, 0)); // F-Z
            Assume.That(() => HasEdge(edges, 0, 0, 200, 0)); // Z-D
            Assume.That(() => HasEdge(edges, 200, 0, 800, 0)); // D-C

            // Assert

            VoronoiEdge edge = FindEdge(edges, 500, 600, 500, 300); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 800, 0))); // A-B neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 200, 0))); // A-B neighbours B-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 600, 1000, 600))); // A-B neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 600, 0, 600))); // A-B neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 600, 500, 1000))); // A-B neighbours A-G
            edge = FindEdge(edges, 500, 300, 800, 0); // B-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 600, 500, 300))); // B-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 200, 0))); // B-C neighbours B-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 0, 1000, 0))); // B-C neighbours C-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 0, 800, 0))); // B-C neighbours D-C
            edge = FindEdge(edges, 500, 300, 200, 0); // B-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 600, 500, 300))); // B-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 800, 0))); // B-D neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 200, 0))); // B-D neighbours Z-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 0, 800, 0))); // B-D neighbours D-C
            edge = FindEdge(edges, 500, 600, 1000, 600); // A-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 600, 500, 300))); // A-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 600, 0, 600))); // A-E neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 600, 500, 1000))); // A-E neighbours A-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 600))); // A-E neighbours W-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 600, 1000, 1000))); // A-E neighbours E-X
            edge = FindEdge(edges, 500, 600, 0, 600); // A-F
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 600, 500, 300))); // A-F neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 600, 1000, 600))); // A-F neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 600, 500, 1000))); // A-F neighbours A-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 600))); // A-F neighbours Y-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 600, 0, 0))); // A-F neighbours F-Z
            edge = FindEdge(edges, 500, 600, 500, 1000); // A-G
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 600, 500, 300))); // A-G neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 600, 1000, 600))); // A-G neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 600, 0, 600))); // A-G neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 500, 1000))); // A-G neighbours X-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 1000, 0, 1000))); // A-G neighbours G-Y
            edge = FindEdge(edges, 800, 0, 1000, 0); // C-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 800, 0))); // C-W neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 600))); // C-W neighbours W-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 0, 800, 0))); // C-W neighbours D-C
            edge = FindEdge(edges, 1000, 0, 1000, 600); // W-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 600, 1000, 600))); // W-E neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 0, 1000, 0))); // W-E neighbours C-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 600, 1000, 1000))); // W-E neighbours E-X
            edge = FindEdge(edges, 1000, 600, 1000, 1000); // E-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 600, 1000, 600))); // E-X neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 600))); // E-X neighbours W-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 500, 1000))); // E-X neighbours X-G
            edge = FindEdge(edges, 1000, 1000, 500, 1000); // X-G
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 600, 500, 1000))); // X-G neighbours A-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 600, 1000, 1000))); // X-G neighbours E-X
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 1000, 0, 1000))); // X-G neighbours G-Y
            edge = FindEdge(edges, 500, 1000, 0, 1000); // G-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 600, 500, 1000))); // G-Y neighbours A-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 500, 1000))); // G-Y neighbours X-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 600))); // G-Y neighbours Y-F
            edge = FindEdge(edges, 0, 1000, 0, 600); // Y-F
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 600, 0, 600))); // Y-F neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 1000, 0, 1000))); // Y-F neighbours G-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 600, 0, 0))); // Y-F neighbours F-Z
            edge = FindEdge(edges, 0, 600, 0, 0); // F-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 600, 0, 600))); // F-Z neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 600))); // F-Z neighbours Y-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 200, 0))); // F-Z neighbours Z-D
            edge = FindEdge(edges, 0, 0, 200, 0); // Z-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 200, 0))); // Z-D neighbours B-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 600, 0, 0))); // Z-D neighbours F-Z
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 0, 800, 0))); // Z-D neighbours D-C
            edge = FindEdge(edges, 200, 0, 800, 0); // D-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 800, 0))); // D-C neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 200, 0))); // D-C neighbours B-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 0, 1000, 0))); // D-C neighbours C-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 200, 0))); // D-C neighbours Z-D
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

            Assume.That(() => 15 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 600, 500, 300, 500)); // A-B
            Assume.That(() => HasEdge(edges, 300, 500, 0, 200)); // B-C
            Assume.That(() => HasEdge(edges, 300, 500, 0, 800)); // B-D
            Assume.That(() => HasEdge(edges, 600, 500, 600, 0)); // A-E
            Assume.That(() => HasEdge(edges, 600, 500, 600, 1000)); // A-F
            Assume.That(() => HasEdge(edges, 600, 500, 1000, 500)); // A-G
            Assume.That(() => HasEdge(edges, 0, 200, 0, 0)); // C-W
            Assume.That(() => HasEdge(edges, 0, 0, 600, 0)); // W-E
            Assume.That(() => HasEdge(edges, 600, 0, 1000, 0)); // E-X
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 500)); // X-G
            Assume.That(() => HasEdge(edges, 1000, 500, 1000, 1000)); // G-Y
            Assume.That(() => HasEdge(edges, 1000, 1000, 600, 1000)); // Y-F
            Assume.That(() => HasEdge(edges, 600, 1000, 0, 1000)); // F-Z
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 800)); // Z-D
            Assume.That(() => HasEdge(edges, 0, 800, 0, 200)); // D-C

            // Assert

            VoronoiEdge edge = FindEdge(edges, 600, 500, 300, 500); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 0, 200))); // A-B neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 0, 800))); // A-B neighbours B-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 500, 600, 0))); // A-B neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 500, 600, 1000))); // A-B neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 500, 1000, 500))); // A-B neighbours A-G
            edge = FindEdge(edges, 300, 500, 0, 200); // B-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 500, 300, 500))); // B-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 0, 800))); // B-C neighbours B-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 200, 0, 0))); // B-C neighbours C-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 800, 0, 200))); // B-C neighbours D-C
            edge = FindEdge(edges, 300, 500, 0, 800); // B-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 500, 300, 500))); // B-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 0, 200))); // B-D neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 800))); // B-D neighbours Z-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 800, 0, 200))); // B-D neighbours D-C
            edge = FindEdge(edges, 600, 500, 600, 0); // A-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 500, 300, 500))); // A-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 500, 600, 1000))); // A-E neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 500, 1000, 500))); // A-E neighbours A-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 600, 0))); // A-E neighbours W-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 0, 1000, 0))); // A-E neighbours E-X
            edge = FindEdge(edges, 600, 500, 600, 1000); // A-F
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 500, 300, 500))); // A-F neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 500, 600, 0))); // A-F neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 500, 1000, 500))); // A-F neighbours A-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 600, 1000))); // A-F neighbours Y-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 1000, 0, 1000))); // A-F neighbours F-Z
            edge = FindEdge(edges, 600, 500, 1000, 500); // A-G
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 500, 300, 500))); // A-G neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 500, 600, 0))); // A-G neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 500, 600, 1000))); // A-G neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 500))); // A-G neighbours X-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 500, 1000, 1000))); // A-G neighbours G-Y
            edge = FindEdge(edges, 0, 200, 0, 0); // C-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 0, 200))); // C-W neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 600, 0))); // C-W neighbours W-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 800, 0, 200))); // C-W neighbours D-C
            edge = FindEdge(edges, 0, 0, 600, 0); // W-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 500, 600, 0))); // W-E neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 200, 0, 0))); // W-E neighbours C-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 0, 1000, 0))); // W-E neighbours E-X
            edge = FindEdge(edges, 600, 0, 1000, 0); // E-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 500, 600, 0))); // E-X neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 600, 0))); // E-X neighbours W-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 500))); // E-X neighbours X-G
            edge = FindEdge(edges, 1000, 0, 1000, 500); // X-G
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 500, 1000, 500))); // X-G neighbours A-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 0, 1000, 0))); // X-G neighbours E-X
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 500, 1000, 1000))); // X-G neighbours G-Y
            edge = FindEdge(edges, 1000, 500, 1000, 1000); // G-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 500, 1000, 500))); // G-Y neighbours A-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 500))); // G-Y neighbours X-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 600, 1000))); // G-Y neighbours Y-F
            edge = FindEdge(edges, 1000, 1000, 600, 1000); // Y-F
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 500, 600, 1000))); // Y-F neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 500, 1000, 1000))); // Y-F neighbours G-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 1000, 0, 1000))); // Y-F neighbours F-Z
            edge = FindEdge(edges, 600, 1000, 0, 1000); // F-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 500, 600, 1000))); // F-Z neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 600, 1000))); // F-Z neighbours Y-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 800))); // F-Z neighbours Z-D
            edge = FindEdge(edges, 0, 1000, 0, 800); // Z-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 0, 800))); // Z-D neighbours B-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 1000, 0, 1000))); // Z-D neighbours F-Z
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 800, 0, 200))); // Z-D neighbours D-C
            edge = FindEdge(edges, 0, 800, 0, 200); // D-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 0, 200))); // D-C neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 0, 800))); // D-C neighbours B-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 200, 0, 0))); // D-C neighbours C-W
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 800))); // D-C neighbours Z-D
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

            Assume.That(() => 13 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 500, 300, 500, 500)); // A-B
            Assume.That(() => HasEdge(edges, 500, 500, 0, 1000)); // B-C
            Assume.That(() => HasEdge(edges, 500, 500, 1000, 1000)); // B-D
            Assume.That(() => HasEdge(edges, 500, 300, 0, 300)); // A-E
            Assume.That(() => HasEdge(edges, 500, 300, 1000, 300)); // A-F
            Assume.That(() => HasEdge(edges, 500, 300, 500, 0)); // A-G
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 300)); // C-E
            Assume.That(() => HasEdge(edges, 0, 300, 0, 0)); // E-X
            Assume.That(() => HasEdge(edges, 0, 0, 500, 0)); // X-G
            Assume.That(() => HasEdge(edges, 500, 0, 1000, 0)); // G-Y
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 300)); // Y-F
            Assume.That(() => HasEdge(edges, 1000, 300, 1000, 1000)); // F-D
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000)); // D-C

            // Assert

            VoronoiEdge edge = FindEdge(edges, 500, 300, 500, 500); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 1000))); // A-B neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 1000))); // A-B neighbours B-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 0, 300))); // A-B neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 1000, 300))); // A-B neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 0))); // A-B neighbours A-G
            edge = FindEdge(edges, 500, 500, 0, 1000); // B-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 500))); // B-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 1000))); // B-C neighbours B-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 300))); // B-C neighbours C-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // B-C neighbours D-C
            edge = FindEdge(edges, 500, 500, 1000, 1000); // B-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 500))); // B-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 1000))); // B-D neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 300, 1000, 1000))); // B-D neighbours F-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // B-D neighbours D-C
            edge = FindEdge(edges, 500, 300, 0, 300); // A-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 500))); // A-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 1000, 300))); // A-E neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 0))); // A-E neighbours A-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 300))); // A-E neighbours C-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 300, 0, 0))); // A-E neighbours E-X
            edge = FindEdge(edges, 500, 300, 1000, 300); // A-F
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 500))); // A-F neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 0, 300))); // A-F neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 0))); // A-F neighbours A-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 300))); // A-F neighbours Y-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 300, 1000, 1000))); // A-F neighbours F-D
            edge = FindEdge(edges, 500, 300, 500, 0); // A-G
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 500))); // A-G neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 0, 300))); // A-G neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 1000, 300))); // A-G neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 500, 0))); // A-G neighbours X-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 0, 1000, 0))); // A-G neighbours G-Y
            edge = FindEdge(edges, 0, 1000, 0, 300); // C-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 1000))); // C-E neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 0, 300))); // C-E neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 300, 0, 0))); // C-E neighbours E-X
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // C-E neighbours D-C
            edge = FindEdge(edges, 0, 300, 0, 0); // E-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 0, 300))); // E-X neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 300))); // E-X neighbours C-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 500, 0))); // E-X neighbours X-G
            edge = FindEdge(edges, 0, 0, 500, 0); // X-G
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 0))); // X-G neighbours A-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 300, 0, 0))); // X-G neighbours E-X
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 0, 1000, 0))); // X-G neighbours G-Y
            edge = FindEdge(edges, 500, 0, 1000, 0); // G-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 0))); // G-Y neighbours A-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 500, 0))); // G-Y neighbours X-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 300))); // G-Y neighbours Y-F
            edge = FindEdge(edges, 1000, 0, 1000, 300); // Y-F
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 1000, 300))); // Y-F neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 0, 1000, 0))); // Y-F neighbours G-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 300, 1000, 1000))); // Y-F neighbours F-D
            edge = FindEdge(edges, 1000, 300, 1000, 1000); // F-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 1000))); // F-D neighbours B-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 1000, 300))); // F-D neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 300))); // F-D neighbours Y-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 0, 1000))); // F-D neighbours D-C
            edge = FindEdge(edges, 1000, 1000, 0, 1000); // D-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 1000))); // D-C neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 1000))); // D-C neighbours B-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 300))); // D-C neighbours C-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 300, 1000, 1000))); // D-C neighbours F-D
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

            Assume.That(() => 13 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 300, 500, 500, 500)); // A-B
            Assume.That(() => HasEdge(edges, 500, 500, 1000, 1000)); // B-C
            Assume.That(() => HasEdge(edges, 500, 500, 1000, 0)); // B-D
            Assume.That(() => HasEdge(edges, 300, 500, 300, 1000)); // A-E
            Assume.That(() => HasEdge(edges, 300, 500, 300, 0)); // A-F
            Assume.That(() => HasEdge(edges, 300, 500, 0, 500)); // A-G
            Assume.That(() => HasEdge(edges, 1000, 1000, 300, 1000)); // C-E
            Assume.That(() => HasEdge(edges, 300, 1000, 0, 1000)); // E-X
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 500)); // X-G
            Assume.That(() => HasEdge(edges, 0, 500, 0, 0)); // G-Y
            Assume.That(() => HasEdge(edges, 0, 0, 300, 0)); // Y-F
            Assume.That(() => HasEdge(edges, 300, 0, 1000, 0)); // F-D
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000)); // D-C

            // Assert

            VoronoiEdge edge = FindEdge(edges, 300, 500, 500, 500); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 1000))); // A-B neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 0))); // A-B neighbours B-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 300, 1000))); // A-B neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 300, 0))); // A-B neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 0, 500))); // A-B neighbours A-G
            edge = FindEdge(edges, 500, 500, 1000, 1000); // B-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 500, 500))); // B-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 0))); // B-C neighbours B-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 300, 1000))); // B-C neighbours C-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // B-C neighbours D-C
            edge = FindEdge(edges, 500, 500, 1000, 0); // B-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 500, 500))); // B-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 1000))); // B-D neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 0, 1000, 0))); // B-D neighbours F-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // B-D neighbours D-C
            edge = FindEdge(edges, 300, 500, 300, 1000); // A-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 500, 500))); // A-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 300, 0))); // A-E neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 0, 500))); // A-E neighbours A-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 300, 1000))); // A-E neighbours C-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 1000, 0, 1000))); // A-E neighbours E-X
            edge = FindEdge(edges, 300, 500, 300, 0); // A-F
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 500, 500))); // A-F neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 300, 1000))); // A-F neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 0, 500))); // A-F neighbours A-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 300, 0))); // A-F neighbours Y-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 0, 1000, 0))); // A-F neighbours F-D
            edge = FindEdge(edges, 300, 500, 0, 500); // A-G
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 500, 500))); // A-G neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 300, 1000))); // A-G neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 300, 0))); // A-G neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 500))); // A-G neighbours X-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 0, 0))); // A-G neighbours G-Y
            edge = FindEdge(edges, 1000, 1000, 300, 1000); // C-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 1000))); // C-E neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 300, 1000))); // C-E neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 1000, 0, 1000))); // C-E neighbours E-X
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // C-E neighbours D-C
            edge = FindEdge(edges, 300, 1000, 0, 1000); // E-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 300, 1000))); // E-X neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 300, 1000))); // E-X neighbours C-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 500))); // E-X neighbours X-G
            edge = FindEdge(edges, 0, 1000, 0, 500); // X-G
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 0, 500))); // X-G neighbours A-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 1000, 0, 1000))); // X-G neighbours E-X
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 0, 0))); // X-G neighbours G-Y
            edge = FindEdge(edges, 0, 500, 0, 0); // G-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 0, 500))); // G-Y neighbours A-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 500))); // G-Y neighbours X-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 300, 0))); // G-Y neighbours Y-F
            edge = FindEdge(edges, 0, 0, 300, 0); // Y-F
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 300, 0))); // Y-F neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 0, 0))); // Y-F neighbours G-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 0, 1000, 0))); // Y-F neighbours F-D
            edge = FindEdge(edges, 300, 0, 1000, 0); // F-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 0))); // F-D neighbours B-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 300, 0))); // F-D neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 300, 0))); // F-D neighbours Y-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 1000))); // F-D neighbours D-C
            edge = FindEdge(edges, 1000, 0, 1000, 1000); // D-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 1000))); // D-C neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 0))); // D-C neighbours B-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 300, 1000))); // D-C neighbours C-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 0, 1000, 0))); // D-C neighbours F-D
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

            Assume.That(() => 17 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 500, 300, 500, 700)); // A-B
            Assume.That(() => HasEdge(edges, 500, 700, 0, 700)); // B-C
            Assume.That(() => HasEdge(edges, 500, 700, 1000, 700)); // B-G
            Assume.That(() => HasEdge(edges, 500, 300, 0, 300)); // A-D
            Assume.That(() => HasEdge(edges, 500, 300, 1000, 300)); // A-F
            Assume.That(() => HasEdge(edges, 500, 300, 500, 0)); // A-E
            Assume.That(() => HasEdge(edges, 500, 700, 500, 1000)); // B-H
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 700)); // W-C
            Assume.That(() => HasEdge(edges, 0, 700, 0, 300)); // C-D
            Assume.That(() => HasEdge(edges, 0, 300, 0, 0)); // D-X
            Assume.That(() => HasEdge(edges, 0, 0, 500, 0)); // X-E
            Assume.That(() => HasEdge(edges, 500, 0, 1000, 0)); // E-Y
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 300)); // Y-F
            Assume.That(() => HasEdge(edges, 1000, 300, 1000, 700)); // F-G
            Assume.That(() => HasEdge(edges, 1000, 700, 1000, 1000)); // G-Z
            Assume.That(() => HasEdge(edges, 1000, 1000, 500, 1000)); // Z-H
            Assume.That(() => HasEdge(edges, 500, 1000, 0, 1000)); // H-W

            // Assert

            VoronoiEdge edge = FindEdge(edges, 500, 300, 500, 700); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(6, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 0, 700))); // A-B neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 1000, 700))); // A-B neighbours B-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 0, 300))); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 1000, 300))); // A-B neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 0))); // A-B neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 500, 1000))); // A-B neighbours B-H
            edge = FindEdge(edges, 500, 700, 0, 700); // B-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 700))); // B-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 1000, 700))); // B-C neighbours B-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 500, 1000))); // B-C neighbours B-H
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 700))); // B-C neighbours W-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 0, 300))); // B-C neighbours C-D
            edge = FindEdge(edges, 500, 700, 1000, 700); // B-G
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 700))); // B-G neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 0, 700))); // B-G neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 500, 1000))); // B-G neighbours B-H
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 300, 1000, 700))); // B-G neighbours F-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 700, 1000, 1000))); // B-G neighbours G-Z
            edge = FindEdge(edges, 500, 300, 0, 300); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 700))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 1000, 300))); // A-D neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 0))); // A-D neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 0, 300))); // A-D neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 300, 0, 0))); // A-D neighbours D-X
            edge = FindEdge(edges, 500, 300, 1000, 300); // A-F
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 700))); // A-F neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 0, 300))); // A-F neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 0))); // A-F neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 300))); // A-F neighbours Y-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 300, 1000, 700))); // A-F neighbours F-G
            edge = FindEdge(edges, 500, 300, 500, 0); // A-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 700))); // A-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 0, 300))); // A-E neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 1000, 300))); // A-E neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 500, 0))); // A-E neighbours X-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 0, 1000, 0))); // A-E neighbours E-Y
            edge = FindEdge(edges, 500, 700, 500, 1000); // B-H
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 700))); // B-H neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 0, 700))); // B-H neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 1000, 700))); // B-H neighbours B-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 500, 1000))); // B-H neighbours Z-H
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 1000, 0, 1000))); // B-H neighbours H-W
            edge = FindEdge(edges, 0, 1000, 0, 700); // W-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 0, 700))); // W-C neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 0, 300))); // W-C neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 1000, 0, 1000))); // W-C neighbours H-W
            edge = FindEdge(edges, 0, 700, 0, 300); // C-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 0, 700))); // C-D neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 0, 300))); // C-D neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 700))); // C-D neighbours W-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 300, 0, 0))); // C-D neighbours D-X
            edge = FindEdge(edges, 0, 300, 0, 0); // D-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 0, 300))); // D-X neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 700, 0, 300))); // D-X neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 500, 0))); // D-X neighbours X-E
            edge = FindEdge(edges, 0, 0, 500, 0); // X-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 0))); // X-E neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 300, 0, 0))); // X-E neighbours D-X
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 0, 1000, 0))); // X-E neighbours E-Y
            edge = FindEdge(edges, 500, 0, 1000, 0); // E-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 0))); // E-Y neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 500, 0))); // E-Y neighbours X-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 300))); // E-Y neighbours Y-F
            edge = FindEdge(edges, 1000, 0, 1000, 300); // Y-F
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 1000, 300))); // Y-F neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 0, 1000, 0))); // Y-F neighbours E-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 300, 1000, 700))); // Y-F neighbours F-G
            edge = FindEdge(edges, 1000, 300, 1000, 700); // F-G
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 1000, 700))); // F-G neighbours B-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 1000, 300))); // F-G neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 300))); // F-G neighbours Y-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 700, 1000, 1000))); // F-G neighbours G-Z
            edge = FindEdge(edges, 1000, 700, 1000, 1000); // G-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 1000, 700))); // G-Z neighbours B-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 300, 1000, 700))); // G-Z neighbours F-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 500, 1000))); // G-Z neighbours Z-H
            edge = FindEdge(edges, 1000, 1000, 500, 1000); // Z-H
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 500, 1000))); // Z-H neighbours B-H
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 700, 1000, 1000))); // Z-H neighbours G-Z
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 1000, 0, 1000))); // Z-H neighbours H-W
            edge = FindEdge(edges, 500, 1000, 0, 1000); // H-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 500, 1000))); // H-W neighbours B-H
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 700))); // H-W neighbours W-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 500, 1000))); // H-W neighbours Z-H
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

            Assume.That(() => 17 == edges.Count);
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 300, 500, 700, 500)); // A-B
            Assume.That(() => HasEdge(edges, 700, 500, 700, 1000)); // B-C
            Assume.That(() => HasEdge(edges, 700, 500, 700, 0)); // B-G
            Assume.That(() => HasEdge(edges, 300, 500, 300, 1000)); // A-D
            Assume.That(() => HasEdge(edges, 300, 500, 300, 0)); // A-F
            Assume.That(() => HasEdge(edges, 300, 500, 0, 500)); // A-E
            Assume.That(() => HasEdge(edges, 700, 500, 1000, 500)); // B-H
            Assume.That(() => HasEdge(edges, 1000, 1000, 700, 1000)); // W-C
            Assume.That(() => HasEdge(edges, 700, 1000, 300, 1000)); // C-D
            Assume.That(() => HasEdge(edges, 300, 1000, 0, 1000)); // D-X
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 500)); // X-E
            Assume.That(() => HasEdge(edges, 0, 500, 0, 0)); // E-Y
            Assume.That(() => HasEdge(edges, 0, 0, 300, 0)); // Y-F
            Assume.That(() => HasEdge(edges, 300, 0, 700, 0)); // F-G
            Assume.That(() => HasEdge(edges, 700, 0, 1000, 0)); // G-Z
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 500)); // Z-H
            Assume.That(() => HasEdge(edges, 1000, 500, 1000, 1000)); // H-W

            // Assert

            VoronoiEdge edge = FindEdge(edges, 300, 500, 700, 500); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(6, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 700, 1000))); // A-B neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 700, 0))); // A-B neighbours B-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 300, 1000))); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 300, 0))); // A-B neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 0, 500))); // A-B neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 1000, 500))); // A-B neighbours B-H
            edge = FindEdge(edges, 700, 500, 700, 1000); // B-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 700, 500))); // B-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 700, 0))); // B-C neighbours B-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 1000, 500))); // B-C neighbours B-H
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 700, 1000))); // B-C neighbours W-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 1000, 300, 1000))); // B-C neighbours C-D
            edge = FindEdge(edges, 700, 500, 700, 0); // B-G
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 700, 500))); // B-G neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 700, 1000))); // B-G neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 1000, 500))); // B-G neighbours B-H
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 0, 700, 0))); // B-G neighbours F-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 0, 1000, 0))); // B-G neighbours G-Z
            edge = FindEdge(edges, 300, 500, 300, 1000); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 700, 500))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 300, 0))); // A-D neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 0, 500))); // A-D neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 1000, 300, 1000))); // A-D neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 1000, 0, 1000))); // A-D neighbours D-X
            edge = FindEdge(edges, 300, 500, 300, 0); // A-F
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 700, 500))); // A-F neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 300, 1000))); // A-F neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 0, 500))); // A-F neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 300, 0))); // A-F neighbours Y-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 0, 700, 0))); // A-F neighbours F-G
            edge = FindEdge(edges, 300, 500, 0, 500); // A-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 700, 500))); // A-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 300, 1000))); // A-E neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 300, 0))); // A-E neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 500))); // A-E neighbours X-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 0, 0))); // A-E neighbours E-Y
            edge = FindEdge(edges, 700, 500, 1000, 500); // B-H
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 700, 500))); // B-H neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 700, 1000))); // B-H neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 700, 0))); // B-H neighbours B-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 500))); // B-H neighbours Z-H
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 500, 1000, 1000))); // B-H neighbours H-W
            edge = FindEdge(edges, 1000, 1000, 700, 1000); // W-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 700, 1000))); // W-C neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 1000, 300, 1000))); // W-C neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 500, 1000, 1000))); // W-C neighbours H-W
            edge = FindEdge(edges, 700, 1000, 300, 1000); // C-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 700, 1000))); // C-D neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 300, 1000))); // C-D neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 700, 1000))); // C-D neighbours W-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 1000, 0, 1000))); // C-D neighbours D-X
            edge = FindEdge(edges, 300, 1000, 0, 1000); // D-X
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 300, 1000))); // D-X neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 1000, 300, 1000))); // D-X neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 500))); // D-X neighbours X-E
            edge = FindEdge(edges, 0, 1000, 0, 500); // X-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 0, 500))); // X-E neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 1000, 0, 1000))); // X-E neighbours D-X
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 0, 0))); // X-E neighbours E-Y
            edge = FindEdge(edges, 0, 500, 0, 0); // E-Y
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 0, 500))); // E-Y neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 1000, 0, 500))); // E-Y neighbours X-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 300, 0))); // E-Y neighbours Y-F
            edge = FindEdge(edges, 0, 0, 300, 0); // Y-F
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 300, 0))); // Y-F neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 0, 0))); // Y-F neighbours E-Y
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 0, 700, 0))); // Y-F neighbours F-G
            edge = FindEdge(edges, 300, 0, 700, 0); // F-G
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 700, 0))); // F-G neighbours B-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 300, 0))); // F-G neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 0, 300, 0))); // F-G neighbours Y-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 0, 1000, 0))); // F-G neighbours G-Z
            edge = FindEdge(edges, 700, 0, 1000, 0); // G-Z
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 700, 0))); // G-Z neighbours B-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 0, 700, 0))); // G-Z neighbours F-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 500))); // G-Z neighbours Z-H
            edge = FindEdge(edges, 1000, 0, 1000, 500); // Z-H
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 1000, 500))); // Z-H neighbours B-H
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 0, 1000, 0))); // Z-H neighbours G-Z
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 500, 1000, 1000))); // Z-H neighbours H-W
            edge = FindEdge(edges, 1000, 500, 1000, 1000); // H-W
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 1000, 500))); // H-W neighbours B-H
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 1000, 700, 1000))); // H-W neighbours W-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 0, 1000, 500))); // H-W neighbours Z-H
        }

    }
}
