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
}
