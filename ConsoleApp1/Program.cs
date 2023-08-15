using System;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an option to try:");
            Console.WriteLine("1. Sum of Array Values");
            Console.WriteLine("2. Last Position of Smallest Number");
            Console.WriteLine("3. Check for Palindrome");
            Console.WriteLine("4. Sort Six Numbers in Descending Order");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter numbers separated by spaces:");
                    string input = Console.ReadLine();
                    string[] numbersStr = input.Split(' ');

                    int[] numbers = new int[numbersStr.Length];

                    for (int i = 0; i < numbersStr.Length; i++)
                    {
                        numbers[i] = int.Parse(numbersStr[i]);
                    }

                    int sum = SumArray(numbers);
                    Console.WriteLine($"Total Array : {sum}");
                    break;

                case 2:
                    int[] table = { 8, 5, 2, 8, 6, 3, 7, 2, 5, 5 };
                    int position = FindLastPositionOfSmallest(table);
                    Console.WriteLine($"Last position of the smallest number : {position}");
                    break;

                case 3:
                    Console.WriteLine("Enter a text or number:");
                    string inp = Console.ReadLine();

                    bool isPalindrome = IsPalindrome(inp);
                    Console.WriteLine($"Is palindrome ? : {isPalindrome}");
                    break;

                case 4:
                    int[] num = ReadNumbers();
                    Array.Sort(num);
                    Array.Reverse(num);

                    PrintNumbers(num);
                    break;

                default:
                    Console.WriteLine("Invalid Number");
                    break;
            }
        }

        static int SumArray(int[] array)
        {
            int sum = 0;
            foreach (int num in array)
            {
                sum += num;
            }
            return sum;
        }

        static int FindLastPositionOfSmallest(int[] table)
        {
            int smallest = int.MaxValue;
            int lastPosition = -1;

            for (int pos = 0; pos < table.Length; pos++)
            {
                if (table[pos] < smallest)
                {
                    smallest = table[pos];
                    lastPosition = pos + 1; // Adding 1 to match the position index
                }
            }

            return lastPosition;
        }

        static bool IsPalindrome(string input)
        {
            string text = input.ToLower().Replace(" ", "").Replace(".", "").Replace(",", "");

            int left = 0;
            int right = text.Length - 1;

            while (left < right)
            {
                if (text[left] != text[right])
                    return false;

                left++;
                right--;
            }

            return true;
        }

        static int[] ReadNumbers()
        {
            Console.WriteLine("Enter six numbers separated by spaces:");
            string input = Console.ReadLine();
            string[] numbersStr = input.Split(' ');

            int[] numbers = new int[6];

            for (int i = 0; i < 6; i++)
            {
                numbers[i] = int.Parse(numbersStr[i]);
            }

            return numbers;
        }

        static void PrintNumbers(int[] numbers)
        {
            for (int i = 0; i < 6; i++)
            {
                Console.Write(numbers[i]);
                if (i < 5)
                {
                    Console.Write(" ");
                }
            }

            Console.WriteLine();
        }
    }
}
