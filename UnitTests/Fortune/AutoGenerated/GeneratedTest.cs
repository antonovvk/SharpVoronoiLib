using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using VoronoiLib;
using VoronoiLib.Structures;

namespace UnitTests
{
    /// <summary>
    /// This is an AUTO-GENERATED test from UnitTestGenerator.
    /// </summary>
    [Parallelizable(ParallelScope.All)]
    [TestFixture]
    public class GeneratedTest
    {
        [Test]
        public void OnePointInMiddle()
        {
            List<VoronoiSite> points = new List<VoronoiSite>
            {
                new VoronoiSite(500, 500), // #1
            };

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(points, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

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

            Assert.AreEqual(0, edges.Count);


        }

        [Test]
        public void TwoPointsVerticalAroundMiddle()
        {
            List<VoronoiSite> points = new List<VoronoiSite>
            {
                new VoronoiSite(500, 300), // #2
                new VoronoiSite(500, 700), // #1
            };

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(points, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

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

            Assert.AreEqual(1, edges.Count);

            Assert.IsTrue(CommonTestUtilities.AnyEdgeBetween(edges, 0, 500, 1000, 500)); // A-B

            Assert.IsTrue(CommonTestUtilities.SiteHasEdge(points[1], 0, 500, 1000, 500)); // #1 has A-B
            Assert.IsTrue(CommonTestUtilities.SiteHasEdge(points[0], 0, 500, 1000, 500)); // #2 has A-B
        }

        [Test]
        public void TwoPointsHorizontalAroundMiddle()
        {
            List<VoronoiSite> points = new List<VoronoiSite>
            {
                new VoronoiSite(300, 500), // #2
                new VoronoiSite(700, 500), // #1
            };

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(points, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

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

            Assert.AreEqual(1, edges.Count);

            Assert.IsTrue(CommonTestUtilities.AnyEdgeBetween(edges, 500, 1000, 500, 0)); // A-B

            Assert.IsTrue(CommonTestUtilities.SiteHasEdge(points[1], 500, 1000, 500, 0)); // #1 has A-B
            Assert.IsTrue(CommonTestUtilities.SiteHasEdge(points[0], 500, 1000, 500, 0)); // #2 has A-B
        }

        [Test]
        public void TwoPointsVerticalOffsetFromMiddle()
        {
            List<VoronoiSite> points = new List<VoronoiSite>
            {
                new VoronoiSite(500, 500), // #2
                new VoronoiSite(500, 900), // #1
            };

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(points, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

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

            Assert.AreEqual(1, edges.Count);

            Assert.IsTrue(CommonTestUtilities.AnyEdgeBetween(edges, 0, 700, 1000, 700)); // A-B

            Assert.IsTrue(CommonTestUtilities.SiteHasEdge(points[1], 0, 700, 1000, 700)); // #1 has A-B
            Assert.IsTrue(CommonTestUtilities.SiteHasEdge(points[0], 0, 700, 1000, 700)); // #2 has A-B
        }

        [Test]
        public void TwoPointsHorizontalOffsetFromMiddle()
        {
            List<VoronoiSite> points = new List<VoronoiSite>
            {
                new VoronoiSite(500, 500), // #2
                new VoronoiSite(900, 500), // #1
            };

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(points, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

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

            Assert.AreEqual(1, edges.Count);

            Assert.IsTrue(CommonTestUtilities.AnyEdgeBetween(edges, 700, 1000, 700, 0)); // A-B

            Assert.IsTrue(CommonTestUtilities.SiteHasEdge(points[1], 700, 1000, 700, 0)); // #1 has A-B
            Assert.IsTrue(CommonTestUtilities.SiteHasEdge(points[0], 700, 1000, 700, 0)); // #2 has A-B
        }

        [Test]
        public void ThreeConcentricPointsAroundMiddle()
        {
            List<VoronoiSite> points = new List<VoronoiSite>
            {
                new VoronoiSite(500, 100), // #3
                new VoronoiSite(500, 500), // #2
                new VoronoiSite(500, 900), // #1
            };

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(points, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

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

            Assert.AreEqual(2, edges.Count);

            Assert.IsTrue(CommonTestUtilities.AnyEdgeBetween(edges, 0, 700, 1000, 700)); // A-B
            Assert.IsTrue(CommonTestUtilities.AnyEdgeBetween(edges, 0, 300, 1000, 300)); // C-D

            Assert.IsTrue(CommonTestUtilities.SiteHasEdge(points[2], 0, 700, 1000, 700)); // #1 has A-B
            Assert.IsTrue(CommonTestUtilities.SiteHasEdge(points[1], 0, 700, 1000, 700)); // #2 has A-B
            Assert.IsTrue(CommonTestUtilities.SiteHasEdge(points[1], 0, 300, 1000, 300)); // #2 has C-D
            Assert.IsTrue(CommonTestUtilities.SiteHasEdge(points[0], 0, 300, 1000, 300)); // #3 has C-D
        }

        [Test]
        public void ThreeConcentricPointsAroundMiddle_Rotated90()
        {
            List<VoronoiSite> points = new List<VoronoiSite>
            {
                new VoronoiSite(100, 500), // #3
                new VoronoiSite(500, 500), // #2
                new VoronoiSite(900, 500), // #1
            };

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(points, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

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

            Assert.AreEqual(2, edges.Count);

            Assert.IsTrue(CommonTestUtilities.AnyEdgeBetween(edges, 700, 1000, 700, 0)); // A-B
            Assert.IsTrue(CommonTestUtilities.AnyEdgeBetween(edges, 300, 1000, 300, 0)); // C-D

            Assert.IsTrue(CommonTestUtilities.SiteHasEdge(points[2], 700, 1000, 700, 0)); // #1 has A-B
            Assert.IsTrue(CommonTestUtilities.SiteHasEdge(points[1], 700, 1000, 700, 0)); // #2 has A-B
            Assert.IsTrue(CommonTestUtilities.SiteHasEdge(points[1], 300, 1000, 300, 0)); // #2 has C-D
            Assert.IsTrue(CommonTestUtilities.SiteHasEdge(points[0], 300, 1000, 300, 0)); // #3 has C-D
        }

        [Test]
        public void TwoDiagonalPointsAroundMiddle()
        {
            List<VoronoiSite> points = new List<VoronoiSite>
            {
                new VoronoiSite(700, 300), // #2
                new VoronoiSite(300, 700), // #1
            };

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(points, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

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

            Assert.AreEqual(1, edges.Count);

            Assert.IsTrue(CommonTestUtilities.AnyEdgeBetween(edges, 0, 0, 1000, 1000)); // A-B

            Assert.IsTrue(CommonTestUtilities.SiteHasEdge(points[1], 0, 0, 1000, 1000)); // #1 has A-B
            Assert.IsTrue(CommonTestUtilities.SiteHasEdge(points[0], 0, 0, 1000, 1000)); // #2 has A-B
        }

        [Test]
        public void TwoDiagonalPointsAroundMiddle_Rotated90()
        {
            List<VoronoiSite> points = new List<VoronoiSite>
            {
                new VoronoiSite(300, 300), // #2
                new VoronoiSite(700, 700), // #1
            };

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(points, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

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

            Assert.AreEqual(1, edges.Count);

            Assert.IsTrue(CommonTestUtilities.AnyEdgeBetween(edges, 0, 1000, 1000, 0)); // A-B

            Assert.IsTrue(CommonTestUtilities.SiteHasEdge(points[1], 0, 1000, 1000, 0)); // #1 has A-B
            Assert.IsTrue(CommonTestUtilities.SiteHasEdge(points[0], 0, 1000, 1000, 0)); // #2 has A-B
        }

        [Test]
        public void TwoDiagonalPointsOffsetFromMiddle()
        {
            List<VoronoiSite> points = new List<VoronoiSite>
            {
                new VoronoiSite(600, 400), // #2
                new VoronoiSite(200, 800), // #1
            };

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(points, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

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

            Assert.AreEqual(1, edges.Count);

            Assert.IsTrue(CommonTestUtilities.AnyEdgeBetween(edges, 0, 200, 800, 1000)); // A-B

            Assert.IsTrue(CommonTestUtilities.SiteHasEdge(points[1], 0, 200, 800, 1000)); // #1 has A-B
            Assert.IsTrue(CommonTestUtilities.SiteHasEdge(points[0], 0, 200, 800, 1000)); // #2 has A-B
        }

        [Test]
        public void TwoDiagonalPointsOffsetFromMiddle_Rotated90()
        {
            List<VoronoiSite> points = new List<VoronoiSite>
            {
                new VoronoiSite(400, 400), // #2
                new VoronoiSite(800, 800), // #1
            };

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(points, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

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

            Assert.AreEqual(1, edges.Count);

            Assert.IsTrue(CommonTestUtilities.AnyEdgeBetween(edges, 200, 1000, 1000, 200)); // A-B

            Assert.IsTrue(CommonTestUtilities.SiteHasEdge(points[1], 200, 1000, 1000, 200)); // #1 has A-B
            Assert.IsTrue(CommonTestUtilities.SiteHasEdge(points[0], 200, 1000, 1000, 200)); // #2 has A-B
        }

        [Test]
        public void TwoDiagonalPointsOffsetFromMiddle_Rotated180()
        {
            List<VoronoiSite> points = new List<VoronoiSite>
            {
                new VoronoiSite(400, 600), // #2
                new VoronoiSite(800, 200), // #1
            };

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(points, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

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

            Assert.AreEqual(1, edges.Count);

            Assert.IsTrue(CommonTestUtilities.AnyEdgeBetween(edges, 1000, 800, 200, 0)); // A-B

            Assert.IsTrue(CommonTestUtilities.SiteHasEdge(points[1], 1000, 800, 200, 0)); // #1 has A-B
            Assert.IsTrue(CommonTestUtilities.SiteHasEdge(points[0], 1000, 800, 200, 0)); // #2 has A-B
        }

        [Test]
        public void TwoDiagonalPointsOffsetFromMiddle_Rotated270()
        {
            List<VoronoiSite> points = new List<VoronoiSite>
            {
                new VoronoiSite(600, 600), // #2
                new VoronoiSite(200, 200), // #1
            };

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(points, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

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

            Assert.AreEqual(1, edges.Count);

            Assert.IsTrue(CommonTestUtilities.AnyEdgeBetween(edges, 800, 0, 0, 800)); // A-B

            Assert.IsTrue(CommonTestUtilities.SiteHasEdge(points[1], 800, 0, 0, 800)); // #1 has A-B
            Assert.IsTrue(CommonTestUtilities.SiteHasEdge(points[0], 800, 0, 0, 800)); // #2 has A-B
        }

    }
}
