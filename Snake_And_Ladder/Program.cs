using System;

namespace Snake_And_Ladder
{
    class SnakeAndLadder
    {
        static void Main(String[] args)
        {
            int Start_Player_Position = 0;
            Random random = new Random();
            int DiceRoll = random.Next(1, 7);
            Console.WriteLine("Welcome to Snake and Ladder game");
            Console.WriteLine("Position of Player: " + Start_Player_Position);
            Console.WriteLine("Roll the Dice: " + DiceRoll);
        }
    }
}

