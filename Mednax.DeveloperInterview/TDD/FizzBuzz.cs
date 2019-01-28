//using System;

//namespace Mednax.DeveloperInterview.TDD
//{
//    /// <summary>
//    /// Write a program that prints the numbers from 1 to 100. But for multiples of three print "Fizz"
//    /// instead of the number and for the multiples of five print "Buzz". For numbers which are multiples
//    /// of both three and five print "FizzBuzz".
//    /// i.e.:  "1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz 16 ..."
//    /// </summary>
//    public class FizzBuzz
//    {
//        private Boolean MultipleOfThree(int input) {
//            return input % 3 == 0;
//        }
//        private Boolean MultipleOfFive() {
//            return input % 5 == 0;
//        }

//        public void FizzBuzz() {

//            for (int i = 1; i <= 100; i++) {
//                if (MultipleOfThree()) {
//                    Console.Write("Fizz");
//                }

//                if (MultipleOfFive()) {
//                    Console.Write("Buzz");
//                }

//                if (MultipleOfThree() && MultipleOfFive()) {
//                    Console.Write("FizzBuzz");
//                }

                
//            }

//        }
//    }
//}