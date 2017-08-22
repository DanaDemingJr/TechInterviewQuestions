using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechInterviewQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter your number");
            //int userNumber = int.Parse(Console.ReadLine());
            //if (userNumber % 15 == 0)
            //{
            //    Console.WriteLine("FizzBuzz");
            //}
            //else if (userNumber % 3 == 0)
            //{
            //    Console.WriteLine("Fizz");
            //}
            //else if (userNumber % 5 == 0)
            //{
            //    Console.WriteLine("Buzz");
            //}
            //else
            //{
            //    Console.WriteLine("Your number is not divisible by 3 or 5");
            //}

            Console.WriteLine("Please enter a number");
            int enteredNumber = int.Parse(Console.ReadLine());
            if(enteredNumber % 3 == 0 && enteredNumber % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (enteredNumber % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (enteredNumber % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine("This number is not divisible by 3 or 5");
            }


        }
    }
}
