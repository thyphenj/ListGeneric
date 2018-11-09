using System;
using System.Collections.Generic;
using System.Text;

namespace ListGeneric
{
    partial class Clue
    {
        public enum EnumDir { ac, dn };

        public int Number { get; set; }
        public EnumDir Direction { get; set; }
        public string Text { get; set; }
        public int Len { get; set; }

        public int XPos { get; set; }
        public int YPos { get; set; }

        public Clue ()
        {
        }

        public Clue(int number, EnumDir direction, string text, int len, int xPos, int yPos)
        {
            Number = number;
            Direction = direction;
            Text = text;
            Len = len;
            XPos = xPos;
            YPos = yPos;
        }

        public override string ToString()
        {
            string retval = $"{Number.ToString().PadLeft(2)}{Direction}) {Text} ({Len.ToString()})";
            return retval;
        }
    }
}
