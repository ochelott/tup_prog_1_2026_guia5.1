using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budines
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int masa, masaso, budin, paquetes, cajas;
            Console.WriteLine("Ingrese la cantidad de masa producida en (Gr): ");
            masa = Convert.ToInt32(Console.ReadLine ());
            budin = (masa / 55);
            paquetes = (budin / 12);
            cajas = (paquetes / 20);
            masaso = masa - (budin * 55);
            Console.WriteLine("Cantidad de budines producidos: " + budin);
            Console.WriteLine("Cantidad de paquetes: " + paquetes);
            Console.WriteLine("Cantidad de cajas: " + cajas);
            Console.WriteLine("Cantidad de masa sobrante: " + masaso);

        }

    }

}
