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

        public static IEnumerable<int> DoQuickSortOnAlternative(this IEnumerable<int> source)
        {
            if(!source.Any())
            {
                return new List<int>();
            }

            int elementZero = source.First();
            var otherElements = source.Skip(1);

            var smallerElements = otherElements.Skip(1)
                                        .Where(f => f < elementZero)
                                        .DoQuickSortOnAlternative();
            var biggerElements = otherElements.Skip(1)
                                        .Where(f => f >= elementZero)
                                        .DoQuickSortOnAlternative();

            List<int> result = new List<int>();
            result.AddRange(DoQuickSortOnAlternative(smallerElements));
            result.Add(elementZero);
            result.AddRange(DoQuickSortOnAlternative(biggerElements));
            return result;
        }
    }
}