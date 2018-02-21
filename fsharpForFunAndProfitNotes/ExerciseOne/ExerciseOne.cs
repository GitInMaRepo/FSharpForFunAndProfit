using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Microsoft.FSharp.Collections;
using FluentAssertions;
using System.Linq;

namespace ExerciseOne
{
    [TestClass]
    public class ExerciseOne
    {
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
        public void AQuickSortOnARangeOfValues_FSharp()
        {
            var targetFSharp = new fsharpForFunAndProfitNotes.QuickSortFSharp();
            targetFSharp
                .DoQuickSortOn(ListModule.OfSeq(new List<int> { 1, 7, 3, 15, 54, 12, 2, 5, 9 }))
                .ToList()
                .Should()
                .BeEquivalentTo(new List<int> { 1, 2, 3, 5, 7, 9, 12, 15, 54 });
        }
    }
}
