using System.Collections.Generic;
using System.Linq;
using VoronoiLib;
using VoronoiLib.Structures;

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
        return site.Cell.Any(e =>
                                 e.Start.X.ApproxEqual(x1) && e.Start.Y.ApproxEqual(y1) && e.End.X.ApproxEqual(x2) && e.End.Y.ApproxEqual(y2) ||
                                 e.Start.X.ApproxEqual(x2) && e.Start.Y.ApproxEqual(y2) && e.End.X.ApproxEqual(x1) && e.End.Y.ApproxEqual(y1)
        );
    }
}