using System.Runtime.CompilerServices;

namespace VoronoiLib.Structures
{
    public class VPoint
    {
        public double X { get; }
        public double Y { get; }
        public bool OnBorder { get; }

        public VPoint(double x, double y, bool onBorder = false)
        {
            X = x;
            Y = y;
            OnBorder = onBorder;
        }

#if DEBUG
        public override string ToString()
        {
            return "(" + X.ToString("F3") + "," + Y.ToString("F3") + ")" + (OnBorder ? "B" : "");
        }
        
        public string ToString(string format)
        {
            return "(" + X.ToString(format) + "," + Y.ToString(format) + ")" + (OnBorder ? "B" : "");
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
