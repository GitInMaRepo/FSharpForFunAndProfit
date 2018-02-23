using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ExerciseThree
{
    [TestClass]
    public class ExerciseThree
    {
        [TestMethod]
        public void BuildProductOverList()
        {

            var targetCSharp = new CalculatorCSharp();
            targetCSharp
                .DoProductsOverallOn(new List<int> { 1, 7, 3, 2, 5, 9 })
                .Should()
                .Be(1990);
        }

        [TestMethod]
        public void BuildProductOfOddNumbersInList()
        {

            var targetCSharp = new CalculatorCSharp();
            targetCSharp
                .DoProductsOfOddsOn(new List<int> { 1, 3, 2, 4, 9 })
                .Should()
                .Be(27);
        }

        [TestMethod]
        public void BuildAlternatingSumInList()
        {

            var targetCSharp = new CalculatorCSharp();
            targetCSharp
                .DoAlternatingSumOn(new List<int> { 1, 7, 3, 2, 5, 9 })
                .Should()
                .Be(11);
        }
    }
}
