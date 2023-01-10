
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace myShoppingList
{
	class Program
	{
		static void Main(string[] args)
		{
			if (File.Exists($"C:\\Users\\atrei\\samples\\shoppingList\\myShoppingList.txt"))
			{
				string[] arrayFromFile = File.ReadAllLines($"C:\\Users\\atrei\\samples\\shoppingList\\myShoppingList.txt");
				List<string> myShoppingList = arrayFromFile.ToList<string>();

				bool loopActive = true;

				while (loopActive)
				{
					Console.WriteLine("Would you like to add a item to shoppinglist? Y/N:");
					char userInput = Convert.ToChar(Console.ReadLine().ToLower());

					if (userInput == 'y')
					{
						Console.WriteLine("Enter you item:");
						string useritem = Console.ReadLine();
						myShoppingList.Add(useritem);

					}
					else
					{
						loopActive = false;
						Console.WriteLine("Take care!");
					}

				}
				Console.Clear();

				foreach (string items in myShoppingList)
				{
					Console.WriteLine($"Your wish: {items}");
				}

				File.WriteAllLines($"C:\\Users\\atrei\\samples\\shoppingList\\myShoppingList.txt", myShoppingList);
			}
			else
			{
				Console.WriteLine("Take care!");
			}
		}
	}
}
