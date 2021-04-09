using System;
using System.Collections.Generic;
using System.Text;

namespace Position
{
    class Opcion
    {
        public void menu_prin()
        {
            Pantalla entorno = new Pantalla();
            int opcion;
            do
            {                
                Console.SetCursorPosition(55, 4); Console.Write("MENU PRINCIPAL");
                Console.SetCursorPosition(45, 9); Console.Write("■  1 «-- Agregar");
                Console.SetCursorPosition(45, 11); Console.Write("■  2 «-- Listar");
                Console.SetCursorPosition(45, 13); Console.Write("■  3 «-- Consultar");
                Console.SetCursorPosition(45, 16); Console.Write("■  0 «-- Menu Anterior");

                Console.SetCursorPosition(45, 24); Console.Write(" Digite una opcion » ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        entorno.principal();
                        Console.SetCursorPosition(55, 4); Console.Write("AGREGAR");
                        Console.SetCursorPosition(44, 16); Console.Write("■ «-- En construccion --» ■");
                        esperar();
                        break;
                    case 2:
                        Console.Clear();
                        entorno.principal();
                        Console.SetCursorPosition(55, 4); Console.Write("LISTAR");
                        Console.SetCursorPosition(44, 16); Console.Write("■ «-- En construccion --» ■");
                        esperar();
                        break;
                    case 3:
                        Console.Clear();
                        entorno.principal();
                        Console.SetCursorPosition(55, 4); Console.Write("CONSULTAR");
                        Console.SetCursorPosition(44, 16); Console.Write("■ «-- En construccion --» ■");
                        esperar();
                        break;
                    case 0:
                        Console.SetCursorPosition(40, 26); Console.WriteLine("Redireccionando al menu anterior");
                        Console.SetCursorPosition(40, 27); Console.Write("Presione enter para salir ...");
                        break;
                    default:
                        Console.SetCursorPosition(46, 19); Console.Write("X× ¡¡¡ Opcion no valida !!! ×X");
                        Console.SetCursorPosition(46, 20); Console.Write("X× Digite una opcion valida ×X");
                        break;
                }
            } while (opcion != 0);
        }

        public void quien_somos()
        {
            Console.SetCursorPosition(55, 4); Console.Write("QUIENES SOMOS");
            Console.SetCursorPosition(52, 10); Console.Write("Francisco Cifuentes");
            Console.SetCursorPosition(52, 11); Console.Write(" © Gaultter_Strong");
            Console.SetCursorPosition(52, 13); Console.Write("Daniel Chacon");
            Console.SetCursorPosition(52, 14); Console.Write(" © PostChacone");
            Console.SetCursorPosition(52, 16); Console.Write("Juan Ducuara");
            Console.SetCursorPosition(52, 17); Console.Write(" © xJuanda");
            Console.SetCursorPosition(52, 19); Console.Write("Diana Carolina");
            Console.SetCursorPosition(52, 20); Console.Write(" © Carito");
            esperar();
        }

        public void esperar()
        {
            Console.SetCursorPosition(40, 26); Console.Write("Presione enter para salir ...");
            Console.ReadKey();
        }
    }
}
