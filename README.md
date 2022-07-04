# VoronoiLib

C# implementation of generating a Voronoi diagram from a set of points in a plane (using Fortune's Algorithm) with edge clipping and optional border closure. This implementation guarantees O(n×ln(n)) performance.

The key differences from the [original repo](https://github.com/Zalgo2462/VoronoiLib)
* Borders can be closed, that is, edges generated along the boundary
* Edges can correctly go through boundary corners without generating invalid data
* Edges and points/sites contain additional useful data
* (Rare bug fixed that caused infinite loop or invalid data)[url]
* Lots more unit testing

Known issues:
* More than 3 equidistant sites will create a 0-length edge instead of 3+ edges meeting at the same point. This is rare since even the tiniest difference will create a non-0-length edge. So this is only an annoying issue if working with an evenly-spaced smaller grid where equidistant points are common and wanting to traverse the edge graph.
* The algorithm uses a lot of allocations, forcing garbage collection
* There is no visual output/example since the original used MonoGame

# Example

TODO: image

# Dependencies

The library (VoronoiLib) is compiled for .NET standard 1.1. As such, projects should be able to be built on Linux or OS X.

# Use

Quick-start:

```
IEnumerable<VoronoiSite> sites = new List<VoronoiSite>
{
    new FortuneSite(300, 300),
    new FortuneSite(300, 400),
    new FortuneSite(400, 300)
};

LinkedList<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(
    sites, 
    0, 0, 
    600, 600
);
```

The returned collection contains the generated edges as `VoronoiEdge`s.
`VoronoiEdge.Start` and `.End` are the start and end points of the edge.
`VoronoiEdge.Right` and `.Left` are the sites the edge encloses. Border edges move clockwise and will only have the `.Right` site. And if no points are within the region, both will be `null`.
Edge end `VoronoiPoint`s also contain a `.BorderLocation` specifying if it's on a border and which one.
`VoronoiEdge.Neighbours` (on-demand) are edges directly "connecting" to this edge, basically creating a traversable edge graph.
`FortuneSite.Cell` contains the edges that enclose the site (starting from the bottom-left "corner").
`FortuneSite.ClockwiseCell` (on-demand) contains these edges sorted clockwise (starting from the bottom-left "corner" end point).
`FortuneSite.Neighbors` contains the site's neighbors (in the Delaunay Triangulation), that is, other sites across its edges.
`FortuneSite.Points` (on-demand) contains points of the cell, that is, edge end points / edge nodes.
`FortuneSite.ClockwisePoints` (on-demand) contains these points sorted clockwise (starting from the bottom-left "corner").

If closing borders around the boundary is not desired (leaving sites with unclosed cells/polygons):

```
LinkedList<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(
    sites, 
    0, 0, 
    600, 600,
    BorderEdgeGeneration.DoNotMakeBorderEdges
);
```

Full syntax (leaving a reusable `VoronoiPlane` instance):

```
VoronoiPlane plane = new VoronoiPlane(
    sites, 
    0, 0, 
    600, 600
);

plane.Tessellate();
```

# Credits

- [Originally written by Logan Lembke](https://github.com/Zalgo2462/VoronoiLib)
- [Updated with unit tests and nuget package by Sean Esopenko](https://github.com/sesopenko/VoronoiLib)
- [Improvements by Jeffrey Jones](https://github.com/rurounijones/VoronoiLib)
- Various code pieces atributed inline

Original implementation inspired by:
- [Ivan Kuckir's project](http://blog.ivank.net/fortunes-algorithm-and-implementation.html)
- [Raymond Hill's project](https://github.com/gorhill/Javascript-Voronoi)