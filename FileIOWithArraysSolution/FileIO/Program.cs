using System;
using System.IO; 

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            //your code goes here


            string inputTemp ="";
            string FullFilePathName ="";
            do
            {
                inputTemp = MenuPrompt();  
                switch (inputTemp.ToUpper())
                {
                    case "A":
                        {
                            FullFilePathName = HardCodedFileName();
                            ProcessFile(FullFilePathName);
                            break;
                        }
                    case "B":
                        {
                            //your code goes here
                            break;
                        }
                    case "C":
                        {
                            WriteToFile();
                            break;
                        }
                    case "X":
                        {
                            Console.WriteLine("Thank you. Have a nice day.");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine($" {inputTemp} is not a valid menu option. Try again.");
                            break;
                        }
                }
            } while (inputTemp.ToUpper() != "X");
        }

        static string HardCodedFileName()
        {
           
            string Folder_Pathname = @"E:\GitHub\CPSC-1012\FileProcessing\";
            string Full_Path_Filename;
            Full_Path_Filename = Folder_Pathname + @"OneColumn.txt";
            //Full_Path_Filename = Folder_Pathname + @"TwoColumn.txt";
            //Full_Path_Filename = Folder_Pathname + @"VariableColums.txt";
            //Full_Path_Filename = Folder_Pathname + @"BadFileDoesNotExist.txt";
            return Full_Path_Filename;
        }

        static void ProcessFile(string paramFullFilePathName)
        {

            int records = 0;
            StreamReader reader = null;
            try
            { 
                reader = new StreamReader(paramFullFilePathName);
                string readline = "";
                readline = reader.ReadLine();
                while (readline != null)
                {
                    records++;
                    Console.WriteLine($"\nContents of file record\t{readline}");
                    int columncounter = 0;
                    foreach(string value in readline.Split(','))
                    {
                        columncounter++;
                        Console.WriteLine($"Column {columncounter} contains the value {value}");
                    }
                    readline = reader.ReadLine();
                }
                Console.WriteLine($"\nYou read {records} records");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"You had a problem reading the file. \nError:\t{ex.Message}");
            }
            finally
            {
                reader.Close();
            }
        }
    
        static string MenuPrompt()
        {
            string inputTempLocal = "";
            Console.WriteLine("File I/O options:");
            Console.WriteLine("a) Hard-coded file name.");
            Console.WriteLine("b) Using Windows Environment (DeskTop, Documents, Download) path file name.");
            Console.WriteLine("c) Writing to a file.");
            Console.WriteLine("x) Exit.\n");
            Console.Write("Enter the menu option for File I/O\t");
            inputTempLocal = Console.ReadLine();
            return inputTempLocal;
        }

        static void WriteToFile()
        {
            string PathName = @"E:\\GitHub\\CPSC-1012\\";
            string FullPathName = PathName + @"NewFile.txt";
            StreamWriter writer;
            try  
            {
                writer = new StreamWriter(FullPathName, false);
                Random rnd = new Random(); 
                int linesout = rnd.Next(1, 6); 
                for (int looper = 0; looper < linesout; looper++)  
                {
                    writer.Write($"line {looper}, terry\n");
                }
                writer.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n\nError: {ex.Message}\n\n");
            }
        }
    }
}
