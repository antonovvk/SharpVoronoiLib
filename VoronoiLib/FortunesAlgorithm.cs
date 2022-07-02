using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using VoronoiLib.Structures;

namespace VoronoiLib
{
    public static class FortunesAlgorithm
    {
        public static LinkedList<VEdge> Run(List<FortuneSite> sites, double minX, double minY, double maxX, double maxY, bool closeBorders = false)
        {
            var eventQueue = new MinHeap<FortuneEvent>(5*sites.Count);
            foreach (var s in sites)
            {
                eventQueue.Insert(new FortuneSiteEvent(s));
            }
            //init tree
            var beachLine = new BeachLine();
            var edges = new LinkedList<VEdge>();
            var deleted = new HashSet<FortuneCircleEvent>();

            //init edge list
            while (eventQueue.Count != 0)
            {
                var fEvent = eventQueue.Pop();
                if (fEvent is FortuneSiteEvent)
                    beachLine.AddBeachSection((FortuneSiteEvent) fEvent, eventQueue, deleted, edges);
                else
                {
                    if (deleted.Contains((FortuneCircleEvent) fEvent))
                    {
                        deleted.Remove((FortuneCircleEvent) fEvent);
                    }
                    else
                    {
                        beachLine.RemoveBeachSection((FortuneCircleEvent) fEvent, eventQueue, deleted, edges);
                    }
                }
            }
            

            //clip edges
            var edgeNode = edges.First;
            while (edgeNode != null)
            {
                var edge = edgeNode.Value;
                var next = edgeNode.Next;

                var valid = ClipEdge(edge, minX, minY, maxX, maxY);
                if (valid)
                {
                    edgeNode.Value.Left.AddEdge(edgeNode.Value);
                    edgeNode.Value.Right.AddEdge(edgeNode.Value);
                } else {
                    edges.Remove(edgeNode);
                }

                //advance
                edgeNode = next;
            }

            if (closeBorders)
                CloseBorders(edges, minX, minY, maxX, maxY, sites);

            return edges;
        }

        //combination of personal ray clipping alg and cohen sutherland
        private static bool ClipEdge(VEdge edge, double minX, double minY, double maxX, double maxY)
        {
            var accept = false;

            //if its a ray
            if (edge.End == null)
            {
                accept = ClipRay(edge, minX, minY, maxX, maxY);
            }
            else
            {
                //Cohen–Sutherland
                var start = ComputeOutCode(edge.Start.X, edge.Start.Y, minX, minY, maxX, maxY);
                var end = ComputeOutCode(edge.End.X, edge.End.Y, minX, minY, maxX, maxY);

                while (true)
                {
                    if ((start | end) == Outcode.None)
                    {
                        accept = true;
                        break;
                    }
                    if ((start & end) != Outcode.None)
                    {
                        break;
                    }

                    double x = -1, y = -1;
                    var outcode = start != Outcode.None ? start : end;

                    if (outcode.HasFlag(Outcode.Top))
                    {
                        x = edge.Start.X + (edge.End.X - edge.Start.X)*(maxY - edge.Start.Y)/(edge.End.Y - edge.Start.Y);
                        y = maxY;
                    }
                    else if (outcode.HasFlag(Outcode.Bottom))
                    {
                        x = edge.Start.X + (edge.End.X - edge.Start.X)*(minY - edge.Start.Y)/(edge.End.Y - edge.Start.Y);
                        y = minY;
                    }
                    else if (outcode.HasFlag(Outcode.Right))
                    {
                        y = edge.Start.Y + (edge.End.Y - edge.Start.Y)*(maxX - edge.Start.X)/(edge.End.X - edge.Start.X);
                        x = maxX;
                    }
                    else if (outcode.HasFlag(Outcode.Left))
                    {
                        y = edge.Start.Y + (edge.End.Y - edge.Start.Y)*(minX - edge.Start.X)/(edge.End.X - edge.Start.X);
                        x = minX;
                    }

                    if (outcode == start)
                    {
                        edge.Start = new VPoint(x, y, GetBorderLocationForCoordinate(x, y, minX, minY, maxX, maxY));
                        start = ComputeOutCode(x, y, minX, minY, maxX, maxY);
                    }
                    else
                    {
                        edge.End = new VPoint(x, y, GetBorderLocationForCoordinate(x, y, minX, minY, maxX, maxY));
                        end = ComputeOutCode(x, y, minX, minY, maxX, maxY);
                    }
                }
            }
            //if we have a neighbor
            if (edge.Neighbor != null)
            {
                //check it
                var valid = ClipEdge(edge.Neighbor, minX, minY, maxX, maxY);
                //both are valid
                if (accept && valid)
                {
                    edge.Start = edge.Neighbor.End;
                }
                //this edge isn't valid, but the neighbor is
                //flip and set
                if (!accept && valid)
                {
                    edge.Start = edge.Neighbor.End;
                    edge.End = edge.Neighbor.Start;
                    accept = true;
                }
            }
            return accept;
        }
        
