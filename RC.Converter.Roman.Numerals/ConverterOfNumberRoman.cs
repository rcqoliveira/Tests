using System;
using System.Collections.Generic;
using System.Text;

namespace RC.Converter.Roman.Numerals
{
    public class ConverterOfNumberRoman
    {
        private readonly Dictionary<string, int> tableOfNumberRoman = new Dictionary<string, int>()
        {
            { "I", 1 },
            { "V", 5 },
            { "X", 10 },
            { "L", 50 },
            { "C", 100 },
            { "D", 500 },
            { "M", 1000 }
        };

        public int ToConvert(string numberInRoman)
        {
            int acumulator = 0;
            int lastNumberOnTheRight = 0;

            for (int i = numberInRoman.Length - 1; i >= 0; i--)
            {
                int current = tableOfNumberRoman[numberInRoman[i].ToString()];
                int multiplier = 1;

                if (current < lastNumberOnTheRight) multiplier = -1;
                acumulator += current * multiplier;
                lastNumberOnTheRight = current;
            }

            return acumulator;
        }
    }
}
