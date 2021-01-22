using System;

namespace ArithmeticProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculate mean average

            //declare 4 double variables
            //declare 1 string variable for input
            //prompt, input and convert number; repeat 3 times
            //add numbers together then divided by 3
            //display mean average

            double numberOne;
            double numberTwo;
            double numberThree;
            double meanAverage;

            //Technically the above 4 lines could be coded on one physical line
            //double numberOne, numberTwo, numberThree, meanAverage;

            string inputTemp;
            Console.Write("Enter a real number:\t");
            inputTemp = Console.ReadLine();
            numberOne = double.Parse(inputTemp);
            Console.Write("Enter a real number:\t");
            inputTemp = Console.ReadLine();
            numberTwo = double.Parse(inputTemp);
            Console.Write("Enter a real number:\t");
            inputTemp = Console.ReadLine();
            numberThree = double.Parse(inputTemp);
            meanAverage = (numberOne + numberTwo + numberThree) / 3.0;
            Console.WriteLine($"{numberOne} + { numberTwo} + {numberThree} has an average of {meanAverage}");

            //Practice Math.Round()
            Console.WriteLine($"{numberOne} + { numberTwo} + {numberThree} has an average of {Math.Round(meanAverage,2)}");

            //Pythagorean Theorem
            //declare 3 double variables
            //declare 1 string variable for reuse as input variable
            //prompt and read number for height
            //prompt and read number for base
            //calculate hypotenuse (use Math class methods)
            //  formula hypotenuse = squareroot(height squared + base squared)
            //display data

            double triangleHeight;
            double triangleBase;
            double hypotenuse;
            Console.Write("enter the triangle''s height;\t");

            //declare and assign a value to a variable
            string inputTempTriangle = Console.ReadLine();

            triangleHeight = double.Parse(inputTempTriangle);
            Console.Write("enter the triangle''s base;\t");

            //reuse a declared variable and reassign a value to that variable
            inputTempTriangle = Console.ReadLine();

            triangleBase = double.Parse(inputTempTriangle);

            //Math.Sqrt()  calculates a square root value
            //Math.Pow()  calculates a value raised to a specified power
            hypotenuse = Math.Sqrt(Math.Pow(triangleHeight, 2) + Math.Pow(triangleBase, 2));
            hypotenuse = Math.Sqrt((triangleHeight * triangleHeight) + (triangleBase * triangleBase));
            Console.WriteLine($"The hypotenuse of a triangle with a height of {triangleHeight}" +
                $" and a base of {triangleBase} is {hypotenuse}");

            //Sum Numbers

            //declare 2 integer variable
            //declare 1 string variable for input
            //prompt, input and convert number
            //Divide number by 100 add to sum integer variable
            //get remainder of number divided by 100, divide remainder by 10, add to sum integer
            //get remainder of number divided by 10, add to sum integer
            //display three numbers and sum

            int inputNumber;
            int totalSum = 0; //Declare and assign variable and its value 
            string inputSumTemp;

            Console.Write("Enter a whole number:\t");
            inputSumTemp = Console.ReadLine();
            inputNumber = int.Parse(inputSumTemp);

            //integer division
            //ex  345 ->  345 /100 = 3 NO DECIMAL DIGITS
            totalSum += inputNumber / 100;

            //Modulas division to get remainder
            //  345 % 100 -> 45 -> 45 / 10 -> 4
            totalSum += (inputNumber % 100) / 10;

            //Modulas division to get remainder
            //  345 % 100 -> 45 -> 45 % 10 -> 5
            totalSum = +(inputNumber % 100) % 10;
           
          
            Console.WriteLine($"The digits of {inputNumber}  has a sum of {totalSum}");
            Console.WriteLine($"{inputNumber} sums to {totalSum}");
        }
    }
}
