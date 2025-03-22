using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame1
{
    public class Food1
    {
        public int X, Y;
        public char yildiz = '*';

        public void uret()
        {
            Random sayiGen = new Random();
            X = sayiGen.Next(1,21);
            Y = sayiGen.Next(1,31);
        }

        public void ciz()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(yildiz);
        }
    }
}
