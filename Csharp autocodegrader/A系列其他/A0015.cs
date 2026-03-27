using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_autocodegrader.A系列其他
{
    internal class A0015
    {
        static void Main(string[] args)
        {
            // 系統可能會預先放入其他的數值進行測試
            int M = 1597; //輸入自己的
            int N = 61;

            // your code here
            // 計算商數與餘數，並利用字串內插 ($"") 格式化輸出
            Console.WriteLine($"{M}除以{N}={M / N}餘{M % N}");

            Console.ReadLine();
        }
    }
}
