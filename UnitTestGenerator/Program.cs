using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using VoronoiLib.Structures;

namespace UnitTestGenerator
{
    public static class Program
    {
        public static void Main()
        {
            TestGenerator testGenerator = new TestGenerator(
                0, 0, 1000, 1000, 
                50, 100,
                20, 50
            );

            testGenerator.AddTest("OnePointInMiddle", @"
                · · · · · · · · · · · 10
                · · · · · · · · · · · 9
                · · · · · · · · · · · 8
                · · · · · · · · · · · 7
                · · · · · · · · · · · 6
                · · · · · 1 · · · · · 5
                · · · · · · · · · · · 4
                · · · · · · · · · · · 3
                · · · · · · · · · · · 2
                · · · · · · · · · · · 1
                · · · · · · · · · · · 0
                0 1 2 3 4 5 6 7 8 9 10
            ");
            
            testGenerator.AddTest("TwoPointsVerticalAroundMiddle", @"
                · · · · · · · · · · · 10
                · · · · · · · · · · · 9
                · · · · · · · · · · · 8
                · · · · · 1 · · · · · 7
                · · · · · · · · · · · 6
                A · · · · · · · · · B 5
                · · · · · · · · · · · 4
                · · · · · 2 · · · · · 3
                · · · · · · · · · · · 2
                · · · · · · · · · · · 1
                · · · · · · · · · · · 0
                0 1 2 3 4 5 6 7 8 9 10
                A-B: 1,2
            ", Repeat.Rotate90);
            
            testGenerator.AddTest("TwoPointsVerticalOffsetFromMiddle", @"
                · · · · · · · · · · · 10
                · · · · · 1 · · · · · 9
                · · · · · · · · · · · 8
                A · · · · · · · · · B 7
                · · · · · · · · · · · 6
                · · · · · 2 · · · · · 5
                · · · · · · · · · · · 4
                · · · · · · · · · · · 3
                · · · · · · · · · · · 2
                · · · · · · · · · · · 1
                · · · · · · · · · · · 0
                0 1 2 3 4 5 6 7 8 9 10
                A-B: 1,2
            ", Repeat.Rotate90);
            
            testGenerator.AddTest("ThreeConcentricPointsVerticalAroundMiddle", @"
                · · · · · · · · · · · 10
                · · · · · 1 · · · · · 9
                · · · · · · · · · · · 8
                A · · · · · · · · · B 7
                · · · · · · · · · · · 6
                · · · · · 2 · · · · · 5
                · · · · · · · · · · · 4
                C · · · · · · · · · D 3
                · · · · · · · · · · · 2
                · · · · · 3 · · · · · 1
                · · · · · · · · · · · 0
                0 1 2 3 4 5 6 7 8 9 10
                A-B: 1,2
                C-D: 2,3
            ", Repeat.Rotate90);
            
            testGenerator.AddTest("FourConcentricPointsVerticalAroundMiddle", @"
                · · · · · · · · · · · 10
                · · · · · · · · · · · 9
                · · · · · 1 · · · · · 8
                A · · · · · · · · · B 7
                · · · · · 2 · · · · · 6
                C · · · · · · · · · D 5
                · · · · · 3 · · · · · 4
                E · · · · · · · · · F 3
                · · · · · 4 · · · · · 2
                · · · · · · · · · · · 1
                · · · · · · · · · · · 0
                0 1 2 3 4 5 6 7 8 9 10
                A-B: 1,2
                C-D: 2,3
                E-F: 3,4
            ", Repeat.Rotate90);
            
            testGenerator.AddTest("TwoDiagonalPointsAroundMiddle", @"
                · · · · · · · · · · B 10
                · · · · · · · · · · · 9
                · · · · · · · · · · · 8
                · · · 1 · · · · · · · 7
                · · · · · · · · · · · 6
                · · · · · · · · · · · 5
                · · · · · · · · · · · 4
                · · · · · · · 2 · · · 3
                · · · · · · · · · · · 2
                · · · · · · · · · · · 1
                A · · · · · · · · · · 0
                0 1 2 3 4 5 6 7 8 9 10
                A-B: 1,2
            ", Repeat.Rotate90);
            
            testGenerator.AddTest("TwoDiagonalPointsOffsetFromMiddle", @"
                · · · · · · · · B · · 10
                · · · · · · · · · · · 9
                · · 1 · · · · · · · · 8
                · · · · · · · · · · · 7
                · · · · · · · · · · · 6
                · · · · · · · · · · · 5
                · · · · · · 2 · · · · 4
                · · · · · · · · · · · 3
                A · · · · · · · · · · 2
                · · · · · · · · · · · 1
                · · · · · · · · · · · 0
                0 1 2 3 4 5 6 7 8 9 10
                A-B: 1,2
            ", Repeat.RotateAll);
            
            testGenerator.AddTest("ThreeConcentricPointsDiagonalAroundMiddle", @"
                · · · · · · · D · · · 10
                · · · · · · · · · · · 9
                · · 1 · · · · · · · · 8
                · · · · · · · · · · C 7
                · · · · · · · · · · · 6
                · · · · · 2 · · · · · 5
                · · · · · · · · · · · 4
                A · · · · · · · · · · 3
                · · · · · · · · 3 · · 2
                · · · · · · · · · · · 1
                · · · B · · · · · · · 0
                0 1 2 3 4 5 6 7 8 9 10
                A-D: 1,2
                B-C: 2,3
            ", Repeat.Rotate90);
            
            testGenerator.AddTest("ThreeConcentricPointsDiagonalOffsetFromMiddle", @"
                · · · · · · D · · · C 10
                · · · · · · · · · · · 9
                · · 1 · · · · · · · · 8
                · · · · · · · · · · · 7
                · · · · 2 · · · · · · 6
                · · · · · · · · · · · 5
                A · · · · · 3 · · · · 4
                · · · · · · · · · · · 3
                · · · · · · · · · · · 2
                · · · · · · · · · · · 1
                B · · · · · · · · · · 0
                0 1 2 3 4 5 6 7 8 9 10
                A-D: 1,2
                B-C: 2,3
            ", Repeat.RotateAll);
            
            testGenerator.AddTest("FourConcentricPointsDiagonalAroundMiddle", @"
                · · · · · · F · · · E 10
                · · · · · · · · · · · 9
                · · 1 · · · · · · · · 8
                · · · · · · · · · · · 7
                · · · · 2 · · · · · D 6
                · · · · · · · · · · · 5
                A · · · · · 3 · · · · 4
                · · · · · · · · · · · 3
                · · · · · · · · 4 · · 2
                · · · · · · · · · · · 1
                B · · · C · · · · · · 0
                0 1 2 3 4 5 6 7 8 9 10
                A-F: 1,2
                B-E: 2,3
                C-D: 3,4
            ", Repeat.Rotate90);

            testGenerator.AddTest("ThreePointsInAWedgeTowardsCorner", @"
                · · · · · · · · · · D 10
                · · · · · · · · · · · 9
                · · · · · · · · · · · 8
                · · · · · · · · · · · 7
                · · · · · · · · · · · 6
                · · · 1 · · · · · · · 5
                B · · · A · · · · · · 4
                · · · 2 · 3 · · · · · 3
                · · · · · · · · · · · 2
                · · · · · · · · · · · 1
                · · · · C · · · · · · 0
                0 1 2 3 4 5 6 7 8 9 10
                A-B: 1,2
                A-C: 2,3
                A-D: 1,3
            ", Repeat.RotateAll);

            testGenerator.AddTest("ThreePointsInAWedgeAroundMiddleTowardsSide", @"
                · · · · · D · · · · · 10
                · · · · · · · · · · · 9
                · · · · · · · · · · · 8
                · · · · · · · · · · · 7
                · · · · · · · · · · · 6
                · · · 3 · A · 2 · · · 5
                · · · · · · · · · · · 4
                · · · · · 1 · · · · · 3
                · · · · · · · · · · · 2
                · · · · · · · · · · · 1
                B · · · · · · · · · C 0
                0 1 2 3 4 5 6 7 8 9 10
                A-B: 1,3
                A-C: 1,2
                A-D: 2,3
            ", Repeat.RotateAll);

            testGenerator.AddTest("ThreePointsInAWedgeOffsetFromMiddleTowardsSide", @"
                · · · · · D · · · · · 10
                · · · · · · · · · · · 9
                · · · · · · · · · · · 8
                · · · · · · · · · · · 7
                · · · · · · · · · · · 6
                · · · · · · · · · · · 5
                · · · · · · · · · · · 4
                · · · 3 · A · 2 · · · 3
                · · · · · · · · · · · 2
                · · · · · 1 · · · · · 1
                · · B · · · · · C · · 0
                0 1 2 3 4 5 6 7 8 9 10
                A-B: 1,3
                A-C: 1,2
                A-D: 2,3
            ", Repeat.RotateAll);

            testGenerator.AddTest("FourPointsSurroundingAPointInMiddle", @"
                E · · · · · · · · · H 10
                · · · · · · · · · · · 9
                · · · · · · · · · · · 8
                · · · · · 5 · · · · · 7
                · · · · A · D · · · · 6
                · · · 2 · 1 · 4 · · · 5
                · · · · B · C · · · · 4
                · · · · · 3 · · · · · 3
                · · · · · · · · · · · 2
                · · · · · · · · · · · 1
                F · · · · · · · · · G 0
                0 1 2 3 4 5 6 7 8 9 10
                A-B: 1,2
                B-C: 1,3
                C-D: 1,4
                D-A: 1,5
                A-E: 2,5
                B-F: 2,3
                C-G: 3,4
                D-H: 4,5
            ");

            testGenerator.AddTest("FourPointsSurroundingAPointOffsetFromMiddle", @"
                · · · · · · · · · · · 10
                · · · · · · · · · · · 9
                E · · · · · · · · · H 8
                · · · · · · · · · · · 7
                · · · · · · · · · · · 6
                · · · · · 5 · · · · · 5
                · · · · A · D · · · · 4
                · · · 2 · 1 · 4 · · · 3
                · · · · B · C · · · · 2
                · · · · · 3 · · · · · 1
                · · F · · · · · G · · 0
                0 1 2 3 4 5 6 7 8 9 10
                A-B: 1,2
                B-C: 1,3
                C-D: 1,4
                D-A: 1,5
                A-E: 2,5
                B-F: 2,3
                C-G: 3,4
                D-H: 4,5
            ", Repeat.RotateAll);

            List<(string, TestPurpose)> variants = new List<(string, TestPurpose)>()
            {
                ("GeneratedTest_Edges", TestPurpose.AssertEdges),
                ("GeneratedTest_SiteEdges", TestPurpose.AssertSiteEdges)
            };

            foreach ((string testName, TestPurpose testPurpose) in variants)
            {
                string output = testGenerator.GenerateCode(testName, testPurpose);

                File.WriteAllText("../../../../UnitTests/Fortune/AutoGenerated/" + testName + ".cs", output);
                
                //Console.OutputEncoding = Encoding.UTF8;
                //Console.WriteLine(output);
            }
        }


        private class TestGenerator
        {
            private readonly int _minX;
            private readonly int _minY;
            private readonly int _maxX;
            private readonly int _maxY;
            private readonly int _horStepSize;
            private readonly int _verStepSize;
            private readonly int _horPreviewStepSize;
            private readonly int _verPreviewStepSize;

            private readonly int _width;
            private readonly int _height;
            private readonly int _horSteps;
            private readonly int _verSteps;
            private int _horPreviewSteps;
            private int _verPreviewSteps;

            
            private List<Test> tests = new List<Test>();


            public TestGenerator(int minX, int minY, int maxX, int maxY, int horStepSize, int verStepSize, int horPreviewStepSize, int verPreviewStepSize)
            {
                _minX = minX;
                _minY = minY;
                _maxX = maxX;
                _maxY = maxY;
                _horStepSize = horStepSize;
                _verStepSize = verStepSize;
                _horPreviewStepSize = horPreviewStepSize;
                _verPreviewStepSize = verPreviewStepSize;

                _width = _maxX - _minX; 
                _height = _maxY - _minY;
                _horSteps = _width / _horStepSize + 1;
                _verSteps = _height / _verStepSize + 1;
            }

        
            public void AddTest(string name, string layout, params Repeat[] repeats)
            {
                if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException();
                if (string.IsNullOrWhiteSpace(layout)) throw new ArgumentException();
                if (tests.Any(t => t.Name == name)) throw new ArgumentException();

                
                string[] lines = layout.Split(Environment.NewLine, StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);

                if (lines.Length < _verSteps) throw new ArgumentException();

                List<Site> sites = new List<Site>();
                List<Point> points = new List<Point>();
                
                for (int y = 0; y < _verSteps; y++)
                {
                    string line = lines[_verSteps - y - 1].Trim();
                    
                    if (line.Length < _horSteps) throw new ArgumentException();

                    for (int x = 0; x < _horSteps; x++)
                    {
                        char symbol = line[x];

                        switch (symbol)
                        {
                            case '·' or ' ':
                                // Filler
                                break;
                            
                            case >= '0' and <= '9':
                                sites.Add(new Site(x * _horStepSize, y * _verStepSize, int.Parse(symbol.ToString())));
                                break;
                            
                            case >= 'A' and <= 'Z':
                                points.Add(new Point(x * _horStepSize, y * _verStepSize, symbol));
                                break;
                            
                            default:
                                throw new ArgumentException();
                        }
                    }
                }
                
                sites.Sort((s1, s2) => s1.Id.CompareTo(s2.Id));

                List<Edge> edges = new List<Edge>();

                for (int ex = _verSteps + 1; ex < lines.Length; ex++)
                {
                    string line = lines[ex];

                    // Expecting:
                    // "A-B"
                    // "A-B: 1,2"
                    // "A-B: 1,2"

                    if (line.Length < 3) throw new ArgumentException();
                    
                    char fromIdSymbol = line[0];
                    if (fromIdSymbol < 'A' || fromIdSymbol > 'Z') throw new ArgumentException();

                    int fromId = fromIdSymbol;
                    Point? fromPoint = points.FirstOrDefault(p => p.Id == fromId);
                    
                    if (fromPoint == null) throw new ArgumentException();
                    
                    char toIdSymbol = line[2];
                    if (toIdSymbol < 'A' || toIdSymbol > 'Z') throw new ArgumentException();

                    int toId = toIdSymbol;
                    Point? toPoint = points.FirstOrDefault(p => p.Id == toId);
                    
                    if (toPoint == null) throw new ArgumentException();
                    
                    if (line[1] != '-') throw new ArgumentException();

                    if (fromPoint == toPoint) throw new ArgumentException();

                    List<Site> edgeSites = new List<Site>();
                    
                    if (line.Length > 3)
                    {
                        if (line.Length < 6) throw new ArgumentException();

                        if (line[3] != ':') throw new ArgumentException();
                        if (line[4] != ' ') throw new ArgumentException();

                        string siteString = line.Substring(5);

                        string[] siteSymbolStrings = siteString.Split(",");

                        foreach (string siteSymbolString in siteSymbolStrings)
                        {
                            if (siteSymbolString.Length != 1) throw new ArgumentException();

                            char siteSymbol = siteSymbolString[0];
                            
                            if (siteSymbol < '0' || siteSymbol > '9') throw new ArgumentException();

                            int siteId = int.Parse(siteSymbol.ToString());
                            Site? site = sites.FirstOrDefault(p => p.Id == siteId);
                    
                            if (site == null) throw new ArgumentException();
                            
                            if (edgeSites.Contains(site)) throw new ArgumentException();
                            
                            edgeSites.Add(site);
                        }
                    }
                    
                    edges.Add(new Edge(fromPoint, toPoint, edgeSites));
                }

                Test newTest = new Test(name, sites, points, edges);
                
                tests.Add(newTest);

                foreach (Repeat repeat in repeats)
                {
                    switch (repeat)
                    {
                        case Repeat.Rotate90:
                            if (_width != _height) throw new InvalidOperationException();
                            tests.Add(new RepeatedTest(newTest, Repeat.Rotate90, _minX, _minY, _maxX, _maxY));
                            break;
                        
                        case Repeat.RotateAll:
                            if (_width != _height) throw new InvalidOperationException();
                            tests.Add(new RepeatedTest(newTest, Repeat.Rotate90, _minX, _minY, _maxX, _maxY));
                            tests.Add(new RepeatedTest(newTest, Repeat.Rotate180, _minX, _minY, _maxX, _maxY));
                            tests.Add(new RepeatedTest(newTest, Repeat.Rotate270, _minX, _minY, _maxX, _maxY));
                            break;
                        
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }
            }

            public string GenerateCode(string className, TestPurpose purpose)
            {
                StringBuilder stringBuilder = new StringBuilder();

                stringBuilder.AppendLine(@"using NUnit.Framework;");
                stringBuilder.AppendLine(@"using System.Collections.Generic;");
                stringBuilder.AppendLine(@"using System.Linq;");
                stringBuilder.AppendLine(@"using VoronoiLib;");
                stringBuilder.AppendLine(@"using VoronoiLib.Structures;");
                stringBuilder.AppendLine();
                stringBuilder.AppendLine(@"namespace UnitTests");
                stringBuilder.AppendLine(@"{");
                List<string> classSummary = BuildClassSummary(purpose);
                foreach (string summaryLine in classSummary)
                    stringBuilder.AppendPaddedLine(1, summaryLine);
                stringBuilder.AppendPaddedLine(1, @"[Parallelizable(ParallelScope.All)]");
                stringBuilder.AppendPaddedLine(1, @"[TestFixture]");
                stringBuilder.AppendPaddedLine(1, @"public class " + className);
                stringBuilder.AppendPaddedLine(1, @"{");
                
                foreach (Test test in tests)
                {
                    if (test is RepeatedTest repeatedTest)
                    {
                        List<string> summary = BuildSummary(repeatedTest.Repeated, repeatedTest.OriginalName);
                        foreach (string summaryLine in summary)
                            stringBuilder.AppendPaddedLine(2, summaryLine);
                    }

                    stringBuilder.AppendPaddedLine(2, @"[Test]");
                    stringBuilder.AppendPaddedLine(2, @"public void " + test.Name + @"()");
                    stringBuilder.AppendPaddedLine(2, @"{");
                    stringBuilder.AppendPaddedLine(3, @"// Arrange");
                    stringBuilder.AppendLine();

                    stringBuilder.AppendPaddedLine(3, @"List<VoronoiSite> points = new List<VoronoiSite>");
                    stringBuilder.AppendPaddedLine(3, @"{");
                    List<string> siteDefinitions = BuildSiteDefinitions(test.Sites);
                    foreach (string siteDefinition in siteDefinitions)
                        stringBuilder.AppendPaddedLine(4, siteDefinition);
                    stringBuilder.AppendPaddedLine(3, @"};");
                    stringBuilder.AppendLine();
                    
                    List<string> visualLayout = BuildVisualLayout(test);
                    foreach (string visualLayoutString in visualLayout)
                        stringBuilder.AppendPaddedLine(3, visualLayoutString);
                    stringBuilder.AppendLine();

                    stringBuilder.AppendPaddedLine(3, @"// Act");
                    stringBuilder.AppendLine();
                    if (NeedEdgesFor(purpose))
                        stringBuilder.AppendPaddedLine(3, @"List<VoronoiEdge> edges = FortunesAlgorithm.RunOnce(points, " + _minX + @", " + _minY + @", " + _maxX + @", " + _maxY + @", BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();");
                    else
                        stringBuilder.AppendPaddedLine(3, @"FortunesAlgorithm.RunOnce(points, " + _minX + @", " + _minY + @", " + _maxX + @", " + _maxY + @", BorderEdgeGeneration.DoNotMakeBorderEdges);");
                    stringBuilder.AppendLine();
                    
                    stringBuilder.AppendPaddedLine(3, @"// Assert");

                    switch (purpose)
                    {
                        case TestPurpose.AssertEdges:
                            stringBuilder.AppendLine();
                            stringBuilder.AppendPaddedLine(3, @"Assert.AreEqual(" + test.Edges.Count + @", edges.Count);");
                    
                            List<string> edgeAssertions = BuildEdgeAssertions(test.Edges);
                            foreach (string edgeAssertion in edgeAssertions)
                                stringBuilder.AppendPaddedLine(3, edgeAssertion);
                            break;
                        
                        case TestPurpose.AssertSiteEdges:
                            stringBuilder.AppendLine();
                            List<string> siteCellAssertions = BuildSiteCellAssertions(test.Edges, test.Sites);
                            foreach (string siteCellAssertion in siteCellAssertions)
                                stringBuilder.AppendPaddedLine(3, siteCellAssertion);
                            break;
                        
                        default:
                            throw new ArgumentOutOfRangeException(nameof(purpose), purpose, null);
                    }
                    
                    stringBuilder.AppendPaddedLine(2, @"}");
                    stringBuilder.AppendLine();
                }

                stringBuilder.AppendPaddedLine(1, @"}");
                stringBuilder.AppendLine(@"}");
                
                return stringBuilder.ToString();
            }

            private bool NeedEdgesFor(TestPurpose purpose)
            {
                switch (purpose)
                {
                    case TestPurpose.AssertEdges:
                        return true;
                    
                    case TestPurpose.AssertSiteEdges:
                        return false;
                    
                    default:
                        throw new ArgumentOutOfRangeException(nameof(purpose), purpose, null);
                }
            }

            private List<string> BuildClassSummary(TestPurpose purpose)
            {
                List<string> strings = new List<string>();

                strings.Add(@"/// <summary>");
                strings.Add(@"/// This is an AUTO-GENERATED test class from UnitTestGenerator.");
                strings.Add(@"/// These tests assert that " + PurposeSummaryExplanation(purpose) + @".");
                strings.Add(@"/// </summary>");

                return strings;
            }

            private string PurposeSummaryExplanation(TestPurpose purpose)
            {
                switch (purpose)
                {
                    case TestPurpose.AssertEdges:
                        return @"<see cref=""" + nameof(VoronoiEdge) + @"""/>`s are returned as expected";
                    
                    case TestPurpose.AssertSiteEdges:
                        return @"<see cref=""" + nameof(VoronoiSite) + @"""/>`s have expected <see cref=""" + nameof(VoronoiEdge) + @"""/>`s";
                    
                    default:
                        throw new ArgumentOutOfRangeException(nameof(purpose), purpose, null);
                }
            }

            private List<string> BuildSummary(Repeat repeated, string originalName)
            {
                List<string> strings = new List<string>();

                strings.Add(@"/// <summary>");
                strings.Add(@"/// This test basically repeats <see cref=""" + originalName + @"""/> above,");
                strings.Add(@"/// but all coordinates are " + RepeatToExplanation(repeated) + ".");
                strings.Add(@"/// </summary>");

                return strings;
            }

            private string RepeatToExplanation(Repeat repeat)
            {
                switch (repeat)
                {
                    case Repeat.Rotate90: return "rotated 90° around the center of the boundary";
                    case Repeat.Rotate180: return "rotated 180° around the center of the boundary";
                    case Repeat.Rotate270: return "rotated 270° around the center of the boundary";
                    
                    case Repeat.RotateAll:
                        throw new InvalidOperationException();
                    
                    default:
                        throw new ArgumentOutOfRangeException(nameof(repeat), repeat, null);
                }
            }

            private List<string> BuildSiteDefinitions(List<Site> sites)
            {
                List<string> strings = new List<string>();
                
                foreach (Site site in sites)
                {
                    strings.Add(@"new VoronoiSite(" + site.X + @", " + site.Y + @"), // #" + site.Id);
                }

                return strings;
            }

            private List<string> BuildEdgeAssertions(List<Edge> edges)
            {
                List<string> strings = new List<string>();
                
                foreach (Edge edge in edges)
                {
                    strings.Add(@"Assert.IsTrue(CommonTestUtilities.AnyEdgeBetween(edges, " + edge.FromPoint.X + @", " + edge.FromPoint.Y + @", " + edge.ToPoint.X + @", " + edge.ToPoint.Y + @")); // "+(char)edge.FromPoint.Id+@"-"+(char)edge.ToPoint.Id);
                }

                return strings;
            }

            private List<string> BuildSiteCellAssertions(List<Edge> edges, List<Site> allSites)
            {
                List<string> strings = new List<string>();

                IEnumerable<Site> sites = edges.SelectMany(e => e.EdgeSites).Distinct().OrderBy(s => s.Id);
                
                foreach (Site site in sites)
                {
                    IEnumerable<Edge> siteEdges = edges.Where(e => e.EdgeSites.Contains(site));

                    foreach (Edge siteEdge in siteEdges)
                    {
                        strings.Add(@"Assert.IsTrue(CommonTestUtilities.SiteHasEdge(points[" + allSites.IndexOf(site) + @"], " + siteEdge.FromPoint.X + @", " + siteEdge.FromPoint.Y + @", " + siteEdge.ToPoint.X + @", " + siteEdge.ToPoint.Y + @")); // #" + site.Id + @" has " + (char)siteEdge.FromPoint.Id + @"-" + (char)siteEdge.ToPoint.Id);
                    }
                }

                return strings;
            }

            private List<string> BuildVisualLayout(Test test)
            {
                _horPreviewSteps = _width / _horPreviewStepSize + 1;
                _verPreviewSteps = _height / _verPreviewStepSize + 1;

                List<Edge>?[,] edgeLines = new List<Edge>[_horPreviewSteps, _verPreviewSteps];

                foreach (Edge edge in test.Edges)
                    PlaceEdgeOnGrid(ref edgeLines, edge); 
                
                List<string> lines = new List<string>(); 
                
                for (int y = _verPreviewSteps - 1; y >= 0; y--)
                {
                    string s = "// ";

                    int verValue = y * _verPreviewStepSize;

                    if (verValue % 100 == 0)
                        s += $"{verValue,4}";
                    else
                        s += @"    ";
                        
                    s += @" ";
                    
                    for (int x = 0; x < _horPreviewSteps; x++)
                    {
                        int horValue = x * _horPreviewStepSize;

                        Site? site = test.Sites.FirstOrDefault(s => s.X == horValue && s.Y == verValue);

                        if (site != null)
                        {
                            s += site.Id;
                        }
                        else
                        {
                            Point? point = test.Points.FirstOrDefault(p => p.X == horValue && p.Y == verValue);

                            if (point != null)
                            {
                                s += (char)point.Id;
                            }
                            else
                            {
                                List<Edge>? edges = edgeLines[x, y];
                                    
                                if (edges != null && 
                                    edges.Count > 0)
                                {
                                    if (edges.Count > 1)
                                        s += "⁕";
                                    else
                                        s += MakeEdgeLineSymbol(edges[0], horValue, verValue);
                                }
                                else
                                {
                                    if (x == 0)
                                    {
                                        if (y == 0)
                                            s += @"└";
                                        else if (y == _verPreviewSteps - 1)
                                            s += @"↑";
                                        else
                                            s += @"|";
                                    }
                                    else if (y == 0)
                                    {
                                        if (x == _horPreviewSteps - 1)
                                            s += "→";
                                        else
                                            s += "-";
                                    }
                                    else
                                    {
                                        s += " ";
                                    }
                                }
                            }
                        }
                    }
                    
                    lines.Add(s);
                }
                
                string fs = "//    ";

                for (int x = 0; x < _horPreviewSteps; x++)
                {
                    int horValue = x * _horPreviewStepSize;
                    
                    if (horValue % 100 == 0)
                        fs += $"{horValue,4} ";
                }
                
                lines.Add(fs);

                return lines;
            }

            private char MakeEdgeLineSymbol(Edge edge, int valueX, int valueY)
            {
                if (edge.ToPoint.X == edge.FromPoint.X)
                    return '|';
                
                if (edge.ToPoint.Y == edge.FromPoint.Y)
                    return '-';
                
                // How many cells does this line/edge pass through?
                
                int xSteps = Math.Abs((edge.ToPoint.X - edge.FromPoint.X) / _horPreviewStepSize);
                int ySteps = Math.Abs((edge.ToPoint.Y - edge.FromPoint.Y) / _verPreviewStepSize);
                int totalSteps = Math.Max(xSteps, ySteps);

                // Find the closest point to the given cell's center
                
                double closestDistToValue = -1;
                double closestXToValue = -1;
                double closestYToValue = -1;

                for (int i = 0; i <= totalSteps; i++)
                {
                    double frac = (double)i / totalSteps;
                    
                    double actualX = edge.FromPoint.X + (edge.ToPoint.X - edge.FromPoint.X) * frac;
                    double actualY = edge.FromPoint.Y + (edge.ToPoint.Y - edge.FromPoint.Y) * frac;

                    double distX = (valueX - actualX);
                    double distY = (valueY - actualY) * _horPreviewStepSize / _verPreviewStepSize; // because text isn't "square"
                    double distToValue = distX * distX + distY * distY;

                    if (closestDistToValue < 0 ||
                        distToValue < closestDistToValue)
                    {
                        closestDistToValue = distToValue;
                        closestXToValue = actualX;
                        closestYToValue = actualY;
                    }
                }

                // Calculate the difference between cell center and where the line passes through the cell
                
                double diffX = (valueX - closestXToValue) / _horPreviewStepSize;
                double diffY = (valueY - closestYToValue) / _verPreviewStepSize;

                // Choose a symbol that best "describes" this position
                
                char symbol = diffY switch
                {
                    < -0.1 => '\'',
                    > 0.1  => ',',
                    _      => '·'
                };

                //Console.WriteLine(symbol + " for value " + valueX + ", " + valueY + " -> closest actual " + closestXToValue + ", " + closestYToValue + " dif " + diffX + ", " + diffY);

                return symbol;
            }
            
            private void PlaceEdgeOnGrid(ref List<Edge>?[,] edgeLines, Edge edge)
            {
                int x = edge.FromPoint.X / _horPreviewStepSize;
                int y = edge.FromPoint.Y / _verPreviewStepSize;
                int x2 = edge.ToPoint.X / _horPreviewStepSize;
                int y2 = edge.ToPoint.Y / _verPreviewStepSize;

                // This is Bresenham's Line Algorithm verbatim from:
                // https://stackoverflow.com/a/11683720/8047867
                
                int w = x2 - x;
                int h = y2 - y;
                int dx1 = 0, dy1 = 0, dx2 = 0, dy2 = 0;
                if (w < 0) dx1 = -1;
                else if (w > 0) dx1 = 1;
                if (h < 0) dy1 = -1;
                else if (h > 0) dy1 = 1;
                if (w < 0) dx2 = -1;
                else if (w > 0) dx2 = 1;
                int longest = Math.Abs(w);
                int shortest = Math.Abs(h);
                if (!(longest > shortest))
                {
                    longest = Math.Abs(h);
                    shortest = Math.Abs(w);
                    if (h < 0) dy2 = -1;
                    else if (h > 0) dy2 = 1;
                    dx2 = 0;
                }

                int numerator = longest >> 1;
                for (int i = 0; i <= longest; i++)
                {
                    // Our code
                    if (edgeLines[x, y] == null)
                        edgeLines[x, y] = new List<Edge>();
                    edgeLines[x, y]!.Add(edge);
                    // End of our code
                    numerator += shortest;
                    if (!(numerator < longest))
                    {
                        numerator -= longest;
                        x += dx1;
                        y += dy1;
                    }
                    else
                    {
                        x += dx2;
                        y += dy2;
                    }
                }
            }


            private class Test
            {
                public List<Site> Sites { get; protected init; } = null!;
                public List<Point> Points { get; protected init; } = null!;
                public List<Edge> Edges { get; protected init; } = null!;
                public string Name { get; protected init; } = null!;


                public Test(string name, List<Site> sites, List<Point> points, List<Edge> edges)
                {
                    Sites = sites;
                    Points = points;
                    Edges = edges;
                    Name = name;
                }

                protected Test()
                {
                }
            }

            private class RepeatedTest : Test
            {
                public Repeat Repeated { get; }
                public string OriginalName { get; }

                
                public RepeatedTest(Test givenTest, Repeat repeat, int minX, int minY, int maxX, int maxY)
                {
                    Repeated = repeat;
                    OriginalName = givenTest.Name;

                    Sites = new List<Site>();
                    Points = new List<Point>();
                    Edges = new List<Edge>();

                    foreach (Site site in givenTest.Sites)
                    {
                        (int x, int y) = TransformX(site.X, site.Y, repeat, minX, minY, maxX, maxY);
                        Sites.Add(new Site(x, y, site.Id));
                    }

                    foreach (Point point in givenTest.Points)
                    {
                        (int x, int y) = TransformX(point.X, point.Y, repeat, minX, minY, maxX, maxY);
                        Points.Add(new Point(x, y, point.Id));
                    }

                    foreach (Edge edge in givenTest.Edges)
                    {
                        Point fromPoint = Points[givenTest.Points.IndexOf(edge.FromPoint)];
                        Point toPoint = Points[givenTest.Points.IndexOf(edge.ToPoint)];
                        List<Site> sites = new List<Site>();
                        foreach (Site site in edge.EdgeSites)
                            sites.Add(Sites[givenTest.Sites.IndexOf(site)]);
                        Edges.Add(new Edge(fromPoint, toPoint, sites));
                    }

                    Name = TransformName(givenTest.Name, repeat);
                }


                private static (int x, int y) TransformX(int siteX, int siteY, Repeat repeat, int minX, int minY, int maxX, int maxY)
                {
                    int x0 = minX;
                    int y0 = minY;
                    int x1 = maxX;
                    int y1 = maxY;
                    int xc = siteX;
                    int yc = siteY;
                    
                    switch (repeat)
                    {
                        case Repeat.Rotate90:
                            return (x0 + yc, y1 - xc);
                        
                        case Repeat.Rotate180:
                            return (x1 - xc, y1 - yc);
                        
                        case Repeat.Rotate270:
                            return (x1 - yc, y0 + xc);
                        
                        case Repeat.RotateAll:
                            throw new InvalidOperationException();
                        
                        default:
                            throw new ArgumentOutOfRangeException(nameof(repeat), repeat, null);
                    }
                }

                private string TransformName(string givenName, Repeat repeat)
                {
                    if (repeat == Repeat.Rotate90)
                        if (givenName.Contains("Horizontal"))
                            return givenName.Replace("Horizontal", "Vertical");
                    
                    if (repeat == Repeat.Rotate90)
                        if (givenName.Contains("Vertical"))
                            return givenName.Replace("Vertical", "Horizontal");
                    
                    return givenName + "_" + RepeatToNameSuffix(repeat);
                }

                private static string RepeatToNameSuffix(Repeat repeat)
                {
                    switch (repeat)
                    {
                        case Repeat.Rotate90:
                            return "Rotated90";
                        
                        case Repeat.Rotate180:
                            return "Rotated180";
                        
                        case Repeat.Rotate270:
                            return "Rotated270";
                        
                        case Repeat.RotateAll:
                            throw new InvalidOperationException();
                        
                        default:
                            throw new ArgumentOutOfRangeException(nameof(repeat), repeat, null);
                    }
                }
            }

            private class Site
            {
                public int X { get; }
                public int Y { get; }
                public int Id { get; }

                
                public Site(int x, int y, int id)
                {
                    X = x;
                    Y = y;
                    Id = id;
                }
            }

            private class Point
            {
                public int X { get; }
                public int Y { get; }
                public int Id { get; }

                
                public Point(int x, int y, int id)
                {
                    X = x;
                    Y = y;
                    Id = id;
                }
            }

            private class Edge
            {
                public Point FromPoint { get; }
                public Point ToPoint { get; }
                public List<Site> EdgeSites { get; }


                public Edge(Point fromPoint, Point toPoint, List<Site> edgeSites)
                {
                    FromPoint = fromPoint;
                    ToPoint = toPoint;
                    EdgeSites = edgeSites;
                }
            }
        }

        private enum Repeat
        {
            Rotate90,
            Rotate180,
            Rotate270,
            RotateAll
        }

        public enum TestPurpose
        {
            AssertEdges,
            AssertSiteEdges
        }
    }


    internal static class StringBuilderExtensions
    {
        public static void AppendPaddedLine(this StringBuilder stringBuilder, int padding, string text)
        {
            stringBuilder.Append(' ', padding * 4);
            stringBuilder.AppendLine(text);
        }
    }
}