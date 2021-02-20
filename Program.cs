using System;

namespace DemoStr2Int
{
    class Program
    {
        static void StrToInt(string str)
        {
            int num = 0;
            int n = str.Length;

            for (int i = 0; i < n; i++)
            {
                if (str[i] - 48 < 10) num = num * 10 + (str[i] - 48);
            }

            Console.Write(num);
        }

        static void Main(string[] args)
        {
            string a = "abc573";
            //string b = "a5b7c3";
            StrToInt(a);
            //StrToInt(b);
        }

    }
}
