// Made by Benjamin Espenschied
// V1.4

using System;

namespace myProgram
{
    class Grid
    {
        public int gridX;
        public int gridY;
        public string[,] gridData = new string[gridX, gridY];
        
        public Grid(X, Y)
        {
            gridX = X;
            gridY = Y;
        }
        
        public void drawGridLine()
        {
            for (int i = 0; i < gridX; i++) {
                Console.Write("+-");
            };
            Console.WriteLine("+");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
