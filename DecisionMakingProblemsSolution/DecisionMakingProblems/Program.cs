﻿using System;

namespace DecisionMakingProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputTemp;

            //question 1
            //Console.Write("Enter a whole number:\t");
            //inputTemp = Console.ReadLine();
            //int aNumber = int.Parse(inputTemp);
            //if (aNumber == 0)
            //{

            //    Console.WriteLine($"\nYour number {aNumber} is zero");
            //}
            //else if (aNumber > 0)
            //{
            //    Console.WriteLine($"\nYour number {aNumber} is a positive number greater than zero.");
            //}
            //else 
            //{
            //    Console.WriteLine($"\nYour number {aNumber} is a negative number less than zero.");
            //}

            //question 2
            //Console.Write("Enter your age in years:\t");
            //inputTemp = Console.ReadLine();
            //int yourAge = int.Parse(inputTemp);
            //if (yourAge <= 6)   // < 7 is the same as <= 6
            //{
            //    Console.WriteLine($"\nAdmission is Free");
            //}
            //else if (yourAge >= 7 && yourAge <= 17)
            //{
            //    Console.WriteLine($"\nAdmission is $9.80");
            //}
            //else if (yourAge < 55)
            //{
            //    Console.WriteLine($"\nAdmission is $11.35");
            //}
            //else 
            //{
            //    Console.WriteLine($"\nAdmission is $10.00.");
            //}

            //question 3
            //Console.Write("Enter your name:\t");
            //string studentName = Console.ReadLine();
            //Console.Write("Enter your mark as a whole number (ie 65):\t");
            //inputTemp = Console.ReadLine();
            //int studentMark = int.Parse(inputTemp);
            //if (studentMark < 50)
            //{
            //    Console.WriteLine($"\n {studentName} is mark of {studentMark} is a F");
            //}
            //else if (studentMark < 70)
            //{
            //    Console.WriteLine($"\n {studentName} is mark of {studentMark} is a D");
            //}
            //else if (studentMark < 80)
            //{
            //    Console.WriteLine($"\n {studentName} is mark of {studentMark} is a C");
            //}
            //else if (studentMark < 90)
            //{
            //    Console.WriteLine($"\n {studentName} is mark of {studentMark} is a B");
            //}
            //else
            //{
            //    Console.WriteLine($"\n {studentName} is mark of {studentMark} is a A");
            //}

            //Question 4
            //const decimal FIVEPERCENT = 0.05m;  //the m indicates the value is a decimal
            //const decimal SEVENPERCENT = 0.07m;
            //const decimal NINEPERCENT = 0.09m;
            //const decimal UPTOFIFTY = 50000.00m;
            //const decimal UPTOHUNDRED = 100000.0m;
            //decimal taxesDue = 0.0m;

            //Console.Write("Enter your total income (ie 65345.67):\t");
            //inputTemp = Console.ReadLine();
            //decimal totalIncome = decimal.Parse(inputTemp);
            //if (totalIncome <= 50000.00m)
            //{
            //    taxesDue = totalIncome * FIVEPERCENT;
            //    Console.WriteLine($"\n An Income of {Math.Round(totalIncome, 2)} pays " +
            //        $"{Math.Round(taxesDue, 2)} in taxes.");
            //}
            //else if (totalIncome <= UPTOHUNDRED)
            //{
            //    taxesDue = ((totalIncome - UPTOFIFTY) * SEVENPERCENT) + 2500.0m;
            //    Console.WriteLine($"\n An Income of {Math.Round(totalIncome, 2)} pays " +
            //        $"{Math.Round(taxesDue, 2)} in taxes.");
            //}
            //else
            //{
            //    taxesDue = ((totalIncome - UPTOHUNDRED) * NINEPERCENT) + 6000.0m;
            //    Console.WriteLine($"\n An Income of {Math.Round(totalIncome, 2)} pays " +
            //        $"{Math.Round(taxesDue, 2)} in taxes.");
            //}

            //switch problems
            //Console.WriteLine("Packages:\n");
            //Console.WriteLine("Package A: 9.95/month; 10 hours; Over 2.00/hour\n");
            //Console.WriteLine("Package B: 13.95/month; 20 hours; Over 1.00/hour\n");
            //Console.WriteLine("Package C: 19.95/month; unlimited hours\n\n");
            //Console.Write("Enter your Package choice (a, b, c)\t");
            //string packageChoice = Console.ReadLine();
            //int hoursUsed = 0;
            //decimal billedAmount = 0.0m;
            //if (packageChoice.ToUpper() == "A" || 
            //    (packageChoice == "B" || packageChoice == "b"))
            //{
            //    Console.Write("Enter your hours used:\t");
            //    inputTemp = Console.ReadLine();
            //    hoursUsed = int.Parse(inputTemp);
            //}
            //switch (packageChoice) //the is an equals (==)
            //{
            //    case "a":  //multiple cases is an logical || situation
            //    case "A":
            //        {
            //            if (hoursUsed > 10)
            //            {
            //                billedAmount = 9.95m + ((hoursUsed - 10) * 2.00m);
            //            }
            //            else
            //            {
            //                billedAmount = 9.95m;
            //            }
            //            break;
            //        }
            //    case "b":
            //    case "B":
            //        {
            //            billedAmount = 13.95m;
            //            if (hoursUsed > 20)
            //            {
            //                billedAmount += ((hoursUsed - 20) * 1.00m);
            //            }

            //            break;
            //        }
            //    case "c":
            //    case "C":
            //        {
            //            billedAmount = 19.95m;
            //            break;
            //        }
            //    default:  //this is the last else in an if else-if structure
            //        {
            //            Console.WriteLine("\nInvalid package selection.");
            //            break;
            //        }
            //}//eo switch your break; takes the user to the end of switch
            //if (billedAmount > 0.0m)
            //{
            //    if (packageChoice.ToUpper().Equals("C")) // (packageChoice.ToUpper() =="C")
            //    {
            //        Console.WriteLine($"Your package {packageChoice} with unlimited hours will be" +
            //      $" billed {Math.Round(billedAmount, 2)}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Your package {packageChoice} with {hoursUsed} hours will be" +
            //      $" billed {Math.Round(billedAmount, 2)}");
            //    }
              
            //}


        }
    }
}
