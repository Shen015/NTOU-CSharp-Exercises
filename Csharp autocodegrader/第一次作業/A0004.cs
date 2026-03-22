using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_autocodegrader.第一次作業
{
    internal class A0004
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a real number:");//勿動
            // 輸入例如 12.05
            string input = Console.ReadLine(); // 讀取輸入
            double x = Convert.ToDouble(input);//勿動

            // 1. 輸出四捨五入到小數點下第一位結果
            // 使用格式化字串 "0.0" 可以達成標準的四捨五入（5 會進位），且強制顯示一位小數
            Console.WriteLine($"{x:0.0}");

            // 2. 輸出四捨六入，五入成雙到小數點下第一位結果
            // Math.Round(數值, 位數, 模式)
            // MidpointRounding.ToEven 就是所謂的「五入成雙」
            double roundedValue = Math.Round(x, 1, MidpointRounding.ToEven);
            // 輸出時使用 :0.0 確保即使是 12.0 也不會省略掉 0
            Console.WriteLine($"{roundedValue:0.0}");

            Console.ReadLine();
        }
    }
}
