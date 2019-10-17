using System;
namespace JobConsole5
{
    class Program
    {
        static void Main(string[] args)
        {
            int Cantidad = 0;
            string Data1 = "";
            Console.WriteLine(".................INGRESE EL TAMAÑO DE LA PIRAMIDE.................."); 
            Data1= Console.ReadLine();
            Cantidad = Convert.ToInt32(Data1);
            int Numumero2 = 0;
            for (int C = 0; C <= CANTIDAD; C++)
            {    
                for (int K= 0; K <= CANTIDAD-C; K++)
                { 
                    Console.Write(" ");
                }
                for (int H = 1; H <= 2 * C - 1; H++)
                {               
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
            Console.ReadKey();
        }
    }
}