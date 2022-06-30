using System.Runtime.CompilerServices;

namespace VoronoiLib.Structures
{
    public class VPoint
    {
        public double X { get; }
        public double Y { get; }

        public VPoint(double x, double y)
        {
            X = x;
            Y = y;
        }

#if DEBUG
        public override string ToString()
        {
            return "(" + X.ToString("F3") + "," + Y.ToString("F3") + ")";
        }
        
        public string ToString(string format)
        {
            return "(" + X.ToString(format) + "," + Y.ToString(format) + ")";
        }
#endif
    }

    public static class VPointExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool ApproxEqual(this VPoint value1, VPoint value2)
        {
            return
                value1.X.ApproxEqual(value2.X) &&
                value1.Y.ApproxEqual(value2.Y);
        }
    }
}
