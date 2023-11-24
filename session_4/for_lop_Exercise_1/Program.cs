//////////////////////////////////////////////////////////////////////////
// Author: Ramtin BeheshtAeen
// Date: 24 Nov 2023
// Session: Session 4
// Content: for loop
// Topic:  exercise2: plot the specific shape using nested for loops
// Filename: Program.cs
// Dependencies: - 
//////////////////////////////////////////////////////////////////////////

internal class Program
{
    private static void Main(string[] args)
    {
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine();
            for(int j = 0; j < 3; j++){
                Console.Write("*");
            }
        }
        Console.ReadLine();
    }
}
