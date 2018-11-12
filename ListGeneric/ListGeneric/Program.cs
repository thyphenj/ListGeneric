using System;
using System.Collections.Generic;
using System.Linq;

namespace ListGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            // Populate the Clues
            List<Clue> clues = new List<Clue>
            {
                new Clue(1, Clue.EnumDir.ac, 2, 0, 0, "Sum of all 20 digits in the grid"),
                new Clue(2, Clue.EnumDir.ac, 3, 2, 0, "Multiple of another grid entry"),
                new Clue(4, Clue.EnumDir.ac, 3, 0, 1, "One row of the Playfair code-square"),
                new Clue(7, Clue.EnumDir.ac, 3, 2, 2, "Divisor of 3dn"),
                new Clue(8, Clue.EnumDir.ac, 3, 0, 3, "One column of the Playfair code-square" ),
                new Clue(9, Clue.EnumDir.ac, 2, 3, 3, "The Playfair code-number for this puzzle" ),

                new Clue(1, Clue.EnumDir.dn, 3, 0, 0, "A square minus the grid entry at 1ac" ),
                new Clue(2, Clue.EnumDir.dn, 2, 2, 0, "Sum of the digits of 7ac" ),
                new Clue(3, Clue.EnumDir.dn, 3, 3, 0, "Reverse of 2ac" ),
                new Clue(5, Clue.EnumDir.dn, 3, 1, 1, "Anagram of 6dn" ),
                new Clue(6, Clue.EnumDir.dn, 3, 4, 1, "Square" ),
                new Clue(7, Clue.EnumDir.dn, 2, 2, 2, "Prime" ),
            };

            // Populate the Grid
            Grid grid = new Grid(5, 4);

            foreach (Clue clue in clues)
                grid.SetClue(clue);

            grid.Cells[1, 1].SetDigit(6);
            grid.Cells[2, 1].SetDigit(1);
            grid.Cells[4, 1].SetDigit(3);

            grid.Cells[1, 2].SetDigit(1);
            grid.Cells[4, 2].SetDigit(6);

            grid.Cells[1, 3].SetDigit(3);
            grid.Cells[3, 3].SetDigit(6);
            grid.Cells[4, 3].SetDigit(1);

            //----------------------------- report on contents!
            // The clues
            foreach (Clue clue in clues.Where(c => c.Direction == Clue.EnumDir.ac).OrderBy(c => c.Number))
                Console.WriteLine(clue.ToString());
            Console.WriteLine();

            foreach (Clue clue in clues.Where(c => c.Direction == Clue.EnumDir.dn).OrderBy(c => c.Number))
                Console.WriteLine(clue.ToString());
            Console.WriteLine();

            // The grid
            Console.WriteLine(grid.ToString());
            Console.ReadLine();
        }
    }
}
