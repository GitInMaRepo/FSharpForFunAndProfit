using System;

namespace AFewSimpleThingsFirst
{
    public class SquareCalculatorCSharp
    {
        public int SquaresFromOneTo(int upper)
        {
            var result = 0;
            for(int x = 1; x <= upper; x++)
            {
                result += Square(x);
            }
            return result;
        }

        private static int Square(int x)
        {
            return x * x;
        }
    }
}