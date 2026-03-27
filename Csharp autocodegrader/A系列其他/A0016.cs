using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_autocodegrader.A系列其他
{
    internal class A0016
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請入正整數字N=");
            string sN = Console.ReadLine();
            int N = Convert.ToInt32(sN);

            Console.WriteLine("請入正整數字M=");
            string sM = Console.ReadLine();
            int M = Convert.ToInt32(sM);

            // 修正 1：在 N 前面加上 (float) 進行強制轉型，讓系統執行浮點數除法
            float f = (float)N / M;

            // 修正 2：利用之前學過的字串內插 ($"")，並加上 :F4 來四捨五入到小數點後第四位
            Console.WriteLine($"{N}/{M}={f:F4}");

            // 以下勿動
            Console.WriteLine($"Typeof f is {f.GetType().ToString()}.");
            Console.ReadLine();
        }
    }
}
