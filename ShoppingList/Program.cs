using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ShoppingList
{
	class Program
	{
		static void Main(string[] args)
		{



			if (File.Exists($"C:\\Users\\atrei\\samples\\shoppingList\\myShoppingList.txt"))
			{
				Console.WriteLine($"File myShoppingList.txt is exist.");
			}
			else
			{
				string rootDirectory = @"C:\Users\atrei\samples";
				Console.WriteLine("Enter directory name: (recommended shoppingList)");
				string newDirectory = Console.ReadLine();
				Console.WriteLine("Enter file name: (recommended myShoppingList.txt)");
				string fileName = Console.ReadLine();
				Directory.CreateDirectory($"{rootDirectory}\\{newDirectory}");
				File.Create($"{rootDirectory}\\{newDirectory}\\{fileName}");

				Console.WriteLine($"{rootDirectory}\\{newDirectory}\\{fileName} is created");
			}


		}

	}
}