        private static Outcode ComputeOutCode(double x, double y, double minX, double minY, double maxX, double maxY)
        {
            Outcode code = Outcode.None;
            if (x.ApproxEqual(minX) || x.ApproxEqual(maxX))
            { }
            else if (x < minX)
                code |= Outcode.Left;
            else if (x > maxX)
                code |= Outcode.Right;

            if (y.ApproxEqual(minY) || y.ApproxEqual(maxY))
            { }
            else if (y < minY)
                code |= Outcode.Bottom;
            else if (y > maxY)
                code |= Outcode.Top;
            return code;
        }

        private static PointBorderLocation GetBorderLocationForCoordinate(double x, double y, double minX, double minY, double maxX, double maxY)
        {
            if (x.ApproxEqual(minX) && y.ApproxEqual(minY)) return PointBorderLocation.BottomLeft;
            if (x.ApproxEqual(minX) && y.ApproxEqual(maxY)) return PointBorderLocation.TopLeft;
            if (x.ApproxEqual(maxX) && y.ApproxEqual(minY)) return PointBorderLocation.BottomRight;
            if (x.ApproxEqual(maxX) && y.ApproxEqual(maxY)) return PointBorderLocation.TopRight;
            
            if (x.ApproxEqual(minX)) return PointBorderLocation.Left;
            if (y.ApproxEqual(minY)) return PointBorderLocation.Bottom;
            if (x.ApproxEqual(maxX)) return PointBorderLocation.Right;
            if (y.ApproxEqual(maxY)) return PointBorderLocation.Top;
            
            return PointBorderLocation.NotOnBorder;
        }

        [Flags]
        private enum Outcode
        {
            None = 0x0,
            Left = 0x1,
            Right = 0x2,
            Bottom = 0x4,
            Top = 0x8
        }

