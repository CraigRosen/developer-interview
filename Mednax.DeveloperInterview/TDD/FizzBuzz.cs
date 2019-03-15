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
    public class FizzBuzz
    {
        public List<String> GetResult()
        {
            List<String> result = new List<String>();

            for(int i = 1; i <= 100; i++ )
            {
                if(i % 3 == 0 && i % 5 == 0)
                {
                    result.Add("FizzBuzz");
                } else if (i % 3 == 0)
                {
                    result.Add("Fizz");
                } else if (i % 5 == 0)
                {
                    result.Add("Buzz");
                }
                else
                {
                    result.Add(i.ToString());
                }
                
            }

            return result;
        }
    }
}