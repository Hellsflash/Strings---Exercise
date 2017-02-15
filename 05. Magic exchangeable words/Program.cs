using System;
using System.Collections.Generic;

namespace _05.Magic_exchangeable_words
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var inputArray = Console.ReadLine().Split();
            List<char> firstWord = new List<char>(inputArray[0]);
            List<char> secondWord = new List<char>(inputArray[1]);
            Console.WriteLine((firstWord.Count == secondWord.Count) ? "true" : "false");
        }
    }
}