        private static bool ClipRay(VEdge edge, double minX, double minY, double maxX, double maxY)
        {
            var start = edge.Start;
            //horizontal ray
            if (edge.SlopeRise.ApproxEqual(0))
            {
                if (!Within(start.Y, minY, maxY))
                    return false;
                if (edge.SlopeRun > 0 && start.X > maxX)
                    return false;
                if (edge.SlopeRun < 0 && start.X < minX)
                    return false;
                if (Within(start.X, minX, maxX))
                {
                    if (edge.SlopeRun > 0)
                        edge.End = new VPoint(maxX, start.Y, PointBorderLocation.Right);
                    else
                        edge.End = new VPoint(minX, start.Y, start.Y.ApproxEqual(minY) ? PointBorderLocation.BottomLeft : start.Y.ApproxEqual(maxY) ? PointBorderLocation.TopLeft : PointBorderLocation.Left);
                }
                else
                {
                    if (edge.SlopeRun > 0)
                    {
                        edge.Start = new VPoint(minX, start.Y, PointBorderLocation.Left);
                        edge.End = new VPoint(maxX, start.Y, PointBorderLocation.Right);
                    }
                    else
                    {
                        edge.Start = new VPoint(maxX, start.Y, PointBorderLocation.Right);
                        edge.End = new VPoint(minX, start.Y, PointBorderLocation.Left);
                    }
                }
                return true;
            }
            //vertical ray
            if (edge.SlopeRun.ApproxEqual(0))
            {
                if (start.X < minX || start.X > maxX)
                    return false;
                if (edge.SlopeRise > 0 && start.Y > maxY)
                    return false;
                if (edge.SlopeRise < 0 && start.Y < minY)
                    return false;
                if (Within(start.Y, minY, maxY))
                {
                    if (edge.SlopeRise > 0)
                        edge.End = new VPoint(start.X, maxY, start.X.ApproxEqual(minX) ? PointBorderLocation.TopLeft : start.X.ApproxEqual(maxX) ? PointBorderLocation.TopRight : PointBorderLocation.Top);
                    else
                        edge.End = new VPoint(start.X, minY, PointBorderLocation.Bottom);
                }
                else
                {
                    if (edge.SlopeRise > 0)
                    {
                        edge.Start = new VPoint(start.X, minY, PointBorderLocation.Bottom);
                        edge.End = new VPoint(start.X, maxY, PointBorderLocation.Top);
                    }
                    else
                    {
                        edge.Start = new VPoint(start.X, maxY, PointBorderLocation.Top);
                        edge.End = new VPoint(start.X, minY, PointBorderLocation.Bottom);
                    }
                }
                return true;
            }
            
            //works for outside
            Debug.Assert(edge.Slope != null, "edge.Slope != null");
            Debug.Assert(edge.Intercept != null, "edge.Intercept != null");

            double topXValue = CalcX(edge.Slope.Value, maxY, edge.Intercept.Value);
            VPoint topX = new VPoint(topXValue, maxY, topXValue.ApproxEqual(minX) ? PointBorderLocation.TopLeft : topXValue.ApproxEqual(maxX) ? PointBorderLocation.TopRight : PointBorderLocation.Top);

            double rightYValue = CalcY(edge.Slope.Value, maxX, edge.Intercept.Value);
            VPoint rightY = new VPoint(maxX, rightYValue, rightYValue.ApproxEqual(minY) ? PointBorderLocation.BottomRight : rightYValue.ApproxEqual(maxY) ? PointBorderLocation.TopRight : PointBorderLocation.Right);

            double bottomXValue = CalcX(edge.Slope.Value, minY, edge.Intercept.Value);
            VPoint bottomX = new VPoint(bottomXValue, minY, bottomXValue.ApproxEqual(minX) ? PointBorderLocation.BottomLeft : bottomXValue.ApproxEqual(maxX) ? PointBorderLocation.BottomRight : PointBorderLocation.Bottom);

            double leftYValue = CalcY(edge.Slope.Value, minX, edge.Intercept.Value);
            VPoint leftY = new VPoint(minX, leftYValue, leftYValue.ApproxEqual(minY) ? PointBorderLocation.BottomLeft : leftYValue.ApproxEqual(maxY) ? PointBorderLocation.TopLeft : PointBorderLocation.Left);

            // Note: these points may be duplicates if the ray goes through a border corner,
            // so we have to check for repeats when building the candidate list below.
            // We can optimize slightly since we are adding them one at a time and only "neighbouring" points can be the same,
            // e.g. topX and rightY can but not topX and bottomX.
            
            //reject intersections not within bounds
            
            var candidates = new List<VPoint>();

            bool withinTopX = Within(topX.X, minX, maxX);
            bool withinRightY = Within(rightY.Y, minY, maxY);
            bool withinBottomX = Within(bottomX.X, minX, maxX);
            bool withinLeftY = Within(leftY.Y, minY, maxY);

            if (withinTopX)
                candidates.Add(topX);

            if (withinRightY)
                if (!withinTopX || !rightY.ApproxEqual(topX))
                    candidates.Add(rightY);

            if (withinBottomX)
                if (!withinRightY || !bottomX.ApproxEqual(rightY))
                    candidates.Add(bottomX);

            if (withinLeftY)
                if (!withinTopX || !leftY.ApproxEqual(topX))
                    if (!withinBottomX || !leftY.ApproxEqual(bottomX))
                        candidates.Add(leftY);

            // This also works as a condition above, but is slower and checks against redundant values
            // if (candidates.All(c => !c.X.ApproxEqual(leftY.X) || !c.Y.ApproxEqual(leftY.Y)))
            

            //reject candidates which don't align with the slope
            for (var i = candidates.Count - 1; i > -1; i--)
            {
                var candidate = candidates[i];
                //grab vector representing the edge
                var ax = candidate.X - start.X;
                var ay = candidate.Y - start.Y;
                if (edge.SlopeRun*ax + edge.SlopeRise*ay < 0)
                    candidates.RemoveAt(i);
            }

            //if there are two candidates we are outside the closer one is start
            //the further one is the end
            if (candidates.Count == 2)
            {
                var ax = candidates[0].X - start.X;
                var ay = candidates[0].Y - start.Y;
                var bx = candidates[1].X - start.X;
                var by = candidates[1].Y - start.Y;
                if (ax*ax + ay*ay > bx*bx + by*by)
                {
                    edge.Start = candidates[1];
                    edge.End = candidates[0];
                }
                else
                {
                    edge.Start = candidates[0];
                    edge.End = candidates[1];
                }
            }

            //if there is one candidate we are inside
            if (candidates.Count == 1)
                edge.End = candidates[0];

            //there were no candidates
            return edge.End != null;
        }

