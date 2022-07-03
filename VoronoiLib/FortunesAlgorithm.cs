using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using JetBrains.Annotations;
using VoronoiLib.Structures;

namespace VoronoiLib
{
    public class FortunesAlgorithm
    {
        [PublicAPI]
        public double MinX { get; }
        
        [PublicAPI]
        public double MinY { get; }
        
        [PublicAPI]
        public double MaxX { get; }
        
        [PublicAPI]
        public double MaxY { get; }
        

        public FortunesAlgorithm(double minX, double minY, double maxX, double maxY)
        {
            if (minX >= maxX) throw new ArgumentException();
            if (minY >= maxY) throw new ArgumentException();
            

            MinX = minX;
            MinY = minY;
            MaxX = maxX;
            MaxY = maxY;
        }


        [PublicAPI]
        public static LinkedList<VoronoiEdge> RunOnce(IEnumerable<VoronoiSite> sites, double minX, double minY, double maxX, double maxY, BorderEdgeGeneration borderGeneration)
        {
            if (sites == null) throw new ArgumentNullException(nameof(sites));
            

            return new FortunesAlgorithm(minX, minY, maxX, maxY).Run(sites, borderGeneration);
        }

        [PublicAPI]
        public LinkedList<VoronoiEdge> Run(IEnumerable<VoronoiSite> sites, BorderEdgeGeneration borderGeneration)
        {
            if (sites == null) throw new ArgumentNullException(nameof(sites));
            
            
            MinHeap<FortuneEvent> eventQueue = new MinHeap<FortuneEvent>(5*sites.Count());
            
            foreach (VoronoiSite site in sites)
            {
                if (site == null) throw new ArgumentNullException(nameof(sites));
                
                eventQueue.Insert(new FortuneSiteEvent(site));
            }
            
            
            //init tree
            BeachLine beachLine = new BeachLine();
            LinkedList<VoronoiEdge> edges = new LinkedList<VoronoiEdge>();
            HashSet<FortuneCircleEvent> deleted = new HashSet<FortuneCircleEvent>();

            //init edge list
            while (eventQueue.Count != 0)
            {
                FortuneEvent fEvent = eventQueue.Pop();
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
            LinkedListNode<VoronoiEdge> edgeNode = edges.First;
            while (edgeNode != null)
            {
                VoronoiEdge edge = edgeNode.Value;
                LinkedListNode<VoronoiEdge> next = edgeNode.Next;

                bool valid = ClipEdge(edge, MinX, MinY, MaxX, MaxY);
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

            if (borderGeneration == BorderEdgeGeneration.MakeBorderEdges)
                CloseBorders(edges, MinX, MinY, MaxX, MaxY, sites);

            return edges;
        }

        //combination of personal ray clipping alg and cohen sutherland
        private static bool ClipEdge(VoronoiEdge edge, double minX, double minY, double maxX, double maxY)
        {
            bool accept = false;

            //if its a ray
            if (edge.End == null)
            {
                accept = ClipRay(edge, minX, minY, maxX, maxY);
            }
            else
            {
                //Cohen–Sutherland
                Outcode start = ComputeOutCode(edge.Start.X, edge.Start.Y, minX, minY, maxX, maxY);
                Outcode end = ComputeOutCode(edge.End.X, edge.End.Y, minX, minY, maxX, maxY);

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
                    Outcode outcode = start != Outcode.None ? start : end;

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
                        edge.Start = new VoronoiPoint(x, y, GetBorderLocationForCoordinate(x, y, minX, minY, maxX, maxY));
                        start = ComputeOutCode(x, y, minX, minY, maxX, maxY);
                    }
                    else
                    {
                        edge.End = new VoronoiPoint(x, y, GetBorderLocationForCoordinate(x, y, minX, minY, maxX, maxY));
                        end = ComputeOutCode(x, y, minX, minY, maxX, maxY);
                    }
                }
            }
            //if we have a neighbor
            if (edge.LastBeachLineNeighbor != null)
            {
                //check it
                bool valid = ClipEdge(edge.LastBeachLineNeighbor, minX, minY, maxX, maxY);
                //both are valid
                if (accept && valid)
                {
                    edge.Start = edge.LastBeachLineNeighbor.End;
                }
                //this edge isn't valid, but the neighbor is
                //flip and set
                if (!accept && valid)
                {
                    edge.Start = edge.LastBeachLineNeighbor.End;
                    edge.End = edge.LastBeachLineNeighbor.Start;
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

        private static bool ClipRay(VoronoiEdge edge, double minX, double minY, double maxX, double maxY)
        {
            VoronoiPoint start = edge.Start;
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
                        edge.End = new VoronoiPoint(maxX, start.Y, PointBorderLocation.Right);
                    else
                        edge.End = new VoronoiPoint(minX, start.Y, start.Y.ApproxEqual(minY) ? PointBorderLocation.BottomLeft : start.Y.ApproxEqual(maxY) ? PointBorderLocation.TopLeft : PointBorderLocation.Left);
                }
                else
                {
                    if (edge.SlopeRun > 0)
                    {
                        edge.Start = new VoronoiPoint(minX, start.Y, PointBorderLocation.Left);
                        edge.End = new VoronoiPoint(maxX, start.Y, PointBorderLocation.Right);
                    }
                    else
                    {
                        edge.Start = new VoronoiPoint(maxX, start.Y, PointBorderLocation.Right);
                        edge.End = new VoronoiPoint(minX, start.Y, PointBorderLocation.Left);
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
                        edge.End = new VoronoiPoint(start.X, maxY, start.X.ApproxEqual(minX) ? PointBorderLocation.TopLeft : start.X.ApproxEqual(maxX) ? PointBorderLocation.TopRight : PointBorderLocation.Top);
                    else
                        edge.End = new VoronoiPoint(start.X, minY, PointBorderLocation.Bottom);
                }
                else
                {
                    if (edge.SlopeRise > 0)
                    {
                        edge.Start = new VoronoiPoint(start.X, minY, PointBorderLocation.Bottom);
                        edge.End = new VoronoiPoint(start.X, maxY, PointBorderLocation.Top);
                    }
                    else
                    {
                        edge.Start = new VoronoiPoint(start.X, maxY, PointBorderLocation.Top);
                        edge.End = new VoronoiPoint(start.X, minY, PointBorderLocation.Bottom);
                    }
                }
                return true;
            }
            
            //works for outside
            Debug.Assert(edge.Slope != null, "edge.Slope != null");
            Debug.Assert(edge.Intercept != null, "edge.Intercept != null");

            double topXValue = CalcX(edge.Slope.Value, maxY, edge.Intercept.Value);
            VoronoiPoint topX = new VoronoiPoint(topXValue, maxY, topXValue.ApproxEqual(minX) ? PointBorderLocation.TopLeft : topXValue.ApproxEqual(maxX) ? PointBorderLocation.TopRight : PointBorderLocation.Top);

            double rightYValue = CalcY(edge.Slope.Value, maxX, edge.Intercept.Value);
            VoronoiPoint rightY = new VoronoiPoint(maxX, rightYValue, rightYValue.ApproxEqual(minY) ? PointBorderLocation.BottomRight : rightYValue.ApproxEqual(maxY) ? PointBorderLocation.TopRight : PointBorderLocation.Right);

            double bottomXValue = CalcX(edge.Slope.Value, minY, edge.Intercept.Value);
            VoronoiPoint bottomX = new VoronoiPoint(bottomXValue, minY, bottomXValue.ApproxEqual(minX) ? PointBorderLocation.BottomLeft : bottomXValue.ApproxEqual(maxX) ? PointBorderLocation.BottomRight : PointBorderLocation.Bottom);

            double leftYValue = CalcY(edge.Slope.Value, minX, edge.Intercept.Value);
            VoronoiPoint leftY = new VoronoiPoint(minX, leftYValue, leftYValue.ApproxEqual(minY) ? PointBorderLocation.BottomLeft : leftYValue.ApproxEqual(maxY) ? PointBorderLocation.TopLeft : PointBorderLocation.Left);

            // Note: these points may be duplicates if the ray goes through a border corner,
            // so we have to check for repeats when building the candidate list below.
            // We can optimize slightly since we are adding them one at a time and only "neighbouring" points can be the same,
            // e.g. topX and rightY can but not topX and bottomX.
            
            //reject intersections not within bounds
            
            List<VoronoiPoint> candidates = new List<VoronoiPoint>();

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
            for (int i = candidates.Count - 1; i > -1; i--)
            {
                VoronoiPoint candidate = candidates[i];
                //grab vector representing the edge
                double ax = candidate.X - start.X;
                double ay = candidate.Y - start.Y;
                if (edge.SlopeRun*ax + edge.SlopeRise*ay < 0)
                    candidates.RemoveAt(i);
            }

            //if there are two candidates we are outside the closer one is start
            //the further one is the end
            if (candidates.Count == 2)
            {
                double ax = candidates[0].X - start.X;
                double ay = candidates[0].Y - start.Y;
                double bx = candidates[1].X - start.X;
                double by = candidates[1].Y - start.Y;
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
        
        private static void CloseBorders(LinkedList<VoronoiEdge> edges, double minX, double minY, double maxX, double maxY, IEnumerable<VoronoiSite> sites)
        {
            BorderNodeComparer comparer = new BorderNodeComparer();

            SortedSet<BorderNode> nodes = new SortedSet<BorderNode>(comparer);

            bool hadBottomLeft = false;
            bool hadBottomRight = false;
            bool hadTopRight = false;
            bool hadTopLeft = false;
            
            LinkedListNode<VoronoiEdge>? edgeNode = edges.First;

            while (edgeNode != null)
            {
                VoronoiEdge edge = edgeNode.Value;
                
                if (edge.Start.BorderLocation != PointBorderLocation.NotOnBorder)
                {
                    nodes.Add(new EdgeStartBorderNode(edge));

                    if (edge.Start.BorderLocation == PointBorderLocation.BottomLeft) hadBottomLeft = true;
                    else if (edge.Start.BorderLocation == PointBorderLocation.BottomRight) hadBottomRight = true;
                    else if (edge.Start.BorderLocation == PointBorderLocation.TopRight) hadTopRight = true;
                    else if (edge.Start.BorderLocation == PointBorderLocation.TopLeft) hadTopLeft = true;
                }
                
                if (edge.End!.BorderLocation != PointBorderLocation.NotOnBorder)
                {
                    nodes.Add(new EdgeEndBorderNode(edge));
                    
                    if (edge.End.BorderLocation == PointBorderLocation.BottomLeft) hadBottomLeft = true;
                    else if (edge.End.BorderLocation == PointBorderLocation.BottomRight) hadBottomRight = true;
                    else if (edge.End.BorderLocation == PointBorderLocation.TopRight) hadTopRight = true;
                    else if (edge.End.BorderLocation == PointBorderLocation.TopLeft) hadTopLeft = true;
                }
                
                edgeNode = edgeNode.Next;
            }
            
            if (!hadBottomLeft) nodes.Add(new CornerBorderNode(new VoronoiPoint(minX, minY, PointBorderLocation.BottomLeft)));
            if (!hadBottomRight) nodes.Add(new CornerBorderNode(new VoronoiPoint(maxX, minY, PointBorderLocation.BottomRight)));
            if (!hadTopRight) nodes.Add(new CornerBorderNode(new VoronoiPoint(maxX, maxY, PointBorderLocation.TopRight)));
            if (!hadTopLeft) nodes.Add(new CornerBorderNode(new VoronoiPoint(minX, maxY, PointBorderLocation.TopLeft)));


            EdgeBorderNode? previousEdgeNode = null;

            if (nodes.Min is EdgeBorderNode febn)
                previousEdgeNode = febn;

            if (previousEdgeNode == null)
            {
                foreach (BorderNode node in nodes.Reverse())
                {
                    if (node is EdgeBorderNode rebn)
                    {
                        previousEdgeNode = rebn;
                        break;
                    }
                }
            }

            VoronoiSite? defaultSite = null;
            if (previousEdgeNode == null)
            {
                // We have no edges within bounds

                if (sites.Any())
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

            // Edge tracking for neighbour recording
            VoronoiEdge firstEdge = null!; // to "loop" last edge back to first
            VoronoiEdge? previousEdge = null; // to connect each new edge to previous edge
            
            BorderNode? node2 = null; // i.e. last node
            
            foreach (BorderNode node in nodes)
            {
                BorderNode? node1 = node2;
                node2 = node;

                if (node1 == null) // i.e. node == nodes.Min
                    continue; // we are looking at first node, we will start from Min and next one

                VoronoiSite? site = previousEdgeNode != null ? previousEdgeNode is EdgeStartBorderNode ? previousEdgeNode.Edge.Right : previousEdgeNode.Edge.Left : defaultSite;

                VoronoiEdge newEdge = new VoronoiEdge(
                    node1.Point, 
                    node2.Point, 
                    null, // we are building these clockwise, so by definition the left side is out of bounds
                    site
                );

                // Record edge neighbours
                if (previousEdge != null)
                {
                    // Add the neighbours for the edge
                    newEdge.CounterclockwiseNeighbourBorder = previousEdge; // counter-clockwise = previous
                    previousEdge.ClockwiseNeighbourBorder = newEdge; // clockwise = next
                }
                else
                {
                    // Record the first created edge for the last edge to "loop" around
                    firstEdge = newEdge;
                }

                edges.AddLast(newEdge);
                
                if (site != null)
                    site.cell.Add(newEdge);
                
                if (node is EdgeBorderNode cebn)
                    previousEdgeNode = cebn;

                previousEdge = newEdge;
            }

            VoronoiSite? finalSite = previousEdgeNode != null ? previousEdgeNode is EdgeStartBorderNode ? previousEdgeNode.Edge.Right : previousEdgeNode.Edge.Left : defaultSite;

            VoronoiEdge finalEdge = new VoronoiEdge(
                nodes.Max.Point,
                nodes.Min.Point, 
                null, // we are building these clockwise, so by definition the left side is out of bounds
                finalSite
            );
            
            // Add the neighbours for the final edge
            finalEdge.CounterclockwiseNeighbourBorder = previousEdge; // counter-clockwise = previous
            previousEdge!.ClockwiseNeighbourBorder = finalEdge; // clockwise = next
            
            edges.AddLast(finalEdge);
            
            // And finish the neighbour edges by "looping" back to the first edge
            firstEdge.CounterclockwiseNeighbourBorder = finalEdge; // counter-clockwise = previous
            finalEdge.ClockwiseNeighbourBorder = firstEdge; // clockwise = next

            if (finalSite != null)
                finalSite.cell.Add(finalEdge);
        }

        private abstract class BorderNode
        {
            public abstract PointBorderLocation BorderLocation { get; }

            public abstract VoronoiPoint Point { get; }


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
            public VoronoiEdge Edge { get; }


            protected EdgeBorderNode(VoronoiEdge edge)
            {
                Edge = edge;
            }
        }

        private class EdgeStartBorderNode : EdgeBorderNode
        {
            public override PointBorderLocation BorderLocation => Edge.Start.BorderLocation;

            public override VoronoiPoint Point => Edge.Start;
            
            
            public EdgeStartBorderNode(VoronoiEdge edge)
                : base(edge)
            {
            }
        }

        private class EdgeEndBorderNode : EdgeBorderNode
        {
            public override PointBorderLocation BorderLocation => Edge.End.BorderLocation;

            public override VoronoiPoint Point => Edge.End;
            
            
            public EdgeEndBorderNode(VoronoiEdge edge)
                : base(edge)
            {
            }
        }

        private class CornerBorderNode : BorderNode
        {
            public override PointBorderLocation BorderLocation { get; }

            public override VoronoiPoint Point { get; }


            public CornerBorderNode(VoronoiPoint point)
            {
                BorderLocation = point.BorderLocation;
                Point = point;
            }
        }

        private class BorderNodeComparer : IComparer<BorderNode>
        {
            public int Compare(BorderNode n1, BorderNode n2)
            {
                int locationCompare = n1.BorderLocation.CompareTo(n2.BorderLocation);

                if (locationCompare != 0)
                    return locationCompare;

                switch (n1.BorderLocation)
                {
                    case PointBorderLocation.Left: // going up
                        return n1.Point.Y.CompareTo(n2.Point.Y);
                    
                    case PointBorderLocation.Top: // going right
                        return n1.Point.X.CompareTo(n2.Point.X);
                    
                    case PointBorderLocation.Right: // going down
                        return n2.Point.Y.CompareTo(n1.Point.Y);
                    
                    case PointBorderLocation.Bottom: // going left
                        return n2.Point.X.CompareTo(n1.Point.X);
                    
                    case PointBorderLocation.BottomLeft:
                    case PointBorderLocation.TopLeft:
                    case PointBorderLocation.TopRight:
                    case PointBorderLocation.BottomRight:
                    case PointBorderLocation.NotOnBorder:
                        throw new InvalidOperationException();
                        
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }
    }


    public enum BorderEdgeGeneration
    {
        DoNotMakeBorderEdges = 0,
        MakeBorderEdges = 1
    }
}
