using System;

namespace Snake_And_Ladder
{
    class SnakeAndLadder
    {
        public const int Start_Player_Position = 0;
        public const int Winning_Player_Position = 100;
        public const int No_Play = 0;
        public const int Ladder = 1;
        public const int Snake = 2;

        static void Main(String[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder game");
            Console.WriteLine("Position of Player: " + Start_Player_Position);
            int Position = 0;
            for(int Position_Mave = Start_Player_Position; Position_Mave  <= Winning_Player_Position; Position_Mave++)
            { 
                Random random = new Random();
                int DiceRoll = random.Next(1, 7);
                Random check = new Random();
                int NoPlayLadderSnake = check.Next(0, 3);            
                switch (NoPlayLadderSnake)
                {
                    case No_Play:
                        Console.WriteLine("No Play");
                        break;
                    case Ladder:
                        Console.WriteLine("Ladder");
                        Position += DiceRoll;
                        break;
                    case Snake:
                        Position -= DiceRoll;
                        Console.WriteLine("Snake");
                        break;                      
                }
                Position_Mave = Position;
                if (Position_Mave < Start_Player_Position)
                {
                    Position_Mave = Start_Player_Position;
                }
                else
                {
                    Position_Mave = Position;
                }
                Console.WriteLine("Roll the Dice: " + DiceRoll);
                Console.WriteLine("Position of Player: " + Position_Mave);
            }
        }
    }
}