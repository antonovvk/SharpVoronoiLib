#define BRUTE_FORCE_TEST

using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System.Collections.Generic;
using VoronoiLib;
using VoronoiLib.Structures;
using System.Linq;
using System;

namespace UnitTests
{
    [TestFixture]
    [Parallelizable(ParallelScope.Self)]
    public class FortuneAlgorithmTest
    {
        /// <summary>
        /// Special test that is more like an explanation of what to expect with this case.
        /// </summary>
        [Test]
        public void FourEquidistantPoints()
        {
            List<VoronoiSite> points = new List<VoronoiSite>
            {
                new VoronoiSite(200, 200),
                new VoronoiSite(200, 400),
                new VoronoiSite(400, 400),
                new VoronoiSite(400, 200)
            };
            
            // These points form a square, so, intuitively, there should be 4 edges making a "cross".
            //           |
            //     X     |     X
            //           |
            // ----------+----------
            //           |    
            //     X     |     X
            //           |
            
            // But this is not how the algorithm works at the moment -
            // you can't have a 4+ point "connection", edges always "split into 2" at connections.
            // So, in reality it makes another edge "in-between" (exaggerated):
            //           |
            //     X     |      X
            //           |
            // ----------\
            //            \---------
            //            |    
            //     X      |     X
            //            |
            // So each corner only ever has 3 edges and 3 closest points
            // But there's a 0-length edge
            
            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(points, 0, 0, 600, 600, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();
            
            // There are 5 edges (not 4)
            Assert.AreEqual(5, edges.Count);
            
            // One edge is 0 length
            Assert.AreEqual(edges[1].Start.X, edges[1].End.X);
            Assert.AreEqual(edges[1].Start.Y, edges[1].End.Y);

            // Two of the sites have expected 2 edges
            Assert.AreEqual(2, points[1].Cell.Count());
            Assert.AreEqual(2, points[3].Cell.Count());

            // Two of the sites have an "extra" edge
            Assert.AreEqual(3, points[0].Cell.Count());
            Assert.AreEqual(3, points[2].Cell.Count());
            // And this is the 0-length edge
            Assert.AreEqual(edges[1], points[0].Cell.ToList()[0]);
            Assert.AreEqual(edges[1], points[2].Cell.ToList()[1]);
        }

        [Test]
        public void NoPoints()
        {
            List<VoronoiSite> points = new List<VoronoiSite>();

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(points, 0, 0, 600, 600, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();
            
            Assert.AreEqual(0, edges.Count);
        }

        [Test]
        public void OnePoint()
        {
            List<VoronoiSite> points = new List<VoronoiSite>
            {
                new VoronoiSite(300, 300)
            };

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(points, 0, 0, 600, 600, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();
            
            Assert.AreEqual(0, edges.Count);
        }

        [TestCase(-100, 300)]
        [TestCase(300, -100)]
        [TestCase(700, 300)]
        [TestCase(300, 700)]
        [TestCase(-100, -100)]
        [TestCase(700, -100)]
        [TestCase(700, 700)]
        [TestCase(-100, 700)]
        public void PointOutsideBoundsAlone(double x, double y)
        {
            List<VoronoiSite> points = new List<VoronoiSite>
            {
                new VoronoiSite(x, y)
            };

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(points, 0, 0, 600, 600, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();
            
            Assert.AreEqual(0, edges.Count);
            Assert.AreEqual(0, points[0].Cell.Count());
        }

        [TestCase(-100, 300)]
        [TestCase(300, -100)]
        [TestCase(700, 300)]
        [TestCase(300, 700)]
        [TestCase(-100, -100)]
        [TestCase(700, -100)]
        [TestCase(700, 700)]
        [TestCase(-100, 700)]
        public void PointOutsideBoundsAgainstInBoundsPoint(double x, double y)
        {
            List<VoronoiSite> points = new List<VoronoiSite>
            {
                new VoronoiSite(x, y),
                new VoronoiSite(300, 300)
            };

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(points, 0, 0, 600, 600, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();
            
            Assert.AreEqual(1, edges.Count);
            Assert.AreEqual(1, points[0].Cell.Count());
            Assert.AreEqual(1, points[1].Cell.Count());
        }

        [TestCase(-1000, 300)]
        [TestCase(300, -1000)]
        [TestCase(7000, 300)]
        [TestCase(300, 7000)]
        [TestCase(-1000, -1000)]
        [TestCase(7000, -1000)]
        [TestCase(7000, 7000)]
        [TestCase(-1000, 7000)]
        public void PointFarOutsideBoundsAgainstInBoundsPoint(double x, double y)
        {
            List<VoronoiSite> points = new List<VoronoiSite>
            {
                new VoronoiSite(x, y),
                new VoronoiSite(300, 300)
            };

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(points, 0, 0, 600, 600, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();
            
            Assert.AreEqual(0, edges.Count);
            Assert.AreEqual(0, points[0].Cell.Count());
            Assert.AreEqual(0, points[1].Cell.Count());
        }

        [TestCase(0, 300)]
        [TestCase(300, 0)]
        [TestCase(600, 300)]
        [TestCase(300, 600)]
        [TestCase(0, 0)]
        [TestCase(600, 0)]
        [TestCase(600, 600)]
        [TestCase(0, 600)]
        public void PointOnBoundsAlone(double x, double y)
        {
            List<VoronoiSite> points = new List<VoronoiSite>
            {
                new VoronoiSite(x, y)
            };

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(points, 0, 0, 600, 600, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();
            
            Assert.AreEqual(0, edges.Count);
            Assert.AreEqual(0, points[0].Cell.Count());
        }

        [TestCase(0, 300)]
        [TestCase(300, 0)]
        [TestCase(600, 300)]
        [TestCase(300, 600)]
        [TestCase(0, 0)]
        [TestCase(600, 0)]
        [TestCase(600, 600)]
        [TestCase(0, 600)]
        public void PointOnBoundsAgainstInBoundsPoint(double x, double y)
        {
            List<VoronoiSite> points = new List<VoronoiSite>
            {
                new VoronoiSite(x, y),
                new VoronoiSite(300, 300)
            };

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(points, 0, 0, 600, 600, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();
            
            Assert.AreEqual(1, edges.Count);
            Assert.AreEqual(1, points[0].Cell.Count());
            Assert.AreEqual(1, points[1].Cell.Count());
        }

        [Test]
        public void FourPointsInASquare()
        {
            List<VoronoiSite> points = new List<VoronoiSite>
            {
                new VoronoiSite(200, 300), // 1
                new VoronoiSite(300, 400), // 2
                new VoronoiSite(300, 200), // 3
                new VoronoiSite(400, 300) // 4
            };

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(points, 0, 0, 600, 600, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // 600 B                                   E
            //     |\                                 /
            // 500 |    \                         /
            //     |        \                 /
            // 400 |            \    2    /
            //     |               \   /
            // 300 |           1     A     4
            //     |               /   \
            // 200 |            /    3    \
            //     |        /                 \
            // 100 |    /                         \
            //     |/                                 \
            //   0 C-----------------------------------D
            //     0    100   200   300   400   500   600

            foreach (VoronoiEdge edge in edges)
                Console.WriteLine(edge.ToString("F0"));

            Assert.AreEqual(5, edges.Count);

            Assert.IsTrue(CommonTestUtilities.AnyEdgeBetween(edges, 300, 300, 000, 600)); // A-B
            Assert.IsTrue(CommonTestUtilities.AnyEdgeBetween(edges, 300, 300, 000, 000)); // A-C
            Assert.IsTrue(CommonTestUtilities.AnyEdgeBetween(edges, 300, 300, 600, 000)); // A-D
            Assert.IsTrue(CommonTestUtilities.AnyEdgeBetween(edges, 300, 300, 600, 600)); // A-E
            Assert.IsTrue(CommonTestUtilities.AnyEdgeBetween(edges, 300, 300, 300, 300)); // A-A - because that's how this algorithm works
        }
        
        [Test]
        public void FourPointsOutsideBounds()
        {
            List<VoronoiSite> points = new List<VoronoiSite>
            {
                new VoronoiSite(-100, 300),
                new VoronoiSite(300, -100),
                new VoronoiSite(800, 300),
                new VoronoiSite(300, 800)
            };

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(points, 0, 0, 600, 600, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();
            
            foreach (VoronoiEdge edge in edges)
                Console.WriteLine(edge.ToString("F0"));
            
            Assert.AreEqual(5, edges.Count);
        }
        
        [TestCase(-100, -100, -200, -200)]
        [TestCase(-100, 700, -200, 800)]
        [TestCase(700, 700, 800, 800)]
        [TestCase(700, -100, 800, -200)]
        [TestCase(700, 300, 800, 300)]
        [TestCase(300, 700, 300, 800)]
        [TestCase(-100, 300, -200, 300)]
        [TestCase(300, -100, 300, -200)]
        public void TwoPointsOutsideBoundsTogether(double x1, double y1, double x2, double y2)
        {
            List<VoronoiSite> points = new List<VoronoiSite>
            {
                new VoronoiSite(x1, y1),
                new VoronoiSite(x2, y2)
            };

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(points, 0, 0, 600, 600, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();
            
            Assert.AreEqual(0, edges.Count);
        }

#if BRUTE_FORCE_TEST
        /// <summary>
        /// Ideally, we don't want to run this because it's random and not repeatable.
        /// </summary>
        [Test]
        [Repeat(10000)]
        public void RandomPointFractionalBruteforce()
        {
            Random random = new Random();
            
            int count = 100 + random.Next(100);
    
            List<VoronoiSite> points = new List<VoronoiSite>(count);
    
            for (int j = 0; j < count; j++)
            {
                points.Add(new VoronoiSite(random.NextDouble() * 3000 - 1500, random.NextDouble() * 3000 - 1500));
            }
    
            FortunesAlgorithm.RunOnce(points, 0, 0, 600, 600, BorderEdgeGeneration.DoNotMakeBorderEdges);
            
            // These are really slow and only work on in-bounds values:
            // CollectionAssert.AllItemsAreNotNull(edges);
            //     
            // foreach (VoronoiSite point in points)
            // {
            //     Assert.NotNull(point.cell);
            //     CollectionAssert.IsNotEmpty(point.cell);
            //     CollectionAssert.AllItemsAreNotNull(point.cell);
            //     foreach (VoronoiEdge edge in point.cell)
            //     {
            //         CollectionAssert.Contains(edges, edge);
            //         Assert.NotNull(edge.Left);
            //         Assert.NotNull(edge.Right);
            //     }
            // }
            
            Assert.Pass();
        }
        
        /// <summary>
        /// Ideally, we don't want to run this because it's random and not repeatable.
        /// </summary>
        [Test]
        [Repeat(10000)]
        public void RandomPointWholeBruteforce()
        {
            Random random = new Random();
            
            int count = 10 + random.Next(10);
    
            List<VoronoiSite> points = new List<VoronoiSite>(count);
    
            for (int j = 0; j < count; j++)
            {
                points.Add(new VoronoiSite(random.Next(3000) - 1500, random.Next(3000) - 1500));
            }
    
            FortunesAlgorithm.RunOnce(points, 0, 0, 600, 600, BorderEdgeGeneration.DoNotMakeBorderEdges);
            
            Assert.Pass();
        }
#endif
    }
}