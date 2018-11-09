using System;
using System.Collections.Generic;
using System.Linq;

namespace ListGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Clue> Clues = new List<Clue>();

            Clues.Add(new Clue(2, EnumDirection.ac, "bet", 3, 4, 0));
            Clues.Add(new Clue(1, EnumDirection.ac, "alf", 4, 0, 0));
            Clues.Add(new Clue() { Number = 3, Direction = EnumDirection.dn, Text = "del", Len = 3, XPos = 3, YPos = 1 });
            Clues.Add(new Clue(1, EnumDirection.dn, "gam", 2, 0, 0));

            foreach (Clue clue in Clues.Where(c => c.Direction == EnumDirection.ac).OrderBy(c => c.Number))
            {
                Console.WriteLine(clue.ToString());
            }

            Console.WriteLine();

            foreach (Clue clue in Clues.Where(c => c.Direction == EnumDirection.dn).OrderBy(c => c.Number))
                Console.WriteLine(clue.ToString());
        }
    }
}
