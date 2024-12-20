using System;

namespace HTML_Editor
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
        //  Console.BackgroundColor = ConsoleColor.Yellow;
        //  Console.ForegroundColor = ConsoleColor.White;
            Console.Title = "HTerm";
            int width = 40;
            int height = 8;
            
            DrawScreen(width, height);
            Options();
            var option = int.Parse(Console.ReadLine());
        }

        public static void DrawScreen(int width, int height)
        {
            LinesScreen(width, height);
            for (int lines = 0; lines <= height; lines++)
            {
                Console.Write("|");
                for (int i = 0; i <= width; i++)
                    Console.Write(" ");
                Console.Write("|");
                Console.Write("\n");
            }
            LinesScreen(width, height);
        }

        public static void LinesScreen(int width, int height)
        {
            Console.Write("+");
            for (int i = 0; i <= width; i++)
                Console.Write("-");
            Console.Write("+");
            Console.Write("\n");
        }

        public static void Options()
        {
            var nameSystem = "Welcome to HTerm!";
            
            Console.SetCursorPosition(3, 2);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(nameSystem);
            Console.ResetColor();
            
            Console.SetCursorPosition(3, 3);
            Console.Write(new string('-', nameSystem.Length));
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(3, 5);
            Console.Write("[1] - Carregar arquivo");
            
            Console.SetCursorPosition(3, 6);
            Console.Write("[2] - Abrir arquivo");
            
            Console.SetCursorPosition(3, 7);
            Console.Write("[0] - Sair");
            Console.ResetColor();
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(3, 9);
            Console.Write(">> Opcao: ");
            Console.ResetColor();
        }
    }
}

