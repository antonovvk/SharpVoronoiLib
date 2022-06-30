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

        [Test]
        public void FortuneFourEquidistantPoints()
        {
            var points = new List<FortuneSite>
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
        public void FourSitesSurroundingASite()
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

            //     
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
            // (600,600)->(600,600) ---- this is totally wrong, was expecting D-H
            // (0,600)->(0,600) ---- this is totally wrong, was expecting A-E
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
                    e.Start.X == x1 && e.Start.Y == y1 && e.End.X == x2 && e.End.Y == y2 ||
                    e.Start.X == x2 && e.Start.Y == y2 && e.End.X == x1 && e.End.Y == y1
            );
        }
    }
}