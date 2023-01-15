// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the largest number finder!");
        if (TryGetConsoleIntParameters(3, out var inputValues))
        {
            var maxValue = int.MinValue;
            foreach(var i in inputValues)
            {
                if (i > maxValue)
                {
                    maxValue = i;
                }
            }

            Console.WriteLine($"\n{maxValue}");
        }
        else
        {
            Console.WriteLine("Sorry, program could not handle inserted value");
        }
    }

    private static bool TryGetConsoleIntParameters(int paramsCount, out List<int> result)
    {
        result = new List<int>();
        for (var i = 1; i <= paramsCount; i++)
        {
            Console.WriteLine($"Please, insert number № {i}:");
            var input = Console.ReadLine();
            if (int.TryParse(input, out var intParam))
            {
                result.Add(intParam);
            }
            else
            {
                return false;
            }
        }

        return true;
    }
}