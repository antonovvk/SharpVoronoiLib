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
    /// These tests are run without generating the border edges, i.e. <see cref="BorderEdgeGeneration.DoNotMakeBorderEdges"/>.
    /// </summary>
    /// <remarks>
    /// This is an AUTO-GENERATED test fixture class from UnitTestGenerator.
    /// This is one of the several auto-generated fixture classes each checking a different part of the algorithm's result.
    /// It contains a bunch of known Voronoi site layouts, including many edge cases.
    /// </remarks>
    [Parallelizable(ParallelScope.All)]
    [TestFixture]
    public class GeneratedTest_EdgeNeighbours_OpenBorders
    {
        [Test]
        public void NoPoints()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
            };

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 |                                                  
            //      |                                                  
            //  700 |                                                  
            //      |                                                  
            //  600 |                                                  
            //      |                                                  
            //  500 |                                                  
            //      |                                                  
            //  400 |                                                  
            //      |                                                  
            //  300 |                                                  
            //      |                                                  
            //  200 |                                                  
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 0 == edges.Count);

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

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 |                                                  
            //      |                                                  
            //  700 |                                                  
            //      |                                                  
            //  600 |                                                  
            //      |                                                  
            //  500 |                        1                         
            //      |                                                  
            //  400 |                                                  
            //      |                                                  
            //  300 |                                                  
            //      |                                                  
            //  200 |                                                  
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 0 == edges.Count);

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

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 |                                                  
            //      |                                                  
            //  700 |                                                  
            //      |                                                  
            //  600 |                                                  
            //      |                                                  
            //  500 |         1                                        
            //      |                                                  
            //  400 |                                                  
            //      |                                                  
            //  300 |                                                  
            //      |                                                  
            //  200 |                                                  
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 0 == edges.Count);

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

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 |                        1                         
            //      |                                                  
            //  700 |                                                  
            //      |                                                  
            //  600 |                                                  
            //      |                                                  
            //  500 |                                                  
            //      |                                                  
            //  400 |                                                  
            //      |                                                  
            //  300 |                                                  
            //      |                                                  
            //  200 |                                                  
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 0 == edges.Count);

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

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 |                                                  
            //      |                                                  
            //  700 |                                                  
            //      |                                                  
            //  600 |                                                  
            //      |                                                  
            //  500 |                                       1          
            //      |                                                  
            //  400 |                                                  
            //      |                                                  
            //  300 |                                                  
            //      |                                                  
            //  200 |                                                  
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 0 == edges.Count);

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

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 |                                                  
            //      |                                                  
            //  700 |                                                  
            //      |                                                  
            //  600 |                                                  
            //      |                                                  
            //  500 |                                                  
            //      |                                                  
            //  400 |                                                  
            //      |                                                  
            //  300 |                                                  
            //      |                                                  
            //  200 |                        1                         
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 0 == edges.Count);

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

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 |                                                  
            //      |                                                  
            //  700 |         1                                        
            //      |                                                  
            //  600 |                                                  
            //      |                                                  
            //  500 |                                                  
            //      |                                                  
            //  400 |                                                  
            //      |                                                  
            //  300 |                                                  
            //      |                                                  
            //  200 |                                                  
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 0 == edges.Count);

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

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 |                                  1               
            //      |                                                  
            //  700 |                                                  
            //      |                                                  
            //  600 |                                                  
            //      |                                                  
            //  500 |                                                  
            //      |                                                  
            //  400 |                                                  
            //      |                                                  
            //  300 |                                                  
            //      |                                                  
            //  200 |                                                  
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 0 == edges.Count);

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

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 |                                                  
            //      |                                                  
            //  700 |                                                  
            //      |                                                  
            //  600 |                                                  
            //      |                                                  
            //  500 |                                                  
            //      |                                                  
            //  400 |                                                  
            //      |                                                  
            //  300 |                                       1          
            //      |                                                  
            //  200 |                                                  
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 0 == edges.Count);

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

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 |                                                  
            //      |                                                  
            //  700 |                                                  
            //      |                                                  
            //  600 |                                                  
            //      |                                                  
            //  500 |                                                  
            //      |                                                  
            //  400 |                                                  
            //      |                                                  
            //  300 |                                                  
            //      |                                                  
            //  200 |              1                                   
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 0 == edges.Count);

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

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 |                                                  
            //      |                                                  
            //  700 |                                                  
            //      |                                                  
            //  600 |                                                  
            //      |                                                  
            //  500 1                                                  
            //      |                                                  
            //  400 |                                                  
            //      |                                                  
            //  300 |                                                  
            //      |                                                  
            //  200 |                                                  
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 0 == edges.Count);

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

            // 1000 ↑                        1                         
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 |                                                  
            //      |                                                  
            //  700 |                                                  
            //      |                                                  
            //  600 |                                                  
            //      |                                                  
            //  500 |                                                  
            //      |                                                  
            //  400 |                                                  
            //      |                                                  
            //  300 |                                                  
            //      |                                                  
            //  200 |                                                  
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 0 == edges.Count);

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

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 |                                                  
            //      |                                                  
            //  700 |                                                  
            //      |                                                  
            //  600 |                                                  
            //      |                                                  
            //  500 |                                                 1
            //      |                                                  
            //  400 |                                                  
            //      |                                                  
            //  300 |                                                  
            //      |                                                  
            //  200 |                                                  
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 0 == edges.Count);

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

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 |                                                  
            //      |                                                  
            //  700 |                                                  
            //      |                                                  
            //  600 |                                                  
            //      |                                                  
            //  500 |                                                  
            //      |                                                  
            //  400 |                                                  
            //      |                                                  
            //  300 |                                                  
            //      |                                                  
            //  200 |                                                  
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └------------------------1------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 0 == edges.Count);

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

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 |                                                  
            //      |                                                  
            //  700 1                                                  
            //      |                                                  
            //  600 |                                                  
            //      |                                                  
            //  500 |                                                  
            //      |                                                  
            //  400 |                                                  
            //      |                                                  
            //  300 |                                                  
            //      |                                                  
            //  200 |                                                  
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 0 == edges.Count);

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

            // 1000 ↑                                  1               
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 |                                                  
            //      |                                                  
            //  700 |                                                  
            //      |                                                  
            //  600 |                                                  
            //      |                                                  
            //  500 |                                                  
            //      |                                                  
            //  400 |                                                  
            //      |                                                  
            //  300 |                                                  
            //      |                                                  
            //  200 |                                                  
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 0 == edges.Count);

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

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 |                                                  
            //      |                                                  
            //  700 |                                                  
            //      |                                                  
            //  600 |                                                  
            //      |                                                  
            //  500 |                                                  
            //      |                                                  
            //  400 |                                                  
            //      |                                                  
            //  300 |                                                 1
            //      |                                                  
            //  200 |                                                  
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 0 == edges.Count);

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

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 |                                                  
            //      |                                                  
            //  700 |                                                  
            //      |                                                  
            //  600 |                                                  
            //      |                                                  
            //  500 |                                                  
            //      |                                                  
            //  400 |                                                  
            //      |                                                  
            //  300 |                                                  
            //      |                                                  
            //  200 |                                                  
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └--------------1----------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 0 == edges.Count);

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

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 |                                                  
            //      |                                                  
            //  700 |                                                  
            //      |                                                  
            //  600 |                                                  
            //      |                                                  
            //  500 |                                                  
            //      |                                                  
            //  400 |                                                  
            //      |                                                  
            //  300 |                                                  
            //      |                                                  
            //  200 |                                                  
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 1-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 0 == edges.Count);

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

            // 1000 1                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 |                                                  
            //      |                                                  
            //  700 |                                                  
            //      |                                                  
            //  600 |                                                  
            //      |                                                  
            //  500 |                                                  
            //      |                                                  
            //  400 |                                                  
            //      |                                                  
            //  300 |                                                  
            //      |                                                  
            //  200 |                                                  
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 0 == edges.Count);

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

            // 1000 ↑                                                 1
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 |                                                  
            //      |                                                  
            //  700 |                                                  
            //      |                                                  
            //  600 |                                                  
            //      |                                                  
            //  500 |                                                  
            //      |                                                  
            //  400 |                                                  
            //      |                                                  
            //  300 |                                                  
            //      |                                                  
            //  200 |                                                  
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 0 == edges.Count);

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

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 |                                                  
            //      |                                                  
            //  700 |                                                  
            //      |                                                  
            //  600 |                                                  
            //      |                                                  
            //  500 |                                                  
            //      |                                                  
            //  400 |                                                  
            //      |                                                  
            //  300 |                                                  
            //      |                                                  
            //  200 |                                                  
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------1
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 0 == edges.Count);

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

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 |                                                  
            //      |                                                  
            //  700 |                        1                         
            //      |                                                  
            //  600 |                                                  
            //      |                                                  
            //  500 A-------------------------------------------------B
            //      |                                                  
            //  400 |                                                  
            //      |                                                  
            //  300 |                        2                         
            //      |                                                  
            //  200 |                                                  
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 1 == edges.Count);
            Assume.That(() => AnyEdgeBetween(edges, 0, 500, 1000, 500)); // A-B

            // Assert

            Assert.AreEqual(0, FindEdge(edges, 0, 500, 1000, 500).Neighbours.Count()); // A-B
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

            // 1000 ↑                        A                         
            //      |                        |                         
            //  900 |                        |                         
            //      |                        |                         
            //  800 |                        |                         
            //      |                        |                         
            //  700 |                        |                         
            //      |                        |                         
            //  600 |                        |                         
            //      |                        |                         
            //  500 |              2         |         1               
            //      |                        |                         
            //  400 |                        |                         
            //      |                        |                         
            //  300 |                        |                         
            //      |                        |                         
            //  200 |                        |                         
            //      |                        |                         
            //  100 |                        |                         
            //      |                        |                         
            //    0 └------------------------B------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 1 == edges.Count);
            Assume.That(() => AnyEdgeBetween(edges, 500, 1000, 500, 0)); // A-B

            // Assert

            Assert.AreEqual(0, FindEdge(edges, 500, 1000, 500, 0).Neighbours.Count()); // A-B
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

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                        1                         
            //      |                                                  
            //  800 |                                                  
            //      |                                                  
            //  700 A-------------------------------------------------B
            //      |                                                  
            //  600 |                                                  
            //      |                                                  
            //  500 |                        2                         
            //      |                                                  
            //  400 |                                                  
            //      |                                                  
            //  300 |                                                  
            //      |                                                  
            //  200 |                                                  
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 1 == edges.Count);
            Assume.That(() => AnyEdgeBetween(edges, 0, 700, 1000, 700)); // A-B

            // Assert

            Assert.AreEqual(0, FindEdge(edges, 0, 700, 1000, 700).Neighbours.Count()); // A-B
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

            // 1000 ↑                                  A               
            //      |                                  |               
            //  900 |                                  |               
            //      |                                  |               
            //  800 |                                  |               
            //      |                                  |               
            //  700 |                                  |               
            //      |                                  |               
            //  600 |                                  |               
            //      |                                  |               
            //  500 |                        2         |         1     
            //      |                                  |               
            //  400 |                                  |               
            //      |                                  |               
            //  300 |                                  |               
            //      |                                  |               
            //  200 |                                  |               
            //      |                                  |               
            //  100 |                                  |               
            //      |                                  |               
            //    0 └----------------------------------B--------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 1 == edges.Count);
            Assume.That(() => AnyEdgeBetween(edges, 700, 1000, 700, 0)); // A-B

            // Assert

            Assert.AreEqual(0, FindEdge(edges, 700, 1000, 700, 0).Neighbours.Count()); // A-B
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

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                        1                         
            //      |                                                  
            //  800 |                                                  
            //      |                                                  
            //  700 A-------------------------------------------------B
            //      |                                                  
            //  600 |                                                  
            //      |                                                  
            //  500 |                        2                         
            //      |                                                  
            //  400 |                                                  
            //      |                                                  
            //  300 C-------------------------------------------------D
            //      |                                                  
            //  200 |                                                  
            //      |                                                  
            //  100 |                        3                         
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 2 == edges.Count);
            Assume.That(() => AnyEdgeBetween(edges, 0, 700, 1000, 700)); // A-B
            Assume.That(() => AnyEdgeBetween(edges, 0, 300, 1000, 300)); // C-D

            // Assert

            Assert.AreEqual(0, FindEdge(edges, 0, 700, 1000, 700).Neighbours.Count()); // A-B
            Assert.AreEqual(0, FindEdge(edges, 0, 300, 1000, 300).Neighbours.Count()); // C-D
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

            // 1000 ↑              C                   A               
            //      |              |                   |               
            //  900 |              |                   |               
            //      |              |                   |               
            //  800 |              |                   |               
            //      |              |                   |               
            //  700 |              |                   |               
            //      |              |                   |               
            //  600 |              |                   |               
            //      |              |                   |               
            //  500 |    3         |         2         |         1     
            //      |              |                   |               
            //  400 |              |                   |               
            //      |              |                   |               
            //  300 |              |                   |               
            //      |              |                   |               
            //  200 |              |                   |               
            //      |              |                   |               
            //  100 |              |                   |               
            //      |              |                   |               
            //    0 └--------------D-------------------B--------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 2 == edges.Count);
            Assume.That(() => AnyEdgeBetween(edges, 700, 1000, 700, 0)); // A-B
            Assume.That(() => AnyEdgeBetween(edges, 300, 1000, 300, 0)); // C-D

            // Assert

            Assert.AreEqual(0, FindEdge(edges, 700, 1000, 700, 0).Neighbours.Count()); // A-B
            Assert.AreEqual(0, FindEdge(edges, 300, 1000, 300, 0).Neighbours.Count()); // C-D
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

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 |                        1                         
            //      |                                                  
            //  700 A-------------------------------------------------B
            //      |                                                  
            //  600 |                        2                         
            //      |                                                  
            //  500 C-------------------------------------------------D
            //      |                                                  
            //  400 |                        3                         
            //      |                                                  
            //  300 E-------------------------------------------------F
            //      |                                                  
            //  200 |                        4                         
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 3 == edges.Count);
            Assume.That(() => AnyEdgeBetween(edges, 0, 700, 1000, 700)); // A-B
            Assume.That(() => AnyEdgeBetween(edges, 0, 500, 1000, 500)); // C-D
            Assume.That(() => AnyEdgeBetween(edges, 0, 300, 1000, 300)); // E-F

            // Assert

            Assert.AreEqual(0, FindEdge(edges, 0, 700, 1000, 700).Neighbours.Count()); // A-B
            Assert.AreEqual(0, FindEdge(edges, 0, 500, 1000, 500).Neighbours.Count()); // C-D
            Assert.AreEqual(0, FindEdge(edges, 0, 300, 1000, 300).Neighbours.Count()); // E-F
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

            // 1000 ↑              E         C         A               
            //      |              |         |         |               
            //  900 |              |         |         |               
            //      |              |         |         |               
            //  800 |              |         |         |               
            //      |              |         |         |               
            //  700 |              |         |         |               
            //      |              |         |         |               
            //  600 |              |         |         |               
            //      |              |         |         |               
            //  500 |         4    |    3    |    2    |    1          
            //      |              |         |         |               
            //  400 |              |         |         |               
            //      |              |         |         |               
            //  300 |              |         |         |               
            //      |              |         |         |               
            //  200 |              |         |         |               
            //      |              |         |         |               
            //  100 |              |         |         |               
            //      |              |         |         |               
            //    0 └--------------F---------D---------B--------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 3 == edges.Count);
            Assume.That(() => AnyEdgeBetween(edges, 700, 1000, 700, 0)); // A-B
            Assume.That(() => AnyEdgeBetween(edges, 500, 1000, 500, 0)); // C-D
            Assume.That(() => AnyEdgeBetween(edges, 300, 1000, 300, 0)); // E-F

            // Assert

            Assert.AreEqual(0, FindEdge(edges, 700, 1000, 700, 0).Neighbours.Count()); // A-B
            Assert.AreEqual(0, FindEdge(edges, 500, 1000, 500, 0).Neighbours.Count()); // C-D
            Assert.AreEqual(0, FindEdge(edges, 300, 1000, 300, 0).Neighbours.Count()); // E-F
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

            // 1000 ↑                                                ,B
            //      |                                              ,'  
            //  900 |                                           ,·'    
            //      |                                         ,'       
            //  800 |                                      ,·'         
            //      |                                    ,'            
            //  700 |              1                  ,·'              
            //      |                               ,'                 
            //  600 |                            ,·'                   
            //      |                          ,'                      
            //  500 |                       ,·'                        
            //      |                     ,'                           
            //  400 |                  ,·'                             
            //      |                ,'                                
            //  300 |             ,·'                  2               
            //      |           ,'                                     
            //  200 |        ,·'                                       
            //      |      ,'                                          
            //  100 |   ,·'                                            
            //      | ,'                                               
            //    0 A'------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 1 == edges.Count);
            Assume.That(() => AnyEdgeBetween(edges, 0, 0, 1000, 1000)); // A-B

            // Assert

            Assert.AreEqual(0, FindEdge(edges, 0, 0, 1000, 1000).Neighbours.Count()); // A-B
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

            // 1000 A,                                                 
            //      | ',                                               
            //  900 |   '·,                                            
            //      |      ',                                          
            //  800 |        '·,                                       
            //      |           ',                                     
            //  700 |             '·,                  1               
            //      |                ',                                
            //  600 |                  '·,                             
            //      |                     ',                           
            //  500 |                       '·,                        
            //      |                          ',                      
            //  400 |                            '·,                   
            //      |                               ',                 
            //  300 |              2                  '·,              
            //      |                                    ',            
            //  200 |                                      '·,         
            //      |                                         ',       
            //  100 |                                           '·,    
            //      |                                              ',  
            //    0 └------------------------------------------------'B
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 1 == edges.Count);
            Assume.That(() => AnyEdgeBetween(edges, 0, 1000, 1000, 0)); // A-B

            // Assert

            Assert.AreEqual(0, FindEdge(edges, 0, 1000, 1000, 0).Neighbours.Count()); // A-B
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

            // 1000 ↑                                      ,B          
            //      |                                    ,'            
            //  900 |                                 ,·'              
            //      |                               ,'                 
            //  800 |         1                  ,·'                   
            //      |                          ,'                      
            //  700 |                       ,·'                        
            //      |                     ,'                           
            //  600 |                  ,·'                             
            //      |                ,'                                
            //  500 |             ,·'                                  
            //      |           ,'                                     
            //  400 |        ,·'                  2                    
            //      |      ,'                                          
            //  300 |   ,·'                                            
            //      | ,'                                               
            //  200 A'                                                 
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 1 == edges.Count);
            Assume.That(() => AnyEdgeBetween(edges, 0, 200, 800, 1000)); // A-B

            // Assert

            Assert.AreEqual(0, FindEdge(edges, 0, 200, 800, 1000).Neighbours.Count()); // A-B
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

            // 1000 ↑         A,                                       
            //      |           ',                                     
            //  900 |             '·,                                  
            //      |                ',                                
            //  800 |                  '·,                  1          
            //      |                     ',                           
            //  700 |                       '·,                        
            //      |                          ',                      
            //  600 |                            '·,                   
            //      |                               ',                 
            //  500 |                                 '·,              
            //      |                                    ',            
            //  400 |                   2                  '·,         
            //      |                                         ',       
            //  300 |                                           '·,    
            //      |                                              ',  
            //  200 |                                                'B
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 1 == edges.Count);
            Assume.That(() => AnyEdgeBetween(edges, 200, 1000, 1000, 200)); // A-B

            // Assert

            Assert.AreEqual(0, FindEdge(edges, 200, 1000, 1000, 200).Neighbours.Count()); // A-B
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

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 |                                                ,A
            //      |                                              ,'  
            //  700 |                                           ,·'    
            //      |                                         ,'       
            //  600 |                   2                  ,·'         
            //      |                                    ,'            
            //  500 |                                 ,·'              
            //      |                               ,'                 
            //  400 |                            ,·'                   
            //      |                          ,'                      
            //  300 |                       ,·'                        
            //      |                     ,'                           
            //  200 |                  ,·'                  1          
            //      |                ,'                                
            //  100 |             ,·'                                  
            //      |           ,'                                     
            //    0 └---------B'--------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 1 == edges.Count);
            Assume.That(() => AnyEdgeBetween(edges, 1000, 800, 200, 0)); // A-B

            // Assert

            Assert.AreEqual(0, FindEdge(edges, 1000, 800, 200, 0).Neighbours.Count()); // A-B
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

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 B,                                                 
            //      | ',                                               
            //  700 |   '·,                                            
            //      |      ',                                          
            //  600 |        '·,                  2                    
            //      |           ',                                     
            //  500 |             '·,                                  
            //      |                ',                                
            //  400 |                  '·,                             
            //      |                     ',                           
            //  300 |                       '·,                        
            //      |                          ',                      
            //  200 |         1                  '·,                   
            //      |                               ',                 
            //  100 |                                 '·,              
            //      |                                    ',            
            //    0 └--------------------------------------'A---------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 1 == edges.Count);
            Assume.That(() => AnyEdgeBetween(edges, 800, 0, 0, 800)); // A-B

            // Assert

            Assert.AreEqual(0, FindEdge(edges, 800, 0, 0, 800).Neighbours.Count()); // A-B
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

            // 1000 A,                                                 
            //      | ',                                               
            //  900 |   '·,                                            
            //      |      ',                                          
            //  800 |        '·,                  2                    
            //      |           ',                                     
            //  700 |             '·,                                  
            //      |                ',                                
            //  600 |                  '·,                             
            //      |                     ',                           
            //  500 |                       '·,                        
            //      |                          ',                      
            //  400 |         1                  '·,                   
            //      |                               ',                 
            //  300 |                                 '·,              
            //      |                                    ',            
            //  200 |                                      '·,         
            //      |                                         ',       
            //  100 |                                           '·,    
            //      |                                              ',  
            //    0 └------------------------------------------------'B
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 1 == edges.Count);
            Assume.That(() => AnyEdgeBetween(edges, 0, 1000, 1000, 0)); // A-B

            // Assert

            Assert.AreEqual(0, FindEdge(edges, 0, 1000, 1000, 0).Neighbours.Count()); // A-B
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

            // 1000 ↑                                                ,A
            //      |                                              ,'  
            //  900 |                                           ,·'    
            //      |                                         ,'       
            //  800 |                   1                  ,·'         
            //      |                                    ,'            
            //  700 |                                 ,·'              
            //      |                               ,'                 
            //  600 |                            ,·'                   
            //      |                          ,'                      
            //  500 |                       ,·'                        
            //      |                     ,'                           
            //  400 |                  ,·'                  2          
            //      |                ,'                                
            //  300 |             ,·'                                  
            //      |           ,'                                     
            //  200 |        ,·'                                       
            //      |      ,'                                          
            //  100 |   ,·'                                            
            //      | ,'                                               
            //    0 B'------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 1 == edges.Count);
            Assume.That(() => AnyEdgeBetween(edges, 1000, 1000, 0, 0)); // A-B

            // Assert

            Assert.AreEqual(0, FindEdge(edges, 1000, 1000, 0, 0).Neighbours.Count()); // A-B
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

            // 1000 B,                                                 
            //      | ',                                               
            //  900 |   '·,                                            
            //      |      ',                                          
            //  800 |        '·,                                       
            //      |           ',                                     
            //  700 |             '·,                                  
            //      |                ',                                
            //  600 |                  '·,                  1          
            //      |                     ',                           
            //  500 |                       '·,                        
            //      |                          ',                      
            //  400 |                            '·,                   
            //      |                               ',                 
            //  300 |                                 '·,              
            //      |                                    ',            
            //  200 |                   2                  '·,         
            //      |                                         ',       
            //  100 |                                           '·,    
            //      |                                              ',  
            //    0 └------------------------------------------------'A
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 1 == edges.Count);
            Assume.That(() => AnyEdgeBetween(edges, 1000, 0, 0, 1000)); // A-B

            // Assert

            Assert.AreEqual(0, FindEdge(edges, 1000, 0, 0, 1000).Neighbours.Count()); // A-B
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

            // 1000 ↑                                                ,B
            //      |                                              ,'  
            //  900 |                                           ,·'    
            //      |                                         ,'       
            //  800 |                                      ,·'         
            //      |                                    ,'            
            //  700 |                                 ,·'              
            //      |                               ,'                 
            //  600 |         2                  ,·'                   
            //      |                          ,'                      
            //  500 |                       ,·'                        
            //      |                     ,'                           
            //  400 |                  ,·'                             
            //      |                ,'                                
            //  300 |             ,·'                                  
            //      |           ,'                                     
            //  200 |        ,·'                  1                    
            //      |      ,'                                          
            //  100 |   ,·'                                            
            //      | ,'                                               
            //    0 A'------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 1 == edges.Count);
            Assume.That(() => AnyEdgeBetween(edges, 0, 0, 1000, 1000)); // A-B

            // Assert

            Assert.AreEqual(0, FindEdge(edges, 0, 0, 1000, 1000).Neighbours.Count()); // A-B
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

            // 1000 A,,                                                
            //      |  ''·,,                                           
            //  900 |       ''·,,                      2               
            //      |            ''·,,                                 
            //  800 |                 ''·,,                            
            //      |                      ''·,,                       
            //  700 |                           ''·,,                  
            //      |                                ''·,,             
            //  600 |                                     ''·,,        
            //      |                                          ''·,,   
            //  500 |                        1                      ''B
            //      |                                                  
            //  400 |                                                  
            //      |                                                  
            //  300 |                                                  
            //      |                                                  
            //  200 |                                                  
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 1 == edges.Count);
            Assume.That(() => AnyEdgeBetween(edges, 0, 1000, 1000, 500)); // A-B

            // Assert

            Assert.AreEqual(0, FindEdge(edges, 0, 1000, 1000, 500).Neighbours.Count()); // A-B
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

            // 1000 ↑                                                 A
            //      |                                                ' 
            //  900 |                                              ,'  
            //      |                                             ,    
            //  800 |                                            ·     
            //      |                                           '      
            //  700 |                                         ,'       
            //      |                                        ,         
            //  600 |                                       ·          
            //      |                                      '           
            //  500 |                        1           ,'            
            //      |                                   ,              
            //  400 |                                  ·               
            //      |                                 '                
            //  300 |                               ,'           2     
            //      |                              ,                   
            //  200 |                             ·                    
            //      |                            '                     
            //  100 |                          ,'                      
            //      |                         ,                        
            //    0 └------------------------B------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 1 == edges.Count);
            Assume.That(() => AnyEdgeBetween(edges, 1000, 1000, 500, 0)); // A-B

            // Assert

            Assert.AreEqual(0, FindEdge(edges, 1000, 1000, 500, 0).Neighbours.Count()); // A-B
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

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 |                                                  
            //      |                                                  
            //  700 |                                                  
            //      |                                                  
            //  600 |                                                  
            //      |                                                  
            //  500 B,,                      1                         
            //      |  ''·,,                                           
            //  400 |       ''·,,                                      
            //      |            ''·,,                                 
            //  300 |                 ''·,,                            
            //      |                      ''·,,                       
            //  200 |                           ''·,,                  
            //      |                                ''·,,             
            //  100 |              2                      ''·,,        
            //      |                                          ''·,,   
            //    0 └-----------------------------------------------''A
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 1 == edges.Count);
            Assume.That(() => AnyEdgeBetween(edges, 1000, 0, 0, 500)); // A-B

            // Assert

            Assert.AreEqual(0, FindEdge(edges, 1000, 0, 0, 500).Neighbours.Count()); // A-B
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

            // 1000 ↑                        B                         
            //      |                       '                          
            //  900 |                     ,'                           
            //      |                    ,                             
            //  800 |                   ·                              
            //      |                  '                               
            //  700 |    2           ,'                                
            //      |               ,                                  
            //  600 |              ·                                   
            //      |             '                                    
            //  500 |           ,'           1                         
            //      |          ,                                       
            //  400 |         ·                                        
            //      |        '                                         
            //  300 |      ,'                                          
            //      |     ,                                            
            //  200 |    ·                                             
            //      |   '                                              
            //  100 | ,'                                               
            //      |,                                                 
            //    0 A-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 1 == edges.Count);
            Assume.That(() => AnyEdgeBetween(edges, 0, 0, 500, 1000)); // A-B

            // Assert

            Assert.AreEqual(0, FindEdge(edges, 0, 0, 500, 1000).Neighbours.Count()); // A-B
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

            // 1000 ↑                                 ,D               
            //      |                               ,'                 
            //  900 |                            ,·'                   
            //      |                          ,'                      
            //  800 |         1             ,·'                        
            //      |                     ,'                           
            //  700 |                  ,·'                           ,C
            //      |                ,'                            ,'  
            //  600 |             ,·'                           ,·'    
            //      |           ,'                            ,'       
            //  500 |        ,·'             2             ,·'         
            //      |      ,'                            ,'            
            //  400 |   ,·'                           ,·'              
            //      | ,'                            ,'                 
            //  300 A'                           ,·'                   
            //      |                          ,'                      
            //  200 |                       ,·'             3          
            //      |                     ,'                           
            //  100 |                  ,·'                             
            //      |                ,'                                
            //    0 └--------------B'---------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 2 == edges.Count);
            Assume.That(() => AnyEdgeBetween(edges, 0, 300, 700, 1000)); // A-D
            Assume.That(() => AnyEdgeBetween(edges, 300, 0, 1000, 700)); // B-C

            // Assert

            Assert.AreEqual(0, FindEdge(edges, 0, 300, 700, 1000).Neighbours.Count()); // A-D
            Assert.AreEqual(0, FindEdge(edges, 300, 0, 1000, 700).Neighbours.Count()); // B-C
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

            // 1000 ↑              A,                                  
            //      |                ',                                
            //  900 |                  '·,                             
            //      |                     ',                           
            //  800 |                       '·,             1          
            //      |                          ',                      
            //  700 B,                           '·,                   
            //      | ',                            ',                 
            //  600 |   '·,                           '·,              
            //      |      ',                            ',            
            //  500 |        '·,             2             '·,         
            //      |           ',                            ',       
            //  400 |             '·,                           '·,    
            //      |                ',                            ',  
            //  300 |                  '·,                           'D
            //      |                     ',                           
            //  200 |         3             '·,                        
            //      |                          ',                      
            //  100 |                            '·,                   
            //      |                               ',                 
            //    0 └---------------------------------'C--------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 2 == edges.Count);
            Assume.That(() => AnyEdgeBetween(edges, 300, 1000, 1000, 300)); // A-D
            Assume.That(() => AnyEdgeBetween(edges, 0, 700, 700, 0)); // B-C

            // Assert

            Assert.AreEqual(0, FindEdge(edges, 300, 1000, 1000, 300).Neighbours.Count()); // A-D
            Assert.AreEqual(0, FindEdge(edges, 0, 700, 700, 0).Neighbours.Count()); // B-C
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

            // 1000 ↑                            ,D                  ,C
            //      |                          ,'                  ,'  
            //  900 |                       ,·'                 ,·'    
            //      |                     ,'                  ,'       
            //  800 |         1        ,·'                 ,·'         
            //      |                ,'                  ,'            
            //  700 |             ,·'                 ,·'              
            //      |           ,'                  ,'                 
            //  600 |        ,·'        2        ,·'                   
            //      |      ,'                  ,'                      
            //  500 |   ,·'                 ,·'                        
            //      | ,'                  ,'                           
            //  400 A'                 ,·'        3                    
            //      |                ,'                                
            //  300 |             ,·'                                  
            //      |           ,'                                     
            //  200 |        ,·'                                       
            //      |      ,'                                          
            //  100 |   ,·'                                            
            //      | ,'                                               
            //    0 B'------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 2 == edges.Count);
            Assume.That(() => AnyEdgeBetween(edges, 0, 400, 600, 1000)); // A-D
            Assume.That(() => AnyEdgeBetween(edges, 0, 0, 1000, 1000)); // B-C

            // Assert

            Assert.AreEqual(0, FindEdge(edges, 0, 400, 600, 1000).Neighbours.Count()); // A-D
            Assert.AreEqual(0, FindEdge(edges, 0, 0, 1000, 1000).Neighbours.Count()); // B-C
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

            // 1000 B,                  A,                             
            //      | ',                  ',                           
            //  900 |   '·,                 '·,                        
            //      |      ',                  ',                      
            //  800 |        '·,                 '·,        1          
            //      |           ',                  ',                 
            //  700 |             '·,                 '·,              
            //      |                ',                  ',            
            //  600 |                  '·,        2        '·,         
            //      |                     ',                  ',       
            //  500 |                       '·,                 '·,    
            //      |                          ',                  ',  
            //  400 |                   3        '·,                 'D
            //      |                               ',                 
            //  300 |                                 '·,              
            //      |                                    ',            
            //  200 |                                      '·,         
            //      |                                         ',       
            //  100 |                                           '·,    
            //      |                                              ',  
            //    0 └------------------------------------------------'C
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 2 == edges.Count);
            Assume.That(() => AnyEdgeBetween(edges, 400, 1000, 1000, 400)); // A-D
            Assume.That(() => AnyEdgeBetween(edges, 0, 1000, 1000, 0)); // B-C

            // Assert

            Assert.AreEqual(0, FindEdge(edges, 400, 1000, 1000, 400).Neighbours.Count()); // A-D
            Assert.AreEqual(0, FindEdge(edges, 0, 1000, 1000, 0).Neighbours.Count()); // B-C
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

            // 1000 ↑                                                ,B
            //      |                                              ,'  
            //  900 |                                           ,·'    
            //      |                                         ,'       
            //  800 |                                      ,·'         
            //      |                                    ,'            
            //  700 |                                 ,·'              
            //      |                               ,'                 
            //  600 |                   3        ,·'                 ,A
            //      |                          ,'                  ,'  
            //  500 |                       ,·'                 ,·'    
            //      |                     ,'                  ,'       
            //  400 |                  ,·'        2        ,·'         
            //      |                ,'                  ,'            
            //  300 |             ,·'                 ,·'              
            //      |           ,'                  ,'                 
            //  200 |        ,·'                 ,·'        1          
            //      |      ,'                  ,'                      
            //  100 |   ,·'                 ,·'                        
            //      | ,'                  ,'                           
            //    0 C'------------------D'----------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 2 == edges.Count);
            Assume.That(() => AnyEdgeBetween(edges, 1000, 600, 400, 0)); // A-D
            Assume.That(() => AnyEdgeBetween(edges, 1000, 1000, 0, 0)); // B-C

            // Assert

            Assert.AreEqual(0, FindEdge(edges, 1000, 600, 400, 0).Neighbours.Count()); // A-D
            Assert.AreEqual(0, FindEdge(edges, 1000, 1000, 0, 0).Neighbours.Count()); // B-C
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

            // 1000 C,                                                 
            //      | ',                                               
            //  900 |   '·,                                            
            //      |      ',                                          
            //  800 |        '·,                                       
            //      |           ',                                     
            //  700 |             '·,                                  
            //      |                ',                                
            //  600 D,                 '·,        3                    
            //      | ',                  ',                           
            //  500 |   '·,                 '·,                        
            //      |      ',                  ',                      
            //  400 |        '·,        2        '·,                   
            //      |           ',                  ',                 
            //  300 |             '·,                 '·,              
            //      |                ',                  ',            
            //  200 |         1        '·,                 '·,         
            //      |                     ',                  ',       
            //  100 |                       '·,                 '·,    
            //      |                          ',                  ',  
            //    0 └----------------------------'A------------------'B
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 2 == edges.Count);
            Assume.That(() => AnyEdgeBetween(edges, 600, 0, 0, 600)); // A-D
            Assume.That(() => AnyEdgeBetween(edges, 1000, 0, 0, 1000)); // B-C

            // Assert

            Assert.AreEqual(0, FindEdge(edges, 600, 0, 0, 600).Neighbours.Count()); // A-D
            Assert.AreEqual(0, FindEdge(edges, 1000, 0, 0, 1000).Neighbours.Count()); // B-C
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

            // 1000 ↑                            ,F                  ,E
            //      |                          ,'                  ,'  
            //  900 |                       ,·'                 ,·'    
            //      |                     ,'                  ,'       
            //  800 |         1        ,·'                 ,·'         
            //      |                ,'                  ,'            
            //  700 |             ,·'                 ,·'              
            //      |           ,'                  ,'                 
            //  600 |        ,·'        2        ,·'                 ,D
            //      |      ,'                  ,'                  ,'  
            //  500 |   ,·'                 ,·'                 ,·'    
            //      | ,'                  ,'                  ,'       
            //  400 A'                 ,·'        3        ,·'         
            //      |                ,'                  ,'            
            //  300 |             ,·'                 ,·'              
            //      |           ,'                  ,'                 
            //  200 |        ,·'                 ,·'        4          
            //      |      ,'                  ,'                      
            //  100 |   ,·'                 ,·'                        
            //      | ,'                  ,'                           
            //    0 B'------------------C'----------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 3 == edges.Count);
            Assume.That(() => AnyEdgeBetween(edges, 0, 400, 600, 1000)); // A-F
            Assume.That(() => AnyEdgeBetween(edges, 0, 0, 1000, 1000)); // B-E
            Assume.That(() => AnyEdgeBetween(edges, 400, 0, 1000, 600)); // C-D

            // Assert

            Assert.AreEqual(0, FindEdge(edges, 0, 400, 600, 1000).Neighbours.Count()); // A-F
            Assert.AreEqual(0, FindEdge(edges, 0, 0, 1000, 1000).Neighbours.Count()); // B-E
            Assert.AreEqual(0, FindEdge(edges, 400, 0, 1000, 600).Neighbours.Count()); // C-D
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

            // 1000 B,                  A,                             
            //      | ',                  ',                           
            //  900 |   '·,                 '·,                        
            //      |      ',                  ',                      
            //  800 |        '·,                 '·,        1          
            //      |           ',                  ',                 
            //  700 |             '·,                 '·,              
            //      |                ',                  ',            
            //  600 C,                 '·,        2        '·,         
            //      | ',                  ',                  ',       
            //  500 |   '·,                 '·,                 '·,    
            //      |      ',                  ',                  ',  
            //  400 |        '·,        3        '·,                 'F
            //      |           ',                  ',                 
            //  300 |             '·,                 '·,              
            //      |                ',                  ',            
            //  200 |         4        '·,                 '·,         
            //      |                     ',                  ',       
            //  100 |                       '·,                 '·,    
            //      |                          ',                  ',  
            //    0 └----------------------------'D------------------'E
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 3 == edges.Count);
            Assume.That(() => AnyEdgeBetween(edges, 400, 1000, 1000, 400)); // A-F
            Assume.That(() => AnyEdgeBetween(edges, 0, 1000, 1000, 0)); // B-E
            Assume.That(() => AnyEdgeBetween(edges, 0, 600, 600, 0)); // C-D

            // Assert

            Assert.AreEqual(0, FindEdge(edges, 400, 1000, 1000, 400).Neighbours.Count()); // A-F
            Assert.AreEqual(0, FindEdge(edges, 0, 1000, 1000, 0).Neighbours.Count()); // B-E
            Assert.AreEqual(0, FindEdge(edges, 0, 600, 600, 0).Neighbours.Count()); // C-D
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

            // 1000 ↑                                                ,D
            //      |                                              ,'  
            //  900 |                                           ,·'    
            //      |                                         ,'       
            //  800 |                                      ,·'         
            //      |                                    ,'            
            //  700 |                                 ,·'              
            //      |                               ,'                 
            //  600 |                            ,·'                   
            //      |                          ,'                      
            //  500 |              1        ,·'                        
            //      |                     ,'                           
            //  400 B-------------------A'                             
            //      |                   |                              
            //  300 |              2    |    3                         
            //      |                   |                              
            //  200 |                   |                              
            //      |                   |                              
            //  100 |                   |                              
            //      |                   |                              
            //    0 └-------------------C-----------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 3 == edges.Count);
            Assume.That(() => AnyEdgeBetween(edges, 400, 400, 0, 400)); // A-B
            Assume.That(() => AnyEdgeBetween(edges, 400, 400, 400, 0)); // A-C
            Assume.That(() => AnyEdgeBetween(edges, 400, 400, 1000, 1000)); // A-D

            // Assert

            VoronoiEdge edge = FindEdge(edges, 400, 400, 0, 400); // A-B
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 400, 0))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 1000, 1000))); // A-B neighbours A-D
            edge = FindEdge(edges, 400, 400, 400, 0); // A-C
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 0, 400))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 1000, 1000))); // A-C neighbours A-D
            edge = FindEdge(edges, 400, 400, 1000, 1000); // A-D
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 0, 400))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 400, 0))); // A-D neighbours A-C
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

            // 1000 ↑                   B                              
            //      |                   |                              
            //  900 |                   |                              
            //      |                   |                              
            //  800 |                   |                              
            //      |                   |                              
            //  700 |              2    |    1                         
            //      |                   |                              
            //  600 C-------------------A,                             
            //      |                     ',                           
            //  500 |              3        '·,                        
            //      |                          ',                      
            //  400 |                            '·,                   
            //      |                               ',                 
            //  300 |                                 '·,              
            //      |                                    ',            
            //  200 |                                      '·,         
            //      |                                         ',       
            //  100 |                                           '·,    
            //      |                                              ',  
            //    0 └------------------------------------------------'D
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 3 == edges.Count);
            Assume.That(() => AnyEdgeBetween(edges, 400, 600, 400, 1000)); // A-B
            Assume.That(() => AnyEdgeBetween(edges, 400, 600, 0, 600)); // A-C
            Assume.That(() => AnyEdgeBetween(edges, 400, 600, 1000, 0)); // A-D

            // Assert

            VoronoiEdge edge = FindEdge(edges, 400, 600, 400, 1000); // A-B
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 0, 600))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 1000, 0))); // A-B neighbours A-D
            edge = FindEdge(edges, 400, 600, 0, 600); // A-C
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 400, 1000))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 1000, 0))); // A-C neighbours A-D
            edge = FindEdge(edges, 400, 600, 1000, 0); // A-D
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 400, 1000))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 0, 600))); // A-D neighbours A-C
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

            // 1000 ↑                             C                    
            //      |                             |                    
            //  900 |                             |                    
            //      |                             |                    
            //  800 |                             |                    
            //      |                             |                    
            //  700 |                        3    |    2               
            //      |                             |                    
            //  600 |                            ,A-------------------B
            //      |                          ,'                      
            //  500 |                       ,·'        1               
            //      |                     ,'                           
            //  400 |                  ,·'                             
            //      |                ,'                                
            //  300 |             ,·'                                  
            //      |           ,'                                     
            //  200 |        ,·'                                       
            //      |      ,'                                          
            //  100 |   ,·'                                            
            //      | ,'                                               
            //    0 D'------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 3 == edges.Count);
            Assume.That(() => AnyEdgeBetween(edges, 600, 600, 1000, 600)); // A-B
            Assume.That(() => AnyEdgeBetween(edges, 600, 600, 600, 1000)); // A-C
            Assume.That(() => AnyEdgeBetween(edges, 600, 600, 0, 0)); // A-D

            // Assert

            VoronoiEdge edge = FindEdge(edges, 600, 600, 1000, 600); // A-B
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 600, 1000))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 0, 0))); // A-B neighbours A-D
            edge = FindEdge(edges, 600, 600, 600, 1000); // A-C
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 1000, 600))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 0, 0))); // A-C neighbours A-D
            edge = FindEdge(edges, 600, 600, 0, 0); // A-D
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 1000, 600))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 600, 1000))); // A-D neighbours A-C
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

            // 1000 D,                                                 
            //      | ',                                               
            //  900 |   '·,                                            
            //      |      ',                                          
            //  800 |        '·,                                       
            //      |           ',                                     
            //  700 |             '·,                                  
            //      |                ',                                
            //  600 |                  '·,                             
            //      |                     ',                           
            //  500 |                       '·,        3               
            //      |                          ',                      
            //  400 |                            'A-------------------C
            //      |                             |                    
            //  300 |                        1    |    2               
            //      |                             |                    
            //  200 |                             |                    
            //      |                             |                    
            //  100 |                             |                    
            //      |                             |                    
            //    0 └-----------------------------B-------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 3 == edges.Count);
            Assume.That(() => AnyEdgeBetween(edges, 600, 400, 600, 0)); // A-B
            Assume.That(() => AnyEdgeBetween(edges, 600, 400, 1000, 400)); // A-C
            Assume.That(() => AnyEdgeBetween(edges, 600, 400, 0, 1000)); // A-D

            // Assert

            VoronoiEdge edge = FindEdge(edges, 600, 400, 600, 0); // A-B
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 1000, 400))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 0, 1000))); // A-B neighbours A-D
            edge = FindEdge(edges, 600, 400, 1000, 400); // A-C
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 600, 0))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 0, 1000))); // A-C neighbours A-D
            edge = FindEdge(edges, 600, 400, 0, 1000); // A-D
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 600, 0))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 1000, 400))); // A-D neighbours A-C
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

            // 1000 ↑                        D                         
            //      |                        |                         
            //  900 |                        |                         
            //      |                        |                         
            //  800 |                        |                         
            //      |                        |                         
            //  700 |                        |                         
            //      |                        |                         
            //  600 |                        |                         
            //      |                        |                         
            //  500 |              3        ,A,        2               
            //      |                     ,'   ',                      
            //  400 |                  ,·'       '·,                   
            //      |                ,'             ',                 
            //  300 |             ,·'        1        '·,              
            //      |           ,'                       ',            
            //  200 |        ,·'                           '·,         
            //      |      ,'                                 ',       
            //  100 |   ,·'                                     '·,    
            //      | ,'                                           ',  
            //    0 B'-----------------------------------------------'C
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 3 == edges.Count);
            Assume.That(() => AnyEdgeBetween(edges, 500, 500, 0, 0)); // A-B
            Assume.That(() => AnyEdgeBetween(edges, 500, 500, 1000, 0)); // A-C
            Assume.That(() => AnyEdgeBetween(edges, 500, 500, 500, 1000)); // A-D

            // Assert

            VoronoiEdge edge = FindEdge(edges, 500, 500, 0, 0); // A-B
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 0))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 1000))); // A-B neighbours A-D
            edge = FindEdge(edges, 500, 500, 1000, 0); // A-C
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 0))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 1000))); // A-C neighbours A-D
            edge = FindEdge(edges, 500, 500, 500, 1000); // A-D
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 0))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 0))); // A-D neighbours A-C
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

            // 1000 B,                                                 
            //      | ',                                               
            //  900 |   '·,                                            
            //      |      ',                                          
            //  800 |        '·,                                       
            //      |           ',                                     
            //  700 |             '·,        3                         
            //      |                ',                                
            //  600 |                  '·,                             
            //      |                     ',                           
            //  500 |              1        #A------------------------D
            //      |                     ,'                           
            //  400 |                  ,·'                             
            //      |                ,'                                
            //  300 |             ,·'        2                         
            //      |           ,'                                     
            //  200 |        ,·'                                       
            //      |      ,'                                          
            //  100 |   ,·'                                            
            //      | ,'                                               
            //    0 C'------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 3 == edges.Count);
            Assume.That(() => AnyEdgeBetween(edges, 500, 500, 0, 1000)); // A-B
            Assume.That(() => AnyEdgeBetween(edges, 500, 500, 0, 0)); // A-C
            Assume.That(() => AnyEdgeBetween(edges, 500, 500, 1000, 500)); // A-D

            // Assert

            VoronoiEdge edge = FindEdge(edges, 500, 500, 0, 1000); // A-B
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 0))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 500))); // A-B neighbours A-D
            edge = FindEdge(edges, 500, 500, 0, 0); // A-C
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 1000))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 500))); // A-C neighbours A-D
            edge = FindEdge(edges, 500, 500, 1000, 500); // A-D
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 1000))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 0))); // A-D neighbours A-C
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

            // 1000 C,                                               ,B
            //      | ',                                           ,'  
            //  900 |   '·,                                     ,·'    
            //      |      ',                                 ,'       
            //  800 |        '·,                           ,·'         
            //      |           ',                       ,'            
            //  700 |             '·,        1        ,·'              
            //      |                ',             ,'                 
            //  600 |                  '·,       ,·'                   
            //      |                     ',   ,'                      
            //  500 |              2        'A'        3               
            //      |                        |                         
            //  400 |                        |                         
            //      |                        |                         
            //  300 |                        |                         
            //      |                        |                         
            //  200 |                        |                         
            //      |                        |                         
            //  100 |                        |                         
            //      |                        |                         
            //    0 └------------------------D------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 3 == edges.Count);
            Assume.That(() => AnyEdgeBetween(edges, 500, 500, 1000, 1000)); // A-B
            Assume.That(() => AnyEdgeBetween(edges, 500, 500, 0, 1000)); // A-C
            Assume.That(() => AnyEdgeBetween(edges, 500, 500, 500, 0)); // A-D

            // Assert

            VoronoiEdge edge = FindEdge(edges, 500, 500, 1000, 1000); // A-B
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 1000))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 0))); // A-B neighbours A-D
            edge = FindEdge(edges, 500, 500, 0, 1000); // A-C
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 1000))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 0))); // A-C neighbours A-D
            edge = FindEdge(edges, 500, 500, 500, 0); // A-D
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 1000))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 1000))); // A-D neighbours A-C
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

            // 1000 ↑                                                ,C
            //      |                                              ,'  
            //  900 |                                           ,·'    
            //      |                                         ,'       
            //  800 |                                      ,·'         
            //      |                                    ,'            
            //  700 |                        2        ,·'              
            //      |                               ,'                 
            //  600 |                            ,·'                   
            //      |                          ,'                      
            //  500 D------------------------A#        1               
            //      |                          ',                      
            //  400 |                            '·,                   
            //      |                               ',                 
            //  300 |                        3        '·,              
            //      |                                    ',            
            //  200 |                                      '·,         
            //      |                                         ',       
            //  100 |                                           '·,    
            //      |                                              ',  
            //    0 └------------------------------------------------'B
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 3 == edges.Count);
            Assume.That(() => AnyEdgeBetween(edges, 500, 500, 1000, 0)); // A-B
            Assume.That(() => AnyEdgeBetween(edges, 500, 500, 1000, 1000)); // A-C
            Assume.That(() => AnyEdgeBetween(edges, 500, 500, 0, 500)); // A-D

            // Assert

            VoronoiEdge edge = FindEdge(edges, 500, 500, 1000, 0); // A-B
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 1000))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 500))); // A-B neighbours A-D
            edge = FindEdge(edges, 500, 500, 1000, 1000); // A-C
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 0))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 500))); // A-C neighbours A-D
            edge = FindEdge(edges, 500, 500, 0, 500); // A-D
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 0))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 1000))); // A-D neighbours A-C
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

            // 1000 ↑                        D                         
            //      |                        |                         
            //  900 |                        |                         
            //      |                        |                         
            //  800 |                        |                         
            //      |                        |                         
            //  700 |                        |                         
            //      |                        |                         
            //  600 |                        |                         
            //      |                        |                         
            //  500 |                        |                         
            //      |                        |                         
            //  400 |                        |                         
            //      |                        |                         
            //  300 |              3        ,A,        2               
            //      |                     ,'   ',                      
            //  200 |                  ,·'       '·,                   
            //      |                ,'             ',                 
            //  100 |             ,·'        1        '·,              
            //      |           ,'                       ',            
            //    0 └---------B'---------------------------'C---------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 3 == edges.Count);
            Assume.That(() => AnyEdgeBetween(edges, 500, 300, 200, 0)); // A-B
            Assume.That(() => AnyEdgeBetween(edges, 500, 300, 800, 0)); // A-C
            Assume.That(() => AnyEdgeBetween(edges, 500, 300, 500, 1000)); // A-D

            // Assert

            VoronoiEdge edge = FindEdge(edges, 500, 300, 200, 0); // A-B
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 800, 0))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 1000))); // A-B neighbours A-D
            edge = FindEdge(edges, 500, 300, 800, 0); // A-C
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 200, 0))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 1000))); // A-C neighbours A-D
            edge = FindEdge(edges, 500, 300, 500, 1000); // A-D
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 200, 0))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 800, 0))); // A-D neighbours A-C
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

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 B,                                                 
            //      | ',                                               
            //  700 |   '·,        3                                   
            //      |      ',                                          
            //  600 |        '·,                                       
            //      |           ',                                     
            //  500 |    1        #A----------------------------------D
            //      |           ,'                                     
            //  400 |        ,·'                                       
            //      |      ,'                                          
            //  300 |   ,·'        2                                   
            //      | ,'                                               
            //  200 C'                                                 
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 3 == edges.Count);
            Assume.That(() => AnyEdgeBetween(edges, 300, 500, 0, 800)); // A-B
            Assume.That(() => AnyEdgeBetween(edges, 300, 500, 0, 200)); // A-C
            Assume.That(() => AnyEdgeBetween(edges, 300, 500, 1000, 500)); // A-D

            // Assert

            VoronoiEdge edge = FindEdge(edges, 300, 500, 0, 800); // A-B
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 0, 200))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 1000, 500))); // A-B neighbours A-D
            edge = FindEdge(edges, 300, 500, 0, 200); // A-C
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 0, 800))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 1000, 500))); // A-C neighbours A-D
            edge = FindEdge(edges, 300, 500, 1000, 500); // A-D
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 0, 800))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 0, 200))); // A-D neighbours A-C
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

            // 1000 ↑         C,                           ,B          
            //      |           ',                       ,'            
            //  900 |             '·,        1        ,·'              
            //      |                ',             ,'                 
            //  800 |                  '·,       ,·'                   
            //      |                     ',   ,'                      
            //  700 |              2        'A'        3               
            //      |                        |                         
            //  600 |                        |                         
            //      |                        |                         
            //  500 |                        |                         
            //      |                        |                         
            //  400 |                        |                         
            //      |                        |                         
            //  300 |                        |                         
            //      |                        |                         
            //  200 |                        |                         
            //      |                        |                         
            //  100 |                        |                         
            //      |                        |                         
            //    0 └------------------------D------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 3 == edges.Count);
            Assume.That(() => AnyEdgeBetween(edges, 500, 700, 800, 1000)); // A-B
            Assume.That(() => AnyEdgeBetween(edges, 500, 700, 200, 1000)); // A-C
            Assume.That(() => AnyEdgeBetween(edges, 500, 700, 500, 0)); // A-D

            // Assert

            VoronoiEdge edge = FindEdge(edges, 500, 700, 800, 1000); // A-B
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 200, 1000))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 500, 0))); // A-B neighbours A-D
            edge = FindEdge(edges, 500, 700, 200, 1000); // A-C
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 800, 1000))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 500, 0))); // A-C neighbours A-D
            edge = FindEdge(edges, 500, 700, 500, 0); // A-D
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 800, 1000))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 200, 1000))); // A-D neighbours A-C
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

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 |                                                ,C
            //      |                                              ,'  
            //  700 |                                  2        ,·'    
            //      |                                         ,'       
            //  600 |                                      ,·'         
            //      |                                    ,'            
            //  500 D----------------------------------A#        1     
            //      |                                    ',            
            //  400 |                                      '·,         
            //      |                                         ',       
            //  300 |                                  3        '·,    
            //      |                                              ',  
            //  200 |                                                'B
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 3 == edges.Count);
            Assume.That(() => AnyEdgeBetween(edges, 700, 500, 1000, 200)); // A-B
            Assume.That(() => AnyEdgeBetween(edges, 700, 500, 1000, 800)); // A-C
            Assume.That(() => AnyEdgeBetween(edges, 700, 500, 0, 500)); // A-D

            // Assert

            VoronoiEdge edge = FindEdge(edges, 700, 500, 1000, 200); // A-B
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 1000, 800))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 0, 500))); // A-B neighbours A-D
            edge = FindEdge(edges, 700, 500, 1000, 800); // A-C
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 1000, 200))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 0, 500))); // A-C neighbours A-D
            edge = FindEdge(edges, 700, 500, 0, 500); // A-D
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 1000, 200))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 1000, 800))); // A-D neighbours A-C
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

            // 1000 ↑                        D                         
            //      |                        |                         
            //  900 |                        |                         
            //      |                        |                         
            //  800 |                        |                         
            //      |                        |                         
            //  700 |              3        ,A,        2               
            //      |                     ,'   ',                      
            //  600 |                  ,·'       '·,                   
            //      |                ,'             ',                 
            //  500 |             ,·'        1        '·,              
            //      |           ,'                       ',            
            //  400 |        ,·'                           '·,         
            //      |      ,'                                 ',       
            //  300 |   ,·'                                     '·,    
            //      | ,'                                           ',  
            //  200 B'                                               'C
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 3 == edges.Count);
            Assume.That(() => AnyEdgeBetween(edges, 500, 700, 0, 200)); // A-B
            Assume.That(() => AnyEdgeBetween(edges, 500, 700, 1000, 200)); // A-C
            Assume.That(() => AnyEdgeBetween(edges, 500, 700, 500, 1000)); // A-D

            // Assert

            VoronoiEdge edge = FindEdge(edges, 500, 700, 0, 200); // A-B
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 1000, 200))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 500, 1000))); // A-B neighbours A-D
            edge = FindEdge(edges, 500, 700, 1000, 200); // A-C
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 0, 200))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 500, 1000))); // A-C neighbours A-D
            edge = FindEdge(edges, 500, 700, 500, 1000); // A-D
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 0, 200))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 1000, 200))); // A-D neighbours A-C
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

            // 1000 ↑         B,                                       
            //      |           ',                                     
            //  900 |             '·,                                  
            //      |                ',                                
            //  800 |                  '·,                             
            //      |                     ',                           
            //  700 |                       '·,        3               
            //      |                          ',                      
            //  600 |                            '·,                   
            //      |                               ',                 
            //  500 |                        1        #A--------------D
            //      |                               ,'                 
            //  400 |                            ,·'                   
            //      |                          ,'                      
            //  300 |                       ,·'        2               
            //      |                     ,'                           
            //  200 |                  ,·'                             
            //      |                ,'                                
            //  100 |             ,·'                                  
            //      |           ,'                                     
            //    0 └---------C'--------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 3 == edges.Count);
            Assume.That(() => AnyEdgeBetween(edges, 700, 500, 200, 1000)); // A-B
            Assume.That(() => AnyEdgeBetween(edges, 700, 500, 200, 0)); // A-C
            Assume.That(() => AnyEdgeBetween(edges, 700, 500, 1000, 500)); // A-D

            // Assert

            VoronoiEdge edge = FindEdge(edges, 700, 500, 200, 1000); // A-B
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 200, 0))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 1000, 500))); // A-B neighbours A-D
            edge = FindEdge(edges, 700, 500, 200, 0); // A-C
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 200, 1000))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 1000, 500))); // A-C neighbours A-D
            edge = FindEdge(edges, 700, 500, 1000, 500); // A-D
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 200, 1000))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 200, 0))); // A-D neighbours A-C
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

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 C,                                               ,B
            //      | ',                                           ,'  
            //  700 |   '·,                                     ,·'    
            //      |      ',                                 ,'       
            //  600 |        '·,                           ,·'         
            //      |           ',                       ,'            
            //  500 |             '·,        1        ,·'              
            //      |                ',             ,'                 
            //  400 |                  '·,       ,·'                   
            //      |                     ',   ,'                      
            //  300 |              2        'A'        3               
            //      |                        |                         
            //  200 |                        |                         
            //      |                        |                         
            //  100 |                        |                         
            //      |                        |                         
            //    0 └------------------------D------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 3 == edges.Count);
            Assume.That(() => AnyEdgeBetween(edges, 500, 300, 1000, 800)); // A-B
            Assume.That(() => AnyEdgeBetween(edges, 500, 300, 0, 800)); // A-C
            Assume.That(() => AnyEdgeBetween(edges, 500, 300, 500, 0)); // A-D

            // Assert

            VoronoiEdge edge = FindEdge(edges, 500, 300, 1000, 800); // A-B
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 0, 800))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 0))); // A-B neighbours A-D
            edge = FindEdge(edges, 500, 300, 0, 800); // A-C
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 1000, 800))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 0))); // A-C neighbours A-D
            edge = FindEdge(edges, 500, 300, 500, 0); // A-D
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 1000, 800))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 0, 800))); // A-D neighbours A-C
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

            // 1000 ↑                                      ,C          
            //      |                                    ,'            
            //  900 |                                 ,·'              
            //      |                               ,'                 
            //  800 |                            ,·'                   
            //      |                          ,'                      
            //  700 |              2        ,·'                        
            //      |                     ,'                           
            //  600 |                  ,·'                             
            //      |                ,'                                
            //  500 D--------------A#        1                         
            //      |                ',                                
            //  400 |                  '·,                             
            //      |                     ',                           
            //  300 |              3        '·,                        
            //      |                          ',                      
            //  200 |                            '·,                   
            //      |                               ',                 
            //  100 |                                 '·,              
            //      |                                    ',            
            //    0 └--------------------------------------'B---------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 3 == edges.Count);
            Assume.That(() => AnyEdgeBetween(edges, 300, 500, 800, 0)); // A-B
            Assume.That(() => AnyEdgeBetween(edges, 300, 500, 800, 1000)); // A-C
            Assume.That(() => AnyEdgeBetween(edges, 300, 500, 0, 500)); // A-D

            // Assert

            VoronoiEdge edge = FindEdge(edges, 300, 500, 800, 0); // A-B
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 800, 1000))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 0, 500))); // A-B neighbours A-D
            edge = FindEdge(edges, 300, 500, 800, 1000); // A-C
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 800, 0))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 0, 500))); // A-C neighbours A-D
            edge = FindEdge(edges, 300, 500, 0, 500); // A-D
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 800, 0))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 800, 1000))); // A-D neighbours A-C
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

            // 1000 E,                                               ,H
            //      | ',                                           ,'  
            //  900 |   '·,                                     ,·'    
            //      |      ',                                 ,'       
            //  800 |        '·,                           ,·'         
            //      |           ',                       ,'            
            //  700 |             '·,        5        ,·'              
            //      |                ',             ,'                 
            //  600 |                  'A---------D'                   
            //      |                   |         |                    
            //  500 |              2    |    1    |    4               
            //      |                   |         |                    
            //  400 |                  ,B---------C,                   
            //      |                ,'             ',                 
            //  300 |             ,·'        3        '·,              
            //      |           ,'                       ',            
            //  200 |        ,·'                           '·,         
            //      |      ,'                                 ',       
            //  100 |   ,·'                                     '·,    
            //      | ,'                                           ',  
            //    0 F'-----------------------------------------------'G
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 8 == edges.Count);
            Assume.That(() => AnyEdgeBetween(edges, 400, 600, 400, 400)); // A-B
            Assume.That(() => AnyEdgeBetween(edges, 400, 400, 600, 400)); // B-C
            Assume.That(() => AnyEdgeBetween(edges, 600, 400, 600, 600)); // C-D
            Assume.That(() => AnyEdgeBetween(edges, 600, 600, 400, 600)); // D-A
            Assume.That(() => AnyEdgeBetween(edges, 400, 600, 0, 1000)); // A-E
            Assume.That(() => AnyEdgeBetween(edges, 400, 400, 0, 0)); // B-F
            Assume.That(() => AnyEdgeBetween(edges, 600, 400, 1000, 0)); // C-G
            Assume.That(() => AnyEdgeBetween(edges, 600, 600, 1000, 1000)); // D-H

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
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 400, 400))); // A-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 400, 600))); // A-E neighbours D-A
            edge = FindEdge(edges, 400, 400, 0, 0); // B-F
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 400, 400))); // B-F neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 600, 400))); // B-F neighbours B-C
            edge = FindEdge(edges, 600, 400, 1000, 0); // C-G
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 600, 400))); // C-G neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 600, 600))); // C-G neighbours C-D
            edge = FindEdge(edges, 600, 600, 1000, 1000); // D-H
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 600, 600))); // D-H neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 400, 600))); // D-H neighbours D-A
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

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 E,                                               ,H
            //      | ',                                           ,'  
            //  700 |   '·,                                     ,·'    
            //      |      ',                                 ,'       
            //  600 |        '·,                           ,·'         
            //      |           ',                       ,'            
            //  500 |             '·,        5        ,·'              
            //      |                ',             ,'                 
            //  400 |                  'A---------D'                   
            //      |                   |         |                    
            //  300 |              2    |    1    |    4               
            //      |                   |         |                    
            //  200 |                  ,B---------C,                   
            //      |                ,'             ',                 
            //  100 |             ,·'        3        '·,              
            //      |           ,'                       ',            
            //    0 └---------F'---------------------------'G---------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 8 == edges.Count);
            Assume.That(() => AnyEdgeBetween(edges, 400, 400, 400, 200)); // A-B
            Assume.That(() => AnyEdgeBetween(edges, 400, 200, 600, 200)); // B-C
            Assume.That(() => AnyEdgeBetween(edges, 600, 200, 600, 400)); // C-D
            Assume.That(() => AnyEdgeBetween(edges, 600, 400, 400, 400)); // D-A
            Assume.That(() => AnyEdgeBetween(edges, 400, 400, 0, 800)); // A-E
            Assume.That(() => AnyEdgeBetween(edges, 400, 200, 200, 0)); // B-F
            Assume.That(() => AnyEdgeBetween(edges, 600, 200, 800, 0)); // C-G
            Assume.That(() => AnyEdgeBetween(edges, 600, 400, 1000, 800)); // D-H

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
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 400, 200))); // A-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 400, 400))); // A-E neighbours D-A
            edge = FindEdge(edges, 400, 200, 200, 0); // B-F
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 400, 200))); // B-F neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 200, 600, 200))); // B-F neighbours B-C
            edge = FindEdge(edges, 600, 200, 800, 0); // C-G
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 200, 600, 200))); // C-G neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 200, 600, 400))); // C-G neighbours C-D
            edge = FindEdge(edges, 600, 400, 1000, 800); // D-H
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 200, 600, 400))); // D-H neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 400, 400))); // D-H neighbours D-A
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

            // 1000 ↑                                      ,E          
            //      |                                    ,'            
            //  900 |                                 ,·'              
            //      |                               ,'                 
            //  800 F,                           ,·'                   
            //      | ',                       ,'                      
            //  700 |   '·,        2        ,·'                        
            //      |      ',             ,'                           
            //  600 |        'B---------A'                             
            //      |         |         |                              
            //  500 |    3    |    1    |    5                         
            //      |         |         |                              
            //  400 |        ,C---------D,                             
            //      |      ,'             ',                           
            //  300 |   ,·'        4        '·,                        
            //      | ,'                       ',                      
            //  200 G'                           '·,                   
            //      |                               ',                 
            //  100 |                                 '·,              
            //      |                                    ',            
            //    0 └--------------------------------------'H---------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 8 == edges.Count);
            Assume.That(() => AnyEdgeBetween(edges, 400, 600, 200, 600)); // A-B
            Assume.That(() => AnyEdgeBetween(edges, 200, 600, 200, 400)); // B-C
            Assume.That(() => AnyEdgeBetween(edges, 200, 400, 400, 400)); // C-D
            Assume.That(() => AnyEdgeBetween(edges, 400, 400, 400, 600)); // D-A
            Assume.That(() => AnyEdgeBetween(edges, 400, 600, 800, 1000)); // A-E
            Assume.That(() => AnyEdgeBetween(edges, 200, 600, 0, 800)); // B-F
            Assume.That(() => AnyEdgeBetween(edges, 200, 400, 0, 200)); // C-G
            Assume.That(() => AnyEdgeBetween(edges, 400, 400, 800, 0)); // D-H

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
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 200, 600))); // A-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 400, 600))); // A-E neighbours D-A
            edge = FindEdge(edges, 200, 600, 0, 800); // B-F
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 200, 600))); // B-F neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 600, 200, 400))); // B-F neighbours B-C
            edge = FindEdge(edges, 200, 400, 0, 200); // C-G
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 600, 200, 400))); // C-G neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 400, 400, 400))); // C-G neighbours C-D
            edge = FindEdge(edges, 400, 400, 800, 0); // D-H
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 400, 400, 400))); // D-H neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 400, 600))); // D-H neighbours D-A
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

            // 1000 ↑         G,                           ,F          
            //      |           ',                       ,'            
            //  900 |             '·,        3        ,·'              
            //      |                ',             ,'                 
            //  800 |                  'C---------B'                   
            //      |                   |         |                    
            //  700 |              4    |    1    |    2               
            //      |                   |         |                    
            //  600 |                  ,D---------A,                   
            //      |                ,'             ',                 
            //  500 |             ,·'        5        '·,              
            //      |           ,'                       ',            
            //  400 |        ,·'                           '·,         
            //      |      ,'                                 ',       
            //  300 |   ,·'                                     '·,    
            //      | ,'                                           ',  
            //  200 H'                                               'E
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 8 == edges.Count);
            Assume.That(() => AnyEdgeBetween(edges, 600, 600, 600, 800)); // A-B
            Assume.That(() => AnyEdgeBetween(edges, 600, 800, 400, 800)); // B-C
            Assume.That(() => AnyEdgeBetween(edges, 400, 800, 400, 600)); // C-D
            Assume.That(() => AnyEdgeBetween(edges, 400, 600, 600, 600)); // D-A
            Assume.That(() => AnyEdgeBetween(edges, 600, 600, 1000, 200)); // A-E
            Assume.That(() => AnyEdgeBetween(edges, 600, 800, 800, 1000)); // B-F
            Assume.That(() => AnyEdgeBetween(edges, 400, 800, 200, 1000)); // C-G
            Assume.That(() => AnyEdgeBetween(edges, 400, 600, 0, 200)); // D-H

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
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 600, 800))); // A-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 600, 600))); // A-E neighbours D-A
            edge = FindEdge(edges, 600, 800, 800, 1000); // B-F
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 600, 800))); // B-F neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 800, 400, 800))); // B-F neighbours B-C
            edge = FindEdge(edges, 400, 800, 200, 1000); // C-G
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 800, 400, 800))); // C-G neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 800, 400, 600))); // C-G neighbours C-D
            edge = FindEdge(edges, 400, 600, 0, 200); // D-H
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 800, 400, 600))); // D-H neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 600, 600))); // D-H neighbours D-A
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

            // 1000 ↑         H,                                       
            //      |           ',                                     
            //  900 |             '·,                                  
            //      |                ',                                
            //  800 |                  '·,                           ,G
            //      |                     ',                       ,'  
            //  700 |                       '·,        4        ,·'    
            //      |                          ',             ,'       
            //  600 |                            'D---------C'         
            //      |                             |         |          
            //  500 |                        5    |    1    |    3     
            //      |                             |         |          
            //  400 |                            ,A---------B,         
            //      |                          ,'             ',       
            //  300 |                       ,·'        2        '·,    
            //      |                     ,'                       ',  
            //  200 |                  ,·'                           'F
            //      |                ,'                                
            //  100 |             ,·'                                  
            //      |           ,'                                     
            //    0 └---------E'--------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 8 == edges.Count);
            Assume.That(() => AnyEdgeBetween(edges, 600, 400, 800, 400)); // A-B
            Assume.That(() => AnyEdgeBetween(edges, 800, 400, 800, 600)); // B-C
            Assume.That(() => AnyEdgeBetween(edges, 800, 600, 600, 600)); // C-D
            Assume.That(() => AnyEdgeBetween(edges, 600, 600, 600, 400)); // D-A
            Assume.That(() => AnyEdgeBetween(edges, 600, 400, 200, 0)); // A-E
            Assume.That(() => AnyEdgeBetween(edges, 800, 400, 1000, 200)); // B-F
            Assume.That(() => AnyEdgeBetween(edges, 800, 600, 1000, 800)); // C-G
            Assume.That(() => AnyEdgeBetween(edges, 600, 600, 200, 1000)); // D-H

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
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 800, 400))); // A-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 600, 400))); // A-E neighbours D-A
            edge = FindEdge(edges, 800, 400, 1000, 200); // B-F
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 800, 400))); // B-F neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 400, 800, 600))); // B-F neighbours B-C
            edge = FindEdge(edges, 800, 600, 1000, 800); // C-G
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 400, 800, 600))); // C-G neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 600, 600, 600))); // C-G neighbours C-D
            edge = FindEdge(edges, 600, 600, 200, 1000); // D-H
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 600, 600, 600))); // D-H neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 600, 400))); // D-H neighbours D-A
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

            // 1000 ↑                        B                         
            //      |                        |                         
            //  900 |                        |                         
            //      |                        |                         
            //  800 |                        |                         
            //      |                        |                         
            //  700 |              1         |         4               
            //      |                        |                         
            //  600 |                        |                         
            //      |                        |                         
            //  500 C------------------------A------------------------E
            //      |                        |                         
            //  400 |                        |                         
            //      |                        |                         
            //  300 |              2         |         3               
            //      |                        |                         
            //  200 |                        |                         
            //      |                        |                         
            //  100 |                        |                         
            //      |                        |                         
            //    0 └------------------------D------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 4 == edges.Count);
            Assume.That(() => AnyEdgeBetween(edges, 500, 500, 500, 1000)); // A-B
            Assume.That(() => AnyEdgeBetween(edges, 500, 500, 0, 500)); // A-C
            Assume.That(() => AnyEdgeBetween(edges, 500, 500, 500, 0)); // A-D
            Assume.That(() => AnyEdgeBetween(edges, 500, 500, 1000, 500)); // A-E

            // Assert

            VoronoiEdge edge = FindEdge(edges, 500, 500, 500, 1000); // A-B
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 500))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 0))); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 500))); // A-B neighbours A-E
            edge = FindEdge(edges, 500, 500, 0, 500); // A-C
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 1000))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 0))); // A-C neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 500))); // A-C neighbours A-E
            edge = FindEdge(edges, 500, 500, 500, 0); // A-D
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 1000))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 500))); // A-D neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 500))); // A-D neighbours A-E
            edge = FindEdge(edges, 500, 500, 1000, 500); // A-E
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 1000))); // A-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 500))); // A-E neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 0))); // A-E neighbours A-D
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

            // 1000 ↑                        B                         
            //      |                        |                         
            //  900 |                        |                         
            //      |                        |                         
            //  800 |                   1    |    4                    
            //      |                        |                         
            //  700 |                        |                         
            //      |                        |                         
            //  600 |                        |                         
            //      |                        |                         
            //  500 C------------------------A------------------------E
            //      |                        |                         
            //  400 |                        |                         
            //      |                        |                         
            //  300 |                        |                         
            //      |                        |                         
            //  200 |                   2    |    3                    
            //      |                        |                         
            //  100 |                        |                         
            //      |                        |                         
            //    0 └------------------------D------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 4 == edges.Count);
            Assume.That(() => AnyEdgeBetween(edges, 500, 500, 500, 1000)); // A-B
            Assume.That(() => AnyEdgeBetween(edges, 500, 500, 0, 500)); // A-C
            Assume.That(() => AnyEdgeBetween(edges, 500, 500, 500, 0)); // A-D
            Assume.That(() => AnyEdgeBetween(edges, 500, 500, 1000, 500)); // A-E

            // Assert

            VoronoiEdge edge = FindEdge(edges, 500, 500, 500, 1000); // A-B
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 500))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 0))); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 500))); // A-B neighbours A-E
            edge = FindEdge(edges, 500, 500, 0, 500); // A-C
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 1000))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 0))); // A-C neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 500))); // A-C neighbours A-E
            edge = FindEdge(edges, 500, 500, 500, 0); // A-D
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 1000))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 500))); // A-D neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 500))); // A-D neighbours A-E
            edge = FindEdge(edges, 500, 500, 1000, 500); // A-E
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 1000))); // A-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 500))); // A-E neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 0))); // A-E neighbours A-D
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

            // 1000 ↑                        C                         
            //      |                        |                         
            //  900 |                        |                         
            //      |                        |                         
            //  800 |                        |                         
            //      |                        |                         
            //  700 |                        |                         
            //      |                        |                         
            //  600 |         2              |              1          
            //      |                        |                         
            //  500 D------------------------A------------------------B
            //      |                        |                         
            //  400 |         3              |              4          
            //      |                        |                         
            //  300 |                        |                         
            //      |                        |                         
            //  200 |                        |                         
            //      |                        |                         
            //  100 |                        |                         
            //      |                        |                         
            //    0 └------------------------E------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 4 == edges.Count);
            Assume.That(() => AnyEdgeBetween(edges, 500, 500, 1000, 500)); // A-B
            Assume.That(() => AnyEdgeBetween(edges, 500, 500, 500, 1000)); // A-C
            Assume.That(() => AnyEdgeBetween(edges, 500, 500, 0, 500)); // A-D
            Assume.That(() => AnyEdgeBetween(edges, 500, 500, 500, 0)); // A-E

            // Assert

            VoronoiEdge edge = FindEdge(edges, 500, 500, 1000, 500); // A-B
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 1000))); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 500))); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 0))); // A-B neighbours A-E
            edge = FindEdge(edges, 500, 500, 500, 1000); // A-C
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 500))); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 500))); // A-C neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 0))); // A-C neighbours A-E
            edge = FindEdge(edges, 500, 500, 0, 500); // A-D
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 500))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 1000))); // A-D neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 0))); // A-D neighbours A-E
            edge = FindEdge(edges, 500, 500, 500, 0); // A-E
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 500))); // A-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 1000))); // A-E neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 500))); // A-E neighbours A-D
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

            // 1000 ↑         C,                           ,D          
            //      |           ',                       ,'            
            //  900 |             '·,        1        ,·'              
            //      |                ',             ,'                 
            //  800 |                  '·,       ,·'                   
            //      |                     ',   ,'                      
            //  700 |              2        'B'        5               
            //      |                        |                         
            //  600 |                        |                         
            //      |                        |                         
            //  500 |                        |                         
            //      |                        |                         
            //  400 E------------------------A------------------------F
            //      |                        |                         
            //  300 |                        |                         
            //      |                        |                         
            //  200 |                        |                         
            //      |                        |                         
            //  100 |              3         |         4               
            //      |                        |                         
            //    0 └------------------------G------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 6 == edges.Count);
            Assume.That(() => AnyEdgeBetween(edges, 500, 400, 500, 700)); // A-B
            Assume.That(() => AnyEdgeBetween(edges, 500, 700, 200, 1000)); // B-C
            Assume.That(() => AnyEdgeBetween(edges, 500, 700, 800, 1000)); // B-D
            Assume.That(() => AnyEdgeBetween(edges, 500, 400, 0, 400)); // A-E
            Assume.That(() => AnyEdgeBetween(edges, 500, 400, 1000, 400)); // A-F
            Assume.That(() => AnyEdgeBetween(edges, 500, 400, 500, 0)); // A-G

            // Assert

            VoronoiEdge edge = FindEdge(edges, 500, 400, 500, 700); // A-B
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 200, 1000))); // A-B neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 800, 1000))); // A-B neighbours B-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 400, 0, 400))); // A-B neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 400, 1000, 400))); // A-B neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 400, 500, 0))); // A-B neighbours A-G
            edge = FindEdge(edges, 500, 700, 200, 1000); // B-C
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 400, 500, 700))); // B-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 800, 1000))); // B-C neighbours B-D
            edge = FindEdge(edges, 500, 700, 800, 1000); // B-D
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 400, 500, 700))); // B-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 200, 1000))); // B-D neighbours B-C
            edge = FindEdge(edges, 500, 400, 0, 400); // A-E
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 400, 500, 700))); // A-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 400, 1000, 400))); // A-E neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 400, 500, 0))); // A-E neighbours A-G
            edge = FindEdge(edges, 500, 400, 1000, 400); // A-F
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 400, 500, 700))); // A-F neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 400, 0, 400))); // A-F neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 400, 500, 0))); // A-F neighbours A-G
            edge = FindEdge(edges, 500, 400, 500, 0); // A-G
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 400, 500, 700))); // A-G neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 400, 0, 400))); // A-G neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 400, 1000, 400))); // A-G neighbours A-F
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

            // 1000 ↑                   E                              
            //      |                   |                              
            //  900 |                   |                              
            //      |                   |                              
            //  800 |                   |                            ,C
            //      |                   |                          ,'  
            //  700 |    3              |              2        ,·'    
            //      |                   |                     ,'       
            //  600 |                   |                  ,·'         
            //      |                   |                ,'            
            //  500 G-------------------A--------------B#        1     
            //      |                   |                ',            
            //  400 |                   |                  '·,         
            //      |                   |                     ',       
            //  300 |    4              |              5        '·,    
            //      |                   |                          ',  
            //  200 |                   |                            'D
            //      |                   |                              
            //  100 |                   |                              
            //      |                   |                              
            //    0 └-------------------F-----------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 6 == edges.Count);
            Assume.That(() => AnyEdgeBetween(edges, 400, 500, 700, 500)); // A-B
            Assume.That(() => AnyEdgeBetween(edges, 700, 500, 1000, 800)); // B-C
            Assume.That(() => AnyEdgeBetween(edges, 700, 500, 1000, 200)); // B-D
            Assume.That(() => AnyEdgeBetween(edges, 400, 500, 400, 1000)); // A-E
            Assume.That(() => AnyEdgeBetween(edges, 400, 500, 400, 0)); // A-F
            Assume.That(() => AnyEdgeBetween(edges, 400, 500, 0, 500)); // A-G

            // Assert

            VoronoiEdge edge = FindEdge(edges, 400, 500, 700, 500); // A-B
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 1000, 800))); // A-B neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 1000, 200))); // A-B neighbours B-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 500, 400, 1000))); // A-B neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 500, 400, 0))); // A-B neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 500, 0, 500))); // A-B neighbours A-G
            edge = FindEdge(edges, 700, 500, 1000, 800); // B-C
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 500, 700, 500))); // B-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 1000, 200))); // B-C neighbours B-D
            edge = FindEdge(edges, 700, 500, 1000, 200); // B-D
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 500, 700, 500))); // B-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 1000, 800))); // B-D neighbours B-C
            edge = FindEdge(edges, 400, 500, 400, 1000); // A-E
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 500, 700, 500))); // A-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 500, 400, 0))); // A-E neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 500, 0, 500))); // A-E neighbours A-G
            edge = FindEdge(edges, 400, 500, 400, 0); // A-F
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 500, 700, 500))); // A-F neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 500, 400, 1000))); // A-F neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 500, 0, 500))); // A-F neighbours A-G
            edge = FindEdge(edges, 400, 500, 0, 500); // A-G
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 500, 700, 500))); // A-G neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 500, 400, 1000))); // A-G neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 500, 400, 0))); // A-G neighbours A-F
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

            // 1000 ↑                        G                         
            //      |                        |                         
            //  900 |              4         |         3               
            //      |                        |                         
            //  800 |                        |                         
            //      |                        |                         
            //  700 |                        |                         
            //      |                        |                         
            //  600 F------------------------A------------------------E
            //      |                        |                         
            //  500 |                        |                         
            //      |                        |                         
            //  400 |                        |                         
            //      |                        |                         
            //  300 |              5        ,B,        2               
            //      |                     ,'   ',                      
            //  200 |                  ,·'       '·,                   
            //      |                ,'             ',                 
            //  100 |             ,·'        1        '·,              
            //      |           ,'                       ',            
            //    0 └---------D'---------------------------'C---------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 6 == edges.Count);
            Assume.That(() => AnyEdgeBetween(edges, 500, 600, 500, 300)); // A-B
            Assume.That(() => AnyEdgeBetween(edges, 500, 300, 800, 0)); // B-C
            Assume.That(() => AnyEdgeBetween(edges, 500, 300, 200, 0)); // B-D
            Assume.That(() => AnyEdgeBetween(edges, 500, 600, 1000, 600)); // A-E
            Assume.That(() => AnyEdgeBetween(edges, 500, 600, 0, 600)); // A-F
            Assume.That(() => AnyEdgeBetween(edges, 500, 600, 500, 1000)); // A-G

            // Assert

            VoronoiEdge edge = FindEdge(edges, 500, 600, 500, 300); // A-B
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 800, 0))); // A-B neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 200, 0))); // A-B neighbours B-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 600, 1000, 600))); // A-B neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 600, 0, 600))); // A-B neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 600, 500, 1000))); // A-B neighbours A-G
            edge = FindEdge(edges, 500, 300, 800, 0); // B-C
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 600, 500, 300))); // B-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 200, 0))); // B-C neighbours B-D
            edge = FindEdge(edges, 500, 300, 200, 0); // B-D
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 600, 500, 300))); // B-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 800, 0))); // B-D neighbours B-C
            edge = FindEdge(edges, 500, 600, 1000, 600); // A-E
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 600, 500, 300))); // A-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 600, 0, 600))); // A-E neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 600, 500, 1000))); // A-E neighbours A-G
            edge = FindEdge(edges, 500, 600, 0, 600); // A-F
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 600, 500, 300))); // A-F neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 600, 1000, 600))); // A-F neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 600, 500, 1000))); // A-F neighbours A-G
            edge = FindEdge(edges, 500, 600, 500, 1000); // A-G
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 600, 500, 300))); // A-G neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 600, 1000, 600))); // A-G neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 600, 0, 600))); // A-G neighbours A-F
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

            // 1000 ↑                             F                    
            //      |                             |                    
            //  900 |                             |                    
            //      |                             |                    
            //  800 D,                            |                    
            //      | ',                          |                    
            //  700 |   '·,        5              |              4     
            //      |      ',                     |                    
            //  600 |        '·,                  |                    
            //      |           ',                |                    
            //  500 |    1        #B--------------A-------------------G
            //      |           ,'                |                    
            //  400 |        ,·'                  |                    
            //      |      ,'                     |                    
            //  300 |   ,·'        2              |              3     
            //      | ,'                          |                    
            //  200 C'                            |                    
            //      |                             |                    
            //  100 |                             |                    
            //      |                             |                    
            //    0 └-----------------------------E-------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 6 == edges.Count);
            Assume.That(() => AnyEdgeBetween(edges, 600, 500, 300, 500)); // A-B
            Assume.That(() => AnyEdgeBetween(edges, 300, 500, 0, 200)); // B-C
            Assume.That(() => AnyEdgeBetween(edges, 300, 500, 0, 800)); // B-D
            Assume.That(() => AnyEdgeBetween(edges, 600, 500, 600, 0)); // A-E
            Assume.That(() => AnyEdgeBetween(edges, 600, 500, 600, 1000)); // A-F
            Assume.That(() => AnyEdgeBetween(edges, 600, 500, 1000, 500)); // A-G

            // Assert

            VoronoiEdge edge = FindEdge(edges, 600, 500, 300, 500); // A-B
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 0, 200))); // A-B neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 0, 800))); // A-B neighbours B-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 500, 600, 0))); // A-B neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 500, 600, 1000))); // A-B neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 500, 1000, 500))); // A-B neighbours A-G
            edge = FindEdge(edges, 300, 500, 0, 200); // B-C
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 500, 300, 500))); // B-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 0, 800))); // B-C neighbours B-D
            edge = FindEdge(edges, 300, 500, 0, 800); // B-D
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 500, 300, 500))); // B-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 0, 200))); // B-D neighbours B-C
            edge = FindEdge(edges, 600, 500, 600, 0); // A-E
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 500, 300, 500))); // A-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 500, 600, 1000))); // A-E neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 500, 1000, 500))); // A-E neighbours A-G
            edge = FindEdge(edges, 600, 500, 600, 1000); // A-F
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 500, 300, 500))); // A-F neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 500, 600, 0))); // A-F neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 500, 1000, 500))); // A-F neighbours A-G
            edge = FindEdge(edges, 600, 500, 1000, 500); // A-G
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 500, 300, 500))); // A-G neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 500, 600, 0))); // A-G neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 500, 600, 1000))); // A-G neighbours A-F
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

            // 1000 C,                                               ,D
            //      | ',                                           ,'  
            //  900 |   '·,                                     ,·'    
            //      |      ',                                 ,'       
            //  800 |        '·,                           ,·'         
            //      |           ',                       ,'            
            //  700 |             '·,        1        ,·'              
            //      |                ',             ,'                 
            //  600 |                  '·,       ,·'                   
            //      |                     ',   ,'                      
            //  500 |              2        'B'        5               
            //      |                        |                         
            //  400 |                        |                         
            //      |                        |                         
            //  300 E------------------------A------------------------F
            //      |                        |                         
            //  200 |                        |                         
            //      |                        |                         
            //  100 |              3         |         4               
            //      |                        |                         
            //    0 └------------------------G------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 6 == edges.Count);
            Assume.That(() => AnyEdgeBetween(edges, 500, 300, 500, 500)); // A-B
            Assume.That(() => AnyEdgeBetween(edges, 500, 500, 0, 1000)); // B-C
            Assume.That(() => AnyEdgeBetween(edges, 500, 500, 1000, 1000)); // B-D
            Assume.That(() => AnyEdgeBetween(edges, 500, 300, 0, 300)); // A-E
            Assume.That(() => AnyEdgeBetween(edges, 500, 300, 1000, 300)); // A-F
            Assume.That(() => AnyEdgeBetween(edges, 500, 300, 500, 0)); // A-G

            // Assert

            VoronoiEdge edge = FindEdge(edges, 500, 300, 500, 500); // A-B
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 1000))); // A-B neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 1000))); // A-B neighbours B-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 0, 300))); // A-B neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 1000, 300))); // A-B neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 0))); // A-B neighbours A-G
            edge = FindEdge(edges, 500, 500, 0, 1000); // B-C
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 500))); // B-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 1000))); // B-C neighbours B-D
            edge = FindEdge(edges, 500, 500, 1000, 1000); // B-D
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 500))); // B-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 1000))); // B-D neighbours B-C
            edge = FindEdge(edges, 500, 300, 0, 300); // A-E
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 500))); // A-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 1000, 300))); // A-E neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 0))); // A-E neighbours A-G
            edge = FindEdge(edges, 500, 300, 1000, 300); // A-F
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 500))); // A-F neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 0, 300))); // A-F neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 0))); // A-F neighbours A-G
            edge = FindEdge(edges, 500, 300, 500, 0); // A-G
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 500))); // A-G neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 0, 300))); // A-G neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 1000, 300))); // A-G neighbours A-F
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

            // 1000 ↑              E                                 ,C
            //      |              |                               ,'  
            //  900 |              |                            ,·'    
            //      |              |                          ,'       
            //  800 |              |                       ,·'         
            //      |              |                     ,'            
            //  700 |    3         |         2        ,·'              
            //      |              |                ,'                 
            //  600 |              |             ,·'                   
            //      |              |           ,'                      
            //  500 G--------------A---------B#        1               
            //      |              |           ',                      
            //  400 |              |             '·,                   
            //      |              |                ',                 
            //  300 |    4         |         5        '·,              
            //      |              |                     ',            
            //  200 |              |                       '·,         
            //      |              |                          ',       
            //  100 |              |                            '·,    
            //      |              |                               ',  
            //    0 └--------------F---------------------------------'D
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 6 == edges.Count);
            Assume.That(() => AnyEdgeBetween(edges, 300, 500, 500, 500)); // A-B
            Assume.That(() => AnyEdgeBetween(edges, 500, 500, 1000, 1000)); // B-C
            Assume.That(() => AnyEdgeBetween(edges, 500, 500, 1000, 0)); // B-D
            Assume.That(() => AnyEdgeBetween(edges, 300, 500, 300, 1000)); // A-E
            Assume.That(() => AnyEdgeBetween(edges, 300, 500, 300, 0)); // A-F
            Assume.That(() => AnyEdgeBetween(edges, 300, 500, 0, 500)); // A-G

            // Assert

            VoronoiEdge edge = FindEdge(edges, 300, 500, 500, 500); // A-B
            Assert.AreEqual(5, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 1000))); // A-B neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 0))); // A-B neighbours B-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 300, 1000))); // A-B neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 300, 0))); // A-B neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 0, 500))); // A-B neighbours A-G
            edge = FindEdge(edges, 500, 500, 1000, 1000); // B-C
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 500, 500))); // B-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 0))); // B-C neighbours B-D
            edge = FindEdge(edges, 500, 500, 1000, 0); // B-D
            Assert.AreEqual(2, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 500, 500))); // B-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 1000))); // B-D neighbours B-C
            edge = FindEdge(edges, 300, 500, 300, 1000); // A-E
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 500, 500))); // A-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 300, 0))); // A-E neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 0, 500))); // A-E neighbours A-G
            edge = FindEdge(edges, 300, 500, 300, 0); // A-F
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 500, 500))); // A-F neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 300, 1000))); // A-F neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 0, 500))); // A-F neighbours A-G
            edge = FindEdge(edges, 300, 500, 0, 500); // A-G
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 500, 500))); // A-G neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 300, 1000))); // A-G neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 300, 0))); // A-G neighbours A-F
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

            // 1000 ↑                        H                         
            //      |                        |                         
            //  900 |              1         |         2               
            //      |                        |                         
            //  800 |                        |                         
            //      |                        |                         
            //  700 C------------------------B------------------------G
            //      |                        |                         
            //  600 |                        |                         
            //      |                        |                         
            //  500 |              3         |         4               
            //      |                        |                         
            //  400 |                        |                         
            //      |                        |                         
            //  300 D------------------------A------------------------F
            //      |                        |                         
            //  200 |                        |                         
            //      |                        |                         
            //  100 |              5         |         6               
            //      |                        |                         
            //    0 └------------------------E------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 7 == edges.Count);
            Assume.That(() => AnyEdgeBetween(edges, 500, 300, 500, 700)); // A-B
            Assume.That(() => AnyEdgeBetween(edges, 500, 700, 0, 700)); // B-C
            Assume.That(() => AnyEdgeBetween(edges, 500, 700, 1000, 700)); // B-G
            Assume.That(() => AnyEdgeBetween(edges, 500, 300, 0, 300)); // A-D
            Assume.That(() => AnyEdgeBetween(edges, 500, 300, 1000, 300)); // A-F
            Assume.That(() => AnyEdgeBetween(edges, 500, 300, 500, 0)); // A-E
            Assume.That(() => AnyEdgeBetween(edges, 500, 700, 500, 1000)); // B-H

            // Assert

            VoronoiEdge edge = FindEdge(edges, 500, 300, 500, 700); // A-B
            Assert.AreEqual(6, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 0, 700))); // A-B neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 1000, 700))); // A-B neighbours B-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 0, 300))); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 1000, 300))); // A-B neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 0))); // A-B neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 500, 1000))); // A-B neighbours B-H
            edge = FindEdge(edges, 500, 700, 0, 700); // B-C
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 700))); // B-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 1000, 700))); // B-C neighbours B-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 500, 1000))); // B-C neighbours B-H
            edge = FindEdge(edges, 500, 700, 1000, 700); // B-G
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 700))); // B-G neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 0, 700))); // B-G neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 500, 1000))); // B-G neighbours B-H
            edge = FindEdge(edges, 500, 300, 0, 300); // A-D
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 700))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 1000, 300))); // A-D neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 0))); // A-D neighbours A-E
            edge = FindEdge(edges, 500, 300, 1000, 300); // A-F
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 700))); // A-F neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 0, 300))); // A-F neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 0))); // A-F neighbours A-E
            edge = FindEdge(edges, 500, 300, 500, 0); // A-E
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 700))); // A-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 0, 300))); // A-E neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 1000, 300))); // A-E neighbours A-F
            edge = FindEdge(edges, 500, 700, 500, 1000); // B-H
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 700))); // B-H neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 0, 700))); // B-H neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 1000, 700))); // B-H neighbours B-G
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

            // 1000 ↑              D                   C               
            //      |              |                   |               
            //  900 |              |                   |               
            //      |              |                   |               
            //  800 |              |                   |               
            //      |              |                   |               
            //  700 |    5         |         3         |         1     
            //      |              |                   |               
            //  600 |              |                   |               
            //      |              |                   |               
            //  500 E--------------A-------------------B--------------H
            //      |              |                   |               
            //  400 |              |                   |               
            //      |              |                   |               
            //  300 |    6         |         4         |         2     
            //      |              |                   |               
            //  200 |              |                   |               
            //      |              |                   |               
            //  100 |              |                   |               
            //      |              |                   |               
            //    0 └--------------F-------------------G--------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 7 == edges.Count);
            Assume.That(() => AnyEdgeBetween(edges, 300, 500, 700, 500)); // A-B
            Assume.That(() => AnyEdgeBetween(edges, 700, 500, 700, 1000)); // B-C
            Assume.That(() => AnyEdgeBetween(edges, 700, 500, 700, 0)); // B-G
            Assume.That(() => AnyEdgeBetween(edges, 300, 500, 300, 1000)); // A-D
            Assume.That(() => AnyEdgeBetween(edges, 300, 500, 300, 0)); // A-F
            Assume.That(() => AnyEdgeBetween(edges, 300, 500, 0, 500)); // A-E
            Assume.That(() => AnyEdgeBetween(edges, 700, 500, 1000, 500)); // B-H

            // Assert

            VoronoiEdge edge = FindEdge(edges, 300, 500, 700, 500); // A-B
            Assert.AreEqual(6, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 700, 1000))); // A-B neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 700, 0))); // A-B neighbours B-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 300, 1000))); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 300, 0))); // A-B neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 0, 500))); // A-B neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 1000, 500))); // A-B neighbours B-H
            edge = FindEdge(edges, 700, 500, 700, 1000); // B-C
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 700, 500))); // B-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 700, 0))); // B-C neighbours B-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 1000, 500))); // B-C neighbours B-H
            edge = FindEdge(edges, 700, 500, 700, 0); // B-G
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 700, 500))); // B-G neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 700, 1000))); // B-G neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 1000, 500))); // B-G neighbours B-H
            edge = FindEdge(edges, 300, 500, 300, 1000); // A-D
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 700, 500))); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 300, 0))); // A-D neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 0, 500))); // A-D neighbours A-E
            edge = FindEdge(edges, 300, 500, 300, 0); // A-F
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 700, 500))); // A-F neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 300, 1000))); // A-F neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 0, 500))); // A-F neighbours A-E
            edge = FindEdge(edges, 300, 500, 0, 500); // A-E
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 700, 500))); // A-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 300, 1000))); // A-E neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 300, 0))); // A-E neighbours A-F
            edge = FindEdge(edges, 700, 500, 1000, 500); // B-H
            Assert.AreEqual(3, edge.Neighbours.Count());
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 700, 500))); // B-H neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 700, 1000))); // B-H neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 700, 0))); // B-H neighbours B-G
        }

    }
}
