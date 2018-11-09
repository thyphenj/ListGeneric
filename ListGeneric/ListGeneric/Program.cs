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
                new Clue(1, Clue.EnumDir.dn, "gam", 2, 0, 0),
                new Clue(2, Clue.EnumDir.ac, "bet", 3, 4, 0),
                new Clue(3, Clue.EnumDir.dn, "del", 3, 3, 1 ),
                new Clue(1, Clue.EnumDir.ac, "alf", 4, 0, 0)
            };

            // Populate the Grid
            Grid grid = new Grid(6, 4);

            foreach (Clue clue in clues)
                grid.SetClue(clue);

            grid.Cells[2, 2].SetDigit(1);
            grid.Cells[0, 3].SetDigit(2);
            grid.Cells[3, 0].SetDigit(3);

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
