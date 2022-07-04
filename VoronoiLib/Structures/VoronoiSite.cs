using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace VoronoiLib.Structures
{
    public class VoronoiSite
    {
        public double X { get; }
        public double Y { get; }

        [PublicAPI]
        public IEnumerable<VoronoiEdge> Cell => cell;

        [PublicAPI]
        public IEnumerable<VoronoiEdge> ClockwiseCell
        {
            get
            {
                if (_clockwiseCell == null)
                {
                    _clockwiseCell = new List<VoronoiEdge>(cell);
                    _clockwiseCell.Sort(SortEdgesClockwise);
                }

                return _clockwiseCell;
            }
        }

        [PublicAPI]
        public IEnumerable<VoronoiSite> Neighbours => neighbours;

        [PublicAPI]
        public IEnumerable<VoronoiPoint> Points
        {
            get
            {
                if (_points == null)
                {
                    _points = new List<VoronoiPoint>();

                    foreach (VoronoiEdge edge in cell)
                    {
                        if (!_points.Contains(edge.Start))
                            _points.Add(edge.Start);
                        
                        if (!_points.Contains(edge.End!))
                            _points.Add(edge.End);
                        // Note that .End is guaranteed to be set since we don't expose edges externally that aren't clipped in bounds

                        // Note that the order of .Start and .End is not guaranteed in VoronoiEdge,
                        // so we couldn't simply only add either .Start or .End, this would skip and duplicate points
                    }
                }

                return _points;
            }
        }

        [PublicAPI]
        public IEnumerable<VoronoiPoint> ClockwisePoints
        {
            get
            {
                if (_clockwisePoints == null)
                {
                    _clockwisePoints = new List<VoronoiPoint>(Points);
                    _clockwisePoints.Sort(SortPointsClockwise);
                }

                return _clockwisePoints;
            }
        }


        internal readonly List<VoronoiEdge> cell;
        internal readonly List<VoronoiSite> neighbours;
        
        
        private List<VoronoiPoint>? _points;
        private List<VoronoiPoint>? _clockwisePoints;
        private List<VoronoiEdge>? _clockwiseCell;


        [PublicAPI]
        public VoronoiSite(double x, double y)
        {
            X = x;
            Y = y;
            cell = new List<VoronoiEdge>();
            neighbours = new List<VoronoiSite>();
        }

        
        [PublicAPI]
        public bool Contains(VoronoiPoint testPoint)
        {
            // If we don't have points generated yet, do so now (by calling the property that does so when read)
            if (_clockwisePoints == null)
            {
                IEnumerable<VoronoiPoint> _ = ClockwisePoints;
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


        internal static int SortPointsClockwise(VoronoiPoint A, VoronoiPoint B, double x, double y)
        {
            // based on: https://social.msdn.microsoft.com/Forums/en-US/c4c0ce02-bbd0-46e7-aaa0-df85a3408c61/sorting-list-of-xy-coordinates-clockwise-sort-works-if-list-is-unsorted-but-fails-if-list-is?forum=csharplanguage

            // comparer to sort the array based on the points relative position to the center
            double atanA = Math.Atan2(A.Y - y, A.X - x);
            double atanB = Math.Atan2(B.Y - y, B.X - x);

            if (atanA < atanB) return -1;
            else if (atanA > atanB) return 1;
            return 0;
        }

        internal void AddEdge(VoronoiEdge value)
        {
            cell.Add(value);
            _clockwisePoints = null;
        }

        
        private int SortEdgesClockwise(VoronoiEdge A, VoronoiEdge B)
        {
            return SortPointsClockwise(A.Mid, B.Mid);
            
            // Note that we use edge midpoint because the order of .Start and .End is not guaranteed.
            // If we used Start or End, we would sometimes end up checking the same point/coordinate where the edges connect.
            // A midpoint, however, guarantees each edge has a unique position for the comparison.
            // (Technically, any point along the edge that isn't the start/end will do, but midpoint is just the simplest).
        }

        private int SortPointsClockwise(VoronoiPoint A, VoronoiPoint B)
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
