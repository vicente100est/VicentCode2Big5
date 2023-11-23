using System.Diagnostics;

namespace Triangulo_de_Pascal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch time = new Stopwatch();

            Console.WriteLine("Entre la cantidad de filas");
            int cant = int.Parse(Console.ReadLine());
            time.Start();
            int[,] matriz = new int[cant, cant];

            for (int i = 0; i < cant; i++)
            {
                matriz[i, 0] = 1;
            }

            for(int i =0; i < cant; i++)
            {
                matriz[i, i] = 1;
            }

            for(int i = 2; i < cant; i++)
            {
                for (int j =1; j < i; j++)
                {
                    matriz[i, j] = matriz[i - 1, j] + matriz[i - 1, j - 1];
                }
            }
            
            for (int i = 0; i < cant; i++)
            {
                string fila = "";
                for (int j = 0; j <= i; j++)
                {
                    fila += matriz[i, j] + " ";
                }
                Console.WriteLine(fila);
            }
            
            time.Stop();
            Console.WriteLine($"El algoritmo tarda: {time.Elapsed.TotalSeconds} segundos");
            Console.ReadKey();
        }
    }
}
