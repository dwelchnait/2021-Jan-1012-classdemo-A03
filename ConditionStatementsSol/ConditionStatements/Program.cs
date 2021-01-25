using System;

namespace ConditionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //const int MIN_NUMBER = 1;
            //const int MAX_NUMBER = 9;

            //Random keyrad = new Random();

            //int number1 = keyrad.Next(MIN_NUMBER, MAX_NUMBER + 1);
            //int number2 = keyrad.Next(MIN_NUMBER, MAX_NUMBER + 1);

            //Console.Write($"The sum of {number1} + {number2} = ?\t");

            //string inputTemp = Console.ReadLine();
            //int answer = int.Parse(inputTemp);
            ////int answer = int.Parse(Console.ReadLine());

            ////the conditional test is (number1 + number2) == answer
            ////where the left argument is (number1 + number2)
            ////      the relational operator is == (equals)
            ////      the right argument is answer
            ////this condition will resolve to either true or false
            //Console.WriteLine($"{number1} + {number2} = {answer}" +
            //    $" your answer is {(number1 + number2) == answer}");

            //the one--way if statement
            //has only a true path
            double radius = 3.5;
            if (radius > 0)
            {
                double area = Math.Pow(radius, Math.PI);
                Console.WriteLine($"The area of a cricle with a radius of {radius} is {Math.Round(area,2)}");
            }

            //a two-way if statement
            //has a true path and a false path
            //the true path is coded first
            //the false path is code second
            //the true path coding block is separated from the false path
            //      coding block by the key word -> else
            if (radius > 0)
            {
                double area = Math.Pow(radius, Math.PI);
                if (area >= 100.0)
                {
                    //true path
                    //executed when the condition resolves to the boolean value TRUE
                    Console.WriteLine($"The area of a cricle with a radius of {radius} is {Math.Round(area, 2)}. Your circle is large enough.");

                    //at the end of this TRUE coding block you exit to the
                    //   next statement AFTER the end of the if
                }
                else
                {
                    //false  path
                    //executed when the condition resolves to the boolean value FALSE
                    Console.WriteLine($"The area of a cricle with a radius of {radius} is {Math.Round(area, 2)}. Increase the size of the radius");

                    //at the end of this FALSE coding block you exit to the
                    //   next statement AFTER the end of the if
                } //this closing bracket indicates the end of the two way if
                Console.WriteLine("The is the next statement after the two way if");

            }

            string inputTemp = "";
            string racerName1;                          //just declared
            string racerName2, racerName3;              //just declared
            double racerTime1 = 0.0;                    //declared and assigned
            double racerTime2 = 0.0, racerTime3 = 0.0;  //declared and assigned
            string firstPlace, secondPlace, thirdPlace; //just declared
            firstPlace = secondPlace = thirdPlace = ""; //variables assigned same value
            Console.Write("Enter racer 1 name:\t");
            racerName1 = Console.ReadLine();
            Console.Write("Enter racer 1 time in minutes (12.3):\t");
            inputTemp = Console.ReadLine();
            racerTime1 = double.Parse(inputTemp);
            Console.Write("Enter racer 2 name:\t");
            racerName2 = Console.ReadLine();
            Console.Write("Enter racer 2 time in minutes (12.3):\t");
            //inputTemp = Console.ReadLine();
            racerTime2 = double.Parse(Console.ReadLine());
            Console.Write("Enter racer 3 name:\t");
            racerName3 = Console.ReadLine();
            Console.Write("Enter racer 3 time in minutes (12.3):\t");
            inputTemp = Console.ReadLine();
            racerTime3 = double.Parse(inputTemp);

            //conditional logic 
            //a Nested IF
            //an IF within another IF
           
            Console.WriteLine($"First place {firstPlace}\n");
            Console.WriteLine($"Second place {secondPlace}\n");
            Console.WriteLine($"Third place {thirdPlace}\n");
        }
    }
}
