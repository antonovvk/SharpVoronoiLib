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

        internal static bool SiteHasEdge(VoronoiSite site, double x1, double y1, double x2, double y2)
        {
            return site.Cell != null &&
                   site.Cell.Any(e =>
                                     e.Start.X.ApproxEqual(x1) && e.Start.Y.ApproxEqual(y1) && e.End.X.ApproxEqual(x2) && e.End.Y.ApproxEqual(y2) ||
                                     e.Start.X.ApproxEqual(x2) && e.Start.Y.ApproxEqual(y2) && e.End.X.ApproxEqual(x1) && e.End.Y.ApproxEqual(y1)
                   );
        }

        internal static bool SiteHasClockwiseEdge(VoronoiSite site, double x1, double y1, double x2, double y2)
        {
            return site.ClockwiseCell != null &&
                   site.ClockwiseCell.Any(e =>
                                     e.Start.X.ApproxEqual(x1) && e.Start.Y.ApproxEqual(y1) && e.End.X.ApproxEqual(x2) && e.End.Y.ApproxEqual(y2) ||
                                     e.Start.X.ApproxEqual(x2) && e.Start.Y.ApproxEqual(y2) && e.End.X.ApproxEqual(x1) && e.End.Y.ApproxEqual(y1)
                   );
        }

        internal static bool SiteHasPoint(VoronoiSite site, double x, double y)
        {
            return site.Points != null &&
                   site.Points.Any(p => p.X.ApproxEqual(x) && p.Y.ApproxEqual(y));
        }

        internal static bool SiteHasClockwisePoint(VoronoiSite site, double x, double y)
        {
            return site.ClockwisePoints != null &&
                   site.ClockwisePoints.Any(p => p.X.ApproxEqual(x) && p.Y.ApproxEqual(y));
        }

        internal static bool PointIs(VoronoiPoint point, double x, double y)
        {
            return point.X.ApproxEqual(x) && point.Y.ApproxEqual(y);
        }

        internal static bool EdgeIs(VoronoiEdge edge, double x1, double y1, double x2, double y2)
        {
            return
                edge.Start != null && edge.End != null &&
                (edge.Start.X.ApproxEqual(x1) && edge.Start.Y.ApproxEqual(y1) && edge.End.X.ApproxEqual(x2) && edge.End.Y.ApproxEqual(y2) ||
                 edge.Start.X.ApproxEqual(x2) && edge.Start.Y.ApproxEqual(y2) && edge.End.X.ApproxEqual(x1) && edge.End.Y.ApproxEqual(y1));
        }

        internal static bool EdgeHasSite(VoronoiEdge edge, double x, double y)
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

        internal static VoronoiEdge FindEdge(IEnumerable<VoronoiEdge> edges, double x1, double y1, double x2, double y2)
        {
            return edges.First(
                e =>
                    e.Start != null && e.End != null &&
                    e.Start.X.ApproxEqual(x1) && e.Start.Y.ApproxEqual(y1) && e.End.X.ApproxEqual(x2) && e.End.Y.ApproxEqual(y2) ||
                    e.Start.X.ApproxEqual(x2) && e.Start.Y.ApproxEqual(y2) && e.End.X.ApproxEqual(x1) && e.End.Y.ApproxEqual(y1)
            );
        }

        internal static VoronoiPoint FindPoint(IEnumerable<VoronoiEdge> edges, double x, double y)
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
    }
}