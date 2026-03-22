using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_autocodegrader.第一次作業
{
    internal class A0007
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入品名1");
            string s1 = Console.ReadLine();
            Console.WriteLine("輸入品名1的數量(長整數)");
            long q1 = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("輸入代表品名1的價格(倍精度實數)");
            double a1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("輸入品名2");
            string s2 = Console.ReadLine();
            Console.WriteLine("輸入品名2的數量(長整數)");
            long q2 = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("輸入代表品名2的價格(倍精度實數)");
            double a2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("輸入品名3");
            string s3 = Console.ReadLine();
            Console.WriteLine("輸入品名3的數量(長整數)");
            long q3 = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("輸入代表品名3的價格(倍精度實數)");
            double a3 = Convert.ToDouble(Console.ReadLine());

            // --- 需修改地方以下，已完成排版 ---

            Console.WriteLine("Bill:");

            // 標題列：Item 向左對齊(-20)，其餘向右對齊(20)
            Console.WriteLine("{0,-20}{1,20}{2,20}{3,20}", "Item", "Amount", "Unit Price", "Subtotal");

            // 內容列：s(品名)向左對齊(-20)，q(數量)向右(20)，a(單價)與小計向右且取兩位小數(20:F2)
            Console.WriteLine("{0,-20}{1,20}{2,20:F2}{3,20:F2}", s1, q1, a1, q1 * a1);
            Console.WriteLine("{0,-20}{1,20}{2,20:F2}{3,20:F2}", s2, q2, a2, q2 * a2);
            Console.WriteLine("{0,-20}{1,20}{2,20:F2}{3,20:F2}", s3, q3, a3, q3 * a3);

            // 總計列：算好總額後印出。
            // 為了讓 Total 的數字對齊在最後一排，前三個欄位(Item, Amo, Price)加起來剛好佔了 60 個字元寬度
            // 所以我們讓 "Total" 這個字串向左對齊並佔用 60 個字元，總額一樣給 20 個字元向右對齊並取兩位小數
            double totalAmount = (q1 * a1) + (q2 * a2) + (q3 * a3);
            Console.WriteLine("{0,-60}{1,20:F2}", "Total", totalAmount);

            Console.ReadLine();
        }
    }
}
