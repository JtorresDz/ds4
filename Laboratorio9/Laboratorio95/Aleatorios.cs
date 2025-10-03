using System;

namespace Laboratorio95
{
    public class Aleatorios
    {
        private Random random;
        public Aleatorios()
        {
            random = new Random();
        }
        public int[] GenerarArre(int nA, int n1, int n2)
        {
            int[] arreglo = new int[nA];
            int j = 0;

            while (j < nA)
            {
                int num = random.Next(n1, n2 + 1);
                bool repetido = false;
                for (int i = 0; i < j; i++)
                {
                    if (arreglo[i] == num)
                    {
                        repetido = true;
                        break;
                    }
                }
                if (!repetido)
                {
                    arreglo[j] = num;
                    j++;
                }
            }
            return arreglo;
        }
    }
}
