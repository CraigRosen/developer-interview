using System;
using System.Collections.Generic;

namespace Mednax.DeveloperInterview.TDD
{
    /// <summary>
    /// Write a program that prints the numbers from 1 to 100. But for multiples of three print "Fizz"
    /// instead of the number and for the multiples of five print "Buzz". For numbers which are multiples
    /// of both three and five print "FizzBuzz".
    /// i.e.:  "1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz 16 ..."
    /// </summary>
    public class FizzBuzz : IFizzBuzz
    {
        public const string FIZZ = "Fizz";
        public const string BUZZ = "Buzz";
        public const string FIZZBUZZ = FIZZ + BUZZ;

        string[] IFizzBuzz.DoFizzBuzz()
        {
            var result = new List<string>();

            for (int i = 1; i <= 100; i++)
            {
                if (i % 15 == 0)
                {
                    result.Add(FIZZBUZZ);
                }
                else if (i % 5 == 0)
                {
                    result.Add(BUZZ);
                }
                else if (i % 3 == 0)
                {
                    result.Add(FIZZ);
                }
                else
                {
                    result.Add(i.ToString());
                }
            }

            return result.ToArray();
        }
    }

    public interface IFizzBuzz
    {
        string[] DoFizzBuzz();
    }
}