//using System;
//using System.Collections.Generic;

//namespace Mednax.DeveloperInterview
//{
//    //Question 1
//    //Given and instance circle of the following class:
//    //Write code to calculate the circumfrence of the circle, without modifying the Circle class itself
//    public sealed class Circle
//    {
//        private double radius;
//        public double Calculate(Func<double, double> op)
//        {
//            return op(radius);
//        }
//    }

//    //Question 2
//    //What is the output for the program below and explain answer.
//    public class program
//    {
//        delegate void Printer();

//        static void Main2()
//        {
//            List<Printer> printers = new List<Printer>();
//            int i = 0;
//            for (; i < 10; i++)
//            {
//                printers.Add(delegate { Console.WriteLine(i); });
//            }

//            foreach (var printer in printers)
//            {
//                printer();
//            }
//        }
//    }

//    //Question 3
//    //What is the output of the program below and explain your answer..
//    class ProgramTwo
//    {
//        static String location;
//        static DateTime time;

//        static void Main3()
//        {
//            Console.WriteLine(location == null ? "location is null" : location);
//            Console.WriteLine(time == null ? "time is null" : time.ToString());
//        }
//    }

//    //Question 4
//    //Identify which line is boxing and which line is unboxing
//    public class ProgramThree
//    {
//        static void Main4()
//        {    
//            int x = 101;
//            Object o = x;

//            o = 999;
//            x = (int)o;
//        }
//    }
//}
