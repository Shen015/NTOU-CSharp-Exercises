using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_autocodegrader.A系列其他
{
    internal class A0021
    {
        static void Main(string[] args)
        {
            var r = new Random(1);//勿更動
            string s = "將士象車馬砲兵";
            Console.WriteLine($"輸入你想出的棋子:\n1.將\n2.士\n3.象\n4.車\n5.馬\n6.砲\n7.兵");
            int you = Convert.ToInt32(Console.ReadLine());
            int pc = r.Next(1, 8);

            Console.WriteLine($"你:{s.Substring(you - 1, 1)}");
            Console.WriteLine($"電腦:{s.Substring(pc - 1, 1)}");

            // 開始判斷輸贏邏輯
            if (you - pc == 0)
            {
                Console.WriteLine("平手!");
            }
            else if (you - pc > 0)
            {
                // 當 you - pc > 0 時，代表你的數字比電腦大（通常代表你比較小、你輸）
                // 唯一的例外是你出「兵(7)」，電腦出「將(1)」，相減剛好是 6
                if (you - pc == 6)
                {
                    Console.WriteLine("你贏!電腦輸!");
                }
                else
                {
                    Console.WriteLine("電腦贏!你輸!");
                }
            }
            else if (you - pc < 0)
            {
                // 當 you - pc < 0 時，代表你的數字比電腦小（通常代表你比較大、你贏）
                // 唯一的例外是你出「將(1)」，電腦出「兵(7)」，相減剛好是 -6
                // (注意：這裡將原題目的 pc - you == -6 修正為 you - pc == -6)
                if (you - pc == -6)
                {
                    Console.WriteLine("電腦贏!你輸!");
                }
                else
                {
                    Console.WriteLine("你贏!電腦輸!");
                }
            }

            Console.ReadLine();
        }
    }
}
