using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameZhargal2
{
    internal class PlayerRegistration
    {
        public static string Player()
        {
            Console.WriteLine("Как вас зовут?");
            string name = Console.ReadLine();
            Console.WriteLine($"Приветствую, {name}! Твоя задача складывать выпадающие числа, всего будет 5 раундов.");
            Console.WriteLine("==================================================================================");
            return name;
        }
    }
}
