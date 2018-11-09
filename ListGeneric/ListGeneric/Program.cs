using System;
using System.Collections.Generic;
using System.Linq;

namespace ListGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Clue> Clues = new List<Clue>
            {
                new Clue(2, Clue.EnumDir.ac, "bet", 3, 4, 0),
                new Clue(1, Clue.EnumDir.ac, "alf", 4, 0, 0),
                new Clue() { Number = 3, Direction = Clue.EnumDir.dn, Text = "del", Len = 3, XPos = 3, YPos = 1 },
                new Clue(1, Clue.EnumDir.dn, "gam", 2, 0, 0)
            };

            foreach (Clue clue in Clues.Where(c => c.Direction == Clue.EnumDir.ac).OrderBy(c => c.Number))
            {
                Console.WriteLine(clue.ToString());
            }

            Console.WriteLine();

            foreach (Clue clue in Clues.Where(c => c.Direction == Clue.EnumDir.dn).OrderBy(c => c.Number))
                Console.WriteLine(clue.ToString());
        }
    }
}
