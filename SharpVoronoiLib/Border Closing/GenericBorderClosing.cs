using System;
using System.Collections.Generic;
using System.Linq;

namespace SharpVoronoiLib
{
    internal class GenericBorderClosing : IBorderClosingAlgorithm
    {
        public List<VoronoiEdge> Close(List<VoronoiEdge> edges, double minX, double minY, double maxX, double maxY, List<VoronoiSite> sites)
        {
            BorderNodeComparer comparer = new BorderNodeComparer();

            SortedSet<BorderNode> nodes = new SortedSet<BorderNode>(comparer);

            bool hadBottomLeft = false;
            bool hadBottomRight = false;
            bool hadTopRight = false;
            bool hadTopLeft = false;
            
            foreach (VoronoiEdge edge in edges)
            {
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
                    node2.Point, // we are building these clockwise, so by definition the left side is out of bounds
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

                edges.Add(newEdge);
                
                if (site != null)
                    site.cell.Add(newEdge);
                
                if (node is EdgeBorderNode cebn)
                    previousEdgeNode = cebn;

                previousEdge = newEdge;
            }

            VoronoiSite? finalSite = previousEdgeNode != null ? previousEdgeNode is EdgeStartBorderNode ? previousEdgeNode.Edge.Right : previousEdgeNode.Edge.Left : defaultSite;

            VoronoiEdge finalEdge = new VoronoiEdge(
                nodes.Max.Point,
                nodes.Min.Point, // we are building these clockwise, so by definition the left side is out of bounds
                finalSite
            );
            
            // Add the neighbours for the final edge
            finalEdge.CounterclockwiseNeighbourBorder = previousEdge; // counter-clockwise = previous
            previousEdge!.ClockwiseNeighbourBorder = finalEdge; // clockwise = next
            
            edges.Add(finalEdge);
            
            // And finish the neighbour edges by "looping" back to the first edge
            firstEdge.CounterclockwiseNeighbourBorder = finalEdge; // counter-clockwise = previous
            finalEdge.ClockwiseNeighbourBorder = firstEdge; // clockwise = next

            if (finalSite != null)
                finalSite.cell.Add(finalEdge);

            return edges;
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
}