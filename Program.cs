using System;

namespace DemoStr2Int
{
    class Program
    {
        static void StrToInt(string str)
        {
            int num = 0;
            foreach (char c in str)
            {
                int value = c - '0';
                if (value >= 0 && value < 10) num = (num * 10) + (value);
            }
            Console.WriteLine(num);
        }

        static void Main(string[] args)
        {
            string a = "abc573";
            string b = "a5b7c3";
            StrToInt(a);
            StrToInt(b);
        }

    }
}
