using System;

namespace Snakes_And_Ladders
{
    class SnakeAndLadder
    {
        public int Dice_Roll = 0;
        public int Num_of_Rolls = 0;
        public int Current_Position = 0;
        public int Winning_Position = 100;
        public int Current_Position_One = 0;
        public int Current_Position_Two = 0;
        public int Last_Position = 0;
        public const int No_Play = 0;
        public const int Ladder = 1;
        public const int Snake = 2;
        public int Dice()
        {
            Random Roll = new Random();
            int Dice_Roll = Roll.Next(1, 7);
            Console.WriteLine("Roll the Dice: " + Dice_Roll);
            Num_of_Rolls++;
            return Dice_Roll;
        }
        public int Check()
        {
            Random check = new Random();
            int NoPlayLadderSnake = check.Next(0, 3);
            return NoPlayLadderSnake;
        }
        public void Play(string Player)
        {
            bool Turn = true;
            while (Turn && Current_Position < Winning_Position)
            {
                Last_Position = Current_Position;
                int Dice_Roll = Dice();
                switch (Check())
                {
                    case No_Play:
                        Turn = false;
                        Console.WriteLine("No Play");
                        break;
                    case Ladder:
                        Console.WriteLine("Ladder");
                        Current_Position = Current_Position + Dice_Roll;
                        break;
                    case Snake:
                        Console.WriteLine("Snake");
                        Current_Position = Current_Position - Dice_Roll;
                        if (Current_Position < 0)
                        {
                            Current_Position = 0;
                        }
                        Turn = false;
                        break;
                }
                if (Current_Position > Winning_Position)
                {
                    Current_Position = Last_Position;
                }
                Console.WriteLine("Current Position of {0} is: {1}", Player, Current_Position);
                Console.WriteLine("\n");
            }
        }
        static void Main(string[] args)
        {
            int Turn = 1;
            Console.WriteLine("Welcome to Snake and Ladder game");
            Console.WriteLine("Starting Position of player one is: 0");
            Console.WriteLine("Starting Position of player two is: 0");
            SnakeAndLadder Player_One = new SnakeAndLadder();
            SnakeAndLadder Player_Two = new SnakeAndLadder();
            while (Player_One.Current_Position < 100 && Player_Two.Current_Position < 100)
            {
                if (Turn == 1)
                {
                    Player_One.Play("Player 1");
                    Turn = 2;
                }
                else if (Turn == 2)
                {
                    Player_Two.Play("Player 2");
                    Turn = 1;
                }
            }
            if (Player_One.Current_Position == 100)
            {
                Console.WriteLine("Winning Player is Player one");
            }
            else
            {
                Console.WriteLine("Winning Player is Player two");
            }
            Console.WriteLine("Total times the dice was rolled by Player One = {0}", Player_One.Num_of_Rolls);
            Console.WriteLine("Total times the dice was rolled by Player Two = {0}", Player_Two.Num_of_Rolls);
        }
    }
}