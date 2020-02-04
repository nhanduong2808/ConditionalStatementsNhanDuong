using System;

namespace ConditionalStatementsNhanDuong
{
    class Program
    {
        static void Main(string[] args)
        {
            int score;
            Console.WriteLine("Hello, this is Nhan Duong!");
            Console.WriteLine("Please tell me what total score out of 100 you are expecting to get in ISM 4300? (Integer input only)");
            Int32.TryParse(Console.ReadLine(), out score);
            if(score >= 98 && score <= 100)
            {
                Console.WriteLine("That is A+");
            }
            else if(score >= 92 && score <= 97)
            {
                Console.WriteLine("That is A");
            }
            else if(score == 90 || score == 91)
            {
                Console.WriteLine("That is A-");
            }
            else if(score == 88 || score == 89)
            {
                Console.WriteLine("That is B+");
            }
            else if(score >= 82 && score <= 87)
            {
                Console.WriteLine("That is B");
            }
            else if(score == 80 || score == 81)
            {
                Console.WriteLine("That is B-");
            }
            else if(score == 78 || score == 79)
            {
                Console.WriteLine("That is C+");
            }
            else if(score >= 72 && score <= 77)
            {
                Console.WriteLine("That is C");
            }
            else if(score == 70 || score == 71)
            {
                Console.WriteLine("That is C-");
            }
            else if(score == 68 || score == 69)
            {
                Console.WriteLine("That is D+");
            }
            else if(score >= 62 && score <= 67)
            {
                Console.WriteLine("That is D");
            }
            else if(score == 60 || score == 61)
            {
                Console.WriteLine("That is D-");
            }
            else if (score <= 59 && score >= 0)
            {
                Console.WriteLine("That is F");
            }
            else
            {
                Console.WriteLine("Please enter a grade between 0 and 100!");
            }
        }
    }
}
