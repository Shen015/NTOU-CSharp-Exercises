using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_autocodegrader.A系列其他
{
    internal class A3000
    {
        static void Main(string[] args)
        {
            int i = 100;
            object ob1 = i;  // 裝箱：將 int 放入 object
            object ob2 = 2.1; // 裝箱：C# 中有小數點的數字預設為 double，所以這裡是將 double 放入 object

            // 修正 1：ob2 裡面裝的是 double，所以必須先拆箱成 double，才能跟 int 相加
            double ob3 = i + (double)ob2;

            Console.WriteLine(ob1.GetType().ToString());//勿更動
            Console.WriteLine(ob2.GetType().ToString());//勿更動
            Console.WriteLine(ob3.GetType().ToString());//勿更動

            // 修正 2：ob1 裡面裝的是 int，必須先拆箱成 (int)，然後系統會自動隱含轉型給 double x
            double x = (int)ob1;

            // 修正 3：ob2 裡面裝的是 double，必須先拆箱成 (double)，再用 (int) 強制轉型去掉小數點
            int y = (int)(double)ob2;

            // 修正 4：ob3 本身就是 double 變數 (沒有被裝箱)，要把 double 塞進比較小的 float，必須強制轉型成 (float)
            float z = (float)ob3;

            Console.WriteLine(x);//勿更動
            Console.WriteLine(y);//勿更動
            Console.WriteLine(z);//勿更動
            Console.WriteLine(ob1.GetType().ToString());//勿更動
            Console.WriteLine(ob2.GetType().ToString());//勿更動
            Console.WriteLine(ob3.GetType().ToString());//勿更動
            Console.ReadLine();//勿更動
        }
    }
}
