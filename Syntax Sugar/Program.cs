using System;

namespace Syntax_Sugar
{
    class Program
    {
        static void Main(string[] args)
        {




            //int answer = 4;
            //string response;

            //if (answer < 9)
            
            //    response = answer + " is less than nine";
            
            //else
            
            //    response = answer + “greater than or equal to nine”;
            




            var answer = 4;

            
            Console.WriteLine($" {answer}  is <9");

            
            var response = (answer < 9) ? $"{answer}is less than nine" : $"{answer}is greater than nine";

        }
    }
}  














