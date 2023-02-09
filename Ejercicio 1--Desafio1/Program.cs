using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1__Desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Perímetro de una elipse";
            Console.WriteLine("Ingrese el valor del radio mayor en centímetros (a): ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor del radio menor en centímetros (b): ");
            double b = double.Parse(Console.ReadLine());

            double perimetro = Math.PI * (3 * (a + b) - Math.Sqrt((3 * a + b) * (a + 3 * b)));

            Console.WriteLine("El perímetro de la elipse es: " + perimetro.ToString("0.000") + " centímetros");
            Console.WriteLine("El perímetro de la elipse es: " + (perimetro / 2.54).ToString("0.000") + " pulgadas");
            Console.ReadLine();
        }
    }
}