using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using VoronoiLib.Structures;
using VoronoiLib;

namespace VoronoiSpeedTest
{
    public static class Program
    {
        private const int WIDTH = 10000;
        private const int HEIGHT = 10000;
        private const int MAX_N = 100000;
        private const int SAMPLES = 10;
        private const int INC = 20000;

        
        public static void Main()
        {
            Random r = new Random();
            Stopwatch watch = new Stopwatch();
            long[,] times = new long[MAX_N, SAMPLES];

            for (int point = 1; point * INC <= MAX_N; point++)
            {
                int numPoints = point * INC;
                Console.WriteLine($"Running for n = {numPoints}");
                for (int sample = 1; sample <= SAMPLES; sample++)
                {
                    Console.WriteLine($"\tRunning sample {sample}");
                    watch.Reset();
                    List<VoronoiSite> points = GenPoints(numPoints, r);
                    watch.Start();
                    VoronoiPlane.TessellateOnce(points, 0, 0, WIDTH, HEIGHT, BorderEdgeGeneration.MakeBorderEdges);
                    watch.Stop();
                    times[point - 1, sample - 1] = watch.ElapsedMilliseconds;
                }
            }

            StreamWriter outFile = File.CreateText("timings.csv");
            StreamWriter excelFile = File.CreateText("excelTimings.csv");
            outFile.Write("N, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10" + Environment.NewLine);
            excelFile.Write("N, T (ms)" + Environment.NewLine);
            for (int i = 1; i * INC <= MAX_N; i++)
            {
                string s = i * INC + ", ";
                for (int j = 0; j < SAMPLES - 1; j++)
                {
                    s += times[i - 1, j] + ", ";
                }

                s += times[i - 1, SAMPLES - 1] + Environment.NewLine;
                outFile.Write(s);

                for (int j = 1; j <= SAMPLES; j++)
                {
                    excelFile.Write(i * INC + ", " + times[i - 1, j - 1] + Environment.NewLine);
                }
            }

            outFile.Dispose();
            excelFile.Dispose();
        }

        //o(n) avg gen points
        private static List<VoronoiSite> GenPoints(int n, Random r)
        {
            List<VoronoiSite> points = new List<VoronoiSite>();
            for (int i = 0; i < n; i++)
            {
                points.Add(new VoronoiSite(r.NextDouble() * WIDTH, r.NextDouble() * HEIGHT));
            }

            //uniq the points
            points = UniquePoints(points);
            int moreNeeded = points.Count - n;
            if (moreNeeded > 0)
            {
                points.AddRange(GenPoints(moreNeeded, r));
                points = UniquePoints(points);
            }

            return points;
        }

        //o(n) uniq
        private static List<VoronoiSite> UniquePoints(List<VoronoiSite> points)
        {
            points.Sort((p1, p2) =>
            {
                if (p1.X.ApproxEqual(p2.X))
                {
                    if (p1.Y.ApproxEqual(p2.Y))
                        return 0;
                    if (p1.Y < p2.Y)
                        return -1;
                    return 1;
                }

                if (p1.X < p2.X)
                    return -1;
                return 1;
            });

            List<VoronoiSite> unique = new List<VoronoiSite>(points.Count / 2);
            VoronoiSite? last = points.First();
            unique.Add(last);
            for (int index = 1; index < points.Count; index++)
            {
                VoronoiSite? point = points[index];
                if (!last.X.ApproxEqual(point.X) || !last.Y.ApproxEqual(point.Y))
                {
                    unique.Add(point);
                    last = point;
                }
            }

            return unique;
        }
    }
}