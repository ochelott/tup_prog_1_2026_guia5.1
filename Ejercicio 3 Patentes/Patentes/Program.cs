using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patentes
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Random rnd = new Random();
            int n, n2, p1, p2, p3, d1, d2, d3, i;
            string alfabeto, l1, l2, l3, patente = "";
            Console.WriteLine("Ingrese 1 para crear una patente [0 para salir]");
            i = Convert.ToInt32(Console.ReadLine());

            while (i != 0)
            {
                alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                n = rnd.Next(0, 1000);
                n2 = rnd.Next(0, 17576);
                p3 = n2 % 26;
                p2 = (n2 / 26) % 26;
                p1 = (n2 / (26 * 26)) % 26;
                l1 = alfabeto.Substring(p1, 1);
                l2 = alfabeto.Substring(p2, 1);
                l3 = alfabeto.Substring(p3, 1);
                d1 = n % 10;
                d2 = (n / 10) % 10;
                d3 = (n / 100) % 10;
                patente = l1 + l2 + l3 + d1.ToString() + d2.ToString() + d3.ToString();
                Console.WriteLine(patente);
                Console.WriteLine("Ingrese 1 para crear una patente [0 para salir]");
                i = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}