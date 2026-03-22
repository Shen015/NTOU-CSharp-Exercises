using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_autocodegrader.Chapter1
{
    internal class A0011
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");

            // 1. 讀取使用者輸入的字串
            string input = Console.ReadLine();

            // 2. 將字串轉換為整數 (int)
            int n = int.Parse(input);

            // 3. 根據年齡判斷單複數
            if (n == 1)
            {
                // 當 n 為 1 時，使用單數 year
                Console.WriteLine("You are one year old.");
            }
            else
            {
                // 當 n 大於 1 時，使用複數 years
                Console.WriteLine($"You are {n} years old.");
            }

            Console.ReadLine();
        }
    }
}
