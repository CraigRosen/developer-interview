using System;
using System.Collections.Generic;
using System.Text;

namespace Mednax.DeveloperInterview.TDD
{
    /// <summary>
    /// Write a program that prints the numbers from 1 to 100. But for multiples of three print "Fizz"
    /// instead of the number and for the multiples of five print "Buzz". For numbers which are multiples
    /// of both three and five print "FizzBuzz".
    /// i.e.:  "1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz 16 ..."
    /// </summary>
    public class FizzBuzz
    {

        public string PrintNumbers(int number)
        {
            var result = new List<string>();
            for (int i = 1; i <= number; i++)
            {
                StringBuilder b = new StringBuilder();

                if (i % 3 == 0)
                    b.Append("Fizz");

                if (i % 5 == 0)
                    b.Append("Buzz");

                if (b.Length == 0)
                    b.Append(i.ToString());

                result.Add(b.ToString());
            }

            return string.Join(" ", result);
        }
    }
}