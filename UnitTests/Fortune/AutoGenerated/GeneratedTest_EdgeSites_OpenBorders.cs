using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using VoronoiLib;
using VoronoiLib.Structures;
using static UnitTests.CommonTestUtilities;

namespace UnitTests
{
    /// <summary>
    /// These tests assert that <see cref="VoronoiEdge"/>`s have expected <see cref="VoronoiSite"/>`s.
    /// Specifically, that the <see cref="VoronoiEdge.Left"/> and <see cref="VoronoiEdge.Right"/> are the expected sites.
    /// </summary>
    /// <remarks>
    /// This is an AUTO-GENERATED test fixture class from UnitTestGenerator.
    /// This is one of the several auto-generated fixture classes each checking a different part of the algorithm's result.
    /// It contains a bunch of known Voronoi site layouts, including many edge cases.
    /// </remarks>
    [Parallelizable(ParallelScope.All)]
    [TestFixture]
    public class GeneratedTest_EdgeSites_OpenBorders
    {
        [Test]
        public void OnePointInMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 500), // #1
            };

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

            // Act

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assert

        }

        [Test]
        public void TwoPointsVerticalAroundMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 700), // #1
                new VoronoiSite(500, 300), // #2
            };

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

            // Act

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assert

            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 500, 1000, 500), 500, 700)); // A-B has #1
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 500, 1000, 500), 500, 300)); // A-B has #2
        }

        /// <summary>
        /// This test basically repeats <see cref="TwoPointsVerticalAroundMiddle"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void TwoPointsHorizontalAroundMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(700, 500), // #1
                new VoronoiSite(300, 500), // #2
            };

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

            // Act

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assert

            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 1000, 500, 0), 700, 500)); // A-B has #1
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 1000, 500, 0), 300, 500)); // A-B has #2
        }

        [Test]
        public void TwoPointsVerticalOffsetFromMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 900), // #1
                new VoronoiSite(500, 500), // #2
            };

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

            // Act

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assert

            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 700, 1000, 700), 500, 900)); // A-B has #1
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 700, 1000, 700), 500, 500)); // A-B has #2
        }

        /// <summary>
        /// This test basically repeats <see cref="TwoPointsVerticalOffsetFromMiddle"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void TwoPointsHorizontalOffsetFromMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(900, 500), // #1
                new VoronoiSite(500, 500), // #2
            };

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

            // Act

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assert

            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 1000, 700, 0), 900, 500)); // A-B has #1
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 1000, 700, 0), 500, 500)); // A-B has #2
        }

        [Test]
        public void ThreeConcentricPointsVerticalAroundMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 900), // #1
                new VoronoiSite(500, 500), // #2
                new VoronoiSite(500, 100), // #3
            };

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

            // Act

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assert

            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 700, 1000, 700), 500, 900)); // A-B has #1
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 700, 1000, 700), 500, 500)); // A-B has #2
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 300, 1000, 300), 500, 500)); // C-D has #2
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 300, 1000, 300), 500, 100)); // C-D has #3
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreeConcentricPointsVerticalAroundMiddle"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreeConcentricPointsHorizontalAroundMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(900, 500), // #1
                new VoronoiSite(500, 500), // #2
                new VoronoiSite(100, 500), // #3
            };

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

            // Act

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assert

            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 1000, 700, 0), 900, 500)); // A-B has #1
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 1000, 700, 0), 500, 500)); // A-B has #2
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 1000, 300, 0), 500, 500)); // C-D has #2
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 1000, 300, 0), 100, 500)); // C-D has #3
        }

        [Test]
        public void FourConcentricPointsVerticalAroundMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 800), // #1
                new VoronoiSite(500, 600), // #2
                new VoronoiSite(500, 400), // #3
                new VoronoiSite(500, 200), // #4
            };

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 |                        1                         
            //      |                                                  
            //  700 A-------------------------------------------------B
            //      |                                                  
            //  600 |                        2                         
            //      |                                                  
            //  500 C-------------------------------------------------D
            //      |                                                  
            //  400 |                        3                         
            //      |                                                  
            //  300 E-------------------------------------------------F
            //      |                                                  
            //  200 |                        4                         
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assert

            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 700, 1000, 700), 500, 800)); // A-B has #1
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 700, 1000, 700), 500, 600)); // A-B has #2
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 500, 1000, 500), 500, 600)); // C-D has #2
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 500, 1000, 500), 500, 400)); // C-D has #3
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 300, 1000, 300), 500, 400)); // E-F has #3
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 300, 1000, 300), 500, 200)); // E-F has #4
        }

        /// <summary>
        /// This test basically repeats <see cref="FourConcentricPointsVerticalAroundMiddle"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void FourConcentricPointsHorizontalAroundMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(800, 500), // #1
                new VoronoiSite(600, 500), // #2
                new VoronoiSite(400, 500), // #3
                new VoronoiSite(200, 500), // #4
            };

            // 1000 ↑              E         C         A               
            //      |              |         |         |               
            //  900 |              |         |         |               
            //      |              |         |         |               
            //  800 |              |         |         |               
            //      |              |         |         |               
            //  700 |              |         |         |               
            //      |              |         |         |               
            //  600 |              |         |         |               
            //      |              |         |         |               
            //  500 |         4    |    3    |    2    |    1          
            //      |              |         |         |               
            //  400 |              |         |         |               
            //      |              |         |         |               
            //  300 |              |         |         |               
            //      |              |         |         |               
            //  200 |              |         |         |               
            //      |              |         |         |               
            //  100 |              |         |         |               
            //      |              |         |         |               
            //    0 └--------------F---------D---------B--------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assert

            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 1000, 700, 0), 800, 500)); // A-B has #1
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 1000, 700, 0), 600, 500)); // A-B has #2
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 1000, 500, 0), 600, 500)); // C-D has #2
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 1000, 500, 0), 400, 500)); // C-D has #3
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 1000, 300, 0), 400, 500)); // E-F has #3
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 1000, 300, 0), 200, 500)); // E-F has #4
        }

        [Test]
        public void TwoDiagonalPointsAroundMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(300, 700), // #1
                new VoronoiSite(700, 300), // #2
            };

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

            // Act

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assert

            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 1000), 300, 700)); // A-B has #1
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 1000), 700, 300)); // A-B has #2
        }

        /// <summary>
        /// This test basically repeats <see cref="TwoDiagonalPointsAroundMiddle"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void TwoDiagonalPointsAroundMiddle_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(700, 700), // #1
                new VoronoiSite(300, 300), // #2
            };

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

            // Act

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assert

            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 1000, 0), 700, 700)); // A-B has #1
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 1000, 0), 300, 300)); // A-B has #2
        }

        [Test]
        public void TwoDiagonalPointsOffsetFromMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(200, 800), // #1
                new VoronoiSite(600, 400), // #2
            };

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

            // Act

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assert

            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 200, 800, 1000), 200, 800)); // A-B has #1
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 200, 800, 1000), 600, 400)); // A-B has #2
        }

        /// <summary>
        /// This test basically repeats <see cref="TwoDiagonalPointsOffsetFromMiddle"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void TwoDiagonalPointsOffsetFromMiddle_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(800, 800), // #1
                new VoronoiSite(400, 400), // #2
            };

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

            // Act

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assert

            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 200, 1000, 1000, 200), 800, 800)); // A-B has #1
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 200, 1000, 1000, 200), 400, 400)); // A-B has #2
        }

        /// <summary>
        /// This test basically repeats <see cref="TwoDiagonalPointsOffsetFromMiddle"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void TwoDiagonalPointsOffsetFromMiddle_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(800, 200), // #1
                new VoronoiSite(400, 600), // #2
            };

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

            // Act

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assert

            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 800, 200, 0), 800, 200)); // A-B has #1
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 800, 200, 0), 400, 600)); // A-B has #2
        }

        /// <summary>
        /// This test basically repeats <see cref="TwoDiagonalPointsOffsetFromMiddle"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void TwoDiagonalPointsOffsetFromMiddle_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(200, 200), // #1
                new VoronoiSite(600, 600), // #2
            };

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

            // Act

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assert

            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 800, 0, 0, 800), 200, 200)); // A-B has #1
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 800, 0, 0, 800), 600, 600)); // A-B has #2
        }

        [Test]
        public void ThreeConcentricPointsDiagonalAroundMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(200, 800), // #1
                new VoronoiSite(500, 500), // #2
                new VoronoiSite(800, 200), // #3
            };

            // 1000 ↑                                 ,D               
            //      |                               ,'                 
            //  900 |                            ,·'                   
            //      |                          ,'                      
            //  800 |         1             ,·'                        
            //      |                     ,'                           
            //  700 |                  ,·'                           ,C
            //      |                ,'                            ,'  
            //  600 |             ,·'                           ,·'    
            //      |           ,'                            ,'       
            //  500 |        ,·'             2             ,·'         
            //      |      ,'                            ,'            
            //  400 |   ,·'                           ,·'              
            //      | ,'                            ,'                 
            //  300 A'                           ,·'                   
            //      |                          ,'                      
            //  200 |                       ,·'             3          
            //      |                     ,'                           
            //  100 |                  ,·'                             
            //      |                ,'                                
            //    0 └--------------B'---------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assert

            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 300, 700, 1000), 200, 800)); // A-D has #1
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 300, 700, 1000), 500, 500)); // A-D has #2
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 0, 1000, 700), 500, 500)); // B-C has #2
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 0, 1000, 700), 800, 200)); // B-C has #3
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreeConcentricPointsDiagonalAroundMiddle"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreeConcentricPointsDiagonalAroundMiddle_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(800, 800), // #1
                new VoronoiSite(500, 500), // #2
                new VoronoiSite(200, 200), // #3
            };

            // 1000 ↑              A,                                  
            //      |                ',                                
            //  900 |                  '·,                             
            //      |                     ',                           
            //  800 |                       '·,             1          
            //      |                          ',                      
            //  700 B,                           '·,                   
            //      | ',                            ',                 
            //  600 |   '·,                           '·,              
            //      |      ',                            ',            
            //  500 |        '·,             2             '·,         
            //      |           ',                            ',       
            //  400 |             '·,                           '·,    
            //      |                ',                            ',  
            //  300 |                  '·,                           'D
            //      |                     ',                           
            //  200 |         3             '·,                        
            //      |                          ',                      
            //  100 |                            '·,                   
            //      |                               ',                 
            //    0 └---------------------------------'C--------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assert

            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 1000, 1000, 300), 800, 800)); // A-D has #1
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 1000, 1000, 300), 500, 500)); // A-D has #2
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 700, 700, 0), 500, 500)); // B-C has #2
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 700, 700, 0), 200, 200)); // B-C has #3
        }

        [Test]
        public void ThreeConcentricPointsDiagonalOffsetFromMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(200, 800), // #1
                new VoronoiSite(400, 600), // #2
                new VoronoiSite(600, 400), // #3
            };

            // 1000 ↑                            ,D                  ,C
            //      |                          ,'                  ,'  
            //  900 |                       ,·'                 ,·'    
            //      |                     ,'                  ,'       
            //  800 |         1        ,·'                 ,·'         
            //      |                ,'                  ,'            
            //  700 |             ,·'                 ,·'              
            //      |           ,'                  ,'                 
            //  600 |        ,·'        2        ,·'                   
            //      |      ,'                  ,'                      
            //  500 |   ,·'                 ,·'                        
            //      | ,'                  ,'                           
            //  400 A'                 ,·'        3                    
            //      |                ,'                                
            //  300 |             ,·'                                  
            //      |           ,'                                     
            //  200 |        ,·'                                       
            //      |      ,'                                          
            //  100 |   ,·'                                            
            //      | ,'                                               
            //    0 B'------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assert

            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 400, 600, 1000), 200, 800)); // A-D has #1
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 400, 600, 1000), 400, 600)); // A-D has #2
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 1000), 400, 600)); // B-C has #2
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 1000), 600, 400)); // B-C has #3
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreeConcentricPointsDiagonalOffsetFromMiddle"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreeConcentricPointsDiagonalOffsetFromMiddle_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(800, 800), // #1
                new VoronoiSite(600, 600), // #2
                new VoronoiSite(400, 400), // #3
            };

            // 1000 B,                  A,                             
            //      | ',                  ',                           
            //  900 |   '·,                 '·,                        
            //      |      ',                  ',                      
            //  800 |        '·,                 '·,        1          
            //      |           ',                  ',                 
            //  700 |             '·,                 '·,              
            //      |                ',                  ',            
            //  600 |                  '·,        2        '·,         
            //      |                     ',                  ',       
            //  500 |                       '·,                 '·,    
            //      |                          ',                  ',  
            //  400 |                   3        '·,                 'D
            //      |                               ',                 
            //  300 |                                 '·,              
            //      |                                    ',            
            //  200 |                                      '·,         
            //      |                                         ',       
            //  100 |                                           '·,    
            //      |                                              ',  
            //    0 └------------------------------------------------'C
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assert

            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 1000, 1000, 400), 800, 800)); // A-D has #1
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 1000, 1000, 400), 600, 600)); // A-D has #2
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 1000, 0), 600, 600)); // B-C has #2
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 1000, 0), 400, 400)); // B-C has #3
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreeConcentricPointsDiagonalOffsetFromMiddle"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreeConcentricPointsDiagonalOffsetFromMiddle_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(800, 200), // #1
                new VoronoiSite(600, 400), // #2
                new VoronoiSite(400, 600), // #3
            };

            // 1000 ↑                                                ,B
            //      |                                              ,'  
            //  900 |                                           ,·'    
            //      |                                         ,'       
            //  800 |                                      ,·'         
            //      |                                    ,'            
            //  700 |                                 ,·'              
            //      |                               ,'                 
            //  600 |                   3        ,·'                 ,A
            //      |                          ,'                  ,'  
            //  500 |                       ,·'                 ,·'    
            //      |                     ,'                  ,'       
            //  400 |                  ,·'        2        ,·'         
            //      |                ,'                  ,'            
            //  300 |             ,·'                 ,·'              
            //      |           ,'                  ,'                 
            //  200 |        ,·'                 ,·'        1          
            //      |      ,'                  ,'                      
            //  100 |   ,·'                 ,·'                        
            //      | ,'                  ,'                           
            //    0 C'------------------D'----------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assert

            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 600, 400, 0), 800, 200)); // A-D has #1
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 600, 400, 0), 600, 400)); // A-D has #2
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 0, 0), 600, 400)); // B-C has #2
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 0, 0), 400, 600)); // B-C has #3
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreeConcentricPointsDiagonalOffsetFromMiddle"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreeConcentricPointsDiagonalOffsetFromMiddle_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(200, 200), // #1
                new VoronoiSite(400, 400), // #2
                new VoronoiSite(600, 600), // #3
            };

            // 1000 C,                                                 
            //      | ',                                               
            //  900 |   '·,                                            
            //      |      ',                                          
            //  800 |        '·,                                       
            //      |           ',                                     
            //  700 |             '·,                                  
            //      |                ',                                
            //  600 D,                 '·,        3                    
            //      | ',                  ',                           
            //  500 |   '·,                 '·,                        
            //      |      ',                  ',                      
            //  400 |        '·,        2        '·,                   
            //      |           ',                  ',                 
            //  300 |             '·,                 '·,              
            //      |                ',                  ',            
            //  200 |         1        '·,                 '·,         
            //      |                     ',                  ',       
            //  100 |                       '·,                 '·,    
            //      |                          ',                  ',  
            //    0 └----------------------------'A------------------'B
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assert

            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 0, 0, 600), 200, 200)); // A-D has #1
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 0, 0, 600), 400, 400)); // A-D has #2
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 0, 1000), 400, 400)); // B-C has #2
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 0, 1000), 600, 600)); // B-C has #3
        }

        [Test]
        public void FourConcentricPointsDiagonalAroundMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(200, 800), // #1
                new VoronoiSite(400, 600), // #2
                new VoronoiSite(600, 400), // #3
                new VoronoiSite(800, 200), // #4
            };

            // 1000 ↑                            ,F                  ,E
            //      |                          ,'                  ,'  
            //  900 |                       ,·'                 ,·'    
            //      |                     ,'                  ,'       
            //  800 |         1        ,·'                 ,·'         
            //      |                ,'                  ,'            
            //  700 |             ,·'                 ,·'              
            //      |           ,'                  ,'                 
            //  600 |        ,·'        2        ,·'                 ,D
            //      |      ,'                  ,'                  ,'  
            //  500 |   ,·'                 ,·'                 ,·'    
            //      | ,'                  ,'                  ,'       
            //  400 A'                 ,·'        3        ,·'         
            //      |                ,'                  ,'            
            //  300 |             ,·'                 ,·'              
            //      |           ,'                  ,'                 
            //  200 |        ,·'                 ,·'        4          
            //      |      ,'                  ,'                      
            //  100 |   ,·'                 ,·'                        
            //      | ,'                  ,'                           
            //    0 B'------------------C'----------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assert

            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 400, 600, 1000), 200, 800)); // A-F has #1
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 400, 600, 1000), 400, 600)); // A-F has #2
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 1000), 400, 600)); // B-E has #2
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 1000), 600, 400)); // B-E has #3
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 0, 1000, 600), 600, 400)); // C-D has #3
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 0, 1000, 600), 800, 200)); // C-D has #4
        }

        /// <summary>
        /// This test basically repeats <see cref="FourConcentricPointsDiagonalAroundMiddle"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void FourConcentricPointsDiagonalAroundMiddle_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(800, 800), // #1
                new VoronoiSite(600, 600), // #2
                new VoronoiSite(400, 400), // #3
                new VoronoiSite(200, 200), // #4
            };

            // 1000 B,                  A,                             
            //      | ',                  ',                           
            //  900 |   '·,                 '·,                        
            //      |      ',                  ',                      
            //  800 |        '·,                 '·,        1          
            //      |           ',                  ',                 
            //  700 |             '·,                 '·,              
            //      |                ',                  ',            
            //  600 C,                 '·,        2        '·,         
            //      | ',                  ',                  ',       
            //  500 |   '·,                 '·,                 '·,    
            //      |      ',                  ',                  ',  
            //  400 |        '·,        3        '·,                 'F
            //      |           ',                  ',                 
            //  300 |             '·,                 '·,              
            //      |                ',                  ',            
            //  200 |         4        '·,                 '·,         
            //      |                     ',                  ',       
            //  100 |                       '·,                 '·,    
            //      |                          ',                  ',  
            //    0 └----------------------------'D------------------'E
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assert

            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 1000, 1000, 400), 800, 800)); // A-F has #1
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 1000, 1000, 400), 600, 600)); // A-F has #2
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 1000, 0), 600, 600)); // B-E has #2
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 1000, 0), 400, 400)); // B-E has #3
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 600, 600, 0), 400, 400)); // C-D has #3
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 600, 600, 0), 200, 200)); // C-D has #4
        }

        [Test]
        public void ThreePointsInAWedgeTowardsCorner()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(300, 500), // #1
                new VoronoiSite(300, 300), // #2
                new VoronoiSite(500, 300), // #3
            };

            // 1000 ↑                                                ,D
            //      |                                              ,'  
            //  900 |                                           ,·'    
            //      |                                         ,'       
            //  800 |                                      ,·'         
            //      |                                    ,'            
            //  700 |                                 ,·'              
            //      |                               ,'                 
            //  600 |                            ,·'                   
            //      |                          ,'                      
            //  500 |              1        ,·'                        
            //      |                     ,'                           
            //  400 B-------------------A'                             
            //      |                   |                              
            //  300 |              2    |    3                         
            //      |                   |                              
            //  200 |                   |                              
            //      |                   |                              
            //  100 |                   |                              
            //      |                   |                              
            //    0 └-------------------C-----------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assert

            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 400, 0, 400), 300, 500)); // A-B has #1
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 400, 0, 400), 300, 300)); // A-B has #2
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 400, 400, 0), 300, 300)); // A-C has #2
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 400, 400, 0), 500, 300)); // A-C has #3
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 400, 1000, 1000), 300, 500)); // A-D has #1
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 400, 1000, 1000), 500, 300)); // A-D has #3
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeTowardsCorner"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeTowardsCorner_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 700), // #1
                new VoronoiSite(300, 700), // #2
                new VoronoiSite(300, 500), // #3
            };

            // 1000 ↑                   B                              
            //      |                   |                              
            //  900 |                   |                              
            //      |                   |                              
            //  800 |                   |                              
            //      |                   |                              
            //  700 |              2    |    1                         
            //      |                   |                              
            //  600 C-------------------A,                             
            //      |                     ',                           
            //  500 |              3        '·,                        
            //      |                          ',                      
            //  400 |                            '·,                   
            //      |                               ',                 
            //  300 |                                 '·,              
            //      |                                    ',            
            //  200 |                                      '·,         
            //      |                                         ',       
            //  100 |                                           '·,    
            //      |                                              ',  
            //    0 └------------------------------------------------'D
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assert

            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 600, 400, 1000), 500, 700)); // A-B has #1
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 600, 400, 1000), 300, 700)); // A-B has #2
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 600, 0, 600), 300, 700)); // A-C has #2
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 600, 0, 600), 300, 500)); // A-C has #3
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 600, 1000, 0), 500, 700)); // A-D has #1
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 600, 1000, 0), 300, 500)); // A-D has #3
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeTowardsCorner"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeTowardsCorner_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(700, 500), // #1
                new VoronoiSite(700, 700), // #2
                new VoronoiSite(500, 700), // #3
            };

            // 1000 ↑                             C                    
            //      |                             |                    
            //  900 |                             |                    
            //      |                             |                    
            //  800 |                             |                    
            //      |                             |                    
            //  700 |                        3    |    2               
            //      |                             |                    
            //  600 |                            ,A-------------------B
            //      |                          ,'                      
            //  500 |                       ,·'        1               
            //      |                     ,'                           
            //  400 |                  ,·'                             
            //      |                ,'                                
            //  300 |             ,·'                                  
            //      |           ,'                                     
            //  200 |        ,·'                                       
            //      |      ,'                                          
            //  100 |   ,·'                                            
            //      | ,'                                               
            //    0 D'------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assert

            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 600, 1000, 600), 700, 500)); // A-B has #1
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 600, 1000, 600), 700, 700)); // A-B has #2
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 600, 600, 1000), 700, 700)); // A-C has #2
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 600, 600, 1000), 500, 700)); // A-C has #3
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 600, 0, 0), 700, 500)); // A-D has #1
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 600, 0, 0), 500, 700)); // A-D has #3
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeTowardsCorner"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeTowardsCorner_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 300), // #1
                new VoronoiSite(700, 300), // #2
                new VoronoiSite(700, 500), // #3
            };

            // 1000 D,                                                 
            //      | ',                                               
            //  900 |   '·,                                            
            //      |      ',                                          
            //  800 |        '·,                                       
            //      |           ',                                     
            //  700 |             '·,                                  
            //      |                ',                                
            //  600 |                  '·,                             
            //      |                     ',                           
            //  500 |                       '·,        3               
            //      |                          ',                      
            //  400 |                            'A-------------------C
            //      |                             |                    
            //  300 |                        1    |    2               
            //      |                             |                    
            //  200 |                             |                    
            //      |                             |                    
            //  100 |                             |                    
            //      |                             |                    
            //    0 └-----------------------------B-------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assert

            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 400, 600, 0), 500, 300)); // A-B has #1
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 400, 600, 0), 700, 300)); // A-B has #2
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 400, 1000, 400), 700, 300)); // A-C has #2
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 400, 1000, 400), 700, 500)); // A-C has #3
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 400, 0, 1000), 500, 300)); // A-D has #1
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 400, 0, 1000), 700, 500)); // A-D has #3
        }

        [Test]
        public void ThreePointsInAWedgeAroundMiddleTowardsSide()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 300), // #1
                new VoronoiSite(700, 500), // #2
                new VoronoiSite(300, 500), // #3
            };

            // 1000 ↑                        D                         
            //      |                        |                         
            //  900 |                        |                         
            //      |                        |                         
            //  800 |                        |                         
            //      |                        |                         
            //  700 |                        |                         
            //      |                        |                         
            //  600 |                        |                         
            //      |                        |                         
            //  500 |              3        ,A,        2               
            //      |                     ,'   ',                      
            //  400 |                  ,·'       '·,                   
            //      |                ,'             ',                 
            //  300 |             ,·'        1        '·,              
            //      |           ,'                       ',            
            //  200 |        ,·'                           '·,         
            //      |      ,'                                 ',       
            //  100 |   ,·'                                     '·,    
            //      | ,'                                           ',  
            //    0 B'-----------------------------------------------'C
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assert

            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 0, 0), 500, 300)); // A-B has #1
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 0, 0), 300, 500)); // A-B has #3
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 1000, 0), 500, 300)); // A-C has #1
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 1000, 0), 700, 500)); // A-C has #2
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 500, 1000), 700, 500)); // A-D has #2
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 500, 1000), 300, 500)); // A-D has #3
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeAroundMiddleTowardsSide"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeAroundMiddleTowardsSide_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(300, 500), // #1
                new VoronoiSite(500, 300), // #2
                new VoronoiSite(500, 700), // #3
            };

            // 1000 B,                                                 
            //      | ',                                               
            //  900 |   '·,                                            
            //      |      ',                                          
            //  800 |        '·,                                       
            //      |           ',                                     
            //  700 |             '·,        3                         
            //      |                ',                                
            //  600 |                  '·,                             
            //      |                     ',                           
            //  500 |              1        ⁕A------------------------D
            //      |                     ,'                           
            //  400 |                  ,·'                             
            //      |                ,'                                
            //  300 |             ,·'        2                         
            //      |           ,'                                     
            //  200 |        ,·'                                       
            //      |      ,'                                          
            //  100 |   ,·'                                            
            //      | ,'                                               
            //    0 C'------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assert

            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 0, 1000), 300, 500)); // A-B has #1
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 0, 1000), 500, 700)); // A-B has #3
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 0, 0), 300, 500)); // A-C has #1
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 0, 0), 500, 300)); // A-C has #2
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 1000, 500), 500, 300)); // A-D has #2
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 1000, 500), 500, 700)); // A-D has #3
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeAroundMiddleTowardsSide"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeAroundMiddleTowardsSide_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 700), // #1
                new VoronoiSite(300, 500), // #2
                new VoronoiSite(700, 500), // #3
            };

            // 1000 C,                                               ,B
            //      | ',                                           ,'  
            //  900 |   '·,                                     ,·'    
            //      |      ',                                 ,'       
            //  800 |        '·,                           ,·'         
            //      |           ',                       ,'            
            //  700 |             '·,        1        ,·'              
            //      |                ',             ,'                 
            //  600 |                  '·,       ,·'                   
            //      |                     ',   ,'                      
            //  500 |              2        'A'        3               
            //      |                        |                         
            //  400 |                        |                         
            //      |                        |                         
            //  300 |                        |                         
            //      |                        |                         
            //  200 |                        |                         
            //      |                        |                         
            //  100 |                        |                         
            //      |                        |                         
            //    0 └------------------------D------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assert

            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 1000, 1000), 500, 700)); // A-B has #1
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 1000, 1000), 700, 500)); // A-B has #3
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 0, 1000), 500, 700)); // A-C has #1
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 0, 1000), 300, 500)); // A-C has #2
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 500, 0), 300, 500)); // A-D has #2
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 500, 0), 700, 500)); // A-D has #3
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeAroundMiddleTowardsSide"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeAroundMiddleTowardsSide_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(700, 500), // #1
                new VoronoiSite(500, 700), // #2
                new VoronoiSite(500, 300), // #3
            };

            // 1000 ↑                                                ,C
            //      |                                              ,'  
            //  900 |                                           ,·'    
            //      |                                         ,'       
            //  800 |                                      ,·'         
            //      |                                    ,'            
            //  700 |                        2        ,·'              
            //      |                               ,'                 
            //  600 |                            ,·'                   
            //      |                          ,'                      
            //  500 D------------------------A⁕        1               
            //      |                          ',                      
            //  400 |                            '·,                   
            //      |                               ',                 
            //  300 |                        3        '·,              
            //      |                                    ',            
            //  200 |                                      '·,         
            //      |                                         ',       
            //  100 |                                           '·,    
            //      |                                              ',  
            //    0 └------------------------------------------------'B
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assert

            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 1000, 0), 700, 500)); // A-B has #1
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 1000, 0), 500, 300)); // A-B has #3
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 1000, 1000), 700, 500)); // A-C has #1
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 1000, 1000), 500, 700)); // A-C has #2
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 0, 500), 500, 700)); // A-D has #2
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 0, 500), 500, 300)); // A-D has #3
        }

        [Test]
        public void ThreePointsInAWedgeOffsetFromMiddleTowardsSide()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 100), // #1
                new VoronoiSite(700, 300), // #2
                new VoronoiSite(300, 300), // #3
            };

            // 1000 ↑                        D                         
            //      |                        |                         
            //  900 |                        |                         
            //      |                        |                         
            //  800 |                        |                         
            //      |                        |                         
            //  700 |                        |                         
            //      |                        |                         
            //  600 |                        |                         
            //      |                        |                         
            //  500 |                        |                         
            //      |                        |                         
            //  400 |                        |                         
            //      |                        |                         
            //  300 |              3        ,A,        2               
            //      |                     ,'   ',                      
            //  200 |                  ,·'       '·,                   
            //      |                ,'             ',                 
            //  100 |             ,·'        1        '·,              
            //      |           ,'                       ',            
            //    0 └---------B'---------------------------'C---------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assert

            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 300, 200, 0), 500, 100)); // A-B has #1
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 300, 200, 0), 300, 300)); // A-B has #3
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 300, 800, 0), 500, 100)); // A-C has #1
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 300, 800, 0), 700, 300)); // A-C has #2
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 300, 500, 1000), 700, 300)); // A-D has #2
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 300, 500, 1000), 300, 300)); // A-D has #3
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeOffsetFromMiddleTowardsSide"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeOffsetFromMiddleTowardsSide_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(100, 500), // #1
                new VoronoiSite(300, 300), // #2
                new VoronoiSite(300, 700), // #3
            };

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 B,                                                 
            //      | ',                                               
            //  700 |   '·,        3                                   
            //      |      ',                                          
            //  600 |        '·,                                       
            //      |           ',                                     
            //  500 |    1        ⁕A----------------------------------D
            //      |           ,'                                     
            //  400 |        ,·'                                       
            //      |      ,'                                          
            //  300 |   ,·'        2                                   
            //      | ,'                                               
            //  200 C'                                                 
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assert

            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 500, 0, 800), 100, 500)); // A-B has #1
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 500, 0, 800), 300, 700)); // A-B has #3
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 500, 0, 200), 100, 500)); // A-C has #1
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 500, 0, 200), 300, 300)); // A-C has #2
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 500, 1000, 500), 300, 300)); // A-D has #2
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 500, 1000, 500), 300, 700)); // A-D has #3
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeOffsetFromMiddleTowardsSide"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeOffsetFromMiddleTowardsSide_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 900), // #1
                new VoronoiSite(300, 700), // #2
                new VoronoiSite(700, 700), // #3
            };

            // 1000 ↑         C,                           ,B          
            //      |           ',                       ,'            
            //  900 |             '·,        1        ,·'              
            //      |                ',             ,'                 
            //  800 |                  '·,       ,·'                   
            //      |                     ',   ,'                      
            //  700 |              2        'A'        3               
            //      |                        |                         
            //  600 |                        |                         
            //      |                        |                         
            //  500 |                        |                         
            //      |                        |                         
            //  400 |                        |                         
            //      |                        |                         
            //  300 |                        |                         
            //      |                        |                         
            //  200 |                        |                         
            //      |                        |                         
            //  100 |                        |                         
            //      |                        |                         
            //    0 └------------------------D------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assert

            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 700, 800, 1000), 500, 900)); // A-B has #1
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 700, 800, 1000), 700, 700)); // A-B has #3
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 700, 200, 1000), 500, 900)); // A-C has #1
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 700, 200, 1000), 300, 700)); // A-C has #2
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 700, 500, 0), 300, 700)); // A-D has #2
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 700, 500, 0), 700, 700)); // A-D has #3
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeOffsetFromMiddleTowardsSide"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeOffsetFromMiddleTowardsSide_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(900, 500), // #1
                new VoronoiSite(700, 700), // #2
                new VoronoiSite(700, 300), // #3
            };

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 |                                                ,C
            //      |                                              ,'  
            //  700 |                                  2        ,·'    
            //      |                                         ,'       
            //  600 |                                      ,·'         
            //      |                                    ,'            
            //  500 D----------------------------------A⁕        1     
            //      |                                    ',            
            //  400 |                                      '·,         
            //      |                                         ',       
            //  300 |                                  3        '·,    
            //      |                                              ',  
            //  200 |                                                'B
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assert

            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 500, 1000, 200), 900, 500)); // A-B has #1
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 500, 1000, 200), 700, 300)); // A-B has #3
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 500, 1000, 800), 900, 500)); // A-C has #1
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 500, 1000, 800), 700, 700)); // A-C has #2
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 500, 0, 500), 700, 700)); // A-D has #2
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 500, 0, 500), 700, 300)); // A-D has #3
        }

        [Test]
        public void FourPointsSurroundingAPointInMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 500), // #1
                new VoronoiSite(300, 500), // #2
                new VoronoiSite(500, 300), // #3
                new VoronoiSite(700, 500), // #4
                new VoronoiSite(500, 700), // #5
            };

            // 1000 E,                                               ,H
            //      | ',                                           ,'  
            //  900 |   '·,                                     ,·'    
            //      |      ',                                 ,'       
            //  800 |        '·,                           ,·'         
            //      |           ',                       ,'            
            //  700 |             '·,        5        ,·'              
            //      |                ',             ,'                 
            //  600 |                  'A---------D'                   
            //      |                   |         |                    
            //  500 |              2    |    1    |    4               
            //      |                   |         |                    
            //  400 |                  ,B---------C,                   
            //      |                ,'             ',                 
            //  300 |             ,·'        3        '·,              
            //      |           ,'                       ',            
            //  200 |        ,·'                           '·,         
            //      |      ,'                                 ',       
            //  100 |   ,·'                                     '·,    
            //      | ,'                                           ',  
            //    0 F'-----------------------------------------------'G
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assert

            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 600, 400, 400), 500, 500)); // A-B has #1
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 600, 400, 400), 300, 500)); // A-B has #2
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 400, 600, 400), 500, 500)); // B-C has #1
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 400, 600, 400), 500, 300)); // B-C has #3
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 400, 600, 600), 500, 500)); // C-D has #1
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 400, 600, 600), 700, 500)); // C-D has #4
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 600, 400, 600), 500, 500)); // D-A has #1
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 600, 400, 600), 500, 700)); // D-A has #5
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 600, 0, 1000), 300, 500)); // A-E has #2
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 600, 0, 1000), 500, 700)); // A-E has #5
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 400, 0, 0), 300, 500)); // B-F has #2
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 400, 0, 0), 500, 300)); // B-F has #3
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 400, 1000, 0), 500, 300)); // C-G has #3
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 400, 1000, 0), 700, 500)); // C-G has #4
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 600, 1000, 1000), 700, 500)); // D-H has #4
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 600, 1000, 1000), 500, 700)); // D-H has #5
        }

        [Test]
        public void FourPointsSurroundingAPointOffsetFromMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 300), // #1
                new VoronoiSite(300, 300), // #2
                new VoronoiSite(500, 100), // #3
                new VoronoiSite(700, 300), // #4
                new VoronoiSite(500, 500), // #5
            };

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 E,                                               ,H
            //      | ',                                           ,'  
            //  700 |   '·,                                     ,·'    
            //      |      ',                                 ,'       
            //  600 |        '·,                           ,·'         
            //      |           ',                       ,'            
            //  500 |             '·,        5        ,·'              
            //      |                ',             ,'                 
            //  400 |                  'A---------D'                   
            //      |                   |         |                    
            //  300 |              2    |    1    |    4               
            //      |                   |         |                    
            //  200 |                  ,B---------C,                   
            //      |                ,'             ',                 
            //  100 |             ,·'        3        '·,              
            //      |           ,'                       ',            
            //    0 └---------F'---------------------------'G---------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assert

            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 400, 400, 200), 500, 300)); // A-B has #1
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 400, 400, 200), 300, 300)); // A-B has #2
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 200, 600, 200), 500, 300)); // B-C has #1
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 200, 600, 200), 500, 100)); // B-C has #3
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 200, 600, 400), 500, 300)); // C-D has #1
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 200, 600, 400), 700, 300)); // C-D has #4
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 400, 400, 400), 500, 300)); // D-A has #1
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 400, 400, 400), 500, 500)); // D-A has #5
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 400, 0, 800), 300, 300)); // A-E has #2
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 400, 0, 800), 500, 500)); // A-E has #5
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 200, 200, 0), 300, 300)); // B-F has #2
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 200, 200, 0), 500, 100)); // B-F has #3
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 200, 800, 0), 500, 100)); // C-G has #3
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 200, 800, 0), 700, 300)); // C-G has #4
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 400, 1000, 800), 700, 300)); // D-H has #4
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 400, 1000, 800), 500, 500)); // D-H has #5
        }

        /// <summary>
        /// This test basically repeats <see cref="FourPointsSurroundingAPointOffsetFromMiddle"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void FourPointsSurroundingAPointOffsetFromMiddle_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(300, 500), // #1
                new VoronoiSite(300, 700), // #2
                new VoronoiSite(100, 500), // #3
                new VoronoiSite(300, 300), // #4
                new VoronoiSite(500, 500), // #5
            };

            // 1000 ↑                                      ,E          
            //      |                                    ,'            
            //  900 |                                 ,·'              
            //      |                               ,'                 
            //  800 F,                           ,·'                   
            //      | ',                       ,'                      
            //  700 |   '·,        2        ,·'                        
            //      |      ',             ,'                           
            //  600 |        'B---------A'                             
            //      |         |         |                              
            //  500 |    3    |    1    |    5                         
            //      |         |         |                              
            //  400 |        ,C---------D,                             
            //      |      ,'             ',                           
            //  300 |   ,·'        4        '·,                        
            //      | ,'                       ',                      
            //  200 G'                           '·,                   
            //      |                               ',                 
            //  100 |                                 '·,              
            //      |                                    ',            
            //    0 └--------------------------------------'H---------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assert

            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 600, 200, 600), 300, 500)); // A-B has #1
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 600, 200, 600), 300, 700)); // A-B has #2
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 200, 600, 200, 400), 300, 500)); // B-C has #1
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 200, 600, 200, 400), 100, 500)); // B-C has #3
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 200, 400, 400, 400), 300, 500)); // C-D has #1
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 200, 400, 400, 400), 300, 300)); // C-D has #4
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 400, 400, 600), 300, 500)); // D-A has #1
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 400, 400, 600), 500, 500)); // D-A has #5
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 600, 800, 1000), 300, 700)); // A-E has #2
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 600, 800, 1000), 500, 500)); // A-E has #5
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 200, 600, 0, 800), 300, 700)); // B-F has #2
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 200, 600, 0, 800), 100, 500)); // B-F has #3
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 200, 400, 0, 200), 100, 500)); // C-G has #3
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 200, 400, 0, 200), 300, 300)); // C-G has #4
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 400, 800, 0), 300, 300)); // D-H has #4
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 400, 800, 0), 500, 500)); // D-H has #5
        }

        /// <summary>
        /// This test basically repeats <see cref="FourPointsSurroundingAPointOffsetFromMiddle"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void FourPointsSurroundingAPointOffsetFromMiddle_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 700), // #1
                new VoronoiSite(700, 700), // #2
                new VoronoiSite(500, 900), // #3
                new VoronoiSite(300, 700), // #4
                new VoronoiSite(500, 500), // #5
            };

            // 1000 ↑         G,                           ,F          
            //      |           ',                       ,'            
            //  900 |             '·,        3        ,·'              
            //      |                ',             ,'                 
            //  800 |                  'C---------B'                   
            //      |                   |         |                    
            //  700 |              4    |    1    |    2               
            //      |                   |         |                    
            //  600 |                  ,D---------A,                   
            //      |                ,'             ',                 
            //  500 |             ,·'        5        '·,              
            //      |           ,'                       ',            
            //  400 |        ,·'                           '·,         
            //      |      ,'                                 ',       
            //  300 |   ,·'                                     '·,    
            //      | ,'                                           ',  
            //  200 H'                                               'E
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assert

            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 600, 600, 800), 500, 700)); // A-B has #1
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 600, 600, 800), 700, 700)); // A-B has #2
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 800, 400, 800), 500, 700)); // B-C has #1
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 800, 400, 800), 500, 900)); // B-C has #3
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 800, 400, 600), 500, 700)); // C-D has #1
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 800, 400, 600), 300, 700)); // C-D has #4
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 600, 600, 600), 500, 700)); // D-A has #1
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 600, 600, 600), 500, 500)); // D-A has #5
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 600, 1000, 200), 700, 700)); // A-E has #2
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 600, 1000, 200), 500, 500)); // A-E has #5
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 800, 800, 1000), 700, 700)); // B-F has #2
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 800, 800, 1000), 500, 900)); // B-F has #3
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 800, 200, 1000), 500, 900)); // C-G has #3
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 800, 200, 1000), 300, 700)); // C-G has #4
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 600, 0, 200), 300, 700)); // D-H has #4
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 600, 0, 200), 500, 500)); // D-H has #5
        }

        /// <summary>
        /// This test basically repeats <see cref="FourPointsSurroundingAPointOffsetFromMiddle"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void FourPointsSurroundingAPointOffsetFromMiddle_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(700, 500), // #1
                new VoronoiSite(700, 300), // #2
                new VoronoiSite(900, 500), // #3
                new VoronoiSite(700, 700), // #4
                new VoronoiSite(500, 500), // #5
            };

            // 1000 ↑         H,                                       
            //      |           ',                                     
            //  900 |             '·,                                  
            //      |                ',                                
            //  800 |                  '·,                           ,G
            //      |                     ',                       ,'  
            //  700 |                       '·,        4        ,·'    
            //      |                          ',             ,'       
            //  600 |                            'D---------C'         
            //      |                             |         |          
            //  500 |                        5    |    1    |    3     
            //      |                             |         |          
            //  400 |                            ,A---------B,         
            //      |                          ,'             ',       
            //  300 |                       ,·'        2        '·,    
            //      |                     ,'                       ',  
            //  200 |                  ,·'                           'F
            //      |                ,'                                
            //  100 |             ,·'                                  
            //      |           ,'                                     
            //    0 └---------E'--------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assert

            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 400, 800, 400), 700, 500)); // A-B has #1
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 400, 800, 400), 700, 300)); // A-B has #2
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 800, 400, 800, 600), 700, 500)); // B-C has #1
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 800, 400, 800, 600), 900, 500)); // B-C has #3
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 800, 600, 600, 600), 700, 500)); // C-D has #1
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 800, 600, 600, 600), 700, 700)); // C-D has #4
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 600, 600, 400), 700, 500)); // D-A has #1
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 600, 600, 400), 500, 500)); // D-A has #5
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 400, 200, 0), 700, 300)); // A-E has #2
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 400, 200, 0), 500, 500)); // A-E has #5
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 800, 400, 1000, 200), 700, 300)); // B-F has #2
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 800, 400, 1000, 200), 900, 500)); // B-F has #3
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 800, 600, 1000, 800), 900, 500)); // C-G has #3
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 800, 600, 1000, 800), 700, 700)); // C-G has #4
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 600, 200, 1000), 700, 700)); // D-H has #4
            Assert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 600, 200, 1000), 500, 500)); // D-H has #5
        }

    }
}
