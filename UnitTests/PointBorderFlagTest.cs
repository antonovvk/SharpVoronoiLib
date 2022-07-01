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
    public class PointBorderFlagTest
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

            Assume.That(() => edges.Count == 1);

            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 300, 600, 300)); // A-B
            
            Assert.IsTrue(EdgeStartsAndEndsOnBorder(edges[0])); // A-B
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

            Assume.That(() => edges.Count == 1);

            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 300, 000, 300, 600)); // A-B
            
            Assert.IsTrue(EdgeStartsAndEndsOnBorder(edges[0])); // A-B
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

            Assume.That(() => edges.Count == 1);

            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 600, 600, 000)); // A-B
            
            Assert.IsTrue(EdgeStartsAndEndsOnBorder(edges[0])); // A-B
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
            //     |        1                  /
            // 400 |                        /
            //     |                    /
            // 300 |                 /      
            //     |              /      
            // 200 |          /              
            //     |       /                  2 
            // 100 |    /                          
            //     | /                                 
            //   0 A----------------------------------->
            //     0    100   200   300   400   500   600

            Assume.That(() => edges.Count == 1);

            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 000, 600, 600)); // A-B
            
            Assert.IsTrue(EdgeStartsAndEndsOnBorder(edges[0])); // A-B
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

            Assume.That(() => edges.Count == 3);

            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 350, 350, 600, 600)); // A-B
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 350, 350, 000, 350)); // A-C
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 350, 350, 350, 000)); // A-D
            
            Assert.IsTrue(EdgeStartsXorEndsOnBorder(edges[0]));
            Assert.IsTrue(EdgeStartsXorEndsOnBorder(edges[1]));
            Assert.IsTrue(EdgeStartsXorEndsOnBorder(edges[2]));
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

            Assume.That(() => edges.Count == 3);

            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 250, 350, 000, 600)); // A-B
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 250, 350, 600, 350)); // A-C
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 250, 350, 250, 000)); // A-D
            
            Assert.IsTrue(EdgeStartsXorEndsOnBorder(edges[0]));
            Assert.IsTrue(EdgeStartsXorEndsOnBorder(edges[1]));
            Assert.IsTrue(EdgeStartsXorEndsOnBorder(edges[2]));
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

            Assume.That(() => edges.Count == 3);

            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 250, 250, 000, 000)); // A-B
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 250, 250, 600, 250)); // A-C
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 250, 250, 250, 600)); // A-D
            
            Assert.IsTrue(EdgeStartsXorEndsOnBorder(edges[0]));
            Assert.IsTrue(EdgeStartsXorEndsOnBorder(edges[1]));
            Assert.IsTrue(EdgeStartsXorEndsOnBorder(edges[2]));
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

            Assume.That(() => edges.Count == 3);

            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 350, 250, 600, 000)); // A-B
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 350, 250, 350, 600)); // A-C
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 350, 250, 000, 250)); // A-D     
            
            Assert.IsTrue(EdgeStartsXorEndsOnBorder(edges[0]));
            Assert.IsTrue(EdgeStartsXorEndsOnBorder(edges[1]));
            Assert.IsTrue(EdgeStartsXorEndsOnBorder(edges[2]));   
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

            Assume.That(() => edges.Count == 3);

            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 300, 300, 000, 600)); // A-B
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 300, 300, 300, 000)); // A-C
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 300, 300, 600, 600)); // A-D
            
            Assert.IsTrue(EdgeStartsXorEndsOnBorder(edges[0]));
            Assert.IsTrue(EdgeStartsXorEndsOnBorder(edges[1]));
            Assert.IsTrue(EdgeStartsXorEndsOnBorder(edges[2]));
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

            Assume.That(() => edges.Count == 3);

            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 300, 300, 300, 600)); // A-B
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 300, 300, 000, 000)); // A-C
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 300, 300, 600, 000)); // A-D
            
            Assert.IsTrue(EdgeStartsXorEndsOnBorder(edges[0]));
            Assert.IsTrue(EdgeStartsXorEndsOnBorder(edges[1]));
            Assert.IsTrue(EdgeStartsXorEndsOnBorder(edges[2]));
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

            Assume.That(edges.Count == 3);
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 300, 300, 000, 600)); // A-B
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 300, 300, 000, 000)); // A-C
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 300, 300, 600, 300)); // A-D
            
            Assert.IsTrue(EdgeStartsXorEndsOnBorder(edges[0]));
            Assert.IsTrue(EdgeStartsXorEndsOnBorder(edges[1]));
            Assert.IsTrue(EdgeStartsXorEndsOnBorder(edges[2]));
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

            Assume.That(() => edges.Count == 3);

            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 300, 300, 000, 300)); // A-B
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 300, 300, 600, 000)); // A-C
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 300, 300, 600, 600)); // A-D
            
            Assert.IsTrue(EdgeStartsXorEndsOnBorder(edges[0]));
            Assert.IsTrue(EdgeStartsXorEndsOnBorder(edges[1]));
            Assert.IsTrue(EdgeStartsXorEndsOnBorder(edges[2]));
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

            Assume.That(() => edges.Count == 8);

            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 250, 350, 250, 250)); // A-B
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 250, 250, 350, 250)); // B-C
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 350, 250, 350, 350)); // C-D
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 350, 350, 250, 350)); // D-A

            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 250, 350, 000, 600)); // A-E
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 250, 250, 000, 000)); // B-F
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 350, 250, 600, 000)); // C-G
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 350, 350, 600, 600)); // D-H
            
            Assert.IsTrue(EdgeDoesntStartsOrEndsOnBorder(FindEdge(edges, 250, 350, 250, 250))); // A-B
            Assert.IsTrue(EdgeDoesntStartsOrEndsOnBorder(FindEdge(edges, 250, 250, 350, 250))); // B-C
            Assert.IsTrue(EdgeDoesntStartsOrEndsOnBorder(FindEdge(edges, 350, 250, 350, 350))); // C-D
            Assert.IsTrue(EdgeDoesntStartsOrEndsOnBorder(FindEdge(edges, 350, 350, 250, 350))); // D-A

            Assert.IsTrue(EdgeStartsXorEndsOnBorder(FindEdge(edges, 250, 350, 000, 600))); // A-E
            Assert.IsTrue(EdgeStartsXorEndsOnBorder(FindEdge(edges, 250, 250, 000, 000))); // B-F
            Assert.IsTrue(EdgeStartsXorEndsOnBorder(FindEdge(edges, 350, 250, 600, 000))); // C-G
            Assert.IsTrue(EdgeStartsXorEndsOnBorder(FindEdge(edges, 350, 350, 600, 600))); // D-H
        }

        
        private VEdge FindEdge(List<VEdge> edges, int x1, int y1, int x2, int y2)
        {
            return edges.First(
                e =>
                    e.Start != null && e.End != null &&
                    e.Start.X.ApproxEqual(x1) && e.Start.Y.ApproxEqual(y1) && e.End.X.ApproxEqual(x2) && e.End.Y.ApproxEqual(y2) ||
                    e.Start.X.ApproxEqual(x2) && e.Start.Y.ApproxEqual(y2) && e.End.X.ApproxEqual(x1) && e.End.Y.ApproxEqual(y1)
            );
        }

        private static bool EdgeStartsAndEndsOnBorder(VEdge edge)
        {
            return 
                edge.Start.OnBorder || 
                edge.End.OnBorder;
        }

        private static bool EdgeStartsXorEndsOnBorder(VEdge edge)
        {
            return 
                edge.Start.OnBorder ^
                edge.End.OnBorder;
        }

        private static bool EdgeDoesntStartsOrEndsOnBorder(VEdge edge)
        {
            return 
                !edge.Start.OnBorder &&
                !edge.End.OnBorder;
        }
    }
}