using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentele_Programarii_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            S1();
            S2();
            S3();
        }
        private static void S1()
        {///Maximul unei serii collatz
            int max = -1;
            int n = int.Parse(Console.ReadLine());
            while (n != 1)
            {
                if (n > max) max = n;
                if (n % 2 == 0) n = n / 2;
                else n = 3 * n + 1;
            }
            Console.WriteLine(max);
            Console.ReadKey();
        }
        private static void S2()
        {///Numărul de elemente dintr-o serie Collatz determinata de 2 numere
            int a,b,k,aux,nr,max=-1,nmax=-1;
            string[] t = Console.ReadLine().Split(' ');
            a = int.Parse(t[0]);
            b = int.Parse(t[1]);
            if (a > b)
            {
                k = a;
                a = b;
                b = k;
            }
            for (int i = a; i <= b; ++i)
            {
                aux = i;
                nr = 1;
                while (aux != 1)
                {
                    nr = nr + 1;
                    if (aux % 2 == 0) aux = aux / 2;
                    else aux = 3 * aux + 1;
                }
                if (nr > nmax)
                {
                    max = i;
                    nmax = nr;
                }
                    
            }
            Console.WriteLine(nmax+" "+max);
            Console.ReadKey();
        }

        private static void S3()
        {///Numărul de elemente dintr-o serie Collatz
            int n = int.Parse(Console.ReadLine());
            int nr = 1;
            while (n != 1)
            {
                nr = nr + 1;
                if (n % 2 == 0) n = n / 2;
                else n = 3 * n + 1;

            }
            Console.WriteLine(nr);
            Console.ReadKey();


        }
    }
}
