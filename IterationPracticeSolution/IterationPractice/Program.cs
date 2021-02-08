using System;

namespace IterationPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //global variables
            string inputTemp;

            //Find the sum of the squares of the integers from 1 to MySquare, where MySquare is input by
            // the user.E.g.user enters 4 then return 1x1 + 2x2 + 3x3 + 4x4 = 30

            int mySquare = 0;
            int sumOfSquares = 0;

            Console.Write("Enter a number and find out its sum of squares\t");
            inputTemp = Console.ReadLine();
            //
            //Validate the incoming value
            //
            //xxx.TryParse takes the input string and attempts to convert the string
            //    to the request numeric datatype
            //if the attempt is good then the value is placed in the out variable AND a True is returned
            //if the attempt fails then a False is returned and NO conversion is done
            //
            if(int.TryParse(inputTemp, out mySquare))
            {
                if (mySquare > 0)
                {
                    //one needs to do the iteration at least once, seems a good candidate for post-loop
                    //int loopCount = 1;
                    //do
                    //{
                    //    sumOfSquares += loopCount * loopCount;
                    //    //sumOfSquares = sumOfSquares + loopCount * loopCount;
                    //    //sumOfSquares += (int)Math.Pow(loopCount, 2);

                    //    //you must increment your loop counter
                    //    loopCount++;
                    //} while (loopCount <= mySquare);

                    //pre-test solution
                    int loopCount = 1;
                    string msg = "";
                    while(loopCount <= mySquare)
                    {
                        msg = msg + $"{loopCount}x{loopCount}+";
                        sumOfSquares += (int)Math.Pow(loopCount, 2);
                        loopCount++;
                    }
                    //using the string methods called Substring() and Length()
                    int msgLength = msg.Length;
                    msg = msg.Substring(0, msgLength - 1);

                    Console.WriteLine($"The sum of squares for {mySquare} is {msg} = {sumOfSquares}");
                }
                else
                {
                    Console.WriteLine($"{mySquare} is invalid. Enter a positive greater than 0 number. ");
                }
            }
            else
            {
                Console.WriteLine($"{inputTemp} is invalid. Enter a number. ");
            }
        }
    }
}
