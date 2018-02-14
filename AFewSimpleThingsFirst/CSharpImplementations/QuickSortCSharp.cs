using System;
using System.Collections.Generic;
using System.Linq;

namespace AFewSimpleThingsFirst
{
    public class QuickSortCSharp
    {
        public List<int> DoQuickSortOn(List<int> list)
        {
            if(list.Count == 0)
            {
                return new List<int>();
            }
            int elementZero = list[0];
            List<int> smallerElements = new List<int>();
            List<int> largerElements = new List<int>();
            for(int counter = 1; counter < list.Count; counter++)
            {
                if(list[counter] < elementZero)
                {
                    smallerElements.Add(list[counter]);
                }
                if(list[counter] >= elementZero)
                {
                    largerElements.Add(list[counter]);
                }
            }
            List<int> result = new List<int>();
            result.AddRange(DoQuickSortOn(smallerElements));
            result.Add(elementZero);
            result.AddRange(DoQuickSortOn(largerElements));
            return result;
        }

        public List<int> DoQuickSortOnAlternative(List<int> list)
        {
            if (!list.Any())
            {
                return new List<int>();
            }
            int elementZero = list.First();
            var otherElements = list.Skip(1);
            var smallerElements = otherElements
                                .Where(f => f < elementZero)
                                .ToList();
            var largerElements = otherElements
                                .Where(f => f >= elementZero)
                                .ToList();
            List<int> result = new List<int>();
            result.AddRange(DoQuickSortOn(smallerElements));
            result.Add(elementZero);
            result.AddRange(DoQuickSortOn(largerElements));
            return result;
        }
    }

    public static class EnumerableExtensions
    {
        public static IEnumerable<int> DoQuickSort(this IEnumerable<int> source)
        {
            if (!source.Any())
            {
                return new List<int>();
            }
            int elementZero = source.First();
            var otherElements = source.Skip(1);
            var smallerElements = otherElements
                                .Where(f => f < elementZero)
                                .DoQuickSort();
            var largerElements = otherElements
                                .Where(f => f >= elementZero)
                                .DoQuickSort();
            return smallerElements
                .Concat(new List<int>() { elementZero })
                .Concat(largerElements);
        }
    }
}