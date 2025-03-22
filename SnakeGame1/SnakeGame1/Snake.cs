using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame1
{
    public class Snake
    {
        public int X = 1, Y = 1;
        public char yilan = 'S';
        public int skor=0;

        public void yilanCiz()
        {
            Console.Clear();
            Console.SetCursorPosition(X, Y);
            Console.Write(yilan);
        }

        public void movement(ConsoleKeyInfo basilan)
        {
            if (basilan.Key == ConsoleKey.RightArrow)
                X++;
            else if (basilan.Key == ConsoleKey.LeftArrow)
                X--;
            else if (basilan.Key == ConsoleKey.UpArrow)
                Y--;
            else if (basilan.Key == ConsoleKey.DownArrow)
                Y++;

            if (X == 21)
                X = 1;
            if (Y == 31)
                Y = 1;
            if (X == 0)
                X = 20;
            if (Y == 0)
                Y = 30;

        }

        public bool yedimi(Food1 oanki)
        {
            bool sonuc = false;
            if ((X == oanki.X) && (Y == oanki.Y))
            {
                skor++;
                sonuc = true;
            }
            return sonuc;
        }

        public void skoryaz()
        {
            Console.SetCursorPosition(1, 32);
            Console.WriteLine("Skor{0}", skor);
        }
    }
}
