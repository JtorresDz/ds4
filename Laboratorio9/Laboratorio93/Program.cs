using System;

namespace Laboratorio93
{
    class Program
    {
        static void Main(string[] args)
        {
            int l1, l2, l3;
            Console.Write("Ingrese el valor del lado 1: ");
            l1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor del lado 2: ");
            l2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor del lado 3: ");
            l3 = int.Parse(Console.ReadLine());
            if ((l1 + l2 > l3) || (l1 + l3 > l2) || (l2 + l3 > l1))
            {
                IdentificarTri it = new IdentificarTri();
                it.TipoTriangulo(l1, l2, l3);
            }
            else
            {
                Console.WriteLine("Los valores ingresados no forman un triángulo");
            }
        }
    }
}
    
