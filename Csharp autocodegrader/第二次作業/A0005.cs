using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_autocodegrader.第二次作業
{
    internal class A0005
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first real number:");
            //輸入例如 12.95
            double A = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second real number:");
            //輸入例如 12.25
            double B = Convert.ToDouble(Console.ReadLine());

            // 判斷邏輯開始
            if (A > B)
            {
                // 如果 A 大於 B，執行這行
                Console.WriteLine($"{A}大於{B}");
            }
            else if (A < B)
            {
                // 如果前面的條件不成立，且 A 小於 B，執行這行
                Console.WriteLine($"{A}小於{B}");
            }
            else
            {
                // 如果前面所有條件都不成立（代表 A 既不大於也不小於 B，那就一定是等於），執行這行
                Console.WriteLine($"{A}等於{B}");
            }

            Console.ReadLine(); //勿動
        }
    }
}
