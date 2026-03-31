using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_autocodegrader.A系列其他
{
    internal class A0018
    {
        static void Main(string[] args)
        {
            // 1. 讀取輸入的整數
            Console.WriteLine("Enter positive integer A(<50000):");
            int A = Convert.ToInt32(Console.ReadLine()); // 將字串轉換為整數

            Console.WriteLine("Enter positive integer B(<50000):");
            int B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter positive integer C(<50000):");
            int C = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter positive integer D(<50000):");
            int D = Convert.ToInt32(Console.ReadLine());

            // 2. 顯示 A, B, C, D 的十進位與二進位結果
            // {A, 6} 代表向右對齊並佔用 6 個字元寬度
            Console.WriteLine($"A={A,6}=0x{Convert.ToString(A, 2).PadLeft(18, '0')}");
            Console.WriteLine($"B={B,6}=0x{Convert.ToString(B, 2).PadLeft(18, '0')}");
            Console.WriteLine($"C={C,6}=0x{Convert.ToString(C, 2).PadLeft(18, '0')}");
            Console.WriteLine($"D={D,6}=0x{Convert.ToString(D, 2).PadLeft(18, '0')}");

            // 3. 顯示運算式與結果
            Console.WriteLine($"(A<<2 XOR B<<2) OR (C>>2 AND D>>2)");

            // 4. 修正位元運算式：將 XOR 換成 ^，OR 換成 |，AND 換成 &
            int R = ((A << 2) ^ (B << 2)) | ((C >> 2) & (D >> 2));

            var s = Convert.ToString(R, 2).PadLeft(18, '0');

            // 5. 輸出最終結果
            // 注意題目輸出範例中，等號前面有一個空格 " ="
            Console.WriteLine($" ={R,6}=0x{s}");

            Console.ReadLine();
        }

    }
}
