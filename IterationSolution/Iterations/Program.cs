using System;

namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {

            //pre-test loop structure (a.k.a. DO-While structure)
            //
            string inputTemp;
            int aNumber;

            Console.Write("Enter a number:\t");
            inputTemp = Console.ReadLine();
            aNumber = int.Parse(inputTemp);
            int loopExecutions = 0;
            // pre-test loop
            while (aNumber !=  0)
            {
                //all code within this coding block ({....})
                //  belongs to the loop

                Console.WriteLine($"You entered the number {aNumber}");
                Console.Write("Enter a number:\t");
                inputTemp = Console.ReadLine();
                aNumber = int.Parse(inputTemp);

                //a fast way of adding 1 to a counter
                //loopExecutions = loopExecutions + 1;
                loopExecutions++;
            }//eowhile

            //next statement is the 1st executable statement after the loop
            Console.WriteLine($"The loop has finished, you executed the loop {loopExecutions}");


            //post-test loop
            do
            {
                //all code within this coding block ({....})
                //  belongs to the loop

                //a fast way of adding 1 to a counter
                //loopExecutions = loopExecutions + 1;
                loopExecutions++;

                Console.Write("Enter a number:\t");
                inputTemp = Console.ReadLine();
                aNumber = int.Parse(inputTemp);
                if (aNumber != 0) //termination number DO NOT PRINT
                {
                    Console.WriteLine($"You entered the number {aNumber}");
                }
            } while (aNumber != 0);  //eowhile

                //next statement is the 1st executable statement after the loop
            Console.WriteLine($"The loop has finished, you executed the loop {loopExecutions}");


            //Assume you are an instructor.
            //Enter a mark for each student in your class.
            //Continue enter marks for the students and after
            //    all marks have been entered, calculate the average.
            //The highest mark for any student is 100.
            //The lowest mark for any student is 0.
        }//eoMain
    }
}
