namespace UnitTestingTask;

public static class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please select functionality:");
        Console.WriteLine("1 - counting the maximum number of unequal consecutive characters from an input string");
        Console.WriteLine("2 - determining the maximum number of consecutive identical letters of the Latin alphabet in a line from an input string");
        Console.WriteLine("3 - determining the maximum number of consecutive identical digits from an input string");

        string? selection = Console.ReadLine();

        if (selection is not null)
        {
            switch (selection)
            {
                case "1":
                    Console.WriteLine("Please provide sequence for counting the maximum number of unequal consecutive characters in it");
                    string? input1 = Console.ReadLine();

                    if (input1 is not null)
                    {
                        Console.WriteLine($"\nProvided sequence contains maximum of {MaxUnequalConsecutiveCharacters(input1)} unequal consecutive char(s)");
                    }
                    break;
                case "2":
                    Console.WriteLine("Please provide sequence for determining the maximum number of consecutive identical letters of the Latin alphabet in it");
                    string? input2 = Console.ReadLine();

                    if (input2 is not null)
                    {
                        Console.WriteLine($"\nProvided sequence contains maximum of {MaxConsecutiveIdenticalLetters(input2)} consecutive identical letter(s)");
                    }
                    break;
                case "3":
                    Console.WriteLine("Please provide sequence for determining the maximum number of consecutive identical digits in it");
                    string? input3 = Console.ReadLine();

                    if (input3 is not null)
                    {
                        Console.WriteLine($"\nProvided sequence contains maximum of {MaxConsecutiveIdenticalDigits(input3)} consecutive identical digit(s)");
                    }
                    break;
            }
        }
    }

    public static int MaxUnequalConsecutiveCharacters(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return 0;
        }

        int maxCount = 1;
        int currentCount = 1;

        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] != input[i - 1])
            {
                currentCount++;
            }
            else
            {
                maxCount = Math.Max(maxCount, currentCount);
                currentCount = 1;
            }
        }

        return Math.Max(maxCount, currentCount);
    }

    public static int MaxConsecutiveIdenticalLetters(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return 0;
        }

        int maxCount = 0;
        int currentCount = 0;
        char currentChar = '\0';

        foreach (char c in input)
        {
            if (char.IsLetter(c))
            {
                if (c == currentChar)
                {
                    currentCount++;
                }
                else
                {
                    currentChar = c;
                    currentCount = 1;
                }
            }
            else
            {
                currentCount = 0;
            }

            maxCount = Math.Max(maxCount, currentCount);
        }

        return maxCount;
    }

    public static int MaxConsecutiveIdenticalDigits(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return 0;
        }

        int maxCount = 0;
        int currentCount = 0;
        char currentChar = '\0';

        foreach (char c in input)
        {
            if (char.IsDigit(c))
            {
                if (c == currentChar)
                {
                    currentCount++;
                }
                else
                {
                    currentChar = c;
                    currentCount = 1;
                }
            }
            else
            {
                currentCount = 0;
            }

            maxCount = Math.Max(maxCount, currentCount);
        }

        return maxCount;
    }
}
