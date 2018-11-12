using System;
using System.Collections.Generic;
using System.Text;

namespace ListGeneric
{
    class Cell
    {
        public int Digit { get; set; }

        public bool[] AllowedDigits{ get; set; }

        public bool Complete { get; set; }
        public Clue[] Clue { get; set; }

        public Cell ()
        {
            AllowedDigits = new bool[]{ true,true,true,true,true,true,true,true,true,true };
            Complete = false;
            Digit = 0;
            Clue = new Clue[2];
        }

        public void SetDigit(int digit)
        {
            for (int i = 0; i < 10; i++)
                    AllowedDigits[i] = false;

            AllowedDigits[digit] = true;

            Digit = digit;

            Complete = true;
        }

        public override string ToString()
        {
            //            return Complete ? Digit.ToString().PadLeft(2) : "  ";
            if (Clue[0] == null)
                if (Clue[1] == null)
                    return "  ";
                else
                    return Clue[1].Number.ToString().PadLeft(2);
            else
                return Clue[0].Number.ToString().PadLeft(2);
        }
    }
}
