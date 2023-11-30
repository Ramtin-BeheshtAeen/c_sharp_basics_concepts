//////////////////////////////////////////////////////////////////////////
// Author: Ramtin BeheshtAeen
// Date: 23 Nov 2023
// Session: Session 4
// Content: for loop
// Topic: solved class exercise
// Filename: Program.cs
// Dependencies: - 
//////////////////////////////////////////////////////////////////////////
internal class Program
{
    private static void Main(string[] args)
    {
        float grade_of_student;
        float sum = 0;
        float avg = 0;

        for (int i = 0; i < 9; i++)
        {
            //Get the points of each student in the class:
            Console.WriteLine("Enter the current student's grades:");
            grade_of_student = float.Parse(Console.ReadLine());

            //Calculate sum of the grades by adding current grade to last grades:
            sum = sum + grade_of_student;
        }

        avg = sum / 10;

        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Avg: " + avg);
        
    }
}