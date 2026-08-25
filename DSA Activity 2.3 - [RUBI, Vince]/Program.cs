using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        /*

         *  DSA Activity 2.3 - [RUBI, Vince]
        
         */

        Random rand = new Random();
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.Write("Enter bet amount: ");
        int amount = Convert.ToInt32(Console.ReadLine());
        List<int> luckyNumbers = new List<int>();
        while (luckyNumbers.Count != 6)
        {
            Console.WriteLine("Enter your lucky numbers:");
            string input = Console.ReadLine();
            string[] numbers = input.Split(
                new char[] { ' ', ',' },
                StringSplitOptions.RemoveEmptyEntries
            );
            luckyNumbers.Clear();
            foreach (string x in numbers)
            {
                int num;
                if (int.TryParse(x, out num))
                {
                    if (num >= 1 && num <= 49 && !luckyNumbers.Contains(num))
                    {
                        luckyNumbers.Add(num);
                    }
                }
            }
            if (luckyNumbers.Count != 6)
            {
                Console.WriteLine("Please enter 6 different numbers from 1 to 49.");
            }
        }
        int multiplier = rand.Next(2, 6);
        int prize = amount * multiplier;
        List<int> drawResult = new List<int>();
        while (drawResult.Count < 6)
        {
            int num = rand.Next(1, 50);
            if (!drawResult.Contains(num))
            {
                drawResult.Add(num);
            }
        } 
        Console.WriteLine("DRAW RESULTS");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Amount: " + amount);
        Console.WriteLine("Multiplier x" + multiplier);
        Console.WriteLine("Prize: " + prize);
        Console.Write("Entry No's: ");
        foreach (int num in luckyNumbers)
        {
        Console.Write(num + " ");
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("DRAW RESULT");
        foreach (int num in drawResult)
        {
        Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}