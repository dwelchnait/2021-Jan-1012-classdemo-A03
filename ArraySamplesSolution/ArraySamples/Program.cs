using System;

namespace ArraySamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //arrays are fixed-size
            //each element in the array is the same datatype

            //an integer array of size 6
            //this array will simulate a single dice (die)
            //the size indicates that there are 6 faces on this die
            
            int[] dieFace;  //I have a variable representing an integer array
                            //    which has NOT YET been assigned size
                            //this variable CANNOT hold data at this time

            dieFace = new int[6]; //This statement assigns an area in memeory
                                  //  of 6 int size elements
                                  //this variable CAN hold data at this time

            int[] die2Face = new int[6]; //declaring array AND allocating (requresting)
                                         //   an area in memory to be set aside
                                         //   for 6 int size elements

            int[] die3Face = new int[6] { 1, 2, 3, 4, 5, 6 }; //declare, allocate AND
                                                              //  assign my own initial
                                                              //  values to the array

            int[] die3Alternative = { 1, 2, 3, 4, 5, 6 };  //declare, allocate and assign
                                                           //array size (allocation) was
                                                           //   determind by the number
                                                           //   of initial values

            string[] dieFaceName = {"One", "Two", "Three",
                                    "Four", "Five", "Six"};

            //traverse an array
            //what is needed to know: size of the array
            //How does one reference a particular element in the array: by index (starts at 0)
            //how does one change index: use iteration (looping) logic

            for (int index = 0; index < 6; index++)
            {
                Console.WriteLine($"Default value {die2Face[index]}  Assigned value " +
                    $" {die3Alternative[index]}  Face Name {dieFaceName[index]}" +
                    $" data at index {index}");
            }
        }
    }
}
