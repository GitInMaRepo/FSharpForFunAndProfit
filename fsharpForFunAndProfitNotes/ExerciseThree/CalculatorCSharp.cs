using System;
using System.Collections.Generic;

namespace ExerciseThree
{
    internal class CalculatorCSharp
    {
        internal int DoProductsOverallOnOneTo(int input)
        {
            var result = 1;
            for(int x = 1; x <= input; x++)
            {
                result *= x;
            }
            return result;
        }

        internal int DoSumsOfOddsOnOneTo(int input)
        {
            var result = 0;
            for (int x = 1; x <= input; x++)
            {
                if (x % 2 != 0)
                {
                    result += x;
                };
            }
            return result;
        }

        internal int DoAlternatingSumOnOneTo(int input)
        {
            var result = 0;
            for (int x = 1; x <= input; x++)
            {
                if (x % 2 == 0)
                {
                    result += x;
                }
                else
                {
                    result -= x;
                };
            }
            return result;
        }
    }
}