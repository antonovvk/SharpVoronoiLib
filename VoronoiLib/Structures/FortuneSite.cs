using System;
using System.Collections.Generic;

namespace VoronoiLib.Structures
{
    public class FortuneSite
    {
        public double X { get; }
        public double Y { get; }

        public List<VEdge> Cell { get; }

        public List<FortuneSite> Neighbors { get; private set; }

        public FortuneSite(double x, double y)
        {
            X = x;
            Y = y;
            Cell = new List<VEdge>();
            Neighbors = new List<FortuneSite>();
        }

        private List<VPoint> _points;
        public List<VPoint> Points
        {
            get
            {
                if (_points == null)
                {
                    // it would probably be better to sort these as they are added to improve performance
                    _points = new List<VPoint>();

                    foreach (var edge in Cell)
                    {
                        if (!_points.Contains(edge.Start))
                            _points.Add(edge.Start);
                        
                        if (!_points.Contains(edge.End))
                            _points.Add(edge.End);
                        
                        // Note that the order of .Start and .End is not guaranteed in VEdge,
                        // so we couldn't simply only add either .Start or .End, this would skip and duplicate points
                    }
                    _points.Sort(SortPointsClockwise);
                }

                return _points;
            }
        }
        
        private List<VEdge> _clockwiseCell;
        public List<VEdge> ClockwiseCell
        {
            get
            {
                if (_clockwiseCell == null)
                {
                    _clockwiseCell = new List<VEdge>(Cell);
                    _clockwiseCell.Sort(SortEdgesClockwise);
                }

                return _clockwiseCell;
            }
        }

        public bool Contains(VPoint testPoint)
        {
            // helper method to determine if a point is inside the cell
            // based on meowNET's answer from: https://stackoverflow.com/questions/4243042/c-sharp-point-in-polygon
            bool result = false;
            int j = Points.Count - 1;
            for (int i = 0; i < Points.Count; i++)
            {
                if (Points[i].Y < testPoint.Y && Points[j].Y >= testPoint.Y || Points[j].Y < testPoint.Y && Points[i].Y >= testPoint.Y)
                {
                    if (Points[i].X + ((testPoint.Y - Points[i].Y) / (Points[j].Y - Points[i].Y) * (Points[j].X - Points[i].X)) < testPoint.X)
                    {
                        result = !result;
                    }
                }
                j = i;
            }
            return result;
        }

        private int SortEdgesClockwise(VEdge A, VEdge B)
        {
            return SortPointsClockwise(A.Mid, B.Mid);
            
            // Note that we use edge midpoint because the order of .Start and .End is not guaranteed.
            // If we used Start or End, we would sometimes end up checking the same point/coordinate where the edges connect.
            // A midpoint, however, guarantees each edge has a unique position for the comparison.
            // (Technically, any point along the edge that isn't the start/end will do, but midpoint is just the simplest).
        }

        private int SortPointsClockwise(VPoint A, VPoint B)
        {
            // based on: https://social.msdn.microsoft.com/Forums/en-US/c4c0ce02-bbd0-46e7-aaa0-df85a3408c61/sorting-list-of-xy-coordinates-clockwise-sort-works-if-list-is-unsorted-but-fails-if-list-is?forum=csharplanguage

            // comparer to sort the array based on the points relative position to the center
            var atanA = Math.Atan2(A.Y - Y, A.X - X);
            var atanB = Math.Atan2(B.Y - Y, B.X - X);

            if (atanA < atanB) return -1;
            else if (atanA > atanB) return 1;
            return 0;
        }

        internal void AddEdge(VEdge value)
        {
            if (value.Start == null || value.End == null
                || double.IsNaN(value.Start.X) || double.IsNaN(value.Start.Y)
                || double.IsNaN(value.End.X) || double.IsNaN(value.End.Y))
            {
                return;
            }

            Cell.Add(value);
            _points = null;
        }
        
        
#if DEBUG
        public override string ToString()
        {
            return "(" + X.ToString("F3") + "," + Y.ToString("F3") + ")";
        }
#endif
    }
}
