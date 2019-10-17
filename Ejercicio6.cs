using System;

namespace ConsoleApp9
{
    class ROMBO
    {
        static void Main(string[] args)
        {
            int Numero, Contador = 1;
            string Data1 = "";
            Console.WriteLine("Ingrese el tamaño del rombo:");
            Data1 = Console.ReadLine();
            Numero = Convert.ToInt32(Data1);
            Contador = Numero - 1;
            for (int k = 1; k <= Numero; k++)
            {
                for (int i = 1; i <= Contador; i++)
                    Console.Write(" ");
                Contador--;
                for (int i = 1; i <= 2 * k - 1; i++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Contador = 1;
            for (int k = 1; k <= Numero - 1; k++)
            {
                for (int i = 1; i <= Contador; i++)
                    Console.Write(" ");
                Contador++;
                for (int i = 1; i <= 2 * (Numero - ) - 1; i++)
                    Console.Write("*");
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}