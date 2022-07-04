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


        [Pure]
        internal static int SortPointsClockwise(VoronoiPoint point1, VoronoiPoint point2, double x, double y)
        {
            // originally, based on: https://social.msdn.microsoft.com/Forums/en-US/c4c0ce02-bbd0-46e7-aaa0-df85a3408c61/sorting-list-of-xy-coordinates-clockwise-sort-works-if-list-is-unsorted-but-fails-if-list-is?forum=csharplanguage

            // comparer to sort the array based on the points relative position to the center
            double atanA = Atan2(point1.Y - y, point1.X - x);
            double atanB = Atan2(point2.Y - y, point2.X - x);
            
            if (atanA < atanB) return -1;
            if (atanA > atanB) return 1;
            return 0;
        }
        
        [Pure]
        private static double Atan2(double y, double x)
        {
            // Normally, Atan2 return an angle between -π ≤ θ ≤ π as "seen" on the Cartesian plane,
            // that is, starting at the "right" of x axis and increasing counter-clockwise.
            // But our convention is that bottom-left is the "origin" and clockwise is the "standard direction":
            // →→→→↓
            // ↑   ↓
            // O←←←←

            double a = -Math.Atan2(-y, -x) + Math.PI / 4;
		
            if (a < 0)
                a += 2 * Math.PI;
			
            return a;
        }

        internal void AddEdge(VoronoiEdge value)
        {
            cell.Add(value);
            _clockwisePoints = null;
        }

        
        [Pure]
        private int SortEdgesClockwise(VoronoiEdge edge1, VoronoiEdge edge2)
        {
            if (EdgeCrossesOrigin(edge1))
                return 1;
            
            if (EdgeCrossesOrigin(edge2))
                return -1;
            
            return SortPointsClockwise(edge1.Mid, edge2.Mid);
            
            // Note that we don't assume that edges connect.
        }

        [Pure]
        private bool EdgeCrossesOrigin(VoronoiEdge edge)
        {
            double atanA = Atan2(edge.Start.Y - Y, edge.Start.X - X);
            double atanB = Atan2(edge.End!.Y - Y, edge.End.X - X);
            
            // Edge can only "cover" less than half the circle by definition, otherwise then it wouldn't actually contain the site
            // So when the difference between end point angles is greater than half a circle, we know we have and edge that "crossed" the angle origin.
            
            return Math.Abs(atanA - atanB) >= Math.PI;
        }

        [Pure]
        private int SortPointsClockwise(VoronoiPoint point1, VoronoiPoint point2)
        {
            return SortPointsClockwise(point1, point2, X, Y);
        }


#if DEBUG
        public override string ToString()
        {
            return "(" + X.ToString("F3") + "," + Y.ToString("F3") + ")";
        }
#endif
    }
}
