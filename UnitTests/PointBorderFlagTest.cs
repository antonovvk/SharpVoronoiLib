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

            List<VEdge> edges = FortunesAlgorithm.RunOnce(points, 0, 0, 600, 600).ToList();

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
            
            Assert.IsTrue(EdgeStartsAndEndsOnBorder(edges[0], PointBorderLocation.Left, PointBorderLocation.Right)); // A-B
        }

        [Test]
        public void TwoPointsVertical()
        {
            List<FortuneSite> points = new List<FortuneSite>
            {
                new FortuneSite(200, 300), // 1
                new FortuneSite(400, 300) // 2
            };

            List<VEdge> edges = FortunesAlgorithm.RunOnce(points, 0, 0, 600, 600).ToList();
            
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
            
            Assert.IsTrue(EdgeStartsAndEndsOnBorder(edges[0], PointBorderLocation.Top, PointBorderLocation.Bottom)); // A-B
        }

        [Test]
        public void TwoPointsDiagonalForward()
        {
            List<FortuneSite> points = new List<FortuneSite>
            {
                new FortuneSite(150, 150), // 1
                new FortuneSite(450, 450) // 2
            };

            List<VEdge> edges = FortunesAlgorithm.RunOnce(points, 0, 0, 600, 600).ToList();

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
            
            Assert.IsTrue(EdgeStartsAndEndsOnBorder(edges[0], PointBorderLocation.TopLeft, PointBorderLocation.BottomRight)); // A-B
        }

        [Test]
        public void TwoPointsDiagonalBackward()
        {
            List<FortuneSite> points = new List<FortuneSite>
            {
                new FortuneSite(450, 150), // 1
                new FortuneSite(150, 450) // 2
            };

            List<VEdge> edges = FortunesAlgorithm.RunOnce(points, 0, 0, 600, 600).ToList();

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

            Assume.That(() => edges.Count == 1);

            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 000, 600, 600)); // A-B
            
            Assert.IsTrue(EdgeStartsAndEndsOnBorder(edges[0], PointBorderLocation.BottomLeft, PointBorderLocation.TopRight)); // A-B
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

            List<VEdge> edges = FortunesAlgorithm.RunOnce(points, 0, 0, 600, 600).ToList();

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
            
            Assert.IsTrue(EdgeStartsXorEndsOnBorder(FindEdge(edges, 350, 350, 600, 600), PointBorderLocation.TopRight)); // A-B
            Assert.IsTrue(EdgeStartsXorEndsOnBorder(FindEdge(edges, 350, 350, 000, 350), PointBorderLocation.Left)); // A-C
            Assert.IsTrue(EdgeStartsXorEndsOnBorder(FindEdge(edges, 350, 350, 350, 000), PointBorderLocation.Bottom)); // A-D
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

            List<VEdge> edges = FortunesAlgorithm.RunOnce(points, 0, 0, 600, 600).ToList();

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
            
            Assert.IsTrue(EdgeStartsXorEndsOnBorder(FindEdge(edges, 250, 350, 000, 600), PointBorderLocation.TopLeft)); // A-B
            Assert.IsTrue(EdgeStartsXorEndsOnBorder(FindEdge(edges, 250, 350, 600, 350), PointBorderLocation.Right)); // A-C
            Assert.IsTrue(EdgeStartsXorEndsOnBorder(FindEdge(edges, 250, 350, 250, 000), PointBorderLocation.Bottom)); // A-D
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

            List<VEdge> edges = FortunesAlgorithm.RunOnce(points, 0, 0, 600, 600).ToList();

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
            
            Assert.IsTrue(EdgeStartsXorEndsOnBorder(FindEdge(edges, 250, 250, 000, 000), PointBorderLocation.BottomLeft)); // A-B
            Assert.IsTrue(EdgeStartsXorEndsOnBorder(FindEdge(edges, 250, 250, 600, 250), PointBorderLocation.Right)); // A-C
            Assert.IsTrue(EdgeStartsXorEndsOnBorder(FindEdge(edges, 250, 250, 250, 600), PointBorderLocation.Top)); // A-D
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

            List<VEdge> edges = FortunesAlgorithm.RunOnce(points, 0, 0, 600, 600).ToList();

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
            
            Assert.IsTrue(EdgeStartsXorEndsOnBorder(FindEdge(edges, 350, 250, 600, 000), PointBorderLocation.BottomRight)); // A-B
            Assert.IsTrue(EdgeStartsXorEndsOnBorder(FindEdge(edges, 350, 250, 350, 600), PointBorderLocation.Top)); // A-C
            Assert.IsTrue(EdgeStartsXorEndsOnBorder(FindEdge(edges, 350, 250, 000, 250), PointBorderLocation.Left)); // A-D
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

            List<VEdge> edges = FortunesAlgorithm.RunOnce(points, 0, 0, 600, 600).ToList();

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
            
            Assert.IsTrue(EdgeStartsXorEndsOnBorder(FindEdge(edges, 300, 300, 000, 600), PointBorderLocation.TopLeft)); // A-B
            Assert.IsTrue(EdgeStartsXorEndsOnBorder(FindEdge(edges, 300, 300, 300, 000), PointBorderLocation.Bottom)); // A-C
            Assert.IsTrue(EdgeStartsXorEndsOnBorder(FindEdge(edges, 300, 300, 600, 600), PointBorderLocation.TopRight)); // A-D
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

            List<VEdge> edges = FortunesAlgorithm.RunOnce(points, 0, 0, 600, 600).ToList();

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
            
            Assert.IsTrue(EdgeStartsXorEndsOnBorder(FindEdge(edges, 300, 300, 300, 600), PointBorderLocation.Top)); // A-B
            Assert.IsTrue(EdgeStartsXorEndsOnBorder(FindEdge(edges, 300, 300, 000, 000), PointBorderLocation.BottomLeft)); // A-C
            Assert.IsTrue(EdgeStartsXorEndsOnBorder(FindEdge(edges, 300, 300, 600, 000), PointBorderLocation.BottomRight)); // A-D
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

            List<VEdge> edges = FortunesAlgorithm.RunOnce(points, 0, 0, 600, 600).ToList();

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
            
            Assert.IsTrue(EdgeStartsXorEndsOnBorder(FindEdge(edges, 300, 300, 000, 600), PointBorderLocation.TopLeft)); // A-B
            Assert.IsTrue(EdgeStartsXorEndsOnBorder(FindEdge(edges, 300, 300, 000, 000), PointBorderLocation.BottomLeft)); // A-C
            Assert.IsTrue(EdgeStartsXorEndsOnBorder(FindEdge(edges, 300, 300, 600, 300), PointBorderLocation.Right)); // A-D
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

            List<VEdge> edges = FortunesAlgorithm.RunOnce(points, 0, 0, 600, 600).ToList();

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
            
            Assert.IsTrue(EdgeStartsXorEndsOnBorder(FindEdge(edges, 300, 300, 000, 300), PointBorderLocation.Left)); // A-B
            Assert.IsTrue(EdgeStartsXorEndsOnBorder(FindEdge(edges, 300, 300, 600, 000), PointBorderLocation.BottomRight)); // A-C
            Assert.IsTrue(EdgeStartsXorEndsOnBorder(FindEdge(edges, 300, 300, 600, 600), PointBorderLocation.TopRight)); // A-D
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

            List<VEdge> edges = FortunesAlgorithm.RunOnce(points, 0, 0, 600, 600).ToList();

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

            Assert.IsTrue(EdgeStartsXorEndsOnBorder(FindEdge(edges, 250, 350, 000, 600), PointBorderLocation.TopLeft)); // A-E
            Assert.IsTrue(EdgeStartsXorEndsOnBorder(FindEdge(edges, 250, 250, 000, 000), PointBorderLocation.BottomLeft)); // B-F
            Assert.IsTrue(EdgeStartsXorEndsOnBorder(FindEdge(edges, 350, 250, 600, 000), PointBorderLocation.BottomRight)); // C-G
            Assert.IsTrue(EdgeStartsXorEndsOnBorder(FindEdge(edges, 350, 350, 600, 600), PointBorderLocation.TopRight)); // D-H
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
    
            List<FortuneSite> points = new List<FortuneSite>(count);
    
            for (int j = 0; j < count; j++)
            {
                points.Add(new FortuneSite(random.NextDouble() * 3000 - 1500, random.NextDouble() * 3000 - 1500));
            }

            List<VEdge> edges = FortunesAlgorithm.RunOnce(points, 0, 0, 600, 600).ToList();

            foreach (VEdge edge in edges)
            {
                PointBorderLocation expectedBorderLocation = GetBorderLocationForCoordinate(edge.Start.X, edge.Start.Y, 0, 0, 600, 600);
                Assert.AreEqual(expectedBorderLocation, edge.Start.BorderLocation);

                expectedBorderLocation = GetBorderLocationForCoordinate(edge.End.X, edge.End.Y, 0, 0, 600, 600);
                Assert.AreEqual(expectedBorderLocation, edge.End.BorderLocation);
            }
            
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
    
            List<FortuneSite> points = new List<FortuneSite>(count);
    
            for (int j = 0; j < count; j++)
            {
                points.Add(new FortuneSite(random.Next(3000) - 1500, random.Next(3000) - 1500));
            }

            List<VEdge> edges = FortunesAlgorithm.RunOnce(points, 0, 0, 600, 600).ToList();

            foreach (VEdge edge in edges)
            {
                PointBorderLocation expectedBorderLocation = GetBorderLocationForCoordinate(edge.Start.X, edge.Start.Y, 0, 0, 600, 600);
                Assert.AreEqual(expectedBorderLocation, edge.Start.BorderLocation);

                expectedBorderLocation = GetBorderLocationForCoordinate(edge.End.X, edge.End.Y, 0, 0, 600, 600);
                Assert.AreEqual(expectedBorderLocation, edge.End.BorderLocation);
            }
            
            Assert.Pass();
        }
        
        private static PointBorderLocation GetBorderLocationForCoordinate(double x, double y, double minX, double minY, double maxX, double maxY)
        {
            if (x.ApproxEqual(minX) && y.ApproxEqual(minY)) return PointBorderLocation.BottomLeft;
            if (x.ApproxEqual(minX) && y.ApproxEqual(maxY)) return PointBorderLocation.TopLeft;
            if (x.ApproxEqual(maxX) && y.ApproxEqual(minY)) return PointBorderLocation.BottomRight;
            if (x.ApproxEqual(maxX) && y.ApproxEqual(maxY)) return PointBorderLocation.TopRight;
            
            if (x.ApproxEqual(minX)) return PointBorderLocation.Left;
            if (y.ApproxEqual(minY)) return PointBorderLocation.Bottom;
            if (x.ApproxEqual(maxX)) return PointBorderLocation.Right;
            if (y.ApproxEqual(maxY)) return PointBorderLocation.Top;
            
            return PointBorderLocation.NotOnBorder;
        }
