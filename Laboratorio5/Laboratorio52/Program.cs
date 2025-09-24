using System;
class Program
{
    private int[,]mat;
    public void Ingresar()
    {
        mat = new int[3,4];
        for (int f = 0; f < 3; f++)
        {
            for (int c = 0; c < 4; c++)
            {
                Console.Write("Ingrese posicion ["+(f+1)+","+(c+1)+"]: ");
                String linea;
                linea = Console.ReadLine();
                mat[f,c] = int.Parse(linea);
            }
        }
    }

    public void Imprimir()
    {
        Console.WriteLine("Los valores de la matriz son: \n");
        for (int f = 0; f < 3; f++)
        {
            for (int c = 0; c < 4; c++)
            {
                Console.Write(mat[f,c]+" ");
            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }

    static void Main(string[] args)
    {
        Program pv = new Program();
        pv.Ingresar();
        pv.Imprimir();
    }
}