using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_PARCIAL_POO
{
    public class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangulo1 = new Triangulo(30, 30, 50);

            triangulo1.InformarSiEsTriangulo();
            triangulo1.InformarTipoTriangulo();
            Console.WriteLine($"El perimetro es: {triangulo1.GetPerimetro()}");
            Console.WriteLine($"La superficie es: {triangulo1.GetSuperficie()}");

            Console.ReadLine();
        }
    }
}
