using System;

namespace Position
{
    class Program
    {
        static void Main(string[] args)
        {            
            Pantalla entorno = new Pantalla();
            Opcion Menu_opc = new Opcion();            
            int opcion;
            do
            {                
                entorno.principal();
                Console.SetCursorPosition(55, 4); Console.Write(" BIENVENIDO");
                Console.SetCursorPosition(45, 9); Console.Write("■  1 «-- ¿ Quienes somos ?");
                Console.SetCursorPosition(45, 11); Console.Write("■  2 «-- Menu Principal");
                Console.SetCursorPosition(45, 14); Console.Write("■  0 «-- Salir");

                Console.SetCursorPosition(45, 24); Console.Write(" Digite una opcion » ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        entorno.qui_som();
                        Menu_opc.quien_somos();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:                        
                        entorno.principal();
                        Menu_opc.menu_prin();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 0:
                        Menu_opc.esperar();
                        break;
                    default:
                        Console.SetCursorPosition(46, 19); Console.Write("X× ¡¡¡ Opcion no valida !!! ×X");
                        Console.SetCursorPosition(46, 20); Console.Write("X× Digite una opcion valida ×X");
                        break;
                }
            } while (opcion!=0);            
        }        
    }
}
