using System;
using System.Collections.Generic;

namespace SharpVoronoiLib
{
    public static class ListUtils
    {
        public static void ShiftBy<T>(this List<T> list, int amount)
        {
            if (list == null) throw new ArgumentNullException(nameof(list));
            
            
            if (list.Count <= 1)
                return;
            
            amount %= list.Count;
            
            if (amount == 0)
                return;

            // todo: proper algorithm, this actually turned out to be way more complicated to do without inserts/removals 

            if (amount > 0)
            {
                for (int i = 0; i < amount; i++)
                {
                    T last = list[list.Count - 1];

                    for (int k = list.Count - 1; k >= 1; k--)
                        list[k] = list[k - 1];

                    list[0] = last;
                }
            }
            else
            {
                for (int i = 0; i < -amount; i++)
                {
                    T last = list[0];

                    for (int k = 0; k < list.Count - 1; k++)
                        list[k] = list[k + 1];

                    list[list.Count - 1] = last;
                }
            }
        }
    }
}