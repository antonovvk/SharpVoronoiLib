#define BRUTE_FORCE_TEST 

using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using VoronoiLib;
using VoronoiLib.Structures;

namespace UnitTests
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

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(points, 0, 0, 600, 600, BorderEdgeGeneration.MakeBorderEdges).ToList();
            
            Assert.AreEqual(4, edges.Count);
            
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 000, 600, 000)); // X-W
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 600, 000, 600, 600)); // W-Z
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 600, 600, 000, 600)); // Z-Y
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 600, 000, 000)); // Y-X
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

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(points, 0, 0, 600, 600, BorderEdgeGeneration.MakeBorderEdges).ToList();
            
            Assert.AreEqual(4, edges.Count);
            
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 000, 600, 000)); // X-W
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 600, 000, 600, 600)); // W-Z
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 600, 600, 000, 600)); // Z-Y
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 600, 000, 000)); // Y-X
        }

        [Test]
        public void OnePoint()
        {
            List<VoronoiSite> points = new List<VoronoiSite>
            {
                new VoronoiSite(300, 300)
            };
            
            // 600 Y                                   Z
            //     | 
            // 500 | 
            //     | 
            // 400 |                  
            //     | 
            // 300 |                 1             
            //     | 
            // 200 |                  
            //     | 
            // 100 | 
            //     | 
            //   0 X-----------------------------------W
            //     0    100   200   300   400   500   600

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(points, 0, 0, 600, 600, BorderEdgeGeneration.MakeBorderEdges).ToList();
            
            Assert.AreEqual(4, edges.Count);
            
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 000, 600, 000)); // X-W
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 600, 000, 600, 600)); // W-Z
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 600, 600, 000, 600)); // Z-Y
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 600, 000, 000)); // Y-X
        }
        
        [Test]
        public void TwoPointsHorizontal()
        {
            List<VoronoiSite> points = new List<VoronoiSite>
            {
                new VoronoiSite(300, 200), // 1
                new VoronoiSite(300, 400) // 2
            };

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(points, 0, 0, 600, 600, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // 600 Y                                   Z
            //     | 
            // 500 | 
            //     | 
            // 400 |                 2
            //     | 
            // 300 A-----------------------------------B
            //     | 
            // 200 |                 1
            //     | 
            // 100 | 
            //     | 
            //   0 X-----------------------------------W
            //     0    100   200   300   400   500   600

            Assert.AreEqual(7, edges.Count);

            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 300, 600, 300)); // A-B
            
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 000, 600, 000)); // X-W
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 600, 000, 600, 300)); // W-B
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 600, 300, 600, 600)); // B-Z
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 600, 600, 000, 600)); // Z-Y
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 600, 000, 300)); // Y-A
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 300, 000, 000)); // A-X
        }

        [Test]
        public void TwoPointsVertical()
        {
            List<VoronoiSite> points = new List<VoronoiSite>
            {
                new VoronoiSite(200, 300), // 1
                new VoronoiSite(400, 300) // 2
            };

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(points, 0, 0, 600, 600, BorderEdgeGeneration.MakeBorderEdges).ToList();
            
            // 600 X                 B                 W
            //     |                 | 
            // 500 |                 | 
            //     |                 | 
            // 400 |                 |
            //     |                 | 
            // 300 |           1     |     2
            //     |                 | 
            // 200 |                 |
            //     |                 | 
            // 100 |                 | 
            //     |                 | 
            //   0 Y-----------------A-----------------Z
            //     0    100   200   300   400   500   600

            Assert.AreEqual(7, edges.Count);

            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 300, 000, 300, 600)); // A-B
            
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 000, 300, 000)); // Y-A
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 300, 000, 600, 000)); // A-Z
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 600, 000, 600, 600)); // Z-W
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 600, 600, 300, 600)); // W-B
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 300, 600, 000, 600)); // B-X
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 600, 000, 000)); // X-Y
        }

        [Test]
        public void TwoPointsDiagonalForward()
        {
            List<VoronoiSite> points = new List<VoronoiSite>
            {
                new VoronoiSite(150, 150), // 1
                new VoronoiSite(450, 450) // 2
            };

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(points, 0, 0, 600, 600, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // 600 A                                   Y
            //     |\                                  
            // 500 |    \                          
            //     |       \                  2
            // 400 |          \          
            //     |              \    
            // 300 |                 \      
            //     |                    \
            // 200 |                        \
            //     |        1                  \
            // 100 |                              \
            //     |                                  \
            //   0 X-----------------------------------B
            //     0    100   200   300   400   500   600

            Assert.AreEqual(5, edges.Count);

            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 600, 600, 000)); // A-B
            
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 000, 600, 000)); // X-B
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 600, 000, 600, 600)); // B-Y
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 600, 600, 000, 600)); // Y-A
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 600, 000, 000)); // A-X
        }

        [Test]
        public void TwoPointsDiagonalBackward()
        {
            List<VoronoiSite> points = new List<VoronoiSite>
            {
                new VoronoiSite(450, 150), // 1
                new VoronoiSite(150, 450) // 2
            };

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(points, 0, 0, 600, 600, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // 600 X                                   B 
            //     |                                 /    
            // 500 |                              /   
            //     |        2                  /
            // 400 |                        /
            //     |                    /
            // 300 |                 /      
            //     |              /      
            // 200 |          /              
            //     |       /                  1 
            // 100 |    /                          
            //     | /                                 
            //   0 A-----------------------------------Y
            //     0    100   200   300   400   500   600

            Assert.AreEqual(5, edges.Count);

            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 000, 600, 600)); // A-B
            
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 600, 600, 600)); // A-Y
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 600, 600, 600, 000)); // Y-B
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 600, 000, 000, 000)); // B-X
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 000, 000, 600)); // X-A
        }

        [Test]
        public void ThreePointsInAWedgeNE()
        {
            List<VoronoiSite> points = new List<VoronoiSite>
            {
                new VoronoiSite(300, 300), // 1
                new VoronoiSite(300, 400), // 2
                new VoronoiSite(400, 300) // 3
            };

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(points, 0, 0, 600, 600, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // 600 X                                   B
            //     |                                  /
            // 500 |                              /
            //     |                           /
            // 400 |                 2     /
            //     C--------------------A
            // 300 |                 1  |  3
            //     |                    |
            // 200 |                    |
            //     |                    |
            // 100 |                    |
            //     |                    |
            //   0 Y--------------------D--------------Z
            //     0    100   200   300   400   500   600

            foreach (VoronoiEdge edge in edges)
                Console.WriteLine(edge.ToString("F0"));

            Assert.AreEqual(9, edges.Count);

            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 350, 350, 600, 600)); // A-B
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 350, 350, 000, 350)); // A-C
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 350, 350, 350, 000)); // A-D

            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 000, 350, 000)); // Y-D
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 350, 000, 600, 000)); // D-Z
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 600, 000, 600, 600)); // Z-B
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 600, 600, 000, 600)); // B-X
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 600, 000, 350)); // X-C
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 350, 000, 000)); // C-Y
        }

        [Test]
        public void ThreePointsInAWedgeNW()
        {
            List<VoronoiSite> points = new List<VoronoiSite>
            {
                new VoronoiSite(200, 300), // 1
                new VoronoiSite(300, 400), // 2
                new VoronoiSite(300, 300) // 3
            };

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(points, 0, 0, 600, 600, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // 600 B                                   Z
            //     |  \                     
            // 500 |     \                      
            //     |        \            
            // 400 |           \     2
            //     |              A--------------------C
            // 300 |           1  |  3
            //     |              |
            // 200 |              |
            //     |              |
            // 100 |              |
            //     |              |
            //   0 X--------------D--------------------Y
            //     0    100   200   300   400   500   600

            foreach (VoronoiEdge edge in edges)
                Console.WriteLine(edge.ToString("F0"));

            Assert.AreEqual(9, edges.Count);

            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 250, 350, 000, 600)); // A-B
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 250, 350, 600, 350)); // A-C
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 250, 350, 250, 000)); // A-D
            
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 000, 250, 000)); // X-D
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 250, 000, 600, 000)); // D-Y
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 600, 000, 600, 350)); // Y-C
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 600, 350, 600, 600)); // C-Z
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 600, 600, 000, 600)); // Z-B
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 600, 000, 000)); // B-X
        }

        [Test]
        public void ThreePointsInAWedgeSW()
        {
            List<VoronoiSite> points = new List<VoronoiSite>
            {
                new VoronoiSite(200, 300), // 1
                new VoronoiSite(300, 300), // 2
                new VoronoiSite(300, 200) // 3
            };

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(points, 0, 0, 600, 600, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // 600 X              D                    Z
            //     |              |
            // 500 |              |         
            //     |              |         
            // 400 |              |             
            //     |              |      
            // 300 |           1  |  2
            //     |              A--------------------C
            // 200 |           /     3
            //     |        /     
            // 100 |     /       
            //     |  /         
            //   0 B-----------------------------------Y
            //     0    100   200   300   400   500   600

            foreach (VoronoiEdge edge in edges)
                Console.WriteLine(edge.ToString("F0"));

            Assert.AreEqual(9, edges.Count);

            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 250, 250, 000, 000)); // A-B
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 250, 250, 600, 250)); // A-C
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 250, 250, 250, 600)); // A-D
            
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 000, 600, 000)); // B-Y
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 600, 000, 600, 250)); // Y-C
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 250, 600, 600, 600)); // C-Z
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 600, 600, 250, 600)); // Z-D
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 250, 600, 000, 600)); // D-X
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 600, 000, 000)); // X-B
        }

        [Test]
        public void ThreePointsInAWedgeSE()
        {
            List<VoronoiSite> points = new List<VoronoiSite>
            {
                new VoronoiSite(300, 200), // 1
                new VoronoiSite(300, 300), // 2
                new VoronoiSite(400, 300) // 3
            };

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(points, 0, 0, 600, 600, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // 600 X                    C              Z
            //     |                    |
            // 500 |                    |
            //     |                    |
            // 400 |                    |
            //     |                    |
            // 300 |                 2  |  3
            //     D--------------------A 
            // 200 |                 1     \ 
            //     |                          \
            // 100 |                             \
            //     |                                \
            //   0 Y-----------------------------------B
            //     0    100   200   300   400   500   600

            foreach (VoronoiEdge edge in edges)
                Console.WriteLine(edge.ToString("F0"));

            Assert.AreEqual(9, edges.Count);

            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 350, 250, 600, 000)); // A-B
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 350, 250, 350, 600)); // A-C
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 350, 250, 000, 250)); // A-D      
            
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 000, 600, 000)); // Y-B
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 600, 000, 600, 600)); // B-Z
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 600, 600, 350, 600)); // Z-C
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 350, 600, 000, 600)); // C-X
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 600, 000, 250)); // X-D
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 250, 000, 000)); // D-Y  
        }

        [Test]
        public void ThreePointsInAWedgeS()
        {
            List<VoronoiSite> points = new List<VoronoiSite>
            {
                new VoronoiSite(200, 300), // 1
                new VoronoiSite(300, 400), // 2
                new VoronoiSite(400, 300) // 3
            };

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(points, 0, 0, 600, 600, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // 600 B                                   D
            //     |\                                 /
            // 500 |    \                         /
            //     |        \                 /
            // 400 |            \    2    /
            //     |               \   /
            // 300 |           1     A     3
            //     |                 |  
            // 200 |                 |     
            //     |                 |         
            // 100 |                 |             
            //     |                 |                 
            //   0 X-----------------C-----------------Y
            //     0    100   200   300   400   500   600

            foreach (VoronoiEdge edge in edges)
                Console.WriteLine(edge.ToString("F0"));

            Assert.AreEqual(8, edges.Count);

            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 300, 300, 000, 600)); // A-B
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 300, 300, 300, 000)); // A-C
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 300, 300, 600, 600)); // A-D
            
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 000, 300, 000)); // X-C
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 300, 000, 600, 000)); // C-Y
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 600, 000, 600, 600)); // Y-D
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 600, 600, 000, 600)); // D-B
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 600, 000, 000)); // B-X
        }

        [Test]
        public void ThreePointsInAWedgeN()
        {
            List<VoronoiSite> points = new List<VoronoiSite>
            {
                new VoronoiSite(200, 300), // 1
                new VoronoiSite(300, 200), // 2
                new VoronoiSite(400, 300) // 3
            };

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(points, 0, 0, 600, 600, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // 600 X                 B                 Y
            //     |                 |
            // 500 |                 |
            //     |                 |
            // 400 |                 |
            //     |                 |
            // 300 |           1     A     3
            //     |               /   \
            // 200 |            /    2    \
            //     |        /                 \
            // 100 |    /                         \
            //     |/                                 \
            //   0 C-----------------------------------D
            //     0    100   200   300   400   500   600

            foreach (VoronoiEdge edge in edges)
                Console.WriteLine(edge.ToString("F0"));

            Assert.AreEqual(8, edges.Count);

            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 300, 300, 300, 600)); // A-B
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 300, 300, 000, 000)); // A-C
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 300, 300, 600, 000)); // A-D
            
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 000, 600, 000)); // C-D
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 600, 000, 600, 600)); // D-Y
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 600, 600, 300, 600)); // Y-B
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 300, 600, 000, 600)); // B-X
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 600, 000, 000)); // X-C
        }

        [Test]
        public void ThreePointsInAWedgeE()
        {
            List<VoronoiSite> points = new List<VoronoiSite>
            {
                new VoronoiSite(200, 300), // 1
                new VoronoiSite(300, 400), // 2
                new VoronoiSite(300, 200) // 3
            };

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(points, 0, 0, 600, 600, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // 600 B                                   Y
            //     |\                 
            // 500 |    \             
            //     |        \         
            // 400 |            \    2
            //     |               \  
            // 300 |           1     A-----------------D
            //     |               /   
            // 200 |            /    3 
            //     |        /          
            // 100 |    /              
            //     |/                  
            //   0 C-----------------------------------X
            //     0    100   200   300   400   500   600

            foreach (VoronoiEdge edge in edges)
                Console.WriteLine(edge.ToString("F0"));

            Assert.AreEqual(8, edges.Count);

            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 300, 300, 000, 600)); // A-B
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 300, 300, 000, 000)); // A-C
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 300, 300, 600, 300)); // A-D
            
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 000, 600, 000)); // C-X
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 600, 000, 600, 300)); // X-D
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 600, 300, 600, 600)); // D-Y
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 600, 600, 000, 600)); // Y-B
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 600, 000, 000)); // B-C
        }

        [Test]
        public void ThreePointsInAWedgeW()
        {
            List<VoronoiSite> points = new List<VoronoiSite>
            {
                new VoronoiSite(300, 400), // 1
                new VoronoiSite(400, 300), // 2
                new VoronoiSite(300, 200) // 3
            };

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(points, 0, 0, 600, 600, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // 600 Y                                   D
            //     |                                  /
            // 500 |                              /
            //     |                          /
            // 400 |                 1    /
            //     |                   /
            // 300 B-----------------A     2
            //     |                   \
            // 200 |                 3    \
            //     |                          \
            // 100 |                              \
            //     |                                  \
            //   0 X-----------------------------------C
            //     0    100   200   300   400   500   600

            foreach (VoronoiEdge edge in edges)
                Console.WriteLine(edge.ToString("F0"));

            Assert.AreEqual(8, edges.Count);

            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 300, 300, 000, 300)); // A-B
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 300, 300, 600, 000)); // A-C
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 300, 300, 600, 600)); // A-D
            
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 000, 600, 000)); // X-C
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 600, 000, 600, 600)); // C-D
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 600, 600, 000, 600)); // D-Y
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 600, 000, 300)); // Y-B
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 300, 000, 000)); // B-X
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

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(points, 0, 0, 600, 600, BorderEdgeGeneration.MakeBorderEdges).ToList();

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

            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 300, 300, 000, 600)); // A-B
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 300, 300, 000, 000)); // A-C
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 300, 300, 600, 000)); // A-D
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 300, 300, 600, 600)); // A-E
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 300, 300, 300, 300)); // A-A - because that's how this algorithm works
            
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 000, 600, 000)); // C-D
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 600, 000, 600, 600)); // D-E
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 600, 600, 000, 600)); // E-B
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 600, 000, 000)); // B-C
        }

        [Test]
        public void FourPointsSurroundingASite()
        {
            List<VoronoiSite> points = new List<VoronoiSite>
            {
                new VoronoiSite(300, 300), // 1
                new VoronoiSite(200, 300), // 2
                new VoronoiSite(300, 400), // 3
                new VoronoiSite(300, 200), // 4
                new VoronoiSite(400, 300) // 5
            };

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(points, 0, 0, 600, 600, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // 600 E                                   H
            //     |\                                 /
            // 500 |    \                         /
            //     |        \                 /
            // 400 |            \    3    /
            //     |              A-----D
            // 300 |           2  |  1  |  5
            //     |              B-----C
            // 200 |            /    4    \
            //     |        /                 \
            // 100 |    /                         \
            //     |/                                 \
            //   0 F-----------------------------------G
            //     0    100   200   300   400   500   600

            foreach (VoronoiEdge edge in edges)
                Console.WriteLine(edge.ToString("F0"));

            Assert.AreEqual(12, edges.Count);

            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 250, 350, 250, 250)); // A-B
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 250, 250, 350, 250)); // B-C
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 350, 250, 350, 350)); // C-D
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 350, 350, 250, 350)); // D-A

            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 250, 350, 000, 600)); // A-E
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 250, 250, 000, 000)); // B-F
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 350, 250, 600, 000)); // C-G
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 350, 350, 600, 600)); // D-H
            
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 000, 600, 000)); // F-G
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 600, 000, 600, 600)); // G-H
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 600, 600, 000, 600)); // H-E
            Assert.IsTrue(FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 600, 000, 000)); // E-F
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
    
            FortunesAlgorithm.RunOnce(points, 0, 0, 600, 600, BorderEdgeGeneration.MakeBorderEdges);
            
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
    
            FortunesAlgorithm.RunOnce(points, 0, 0, 600, 600, BorderEdgeGeneration.MakeBorderEdges);
            
            Assert.Pass();
        }
#endif
    }
}