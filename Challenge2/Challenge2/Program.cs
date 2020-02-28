using System;

namespace Carrera_numerica
{
    class Program
    {
        static void Main(string[] args)
        {

            ConsoleKeyInfo op;
            do
            {
                Console.Clear(); //Limpiar la pantalla
                Console.WriteLine("\t\t\t\tMenú \n");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("[A]Nivel basico\t");
                Console.Write("[E]Nivel intermedio\t");
                Console.Write("[B]Nivel avanzado\t");
                Console.Write("[Esc]Salir\t\n\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Seleccione opcion...");
                op = Console.ReadKey(true);
                switch (op.Key)
                {
                    case ConsoleKey.A:
                        Console.WriteLine("Ud seleccionó la opción Nivel basico");
                        do
                        {
                            Console.Clear(); //Limpiar la pantalla
                            Console.WriteLine("\t\t\t\tMenú \n");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("[A]2 jugadores\t");
                            Console.Write("[E]3 jugadores\t");
                            Console.Write("[B]4 jugadores\t");
                            Console.Write("[Esc]Salir\t\n\n");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Seleccione opcion...");
                            op = Console.ReadKey(true);
                            switch (op.Key)
                            {
                                case ConsoleKey.A:
                                    Console.WriteLine("Ud seleccionó la opción 2 jugadores");

                                    Console.WriteLine("Presione 2 para comenzar");

                                    string jugadores2 = Console.ReadLine();


                                    if (!jugadores2.Equals(""))
                                    {

                                        int numero = int.Parse(jugadores2);
                                        int nivel = 20;

                                        Console.WriteLine("Presiona enter para comenzar");
                                        Console.ReadKey();

                                        int[] pun = new int[numero];
                                        int[] par = new int[numero];
                                        int i = 0;

                                        while (pun[i] < nivel || par[i] == 3)
                                        {

                                            Console.WriteLine("\nJugador " + (i + 1) + " presiona enter para tirar los dados");
                                            Console.ReadKey();

                                            int dad = new Random().Next(1, 6);
                                            int dad2 = new Random().Next(1, 6);

                                            if (dad == dad2)
                                            {
                                                par[i]++;
                                            }
                                            else
                                            {
                                                par[i] = 0;
                                            }

                                            pun[i] += dad + dad2;
                                            Console.WriteLine("\nPosicion: " + pun[i]);


                                            if (pun[i] < nivel)
                                            {
                                                i++;
                                            }

                                            if (i == pun.Length)
                                            {
                                                i = 0;
                                            }
                                        }

                                        Console.WriteLine("Jugador " + (i + 1) + " ¡GANASTE!\n");

                                    }

                                    Console.Write("Presione una tecla para continuar...");
                                    Console.ReadKey();
                                    break;
                                case ConsoleKey.E:
                                    Console.WriteLine("Ud seleccionó la opción 3 jugadores");

                                    Console.WriteLine("Presione 3 para comenzar");

                                    string jugadores3 = Console.ReadLine();

                                    if (!jugadores3.Equals(""))
                                    {
                                        int numero = int.Parse(jugadores3);

                                        int nivel = 20;

                                        Console.WriteLine("Presiona enter para comenzar");
                                        Console.ReadKey();

                                        int[] pun = new int[numero];
                                        int[] par = new int[numero];
                                        int i = 0;

                                        while (pun[i] < nivel || par[i] == 3)
                                        {

                                            Console.WriteLine("\nJugador " + (i + 1) + " presiona enter para tirar los dados");
                                            Console.ReadKey();

                                            int dad = new Random().Next(1, 6);
                                            int dad2 = new Random().Next(1, 6);

                                            if (dad == dad2)
                                            {
                                                par[i]++;
                                            }
                                            else
                                            {
                                                par[i] = 0;
                                            }

                                            pun[i] += dad + dad2;
                                            Console.WriteLine("\nPosicion: " + pun[i]);

                                            if (pun[i] < nivel)
                                            {
                                                i++;
                                            }

                                            if (i == pun.Length)
                                            {
                                                i = 0;
                                            }
                                        }

                                        Console.WriteLine("Jugador " + (i + 1) + " ¡GANASTE!\n");

                                    }

                                    Console.Write("Presione una tecla para continuar...");
                                    Console.ReadKey();
                                    break;
                                case ConsoleKey.B:
                                    Console.WriteLine("Ud seleccionó la opción 4 jugadores");

                                    Console.WriteLine("Presione 4 para comenzar");

                                    string jugadores4 = Console.ReadLine();

                                    if (!jugadores4.Equals(""))
                                    {

                                        int numero = int.Parse(jugadores4);

                                        int nivel = 20;

                                        Console.WriteLine("Presiona enter para comenzar");
                                        Console.ReadKey();

                                        int[] pun = new int[numero];
                                        int[] par = new int[numero];
                                        int i = 0;

                                        while (pun[i] < nivel || par[i] == 3)
                                        {

                                            Console.WriteLine("\nJugador " + (i + 1) + " presiona enter para tirar los dados");
                                            Console.ReadKey();

                                            int dad = new Random().Next(1, 6);
                                            int dad2 = new Random().Next(1, 6);

                                            if (dad == dad2)
                                            {
                                                par[i]++;
                                            }
                                            else
                                            {
                                                par[i] = 0;
                                            }

                                            pun[i] += dad + dad2;
                                            Console.WriteLine("\nPosicion: " + pun[i]);


                                            if (pun[i] < nivel)
                                            {
                                                i++;
                                            }

                                            if (i == pun.Length)
                                            {
                                                i = 0;
                                            }
                                        }

                                        Console.WriteLine("Jugador " + (i + 1) + " ¡GANASTE!\n");

                                    }

                                    Console.Write("Presione una tecla para continuar...");
                                    Console.ReadKey();
                                    break;
                                case ConsoleKey.Escape:
                                    Console.WriteLine("Chao");
                                    break;
                            }
                        } while (op.Key != ConsoleKey.Escape);


                        Console.Write("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.E:
                        Console.WriteLine("Ud seleccionó la opción Nivel intermedio");
                        do
                        {
                            Console.Clear(); //Limpiar la pantalla
                            Console.WriteLine("\t\t\t\tMenú \n");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("[A]2 jugadores\t");
                            Console.Write("[E]3 jugadores\t");
                            Console.Write("[B]4 jugadores\t");
                            Console.Write("[Esc]Salir\t\n\n");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Seleccione opcion...");
                            op = Console.ReadKey(true);
                            switch (op.Key)
                            {
                                case ConsoleKey.A:
                                    Console.WriteLine("Ud seleccionó la opción 2 jugadores");

                                    Console.WriteLine("Presione 2 para comenzar");

                                    string jugadores2 = Console.ReadLine();


                                    if (!jugadores2.Equals(""))
                                    {

                                        int numero = int.Parse(jugadores2);
                                        int nivel = 30;

                                        Console.WriteLine("Presiona enter para comenzar");
                                        Console.ReadKey();

                                        int[] pun = new int[numero];
                                        int[] par = new int[numero];
                                        int i = 0;

                                        while (pun[i] < nivel || par[i] == 3)
                                        {

                                            Console.WriteLine("\nJugador " + (i + 1) + " presiona enter para tirar los dados");
                                            Console.ReadKey();

                                            int dad = new Random().Next(1, 6);
                                            int dad2 = new Random().Next(1, 6);

                                            if (dad == dad2)
                                            {
                                                par[i]++;
                                            }
                                            else
                                            {
                                                par[i] = 0;
                                            }

                                            pun[i] += dad + dad2;
                                            Console.WriteLine("\nPosicion: " + pun[i]);


                                            if (pun[i] < nivel)
                                            {
                                                i++;
                                            }

                                            if (i == pun.Length)
                                            {
                                                i = 0;
                                            }
                                        }

                                        Console.WriteLine("Jugador " + (i + 1) + " ¡GANASTE!\n");

                                    }

                                    Console.Write("Presione una tecla para continuar...");
                                    Console.ReadKey();
                                    break;
                                case ConsoleKey.E:
                                    Console.WriteLine("Ud seleccionó la opción 3 jugadores");

                                    Console.WriteLine("Presione 3 para comenzar");

                                    string jugadores3 = Console.ReadLine();


                                    if (!jugadores3.Equals(""))
                                    {

                                        int numero = int.Parse(jugadores3);
                                        int nivel = 30;

                                        Console.WriteLine("Presiona enter para comenzar");
                                        Console.ReadKey();

                                        int[] pun = new int[numero];
                                        int[] par = new int[numero];
                                        int i = 0;

                                        while (pun[i] < nivel || par[i] == 3)
                                        {

                                            Console.WriteLine("\nJugador " + (i + 1) + " presiona enter para tirar los dados");
                                            Console.ReadKey();

                                            int dad = new Random().Next(1, 6);
                                            int dad2 = new Random().Next(1, 6);

                                            if (dad == dad2)
                                            {
                                                par[i]++;
                                            }
                                            else
                                            {
                                                par[i] = 0;
                                            }

                                            pun[i] += dad + dad2;
                                            Console.WriteLine("\nPosicion: " + pun[i]);


                                            if (pun[i] < nivel)
                                            {
                                                i++;
                                            }

                                            if (i == pun.Length)
                                            {
                                                i = 0;
                                            }
                                        }

                                        Console.WriteLine("Jugador " + (i + 1) + " ¡GANASTE!\n");

                                    }

                                    Console.Write("Presione una tecla para continuar...");
                                    Console.ReadKey();
                                    break;
                                case ConsoleKey.B:
                                    Console.WriteLine("Ud seleccionó la opción 4 jugadores");

                                    Console.WriteLine("Presione 4 para comenzar");

                                    string jugadores4 = Console.ReadLine();


                                    if (!jugadores4.Equals(""))
                                    {

                                        int numero = int.Parse(jugadores4);
                                        int nivel = 30;

                                        Console.WriteLine("Presiona enter para comenzar");
                                        Console.ReadKey();

                                        int[] pun = new int[numero];
                                        int[] par = new int[numero];
                                        int i = 0;

                                        while (pun[i] < nivel || par[i] == 3)
                                        {

                                            Console.WriteLine("\nJugador " + (i + 1) + " presiona enter para tirar los dados");
                                            Console.ReadKey();

                                            int dad = new Random().Next(1, 6);
                                            int dad2 = new Random().Next(1, 6);

                                            if (dad == dad2)
                                            {
                                                par[i]++;
                                            }
                                            else
                                            {
                                                par[i] = 0;
                                            }

                                            pun[i] += dad + dad2;
                                            Console.WriteLine("\nPosicion: " + pun[i]);


                                            if (pun[i] < nivel)
                                            {
                                                i++;
                                            }

                                            if (i == pun.Length)
                                            {
                                                i = 0;
                                            }
                                        }

                                        Console.WriteLine("Jugador " + (i + 1) + " ¡GANASTE!\n");

                                    }

                                    Console.Write("Presione una tecla para continuar...");
                                    Console.ReadKey();
                                    break;
                                case ConsoleKey.Escape:
                                    Console.WriteLine("Chao");
                                    break;
                            }
                        } while (op.Key != ConsoleKey.Escape);
                        Console.Write("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.B:
                        Console.WriteLine("Ud seleccionó la opción Nivel avanzado");
                        do
                        {
                            Console.Clear(); //Limpiar la pantalla
                            Console.WriteLine("\t\t\t\tMenú \n");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("[A]2 jugadores\t");
                            Console.Write("[E]3 jugadores\t");
                            Console.Write("[B]4 jugadores\t");
                            Console.Write("[Esc]Salir\t\n\n");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Seleccione opcion...");
                            op = Console.ReadKey(true);
                            switch (op.Key)
                            {
                                case ConsoleKey.A:
                                    Console.WriteLine("Ud seleccionó la opción 2 jugadores");

                                    Console.WriteLine("Presione 2 para comenzar");

                                    string jugadores2 = Console.ReadLine();


                                    if (!jugadores2.Equals(""))
                                    {

                                        int nuumero = int.Parse(jugadores2);
                                        int nivel = 50;

                                        Console.WriteLine("Presiona enter para comenzar");
                                        Console.ReadKey();

                                        int[] pun = new int[nuumero];
                                        int[] par = new int[nuumero];
                                        int i = 0;

                                        while (pun[i] < nivel || par[i] == 3)
                                        {

                                            Console.WriteLine("\nJugador " + (i + 1) + " presiona enter para tirar los dados");
                                            Console.ReadKey();

                                            int dad = new Random().Next(1, 6);
                                            int dad2 = new Random().Next(1, 6);

                                            if (dad == dad2)
                                            {
                                                par[i]++;
                                            }
                                            else
                                            {
                                                par[i] = 0;
                                            }

                                            pun[i] += dad + dad2;
                                            Console.WriteLine("\nPosicion: " + pun[i]);


                                            if (pun[i] < nivel)
                                            {
                                                i++;
                                            }

                                            if (i == pun.Length)
                                            {
                                                i = 0;
                                            }
                                        }

                                        Console.WriteLine("Jugador " + (i + 1) + " ¡GANASTE!\n");

                                    }



                                    Console.Write("Presione una tecla para continuar...");
                                    Console.ReadKey();
                                    break;
                                case ConsoleKey.E:
                                    Console.WriteLine("Ud seleccionó la opción 3 jugadores");

                                    Console.WriteLine("Presione 3 para comenzar");

                                    string jugadores3 = Console.ReadLine();


                                    if (!jugadores3.Equals(""))
                                    {

                                        int numero = int.Parse(jugadores3);
                                        int nivel = 50;

                                        Console.WriteLine("Presiona enter para comenzar");
                                        Console.ReadKey();

                                        int[] pun = new int[numero];
                                        int[] par = new int[numero];
                                        int i = 0;

                                        while (pun[i] < nivel || par[i] == 3)
                                        {

                                            Console.WriteLine("\nJugador " + (i + 1) + " presiona enter para tirar los dados");
                                            Console.ReadKey();

                                            int dad = new Random().Next(1, 6);
                                            int dad2 = new Random().Next(1, 6);

                                            if (dad == dad2)
                                            {
                                                par[i]++;
                                            }
                                            else
                                            {
                                                par[i] = 0;
                                            }

                                            pun[i] += dad + dad2;
                                            Console.WriteLine("\nPosicion: " + pun[i]);


                                            if (pun[i] < nivel)
                                            {
                                                i++;
                                            }

                                            if (i == pun.Length)
                                            {
                                                i = 0;
                                            }
                                        }

                                        Console.WriteLine("Jugador " + (i + 1) + " ¡GANASTE!\n");

                                    }

                                    Console.Write("Presione una tecla para continuar...");
                                    Console.ReadKey();
                                    break;
                                case ConsoleKey.B:
                                    Console.WriteLine("Ud seleccionó la opción 4 jugadores");

                                    Console.WriteLine("Presione 4 para comenzar");

                                    string jugadores4 = Console.ReadLine();


                                    if (!jugadores4.Equals(""))
                                    {

                                        int numero = int.Parse(jugadores4);
                                        int nivel = 50;

                                        Console.WriteLine("Presiona enter para comenzar");
                                        Console.ReadKey();

                                        int[] pun = new int[numero];
                                        int[] par = new int[numero];
                                        int i = 0;

                                        while (pun[i] < nivel || par[i] == 3)
                                        {

                                            Console.WriteLine("\nJugador " + (i + 1) + " presiona enter para tirar los dados");
                                            Console.ReadKey();

                                            int dad = new Random().Next(1, 6);
                                            int dad2 = new Random().Next(1, 6);

                                            if (dad == dad2)
                                            {
                                                par[i]++;
                                            }
                                            else
                                            {
                                                par[i] = 0;
                                            }

                                            pun[i] += dad + dad2;
                                            Console.WriteLine("\nPosicion: " + pun[i]);


                                            if (pun[i] < nivel)
                                            {
                                                i++;
                                            }

                                            if (i == pun.Length)
                                            {
                                                i = 0;
                                            }
                                        }

                                        Console.WriteLine("Jugador " + (i + 1) + " ¡GANASTE!\n");

                                    }

                                    Console.Write("Presione una tecla para continuar...");
                                    Console.ReadKey();
                                    break;
                                case ConsoleKey.Escape:
                                    Console.WriteLine("Chao");
                                    break;
                            }
                        } while (op.Key != ConsoleKey.Escape);
                        Console.Write("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.Escape:
                        Console.WriteLine("Chao");
                        break;
                }
            } while (op.Key != ConsoleKey.Escape);
        }
    }
}