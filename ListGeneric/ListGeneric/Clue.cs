using System;
using System.Collections.Generic;
using System.Text;

namespace ListGeneric
{
    enum EnumDirection { ac, dn };

    partial class Clue
    {
        public int Number { get; set; }
        public EnumDirection Direction { get; set; }
        public string Text { get; set; }
        public int Len { get; set; }

        public int XPos { get; set; }
        public int YPos { get; set; }

        public Clue ()
        {
        }

        public Clue(int number, EnumDirection direction, string text, int len, int xPos, int yPos)
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
