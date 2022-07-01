// unset

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
    public class FortuneSiteClosedCellTest
    {
        [Test]
        public void TwoPointsHorizontal()
        {
            List<FortuneSite> points = new List<FortuneSite>
            {
                new FortuneSite(300, 200), // 1
                new FortuneSite(300, 400) // 2
            };

            List<VEdge> edges = FortunesAlgorithm.Run(points, 0, 0, 600, 600, true).ToList();

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
            
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 300, 600, 300)); // A-B
            
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 000, 600, 000)); // X-W
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 600, 000, 600, 300)); // W-B
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 600, 300, 600, 600)); // B-Z
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 600, 600, 000, 600)); // Z-Y
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 600, 000, 300)); // Y-A
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 300, 000, 000)); // A-X
            
            Assume.That(() => FortuneSiteCellTest.SiteHasEdge(points[0], 000, 300, 600, 300)); // 1 has A-B
            Assume.That(() => FortuneSiteCellTest.SiteHasEdge(points[1], 000, 300, 600, 300)); // 2 has A-B

            foreach (FortuneSite site in points)
                Console.WriteLine(site + ": " + string.Join("; ", site.Cell.Select(c => c.ToString("F0"))));
            
            Assert.IsTrue(FortuneSiteCellTest.SiteHasEdge(points[0], 000, 300, 000, 000)); // 1 has A-X
            Assert.IsTrue(FortuneSiteCellTest.SiteHasEdge(points[0], 000, 000, 600, 000)); // 1 has X-W
            Assert.IsTrue(FortuneSiteCellTest.SiteHasEdge(points[0], 600, 000, 600, 300)); // 1 has W-B
            Assert.IsTrue(FortuneSiteCellTest.SiteHasEdge(points[1], 000, 600, 000, 300)); // 2 has A-Y
            Assert.IsTrue(FortuneSiteCellTest.SiteHasEdge(points[1], 600, 600, 000, 600)); // 2 has Y-Z
            Assert.IsTrue(FortuneSiteCellTest.SiteHasEdge(points[1], 600, 300, 600, 600)); // 2 has Z-B
        }

        [Test]
        public void TwoPointsVertical()
        {
            List<FortuneSite> points = new List<FortuneSite>
            {
                new FortuneSite(200, 300), // 1
                new FortuneSite(400, 300) // 2
            };

            List<VEdge> edges = FortunesAlgorithm.Run(points, 0, 0, 600, 600, true).ToList();
            
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

            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 300, 000, 300, 600)); // A-B
            
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 000, 300, 000)); // Y-A
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 300, 000, 600, 000)); // A-Z
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 600, 000, 600, 600)); // Z-W
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 600, 600, 300, 600)); // W-B
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 300, 600, 000, 600)); // B-X
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 600, 000, 000)); // X-Y
            
            Assume.That(() => FortuneSiteCellTest.SiteHasEdge(points[0], 300, 000, 300, 600)); // 1 has A-B
            Assume.That(() => FortuneSiteCellTest.SiteHasEdge(points[1], 300, 000, 300, 600)); // 2 has A-B

            foreach (FortuneSite site in points)
                Console.WriteLine(site + ": " + string.Join("; ", site.Cell.Select(c => c.ToString("F0"))));
            
            Assert.IsTrue(FortuneSiteCellTest.SiteHasEdge(points[0], 300, 600, 000, 600)); // 1 has B-X
            Assert.IsTrue(FortuneSiteCellTest.SiteHasEdge(points[0], 000, 600, 000, 000)); // 1 has X-Y
            Assert.IsTrue(FortuneSiteCellTest.SiteHasEdge(points[0], 000, 000, 300, 000)); // 1 has A-Y
            Assert.IsTrue(FortuneSiteCellTest.SiteHasEdge(points[1], 300, 000, 600, 000)); // 2 has A-Z
            Assert.IsTrue(FortuneSiteCellTest.SiteHasEdge(points[1], 600, 000, 600, 600)); // 2 has Z-W
            Assert.IsTrue(FortuneSiteCellTest.SiteHasEdge(points[1], 600, 600, 300, 600)); // 2 has W-B
        }

        [Test]
        public void TwoPointsDiagonalForward()
        {
            List<FortuneSite> points = new List<FortuneSite>
            {
                new FortuneSite(150, 150), // 1
                new FortuneSite(450, 450) // 2
            };

            List<VEdge> edges = FortunesAlgorithm.Run(points, 0, 0, 600, 600, true).ToList();

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

            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 600, 600, 000)); // A-B
            
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 000, 600, 000)); // X-B
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 600, 000, 600, 600)); // B-Y
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 600, 600, 000, 600)); // Y-A
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 600, 000, 000)); // A-X
            
            Assert.IsTrue(FortuneSiteCellTest.SiteHasEdge(points[0], 000, 600, 600, 000)); // 1 has A-B
            Assert.IsTrue(FortuneSiteCellTest.SiteHasEdge(points[1], 000, 600, 600, 000)); // 2 has A-B

            foreach (FortuneSite site in points)
                Console.WriteLine(site + ": " + string.Join("; ", site.Cell.Select(c => c.ToString("F0"))));
            
            Assert.IsTrue(FortuneSiteCellTest.SiteHasEdge(points[0], 000, 600, 000, 000)); // 1 has A-X
            Assert.IsTrue(FortuneSiteCellTest.SiteHasEdge(points[0], 000, 000, 600, 000)); // 1 has X-B
            Assert.IsTrue(FortuneSiteCellTest.SiteHasEdge(points[1], 600, 600, 000, 600)); // 2 has A-Y
            Assert.IsTrue(FortuneSiteCellTest.SiteHasEdge(points[1], 600, 000, 600, 600)); // 2 has Y-B
        }

        [Test]
        public void TwoPointsDiagonalBackward()
        {
            List<FortuneSite> points = new List<FortuneSite>
            {
                new FortuneSite(450, 150), // 1
                new FortuneSite(150, 450) // 2
            };

            List<VEdge> edges = FortunesAlgorithm.Run(points, 0, 0, 600, 600, true).ToList();

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

            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 000, 600, 600)); // A-B
            
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 600, 600, 600)); // X-B
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 600, 600, 600, 000)); // B-Y
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 600, 000, 000, 000)); // Y-A
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 000, 000, 600)); // A-X
            
            Assume.That(() => FortuneSiteCellTest.SiteHasEdge(points[0], 000, 000, 600, 600)); // 1 has A-B
            Assume.That(() => FortuneSiteCellTest.SiteHasEdge(points[1], 000, 000, 600, 600)); // 2 has A-B

            foreach (FortuneSite site in points)
                Console.WriteLine(site + ": " + string.Join("; ", site.Cell.Select(c => c.ToString("F0"))));
            
            Assert.IsTrue(FortuneSiteCellTest.SiteHasEdge(points[0], 600, 000, 000, 000)); // 1 has A-Y
            Assert.IsTrue(FortuneSiteCellTest.SiteHasEdge(points[0], 600, 600, 600, 000)); // 1 has Y-B
            Assert.IsTrue(FortuneSiteCellTest.SiteHasEdge(points[1], 000, 000, 000, 600)); // 2 has A-X
            Assert.IsTrue(FortuneSiteCellTest.SiteHasEdge(points[1], 000, 600, 600, 600)); // 2 has X-B
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

            List<VEdge> edges = FortunesAlgorithm.Run(points, 0, 0, 600, 600, true).ToList();

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

            foreach (VEdge edge in edges)
                Console.WriteLine(edge.ToString("F0"));

            Assert.AreEqual(9, edges.Count);

            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 350, 350, 600, 600)); // A-B
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 350, 350, 000, 350)); // A-C
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 350, 350, 350, 000)); // A-D

            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 000, 350, 000)); // Y-D
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 350, 000, 600, 000)); // D-Z
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 600, 000, 600, 600)); // Z-B
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 600, 600, 000, 600)); // B-X
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 600, 000, 350)); // X-C
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 350, 000, 000)); // C-Y
            
            Assume.That(() => FortuneSiteCellTest.SiteHasEdge(points[0], 350, 350, 000, 350)); // 1 has A-C
            Assume.That(() => FortuneSiteCellTest.SiteHasEdge(points[0], 350, 350, 000, 350)); // 1 has A-D
            Assume.That(() => FortuneSiteCellTest.SiteHasEdge(points[1], 350, 350, 600, 600)); // 2 has A-B
            Assume.That(() => FortuneSiteCellTest.SiteHasEdge(points[1], 350, 350, 000, 350)); // 2 has A-C
            Assume.That(() => FortuneSiteCellTest.SiteHasEdge(points[2], 350, 350, 600, 600)); // 3 has A-B
            Assume.That(() => FortuneSiteCellTest.SiteHasEdge(points[2], 350, 350, 350, 000)); // 3 has A-D

            foreach (FortuneSite site in points)
                Console.WriteLine(site + ": " + string.Join("; ", site.Cell.Select(c => c.ToString("F0"))));
            
            Assert.IsTrue(FortuneSiteCellTest.SiteHasEdge(points[0], 000, 350, 000, 000)); // 1 has C-Y
            Assert.IsTrue(FortuneSiteCellTest.SiteHasEdge(points[0], 000, 000, 350, 000)); // 1 has D-Y
            Assert.IsTrue(FortuneSiteCellTest.SiteHasEdge(points[1], 000, 600, 000, 350)); // 2 has C-X
            Assert.IsTrue(FortuneSiteCellTest.SiteHasEdge(points[1], 600, 600, 000, 600)); // 2 has B-X
            Assert.IsTrue(FortuneSiteCellTest.SiteHasEdge(points[2], 350, 000, 600, 000)); // 3 has D-Z
            Assert.IsTrue(FortuneSiteCellTest.SiteHasEdge(points[2], 600, 000, 600, 600)); // 3 has B-Z
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

            List<VEdge> edges = FortunesAlgorithm.Run(points, 0, 0, 600, 600, true).ToList();

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

            foreach (VEdge edge in edges)
                Console.WriteLine(edge.ToString("F0"));

            Assert.AreEqual(9, edges.Count);

            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 250, 350, 000, 600)); // A-B
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 250, 350, 600, 350)); // A-C
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 250, 350, 250, 000)); // A-D
            
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 000, 250, 000)); // X-D
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 250, 000, 600, 000)); // D-Y
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 600, 000, 600, 350)); // Y-C
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 600, 350, 600, 600)); // C-Z
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 600, 600, 000, 600)); // Z-B
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 600, 000, 000)); // B-X
            
            Assume.That(() => FortuneSiteCellTest.SiteHasEdge(points[0], 250, 350, 000, 600)); // 1 has A-B
            Assume.That(() => FortuneSiteCellTest.SiteHasEdge(points[0], 250, 350, 250, 000)); // 1 has A-D
            Assume.That(() => FortuneSiteCellTest.SiteHasEdge(points[1], 250, 350, 000, 600)); // 2 has A-B
            Assume.That(() => FortuneSiteCellTest.SiteHasEdge(points[1], 250, 350, 600, 350)); // 2 has A-C
            Assume.That(() => FortuneSiteCellTest.SiteHasEdge(points[2], 250, 350, 600, 350)); // 3 has A-C
            Assume.That(() => FortuneSiteCellTest.SiteHasEdge(points[2], 250, 350, 250, 000)); // 3 has A-D

            foreach (FortuneSite site in points)
                Console.WriteLine(site + ": " + string.Join("; ", site.Cell.Select(c => c.ToString("F0"))));
            
            Assert.IsTrue(FortuneSiteCellTest.SiteHasEdge(points[0], 000, 600, 000, 000)); // 1 has B-X
            Assert.IsTrue(FortuneSiteCellTest.SiteHasEdge(points[0], 000, 000, 250, 000)); // 1 has D-X
            Assert.IsTrue(FortuneSiteCellTest.SiteHasEdge(points[1], 600, 600, 000, 600)); // 2 has B-Z
            Assert.IsTrue(FortuneSiteCellTest.SiteHasEdge(points[1], 600, 350, 600, 600)); // 2 has C-Z
            Assert.IsTrue(FortuneSiteCellTest.SiteHasEdge(points[2], 250, 000, 600, 000)); // 3 has D-Y
            Assert.IsTrue(FortuneSiteCellTest.SiteHasEdge(points[2], 600, 000, 600, 350)); // 3 has C-Y
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

            List<VEdge> edges = FortunesAlgorithm.Run(points, 0, 0, 600, 600, true).ToList();

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

            foreach (VEdge edge in edges)
                Console.WriteLine(edge.ToString("F0"));

            Assert.AreEqual(9, edges.Count);

            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 250, 250, 000, 000)); // A-B
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 250, 250, 600, 250)); // A-C
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 250, 250, 250, 600)); // A-D
            
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 000, 600, 000)); // B-Y
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 600, 000, 600, 250)); // Y-C
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 250, 600, 600, 600)); // C-Z
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 600, 600, 250, 600)); // Z-D
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 250, 600, 000, 600)); // D-X
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 600, 000, 000)); // X-B
            
            Assume.That(() => FortuneSiteCellTest.SiteHasEdge(points[0], 250, 250, 000, 000)); // 1 has A-B
            Assume.That(() => FortuneSiteCellTest.SiteHasEdge(points[0], 250, 250, 250, 600)); // 1 has A-D
            Assume.That(() => FortuneSiteCellTest.SiteHasEdge(points[1], 250, 250, 600, 250)); // 2 has A-C
            Assume.That(() => FortuneSiteCellTest.SiteHasEdge(points[1], 250, 250, 250, 600)); // 2 has A-D
            Assume.That(() => FortuneSiteCellTest.SiteHasEdge(points[2], 250, 250, 000, 000)); // 3 has A-B
            Assume.That(() => FortuneSiteCellTest.SiteHasEdge(points[2], 250, 250, 600, 250)); // 3 has A-C

            foreach (FortuneSite site in points)
                Console.WriteLine(site + ": " + string.Join("; ", site.Cell.Select(c => c.ToString("F0"))));
            
            Assert.IsTrue(FortuneSiteCellTest.SiteHasEdge(points[0], 000, 600, 000, 000)); // 1 has B-X
            Assert.IsTrue(FortuneSiteCellTest.SiteHasEdge(points[0], 250, 600, 000, 600)); // 1 has D-X
            Assert.IsTrue(FortuneSiteCellTest.SiteHasEdge(points[1], 600, 600, 250, 600)); // 2 has D-Z
            Assert.IsTrue(FortuneSiteCellTest.SiteHasEdge(points[1], 250, 600, 600, 600)); // 2 has C-Z
            Assert.IsTrue(FortuneSiteCellTest.SiteHasEdge(points[2], 000, 000, 600, 000)); // 3 has B-Y
            Assert.IsTrue(FortuneSiteCellTest.SiteHasEdge(points[2], 600, 000, 600, 250)); // 3 has C-Y
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

            List<VEdge> edges = FortunesAlgorithm.Run(points, 0, 0, 600, 600, true).ToList();

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

            foreach (VEdge edge in edges)
                Console.WriteLine(edge.ToString("F0"));

            Assert.AreEqual(9, edges.Count);

            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 350, 250, 600, 000)); // A-B
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 350, 250, 350, 600)); // A-C
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 350, 250, 000, 250)); // A-D     
            
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 000, 600, 000)); // Y-B
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 600, 000, 600, 600)); // B-Z
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 600, 600, 350, 600)); // Z-C
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 350, 600, 000, 600)); // C-X
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 600, 000, 250)); // X-D
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 250, 000, 000)); // D-Y
            
            Assume.That(() => FortuneSiteCellTest.SiteHasEdge(points[0], 350, 250, 600, 000)); // 1 has A-B
            Assume.That(() => FortuneSiteCellTest.SiteHasEdge(points[0], 350, 250, 000, 250)); // 1 has A-D
            Assume.That(() => FortuneSiteCellTest.SiteHasEdge(points[1], 350, 250, 350, 600)); // 2 has A-C
            Assume.That(() => FortuneSiteCellTest.SiteHasEdge(points[1], 350, 250, 000, 250)); // 2 has A-D
            Assume.That(() => FortuneSiteCellTest.SiteHasEdge(points[2], 350, 250, 600, 000)); // 3 has A-B
            Assume.That(() => FortuneSiteCellTest.SiteHasEdge(points[2], 350, 250, 350, 600)); // 3 has A-C

            foreach (FortuneSite site in points)
                Console.WriteLine(site + ": " + string.Join("; ", site.Cell.Select(c => c.ToString("F0"))));
            
            Assert.IsTrue(FortuneSiteCellTest.SiteHasEdge(points[0], 000, 250, 000, 000)); // 1 has D-Y
            Assert.IsTrue(FortuneSiteCellTest.SiteHasEdge(points[0], 000, 000, 600, 000)); // 1 has B-Y
            Assert.IsTrue(FortuneSiteCellTest.SiteHasEdge(points[1], 000, 600, 000, 250)); // 2 has D-X
            Assert.IsTrue(FortuneSiteCellTest.SiteHasEdge(points[1], 350, 600, 000, 600)); // 2 has C-X
            Assert.IsTrue(FortuneSiteCellTest.SiteHasEdge(points[2], 600, 000, 600, 600)); // 3 has B-Z
            Assert.IsTrue(FortuneSiteCellTest.SiteHasEdge(points[2], 600, 600, 350, 600)); // 3 has C-Z
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

            List<VEdge> edges = FortunesAlgorithm.Run(points, 0, 0, 600, 600, true).ToList();

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

            foreach (VEdge edge in edges)
                Console.WriteLine(edge.ToString("F0"));

            Assert.AreEqual(8, edges.Count);

            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 300, 300, 000, 600)); // A-B
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 300, 300, 300, 000)); // A-C
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 300, 300, 600, 600)); // A-D  
            
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 000, 300, 000)); // X-C
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 300, 000, 600, 000)); // C-Y
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 600, 000, 600, 600)); // Y-D
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 600, 600, 000, 600)); // D-B
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 600, 000, 000)); // B-X
            
            Assume.That(() => FortuneSiteCellTest.SiteHasEdge(points[0], 300, 300, 000, 600)); // 1 has A-B
            Assume.That(() => FortuneSiteCellTest.SiteHasEdge(points[0], 300, 300, 300, 000)); // 1 has A-C
            Assume.That(() => FortuneSiteCellTest.SiteHasEdge(points[1], 300, 300, 000, 600)); // 2 has A-B
            Assume.That(() => FortuneSiteCellTest.SiteHasEdge(points[1], 300, 300, 600, 600)); // 2 has A-D
            Assume.That(() => FortuneSiteCellTest.SiteHasEdge(points[2], 300, 300, 300, 000)); // 3 has A-C
            Assume.That(() => FortuneSiteCellTest.SiteHasEdge(points[2], 300, 300, 600, 600)); // 3 has A-D

            foreach (FortuneSite site in points)
                Console.WriteLine(site + ": " + string.Join("; ", site.Cell.Select(c => c.ToString("F0"))));
            
            Assert.IsTrue(FortuneSiteCellTest.SiteHasEdge(points[0], 000, 000, 300, 000)); // 1 has C-X
            Assert.IsTrue(FortuneSiteCellTest.SiteHasEdge(points[0], 000, 600, 000, 000)); // 1 has B-X
            Assert.IsTrue(FortuneSiteCellTest.SiteHasEdge(points[1], 600, 600, 000, 600)); // 2 has B-D
            Assert.IsTrue(FortuneSiteCellTest.SiteHasEdge(points[2], 600, 000, 600, 600)); // 3 has D-Y
            Assert.IsTrue(FortuneSiteCellTest.SiteHasEdge(points[2], 300, 000, 600, 000)); // 3 has C-Y
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

            List<VEdge> edges = FortunesAlgorithm.Run(points, 0, 0, 600, 600, true).ToList();

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

            foreach (VEdge edge in edges)
                Console.WriteLine(edge.ToString("F0"));

            Assert.AreEqual(8, edges.Count);

            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 300, 300, 300, 600)); // A-B
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 300, 300, 000, 000)); // A-C
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 300, 300, 600, 000)); // A-D
            
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 000, 600, 000)); // C-D
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 600, 000, 600, 600)); // D-Y
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 600, 600, 300, 600)); // Y-B
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 300, 600, 000, 600)); // B-X
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 600, 000, 000)); // X-C
            
            Assume.That(() => FortuneSiteCellTest.SiteHasEdge(points[0], 300, 300, 300, 600)); // 1 has A-B
            Assume.That(() => FortuneSiteCellTest.SiteHasEdge(points[0], 300, 300, 000, 000)); // 1 has A-C
            Assume.That(() => FortuneSiteCellTest.SiteHasEdge(points[1], 300, 300, 000, 000)); // 2 has A-C
            Assume.That(() => FortuneSiteCellTest.SiteHasEdge(points[1], 300, 300, 600, 000)); // 2 has A-D
            Assume.That(() => FortuneSiteCellTest.SiteHasEdge(points[2], 300, 300, 300, 600)); // 3 has A-B
            Assume.That(() => FortuneSiteCellTest.SiteHasEdge(points[2], 300, 300, 600, 000)); // 3 has A-D

            foreach (FortuneSite site in points)
                Console.WriteLine(site + ": " + string.Join("; ", site.Cell.Select(c => c.ToString("F0"))));
            
            Assert.IsTrue(FortuneSiteCellTest.SiteHasEdge(points[0], 300, 600, 000, 600)); // 1 has B-X
            Assert.IsTrue(FortuneSiteCellTest.SiteHasEdge(points[0], 000, 600, 000, 000)); // 1 has C-X
            Assert.IsTrue(FortuneSiteCellTest.SiteHasEdge(points[1], 000, 000, 600, 000)); // 2 has C-D
            Assert.IsTrue(FortuneSiteCellTest.SiteHasEdge(points[2], 600, 600, 300, 600)); // 3 has B-Y
            Assert.IsTrue(FortuneSiteCellTest.SiteHasEdge(points[2], 600, 000, 600, 600)); // 3 has D-Y
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

            List<VEdge> edges = FortunesAlgorithm.Run(points, 0, 0, 600, 600, true).ToList();

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

            foreach (VEdge edge in edges)
                Console.WriteLine(edge.ToString("F0"));
            
            Assert.AreEqual(8, edges.Count);

            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 300, 300, 000, 600)); // A-B
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 300, 300, 000, 000)); // A-C
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 300, 300, 600, 300)); // A-D
            
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 000, 600, 000)); // C-X
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 600, 000, 600, 300)); // X-D
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 600, 300, 600, 600)); // D-Y
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 600, 600, 000, 600)); // Y-B
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 600, 000, 000)); // B-C
            
            Assume.That(() => FortuneSiteCellTest.SiteHasEdge(points[0], 300, 300, 000, 600)); // 1 has A-B
            Assume.That(() => FortuneSiteCellTest.SiteHasEdge(points[0], 300, 300, 000, 000)); // 1 has A-C
            Assume.That(() => FortuneSiteCellTest.SiteHasEdge(points[1], 300, 300, 000, 600)); // 2 has A-B
            Assume.That(() => FortuneSiteCellTest.SiteHasEdge(points[1], 300, 300, 600, 300)); // 2 has A-D
            Assume.That(() => FortuneSiteCellTest.SiteHasEdge(points[2], 300, 300, 000, 000)); // 3 has A-C
            Assume.That(() => FortuneSiteCellTest.SiteHasEdge(points[2], 300, 300, 600, 300)); // 3 has A-D

            foreach (FortuneSite site in points)
                Console.WriteLine(site + ": " + string.Join("; ", site.Cell.Select(c => c.ToString("F0"))));
            
            Assert.IsTrue(FortuneSiteCellTest.SiteHasEdge(points[0], 000, 600, 000, 000)); // 1 has B-C
            Assert.IsTrue(FortuneSiteCellTest.SiteHasEdge(points[1], 600, 600, 000, 600)); // 2 has B-Y
            Assert.IsTrue(FortuneSiteCellTest.SiteHasEdge(points[1], 600, 300, 600, 600)); // 2 has D-Y
            Assert.IsTrue(FortuneSiteCellTest.SiteHasEdge(points[2], 000, 000, 600, 000)); // 3 has C-X
            Assert.IsTrue(FortuneSiteCellTest.SiteHasEdge(points[2], 600, 000, 600, 300)); // 3 has D-X
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

            List<VEdge> edges = FortunesAlgorithm.Run(points, 0, 0, 600, 600, true).ToList();

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

            foreach (VEdge edge in edges)
                Console.WriteLine(edge.ToString("F0"));

            Assert.AreEqual(8, edges.Count);

            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 300, 300, 000, 300)); // A-B
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 300, 300, 600, 000)); // A-C
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 300, 300, 600, 600)); // A-D
            
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 000, 600, 000)); // X-C
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 600, 000, 600, 600)); // C-D
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 600, 600, 000, 600)); // D-Y
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 600, 000, 300)); // Y-B
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 300, 000, 000)); // B-X
            
            Assume.That(() => FortuneSiteCellTest.SiteHasEdge(points[0], 300, 300, 000, 300)); // 1 has A-B
            Assume.That(() => FortuneSiteCellTest.SiteHasEdge(points[0], 300, 300, 600, 600)); // 1 has A-D
            Assume.That(() => FortuneSiteCellTest.SiteHasEdge(points[1], 300, 300, 600, 000)); // 2 has A-C
            Assume.That(() => FortuneSiteCellTest.SiteHasEdge(points[1], 300, 300, 600, 600)); // 2 has A-D
            Assume.That(() => FortuneSiteCellTest.SiteHasEdge(points[2], 300, 300, 000, 300)); // 3 has A-B
            Assume.That(() => FortuneSiteCellTest.SiteHasEdge(points[2], 300, 300, 600, 000)); // 3 has A-C

            foreach (FortuneSite site in points)
                Console.WriteLine(site + ": " + string.Join("; ", site.Cell.Select(c => c.ToString("F0"))));
            
            Assert.IsTrue(FortuneSiteCellTest.SiteHasEdge(points[0], 000, 600, 000, 300)); // 1 has B-Y
            Assert.IsTrue(FortuneSiteCellTest.SiteHasEdge(points[0], 600, 600, 000, 600)); // 1 has D-Y
            Assert.IsTrue(FortuneSiteCellTest.SiteHasEdge(points[1], 600, 000, 600, 600)); // 2 has D-C
            Assert.IsTrue(FortuneSiteCellTest.SiteHasEdge(points[2], 000, 300, 000, 000)); // 3 has B-X
            Assert.IsTrue(FortuneSiteCellTest.SiteHasEdge(points[2], 000, 000, 600, 000)); // 3 has C-X
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

            List<VEdge> edges = FortunesAlgorithm.Run(points, 0, 0, 600, 600, true).ToList();

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

            Assert.AreEqual(12, edges.Count);

            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 250, 350, 250, 250)); // A-B
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 250, 250, 350, 250)); // B-C
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 350, 250, 350, 350)); // C-D
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 350, 350, 250, 350)); // D-A

            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 250, 350, 000, 600)); // A-E
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 250, 250, 000, 000)); // B-F
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 350, 250, 600, 000)); // C-G
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 350, 350, 600, 600)); // D-H
            
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 000, 600, 000)); // F-G
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 600, 000, 600, 600)); // G-H
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 600, 600, 000, 600)); // H-E
            Assume.That(() => FortuneAlgorithmTest.AnyEdgeBetween(edges, 000, 600, 000, 000)); // E-F
            
            Assume.That(() => FortuneSiteCellTest.SiteHasEdge(points[0], 250, 350, 250, 250)); // 1 has A-B
            Assume.That(() => FortuneSiteCellTest.SiteHasEdge(points[0], 250, 250, 350, 250)); // 1 has B-C
            Assume.That(() => FortuneSiteCellTest.SiteHasEdge(points[0], 350, 250, 350, 350)); // 1 has C-D
            Assume.That(() => FortuneSiteCellTest.SiteHasEdge(points[0], 350, 350, 250, 350)); // 1 has D-A
            Assume.That(() => FortuneSiteCellTest.SiteHasEdge(points[1], 250, 350, 000, 600)); // 2 has A-E
            Assume.That(() => FortuneSiteCellTest.SiteHasEdge(points[1], 250, 350, 250, 250)); // 2 has A-B
            Assume.That(() => FortuneSiteCellTest.SiteHasEdge(points[1], 250, 250, 000, 000)); // 2 has B-F
            Assume.That(() => FortuneSiteCellTest.SiteHasEdge(points[2], 250, 350, 000, 600)); // 3 has A-E
            Assume.That(() => FortuneSiteCellTest.SiteHasEdge(points[2], 350, 350, 250, 350)); // 3 has D-A
            Assume.That(() => FortuneSiteCellTest.SiteHasEdge(points[2], 350, 350, 600, 600)); // 3 has D-H
            Assume.That(() => FortuneSiteCellTest.SiteHasEdge(points[3], 250, 250, 000, 000)); // 4 has B-F
            Assume.That(() => FortuneSiteCellTest.SiteHasEdge(points[3], 250, 250, 350, 250)); // 4 has B-C
            Assume.That(() => FortuneSiteCellTest.SiteHasEdge(points[3], 350, 250, 600, 000)); // 4 has C-G
            Assume.That(() => FortuneSiteCellTest.SiteHasEdge(points[4], 350, 350, 600, 600)); // 5 has D-H
            Assume.That(() => FortuneSiteCellTest.SiteHasEdge(points[4], 350, 250, 350, 350)); // 5 has C-D
            Assume.That(() => FortuneSiteCellTest.SiteHasEdge(points[4], 350, 250, 600, 000)); // 5 has C-G

            foreach (FortuneSite site in points)
                Console.WriteLine(site + ": " + string.Join("; ", site.Cell.Select(c => c.ToString("F0"))));
            
            Assert.IsTrue(FortuneSiteCellTest.SiteHasEdge(points[1], 000, 600, 000, 000)); // 2 has F-E
            Assert.IsTrue(FortuneSiteCellTest.SiteHasEdge(points[2], 600, 600, 000, 600)); // 3 has E-H
            Assert.IsTrue(FortuneSiteCellTest.SiteHasEdge(points[3], 000, 000, 600, 000)); // 4 has F-G
            Assert.IsTrue(FortuneSiteCellTest.SiteHasEdge(points[4], 600, 000, 600, 600)); // 5 has H-G
        }
    }
}