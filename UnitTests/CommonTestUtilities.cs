using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using VoronoiLib;
using VoronoiLib.Structures;

namespace UnitTests
{
    internal static class CommonTestUtilities
    {
        internal static bool AnyEdgeBetween(IEnumerable<VoronoiEdge> edges, double x1, double y1, double x2, double y2)
        {
            return edges.Any(
                e =>
                    e.Start != null && e.End != null &&
                    e.Start.X.ApproxEqual(x1) && e.Start.Y.ApproxEqual(y1) && e.End.X.ApproxEqual(x2) && e.End.Y.ApproxEqual(y2) ||
                    e.Start.X.ApproxEqual(x2) && e.Start.Y.ApproxEqual(y2) && e.End.X.ApproxEqual(x1) && e.End.Y.ApproxEqual(y1)
            );
        }

        internal static bool SiteHasEdge(VoronoiSite site, int x1, int y1, int x2, int y2)
        {
            return site.Cell != null &&
                   site.Cell.Any(e =>
                                     e.Start.X.ApproxEqual(x1) && e.Start.Y.ApproxEqual(y1) && e.End.X.ApproxEqual(x2) && e.End.Y.ApproxEqual(y2) ||
                                     e.Start.X.ApproxEqual(x2) && e.Start.Y.ApproxEqual(y2) && e.End.X.ApproxEqual(x1) && e.End.Y.ApproxEqual(y1)
                   );
        }

        internal static bool SiteHasClockwiseEdge(VoronoiSite site, int x1, int y1, int x2, int y2)
        {
            return site.ClockwiseCell != null &&
                   site.ClockwiseCell.Any(e =>
                                     e.Start.X.ApproxEqual(x1) && e.Start.Y.ApproxEqual(y1) && e.End.X.ApproxEqual(x2) && e.End.Y.ApproxEqual(y2) ||
                                     e.Start.X.ApproxEqual(x2) && e.Start.Y.ApproxEqual(y2) && e.End.X.ApproxEqual(x1) && e.End.Y.ApproxEqual(y1)
                   );
        }

        internal static bool SiteHasPoint(VoronoiSite site, int x, int y)
        {
            return site.Points != null &&
                   site.Points.Any(p => p.X.ApproxEqual(x) && p.Y.ApproxEqual(y));
        }

        internal static bool SiteHasClockwisePoint(VoronoiSite site, int x, int y)
        {
            return site.ClockwisePoints != null &&
                   site.ClockwisePoints.Any(p => p.X.ApproxEqual(x) && p.Y.ApproxEqual(y));
        }

        internal static bool EdgeHasSite(VoronoiEdge edge, int x, int y)
        {
            return
                (edge.Left != null &&
                 edge.Left.X.ApproxEqual(x) &&
                 edge.Left.Y.ApproxEqual(y))
                ||
                (edge.Right != null &&
                 edge.Right.X.ApproxEqual(x) &&
                 edge.Right.Y.ApproxEqual(y));
        }

        internal static VoronoiEdge FindEdge(IEnumerable<VoronoiEdge> edges, int x1, int y1, int x2, int y2)
        {
            return edges.First(
                e =>
                    e.Start != null && e.End != null &&
                    e.Start.X.ApproxEqual(x1) && e.Start.Y.ApproxEqual(y1) && e.End.X.ApproxEqual(x2) && e.End.Y.ApproxEqual(y2) ||
                    e.Start.X.ApproxEqual(x2) && e.Start.Y.ApproxEqual(y2) && e.End.X.ApproxEqual(x1) && e.End.Y.ApproxEqual(y1)
            );
        }

        internal static VoronoiPoint FindPoint(IEnumerable<VoronoiEdge> edges, int x, int y)
        {
            VoronoiEdge? edge = edges.FirstOrDefault(e => e.Start != null && e.Start.X.ApproxEqual(x) && e.Start.Y.ApproxEqual(y));
            if (edge != null)
                return edge.Start;

            return edges.First(e => e.End != null && e.End.X.ApproxEqual(x) && e.End.Y.ApproxEqual(y))
                        .End;
        }

        internal static bool EdgeStartsAndEndsOnBorder(VoronoiEdge edge, PointBorderLocation border1, PointBorderLocation border2)
        {
            return
                (edge.Start != null && 
                 edge.Start.BorderLocation == border1 &&
                 edge.End.BorderLocation == border2)
                ||
                (edge.End != null &&
                 edge.Start.BorderLocation == border2 &&
                 edge.End.BorderLocation == border1);
        }

        internal static bool EdgeStartsXorEndsOnBorder(VoronoiEdge edge, PointBorderLocation border)
        {
            return
                (edge.Start != null &&
                 edge.Start.BorderLocation == border &&
                 edge.End.BorderLocation == PointBorderLocation.NotOnBorder)
                ||
                (edge.End != null &&
                 edge.Start.BorderLocation == PointBorderLocation.NotOnBorder &&
                 edge.End.BorderLocation == border);
        }

        internal static bool EdgeDoesntStartsOrEndsOnBorder(VoronoiEdge edge)
        {
            return
                edge.Start != null && edge.Start.BorderLocation == PointBorderLocation.NotOnBorder &&
                edge.End != null && edge.End.BorderLocation == PointBorderLocation.NotOnBorder;
        }

        internal class ClockwiseEdgeComparer : IComparer<VoronoiEdge>
        {
            private readonly double _x;
            private readonly double _y;

            
            public ClockwiseEdgeComparer(double x, double y)
            {
                _x = x;
                _y = y;
            }


            public int Compare(VoronoiEdge edge1, VoronoiEdge edge2)
            {
                return ClockwisePointComparer.ClockwisePointSort(edge1.Mid, edge2.Mid, _x, _y);
            }
        }

        internal class ClockwisePointComparer : IComparer<VoronoiPoint>
        {
            private readonly double _x;
            private readonly double _y;

            
            public ClockwisePointComparer(double x, double y)
            {
                _x = x;
                _y = y;
            }
            
            public int Compare(VoronoiPoint point1, VoronoiPoint point2)
            {
                return ClockwisePointSort(point1, point2, _x, _y);
            }
        
            
            /// <remarks>
            /// This is a copy of <see cref="VoronoiSite.SortPointsClockwise"/>.
            /// </remarks>
            internal static int ClockwisePointSort(VoronoiPoint point1, VoronoiPoint point2, double x, double y)
            {
                double atanA = Atan2(point1.Y - y, point1.X - x);
                double atanB = Atan2(point2.Y - y, point2.X - x);
            
                if (atanA < atanB) return -1;
                if (atanA > atanB) return 1;
                return 0;
            }        
            
            /// <remarks> 
            /// This is a copy of <see cref="VoronoiSite.Atan2"/>
            /// </remarks>
            private static double Atan2(double x, double y)
            {
                double a = -Math.Atan2(-y, -x) + Math.PI / 4;
		
                if (a < 0)
                    a += 2 * Math.PI;
			
                return a;
            }
        }
    }
}