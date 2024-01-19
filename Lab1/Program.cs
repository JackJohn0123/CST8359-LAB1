using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Lab1
{
	class Program
	{
		static void Main(string[] args)
		{
			IList<string> wordList = new List<string>();
			while (true)
			{
				Menu();
				String c = Console.ReadLine().ToLower();
				switch (c)
				{
					case "1":
					wordList = readFile();
						break;
					case "2":
						break;
					case "3":
						break;
					case "4":
						break;
					case "5":
						break;
					case "6":
						break;
					case "7":
						break;
					case "8":
						break;
					case "9":
						break;
					case "x":
						return;
					default:
						break;
				}
			}
		}
		static void Menu()
		{
			Console.WriteLine("1 - Import words from File");
			Console.WriteLine("2 - Bubble sort words");
			Console.WriteLine("3 - LINQ/Lambda sort words");
			Console.WriteLine("4 - Count the distinct words");
			Console.WriteLine("5 - Take the first 50 words");
			Console.WriteLine("6 - Reverse print the words");
			Console.WriteLine("7 - Get and display words that end with 'a' and display the count");
			Console.WriteLine("8 - Get and display words that include 'm' and display the count");
			Console.WriteLine("9 - Get and display words that are less than 4 characters long and include the letter 'I', and display the count");
			Console.WriteLine("x - Exit");
			Console.Write("\nSelect an option: ");

		}


		static IList<string> readFile()
		{
			List<string> wordList = File.ReadAllLines("Words.txt").ToList();
			Console.WriteLine("The number of words is " + wordList.Count);
			return wordList;
		}


		static void BubbleSortWords(IList<string> words)
		{
			
			
		}

		static void LambdaSortWords(IList<string> words)
		{
			 
		}
		static void CountDistinctWords(IList<string> words)
		{
		}
		static void FirstFiftyWords(IList<string> words)
		{
		}
		static void ReversePrintWords(IList<string> words)
		{

		}
		static void FindAAndCount(IList<string> words)
		{

			

		}

		static void FindMAndCount(IList<string> words)
		{


		}

		static void UnderFourWithIAndDisplayCount(IList<string> words)
		{

		}
		
	}
}