        private static bool Within(double x, double a, double b)
        {
            return x.ApproxGreaterThanOrEqualTo(a) && x.ApproxLessThanOrEqualTo(b);
        }

        private static double CalcY(double m, double x, double b)
        {
            return m * x + b;
        }

        private static double CalcX(double m, double y, double b)
        {
            return (y - b) / m;
        }
        
        private static void CloseBorders(LinkedList<VEdge> edges, double minX, double minY, double maxX, double maxY, List<FortuneSite> sites)
        {
            BorderNodeComparer comparer = new BorderNodeComparer(
                (minX + maxX) / 2f, 
                (minY + maxY) / 2f
            );

            SortedSet<BorderNode> nodes = new SortedSet<BorderNode>(comparer);

            bool hadBottomLeft = false;
            bool hadBottomRight = false;
            bool hadTopRight = false;
            bool hadTopLeft = false;
            
            LinkedListNode<VEdge> edgeNode = edges.First;

            while (edgeNode != null)
            {
                VEdge edge = edgeNode.Value;
                
                if (edge.Start.BorderLocation != PointBorderLocation.NotOnBorder)
                {
                    nodes.Add(new EdgeStartBorderNode(edge));

                    if (edge.Start.BorderLocation == PointBorderLocation.BottomLeft) hadBottomLeft = true;
                    else if (edge.Start.BorderLocation == PointBorderLocation.BottomRight) hadBottomRight = true;
                    else if (edge.Start.BorderLocation == PointBorderLocation.TopRight) hadTopRight = true;
                    else if (edge.Start.BorderLocation == PointBorderLocation.TopLeft) hadTopLeft = true;
                }
                
                if (edge.End.BorderLocation != PointBorderLocation.NotOnBorder)
                {
                    nodes.Add(new EdgeEndBorderNode(edge));
                    
                    if (edge.End.BorderLocation == PointBorderLocation.BottomLeft) hadBottomLeft = true;
                    else if (edge.End.BorderLocation == PointBorderLocation.BottomRight) hadBottomRight = true;
                    else if (edge.End.BorderLocation == PointBorderLocation.TopRight) hadTopRight = true;
                    else if (edge.End.BorderLocation == PointBorderLocation.TopLeft) hadTopLeft = true;
                }
                
                edgeNode = edgeNode.Next;
            }
            
            if (!hadBottomLeft) nodes.Add(new CornerBorderNode(new VPoint(minX, minY, PointBorderLocation.BottomLeft)));
            if (!hadBottomRight) nodes.Add(new CornerBorderNode(new VPoint(maxX, minY, PointBorderLocation.BottomRight)));
            if (!hadTopRight) nodes.Add(new CornerBorderNode(new VPoint(maxX, maxY, PointBorderLocation.TopRight)));
            if (!hadTopLeft) nodes.Add(new CornerBorderNode(new VPoint(minX, maxY, PointBorderLocation.TopLeft)));


            EdgeBorderNode lastEdgeNode = null;

            if (nodes.Min is EdgeBorderNode febn)
                lastEdgeNode = febn;

            if (lastEdgeNode == null)
            {
                foreach (BorderNode node in nodes.Reverse())
                {
                    if (node is EdgeBorderNode rebn)
                    {
                        lastEdgeNode = rebn;
                        break;
                    }
                }
            }

            FortuneSite defaultSite = null;
            if (lastEdgeNode == null)
            {
                // We have no edges within bounds

                if (sites.Count > 0)
                {
                    // But we have site(s), so it's possible a site is in the bounds
                    // (two sites couldn't be or there would be an edge)
                    
                    defaultSite = sites.FirstOrDefault(s =>
                                                           s.X.ApproxGreaterThanOrEqualTo(minX) &&
                                                           s.X.ApproxLessThanOrEqualTo(maxX) &&
                                                           s.Y.ApproxGreaterThanOrEqualTo(minY) &&
                                                           s.Y.ApproxLessThanOrEqualTo(maxY)
                    );
                }
            }
            
            BorderNode node2 = null; // i.e. last node
            
            foreach (BorderNode node in nodes)
            {
                BorderNode node1 = node2;
                node2 = node;

                if (node1 == null) // i.e. node == nodes.Min
                    continue; // we are looking at first node, we will start from Min and next one

                FortuneSite site = lastEdgeNode != null ? lastEdgeNode is EdgeStartBorderNode ? lastEdgeNode.Edge.Right : lastEdgeNode.Edge.Left : defaultSite;

                VEdge newEdge = new VEdge(
                    node1.Point, 
                    node2.Point, 
                    null, // we are building these clockwise, so by definition the left side is out of bounds
                    site
                );
                
                edges.AddLast(newEdge);
                
                if (site != null)
                    site.Cell.Add(newEdge);
                
                if (node is EdgeBorderNode cebn)
                    lastEdgeNode = cebn;
            }

            FortuneSite finalSite = lastEdgeNode != null ? lastEdgeNode is EdgeStartBorderNode ? lastEdgeNode.Edge.Right : lastEdgeNode.Edge.Left : defaultSite;

            VEdge finalEdge = new VEdge(
                nodes.Max.Point,
                nodes.Min.Point, 
                null, // we are building these clockwise, so by definition the left side is out of bounds
                finalSite
            );
            
            edges.AddLast(finalEdge);

            if (finalSite != null)
                finalSite.Cell.Add(finalEdge);
        }

