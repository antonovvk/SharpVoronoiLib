using System;
using System.Collections.Generic;

namespace SharpVoronoiLib
{
    internal class RandomUniformPointGeneration : IPointGenerationAlgorithm
    {
        public List<VoronoiSite> Generate(double minX, double minY, double maxX, double maxY, int count)
        {
            List<VoronoiSite> sites = new List<VoronoiSite>(count);

            Random random = new Random();
            
            for (int i = 0; i < count; i++)
            {
                sites.Add(
                    new VoronoiSite(
                        minX + random.NextDouble() * (maxX - minX),
                        minY + random.NextDouble() * (maxY - minY)
                    )
                );
            }

            return sites;
        }
    }
}