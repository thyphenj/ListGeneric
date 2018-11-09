using System;
using System.Collections.Generic;
using System.Text;

namespace ListGeneric
{
    class Grid
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Cell[,] Cells {get; set;}

        public Grid ( int width, int height)
        {
            Height = height;
            Width = width;

            Cells = new Cell[Width, Height];

            for (int x = 0; x < Width; x++)
                for (int y = 0; y < Height; y++)
                    Cells[x, y] = new Cell();
        }

        public override string ToString()
        {
            string retval = "";
            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                    retval += Cells[x,y].ToString();
                retval += "\n";
            }
            return retval;
        }
    }
}