        private abstract class BorderNode
        {
            public abstract PointBorderLocation BorderLocation { get; }

            public abstract VPoint Point { get; }


#if DEBUG
            public override string ToString()
            {
                return Point + " @ " + BorderLocation;
            }
            
            public string ToString(string format)
            {
                return Point.ToString(format) + " @ " + BorderLocation;
            }
#endif
        }

        private abstract class EdgeBorderNode : BorderNode
        {
            public VEdge Edge { get; }


            protected EdgeBorderNode(VEdge edge)
            {
                this.Edge = edge;
            }
        }

        private class EdgeStartBorderNode : EdgeBorderNode
        {
            public override PointBorderLocation BorderLocation => Edge.Start.BorderLocation;

            public override VPoint Point => Edge.Start;
            
            
            public EdgeStartBorderNode(VEdge edge)
                : base(edge)
            {
            }
        }

        private class EdgeEndBorderNode : EdgeBorderNode
        {
            public override PointBorderLocation BorderLocation => Edge.End.BorderLocation;

            public override VPoint Point => Edge.End;
            
            
            public EdgeEndBorderNode(VEdge edge)
                : base(edge)
            {
            }
        }

        private class CornerBorderNode : BorderNode
        {
            public override PointBorderLocation BorderLocation { get; }

            public override VPoint Point { get; }


            public CornerBorderNode(VPoint point)
            {
                BorderLocation = point.BorderLocation;
                Point = point;
            }
        }

        private class BorderNodeComparer : IComparer<BorderNode>
        {
            private readonly double _originX;
            private readonly double _originY;

            
            public BorderNodeComparer(double originX, double originY)
            {
                this._originX = originX;
                this._originY = originY;
            }
            
            
            public int Compare(BorderNode n1, BorderNode n2)
            {
                int locationCompare = n1.BorderLocation.CompareTo(n2.BorderLocation);

                if (locationCompare != 0)
                    return locationCompare;

                return FortuneSite.SortPointsClockwise(n1.Point, n2.Point, _originX, _originY);
            }
        }
    }
}
