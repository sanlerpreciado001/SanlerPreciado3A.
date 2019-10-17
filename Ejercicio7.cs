using System;
namespace JobConsole7
{
    class Program
    {
        static void Main(string[] args)
        {
            int Contador = 0, D = 101;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine        ("FILA DEL 1 AL 100                         FILA DEL 100 AL 1");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            for (int I = 1; I <= 100; I++)
            {
                D--;
                Console.WriteLine      ("      {0,1}                                 {1,2}", I, D);
            }
            Console.ReadKey();

        }
    }
}