using System;

namespace QuizTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            int tireSize = 29;
            //if (tireSize < 20 || tireSize > 26)
            //{
            //    Console.WriteLine("Invalid tire size");
            //}

            //if (tireSize >= 20 && tireSize <= 26)
            //{

            //}
            //else
            //{
            //    Console.WriteLine("Invalid tire size.");
            //}

            //if(tireSize < 20 || tireSize > 26)
            //    {
            //    Console.WriteLine("The tiresize is between 20 and 26");
            //     }
            //    else
            //{
            //    Console.WriteLine("Invalid tire size");
            // }

            //if (tireSize >= 20 && tireSize <= 26)
            //{
            //}
            //else
            //{
            //    Console.WriteLine("Invalid tire size");
            //}

            //if (tireSize >= 26 && tireSize <= 20)
            //{
            //    Console.WriteLine("Invalid tire size");
            //}
            //string inputTemp;
            //double celsiusValue;
            //double fahrenheitValue;

            //Console.WriteLine("*** Temperature Converter ***");
            //Console.WriteLine("Please enter a temperature in celsius:\t");
            //inputTemp = Console.ReadLine();
            //celsiusValue = double.Parse(inputTemp);

            //fahrenheitValue = (celsiusValue * 9) / 5 + 32;

            //if (fahrenheitValue < 50)
            //{
            //    Console.WriteLine($"The temperature in Fahrenheit is {fahrenheitValue}.");
            //    Console.WriteLine($"It is too cold!");
            //}
            //else if (fahrenheitValue < 100)
            //{
            //    Console.WriteLine($"The temperature in Fahrenheit is {fahrenheitValue}.");
            //    Console.WriteLine($"It is just right!");
            //}
            //else
            //{
            //    Console.WriteLine($"The temperature in Fahrenheit is {fahrenheitValue}.");
            //    Console.WriteLine($"It is too hot!");
            //}
            string brand = "a";
//            if (brand != "a" && brand != "b" && brand != "c")
//            {
//                Console.WriteLine("Invalid Section");
//            }

//            if (!(brand == "a" || brand == "b" || brand =="c"))
//                        Console.WriteLine("Invalid selection.");
//            if(brand != "a" && brand != "b" && brand != "c")
//{
//                Console.WriteLine("Invalid Selection");
//            }

//            if (brand.ToLower() != "a" || brand.ToLower() != "b" || brand.ToLower() != "c")
//            {
//                Console.WriteLine("Invalid Selectuon");
//            }

            if (brand != "a" | brand != "b" | brand != "c")
            { Console.WriteLine("Invalid selection"); }
        }
    }
}
