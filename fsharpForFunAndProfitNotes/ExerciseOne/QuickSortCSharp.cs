using System;
using System.Collections.Generic;

namespace ExerciseOne
{
    internal class QuickSortCSharp
    {
        internal List<int> DoQuickSortOn(List<int> list)
        {
            if(list.Count == 0)
            {
                return new List<int>();
            }

            var first = list[0];

            List<int> smallerValues = new List<int>();
            List<int> largerValues = new List<int>();

            for (int x = 1; x < list.Count; x++)
            {
                if(list[x] < first)
                {
                    smallerValues.Add(list[x]);
                }
                else
                {
                    largerValues.Add(list[x]);
                }
            }

            List<int> result = new List<int>();
            result.AddRange(DoQuickSortOn(smallerValues));
            result.Add(first);
            result.AddRange(DoQuickSortOn(largerValues));

            return result;
        }
    }
}