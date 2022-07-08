using System;

namespace SharpVoronoiLib
{
    internal class RandomUniformPointGeneration : RandomPointGeneration
    {
        protected override double GetNextRandomValue(Random random, double minX, double maxX)
        {
            do
            {
                double value = minX + random.NextDouble() * (maxX - minX);
                
                if (value < maxX && value < maxX)
                    return value;
                
            } while (true);
        }
    }
}