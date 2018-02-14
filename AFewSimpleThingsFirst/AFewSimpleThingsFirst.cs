using FluentAssertions;
using FSharpImplementations;
using Microsoft.FSharp.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace AFewSimpleThingsFirst
{
    [TestClass]
    public class AFewSimpleThingsFirst
    {
        [TestMethod]
        public void TheSumOfAllSquaresFrom1To4In_CSharp()
        {
            var targetCSharp = new SquareCalculatorCSharp();
            targetCSharp.SquaresFromOneTo(4).Should().Be(30);
        }

        [TestMethod]
        public void TheSumOfAllSquaresFrom1To4In_FSharp()
        {
            var targetFSharp = new SquareCalculatorFSharp();
            targetFSharp.SquaresFromOneTo(4).Should().Be(30);
        }

        [TestMethod]
        public void AQuickSortOnARangeOfValues_CSharp()
        {
            var targetCSharp = new QuickSortCSharp();
            targetCSharp
                .DoQuickSortOn(new List<int> { 1, 7, 3, 15, 54, 12, 2, 5, 9 })
                .Should()
                .BeEquivalentTo(new List<int> { 1, 2, 3, 5, 7, 9, 12, 15, 54 });
        }

        [TestMethod]
        public void AQuickSortOnARangeOfValues_CSharp_AlternateVersion()
        {
            var targetCSharp = new QuickSortCSharp();
            targetCSharp
                .DoQuickSortOnAlternative(new List<int> { 1, 7, 3, 15, 54, 12, 2, 5, 9 })
                .Should()
                .BeEquivalentTo(new List<int> { 1, 2, 3, 5, 7, 9, 12, 15, 54 });
        }

        [TestMethod]
        public void AQuickSortOnARangeOfValues_CSharp_ViaExtensionMethod()
        {
                (new List<int> { 1, 7, 3, 15, 54, 12, 2, 5, 9 })
                .DoQuickSort()
                .Should()
                .BeEquivalentTo(new List<int> { 1, 2, 3, 5, 7, 9, 12, 15, 54 });
        }

        [TestMethod]
        public void AQuickSortOnARangeOfValues_FSharp()
        {
            var targetFSharp = new QuickSortFSharp();
            targetFSharp
                .DoQuickSortOn(ListModule.OfSeq(new List<int> { 1, 7, 3, 15, 54, 12, 2, 5, 9 }))
                .ToList()
                .Should()
                .BeEquivalentTo(new List<int> { 1, 2, 3, 5, 7, 9, 12, 15, 54 });
        }

        [TestMethod]
        public void AQuickSortOnARangeOfValues_FSharp_AlternateVersion()
        {
            var targetFSharp = new QuickSortFSharp();
            targetFSharp
                .DoQuickSortOnAlternative(ListModule.OfSeq(new List<int> { 1, 7, 3, 15, 54, 12, 2, 5, 9 }))
                .ToList()
                .Should()
                .BeEquivalentTo(new List<int> { 1, 2, 3, 5, 7, 9, 12, 15, 54 });
        }

        [TestMethod]
        public void AQuickSortOnARangeOfValues_FSharp_ShortVersion()
        {
            var targetFSharp = new QuickSortFSharp();
            targetFSharp
                .QuickSort(ListModule.OfSeq(new List<int> { 1, 7, 3, 15, 54, 12, 2, 5, 9 }))
                .ToList()
                .Should()
                .BeEquivalentTo(new List<int> { 1, 2, 3, 5, 7, 9, 12, 15, 54 });
        }
    }
}
