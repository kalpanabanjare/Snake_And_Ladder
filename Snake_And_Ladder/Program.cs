using System;

namespace Snake_And_Ladder
{
    class SnakeAndLadder
    {
        public const int Start_Player_Position = 0;
        public const int No_Play = 0;
        public const int Ladder = 1;
        public const int Snake = 2;
        static void Main(String[] args)
        {
            int Position = 0;
            Random random = new Random();
            int DiceRoll = random.Next(1, 7);
            Random check = new Random();
            int NoPlayLadderSnake = random.Next(0, 3);
            switch (NoPlayLadderSnake)
            {
                case No_Play:
                    break;
                case Ladder:
                    Position++;
                    break;
                case Snake:
                    Position--;
                    break;
            }
            Console.WriteLine("Welcome to Snake and Ladder game");
            Console.WriteLine("Position of Player: " + Start_Player_Position);
            Console.WriteLine("Roll the Dice: " + DiceRoll);
            Console.WriteLine("Position of Player: " + Position);
        }
    }
}

