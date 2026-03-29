using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_autocodegrader.第二次作業
{
    internal class A0017
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入一個<100000的正整數");
            var s = Console.ReadLine();
            var n = Convert.ToInt32(s);

            // your codes here
            // 1. 將整數 n 分別轉換為 2, 8, 16 進位的字串
            string binStr = Convert.ToString(n, 2);
            string octStr = Convert.ToString(n, 8);

            // 16進位轉換後，直接呼叫 .ToUpper() 將可能出現的小寫 a~f 轉成大寫 A~F
            string hexStr = Convert.ToString(n, 16).ToUpper();

            // 2. 輸出結果，並使用 {1, 20} 讓第二個參數 (轉換後的字串) 向右對齊，佔用 20 個字元寬度
            Console.WriteLine("{0}的 2進位表示為:{1, 20}", n, binStr);
            Console.WriteLine("{0}的 8進位表示為:{1, 20}", n, octStr);
            Console.WriteLine("{0}的16進位表示為:{1, 20}", n, hexStr);

            Console.ReadLine();
        }
    }
}
