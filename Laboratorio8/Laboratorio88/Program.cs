using System;

namespace Laboratorio88
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ClaseConcreta1 contreta1 = new ClaseConcreta1();
            contreta1.printOut();
            Console.WriteLine(contreta1.prefixValor("ES_"));

            ClaseConcreta2 contreta2 = new ClaseConcreta2();
            contreta2.printOut();
            Console.WriteLine(contreta2.prefixValor("ES_"));
        }
    }
}