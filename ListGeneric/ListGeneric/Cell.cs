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

        public Cell ()
        {
            AllowedDigits = new bool[]{ true,true,true,true,true,true,true,true,true,true };
            Complete = false;
            Digit = 0;
        }

        public void SetDigit(int digit)
        {
            for (int i = 0; i < 10; i++)
                if (i != digit)
                    AllowedDigits[i] = false;

            Digit = digit;

            Complete = true;
        }

        public override string ToString()
        {
            return Complete ? Digit.ToString().PadLeft(2) : "  ";
        }
    }
}
