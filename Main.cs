// Made by Benjamin Espenschied
// V1.9

using System;

namespace myProgram
{
    class Grid
    {
        public int gridX;
        public int gridY;
        public string[,] gridData;
        
        public Grid(int X, int _Y)
        {
            gridX = X;
            gridY = _Y; 
            gridData = new string[X, _Y];
            for (int i = 0; i < gridX; i++) 
            {
                for (int j = 0; j < gridY; j++)
                {
                    gridData[i, j] = " ";
                };
            };
        }
        
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
            Grid level01 = new Grid(7, 3);
            level01.drawGrid();
        }
    }
}
