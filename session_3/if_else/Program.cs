internal class Program
{
    private static void Main(string[] args)
    {
        float firstNumber;
        float secondNumber;
        float thirdNumber;
        float avg = 0;
        float sum;
        try
        {
            Console.WriteLine("Enter the first number");
            firstNumber = float.Parse(Console.ReadLine());
            //if

            Console.WriteLine("Enter the second number");
            secondNumber = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third number");
            thirdNumber = float.Parse(Console.ReadLine());

            sum = firstNumber + secondNumber + thirdNumber;
            avg = sum / 3;
        }
        catch (Exception)
        {
            Console.WriteLine("Error While getting user's Input or Calculating the sum");
            Console.ReadLine();
        }

        try
        {
            if (avg == 20)
            {
                Console.WriteLine("Top Student");
            }

            else if (avg < 20 && avg > 15)
            {
                Console.WriteLine("Good Student");
            }

            else 
            {
                Console.WriteLine("Bad Student");
            }
            Console.ReadKey();
        }
        catch (Exception)
        {
            Console.WriteLine("Error In if/else statement");
            Console.ReadLine();
        }
    }
}