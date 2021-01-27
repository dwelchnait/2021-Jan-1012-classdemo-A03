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

            ////the one--way if statement
            ////has only a true path
            //double radius = 3.5;
            //if (radius > 0)
            //{
            //    double area = Math.Pow(radius, Math.PI);
            //    Console.WriteLine($"The area of a cricle with a radius of {radius} is {Math.Round(area, 2)}");
            //}

            ////a two-way if statement
            ////has a true path and a false path
            ////the true path is coded first
            ////the false path is code second
            ////the true path coding block is separated from the false path
            ////      coding block by the key word -> else
            //if (radius > 0)
            //{
            //    double area = Math.Pow(radius, Math.PI);
            //    if (area >= 100.0)
            //    {
            //        //true path
            //        //executed when the condition resolves to the boolean value TRUE
            //        Console.WriteLine($"The area of a cricle with a radius of {radius} is {Math.Round(area, 2)}. Your circle is large enough.");

            //        //at the end of this TRUE coding block you exit to the
            //        //   next statement AFTER the end of the if
            //    }
            //    else
            //    {
            //        //false  path
            //        //executed when the condition resolves to the boolean value FALSE
            //        Console.WriteLine($"The area of a cricle with a radius of {radius} is {Math.Round(area, 2)}. Increase the size of the radius");

            //        //at the end of this FALSE coding block you exit to the
            //        //   next statement AFTER the end of the if
            //    } //this closing bracket indicates the end of the two way if
            //    Console.WriteLine("The is the next statement after the two way if");

            //}


            ////Nested If algorithm (aka logic, design, plan,...)
            ////a nested if is an if statement within an if statement

            ////Basic Programming Problem 5: Who Won

            //string inputTemp = "";
            //string racerName1;                          //just declared
            //string racerName2, racerName3;              //just declared
            //double racerTime1 = 0.0;                    //declared and assigned
            //double racerTime2 = 0.0, racerTime3 = 0.0;  //declared and assigned
            //string firstPlace, secondPlace, thirdPlace; //just declared

            ////this is technically legal in C#
            //firstPlace = secondPlace = thirdPlace = ""; //variables assigned same value

            //Console.Write("Enter racer 1 name:\t");
            //racerName1 = Console.ReadLine();
            //Console.Write("Enter racer 1 time in minutes (12.3):\t");
            //inputTemp = Console.ReadLine();
            //racerTime1 = double.Parse(inputTemp);
            //Console.Write("Enter racer 2 name:\t");
            //racerName2 = Console.ReadLine();
            //Console.Write("Enter racer 2 time in minutes (12.3):\t");
            ////inputTemp = Console.ReadLine();
            //racerTime2 = double.Parse(Console.ReadLine());
            //Console.Write("Enter racer 3 name:\t");
            //racerName3 = Console.ReadLine();
            //Console.Write("Enter racer 3 time in minutes (12.3):\t");
            //inputTemp = Console.ReadLine();
            //racerTime3 = double.Parse(inputTemp);

            ////conditional logic 
            ////a Nested IF
            ////an IF within another IF

            //if (racerTime1 < racerTime2)
            //{
            //    //racer1 faster than racer2
            //    firstPlace = $"{racerName1} ({racerTime1})";
            //    secondPlace = $"{racerName2} ({racerTime2})";
            //    if (racerTime1 < racerTime3)
            //    {
            //        if (racerTime2 < racerTime3)
            //        {
            //            thirdPlace = $"{racerName3} ({racerTime3})";
            //        }
            //        else
            //        {
            //            //racer3 faster than racer2
            //            thirdPlace = secondPlace;
            //            secondPlace = $"{racerName3} ({racerTime3})";
            //        }
            //    }
            //    else
            //    {
            //        //racer3 is faster than racer1
            //        thirdPlace = secondPlace;
            //        secondPlace = firstPlace;
            //        firstPlace = $"{racerName3} ({racerTime3})";
            //    }
            //}
            //else
            //{
            //    //racer2 faster than racer1
            //    firstPlace = $"{racerName2} ({racerTime2})";
            //    secondPlace = $"{racerName1} ({racerTime1})";

            //    if (racerTime2 < racerTime3)
            //    {
            //        if (racerTime1 < racerTime3)
            //        {
            //            thirdPlace = $"{racerName3} ({racerTime3})";
            //        }
            //        else
            //        {
            //            thirdPlace = secondPlace;
            //            secondPlace = $"{racerName3} ({racerTime3})";
            //        }
            //    }
            //    else
            //    {
            //        //racer3 is faster than racer1
            //        thirdPlace = secondPlace;
            //        secondPlace = firstPlace;
            //        firstPlace = $"{racerName3} ({racerTime3})";
            //    }

            //}//eof outter most if of decision structure

            ////next executable statement
            //Console.WriteLine($"First place {firstPlace}\n");
            //Console.WriteLine($"Second place {secondPlace}\n");
            //Console.WriteLine($"Third place {thirdPlace}\n");

            ////Loan example
            ////Nested If

            //const double MINWAGEAMOUNT = 30000.00;
            //const int MINYEARSWORKED = 2;
            //double wageAmount = 35000.00;
            //int yearWorked = 3;
            //if (wageAmount < MINWAGEAMOUNT)
            //{
            //    if (yearWorked < MINYEARSWORKED)
            //    {
            //        Console.WriteLine("Not qualified for loan due to wages and years worked");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Not qualified for loan due to low wages");
            //    }
            //}
            //else
            //{
            //    if (yearWorked < MINYEARSWORKED)
            //    {
            //        Console.WriteLine("Not qualified for loan due to  years worked");
            //    }
            //    else
            //    {
            //        Console.WriteLine("You qualified for loan");
            //    }
            //}

            ////if - else if structure

            int testScore = 25;
            ////code using NESTED IF
            //if (testScore < 50)
            //{
            //    Console.WriteLine("Your grade is F.");
            //}
            //else
            //{
            //    if (testScore < 60)
            //    {
            //        Console.WriteLine("Your grade is D.");
            //    }
            //    else
            //    {
            //        if (testScore < 70)
            //        {
            //            Console.WriteLine("Your grade is C.");
            //        }
            //        else
            //        {
            //            if (testScore < 80)
            //            {
            //                Console.WriteLine("Your grade is B.");
            //            }
            //            else
            //            {
            //                    Console.WriteLine("Your grade is A.");
            //            }
            //        }
            //    }
            //}//eo if structure

            ////coded using IF - ELSE IF
            //if (testScore < 50)
            //{
            //    Console.WriteLine("Your grade is F.");
            //}//eo coding block 50
            //else if (testScore < 60)
            //{
            //    Console.WriteLine("Your grade is D.");
            //}//eo coding block 60
            //else if (testScore < 70)
            //{
            //    Console.WriteLine("Your grade is C.");
            //}//eo coding block 70
            //else if (testScore < 80)
            //{
            //    Console.WriteLine("Your grade is B.");
            //}//eo coding block 80
            //else
            //{
            //    Console.WriteLine("Your grade is A.");
            //}//eo IF structure / eo coding block 80+

            //Weather Translation
            int FahrenheitTemperature = 75;
            int CelsiusTemperature = 0;

            CelsiusTemperature = (FahrenheitTemperature - 32) * 5 / 9;
            
            if (CelsiusTemperature < 0)
            {
                //below 0
                Console.WriteLine("It's freezing out");
            }
            else if(CelsiusTemperature <= 15)
            {
                // 0 (implied) to 15
                Console.WriteLine("Wear a jacket");
            }
            else if (CelsiusTemperature <= 30)
            {
                //  16 (implied) to 30
                Console.WriteLine("It's a lovely day");
            }
            else
            {
                // over 30
                    Console.WriteLine("It's finally time for shorts");
            }

            //recode as a range
            if (CelsiusTemperature < 0)
            {
                //below 0
                Console.WriteLine("It's freezing out");
            }
            else if ((CelsiusTemperature >= 0) && (CelsiusTemperature <= 15))
            {
                //0 (explictive) to 15
                Console.WriteLine("Wear a jacket");
            }
            else if ((CelsiusTemperature >= 16) && (CelsiusTemperature <= 30))
            {
                // 16  (explicitive) to 30
                Console.WriteLine("It's a lovely day");
            }
            else
            {
                // over 30
                Console.WriteLine("It's finally time for shorts");
            }
        }//eoMain
    }//eop
}//eon
