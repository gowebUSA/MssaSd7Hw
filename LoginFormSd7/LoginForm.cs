using System;
using System.Collections.Generic;
using System.Threading;
public class Database
{
	//Ref: https://dotnetfiddle.net/FsXPff

	public static int ProductKey;
	protected static bool FirstTime = true;
	protected static List<string> Usernames = new List<string> { "richgo", "mssasd7admin" };
	protected static List<string> Passwords = new List<string> { "pa$$word", "sd7pa$$word" };
	protected static List<string> Spreadsheet = new List<string> { "You are now logged in to OMAF sytem." };
	protected static List<string> SpreadsheetAuthors = new List<string> { "Richard Go", "MSSA Admin" };
	public static void Verify(string username, string password)
	{
		bool skip = false;
		if (FirstTime == true && ProductKey != 0 && ProductKey != 1 && !Usernames.Contains(username))
		{
			Console.WriteLine("Since this is your first time logging in. Enter the product key to make this into a username or password.");
			if (Console.ReadLine() == ProductKey.ToString())
			{
				ProductKey = 1;
				FirstTime = false;
				Usernames.Add(username);
				Passwords.Add(password);

			}
			else
			{
				Console.WriteLine("Invalid product key. Type anything to continue.");
				Console.ReadLine();
				Thread.Sleep(3000);
				Client.Main();
			}
		}
		if (Usernames.Contains(username) && !skip)
		{
			ProductKey = 1;
			FirstTime = false;
			if (password == Passwords[Usernames.IndexOf(username)])
			{
				Console.WriteLine("Access granted, " + username + ".");
				Console.WriteLine("Would you like to add a new user, " + username.Split(' ')[0] + "?");
				if (Console.ReadLine().ToLower().Contains("y"))
				{
					Console.WriteLine("Enter new username and password.");
					Usernames.Add(Console.ReadLine());
					Passwords.Add(Console.ReadLine());
				}
				Console.WriteLine("Would you like to view some data, " + username + "?");
				if (Console.ReadLine().ToLower().Contains("y"))
				{
					string input = "";
					while (input.ToLower() != "exit")
					{
						Console.Clear();
						for (int i = 0; i < Spreadsheet.Count; i++)
						{
							Console.WriteLine(i + "|" + Spreadsheet[i]);
						}
						Console.WriteLine("Type 'add [text]' to type something.");
						Console.WriteLine("Type 'rem [index]' to type something at a certain index.");
						Console.WriteLine("Type 'exit' to exit data mode.");
						input = Console.ReadLine();
						if (input.ToLower().Contains("add"))
						{
							try
							{
								Spreadsheet.Add(input.Substring(4));
								SpreadsheetAuthors.Add(username);
							}
							catch
							{
								Console.WriteLine("An error occured.");
							}
						}
						if (input.ToLower().Contains("rem"))
						{
							try
							{
								Spreadsheet.RemoveAt(Int32.Parse(input.Substring(4)));
								SpreadsheetAuthors.Add(username);
							}
							catch
							{
								Console.WriteLine("An error occured.");
							}
						}
					}
					Console.WriteLine("Thank you for your time. Raise your hands and press Enter to log off.");
					Console.ReadLine();
					Client.Main();
				}
			}
			else
			{
				Console.WriteLine("Invalid username or password. Raise your right hand and press Enter to continue.");
				Console.ReadLine();
				Thread.Sleep(3000);
				Client.Main();
			}
		}
		else if (!skip)
		{
			Console.WriteLine("Invalid username or password. Raise your left hand and press Enter to continue.");
			Console.ReadLine();
			Thread.Sleep(3000);
			Client.Main();
		}
	}
}
public class Client
{
	static int StartTime = System.DateTime.Now.Minute / 5 + System.DateTime.Now.Day;
	static int Key = new Random(StartTime).Next();
	public static void Main()
	{
		Console.Clear();
		if (Database.ProductKey == 0)
		{
			Database.ProductKey = Key;
		}
		if (Database.ProductKey != 1 && Database.ProductKey != 0)
		{
			Console.WriteLine("U/P FIRST TIME PRODUCT KEY:");
			Console.WriteLine("[ " + Database.ProductKey + " ] ");
			Console.WriteLine("--EXPIRES EVERY 5 MINUTES--");
			Console.WriteLine();
		}
		Console.WriteLine("Enter username and password:");
		Database.Verify(Console.ReadLine(), Console.ReadLine());
	}
}