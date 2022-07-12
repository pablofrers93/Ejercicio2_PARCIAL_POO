using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_PARCIAL_POO
{
    public class Triangulo
    {
        public int LadoA { get; set; }
        public int LadoB { get; set; }
        public int LadoC { get; set; }

        public Triangulo(int ladoA, int ladoB, int ladoC)
        {
            LadoA = ladoA;
            LadoB = ladoB;
            LadoC = ladoC; 
        }

        public Triangulo()
        {
            LadoA = 1;
            LadoB = 1;
            LadoC = 1;
        }

        private bool Validar()
        {
            return ((LadoA + LadoB) > (LadoC) &&
                    (LadoA + LadoC) > (LadoB) &&
                    (LadoB + LadoC) > (LadoA));
        }

        public void InformarSiEsTriangulo()
        {
            if (Validar())
                Console.WriteLine("Las medidas corresponden a un triangulo");
            else
                Console.WriteLine("Las medidas no correspnden a un triangulo");
        }

        public void InformarTipoTriangulo()
        {
            try
            {
                if (Math.Pow(LadoA, 2) == (Math.Pow(LadoB, 2) + Math.Pow(LadoC, 2)))
                    Console.WriteLine("Triangulo Rectangulo");

                else if (Math.Pow(LadoA, 2) > (Math.Pow(LadoB, 2) + Math.Pow(LadoC, 2)))
                    Console.WriteLine("Triangulo Obtusangulo");

                else if (Math.Pow(LadoA, 2) < (Math.Pow(LadoB, 2) + Math.Pow(LadoC, 2)))
                    Console.WriteLine("Triangulo Acutangulo");
            }
            catch (Exception )
            {

                Console.WriteLine("No se reconoce el tipo de triangulo");
            }
        }

        public int GetPerimetro()
        {
            return LadoA + LadoB + LadoC;
        }

        //√𝑝∗(𝑝−𝐿𝑎𝑑𝑜𝐴)∗(𝑝−𝐿𝑎𝑑𝑜𝐵)∗(𝑝−𝐿𝑎𝑑𝑜𝐶) formula superficie
        public double GetSuperficie()
        {
            return Math.Sqrt(GetSemiPerimetro() * (GetSemiPerimetro() - LadoA) *
                                                  (GetSemiPerimetro() - LadoB) *
                                                  (GetSemiPerimetro() - LadoC));
        }

        private double GetSemiPerimetro()
        {
            return (LadoA + LadoB + LadoC) / 2;
        }
    }
}
