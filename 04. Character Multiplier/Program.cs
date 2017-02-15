using System;

namespace _04.Character_Multiplier
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var line = Console.ReadLine()
                .Split();

            var firstWord = line[0];
            var secondWord = line[1];

            var sum = 0;

            var minLen = Math.Min(firstWord.Length, secondWord.Length);
            var maxLen = Math.Max(firstWord.Length, secondWord.Length);

            for (int i = 0; i < minLen; i++)
            {
                sum += MultiplyChars(firstWord[i], secondWord[i]);
            }

            if (firstWord.Length != secondWord.Length)
            {
               string longer = firstWord.Length > secondWord.Length ? longer = firstWord : longer = secondWord;

                for (int i = minLen; i < maxLen; i++)
                {
                    sum += longer[i];
                }
            }

            Console.WriteLine(sum);
        }

        public static int MultiplyChars(char firstLett, char secondLett)
        {
            int multiply = firstLett * secondLett;
            return multiply;
        }
    }
}

