using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_autocodegrader.A系列其他
{
    internal class A0020
    {
        static void Main(string[] args)
        {
            // 讀取使用者輸入的數字
            int n = Convert.ToInt32(Console.ReadLine());

            // for 迴圈設定：
            // 1. 初始值：讓 i 等於 n
            // 2. 執行條件：只要 i 大於等於 1 就繼續執行
            // 3. 步進值：每次執行完後，i 減 1 (i--)
            for (int i = n; i >= 1; i--)
            {
                // 使用 WriteLine，這樣每次印出數字後就會自動換行
                Console.WriteLine(i);
            }

            // 迴圈結束後（代表倒數到 1 了），印出新年快樂
            Console.WriteLine("Happy New Year!");
        }
    }
}
