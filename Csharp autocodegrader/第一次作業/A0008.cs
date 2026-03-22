using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_autocodegrader.第一次作業
{
    internal class A0008
    {
        static void Main(string[] args)
        {
            // your codes start here
            // 記得將 kiki 和 1234@mail.ntou.edu.tw 換成你自己的資訊喔！
            string userName = "Shen015";
            string email = "01489027@mail.ntou.edu.tw";

            // 解析：
            // \"   用來輸出雙引號 (")
            // \\\\ 用來輸出兩個反斜線 (\\) ，因為一個 \ 需要用 \\ 來跳脫
            // \r\n 用來執行 Windows 系統的標準換行
            Console.WriteLine("\"{0}\\\\Username\"\r\n\"{1}\\\\Email\"", userName, email);

            Console.ReadLine();
        }
    }
}
