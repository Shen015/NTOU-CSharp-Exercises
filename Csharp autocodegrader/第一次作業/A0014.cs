using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_autocodegrader.第一次作業
{
    internal class A0014
    {
        static void Main(string[] args)
        {
            // 注意：你題目敘述中的範例是 0x212 + 22011 (結果為 22541)
            // 但你附上的程式碼是 0x212 + 1947，這裡我保留你程式碼裡的數值
            int N = 0x212 + 1947;
            int M = 0b101011010110;

            // 在此加入程式碼並依要求輸出
            // 使用字串內插 (String Interpolation) 的寫法，加上 $ 符號可以讓變數直接寫在 {} 裡面
            Console.WriteLine($"N的十進位表示是:{N}");
            Console.WriteLine($"M的十進位表示是:{M}");

            Console.ReadLine();
        }
    }
}
