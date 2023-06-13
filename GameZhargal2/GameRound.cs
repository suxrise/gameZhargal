using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameZhargal2
{
    internal class GameRound
    {
        public static int generatorNum(int number)
        {
            Random rnd = new Random();
            int RundNumber = rnd.Next(0, number);
            return RundNumber;
        }
        public static int inputNumber()
        {
            string? sumNumbersInput = Console.ReadLine();
            int sumNumbersRound = Int32.Parse(sumNumbersInput);
            return sumNumbersRound;
        }
        public static bool CheckAnswer(int round)
        {
            int num1, num2 = 0;
            bool answerCheck;
            Console.WriteLine($">{round} раунд. Сложите числа {num1 = generatorNum(100)} и {num2 = generatorNum(100)}.");
            Console.Write("Ваш ответ: ");
            if (inputNumber() == num1 + num2)
            {
                Console.WriteLine($"Правильный ответ! {round} раунд пройден!");
                Console.WriteLine();
                answerCheck = true;
            }
            else
            {
                Console.WriteLine($"Ответ не правильный! Правильный ответ - {num1 + num2}");
                answerCheck = false;
            }
            return answerCheck;
        }
    }
}
