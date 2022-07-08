using System.Collections.Generic;

namespace SharpVoronoiLib
{
    internal interface IRelaxationAlgorithm
    {
        List<VoronoiSite> Relax(List<VoronoiSite> sites, double minX, double minY, double maxX, double maxY, float strength);
    }
}