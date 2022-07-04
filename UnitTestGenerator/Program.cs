using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using VoronoiLib;
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
                X · · · · · · · · · Z 10
                · · · · · · · · · · · 9
                · · · · · · · · · · · 8
                · · · · · · · · · · · 7
                · · · · · · · · · · · 6
                · · · · · 1 · · · · · 5
                · · · · · · · · · · · 4
                · · · · · · · · · · · 3
                · · · · · · · · · · · 2
                · · · · · · · · · · · 1
                Y · · · · · · · · · W 0
                0 1 2 3 4 5 6 7 8 9 10
                X-Y: 1
                Y-W: 1
                W-Z: 1
                Z-X: 1
                1: Y,X,Z,W
            ");

            testGenerator.AddTest("TwoPointsVerticalAroundMiddle", @"
                X · · · · · · · · · Z 10
                · · · · · · · · · · · 9
                · · · · · · · · · · · 8
                · · · · · 1 · · · · · 7
                · · · · · · · · · · · 6
                A · · · · · · · · · B 5
                · · · · · · · · · · · 4
                · · · · · 2 · · · · · 3
                · · · · · · · · · · · 2
                · · · · · · · · · · · 1
                Y · · · · · · · · · W 0
                0 1 2 3 4 5 6 7 8 9 10
                A-B: 1,2
                X-A: 1
                A-Y: 2
                Y-W: 2
                W-B: 2
                B-Z: 1
                Z-X: 1
                1: AX,,ZB,
                2: YA,,BW,
            ", Repeat.Rotate90);

            testGenerator.AddTest("TwoPointsVerticalOffsetFromMiddle", @"
                X · · · · · · · · · Z 10
                · · · · · 1 · · · · · 9
                · · · · · · · · · · · 8
                A · · · · · · · · · B 7
                · · · · · · · · · · · 6
                · · · · · 2 · · · · · 5
                · · · · · · · · · · · 4
                · · · · · · · · · · · 3
                · · · · · · · · · · · 2
                · · · · · · · · · · · 1
                Y · · · · · · · · · W 0
                0 1 2 3 4 5 6 7 8 9 10
                A-B: 1,2
                X-A: 1
                A-Y: 2
                Y-W: 2
                W-B: 2
                B-Z: 1
                Z-X: 1
                1: AX,,ZB,
                2: YA,,B,W
            ", Repeat.Rotate90);

            testGenerator.AddTest("ThreeConcentricPointsVerticalAroundMiddle", @"
                X · · · · · · · · · Z 10
                · · · · · 1 · · · · · 9
                · · · · · · · · · · · 8
                A · · · · · · · · · B 7
                · · · · · · · · · · · 6
                · · · · · 2 · · · · · 5
                · · · · · · · · · · · 4
                C · · · · · · · · · D 3
                · · · · · · · · · · · 2
                · · · · · 3 · · · · · 1
                Y · · · · · · · · · W 0
                0 1 2 3 4 5 6 7 8 9 10
                A-B: 1,2
                C-D: 2,3
                X-A: 1
                A-C: 2
                C-Y: 3
                Y-W: 3
                W-D: 3
                D-B: 2
                B-Z: 1
                Z-X: 1
                1: AX,,ZB,
                2: CA,,BD,
                3: YC,,DW,
            ", Repeat.Rotate90);

            testGenerator.AddTest("FourConcentricPointsVerticalAroundMiddle", @"
                X · · · · · · · · · Z 10
                · · · · · · · · · · · 9
                · · · · · 1 · · · · · 8
                A · · · · · · · · · B 7
                · · · · · 2 · · · · · 6
                C · · · · · · · · · D 5
                · · · · · 3 · · · · · 4
                E · · · · · · · · · F 3
                · · · · · 4 · · · · · 2
                · · · · · · · · · · · 1
                Y · · · · · · · · · W 0
                0 1 2 3 4 5 6 7 8 9 10
                A-B: 1,2
                C-D: 2,3
                E-F: 3,4
                X-A: 1
                A-C: 2
                C-E: 3
                E-Y: 4
                Y-W: 4
                W-F: 4
                F-D: 3
                D-B: 2
                B-Z: 1
                Z-X: 1
                1: AX,,ZB,
                2: CA,,BD,
                3: EC,,DF,
                4: YE,,FW,
            ", Repeat.Rotate90);

            testGenerator.AddTest("TwoDiagonalPointsAroundMiddle", @"
                X · · · · · · · · · B 10
                · · · · · · · · · · · 9
                · · · · · · · · · · · 8
                · · · 1 · · · · · · · 7
                · · · · · · · · · · · 6
                · · · · · · · · · · · 5
                · · · · · · · · · · · 4
                · · · · · · · 2 · · · 3
                · · · · · · · · · · · 2
                · · · · · · · · · · · 1
                A · · · · · · · · · Y 0
                0 1 2 3 4 5 6 7 8 9 10
                A-B: 1,2
                X-A: 1
                A-Y: 2
                Y-B: 2
                B-X: 1
                1: ,X,B,A
                2: A,B,,Y
            ", Repeat.Rotate90);

            testGenerator.AddTest("TwoDiagonalPointsOffsetFromMiddle", @"
                X · · · · · · · B · Z 10
                · · · · · · · · · · · 9
                · · 1 · · · · · · · · 8
                · · · · · · · · · · · 7
                · · · · · · · · · · · 6
                · · · · · · · · · · · 5
                · · · · · · 2 · · · · 4
                · · · · · · · · · · · 3
                A · · · · · · · · · · 2
                · · · · · · · · · · · 1
                Y · · · · · · · · · W 0
                0 1 2 3 4 5 6 7 8 9 10
                A-B: 1,2
                X-A: 1
                A-Y: 2
                Y-W: 2
                W-Z: 2
                Z-B: 2
                B-X: 1
                1: ,X,B,A
                2: YA,BZ,,W
            ", Repeat.RotateAll);

            testGenerator.AddTest("ThreeConcentricPointsDiagonalAroundMiddle", @"
                X · · · · · · D · · Z 10
                · · · · · · · · · · · 9
                · · 1 · · · · · · · · 8
                · · · · · · · · · · C 7
                · · · · · · · · · · · 6
                · · · · · 2 · · · · · 5
                · · · · · · · · · · · 4
                A · · · · · · · · · · 3
                · · · · · · · · 3 · · 2
                · · · · · · · · · · · 1
                Y · · B · · · · · · W 0
                0 1 2 3 4 5 6 7 8 9 10
                A-D: 1,2
                B-C: 2,3
                X-A: 1
                A-Y: 2
                Y-B: 2
                B-W: 3
                W-C: 3
                C-Z: 2
                Z-D: 2
                D-X: 1
                1: ,X,D,A
                2: YA,D,ZC,B
                3: B,C,,W
            ", Repeat.Rotate90);

            testGenerator.AddTest("ThreeConcentricPointsDiagonalOffsetFromMiddle", @"
                X · · · · · D · · · C 10
                · · · · · · · · · · · 9
                · · 1 · · · · · · · · 8
                · · · · · · · · · · · 7
                · · · · 2 · · · · · · 6
                · · · · · · · · · · · 5
                A · · · · · 3 · · · · 4
                · · · · · · · · · · · 3
                · · · · · · · · · · · 2
                · · · · · · · · · · · 1
                B · · · · · · · · · Y 0
                0 1 2 3 4 5 6 7 8 9 10
                A-D: 1,2
                B-C: 2,3
                X-A: 1
                A-B: 2
                B-Y: 3
                Y-C: 3
                C-D: 2
                D-X: 1
                1: ,X,D,A
                2: A,D,C,B
                3: B,C,,Y
            ", Repeat.RotateAll);

            testGenerator.AddTest("FourConcentricPointsDiagonalAroundMiddle", @"
                X · · · · · F · · · E 10
                · · · · · · · · · · · 9
                · · 1 · · · · · · · · 8
                · · · · · · · · · · · 7
                · · · · 2 · · · · · D 6
                · · · · · · · · · · · 5
                A · · · · · 3 · · · · 4
                · · · · · · · · · · · 3
                · · · · · · · · 4 · · 2
                · · · · · · · · · · · 1
                B · · · C · · · · · Y 0
                0 1 2 3 4 5 6 7 8 9 10
                A-F: 1,2
                B-E: 2,3
                C-D: 3,4
                X-A: 1
                A-B: 2
                B-C: 3
                C-Y: 4
                Y-D: 4
                D-E: 3
                E-F: 2
                F-X: 1
                1: ,X,F,A
                2: A,F,E,B
                3: B,E,D,C
                4: C,D,,Y
            ", Repeat.Rotate90);

            testGenerator.AddTest("ThreePointsInAWedgeTowardsCorner", @"
                X · · · · · · · · · D 10
                · · · · · · · · · · · 9
                · · · · · · · · · · · 8
                · · · · · · · · · · · 7
                · · · · · · · · · · · 6
                · · · 1 · · · · · · · 5
                B · · · A · · · · · · 4
                · · · 2 · 3 · · · · · 3
                · · · · · · · · · · · 2
                · · · · · · · · · · · 1
                Y · · · C · · · · · W 0
                0 1 2 3 4 5 6 7 8 9 10
                A-B: 1,2
                A-C: 2,3
                A-D: 1,3
                X-B: 1
                B-Y: 2
                Y-C: 2
                C-W: 3
                W-D: 3
                D-X: 1
                1: B,X,D,A
                2: YB,,A,C
                3: ,AD,W,C
            ", Repeat.RotateAll);

            testGenerator.AddTest("ThreePointsInAWedgeAroundMiddleTowardsSide", @"
                X · · · · D · · · · Y 10
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
                X-B: 3 
                B-C: 1 
                C-Y: 2 
                Y-D: 2 
                D-X: 3
                1: B,A,C,
                2: A,DY,,C
                3: ,XD,A,B
            ", Repeat.RotateAll);

            testGenerator.AddTest("ThreePointsInAWedgeOffsetFromMiddleTowardsSide", @"
                X · · · · D · · · · Z 10
                · · · · · · · · · · · 9
                · · · · · · · · · · · 8
                · · · · · · · · · · · 7
                · · · · · · · · · · · 6
                · · · · · · · · · · · 5
                · · · · · · · · · · · 4
                · · · 3 · A · 2 · · · 3
                · · · · · · · · · · · 2
                · · · · · 1 · · · · · 1
                Y · B · · · · · C · W 0
                0 1 2 3 4 5 6 7 8 9 10
                A-B: 1,3
                A-C: 1,2
                A-D: 2,3
                X-Y: 3 
                Y-B: 3 
                B-C: 1 
                C-W: 2 
                W-Z: 2 
                Z-D: 2 
                D-X: 3 
                1: B,A,C,
                2: A,DZ,,WC
                3: Y,XD,A,B
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
                E-F: 2
                F-G: 3
                G-H: 4
                H-E: 5
                1: B,A,D,C
                2: ,E,A,BF
                3: F,B,CG,
                4: C,DH,,G
                5: AE,,H,D
            ");

            testGenerator.AddTest("FourPointsSurroundingAPointOffsetFromMiddle", @"
                X · · · · · · · · · Z 10
                · · · · · · · · · · · 9
                E · · · · · · · · · H 8
                · · · · · · · · · · · 7
                · · · · · · · · · · · 6
                · · · · · 5 · · · · · 5
                · · · · A · D · · · · 4
                · · · 2 · 1 · 4 · · · 3
                · · · · B · C · · · · 2
                · · · · · 3 · · · · · 1
                Y · F · · · · · G · W 0
                0 1 2 3 4 5 6 7 8 9 10
                A-B: 1,2
                B-C: 1,3
                C-D: 1,4
                D-A: 1,5
                A-E: 2,5
                B-F: 2,3
                C-G: 3,4
                D-H: 4,5
                X-E: 5
                E-Y: 2
                Y-F: 2
                F-G: 3
                G-W: 4
                W-H: 4
                H-Z: 5
                Z-X: 5
                1: B,A,D,C
                2: Y,E,A,BF
                3: F,B,CG,
                4: C,DH,,WG
                5: AE,X,ZH,D
            ", Repeat.RotateAll);

            List<(string, TestPurpose)> variants = new List<(string, TestPurpose)>()
            {
                ("GeneratedTest_Edges", TestPurpose.AssertEdges),
                ("GeneratedTest_SiteEdges", TestPurpose.AssertSiteEdges),
                ("GeneratedTest_SiteEdgesClockwise", TestPurpose.AssertSiteEdgesClockwise),
                ("GeneratedTest_EdgeSites", TestPurpose.AssertEdgeSites),
                ("GeneratedTest_EdgeNeighbours", TestPurpose.AssertEdgeNeighbours),
                ("GeneratedTest_SiteNeighbours", TestPurpose.AssertSiteNeighbours),
                ("GeneratedTest_SitePoints", TestPurpose.AssertSitePoints),
                ("GeneratedTest_SitePointsClockwise", TestPurpose.AssertSitePointsClockwise),
                ("GeneratedTest_PointBorderLocation", TestPurpose.AssertPointBorderLocation)
            };

            for (int i = 0; i < 2; i++)
            {
                TestBorderLogic borderLogic = i == 0 ? TestBorderLogic.UnclosedBorders : TestBorderLogic.ClosedBorders;
                    
                foreach ((string testName, TestPurpose testPurpose) in variants)
                {
                    string fullTestName = testName + "_" + (borderLogic == TestBorderLogic.UnclosedBorders ? "OpenBorders" : "ClosedBorders");

                    Console.WriteLine("Outputting test " + fullTestName + "...");

                    string output = testGenerator.GenerateCode(fullTestName, testPurpose, borderLogic);

                    File.WriteAllText("../../../../UnitTests/Fortune/AutoGenerated/" + fullTestName + ".cs", output);

                    //Console.OutputEncoding = Encoding.UTF8;
                    //Console.WriteLine(output);
                }
            }
            
            Console.WriteLine("Done.");
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


            private readonly List<Test> tests = new List<Test>();


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

                
                Console.WriteLine("Parsing data for test " + name + "...");


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
                                points.Add(new Point(x * _horStepSize, y * _verStepSize, symbol, symbol >= 'W'));
                                break;

                            default:
                                throw new ArgumentException();
                        }
                    }
                }

                sites.Sort((s1, s2) => s1.Id.CompareTo(s2.Id));

                List<Edge> edges = new List<Edge>();

                bool seenSite = false;
                
                for (int ex = _verSteps + 1; ex < lines.Length; ex++)
                {
                    string line = lines[ex];

                    // Expecting:
                    // "A-B: 1,2"
                    // "A-B: 1"
                    // "1: A,B,C,D"
                    // "1: ,AB,,C"

                    if (line.Length < 1) throw new ArgumentException();
                    
                    char firstSymbol = line[0];

                    if (firstSymbol >= 'A' && firstSymbol <= 'Z')
                    {
                        if (seenSite) throw new ArgumentException();
                        
                        if (line.Length < 6) throw new ArgumentException();

                        int fromId = firstSymbol;
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

                        if (line[3] != ':') throw new ArgumentException();
                        if (line[4] != ' ') throw new ArgumentException();

                        string siteString = line.Substring(5);

                        string[] siteSymbolStrings = siteString.Split(",");

                        if (siteSymbolStrings.Length > 2) throw new ArgumentException();

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

                        bool border = edgeSites.Count == 1; // any other edge has 2 sites by definition

                        edges.Add(new Edge(fromPoint, toPoint, edgeSites, border));
                    }
                    else if (firstSymbol >= '0' && firstSymbol <= '9')
                    {
                        seenSite = true;

                        int siteId = int.Parse(firstSymbol.ToString());
                        Site? site = sites.FirstOrDefault(p => p.Id == siteId);
                        
                        if (site == null) throw new ArgumentException();

                        if (line[1] != ':') throw new ArgumentException();
                        
                        if (line[2] != ' ') throw new ArgumentException();

                        string pointString = line.Substring(3);
                        
                        string[] pointEdgeStrings = pointString.Split(",");
                        
                        if (pointEdgeStrings.Length != 4) throw new ArgumentException();

                        for (int q = 0; q < 4; q++)
                        {
                            string pointEdgeString = pointEdgeStrings[q];
                            
                            for (int c = 0; c < pointEdgeString.Length; c++)
                            {
                                char idSymbol = pointEdgeString[c];
                                int id = idSymbol;
                                
                                Point? point = points.FirstOrDefault(p => p.Id == id);
                                
                                if (point == null) throw new ArgumentException();

                                site.Points[q].Add(point);
                            }
                        }
                    }
                    else
                    {
                        throw new ArgumentException();
                    }
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

            public string GenerateCode(string className, TestPurpose purpose, TestBorderLogic borderLogic)
            {
                StringBuilder stringBuilder = new StringBuilder();

                stringBuilder.AppendLine(@"using NUnit.Framework;");
                stringBuilder.AppendLine(@"using System.Collections.Generic;");
                stringBuilder.AppendLine(@"using System.Linq;");
                stringBuilder.AppendLine(@"using VoronoiLib;");
                stringBuilder.AppendLine(@"using VoronoiLib.Structures;");
                stringBuilder.AppendLine(@"using static UnitTests.CommonTestUtilities;");
                stringBuilder.AppendLine();
                stringBuilder.AppendLine(@"namespace UnitTests");
                stringBuilder.AppendLine(@"{");
                List<string> classSummary = BuildClassSummary(purpose, borderLogic);
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

                    stringBuilder.AppendPaddedLine(3, @"List<VoronoiSite> sites = new List<VoronoiSite>");
                    stringBuilder.AppendPaddedLine(3, @"{");
                    List<string> siteDefinitions = BuildSiteDefinitions(test.Sites);
                    foreach (string siteDefinition in siteDefinitions)
                        stringBuilder.AppendPaddedLine(4, siteDefinition);
                    stringBuilder.AppendPaddedLine(3, @"};");
                    stringBuilder.AppendLine();

                    List<string> visualLayout = BuildVisualLayout(test, borderLogic);
                    foreach (string visualLayoutString in visualLayout)
                        stringBuilder.AppendPaddedLine(3, visualLayoutString);
                    stringBuilder.AppendLine();

                    stringBuilder.AppendPaddedLine(3, @"// Act");
                    stringBuilder.AppendLine();
                    if (NeedEdgesFor(purpose))
                        stringBuilder.AppendPaddedLine(3, @"List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, " + _minX + @", " + _minY + @", " + _maxX + @", " + _maxY + @", " + BorderLogicToRealEnum(borderLogic) + @").ToList();");
                    else
                        stringBuilder.AppendPaddedLine(3, @"VoronoiPlane.TessellateOnce(sites, " + _minX + @", " + _minY + @", " + _maxX + @", " + _maxY + @", " + BorderLogicToRealEnum(borderLogic) + @");");
                    stringBuilder.AppendLine();

                    stringBuilder.AppendPaddedLine(3, @"// Assert");

                    switch (purpose)
                    {
                        case TestPurpose.AssertEdges:
                            stringBuilder.AppendLine();
                            stringBuilder.AppendPaddedLine(3, @"Assert.AreEqual(" + CountExpectedRelevantEdges(test.Edges, borderLogic) + @", edges.Count);");

                            List<string> edgeAssertions = BuildEdgeAssertions(test.Edges, borderLogic);
                            foreach (string edgeAssertion in edgeAssertions)
                                stringBuilder.AppendPaddedLine(3, edgeAssertion);
                            break;

                        case TestPurpose.AssertSiteEdges:
                            stringBuilder.AppendLine();
                            List<string> siteEdgeAssertions = BuildSiteEdgeAssertions(test.Edges, test.Sites, borderLogic, false);
                            foreach (string siteEdgeAssertion in siteEdgeAssertions)
                                stringBuilder.AppendPaddedLine(3, siteEdgeAssertion);
                            break;

                        case TestPurpose.AssertSiteEdgesClockwise:
                            stringBuilder.AppendLine();
                            List<string> siteEdgeClockwiseAssertions = BuildSiteEdgeAssertions(test.Edges, test.Sites, borderLogic, true);
                            foreach (string siteEdgeAssertion in siteEdgeClockwiseAssertions)
                                stringBuilder.AppendPaddedLine(3, siteEdgeAssertion);
                            break;

                        case TestPurpose.AssertEdgeSites:
                            stringBuilder.AppendLine();
                            List<string> edgeSiteAssertions = BuildEdgeSiteAssertions(test.Edges, borderLogic);
                            foreach (string edgeSiteAssertion in edgeSiteAssertions)
                                stringBuilder.AppendPaddedLine(3, edgeSiteAssertion);
                            break;

                        case TestPurpose.AssertEdgeNeighbours:
                            stringBuilder.AppendLine();
                            List<string> edgeNeighboursAssertions = BuildEdgeNeighboursAssertions(test.Edges, borderLogic);
                            foreach (string edgeNeighbourAssertion in edgeNeighboursAssertions)
                                stringBuilder.AppendPaddedLine(3, edgeNeighbourAssertion);
                            break;

                        case TestPurpose.AssertSiteNeighbours:
                            stringBuilder.AppendLine();
                            List<string> siteNeighboursAssertions = BuildSiteNeighboursAssertions(test.Sites, test.Edges, borderLogic);
                            foreach (string siteNeighbourAssertion in siteNeighboursAssertions)
                                stringBuilder.AppendPaddedLine(3, siteNeighbourAssertion);
                            break;

                        case TestPurpose.AssertSitePoints:
                            stringBuilder.AppendLine();
                            List<string> sitePointsAssertions = BuildSitePointsAssertions(test.Edges, test.Sites, borderLogic, false);
                            foreach (string sitePointAssertion in sitePointsAssertions)
                                stringBuilder.AppendPaddedLine(3, sitePointAssertion);
                            break;

                        case TestPurpose.AssertSitePointsClockwise:
                            stringBuilder.AppendLine();
                            List<string> sitePointsClockwiseAssertions = BuildSitePointsAssertions(test.Edges, test.Sites, borderLogic, true);
                            foreach (string sitePointAssertion in sitePointsClockwiseAssertions)
                                stringBuilder.AppendPaddedLine(3, sitePointAssertion);
                            break;

                        case TestPurpose.AssertPointBorderLocation:
                            stringBuilder.AppendLine();
                            List<string> pointBorderLocationAssertions = BuildPointBorderLocationAssertions(test.Edges, test.Sites, borderLogic);
                            foreach (string pointBorderLocationAssertion in pointBorderLocationAssertions)
                                stringBuilder.AppendPaddedLine(3, pointBorderLocationAssertion);
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

            private bool EdgeMatchesBorderLogic(Edge edge, TestBorderLogic borderLogic)
            {
                switch (borderLogic)
                {
                    case TestBorderLogic.UnclosedBorders:
                        return !edge.Border;
                    
                    case TestBorderLogic.ClosedBorders:
                        return true;
                    
                    default:
                        throw new ArgumentOutOfRangeException(nameof(borderLogic), borderLogic, null);
                }
            }

            private bool PointMatchesBorderLogic(Point point, TestBorderLogic borderLogic)
            {
                switch (borderLogic)
                {
                    case TestBorderLogic.UnclosedBorders:
                        return !point.Corner;
                    
                    case TestBorderLogic.ClosedBorders:
                        return true;
                    
                    default:
                        throw new ArgumentOutOfRangeException(nameof(borderLogic), borderLogic, null);
                }
            }

            private int CountExpectedRelevantEdges(List<Edge> edges, TestBorderLogic borderLogic)
            {
                return edges.Count(e => EdgeMatchesBorderLogic(e, borderLogic));
            }

            private string BorderLogicToRealEnum(TestBorderLogic borderLogic)
            {
                switch (borderLogic)
                {
                    case TestBorderLogic.UnclosedBorders:
                        return nameof(BorderEdgeGeneration) + "." + nameof(BorderEdgeGeneration.DoNotMakeBorderEdges);
                    
                    case TestBorderLogic.ClosedBorders:
                        return nameof(BorderEdgeGeneration) + "." + nameof(BorderEdgeGeneration.MakeBorderEdges);
                    
                    default:
                        throw new ArgumentOutOfRangeException(nameof(borderLogic), borderLogic, null);
                }
            }

            private bool NeedEdgesFor(TestPurpose purpose)
            {
                switch (purpose)
                {
                    case TestPurpose.AssertEdges:
                    case TestPurpose.AssertEdgeSites:
                    case TestPurpose.AssertPointBorderLocation:
                    case TestPurpose.AssertEdgeNeighbours:
                        return true;

                    case TestPurpose.AssertSiteEdges:
                    case TestPurpose.AssertSiteEdgesClockwise:
                    case TestPurpose.AssertSitePoints:
                    case TestPurpose.AssertSitePointsClockwise:
                    case TestPurpose.AssertSiteNeighbours:
                        return false;

                    default:
                        throw new ArgumentOutOfRangeException(nameof(purpose), purpose, null);
                }
            }

            private List<string> BuildClassSummary(TestPurpose purpose, TestBorderLogic borderLogic)
            {
                List<string> strings = new List<string>();

                strings.Add(@"/// <summary>");

                switch (purpose)
                {
                    case TestPurpose.AssertEdges:
                        strings.Add(@"/// These tests assert that <see cref=""" + nameof(VoronoiEdge) + @"""/>`s are returned as expected");
                        strings.Add(@"/// Specifically, that the result of <see cref=""" + nameof(VoronoiPlane) + @"." + nameof(VoronoiPlane.Tessellate) + @"""/>() contains the expected edges.");
                        break;

                    case TestPurpose.AssertSiteEdges:
                        strings.Add(@"/// These tests assert that <see cref=""" + nameof(VoronoiSite) + @"""/>`s have expected <see cref=""" + nameof(VoronoiEdge) + @"""/>`s.");
                        strings.Add(@"/// Specifically, that the <see cref=""" + nameof(VoronoiSite) + @"." + nameof(VoronoiSite.Cell) + @"""/> contains the expected edges.");
                        break;

                    case TestPurpose.AssertSiteEdgesClockwise:
                        strings.Add(@"/// These tests assert that <see cref=""" + nameof(VoronoiSite) + @"""/>`s have expected clockwise-sorted <see cref=""" + nameof(VoronoiEdge) + @"""/>`s.");
                        strings.Add(@"/// Specifically, that the <see cref=""" + nameof(VoronoiSite) + @"." + nameof(VoronoiSite.ClockwiseCell) + @"""/> contains the expected edges in clockwise order.");
                        break;

                    case TestPurpose.AssertEdgeSites:
                        strings.Add(@"/// These tests assert that <see cref=""" + nameof(VoronoiEdge) + @"""/>`s have expected <see cref=""" + nameof(VoronoiSite) + @"""/>`s.");
                        strings.Add(@"/// Specifically, that the <see cref=""" + nameof(VoronoiEdge) + @"." + nameof(VoronoiEdge.Left) + @"""/> and <see cref=""" + nameof(VoronoiEdge) + @"." + nameof(VoronoiEdge.Right) + @"""/> are the expected sites.");
                        break;

                    case TestPurpose.AssertEdgeNeighbours:
                        strings.Add(@"/// These tests assert that <see cref=""" + nameof(VoronoiEdge) + @"""/>`s have expected neighbouring edges.");
                        strings.Add(@"/// Specifically, that the <see cref=""" + nameof(VoronoiEdge) + @"." + nameof(VoronoiEdge.Neighbours) + @"""/> contains the expected <see cref=""" + nameof(VoronoiEdge) + @"""/>`s.");
                        break;

                    case TestPurpose.AssertSiteNeighbours:
                        strings.Add(@"/// These tests assert that <see cref=""" + nameof(VoronoiSite) + @"""/>`s have expected neighbouring sites.");
                        strings.Add(@"/// Specifically, that the <see cref=""" + nameof(VoronoiSite) + @"." + nameof(VoronoiSite.Neighbours) + @"""/> contains the expected <see cref=""" + nameof(VoronoiSite) + @"""/>`s.");
                        break;

                    case TestPurpose.AssertSitePoints:
                        strings.Add(@"/// These tests assert that <see cref=""" + nameof(VoronoiSite) + @"""/>`s have expected <see cref=""" + nameof(VoronoiPoint) + @"""/>`s.");
                        strings.Add(@"/// Specifically, that the <see cref=""" + nameof(VoronoiSite) + @"." + nameof(VoronoiSite.Points) + @"""/> contains the expected points.");
                        break;

                    case TestPurpose.AssertSitePointsClockwise:
                        strings.Add(@"/// These tests assert that <see cref=""" + nameof(VoronoiSite) + @"""/>`s have expected clockwise-sorted <see cref=""" + nameof(VoronoiPoint) + @"""/>`s.");
                        strings.Add(@"/// Specifically, that the <see cref=""" + nameof(VoronoiSite) + @"." + nameof(VoronoiSite.ClockwisePoints) + @"""/> contains the expected points in clockwise order.");
                        break;

                    case TestPurpose.AssertPointBorderLocation:
                        strings.Add(@"/// These tests assert that <see cref=""" + nameof(VoronoiPoint) + @"""/>`s have the expected <see cref=""" + nameof(PointBorderLocation) + @"""/>.");
                        strings.Add(@"/// Specifically, that the <see cref=""" + nameof(VoronoiPoint) + @"." + nameof(VoronoiPoint.BorderLocation) + @"""/> has the expected value.");
                        break;

                    default:
                        throw new ArgumentOutOfRangeException(nameof(purpose), purpose, null);
                }

                switch (borderLogic)
                {
                    case TestBorderLogic.UnclosedBorders:
                        strings.Add(@"/// These tests are run without generating the border edges, i.e. <see cref=""" + nameof(BorderEdgeGeneration) + @"." + nameof(BorderEdgeGeneration.DoNotMakeBorderEdges) + @"""/>.");
                        break;
                    
                    case TestBorderLogic.ClosedBorders:
                        strings.Add(@"/// These tests are run with generating the border edges, i.e. <see cref=""" + nameof(BorderEdgeGeneration) + @"." + nameof(BorderEdgeGeneration.MakeBorderEdges) + @"""/>.");
                        break;
                    
                    default:
                        throw new ArgumentOutOfRangeException(nameof(borderLogic), borderLogic, null);
                }

                strings.Add(@"/// </summary>");

                strings.Add(@"/// <remarks>");
                strings.Add(@"/// This is an AUTO-GENERATED test fixture class from UnitTestGenerator.");
                strings.Add(@"/// This is one of the several auto-generated fixture classes each checking a different part of the algorithm's result.");
                strings.Add(@"/// It contains a bunch of known Voronoi site layouts, including many edge cases.");
                strings.Add(@"/// </remarks>");

                return strings;
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
                    case Repeat.Rotate90:  return "rotated 90° around the center of the boundary";
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

            private List<string> BuildEdgeAssertions(List<Edge> edges, TestBorderLogic borderLogic)
            {
                List<string> strings = new List<string>();

                foreach (Edge edge in edges.Where(e => EdgeMatchesBorderLogic(e, borderLogic)))
                {
                    strings.Add(@"Assert.IsTrue(AnyEdgeBetween(edges, " + edge.FromPoint.X + @", " + edge.FromPoint.Y + @", " + edge.ToPoint.X + @", " + edge.ToPoint.Y + @")); // " + (char)edge.FromPoint.Id + @"-" + (char)edge.ToPoint.Id);
                }

                return strings;
            }

            private List<string> BuildEdgeSiteAssertions(List<Edge> edges, TestBorderLogic borderLogic)
            {
                List<string> strings = new List<string>();

                foreach (Edge edge in edges.Where(e => EdgeMatchesBorderLogic(e, borderLogic)))
                {
                    foreach (Site site in edge.EdgeSites)
                    {
                        strings.Add(@"Assert.IsTrue(EdgeHasSite(FindEdge(edges, " + edge.FromPoint.X + @", " + edge.FromPoint.Y + @", " + edge.ToPoint.X + @", " + edge.ToPoint.Y + @"), " + site.X + @", " + site.Y + @")); // " + (char)edge.FromPoint.Id + @"-" + (char)edge.ToPoint.Id + " has #" + site.Id + @"");
                    }
                }

                return strings;
            }

            private List<string> BuildEdgeNeighboursAssertions(List<Edge> edges, TestBorderLogic borderLogic)
            {
                List<string> strings = new List<string>();

                bool first = true;
                
                foreach (Edge edge in edges.Where(e => EdgeMatchesBorderLogic(e, borderLogic)))
                {
                    // Find other edges that have a point that we have
                    
                    List<Edge> neighbours = edges
                        .Where(e =>
                                   e != edge &&
                                   EdgeMatchesBorderLogic(e, borderLogic) &&
                                   e.Points()
                                       .Any(p => p == edge.FromPoint || p == edge.ToPoint)
                        ).ToList();

                    if (neighbours.Count > 0)
                    {
                        strings.Add((first ? nameof(VoronoiEdge) + @" " : "") + @"edge = FindEdge(edges, " + edge.FromPoint.X + @", " + edge.FromPoint.Y + @", " + edge.ToPoint.X + @", " + edge.ToPoint.Y + @"); // " + (char)edge.FromPoint.Id + @"-" + (char)edge.ToPoint.Id);

                        strings.Add(@"Assert.AreEqual(" + neighbours.Count + @", edge" + @"." + nameof(VoronoiEdge.Neighbours) + @".Count());");

                        foreach (Edge neighbour in neighbours)
                        {
                            strings.Add(@"Assert.IsTrue(edge." + nameof(VoronoiEdge.Neighbours) + @".Contains(FindEdge(edges, " + neighbour.FromPoint.X + @", " + neighbour.FromPoint.Y + @", " + neighbour.ToPoint.X + @", " + neighbour.ToPoint.Y + @"))); // " + (char)edge.FromPoint.Id + @"-" + (char)edge.ToPoint.Id + " neighbours " + (char)neighbour.FromPoint.Id + @"-" + (char)neighbour.ToPoint.Id);
                        }

                        first = false;
                    }
                    else
                    {
                        strings.Add(@"Assert.AreEqual(0, FindEdge(edges, " + edge.FromPoint.X + @", " + edge.FromPoint.Y + @", " + edge.ToPoint.X + @", " + edge.ToPoint.Y + @")." + nameof(VoronoiEdge.Neighbours) + @".Count()); // " + (char)edge.FromPoint.Id + @"-" + (char)edge.ToPoint.Id);
                    }
                }
                
                return strings;
            }

            private List<string> BuildSiteNeighboursAssertions(List<Site> sites, List<Edge> edges, TestBorderLogic borderLogic)
            {
                List<string> strings = new List<string>();

                foreach (Site site in sites.OrderBy(s => s.Id))
                {
                    // Find other sites that have an edge that we have

                    IEnumerable<Edge> siteEdges = edges
                                                  .Where(e => EdgeMatchesBorderLogic(e, borderLogic))
                                                  .Where(e => e.EdgeSites.Contains(site));
                    
                    List<Site> neighbours = sites
                                            .Where(s =>
                                                       s != site &&
                                                       siteEdges.Intersect(
                                                           // We need to get edges for the site
                                                           edges
                                                               .Where(e => EdgeMatchesBorderLogic(e, borderLogic))
                                                               .Where(e => e.EdgeSites.Contains(s))
                                                       ).Any())
                                            .OrderBy(s => s.Id)
                                            .ToList();
                    
                    foreach (Site neighbour in neighbours)
                    {
                        strings.Add(@"Assert.True(sites[" + sites.IndexOf(site) + @"]." + nameof(VoronoiSite.Neighbours) + @".Contains(sites[" + sites.IndexOf(neighbour) + @"])); // " + site.Id + @" neighbours " + neighbour.Id);
                    }
                }

                return strings;
            }

            private List<string> BuildSitePointsAssertions(List<Edge> edges, List<Site> sites, TestBorderLogic borderLogic, bool clockwise)
            {
                List<string> strings = new List<string>();

                foreach (Site site in sites.OrderBy(s => s.Id))
                {
                    List<Point> points = edges
                                         .Where(e =>
                                                    EdgeMatchesBorderLogic(e, borderLogic) &&
                                                    e.EdgeSites.Contains(site))
                                         .SelectMany(e => e.Points())
                                         .Distinct() // edges connect at points, so there's repeats
                                         .OrderBy(p => p.Id)
                                         .ToList();

                    strings.Add(@"Assert.AreEqual(" + points.Count + @", sites[" + sites.IndexOf(site) + @"]" + @"." + (clockwise ? nameof(VoronoiSite.ClockwisePoints) : nameof(VoronoiSite.Points)) + @".Count()); // #" + site.Id);

                    foreach (Point point in points)
                    {
                        strings.Add(@"Assert.IsTrue(SiteHas" + (clockwise ? "Clockwise" : "") + @"Point(sites[" + sites.IndexOf(site) + @"], " + point.X + @", " + point.Y + @")); // #" + site.Id + " has " + (char)point.Id + @"");
                    }
                    
                    if (clockwise)
                    {
                        int index = 0;
                        
                        foreach (List<Point> quadrantPoints in site.Points)
                        {
                            foreach (Point point in quadrantPoints)
                            {
                                if (PointMatchesBorderLogic(point, borderLogic))
                                {
                                    strings.Add(@"Assert.IsTrue(PointIs(sites[" + sites.IndexOf(site) + @"]" + @"." + nameof(VoronoiSite.ClockwisePoints) + @".ElementAt(" + index + @"), " + point.X + @", " + point.Y + @")); // #" + site.Id + @" " + (char)point.Id);

                                    index++;
                                }
                            }
                        }
                    }
                }

                return strings;
            }

            private List<string> BuildPointBorderLocationAssertions(List<Edge> edges, List<Site> sites, TestBorderLogic borderLogic)
            {
                List<string> strings = new List<string>();

                IEnumerable<Point> points = edges
                                            .Where(e => EdgeMatchesBorderLogic(e, borderLogic))
                                            .SelectMany(e => e.Points())
                                            .Distinct() // edges connect at points, so there's repeats
                                            .OrderBy(p => p.Id + (p.Corner ? 10 : 0)); // corner after regular
                
                foreach (Point point in points)
                {
                    strings.Add(@"Assert.AreEqual(" + nameof(PointBorderLocation) + @"." + PointLocationToExpectedBorderLocation(point) + @", FindPoint(edges, " + point.X + @", " + point.Y + @")." + nameof(VoronoiPoint.BorderLocation) + @"); // " + (char)point.Id);
                }

                return strings;
            }

            private PointBorderLocation PointLocationToExpectedBorderLocation(Point point)
            {
                if (point.X == _minX)
                {
                    if (point.Y == _minY)
                        return PointBorderLocation.BottomLeft;
                    else if (point.Y == _maxY)
                        return PointBorderLocation.TopLeft;
                    else
                        return PointBorderLocation.Left;
                }
                else if (point.X == _maxX)
                {
                    if (point.Y == _minY)
                        return PointBorderLocation.BottomRight;
                    else if (point.Y == _maxY)
                        return PointBorderLocation.TopRight;
                    else
                        return PointBorderLocation.Right;
                }
                else
                {
                    if (point.Y == _minY)
                        return PointBorderLocation.Bottom;
                    if (point.Y == _maxY)
                        return PointBorderLocation.Top;
                    else
                        return PointBorderLocation.NotOnBorder;
                }
            }

            private List<string> BuildSiteEdgeAssertions(List<Edge> edges, List<Site> allSites, TestBorderLogic borderLogic, bool clockwise)
            {
                List<string> strings = new List<string>();

                IEnumerable<Site> sites = edges.SelectMany(e => e.EdgeSites).Distinct().OrderBy(s => s.Id);

                foreach (Site site in sites)
                {
                    List<Edge> siteEdges = edges
                                           .Where(e => EdgeMatchesBorderLogic(e, borderLogic))
                                           .Where(e => e.EdgeSites.Contains(site))
                                           .ToList();

                    strings.Add(@"Assert.AreEqual(" + siteEdges.Count + @", sites[" + allSites.IndexOf(site) + @"]" + @"." + (clockwise ? nameof(VoronoiSite.ClockwiseCell) : nameof(VoronoiSite.Cell)) + @".Count()); // #" + site.Id);

                    foreach (Edge siteEdge in siteEdges)
                    {
                        strings.Add(@"Assert.IsTrue(SiteHas" + (clockwise ? "Clockwise" : "") + @"Edge(sites[" + allSites.IndexOf(site) + @"], " + siteEdge.FromPoint.X + @", " + siteEdge.FromPoint.Y + @", " + siteEdge.ToPoint.X + @", " + siteEdge.ToPoint.Y + @")); // #" + site.Id + @" has " + (char)siteEdge.FromPoint.Id + @"-" + (char)siteEdge.ToPoint.Id);
                    }

                    if (clockwise)
                    {
                        int index = 0;

                        IEnumerable<Edge> orderedEdges = siteEdges.OrderBy(e => GetEdgeSoftIndex(e, site.Points));
                        
                        foreach (Edge edge in orderedEdges)
                        {
                            strings.Add(@"Assert.IsTrue(EdgeIs(sites[" + allSites.IndexOf(site) + @"]" + @"." + nameof(VoronoiSite.ClockwiseCell) + @".ElementAt(" + index + @"), " + edge.FromPoint.X + @", " + edge.FromPoint.Y + @", " + edge.ToPoint.X + @", " + edge.ToPoint.Y + @")); // #" + site.Id + @" " + (char)edge.FromPoint.Id + @"-" + (char)edge.ToPoint.Id);

                            index++;
                        }
                    }
                }

                return strings;
            }

            private int GetEdgeSoftIndex(Edge edge, List<Point>[] sitePoints)
            {
                List<Point> flatPoints = sitePoints.SelectMany(sp => sp).ToList();

                int fromIndex = flatPoints.IndexOf(edge.FromPoint);
                int toIndex = flatPoints.IndexOf(edge.ToPoint);

                // Points are sequential
                if (Math.Abs(toIndex - fromIndex) == 1)
                    return Math.Min(fromIndex, toIndex); // select previous index (going to next)
                
                // Points wrap around
                if (Math.Abs(toIndex - fromIndex) == flatPoints.Count - 1)
                    return Math.Max(fromIndex, toIndex); // select last index (going to first)

                throw new InvalidOperationException();
            }

            private List<string> BuildVisualLayout(Test test, TestBorderLogic borderLogic)
            {
                _horPreviewSteps = _width / _horPreviewStepSize + 1;
                _verPreviewSteps = _height / _verPreviewStepSize + 1;

                List<Edge>?[,] edgeLines = new List<Edge>[_horPreviewSteps, _verPreviewSteps];

                foreach (Edge edge in test.Edges.Where(e => EdgeMatchesBorderLogic(e, borderLogic)))
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
                            Point? point = test.Points.Where(e => PointMatchesBorderLogic(e, borderLogic)).FirstOrDefault(p => p.X == horValue && p.Y == verValue);

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
                                        s += "#";
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

                // How many cells does this line/site pass through?

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
                        Site newSite = new Site(x, y, site.Id);
                        Sites.Add(newSite);
                    }

                    foreach (Point point in givenTest.Points)
                    {
                        (int x, int y) = TransformX(point.X, point.Y, repeat, minX, minY, maxX, maxY);
                        Points.Add(new Point(x, y, point.Id, point.Corner));
                    }

                    foreach (Edge edge in givenTest.Edges)
                    {
                        Point fromPoint = Points[givenTest.Points.IndexOf(edge.FromPoint)];
                        Point toPoint = Points[givenTest.Points.IndexOf(edge.ToPoint)];
                        List<Site> sites = new List<Site>();
                        foreach (Site site in edge.EdgeSites)
                            sites.Add(Sites[givenTest.Sites.IndexOf(site)]);
                        Edges.Add(new Edge(fromPoint, toPoint, sites, edge.Border));
                    }

                    for (int s = 0; s < Sites.Count; s++)
                    {
                        Site ourSite = Sites[s];
                        Site givenSite = givenTest.Sites[s];

                        for (int sourceQuadrant = 0; sourceQuadrant < givenSite.Points.Length; sourceQuadrant++)
                        {
                            int targetQuadrant = TransformQuadrantIndex(sourceQuadrant, repeat);
                        
                            for (int p = 0; p < givenSite.Points[sourceQuadrant].Count; p++)
                            {
                                Point givenPoint = givenSite.Points[sourceQuadrant][p];
                                Point ourPoint = Points[givenTest.Points.IndexOf(givenPoint)];
                                ourSite.Points[targetQuadrant].Add(ourPoint);
                            }
                        }
                    }

                    Name = TransformName(givenTest.Name, repeat);
                }


                private static int TransformQuadrantIndex(int quadrant, Repeat repeat)
                {
                    int newQuadrant;
                    
                    switch (repeat)
                    {
                        case Repeat.Rotate90:
                            newQuadrant = quadrant + 1;
                            break;
                        
                        case Repeat.Rotate180:
                            newQuadrant = quadrant + 2;
                            break;
                        
                        case Repeat.Rotate270:
                            newQuadrant = quadrant + 3;
                            break;
                        
                        case Repeat.RotateAll:
                            throw new InvalidOperationException();
                        
                        default:
                            throw new ArgumentOutOfRangeException(nameof(repeat), repeat, null);
                    }

                    if (newQuadrant < 0)
                        newQuadrant += 4;

                    if (newQuadrant >= 4)
                        newQuadrant -= 4;

                    return newQuadrant;
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
                public List<Point>[] Points { get; init; } = new List<Point>[4] { new List<Point>(), new List<Point>(), new List<Point>(), new List<Point>() };


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
                public bool Corner { get; }


                public Point(int x, int y, int id, bool corner)
                {
                    X = x;
                    Y = y;
                    Id = id;
                    Corner = corner;
                }
            }

            private class Edge
            {
                public Point FromPoint { get; }
                public Point ToPoint { get; }
                public List<Site> EdgeSites { get; }
                public bool Border { get; }


                public Edge(Point fromPoint, Point toPoint, List<Site> edgeSites, bool border)
                {
                    FromPoint = fromPoint;
                    ToPoint = toPoint;
                    EdgeSites = edgeSites;
                    Border = border;
                }

                
                public IEnumerable<Point> Points()
                {
                    yield return FromPoint;
                    yield return ToPoint;
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

        private enum TestPurpose
        {
            AssertEdges,
            AssertSiteEdges,
            AssertEdgeSites,
            AssertSitePoints,
            AssertPointBorderLocation,
            AssertEdgeNeighbours,
            AssertSiteNeighbours,
            AssertSiteEdgesClockwise,
            AssertSitePointsClockwise
        }

        private enum TestBorderLogic
        {
            UnclosedBorders,
            ClosedBorders
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