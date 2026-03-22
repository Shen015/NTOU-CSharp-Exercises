using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_autocodegrader.第一次作業
{
    internal class A0003
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a date/time in format of MM/dd/yyyy HH:mm:ss, HH is in 24h format."); //勿動
            string s = Console.ReadLine();//勿動
            DateTime d = Convert.ToDateTime(s);//勿動

            // 1. 改輸出成 2022/05/01 13:21:05 (數字都需補零)
            Console.WriteLine($"{d:yyyy/MM/dd HH:mm:ss}");

            // 2. 改輸出成 2022年5月1日 下午1點21分5秒 (數字都不需補零，下午與點數不留空格)
            // 將 tt 與 h 直接連寫即可：tth
            Console.WriteLine($"{d:yyyy年M月d日 tth點m分s秒}");

            // 3. 改輸出成 2022年5月1日是星期X (數字都不需補零)
            Console.WriteLine($"{d:yyyy年M月d日是dddd}");

            Console.ReadLine();//勿動
        }
    }
}
