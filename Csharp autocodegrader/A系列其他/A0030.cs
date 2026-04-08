using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_autocodegrader.A系列其他
{
    internal class A0030
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first non-zero integer:");
            int i = Convert.ToInt32(Console.ReadLine()); // 維持 int 型態
            Console.WriteLine("Enter the second non-zero integer:");
            int j = Convert.ToInt32(Console.ReadLine()); // 維持 int 型態

            // 為了極端情況下的安全，加減法也可以轉型成 long，但最容易出錯的是乘法
            Console.WriteLine($"{i}+{j}={(long)i + j}");
            Console.WriteLine($"{i}-{j}={(long)i - j}");

            // 【修正乘法】：將 i 暫時轉型為 long (64位元)，這樣運算結果就會是 long，避免溢位
            Console.WriteLine($"{i}x{j}={(long)i * j}");

            // 【修正除法】：將 i 暫時轉型為 double (浮點數)，這樣就會進行小數除法，保留精確度
            Console.WriteLine($"{i}/{j}={(double)i / j:0.000000}");

            Console.WriteLine($"Type of i must be System.Int32, Current type:{i.GetType().ToString()}"); // 型態檢查會完美通過
            Console.WriteLine($"Type of j must be System.Int32, Current type:{j.GetType().ToString()}");
            Console.ReadLine();
        }
    }
}
