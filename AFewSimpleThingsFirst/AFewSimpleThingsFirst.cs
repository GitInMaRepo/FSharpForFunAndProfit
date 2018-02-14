using FluentAssertions;
using FSharpImplementations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AFewSimpleThingsFirst
{
    [TestClass]
    public class AFewSimpleThingsFirst
    {
        [TestMethod]
        public void TheSumOfAllSquaresFrom1To4()
        {
            var targetCSharp = new SquareCalculatorCSharp();
            var targetFSharp = new SquareCalculatorFSharp();

            targetCSharp.SquaresFromOneTo(4).Should().Be(30);
            targetFSharp.SquaresFromOneTo(4).Should().Be(30);
        }
    }
}
