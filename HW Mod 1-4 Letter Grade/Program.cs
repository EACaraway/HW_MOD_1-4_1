using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Mod1_4_Letter_Grade
{
    class Program
    {
        static void Main(string[] args)
        {
            // request user input
            Console.Write( "Please enter your percentage grade as an integer: ");
            double.TryParse(Console.ReadLine(),out double percentageGrade);
            LetterGrade(percentageGrade);
        }
        // Method to return LetterGrade based on paramater of percentage grade in accordance with CSC 440 class syllabus grading standards.
        public static void LetterGrade(double grade)
        {
            // use if else if statements to write letter grade to the console.
            if (grade >= 97) 
            {
                Console.WriteLine("Your grade = A+");
            }
            else if (grade >= 93)
            {
                Console.WriteLine("Your grade = A");
            }
            else if (grade >= 90)
            {
                Console.WriteLine("Your grade = A-");
            }
            else if (grade >= 87)
            {
                Console.WriteLine("Your grade = B+");
            }
            else if (grade >= 83)
            {
                Console.WriteLine("Your grade = B");
            }
            else if (grade >= 80)
            {
                Console.WriteLine("Your grade = B-");
            }
            else if (grade >= 77)
            {
                Console.WriteLine("Your grade = C+");
            }
            else if (grade >= 73)
            {
                Console.WriteLine("Your grade = C");
            }
            else if (grade >= 70)
            {
                Console.WriteLine("Your grade = C-");
            }
            else if (grade >= 67)
            {
                Console.WriteLine("Your grade = D+");
            }
            else if (grade >= 63)
            {
                Console.WriteLine("Your grade = D");
            }
            else if (grade >= 60)
            {
                Console.WriteLine("Your grade = D-");
            }
            else
            {
                Console.WriteLine("Your grade = F");
            }
        }
    }
    
}
