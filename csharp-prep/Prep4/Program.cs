using System;
/// <Author>
/// George Olwal
/// </Author>
/// <Summary>
/// C# Prep 4 stretch Challenge
/// This program will ask the user to enter a list of numbers from while inserting on the list until 0 is entered
/// the program then displays the list on the console,
/// calculates and display sum, average, largest number and smallest positive number
/// Sort and display the sorted number list
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

        // Calculate sum, largest number and smallest positive number
        int sum = 0;
        double largest = double.NegativeInfinity;
        double smallestPositive = double.PositiveInfinity;   
        foreach (int number in numbers)
        {
            sum += number;

            if (number > largest)
            {
                largest = number;
            }

            if (number > 0 && number < smallestPositive)
            {
                smallestPositive = number;
            }

        }
        Console.WriteLine($"The sum is: {sum}");

        //Calculate average
        double average = (double)sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        //Display largest number
        Console.WriteLine($"The largest number is: {largest}");

        //Display smallest positive number
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");

        //Sort and display sorted list
        numbers.Sort();
        Console.WriteLine("The sorted list is: ");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}