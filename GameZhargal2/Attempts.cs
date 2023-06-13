using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GameZhargal2
{
    internal class Attempts
    {
        public static int listOfAttempts(int attempt, int round, string name)
        {
            switch (attempt)
            {
                case 2:
                    Console.WriteLine($"У вас осталось {attempt} попытки!");
                    Console.WriteLine();
                    break;
                case 1:
                    Console.WriteLine($"У вас осталось {attempt} попытка!");
                    Console.WriteLine();
                    break;
                case 0:
                    Console.WriteLine();
                    Console.WriteLine($"|------->  Попытки закончились! {name}, вы проиграли!");
                    round = 0;
                    break;
            }
            return round;
        }
    }
}
