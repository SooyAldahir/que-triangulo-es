using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace que_triangulo_es
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] lados = new double[3];
            Console.WriteLine("Ingrese los 3 valores: ");
            for (int i = 0; i < 3; i++)
                lados[i] = double.Parse(Console.ReadLine());
            {
                if ((lados[0] == lados[1]) & (lados[1] == lados[2]) & (lados[2] == lados[0]))
                {
                    Console.WriteLine("El triangulo es Equilatero");
                }
                else if (lados[0] == lados[1] & lados[1] != lados[2] || lados[1] == lados[2] & lados[2] != lados[0] || lados[2] == lados[0] & lados[0] != lados[1])
                    {
                        Console.WriteLine("El triangulo es Isoseles");
                    }
                else
                {
                    Console.WriteLine("El trinagulo es escaleno");
                }        
                
            }

            Console.ReadKey();
        }
    }
}
