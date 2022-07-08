using System;
using System.Collections.Generic;

namespace SharpVoronoiLib
{
    public static class ListShifter
    {
        /// <summary>
        /// Rotates the given <see cref="list"/> elements by the given <see cref="shift"/> amount.
        /// That is, [1 2 3 4 5 6 7] shifted by 2 becomes [6 7 1 2 3 4 5].
        /// This works in the right direction (elements move to increasing index positions) with a positive shift value.
        /// This works in the left direction as well with a negative shift value.
        /// Shifting by 0 or list length doesn't do anything.
        /// Shifting a list with 0 or 1 elements doesn't do anything.
        /// Shifting by more than the list count only shifts the necessary amount ignoring the "full rotations".
        /// This algorithm is O(N) swapping each element once and uses no allocations, i.e. O(1) extra space.
        /// </summary>
        public static void ShiftBy<T>(this IList<T> list, int shift)
        {
            // From https://stackoverflow.com/a/70437221/8047867
            // https://stackoverflow.com/a/18154984/8047867 includes a lengthy explanation (but uses GCD that this doesn't need)

            if (list == null) throw new ArgumentNullException(nameof(list));
            
            
            int count = list.Count;
            
            if (count <= 1)
                return;
            
            shift %= count;
            
            shift = (shift + count) % count; // Ensure shift is positive
            
            if (shift == 0)
                return;
            
            int i = 0;
            int i0 = 0;

            T x = list[0];
            
            for (int u = 0; u < count; u++)
            {
                // Count number of shifted elements
                int j = (i - shift + count) % count; // ensure modulo is positive
                
                if (j == i0)
                {
                    // End of a (sub-)cycle, advance to next one
                    list[i] = x;
                    x = list[i = ++i0];
                }
                else
                {
                    list[i] = list[j];
                    i = j;
                }
            }
        }
    }
}