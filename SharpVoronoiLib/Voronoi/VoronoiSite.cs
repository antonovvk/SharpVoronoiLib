using System;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;

namespace SharpVoronoiLib
{
    /// <summary>
    /// The point/site/seed on the Voronoi plane.
    /// This has a <see cref="Cell"/> of <see cref="VoronoiEdge"/>s.
    /// This has <see cref="Points"/> of <see cref="VoronoiPoint"/>s that are the edge end points, i.e. the cell's vertices.
    /// This also has <see cref="Neighbours"/>, i.e. <see cref="VoronoiSite"/>s across the <see cref="VoronoiEdge"/>s.
    /// </summary>
    public class VoronoiSite
    {
        [PublicAPI]
        public double X { get; }
        
        [PublicAPI]
        public double Y { get; }

        /// <summary>
        /// The edges that make up this cell.
        /// The vertices of these edges are the <see cref="Points"/>.
        /// These are also known as Thiessen polygons.
        /// </summary>
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
                    _clockwiseCell.Sort(SortCellEdgesClockwise);
                }

                return _clockwiseCell;
            }
        }

        /// <summary>
        /// The sites across the edges.
        /// </summary>
        [PublicAPI]
        public IEnumerable<VoronoiSite> Neighbours => neighbours;

        /// <summary>
        /// The vertices of the <see cref="Cell"/>.
        /// </summary>
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
        private int SortCellEdgesClockwise(VoronoiEdge edge1, VoronoiEdge edge2)
        {
            int result;

            if (LiesOnEdge(edge1) || LiesOnEdge(edge2))
            {
                // If we are on either edge then we can't compare directly to that edge,
                // because angle to the edge is basically "along the edge", i.e. undefined.
                // We don't know which "direction" the cell will turn, we don't know if the cell is to the right/or left of the edge.
                // So we "step away" a little bit towards out cell's/polygon's center so that we are no longer on either edge.
                // This means we can now get the correct angle, which is slightly different now, but all we care about is the origin/quadrant.
                // This is a roundabout way to do this, but it seems to work well enough.
                
                double centerX = GetCenterShiftedX();
                double centerY = GetCenterShiftedY();
                
                if (EdgeCrossesOrigin(edge1, centerX, centerY))
                    result = 1; // this makes edge 1 the last edge among all (cell's) edges

                else if (EdgeCrossesOrigin(edge2, centerX, centerY))
                    result = -1; // this makes edge 2 the last edge among all (cell's) edges
                
                else
                    result = SortPointsClockwise(edge1.Mid, edge2.Mid, centerX, centerY);
            }
            else
            {
                if (EdgeCrossesOrigin(edge1))
                    result = 1; // this makes edge 1 the last edge among all (cell's) edges

                else if (EdgeCrossesOrigin(edge2))
                    result = -1; // this makes edge 2 the last edge among all (cell's) edges
                
                else 
                    result = SortPointsClockwise(edge1.Mid, edge2.Mid, X, Y);

            }
            
            return result;

            // Note that we don't assume that edges connect.
        }

        [Pure]
        private bool LiesOnEdge(VoronoiEdge edge)
        {
            return ArePointsColinear(
                X, Y, 
                edge.Start.X, edge.Start.Y, 
                edge.End.X, edge.End.Y
            );
        }

        [Pure]
        private static bool ArePointsColinear(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            // Based off https://stackoverflow.com/a/328110/8047867

            // Cross product 2-1 x 3-1
            return ((x2 - x1) * (y3 - y1)).ApproxEqual((x3 - x1) * (y2 - y1));
        }

        [Pure]
        private bool EdgeCrossesOrigin(VoronoiEdge edge)
        {
            double atanA = Atan2(edge.Start.Y - Y, edge.Start.X - X);
            double atanB = Atan2(edge.End!.Y - Y, edge.End.X - X);
            
            // Edge can only "cover" less than half the circle by definition, otherwise then it wouldn't actually "contain" the site
            // So when the difference between end point angles is greater than half a circle, we know we have and edge that "crossed" the angle origin.
            
            return Math.Abs(atanA - atanB) > Math.PI;
        }

        [Pure]
        private bool EdgeCrossesOrigin(VoronoiEdge edge, double originX, double originY)
        {
            double atanA = Atan2(edge.Start.Y - originY, edge.Start.X - originX);
            double atanB = Atan2(edge.End!.Y - originY, edge.End.X - originX);
            
            // Edge can only "cover" less than half the circle by definition, otherwise then it wouldn't actually "contain" the site
            // So when the difference between end point angles is greater than half a circle, we know we have and edge that "crossed" the angle origin.
            
            return Math.Abs(atanA - atanB) > Math.PI;
        }

        [Pure]
        private int SortPointsClockwise(VoronoiPoint point1, VoronoiPoint point2)
        {
            // When the point lies on top of us, we don't know what to use as an angle because that depends on which way the other edges "close".
            // So we "shift" the center a little towatds the centroid of the polygon, which would "restore" the angle.
            if (point1.ApproxEqual(X, Y) ||
                point2.ApproxEqual(X, Y))
                return SortPointsClockwise(point1, point2, GetCenterShiftedX(), GetCenterShiftedY());
            
            return SortPointsClockwise(point1, point2, X, Y);
        }
        
        [Pure]
        private double GetCenterShiftedX()
        {
            double target = cell.Sum(c => c.Start.X + c.End.X) / cell.Count / 2;
            return X + (target - X) * shiftAmount;
        }

        [Pure]
        private double GetCenterShiftedY()
        {
            double target = cell.Sum(c => c.Start.Y + c.End.Y) / cell.Count / 2;
            return Y + (target - Y) * shiftAmount;
        }
        
        private const double shiftAmount = 1 / 1E14;// the point of shifting coordinates is to "change the angle", but Atan cannot distinguish anything smaller than double significant digits, so we need this "epsilon" to be fairly large 


#if DEBUG
        public override string ToString()
        {
            return "(" + X.ToString("F3") + "," + Y.ToString("F3") + ")";
        }
#endif
    }
}
