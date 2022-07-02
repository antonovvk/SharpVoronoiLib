using System.Runtime.CompilerServices;

namespace VoronoiLib.Structures
{
    public class VPoint
    {
        public double X { get; }
        public double Y { get; }
        public PointBorderLocation BorderLocation { get; }

        internal VPoint(double x, double y, PointBorderLocation borderLocation = PointBorderLocation.NotOnBorder)
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
    
    /// <remarks>
    /// Note that these are ordered clock-wise starting at bottom-left
    /// </remarks>
    public enum PointBorderLocation
    {
        NotOnBorder = -1,
        BottomLeft = 0,
        Left = 1,
        TopLeft = 2,
        Top = 3,
        TopRight = 4,
        Right = 5,
        BottomRight = 6,
        Bottom = 7
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
