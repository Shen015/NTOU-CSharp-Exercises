using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_autocodegrader.A系列其他
{
    internal class A0012
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many cars do you have?(enter N from 0 to 100)");

            // 讀取使用者輸入並轉換為整數
            int N = Convert.ToInt32(Console.ReadLine());

            // 根據 N 的數值進行條件判斷
            if (N == 0)
            {
                Console.WriteLine("You don't have a car.");
            }
            else if (N == 1)
            {
                Console.WriteLine("You have a car.");
            }
            else if (N >= 2 && N <= 100)
            {
                // 使用字串內插 ($"") 將變數 N 帶入字串中
                Console.WriteLine($"You have {N} cars.");
            }

            Console.ReadLine();
        }
    }
}
