using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_autocodegrader.A系列其他
{
    internal class A0010
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            // 讓變數 i 從 1 開始，一路加到等於 n
            for (int i = 1; i <= n; i++)
            {
                // 判斷：如果 i 已經等於 n (代表是最後一個數字了)
                if (i == n)
                {
                    // 只印出數字，後面不加空白
                    Console.Write(i);
                }
                else
                {
                    // 如果不是最後一個數字，就印出數字加上一個空白
                    Console.Write(i + " ");
                }
            }

            // 迴圈結束後，補上一個換行符號，這是一個好習慣，可以確保命令提示字元版面整潔
            Console.WriteLine();
        }
    }
}
