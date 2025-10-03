using System;

namespace Laboratorio95
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un primer numero: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese un segundo numero: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el tamaño del arreglo: ");
            int nA = int.Parse(Console.ReadLine());
            Aleatorios alt = new Aleatorios();
            alt.GenerarArre(nA, n1, n2);
            Console.Clear();
            Console.Write("El arreglo de tamaño " + nA + " con numeros aleatorios entre " + n1 + " y " + n2 + " es: ");
            Console.Write(string.Join(", ", alt.GenerarArre(nA, n1, n2)));
            Console.WriteLine("\n\n");
            Console.ReadLine();
        }
    }
}