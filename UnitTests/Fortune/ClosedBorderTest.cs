#define BRUTE_FORCE_TEST 

using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using SharpVoronoiLib;

namespace SharpVoronoiLib.UnitTests
{
    [TestFixture]
    [Parallelizable(ParallelScope.Self)]
    public class ClosedBorderTest
    {
        [Test]
        public void NoPoints()
        {
            List<VoronoiSite> points = new List<VoronoiSite>();
            
            // 600 Y                                   Z
            //     | 
            // 500 | 
            //     | 
            // 400 |                  
            //     | 
            // 300 |                               
            //     | 
            // 200 |                  
            //     | 
            // 100 | 
            //     | 
            //   0 X-----------------------------------W
            //     0    100   200   300   400   500   600

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(points, 0, 0, 600, 600, BorderEdgeGeneration.MakeBorderEdges).ToList();
            
            Assert.AreEqual(4, edges.Count);
            
            Assert.IsTrue(CommonTestUtilities.AnyEdgeBetween(edges, 000, 000, 600, 000)); // X-W
            Assert.IsTrue(CommonTestUtilities.AnyEdgeBetween(edges, 600, 000, 600, 600)); // W-Z
            Assert.IsTrue(CommonTestUtilities.AnyEdgeBetween(edges, 600, 600, 000, 600)); // Z-Y
            Assert.IsTrue(CommonTestUtilities.AnyEdgeBetween(edges, 000, 600, 000, 000)); // Y-X
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

            // 600 Y                                   Z
            //     | 
            // 500 | 
            //     | 
            // 400 |                  
            //     | 
            // 300 |                               
            //     | 
            // 200 |                  
            //     | 
            // 100 | 
            //     | 
            //   0 X-----------------------------------W
            //     0    100   200   300   400   500   600

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(points, 0, 0, 600, 600, BorderEdgeGeneration.MakeBorderEdges).ToList();
            
            Assert.AreEqual(4, edges.Count);
            
            Assert.IsTrue(CommonTestUtilities.AnyEdgeBetween(edges, 000, 000, 600, 000)); // X-W
            Assert.IsTrue(CommonTestUtilities.AnyEdgeBetween(edges, 600, 000, 600, 600)); // W-Z
            Assert.IsTrue(CommonTestUtilities.AnyEdgeBetween(edges, 600, 600, 000, 600)); // Z-Y
            Assert.IsTrue(CommonTestUtilities.AnyEdgeBetween(edges, 000, 600, 000, 000)); // Y-X
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(points, 0, 0, 600, 600, BorderEdgeGeneration.MakeBorderEdges).ToList();

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

            Assert.AreEqual(9, edges.Count);

            Assert.IsTrue(CommonTestUtilities.AnyEdgeBetween(edges, 300, 300, 000, 600)); // A-B
            Assert.IsTrue(CommonTestUtilities.AnyEdgeBetween(edges, 300, 300, 000, 000)); // A-C
            Assert.IsTrue(CommonTestUtilities.AnyEdgeBetween(edges, 300, 300, 600, 000)); // A-D
            Assert.IsTrue(CommonTestUtilities.AnyEdgeBetween(edges, 300, 300, 600, 600)); // A-E
            Assert.IsTrue(CommonTestUtilities.AnyEdgeBetween(edges, 300, 300, 300, 300)); // A-A - because that's how this algorithm works
            
            Assert.IsTrue(CommonTestUtilities.AnyEdgeBetween(edges, 000, 000, 600, 000)); // C-D
            Assert.IsTrue(CommonTestUtilities.AnyEdgeBetween(edges, 600, 000, 600, 600)); // D-E
            Assert.IsTrue(CommonTestUtilities.AnyEdgeBetween(edges, 600, 600, 000, 600)); // E-B
            Assert.IsTrue(CommonTestUtilities.AnyEdgeBetween(edges, 000, 600, 000, 000)); // B-C
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
    
            VoronoiPlane.TessellateOnce(points, 0, 0, 600, 600, BorderEdgeGeneration.MakeBorderEdges);
            
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
    
            VoronoiPlane.TessellateOnce(points, 0, 0, 600, 600, BorderEdgeGeneration.MakeBorderEdges);
            
            Assert.Pass();
        }
#endif
    }
}