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
    public class FortuneSiteCellTest
    {
        [Test]
        public void TwoPointsHorizontal()
        {
            List<FortuneSite> points = new List<FortuneSite>
            {
                new FortuneSite(300, 200), // 1
                new FortuneSite(300, 400) // 2
            };

            List<VEdge> edges = FortunesAlgorithm.Run(points, 0, 0, 600, 600).ToList();

            // 600 ^ 
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
            //   0 +----------------------------------->
            //     0    100   200   300   400   500   600

            Assert.AreEqual(1, edges.Count);
            
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 300, 600, 300)); // A-B
            
            Assert.IsTrue(SiteHasEdge(points[0], 000, 300, 600, 300)); // 1 has A-B
            Assert.IsTrue(SiteHasEdge(points[1], 000, 300, 600, 300)); // 2 has A-B
        }

        [Test]
        public void TwoPointsVertical()
        {
            List<FortuneSite> points = new List<FortuneSite>
            {
                new FortuneSite(200, 300), // 1
                new FortuneSite(400, 300) // 2
            };

            List<VEdge> edges = FortunesAlgorithm.Run(points, 0, 0, 600, 600).ToList();
            
            // 600 ^                 B 
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
            //   0 +-----------------A----------------->
            //     0    100   200   300   400   500   600

            Assert.AreEqual(1, edges.Count);

            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 300, 000, 300, 600)); // A-B
            
            Assert.IsTrue(SiteHasEdge(points[0], 300, 000, 300, 600)); // 1 has A-B
            Assert.IsTrue(SiteHasEdge(points[1], 300, 000, 300, 600)); // 2 has A-B
        }

        [Test]
        public void TwoPointsDiagonalForward()
        {
            List<FortuneSite> points = new List<FortuneSite>
            {
                new FortuneSite(150, 150), // 1
                new FortuneSite(450, 450) // 2
            };

            List<VEdge> edges = FortunesAlgorithm.Run(points, 0, 0, 600, 600).ToList();

            // 600 A                                    
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
            //   0 +-----------------------------------B
            //     0    100   200   300   400   500   600

            Assert.AreEqual(1, edges.Count);

            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 600, 600, 000)); // A-B
            
            Assert.IsTrue(SiteHasEdge(points[0], 000, 600, 600, 000)); // 1 has A-B
            Assert.IsTrue(SiteHasEdge(points[1], 000, 600, 600, 000)); // 2 has A-B
        }

        [Test]
        public void TwoPointsDiagonalBackward()
        {
            List<FortuneSite> points = new List<FortuneSite>
            {
                new FortuneSite(450, 150), // 1
                new FortuneSite(150, 450) // 2
            };

            List<VEdge> edges = FortunesAlgorithm.Run(points, 0, 0, 600, 600).ToList();

            // 600 ^                                   B 
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
            //   0 A----------------------------------->
            //     0    100   200   300   400   500   600

            Assert.AreEqual(1, edges.Count);

            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 000, 600, 600)); // A-B
            
            Assert.IsTrue(SiteHasEdge(points[0], 000, 000, 600, 600)); // 1 has A-B
            Assert.IsTrue(SiteHasEdge(points[1], 000, 000, 600, 600)); // 2 has A-B
        }

        [Test]
        public void ThreePointsInAWedgeNE()
        {
            List<FortuneSite> points = new List<FortuneSite>
            {
                new FortuneSite(300, 300), // 1
                new FortuneSite(300, 400), // 2
                new FortuneSite(400, 300) // 3
            };

            List<VEdge> edges = FortunesAlgorithm.Run(points, 0, 0, 600, 600).ToList();

            // 600 ^                                   B
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
            //   0 +--------------------D-------------->
            //     0    100   200   300   400   500   600

            foreach (VEdge edge in edges)
                Console.WriteLine(edge.ToString("F0"));

            Assert.AreEqual(3, edges.Count);

            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 350, 350, 600, 600)); // A-B
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 350, 350, 000, 350)); // A-C
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 350, 350, 350, 000)); // A-D
            
            Assert.IsTrue(SiteHasEdge(points[0], 350, 350, 000, 350)); // 1 has A-C
            Assert.IsTrue(SiteHasEdge(points[0], 350, 350, 000, 350)); // 1 has A-D
            Assert.IsTrue(SiteHasEdge(points[1], 350, 350, 600, 600)); // 2 has A-B
            Assert.IsTrue(SiteHasEdge(points[1], 350, 350, 000, 350)); // 2 has A-C
            Assert.IsTrue(SiteHasEdge(points[2], 350, 350, 600, 600)); // 3 has A-B
            Assert.IsTrue(SiteHasEdge(points[2], 350, 350, 350, 000)); // 3 has A-D
        }

        [Test]
        public void ThreePointsInAWedgeNW()
        {
            List<FortuneSite> points = new List<FortuneSite>
            {
                new FortuneSite(200, 300), // 1
                new FortuneSite(300, 400), // 2
                new FortuneSite(300, 300) // 3
            };

            List<VEdge> edges = FortunesAlgorithm.Run(points, 0, 0, 600, 600).ToList();

            // 600 B                       
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
            //   0 +--------------D-------------------->
            //     0    100   200   300   400   500   600

            foreach (VEdge edge in edges)
                Console.WriteLine(edge.ToString("F0"));

            Assert.AreEqual(3, edges.Count);

            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 250, 350, 000, 600)); // A-B
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 250, 350, 600, 350)); // A-C
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 250, 350, 250, 000)); // A-D
            
            Assert.IsTrue(SiteHasEdge(points[0], 250, 350, 000, 600)); // 1 has A-B
            Assert.IsTrue(SiteHasEdge(points[0], 250, 350, 250, 000)); // 1 has A-D
            Assert.IsTrue(SiteHasEdge(points[1], 250, 350, 000, 600)); // 2 has A-B
            Assert.IsTrue(SiteHasEdge(points[1], 250, 350, 600, 350)); // 2 has A-C
            Assert.IsTrue(SiteHasEdge(points[2], 250, 350, 600, 350)); // 3 has A-C
            Assert.IsTrue(SiteHasEdge(points[2], 250, 350, 250, 000)); // 3 has A-D
        }

        [Test]
        public void ThreePointsInAWedgeSW()
        {
            List<FortuneSite> points = new List<FortuneSite>
            {
                new FortuneSite(200, 300), // 1
                new FortuneSite(300, 300), // 2
                new FortuneSite(300, 200) // 3
            };

            List<VEdge> edges = FortunesAlgorithm.Run(points, 0, 0, 600, 600).ToList();

            // 600 ^              D
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
            //   0 B----------------------------------->
            //     0    100   200   300   400   500   600

            foreach (VEdge edge in edges)
                Console.WriteLine(edge.ToString("F0"));

            Assert.AreEqual(3, edges.Count);

            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 250, 250, 000, 000)); // A-B
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 250, 250, 600, 250)); // A-C
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 250, 250, 250, 600)); // A-D
            
            Assert.IsTrue(SiteHasEdge(points[0], 250, 250, 000, 000)); // 1 has A-B
            Assert.IsTrue(SiteHasEdge(points[0], 250, 250, 250, 600)); // 1 has A-D
            Assert.IsTrue(SiteHasEdge(points[1], 250, 250, 600, 250)); // 2 has A-C
            Assert.IsTrue(SiteHasEdge(points[1], 250, 250, 250, 600)); // 2 has A-D
            Assert.IsTrue(SiteHasEdge(points[2], 250, 250, 000, 000)); // 3 has A-B
            Assert.IsTrue(SiteHasEdge(points[2], 250, 250, 600, 250)); // 3 has A-C
        }

        [Test]
        public void ThreePointsInAWedgeSE()
        {
            List<FortuneSite> points = new List<FortuneSite>
            {
                new FortuneSite(300, 200), // 1
                new FortuneSite(300, 300), // 2
                new FortuneSite(400, 300) // 3
            };

            List<VEdge> edges = FortunesAlgorithm.Run(points, 0, 0, 600, 600).ToList();

            // 600 ^                    C
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
            //   0 +-----------------------------------B
            //     0    100   200   300   400   500   600

            foreach (VEdge edge in edges)
                Console.WriteLine(edge.ToString("F0"));

            Assert.AreEqual(3, edges.Count);

            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 350, 250, 600, 000)); // A-B
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 350, 250, 350, 600)); // A-C
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 350, 250, 000, 250)); // A-D      
            
            Assert.IsTrue(SiteHasEdge(points[0], 350, 250, 600, 000)); // 1 has A-B
            Assert.IsTrue(SiteHasEdge(points[0], 350, 250, 000, 250)); // 1 has A-D
            Assert.IsTrue(SiteHasEdge(points[1], 350, 250, 350, 600)); // 2 has A-C
            Assert.IsTrue(SiteHasEdge(points[1], 350, 250, 000, 250)); // 2 has A-D
            Assert.IsTrue(SiteHasEdge(points[2], 350, 250, 600, 000)); // 3 has A-B
            Assert.IsTrue(SiteHasEdge(points[2], 350, 250, 350, 600)); // 3 has A-C   
        }

        [Test]
        public void ThreePointsInAWedgeS()
        {
            List<FortuneSite> points = new List<FortuneSite>
            {
                new FortuneSite(200, 300), // 1
                new FortuneSite(300, 400), // 2
                new FortuneSite(400, 300) // 3
            };

            List<VEdge> edges = FortunesAlgorithm.Run(points, 0, 0, 600, 600).ToList();

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
            //   0 +-----------------C----------------->
            //     0    100   200   300   400   500   600

            foreach (VEdge edge in edges)
                Console.WriteLine(edge.ToString("F0"));

            Assert.AreEqual(3, edges.Count);

            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 300, 300, 000, 600)); // A-B
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 300, 300, 300, 000)); // A-C
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 300, 300, 600, 600)); // A-D
            
            Assert.IsTrue(SiteHasEdge(points[0], 300, 300, 000, 600)); // 1 has A-B
            Assert.IsTrue(SiteHasEdge(points[0], 300, 300, 300, 000)); // 1 has A-C
            Assert.IsTrue(SiteHasEdge(points[1], 300, 300, 000, 600)); // 2 has A-B
            Assert.IsTrue(SiteHasEdge(points[1], 300, 300, 600, 600)); // 2 has A-D
            Assert.IsTrue(SiteHasEdge(points[2], 300, 300, 300, 000)); // 3 has A-C
            Assert.IsTrue(SiteHasEdge(points[2], 300, 300, 600, 600)); // 3 has A-D
        }

        [Test]
        public void ThreePointsInAWedgeN()
        {
            List<FortuneSite> points = new List<FortuneSite>
            {
                new FortuneSite(200, 300), // 1
                new FortuneSite(300, 200), // 2
                new FortuneSite(400, 300) // 3
            };

            List<VEdge> edges = FortunesAlgorithm.Run(points, 0, 0, 600, 600).ToList();

            // 600 ^                 B
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

            foreach (VEdge edge in edges)
                Console.WriteLine(edge.ToString("F0"));

            Assert.AreEqual(3, edges.Count);

            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 300, 300, 300, 600)); // A-B
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 300, 300, 000, 000)); // A-C
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 300, 300, 600, 000)); // A-D
            
            Assert.IsTrue(SiteHasEdge(points[0], 300, 300, 300, 600)); // 1 has A-B
            Assert.IsTrue(SiteHasEdge(points[0], 300, 300, 000, 000)); // 1 has A-C
            Assert.IsTrue(SiteHasEdge(points[1], 300, 300, 000, 000)); // 2 has A-C
            Assert.IsTrue(SiteHasEdge(points[1], 300, 300, 600, 000)); // 2 has A-D
            Assert.IsTrue(SiteHasEdge(points[2], 300, 300, 300, 600)); // 3 has A-B
            Assert.IsTrue(SiteHasEdge(points[2], 300, 300, 600, 000)); // 3 has A-D
        }

        [Test]
        public void ThreePointsInAWedgeE()
        {
            List<FortuneSite> points = new List<FortuneSite>
            {
                new FortuneSite(200, 300), // 1
                new FortuneSite(300, 400), // 2
                new FortuneSite(300, 200) // 3
            };

            List<VEdge> edges = FortunesAlgorithm.Run(points, 0, 0, 600, 600).ToList();

            // 600 B                  
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
            //   0 C----------------------------------->
            //     0    100   200   300   400   500   600

            foreach (VEdge edge in edges)
                Console.WriteLine(edge.ToString("F0"));

            Assert.AreEqual(3, edges.Count);

            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 300, 300, 000, 600)); // A-B
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 300, 300, 000, 000)); // A-C
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 300, 300, 600, 300)); // A-D
            
            Assert.IsTrue(SiteHasEdge(points[0], 300, 300, 000, 600)); // 1 has A-B
            Assert.IsTrue(SiteHasEdge(points[0], 300, 300, 000, 000)); // 1 has A-C
            Assert.IsTrue(SiteHasEdge(points[1], 300, 300, 000, 600)); // 2 has A-B
            Assert.IsTrue(SiteHasEdge(points[1], 300, 300, 600, 300)); // 2 has A-D
            Assert.IsTrue(SiteHasEdge(points[2], 300, 300, 000, 000)); // 3 has A-C
            Assert.IsTrue(SiteHasEdge(points[2], 300, 300, 600, 300)); // 3 has A-D
        }

        [Test]
        public void ThreePointsInAWedgeW()
        {
            List<FortuneSite> points = new List<FortuneSite>
            {
                new FortuneSite(300, 400), // 1
                new FortuneSite(400, 300), // 2
                new FortuneSite(300, 200) // 3
            };

            List<VEdge> edges = FortunesAlgorithm.Run(points, 0, 0, 600, 600).ToList();

            // 600 ^                                   D
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
            //   0 +-----------------------------------C
            //     0    100   200   300   400   500   600

            foreach (VEdge edge in edges)
                Console.WriteLine(edge.ToString("F0"));

            Assert.AreEqual(3, edges.Count);

            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 300, 300, 000, 300)); // A-B
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 300, 300, 600, 000)); // A-C
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 300, 300, 600, 600)); // A-D
            
            Assert.IsTrue(SiteHasEdge(points[0], 300, 300, 000, 300)); // 1 has A-B
            Assert.IsTrue(SiteHasEdge(points[0], 300, 300, 600, 600)); // 1 has A-D
            Assert.IsTrue(SiteHasEdge(points[1], 300, 300, 600, 000)); // 2 has A-C
            Assert.IsTrue(SiteHasEdge(points[1], 300, 300, 600, 600)); // 2 has A-D
            Assert.IsTrue(SiteHasEdge(points[2], 300, 300, 000, 300)); // 3 has A-B
            Assert.IsTrue(SiteHasEdge(points[2], 300, 300, 600, 000)); // 3 has A-C
        }

        [Test]
        public void FourPointsInASquare()
        {
            List<FortuneSite> points = new List<FortuneSite>
            {
                new FortuneSite(200, 300), // 1
                new FortuneSite(300, 400), // 2
                new FortuneSite(300, 200), // 3
                new FortuneSite(400, 300) // 4
            };

            List<VEdge> edges = FortunesAlgorithm.Run(points, 0, 0, 600, 600).ToList();

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

            foreach (VEdge edge in edges)
                Console.WriteLine(edge.ToString("F0"));

            Assert.AreEqual(5, edges.Count);

            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 300, 300, 000, 600)); // A-B
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 300, 300, 000, 000)); // A-C
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 300, 300, 600, 000)); // A-D
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 300, 300, 600, 600)); // A-E
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 300, 300, 300, 300)); // A-A - because that's how this algorithm works
            
            Assert.IsTrue(SiteHasEdge(points[0], 300, 300, 000, 600)); // 1 has A-B
            Assert.IsTrue(SiteHasEdge(points[0], 300, 300, 000, 000)); // 1 has A-C
            Assert.IsTrue(SiteHasEdge(points[1], 300, 300, 000, 600)); // 2 has A-B
            Assert.IsTrue(SiteHasEdge(points[1], 300, 300, 600, 600)); // 2 has A-E
            Assert.IsTrue(SiteHasEdge(points[2], 300, 300, 000, 000)); // 3 has A-C
            Assert.IsTrue(SiteHasEdge(points[2], 300, 300, 600, 000)); // 3 has A-D
            Assert.IsTrue(SiteHasEdge(points[3], 300, 300, 600, 000)); // 4 has A-D
            Assert.IsTrue(SiteHasEdge(points[3], 300, 300, 600, 600)); // 4 has A-E
        }

        [Test]
        public void FourPointsSurroundingASite()
        {
            List<FortuneSite> points = new List<FortuneSite>
            {
                new FortuneSite(300, 300), // 1
                new FortuneSite(200, 300), // 2
                new FortuneSite(300, 400), // 3
                new FortuneSite(300, 200), // 4
                new FortuneSite(400, 300) // 5
            };

            List<VEdge> edges = FortunesAlgorithm.Run(points, 0, 0, 600, 600).ToList();

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

            foreach (VEdge edge in edges)
                Console.WriteLine(edge.ToString("F0"));

            Assert.AreEqual(8, edges.Count);

            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 250, 350, 250, 250)); // A-B
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 250, 250, 350, 250)); // B-C
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 350, 250, 350, 350)); // C-D
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 350, 350, 250, 350)); // D-A

            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 250, 350, 000, 600)); // A-E
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 250, 250, 000, 000)); // B-F
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 350, 250, 600, 000)); // C-G
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 350, 350, 600, 600)); // D-H
            
            Assert.IsTrue(SiteHasEdge(points[0], 250, 350, 250, 250)); // 1 has A-B
            Assert.IsTrue(SiteHasEdge(points[0], 250, 250, 350, 250)); // 1 has B-C
            Assert.IsTrue(SiteHasEdge(points[0], 350, 250, 350, 350)); // 1 has C-D
            Assert.IsTrue(SiteHasEdge(points[0], 350, 350, 250, 350)); // 1 has D-A
            Assert.IsTrue(SiteHasEdge(points[1], 250, 350, 000, 600)); // 2 has A-E
            Assert.IsTrue(SiteHasEdge(points[1], 250, 350, 250, 250)); // 2 has A-B
            Assert.IsTrue(SiteHasEdge(points[1], 250, 250, 000, 000)); // 2 has B-F
            Assert.IsTrue(SiteHasEdge(points[2], 250, 350, 000, 600)); // 3 has A-E
            Assert.IsTrue(SiteHasEdge(points[2], 350, 350, 250, 350)); // 3 has D-A
            Assert.IsTrue(SiteHasEdge(points[2], 350, 350, 600, 600)); // 3 has D-H
            Assert.IsTrue(SiteHasEdge(points[3], 250, 250, 000, 000)); // 4 has B-F
            Assert.IsTrue(SiteHasEdge(points[3], 250, 250, 350, 250)); // 4 has B-C
            Assert.IsTrue(SiteHasEdge(points[3], 350, 250, 600, 000)); // 4 has C-G
            Assert.IsTrue(SiteHasEdge(points[4], 350, 350, 600, 600)); // 5 has D-H
            Assert.IsTrue(SiteHasEdge(points[4], 350, 250, 350, 350)); // 5 has C-D
            Assert.IsTrue(SiteHasEdge(points[4], 350, 250, 600, 000)); // 5 has C-G
        }
        
        
        internal static bool SiteHasEdge(FortuneSite site, int x1, int y1, int x2, int y2)
        {
            return site.Cell.Any(e =>
                                     e.Start.X.ApproxEqual(x1) && e.Start.Y.ApproxEqual(y1) && e.End.X.ApproxEqual(x2) && e.End.Y.ApproxEqual(y2) ||
                                     e.Start.X.ApproxEqual(x2) && e.Start.Y.ApproxEqual(y2) && e.End.X.ApproxEqual(x1) && e.End.Y.ApproxEqual(y1)
            );
        }
    }
}