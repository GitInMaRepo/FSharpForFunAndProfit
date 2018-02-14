using FluentAssertions;
using FSharpImplementations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AFewSimpleThingsFirst
{
    [TestClass]
    public class AFewSimpleThingsFirst
    {
        [TestMethod]
        public void TheSumOfAllSquaresFrom1To4InCSharp()
        {
            var target = new SquareCalculatorCSharp();
            target.SquaresFromOneTo(4).Should().Be(30);    
        }

        [TestMethod]
        public void TheSumOfAllSquaresFrom1To4InFSharp()
        {
            var target = new SquareCalculatorFSharp();
            target.SquaresFromOneTo<int, int>(4).Should().Be(30);
        }
    }
}
