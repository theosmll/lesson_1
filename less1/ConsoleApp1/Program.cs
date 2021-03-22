using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello, World!";
            int width = Console.WindowWidth, height = Console.WindowHeight;
            Print();
            while (true)
            {
                if (width != Console.WindowWidth || height != Console.WindowHeight)
                {
                    width = Console.WindowWidth;
                    height = Console.WindowHeight;
                    Print();
                }
            }

            void Print()
            {
                Console.Clear();
                Console.SetCursorPosition(Console.WindowWidth / 2 - str.Length / 2, Console.WindowHeight / 2);
                Console.WriteLine(str);
            }
        }
    }
}
