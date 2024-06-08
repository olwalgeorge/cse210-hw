using System;
/// <Author>
/// George Olwal
/// </Author>
/// <Summary>
/// C# Prep 4 Core
/// This program will ask the user to enter a list of numbers from while inserting on the list until 0 is entered
/// the program then displays the list on the console
/// </Summary>

class Program
{
    static void Main(string[] args)
    {

        int num;
        List<int> numbers = new List<int>();
        do
            {
                Console.Write("Enter a list of numbers, type 0 when finished.");
                num = int.Parse(Console.ReadLine());

                if (num != 0)
                {
                    numbers.Add(num);
                }
            }  while (num != 0);

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}