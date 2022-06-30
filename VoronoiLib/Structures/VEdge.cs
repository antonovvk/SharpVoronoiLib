using System.Collections.Generic;

namespace VoronoiLib.Structures
{
    public class VEdge
    {
        public VPoint Start { get; internal set; }
        public VPoint End { get; internal set; }
        public FortuneSite Left { get; }
        public FortuneSite Right { get; }
        
        private VPoint _mid;
        public VPoint Mid
        {
            get
            {
                if (_mid == null)
                    _mid = new VPoint((Start.X + End.X) / 2, (Start.Y + End.Y) / 2);
                
                return _mid;
            }
        }
        
        private List<VEdge> _neighbours;
        public List<VEdge> Neighbours
        {
            get
            {
                if (_neighbours == null)
                {
                    _neighbours = new List<VEdge>();

                    if (Left != null)
                    {
                        List<VEdge> leftPointCell = Left.Cell;

                        foreach (VEdge edge in leftPointCell)
                            if (edge != this) // one of its edges is us by definition
                                if (edge.Start == Start || edge.End == End || edge.Start == End || edge.End == Start)
                                    _neighbours.Add(edge);
                    }

                    if (Right != null)
                    {
                        List<VEdge> rightPointCell = Right.Cell;

                        foreach (VEdge edge in rightPointCell)
                            if (edge != this) // one of its edges is us by definition
                                if (edge.Start == Start || edge.End == End || edge.Start == End || edge.End == Start)
                                    _neighbours.Add(edge);
                    }
                    
                    // Note that this only works when assuming that edge end points can have 2 neighbours,
                    // that is, 4+ equidistant points actually create an additional 0-length edge.
                    // And this is indeed how the algorithm works at the moment.
                    // This makes this neighbour lookup simpler (one doesn't need to recursively "walk around" the edge end point).
                }

                return _neighbours;
            }
        }
        
        internal double SlopeRise { get; }
        internal double SlopeRun { get; }
        internal double? Slope { get; }
        internal double? Intercept { get; }
        internal VEdge Neighbor { get; set; }
        
        internal VEdge(VPoint start, FortuneSite left, FortuneSite right)
        {
            Start = start;
            Left = left;
            Right = right;
            
            //for bounding box edges
            if (left == null || right == null)
                return;

            //from negative reciprocal of slope of line from left to right
            //ala m = (left.y -right.y / left.x - right.x)
            SlopeRise = left.X - right.X;
            SlopeRun = -(left.Y - right.Y);
            Intercept = null;

            if (SlopeRise.ApproxEqual(0) || SlopeRun.ApproxEqual(0)) return;
            Slope = SlopeRise/SlopeRun;
            Intercept = start.Y - Slope*start.X;
        }


#if DEBUG
        public override string ToString()
        {
            return Start + "->" + End;
        }
#endif
    }
}
