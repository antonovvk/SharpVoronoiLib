using System;

namespace SharpVoronoiLib
{
    public static class MathUtils
    {
        private const double epsilon = double.Epsilon * 1E100;

        
        public static bool ApproxEqual(this double value1, double value2)
        {
            return Math.Abs(value1 - value2) <= epsilon;
        }

        public static bool ApproxGreaterThanOrEqualTo(this double value1, double value2)
        {
            return value2 - value1 < epsilon;
        }

        public static bool ApproxLessThanOrEqualTo(this double value1, double value2)
        {
            return value1 - value2 < epsilon;
        }
    }
}