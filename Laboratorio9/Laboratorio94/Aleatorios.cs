using System;

namespace Laboratorio94
{
    public class Aleatorios
    {
        private Random random;
        public Aleatorios()
        {
            random = new Random();
        }

        public int GenerarN2(int n1, int n2)
        {
            return random.Next(n1, n2 + 1);
        }

        public int[] GenerarArre(int nA, int n1, int n2)
        {
            int[] arreglo = new int[nA];
            for (int i = 0; i < nA; i++)
            {
                arreglo[i] = random.Next(n1, n2 + 1);
            }
            return arreglo;
        }
    }
}
