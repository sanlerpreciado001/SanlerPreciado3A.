using System;
namespace JobConsole8
{
    class Numerosenteros
    {
        static void Main(string[] args)
        {
            int NumberE = 0, Y = 2, W = 3;
            string Data1 = "";
            Console.WriteLine("REGISTRE UN NUMERO ENTERO:");
            Data1 = Console.ReadLine();
            NumberE = Convert.ToInt32(Data1);
            if (NumberE > 0)
            {
                Console.WriteLine("1 EN 1    2 EN 2     3 EN 3");
                for (int C = 1; C <= NumberE; C++)
                {
                    Console.WriteLine("   {0}         {1}        {2}", C, Y, W);
                    Y = Y + 2;
                    W = W + 3;

                }
            }
            else
            {
                Console.WriteLine("USTED REGISTRO UN DIGITO ERRÓNEO.");
            }


            Console.ReadKey();
        }
    }
}