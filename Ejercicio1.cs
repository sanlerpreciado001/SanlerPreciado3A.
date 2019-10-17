using System;

namespace SanlerPreciado2c
{
    class Ejercicio1
    {
        static void Main(string[] args)
        {
            int Cantidad, Número, Mayor = 0;
            Console.WriteLine("el numero maximo es:");

            Cantidad = int.Parse(Console.ReadLine());
            for (int i = 0; i < Cantidad; i++)
            {
                Console.WriteLine("Escriba un Número:");
                Número = int.Parse(Console.ReadLine());

                if (i == 0)
                {
                    Mayor = Número;
            }
                    else if (i == 0)
            {
            }
            else if (Número > Mayor)
            {
                Mayor = Número;
            }
        }
        Console.Write("El número mayor es:"+Mayor);
        Console.ReadKey();
}
    }
}
