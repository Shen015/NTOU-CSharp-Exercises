using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_autocodegrader.A系列其他
{
    internal class A0023
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            if (n > 0) // 確保 n 大於 0 才執行
            {
                Console.Write(n); // 先毫無顧忌地印出第一個數字

                // 迴圈從 1 開始，只需要跑 n-1 次
                for (int i = 1; i < n; i++)
                {
                    Console.Write(" " + n); // 剩下的每一個前面都自帶一個空白
                }
            }

            Console.WriteLine();
        }
    }
}