#endif
        

        private VEdge FindEdge(List<VEdge> edges, int x1, int y1, int x2, int y2)
        {
            return edges.First(
                e =>
                    e.Start != null && e.End != null &&
                    e.Start.X.ApproxEqual(x1) && e.Start.Y.ApproxEqual(y1) && e.End.X.ApproxEqual(x2) && e.End.Y.ApproxEqual(y2) ||
                    e.Start.X.ApproxEqual(x2) && e.Start.Y.ApproxEqual(y2) && e.End.X.ApproxEqual(x1) && e.End.Y.ApproxEqual(y1)
            );
        }

        private static bool EdgeStartsAndEndsOnBorder(VEdge edge, PointBorderLocation border1, PointBorderLocation border2)
        {
            return 
                (edge.Start.BorderLocation == border1 && 
                edge.End.BorderLocation == border2) 
                ||
                (edge.Start.BorderLocation == border2 && 
                edge.End.BorderLocation == border1);
        }

        private static bool EdgeStartsXorEndsOnBorder(VEdge edge, PointBorderLocation border)
        {
            return 
                (edge.Start.BorderLocation == border &&
                edge.End.BorderLocation == PointBorderLocation.NotOnBorder) 
                ||
                (edge.Start.BorderLocation == PointBorderLocation.NotOnBorder &&
                 edge.End.BorderLocation == border);
        }

        private static bool EdgeDoesntStartsOrEndsOnBorder(VEdge edge)
        {
            return 
                edge.Start.BorderLocation == PointBorderLocation.NotOnBorder &&
                edge.End.BorderLocation == PointBorderLocation.NotOnBorder;
        }
    }
}