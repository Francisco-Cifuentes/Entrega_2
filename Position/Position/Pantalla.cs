using System;
using System.Collections.Generic;
using System.Text;

namespace Position
{
    class Pantalla
    {
        public void principal()
        {
            Console.Clear();
            for (int i = 40; i <= 80; i++)
            {
                Console.SetCursorPosition(i, 2); Console.WriteLine("═");
                Console.SetCursorPosition(i, 6); Console.WriteLine("═");
                Console.SetCursorPosition(i, 23); Console.WriteLine("═");
                Console.SetCursorPosition(i, 25); Console.WriteLine("═");
            }

            Console.SetCursorPosition(40, 6); Console.WriteLine("╠");
            Console.SetCursorPosition(81, 6); Console.WriteLine("╣");

            Console.SetCursorPosition(40, 2); Console.WriteLine("╔");
            Console.SetCursorPosition(40, 23); Console.WriteLine("╠");
            Console.SetCursorPosition(40, 25); Console.WriteLine("╚");
            Console.SetCursorPosition(81, 2); Console.WriteLine("╗");
            Console.SetCursorPosition(81, 23); Console.WriteLine("╣");
            Console.SetCursorPosition(81, 25); Console.WriteLine("╝");

            for (int i = 7; i < 23; i++)
            {
                Console.SetCursorPosition(40, i); Console.WriteLine("║");
                Console.SetCursorPosition(81, i); Console.WriteLine("║");
            }
            Console.SetCursorPosition(40, 24); Console.WriteLine("║");
            Console.SetCursorPosition(81, 24); Console.WriteLine("║");

            for (int i = 3; i <= 5; i++)
            {
                Console.SetCursorPosition(40, i); Console.WriteLine("║");
                Console.SetCursorPosition(81, i); Console.WriteLine("║");
            }
        }

        public void qui_som()
        {
            Console.Clear();
            for (int i = 40; i <= 80; i++)
            {
                Console.SetCursorPosition(i, 2); Console.WriteLine("═");
                Console.SetCursorPosition(i, 6); Console.WriteLine("═");
                Console.SetCursorPosition(i, 24); Console.WriteLine("═");
            }

            Console.SetCursorPosition(40, 6); Console.WriteLine("╠");
            Console.SetCursorPosition(81, 6); Console.WriteLine("╣");

            Console.SetCursorPosition(40, 2); Console.WriteLine("╔");
            Console.SetCursorPosition(81, 2); Console.WriteLine("╗");
            Console.SetCursorPosition(40, 24); Console.WriteLine("╚");            
            Console.SetCursorPosition(81, 24); Console.WriteLine("╝");

            for (int i = 7; i < 24; i++)
            {
                Console.SetCursorPosition(40, i); Console.WriteLine("║");
                Console.SetCursorPosition(81, i); Console.WriteLine("║");
            }           

            for (int i = 3; i <= 5; i++)
            {
                Console.SetCursorPosition(40, i); Console.WriteLine("║");
                Console.SetCursorPosition(81, i); Console.WriteLine("║");
            }
        }
    }
}
