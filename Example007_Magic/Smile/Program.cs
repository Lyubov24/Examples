using System;
 
namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawSmiley('*', '0', '_');
            Console.ReadKey();
        }
 
        static void DrawSmiley(char face, char eye, char mouth)
        {
            //Face
            for (int i = 0; i < 10; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write(face);
                Console.SetCursorPosition(10, i);
                Console.Write(face);
            }
            for (int i = 0; i < 10; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write(face);
                Console.SetCursorPosition(i, 9);
                Console.Write(face);
            }
 
            //Eyes
            Console.SetCursorPosition(2, 2);
            Console.Write(eye);
            Console.SetCursorPosition(8, 2);
            Console.Write(eye);
            
            //Mouth
            for (int i = 2; i < 9; i++)
            {
                Console.SetCursorPosition(i, 5);
                Console.Write(mouth);
            }
        }
    }
}