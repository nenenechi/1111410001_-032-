using System;

namespace _1111410001_歐修孚_032_整數轉羅馬值
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int num;
            do
            {
                Console.Write("請輸入一個整數（範圍在0到4000之間）：");
                num = int.Parse(Console.ReadLine());
            } while (num < 0 || num > 4000);
            int num1 = num;
            int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] symbols = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            string result = "";
            
            for (int i = 0; i < values.Length; i++)
            {
                while (num >= values[i])
                {
                    num -= values[i];
                    result += symbols[i];
                }
            }
            
            Console.WriteLine($"輸入 num = {num1}");
            Console.WriteLine($"輸出： {result}");
           
        }
    }

}
