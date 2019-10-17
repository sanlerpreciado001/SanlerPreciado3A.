using System;

namespace ConsoleApp6
{

            class Program
        {
            static void Main(string[] args)
            {
                int Operador = 0;
                string Data1 = "";
                do
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("..................................................");
                    Console.WriteLine("..................................................");
                    Console.WriteLine("..........................MENÚ...............................");
                    Console.WriteLine("............1)............Salir....................");
                    Console.WriteLine(".............2).........Sumatoria.................");
                    Console.WriteLine("..............3)        Factorización............");
                    Console.WriteLine("..................................................");
                    Console.WriteLine("................................................ ");
                    Console.WriteLine();
                    Console.WriteLine("¡SELECIONE UNA OPCIÓN!");
                    Console.WriteLine();
                    Data1 = Console.ReadLine();
                    Operador = Convert.ToInt32(Data1);
                    if (Operador == 1 || Operador == 2 || Operador == 3)
                    {

                        if (Operador == 1)
                        {
                            Console.WriteLine("FINALIZO EL PROGRAMA");
                        }
                        else
                        {
                            if (Operador == 2)
                            {
                                int Number1 = 0, S = 0, X = 1;
                                string Data2 = "";
                                Console.WriteLine();
                                Console.WriteLine("Ingrese un digito para la operación.");
                                Data2 = Console.ReadLine();
                                Number1 = Convert.ToInt32(Data2);
                                Console.WriteLine();
                                for (int Z = 0; Z <= Number1 - 1; Z++)
                                {
                                    Console.Write("{0,8}\t", X);
                                    S = S + X;
                                    X = X + 1;

                                }
                                Console.WriteLine();
                                Console.WriteLine("La Sumatoria es:{0,10:N0}", S);
                            }
                                                      if (Operador == 3)
                            {
                                int Number2 = 0, I = 2;
                                double Number3 = 1;
                                string Data3 = "";
                                Console.WriteLine("Ingrese un digito para la operación.");
                                Data3 = Console.ReadLine();
                                Number2 = Convert.ToInt32(Data3);
                                while (I <= Number2)
                                {
                                    Number3 *= I;
                                    I++;

                                }
                                Console.WriteLine("La Factorizacion da:\n{0:N0}", Number3);
                            }
                        }

                    }
                    else
                    {
                        Console.WriteLine("¡NO EXISTE ESA OPCION!");
                    }

                } while (Operador != 1);
                Console.ReadKey();
            }
        }
    }
