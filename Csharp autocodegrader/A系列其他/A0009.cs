using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_autocodegrader.A系列其他
{
    internal class A0009
    {
        enum atoms
        {
            H = 1,
            He = 2,
            Li = 3,
            Be = 4,
            B = 5,
            C = 6,
            N = 7,
            O = 8,
            F = 9,
            Ne = 10,
            Na = 11,
            Mg = 12,
            Al = 13,
            Si = 14,
            P = 15,
            S = 16,
            Cl = 17,
            Ar = 18,
            K = 19,
            Ca = 20,
            Sc = 21,
            Ti = 22,
            V = 23,
            Cr = 24,
            Mn = 25,
            Fe = 26,
            Co = 27,
            Ni = 28,
            Cu = 29,
            Zn = 30,
            Ga = 31,
            Ge = 32,
            As = 33,
            Se = 34,
            Br = 35,
            Kr = 36,
            Rb = 37,
            Sr = 38,
            Y = 39,
            Zr = 40,
            Nb = 41,
            Mo = 42,
            Tc = 43,
            Ru = 44,
            Rh = 45,
            Pd = 46,
            Ag = 47,
            Cd = 48,
            In = 49,
            Sn = 50,
            Sb = 51,
            Te = 52,
            I = 53,
            Xe = 54,
            Cs = 55,
            Ba = 56,
            La = 57,
            Ce = 58,
            Pr = 59,
            Nd = 60,
            Pm = 61,
            Sm = 62,
            Eu = 63,
            Gd = 64,
            Tb = 65,
            Dy = 66,
            Ho = 67,
            Er = 68,
            Tm = 69,
            Yb = 70,
            Lu = 71,
            Hf = 72,
            Ta = 73,
            W = 74,
            Re = 75,
            Os = 76,
            Ir = 77,
            Pt = 78,
            Au = 79,
            Hg = 80,
            Tl = 81,
            Pb = 82,
            Bi = 83,
            Po = 84,
            At = 85,
            Rn = 86,
            Fr = 87,
            Ra = 88,
            Ac = 89,
            Th = 90,
            Pa = 91,
            U = 92,
            Np = 93,
            Pu = 94,
            Am = 95,
            Cm = 96,
            Bk = 97,
            Cf = 98,
            Es = 99,
            Fm = 100,
            Md = 101,
            No = 102,
            Lr = 103,
            Rf = 104,
            Db = 105,
            Sg = 106,
            Bh = 107,
            Hs = 108,
            Mt = 109,
            Ds = 110,
            Rg = 111,
            Cn = 112,
            Nh = 113,
            Fl = 114,
            Mc = 115,
            Lv = 116,
            Ts = 117,
            Og = 118
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an atomic number for finding its elemental symbol:");
            int n = Convert.ToInt32(Console.ReadLine());

            // 1. 將整數 (n) 轉換為 Enum 的名稱字串
            // 使用 typeof(atoms) 告訴程式這是哪個列舉，然後傳入整數 n
            string symb = Enum.GetName(typeof(atoms), n);

            Console.WriteLine($"The elemental symbol for atomic number N={n} is {symb}.");

            Console.WriteLine("Enter an elemental symbol for getting its atomic number:");
            symb = Console.ReadLine();

            // 2. 將字串 (symb) 轉換回整數
            // 先用 Enum.Parse 把字串轉回 atoms 列舉型態，前面再加上 (int) 強制轉型成整數
            n = (int)(atoms)Enum.Parse(typeof(atoms), symb);

            Console.WriteLine($"The atomic number for {symb} is {n}.");

            Console.ReadLine();
        }
    }
}
