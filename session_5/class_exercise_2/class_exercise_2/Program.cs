//////////////////////////////////////////////////////////////////////////
// Author: Ramtin BeheshtAeen
// Date: 30 Nov 2023
// Session: Session 5
// Content: Array
// Topic:  Class exercise2
// Filename: Program.cs
// Dependencies: - 
//////////////////////////////////////////////////////////////////////////
internal class Program
{
    private static void Main(string[] args)
    {   
        Console.WriteLine("Enter number of goods");
        string[] goods = new string[int.Parse(Console.ReadLine())];
        int[] price = new int[goods.Length];
        int sum = 0;

        for (int i = 0; i < goods.Length; i++)
        {
            Console.WriteLine("Enter the name of the current good:");
            goods[i] = Console.ReadLine();

            Console.WriteLine("Enter the price of the " + goods[i] + ":");
            price[i] = int.Parse(Console.ReadLine());

            sum += price[i];
        }

        Console.WriteLine("-----------------Jadval Mojodi---------------------");
        for (int j = 0; j < goods.Length; j++)
        {
            Console.WriteLine("product_code: " + j + " product_name: " + goods[j]+ " product_price: "+ price[j]);
        }

        Console.WriteLine("Total sum: " + sum);



    }
}