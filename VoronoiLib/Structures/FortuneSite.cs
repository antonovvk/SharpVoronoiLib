using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace VoronoiLib.Structures
{
    public class FortuneSite
    {
        public double X { get; }
        public double Y { get; }

        [PublicAPI]
        public IEnumerable<VEdge> Cell => cell;

        [PublicAPI]
        public IEnumerable<VEdge> ClockwiseCell
        {
            get
            {
                if (_clockwiseCell == null)
                {
                    _clockwiseCell = new List<VEdge>(cell);
                    _clockwiseCell.Sort(SortEdgesClockwise);
                }

                return _clockwiseCell;
            }
        }

        [PublicAPI]
        public IEnumerable<FortuneSite> Neighbors => neighbors;

        [PublicAPI]
        public IEnumerable<VPoint> Points
        {
            get
            {
                if (_points == null)
                {
                    _points = new List<VPoint>();

                    foreach (VEdge edge in cell)
                    {
                        if (!_points.Contains(edge.Start))
                            _points.Add(edge.Start);
                        
                        if (!_points.Contains(edge.End!))
                            _points.Add(edge.End);
                        // Note that .End is guaranteed to be set since we don't expose edges externally that aren't clipped in bounds

                        // Note that the order of .Start and .End is not guaranteed in VEdge,
                        // so we couldn't simply only add either .Start or .End, this would skip and duplicate points
                    }
                }

                return _points;
            }
        }

        [PublicAPI]
        public IEnumerable<VPoint> ClockwisePoints
        {
            get
            {
                if (_clockwisePoints == null)
                {
                    _clockwisePoints = new List<VPoint>(Points);
                    _clockwisePoints.Sort(SortPointsClockwise);
                }

                return _clockwisePoints;
            }
        }


        internal readonly List<VEdge> cell;
        internal readonly List<FortuneSite> neighbors;
        
        
        private List<VPoint>? _points;
        private List<VPoint>? _clockwisePoints;
        private List<VEdge>? _clockwiseCell;


        [PublicAPI]
        public FortuneSite(double x, double y)
        {
            X = x;
            Y = y;
            cell = new List<VEdge>();
            neighbors = new List<FortuneSite>();
        }

        
        [PublicAPI]
        public bool Contains(VPoint testPoint)
        {
            // If we don't have points generated yet, do so now (by calling the property that does so when read)
            if (_clockwisePoints == null)
            {
                IEnumerable<VPoint> _ = ClockwisePoints;
            }

            // helper method to determine if a point is inside the cell
            // based on meowNET's answer from: https://stackoverflow.com/questions/4243042/c-sharp-point-in-polygon
            bool result = false;
            int j = _clockwisePoints!.Count - 1;
            for (int i = 0; i < _clockwisePoints.Count; i++)
            {
                if (_clockwisePoints[i].Y < testPoint.Y && _clockwisePoints[j].Y >= testPoint.Y || _clockwisePoints[j].Y < testPoint.Y && _clockwisePoints[i].Y >= testPoint.Y)
                {
                    if (_clockwisePoints[i].X + ((testPoint.Y - _clockwisePoints[i].Y) / (_clockwisePoints[j].Y - _clockwisePoints[i].Y) * (_clockwisePoints[j].X - _clockwisePoints[i].X)) < testPoint.X)
                    {
                        result = !result;
                    }
                }
                j = i;
            }
            return result;
        }


        internal static int SortPointsClockwise(VPoint A, VPoint B, double x, double y)
        {
            // based on: https://social.msdn.microsoft.com/Forums/en-US/c4c0ce02-bbd0-46e7-aaa0-df85a3408c61/sorting-list-of-xy-coordinates-clockwise-sort-works-if-list-is-unsorted-but-fails-if-list-is?forum=csharplanguage

            // comparer to sort the array based on the points relative position to the center
            double atanA = Math.Atan2(A.Y - y, A.X - x);
            double atanB = Math.Atan2(B.Y - y, B.X - x);

            if (atanA < atanB) return -1;
            else if (atanA > atanB) return 1;
            return 0;
        }

        internal void AddEdge(VEdge value)
        {
            cell.Add(value);
            _clockwisePoints = null;
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
            return SortPointsClockwise(A, B, X, Y);
        }


#if DEBUG
        public override string ToString()
        {
            return "(" + X.ToString("F3") + "," + Y.ToString("F3") + ")";
        }
#endif
    }
}
