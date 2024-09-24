using System;

class Perfect
{
    static void Main()
    {
        Console.Write("Enter a number to check if it is a perfect number: ");
        int number = int.Parse(Console.ReadLine());

        if (perfectCheck(number))
        {
            Console.WriteLine("Perfect number.");
        }
        else //I'm sorry.
        {
            Console.WriteLine("Not a perfect number.");
        }
    }

    static bool perfectCheck(int number) //No shame, I used copilot for this.
    {
        int sum = 0;

        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
            {
                sum += i;
            }
        }

        return sum == number;
    }
}