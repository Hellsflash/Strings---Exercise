using System;
using System.Text;

namespace _03.Unicode_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            var result = GetUnicodeString(line);

            Console.WriteLine(result);

        }
        public static string GetUnicodeString(string s)
        {
            var sb = new StringBuilder();
            foreach (char c in s)
            {
                sb.Append("\\u");
                sb.Append(String.Format("{0:x4}", (int)c));


            }
            return sb.ToString();
        }
    }
}
