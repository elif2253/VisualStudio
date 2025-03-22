using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Food1 food = new Food1();
            Snake yilan = new Snake();
            yilan.yilanCiz();
            food.ciz();
            food.uret();
            ConsoleKeyInfo basilan;
            do
            {
                basilan = Console.ReadKey();
                yilan.movement(basilan);
                yilan.yilanCiz();
                food.ciz();
                if(yilan.yedimi(food) == true)
                {
                    yilan.yilanCiz();
                    food.uret();
                }
                yilan.skoryaz();
            } while (basilan.Key != ConsoleKey.Escape);
        }
    }
}
