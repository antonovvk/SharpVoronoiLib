using NUnit.Framework;
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
        [Test]
        public void FortuneThreePoints()
        {
            var points = new List<FortuneSite>
            {
                new FortuneSite(100, 100),
                new FortuneSite(200, 200),
                new FortuneSite(200, 150)
            };
            var edges = FortunesAlgorithm.Run(points, 0 , 0, 600, 600);

            var edge = edges.First;

            //edge 1
            Assert.AreEqual(125, edge.Value.Start.X);
            Assert.AreEqual(175, edge.Value.Start.Y);
            Assert.AreEqual(0, edge.Value.End.X);
            Assert.AreEqual(300, edge.Value.End.Y);
            Assert.IsNotNull(edge.Next);
            edge = edge.Next;
            //edge 2
            Assert.AreEqual(600, edge.Value.Start.X);
            Assert.AreEqual(175, edge.Value.Start.Y);
            Assert.AreEqual(125, edge.Value.End.X);
            Assert.AreEqual(175, edge.Value.End.Y);
            Assert.IsNotNull(edge.Next);
            edge = edge.Next;
            //edge 3
            Assert.AreEqual(212.5, edge.Value.Start.X);
            Assert.AreEqual(0, edge.Value.Start.Y);
            Assert.AreEqual(125, edge.Value.End.X);
            Assert.AreEqual(175, edge.Value.End.Y);
            Assert.IsNull(edge.Next);
        }

        [Test]
        public void FortuneColinearPoints()
        {
            var points = new List<FortuneSite>
            {
                new FortuneSite(300, 100),
                new FortuneSite(300, 300),
                new FortuneSite(300, 500)
            };

            var edges = FortunesAlgorithm.Run(points, 0, 0, 600, 600);
            var edge = edges.First;
            Assert.AreEqual(600, edge.Value.Start.X);
            Assert.AreEqual(400, edge.Value.Start.Y);
            Assert.AreEqual(0, edge.Value.End.X);
            Assert.AreEqual(400, edge.Value.End.Y);
            Assert.IsNotNull(edge.Next);

            edge = edge.Next;
            Assert.AreEqual(600, edge.Value.Start.X);
            Assert.AreEqual(200, edge.Value.Start.Y);
            Assert.AreEqual(0, edge.Value.End.X);
            Assert.AreEqual(200, edge.Value.End.Y);
            Assert.IsNull(edge.Next);
        }

        [Test]
        public void FortunePointBreak()
        {
            var points = new List<FortuneSite>
            {
                new FortuneSite(100, 100),
                new FortuneSite(500, 100),
                new FortuneSite(300, 200)
            };
            var edges = FortunesAlgorithm.Run(points, 0, 0, 600, 600);
            var edge = edges.First;
            Assert.AreEqual(325, edge.Value.Start.X);
            Assert.AreEqual(0, edge.Value.Start.Y);
            Assert.AreEqual(600, edge.Value.End.X);
            Assert.AreEqual(550, edge.Value.End.Y);
            Assert.IsNotNull(edge.Next);
            edge = edge.Next;
            Assert.AreEqual(275, edge.Value.Start.X);
            Assert.AreEqual(0, edge.Value.Start.Y);
            Assert.AreEqual(0, edge.Value.End.X);
            Assert.AreEqual(550, edge.Value.End.Y);
            Assert.IsNull(edge.Next);
        }

        /// <summary>
        /// Special test that is more like an explanation of what to expect with this case.
        /// </summary>
        [Test]
        public void FourEquidistantPoints()
        {
            List<FortuneSite> points = new List<FortuneSite>
            {
                new FortuneSite(200, 200),
                new FortuneSite(200, 400),
                new FortuneSite(400, 400),
                new FortuneSite(400, 200)
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
            
            List<VEdge> edges = FortunesAlgorithm.Run(points, 0, 0, 600, 600).ToList();
            
            // There are 5 edges (not 4)
            Assert.AreEqual(5, edges.Count);
            
            // One edge is 0 length
            Assert.AreEqual(edges[1].Start.X, edges[1].End.X);
            Assert.AreEqual(edges[1].Start.Y, edges[1].End.Y);

            // Two of the sites have expected 2 edges
            Assert.AreEqual(2, points[1].Cell.Count);
            Assert.AreEqual(2, points[3].Cell.Count);

            // Two of the sites have an "extra" edge
            Assert.AreEqual(3, points[0].Cell.Count);
            Assert.AreEqual(3, points[2].Cell.Count);
            // And this is the 0-length edge
            Assert.AreEqual(edges[1], points[0].Cell[0]);
            Assert.AreEqual(edges[1], points[2].Cell[1]);
        }

        [Test]
        public void NoPoints()
        {
            List<FortuneSite> points = new List<FortuneSite>();

            List<VEdge> edges = FortunesAlgorithm.Run(points, 0, 0, 600, 600).ToList();
            
            Assert.AreEqual(0, edges.Count);
        }

        [Test]
        public void OnePoint()
        {
            List<FortuneSite> points = new List<FortuneSite>
            {
                new FortuneSite(300, 300)
            };

            List<VEdge> edges = FortunesAlgorithm.Run(points, 0, 0, 600, 600).ToList();
            
            Assert.AreEqual(0, edges.Count);
        }

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

            Assert.IsTrue(AnyEdgeBetween(edges, 000, 300, 600, 300)); // A-B
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

            Assert.IsTrue(AnyEdgeBetween(edges, 300, 000, 300, 600)); // A-B
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

            Assert.IsTrue(AnyEdgeBetween(edges, 000, 600, 600, 000)); // A-B
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

            Assert.AreEqual(1, edges.Count);

            Assert.IsTrue(AnyEdgeBetween(edges, 000, 000, 600, 600)); // A-B
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

            Assert.IsTrue(AnyEdgeBetween(edges, 350, 350, 600, 600)); // A-B
            Assert.IsTrue(AnyEdgeBetween(edges, 350, 350, 000, 350)); // A-C
            Assert.IsTrue(AnyEdgeBetween(edges, 350, 350, 350, 000)); // A-D

            // The above fails; the actual output is:
            // (600,600)->(600,600) --- wrong
            // (350,350)->(0,350)
            // (350,0)->(350,350)
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

            Assert.IsTrue(AnyEdgeBetween(edges, 250, 350, 000, 600)); // A-B
            Assert.IsTrue(AnyEdgeBetween(edges, 250, 350, 600, 350)); // A-C
            Assert.IsTrue(AnyEdgeBetween(edges, 250, 350, 250, 000)); // A-D

            // The above fails; the actual output is:
            // (0,600)->(0,600) -- wrong
            // (600,350)->(250,350)
            // (250,0)->(250,350)
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

            Assert.IsTrue(AnyEdgeBetween(edges, 250, 250, 000, 000)); // A-B
            Assert.IsTrue(AnyEdgeBetween(edges, 250, 250, 600, 250)); // A-C
            Assert.IsTrue(AnyEdgeBetween(edges, 250, 250, 250, 600)); // A-D
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

            Assert.IsTrue(AnyEdgeBetween(edges, 350, 250, 600, 000)); // A-B
            Assert.IsTrue(AnyEdgeBetween(edges, 350, 250, 350, 600)); // A-C
            Assert.IsTrue(AnyEdgeBetween(edges, 350, 250, 000, 250)); // A-D         
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

            Assert.IsTrue(AnyEdgeBetween(edges, 300, 300, 000, 600)); // A-B
            Assert.IsTrue(AnyEdgeBetween(edges, 300, 300, 300, 000)); // A-C
            Assert.IsTrue(AnyEdgeBetween(edges, 300, 300, 600, 600)); // A-D

            // The above fails; the actual output is:
            // (600,600)->(600,600)
            // (0,600)->(0,600) -- wrong
            // (300,0)->(300,300)
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

            Assert.IsTrue(AnyEdgeBetween(edges, 300, 300, 300, 600)); // A-B
            Assert.IsTrue(AnyEdgeBetween(edges, 300, 300, 000, 000)); // A-C
            Assert.IsTrue(AnyEdgeBetween(edges, 300, 300, 600, 000)); // A-D
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

            Assert.IsTrue(AnyEdgeBetween(edges, 300, 300, 000, 600)); // A-B
            Assert.IsTrue(AnyEdgeBetween(edges, 300, 300, 000, 000)); // A-C
            Assert.IsTrue(AnyEdgeBetween(edges, 300, 300, 600, 300)); // A-D

            // The above fails; the actual output is:
            // (300,300)->(600,300)
            // (0,600)->(0,600) -- wrong
            // (300,300)->(0,0)
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

            Assert.IsTrue(AnyEdgeBetween(edges, 300, 300, 000, 300)); // A-B
            Assert.IsTrue(AnyEdgeBetween(edges, 300, 300, 600, 000)); // A-C
            Assert.IsTrue(AnyEdgeBetween(edges, 300, 300, 600, 600)); // A-D

            // The above fails; the actual output is:
            // (600,600)->(600,600) -- wrong
            // (300,300)->(0,300)
            // (600,0)->(300,300)
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

            Assert.IsTrue(AnyEdgeBetween(edges, 300, 300, 000, 600)); // A-B
            Assert.IsTrue(AnyEdgeBetween(edges, 300, 300, 000, 000)); // A-C
            Assert.IsTrue(AnyEdgeBetween(edges, 300, 300, 600, 000)); // A-D
            Assert.IsTrue(AnyEdgeBetween(edges, 300, 300, 600, 600)); // A-E
            Assert.IsTrue(AnyEdgeBetween(edges, 300, 300, 300, 300)); // A-A - because that's how this algorithm works

            // The above fails; the actual output is:
            // (600,600)->(600,600) --- wrong
            // (0,600)->(0,600) --- wrong
            // (300,300)->(300,300)
            // (600,0)->(300,300)
            // (300,300)->(0,0)
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

            Assert.IsTrue(AnyEdgeBetween(edges, 250, 350, 250, 250)); // A-B
            Assert.IsTrue(AnyEdgeBetween(edges, 250, 250, 350, 250)); // B-C
            Assert.IsTrue(AnyEdgeBetween(edges, 350, 250, 350, 350)); // C-D
            Assert.IsTrue(AnyEdgeBetween(edges, 350, 350, 250, 350)); // D-A

            Assert.IsTrue(AnyEdgeBetween(edges, 250, 350, 000, 600)); // A-E
            Assert.IsTrue(AnyEdgeBetween(edges, 250, 250, 000, 000)); // B-F
            Assert.IsTrue(AnyEdgeBetween(edges, 350, 250, 600, 000)); // C-G
            Assert.IsTrue(AnyEdgeBetween(edges, 350, 350, 600, 600)); // D-H

            // The above fails; the actual output is:
            // (600,600)->(600,600) ---- wrong
            // (0,600)->(0,600) ---- wrong
            // (350,350)->(250,350)
            // (350,250)->(350,350)
            // (250,250)->(250,350)
            // (600,0)->(350,250)
            // (350,250)->(250,250)
            // (250,250)->(0,0)
        }


        private static bool AnyEdgeBetween(IEnumerable<VEdge> edges, double x1, double y1, double x2, double y2)
        {
            return edges.Any(
                e =>
                    e.Start != null && e.End != null &&
                    e.Start.X == x1 && e.Start.Y == y1 && e.End.X == x2 && e.End.Y == y2 ||
                    e.Start.X == x2 && e.Start.Y == y2 && e.End.X == x1 && e.End.Y == y1
            );
        }
    }
}