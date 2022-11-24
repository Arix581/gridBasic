// Made by Benjamin Espenschied
// V1.7.2.1

using System;

namespace myProgram
{
    class Grid
    {
        public int gridX;
        public int gridY;
        
        public Grid(int X, int _Y)
        {
            gridX = X;
            gridY = _Y; 
            
        }
            
        public string[,] gridData = new string[gridX, gridY];
        
        
        public void drawGridLine()
        {
            for (int i = 0; i < gridX; i++) 
            {
                Console.Write("+-");
            };
            Console.WriteLine("+");
        }
        
        public void fillGridData(string[,] data, int column)
        {
            for (int i = 0; i < gridX; i++) 
            {
                Console.Write("|" + data[i, column]);
            };
            Console.WriteLine("|");
        }
        
        public void drawGrid() 
        {
            for (int i = 0; i < gridY; i++) 
            {
                drawGridLine();
                fillGridData(gridData, i);
            };
            drawGridLine();
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
        }
    }
}
