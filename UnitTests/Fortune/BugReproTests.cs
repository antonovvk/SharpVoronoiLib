using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System;

namespace SharpVoronoiLib.UnitTests
{
    [TestFixture]
    [Parallelizable(ParallelScope.Self)]
    public class BugReproTests
    {
        /// <summary>
        /// Issue #2
        /// </summary>
        [Test]
        public void IncorrectNeighours()
        {
            // Arrange

            VoronoiSite site0 = new VoronoiSite(309.2762, 29.37344);
            VoronoiSite site1 = new VoronoiSite(498.7968, 410.0901);
            VoronoiSite site2 = new VoronoiSite(328.3032, 284.3138);
            VoronoiSite site3 = new VoronoiSite(25.5397, 184.688);
            VoronoiSite site4 = new VoronoiSite(373.5264, 73.77794);

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                site0,
                site1,
                site2,
                site3,
                site4
            };

            // Act

            VoronoiPlane.TessellateOnce(
                sites,
                0, 0, 500, 500
            );

            for (int i = 0; i < sites.Count; i++)
            {
                List<int> neighbor = new List<int>();
                foreach (VoronoiSite neighbour in sites[i].Neighbours)
                    neighbor.Add(sites.IndexOf(neighbour));

                Console.WriteLine("Site " + i + " neighbors are " + string.Join(", ", neighbor.Select(n => n.ToString())));
            }

            // This prints:
            // Site 0 neighbors are 4, 3, 2
            // Site 1 neighbors are 2, 4, 3         <-- incorrect, 3 and 4 shouldn't be here
            // Site 2 neighbors are 4, 0, 3, 1
            // Site 3 neighbors are 0, 2, 1         <-- incorrect, 1 shouldn't be here
            // Site 4 neighbors are 0, 2, 1         <-- incorrect, 1 shouldn't be here

            // Assert

            CollectionAssert.AreEquivalent(new[] { site2, site3, site4 }, site0.Neighbours);
            CollectionAssert.AreEquivalent(new[] { site2 }, site1.Neighbours);
            CollectionAssert.AreEquivalent(new[] { site0, site1, site3, site4 }, site2.Neighbours);
            CollectionAssert.AreEquivalent(new[] { site0, site2 }, site3.Neighbours);
            CollectionAssert.AreEquivalent(new[] { site0, site2 }, site4.Neighbours);
        }
    }
}