using System;

namespace GameRoulette
{
	class Game1
	{
		// ------------------------------------------------------------------------------------ Methods -------------
		static void Write(string str)
		{
			Console.Write(str);
		}
		static void Write(char chr)
		{
			Console.Write(chr);
		}
		static void Write(int intr)
		{
			Console.Write(intr);
		}
		static string Conv()
		{
			string temp = Console.ReadLine();
			return temp;
		}
		static void SkipLines(int howMany)
		{
			do
			{
				Console.WriteLine();
				howMany--;
			} while (howMany > 0);
		}
		static int GetRandomNumber(Random rnd)
		{
			int randNumb = rnd.Next(1, 1);
			// Random number between 1 & 36
			return randNumb;
		}
		static int IntWin(int gamble, int randNumb)
		{
			if (gamble == randNumb)
			{
				Console.WriteLine("The roulette is rolling... \nIt stops on the " + randNumb + ".\nYou win, bet multiply by 5 !");
				return 5;
			}
			Console.WriteLine("The roulette is rolling... \nIt stops on the " + randNumb + ".\nYou lost, bet equals to 0 !");
			return 0;
		}
		static int ColorWin(int randNumb, int[] array)
		{
			foreach (int num in array)
			{
				if (num == randNumb)
				{
					Console.WriteLine("The roulette is rolling so fast !\nIt stops right on your color.\nCongrats, you win : bet multiply by 2");
					return 2;
				}
			}
			Console.WriteLine("You lost, it isn't the right color.\nToo bad : bet equals to 0.");
			return 0;
		}
		// ---------------------------------------------------------------------------- Variables -------------
		static int[] red_nums = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36 };

		static int[] black_nums = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35 };

		static Random rand = new Random();
		static int gamble;
		// ------------------------------------------------------------------------------ Class ---------------
		public class Sold
		{
			private int sold;
			public Sold()
			{
				sold = 100;
			}
			public void ShowSold()
			{
				Console.WriteLine("Sold : " + sold + "$");
			}
			public void Add(int bet)
			{
				sold += bet;
			}
			public void Sub(ref int bet)
			{
				if ((sold - bet) < 0)
				{
					bet = sold;
					Console.WriteLine("Bet set to " + bet + ".");
				}
				sold -= bet;
			}
			public bool CheckForGameOver()
			{
				if (sold <= 0)
				{
					return true;
				}
				return false;
			}
		}
		// ---------------------------------------------------------------------------- Main() ---------------
		public static void Main(string[] args)
		{
			Sold player = new Sold();

			Write("Hello and welcome to MSSA SD7 roulette game.");
			SkipLines(2);
			Write("(1) Bet on color.");  //done
			Write("\n(2) Even or Odds?");
			Write("\n(3) Lows/Highs: low (1 - 18) or high (19 - 38) numbers.");
			Write("\n(4) Columns: first, second, or third columns.");
			Write("\n(5) Dozens: row thirds, 1 - 12, 13 - 24, 25 - 36");
			Write("\n(6) Street: rows, e.g., 1/2/3 or 22/23/24");
			Write("\n(7) 6 Numbers: double rows, e.g., 1/2/3/4/5/6 or 22/23/24/25/26/26");
			Write("\n(8) Split: at the edge of any two contiguous numbers, e.g., 1/2, 11/14, and 35/36");
			Write("\n(9) Corner: at the intersection of any four contiguous numbers, e.g., 1/2/4/5, or 23/24/26/27");
			Write("\n(10) Numbers: the number of the bin");

			Console.Write("\n\nEnter game number: ");
			int activeGame = int.Parse(Console.ReadLine());
			Console.Write($"You chose game #{activeGame}. Hit Enter to play.");
			Console.ReadLine();


			switch (activeGame)
			{
				case 1:
					Console.WriteLine("Game 1");
			Write("\nYou start the game with 100$.\nYou can bet on a number or on a color.\nBet on color will multiply your bet by 2 where a number bet will multiply it by 5.\nTo bet, just write a number between 1 & 36 or red or black.\nGood luck and have fun :)\n");

			SkipLines(1);

			while (true)
			{
				try
				{
					SkipLines(1);
					player.ShowSold();

					Write("Bet ? ");
					gamble = Convert.ToInt32(Conv());

				}
				catch (Exception)
				{
					Write("You have to gamble so your bet is 10.\n");
					gamble = 10;

				}

				player.Sub(ref gamble);
				int randomNumber = GetRandomNumber(rand);
				int mult = 0;

				Write("On what ? ");
				string write = Conv().ToLower();

				if (write.Equals("red"))
				{
					mult = ColorWin(randomNumber, red_nums);
				}
				else if (write.Equals("black"))
				{
					mult = ColorWin(randomNumber, black_nums);
				}
				else
				{
					try
					{
						int bet = Convert.ToInt32(write);
						mult = IntWin(bet, randomNumber);
					}
					catch (Exception)
					{
						Write("Wrong input, lost your bet.");
					}
				}
				player.Add(gamble * mult);
				if (player.CheckForGameOver()) goto defeat;
			}

		defeat:
			SkipLines(2);
			Write("You lost, try again another time :D");
					break;
				case 2:
					Console.WriteLine("Game 2");
					goto case 1;   //TODO need to update
					//break;
				case 3:
					Console.WriteLine("Game 3");
					goto case 1;   //TODO need to update
					//break;
				case 4:
					Console.WriteLine("Game 4");
					goto case 1;   //TODO need to update
					//break;
				case 5:
					Console.WriteLine("Game 5");
					goto case 1;   //TODO need to update
					//break;
				case 6:
					Console.WriteLine("Game 6");
					goto case 1;   //TODO need to update
					//break;
				case 7:
					Console.WriteLine("Game 7");
					goto case 1;   //TODO need to update
					//break;
				case 8:
					Console.WriteLine("Game 8");
					goto case 1;   //TODO need to update
					//break;
				case 9:
					Console.WriteLine("Game 9");
					goto case 1;   //TODO need to update
					//break;
				case 10:
					Console.WriteLine("Game 10");
					goto case 1;						//goto: Used for in replacement of break.
					//break;
			}
		}
	}
}
