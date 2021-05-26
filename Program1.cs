using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp38
{
    class lib1
    {
        public static void stpow(string a, int b)
        {
            string aa = " ";
            for (int i = 0; i < b; i++)
            {
                aa += a;
                Console.WriteLine(aa);
            }
        }
        public static void rev(string kk)
        {
            string aaa = " ";
            for (int i = kk.Length - 1; i > -1; i--)
            {
                aaa += kk[i];
            }
            Console.WriteLine(aaa);
        }
        public static string remov(string o, string p, char e)
        {
            o = o.Replace(e, ' ');
            p = o.Replace(" ", "");
            return p;
        }
        public static void leng(string str)
        {
            int k = str.Length;
            Console.WriteLine(k);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //2
            Console.WriteLine("Введите слово:");
            string a;
            a = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите число, сколько раз хотите продублировать данное слово: ");
            int b;
            b = Convert.ToInt32(Console.ReadLine());
            lib1.stpow(a, b);
            //3
            Console.WriteLine("Введите слово:");
            string kk;
            kk = Convert.ToString(Console.ReadLine());
            lib1.rev(kk);
            //4            
            Console.WriteLine("Введите слово:");
            string o = Console.ReadLine();
            Console.WriteLine("Введите символ который хотите удалить из данного слова/строки; ");
            char e = Convert.ToChar(Console.ReadLine());
            string p = " ";
            Console.WriteLine(lib1.remov(o, p, e));
            //5
            Console.WriteLine("Введите слово:");
            string str;
            str = Console.ReadLine();
            lib1.leng(str);

        }
    }
}
