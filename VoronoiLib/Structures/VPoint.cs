using System.Runtime.CompilerServices;

namespace VoronoiLib.Structures
{
    public class VPoint
    {
        public double X { get; }
        public double Y { get; }
        public PointBorderLocation BorderLocation { get; }

        public VPoint(double x, double y, PointBorderLocation borderLocation = PointBorderLocation.NotOnBorder)
        {
            X = x;
            Y = y;
            BorderLocation = borderLocation;
        }


#if DEBUG
        public override string ToString()
        {
            return "(" + X.ToString("F3") + "," + Y.ToString("F3") + ")" + BorderLocationToString(BorderLocation);
        }

        public string ToString(string format)
        {
            return "(" + X.ToString(format) + "," + Y.ToString(format) + ")" + BorderLocationToString(BorderLocation);
        }

        private static string BorderLocationToString(PointBorderLocation location)
        {
            switch (location)
            {
                case PointBorderLocation.NotOnBorder:
                    return "";
                case PointBorderLocation.BottomLeft:
                    return "BL";
                case PointBorderLocation.Left:
                    return "L";
                case PointBorderLocation.TopLeft:
                    return "TL";
                case PointBorderLocation.Top:
                    return "T";
                case PointBorderLocation.TopRight:
                    return "TR";
                case PointBorderLocation.Right:
                    return "R";
                case PointBorderLocation.BottomRight:
                    return "BR";
                case PointBorderLocation.Bottom:
                    return "B";
                default:
                    return "?";
            }
        }
#endif
    }
    
    public enum PointBorderLocation
    {
        NotOnBorder,
        BottomLeft,
        Left,
        TopLeft,
        Top,
        TopRight,
        Right,
        BottomRight,
        Bottom
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
