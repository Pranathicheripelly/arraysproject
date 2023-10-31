using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraysproject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            runApp();
        }
        public static void runApp()
        {


            // Create arrays to store student names and their corresponding marks
            string[] studentNames = new string[5];
            studentNames[0] = "nani";
            studentNames[1] = "ram";
            studentNames[2] = "krishna";
            studentNames[3] = "Tillu";
            studentNames[4] = "babu";

            int[] studentMarks = new int[] { 93, 81, 86, 99, 73 };

            // Display the list of students and their marks
            Console.WriteLine("Student Names and Marks:");
            int i = 0;
            while (i < studentNames.Length)
            {

                Console.WriteLine($"{studentNames[i]}: {studentMarks[i]}");
                i++;
                Console.ReadLine();
            }
        }
    }

}







