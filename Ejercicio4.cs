using System;
namespace JobConsole4
{
    class sueldo
    {
        static void Main(string[] args)
        {
            int Horas = 0, SalarioN = 0, SalarioM = 0, extra = 0;
            string Data1 = "", Data2 = "", Data3 = "si", Nombre = "";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("¡Calculadora de salarios!");
            Console.ForegroundColor = ConsoleColor.White;
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Ingrese el total de horas que trabajó en la semana:");
                Data1 = Console.ReadLine();
                Horas = Convert.ToInt32(Data1);
                if (Horas <= 35)
                {
                    SalarioN = Horas * 15;
                    Console.WriteLine("Su salario total es:{0}$", SalarioN);
                    Console.WriteLine("¡Gracias!");
                }
                else
                {
                    extra = (Horas - 35) * 22;
                    SalarioM = ((Horas - 35) * 22 + (35 * 15));
                    Console.WriteLine("Horas entras:{0}", (Horas - 35));
                    Console.WriteLine("Dinero extra:{0}$", extra);
                    Console.WriteLine("Su salario total es:{0}$", SalarioM);
                    Console.WriteLine("¡Gracias!");
                }
                Console.WriteLine("¿Desea ingresar otro salario?");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("[si]    ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[no]");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Data2 = Console.ReadLine();
            } while (Data2 == Data3);
            Console.WriteLine("Finalizó el programa.");

            Console.ReadKey();
        }
    }
}
