using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1_LasNiñas {} 

internal class Program
{
    static void Main(string[] args)
    {
        double m, p1, p2, p3, p4, m1, m2, m3, m4;
        int e1, e2, e3, e4, s;
        Console.WriteLine("Ingrese el monto a respartir");
        m = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese las edades de las 4 niñas");
        e1 = Convert.ToInt32(Console.ReadLine());
        e2 = Convert.ToInt32(Console.ReadLine());
        e3 = Convert.ToInt32(Console.ReadLine());
        e4 = Convert.ToInt32(Console.ReadLine());
        s = e1 + e2 + e3 + e4;
        p1 = (double)e1 / s * 100;
        p2 = (double)e2 / s * 100;
        p3 = (double)e3 / s * 100;
        p4 = (double)e4 / s * 100;
        m1 = p1 * m / 100;
        m2 = p2 * m / 100;
        m3 = p3 * m / 100;
        m4 = p4 * m / 100;
        Console.WriteLine("Niña edad:  " + e1 + "Porcentaje asignado:"  + p1.ToString("F2") + "%" + "Monto asignado: $" + m1.ToString("F2"));
        Console.WriteLine("Niña edad:  "+ e2 + "Porcentaje asignado:"  + p2.ToString("F2") + "%" + "Monto asignado: $" + m2.ToString("F2"));
        Console.WriteLine("Niña edad:  "+ e3 + "Porcentaje asignado:"  + p3.ToString("F2") + "%" + "Monto asignado: $" + m3.ToString("F2"));
        Console.WriteLine("Niña edad:  "+ e4 + "Porcentaje asignado:"  + p4.ToString("F2") + "%" + "Monto asignado: $" + m4.ToString("F2"));


        
    }
}
