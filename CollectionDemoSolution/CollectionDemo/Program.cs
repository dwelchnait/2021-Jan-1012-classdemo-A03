﻿using System;

#region Additional Namespaces
using System.Collections.Generic;  //need for List<T> classes
using static System.Console;        //need for Writeline, readline, write
#endregion

namespace CollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare a List<T>
            List<int> setOfNumbers = new List<int>();
            //add element to a list
            setOfNumbers.Add(55);
            //setOfNumbers.Add(41);
            setOfNumbers.Add(100);

            WriteLine($"the list contains {setOfNumbers.Count} elements");



        }
    }
}