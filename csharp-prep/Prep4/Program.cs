using System;
/// <Author>
/// George Olwal
/// </Author>
/// <Summary>
/// C# Prep 4 Core 3
/// This program will ask the user to enter a list of numbers from while inserting on the list until 0 is entered
/// the program then displays the list on the console,
/// calculates and display sum, average and largest number
/// </Summary>

class Program
{
    static void Main(string[] args)
    {
        // Ask user to enter numbers and append them to a list
        int num;        
        List<int> numbers = new List<int>();
        do
            {
                Console.Write("Enter a list of numbers, type 0 when finished. ");
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

        // Calculate sum & largest number
        int sum = 0;
        double largest = double.NegativeInfinity;   
        foreach (int number in numbers)
        {
            sum += number;

            if (number > largest)
            {
                largest = number;
            }

        }
        Console.WriteLine($"The sum is: {sum}");

        //Calculate average
        double average = (double)sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        //Display largest number
        Console.WriteLine($"The largest number is: {largest}");
    }
}