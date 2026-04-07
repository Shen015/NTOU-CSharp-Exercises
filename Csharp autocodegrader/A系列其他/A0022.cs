using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_autocodegrader.A系列其他
{
    internal class A0022
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string s = Console.ReadLine();

            // 1. 處理使用者輸入的字串
            // 迴圈從長度 1 開始，直到字串的總長度
            for (int i = 1; i <= s.Length; i++)
            {
                // Substring(0, i) 代表從索引 0 開始，擷取長度為 i 的字串
                Console.WriteLine(s.Substring(0, i));
            }

            // 2. 設定你的 username (如果你的 username 不同，可以直接修改這裡)
            string username = "Shen015";

            // 3. 如法炮製，處理 username
            for (int i = 1; i <= username.Length; i++)
            {
                Console.WriteLine(username.Substring(0, i));
            }

            Console.ReadLine();
        }
    }
}
