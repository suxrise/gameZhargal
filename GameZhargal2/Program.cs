using System;
using GameZhargal2;

class Program
{
    public static void Main(string[] args)
    {
        int round = 1;
        int attempt = 2;
        string name = PlayerRegistration.Player();
        while (round <= 5 && round != 0)
        {
            if (GameRound.CheckAnswer(round) == true )
            {
                round += 1;
                if (round == 6)
                {
                    Console.WriteLine($"|------->  {name}, вы выиграли!");
                }
            }
            else
            {
                round = Attempts.listOfAttempts(attempt, round, name);
                attempt -= 1;
            }
        }
    }
}