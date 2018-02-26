using FluentAssertions;
using fsharpForFunAndProfitNotes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExerciseThree
{
    [TestClass]
    public class ExerciseThree
    {
        [TestMethod]
        public void BuildProductOverRangeCSharp()
        {
            var targetCSharp = new CalculatorCSharp();
            targetCSharp
                .DoProductsOverallOnOneTo(12)
                .Should()
                .Be(479001600);
        }

        [TestMethod]
        public void BuildProductOverRangeFSharp()
        {
            var targetFSharp = new CalculatorFSharp();
            targetFSharp
                .DoProductsOverallOnOneTo(12)
                .Should()
                .Be(479001600);
        }

        [TestMethod]
        public void BuildProductOfOddNumbersInListCSharp()
        {

            var targetCSharp = new CalculatorCSharp();
            targetCSharp
                .DoSumsOfOddsOnOneTo(12)
                .Should()
                .Be(36);
        }

        [TestMethod]
        public void BuildProductOfOddNumbersInListFSharp()
        {

            var targetFSharp = new CalculatorCSharp();
            targetFSharp
                .DoSumsOfOddsOnOneTo(12)
                .Should()
                .Be(36);
        }

        [TestMethod]
        public void BuildAlternatingSumInListCSharp()
        {

            var targetCSharp = new CalculatorCSharp();
            targetCSharp
                .DoAlternatingSumOnOneTo(12)
                .Should()
                .Be(6);
        }

        [TestMethod]
        public void BuildAlternatingSumInListFSharp()
        {

            var targetFSharp = new CalculatorFSharp();
            targetFSharp
                .DoAlternatingSumOnOneTo(12)
                .Item2
                .Should()
                .Be(6);
        }
    }
}
