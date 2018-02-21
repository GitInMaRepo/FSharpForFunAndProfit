using System;
using System.Collections.Generic;
using System.Linq;

namespace ExerciseOne
{
    internal class QuickSortCSharp
    {
        internal IEnumerable<int> DoQuickSortOn(IEnumerable<int> list)
        {
            if(!list.Any())
            {
                return new List<int>();
            }

            var first = list.First();
            var rest = list.Skip(1);

            var smallerValues = rest
                                    .Where(f => f < first)
                                    .ToList();
            var largerValues = rest
                                    .Where(f => f >= first)
                                    .ToList();

            return DoQuickSortOn(smallerValues)
                .Concat(new List<int> {first})
                .Concat(DoQuickSortOn(largerValues));
        }
    }

    public static class QuickSortExtensions
    {
        public static IEnumerable<int> QuickSort(this IEnumerable<int> list)
        {
            if (!list.Any())
            {
                return new List<int>();
            }

            var first = list.First();
            var rest = list.Skip(1);

            var smallerValues = rest
                                    .Where(f => f < first)
                                    .QuickSort();
            var largerValues = rest
                                    .Where(f => f >= first)
                                    .QuickSort();

            return smallerValues    
                            .Concat(new List<int> { first })
                            .Concat(largerValues);

        }
    }
}