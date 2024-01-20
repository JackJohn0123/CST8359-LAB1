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
						BubbleSort(wordList);
						if (wordList.Count != 0) { wordList = ResetArray(); } //reset the array
						break;
					case "3":
						LINQSort(wordList);
						if (wordList.Count != 0) { wordList = ResetArray(); } //reset the array
						break;
					case "4":
						CountDistinctWords(wordList);
						break;
					case "5":
						FirstFiftyWords(wordList);
						break;
					case "6":
						ReversePrintWords(wordList);
						break;
					case "7":
						FindAAndCount(wordList);
						break;
					case "8":
						FindMAndCount(wordList);
						break;
					case "9":
						UnderFourWithIAndDisplayCount(wordList);
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

		static IList<string> BubbleSort(IList<string> words)
		{
			if (words.Count == 0)
			{
				Console.WriteLine("Please load words first!");
				return words;
			}

			
				Stopwatch time = new Stopwatch();
				time.Start();
				String temp;
				var sortedNames = words;

				for (int j = 0; j < words.Count - 1; j++)
				{
					for (int i = j + 1; i < words.Count; i++)
					{
						if (words[j].CompareTo(words[i]) > 0)
						{
							temp = words[j];
							words[j] = words[i];
							words[i] = temp;
						}
					}
				}

				time.Stop();
				Console.WriteLine(Math.Round(time.Elapsed.TotalMilliseconds) + " MS to sort.");
				return words;
		}

		static IList<string> LINQSort(IList<string> words)
		{
				if (words.Count == 0)
				{
					Console.WriteLine("Please load words first!");
					return words;
				}
				Stopwatch w = new Stopwatch();
				w.Start();
				var sortedNames = words.OrderBy(d => d);
				w.Stop();
				Console.WriteLine(Math.Round(w.Elapsed.TotalMilliseconds) + " MS to sort.");
				return words;

			}

		static void CountDistinctWords(IList<string> words)
		{
			if (words.Count == 0)
			{
				Console.WriteLine("Please load words first!");
				return;
			}
			Console.WriteLine(words.Distinct().Count() + " distinct words found");
		}
		static void FirstFiftyWords(IList<string> words)
		{
			if (words.Count == 0)
			{
				Console.WriteLine("Please load words first!");
				return;
			}
			foreach (var word in words.Distinct().Take(50))
			{
				Console.WriteLine(word);
			}
		}
		static void ReversePrintWords(IList<string> words)
		{
			if (words.Count == 0)
			{
				Console.WriteLine("Please load words first!");
				return;
			}

			foreach (var word in words.Reverse())
			{
				Console.WriteLine(word);
			}
		}
		static void FindAAndCount(IList<string> words)
		{
			if (words.Count == 0)
			{
				Console.WriteLine("Please load words first!");
				return;
			}
			
				int count = 0;
				List<string> wordsEndingWithA = new List<string>();
				foreach (var word in words.Where(word => word.EndsWith("a")))
				{
					wordsEndingWithA.Add(word);
					count++;
				}
				Console.WriteLine("The " + count + " words that end with 'a' are:");

				for (int i = 0; i < count; i++)
				{
					Console.WriteLine(wordsEndingWithA[i]);
				}

			

		}

		static void FindMAndCount(IList<string> words)
		{

			if (words.Count == 0)
			{
				Console.WriteLine("Please load words first!");
				return;
			}
			
				int count = 0;
				List<string> wordsEndingWithA = new List<string>();
				foreach (var word in words.Where(word => word.StartsWith("m")))
				{
					wordsEndingWithA.Add(word);
					count++;
				}
				Console.WriteLine("The " + count + " words that start with the letter 'm' are::");

				for (int i = 0; i < count; i++)
				{
					Console.WriteLine(wordsEndingWithA[i]);
				}
			
		}

		static void UnderFourWithIAndDisplayCount(IList<string> words)
		{
			if (words.Count == 0)
			{
				Console.WriteLine("Please load words first!");
				return;
			}
			int count = 0;
			List<string> wordsEndingWithA = new List<string>();
			foreach (var word in words.Where(word => word.Contains("i") && word.Length < 4))
			{
				wordsEndingWithA.Add(word);
				count++;
			}
			Console.WriteLine("The " + count + " words that have less than 4 characters and include the letter 'i' are:");

			for (int i = 0; i < count; i++)
			{
				Console.WriteLine(wordsEndingWithA[i]);
			}

		}
		private static IList<string> ResetArray()
		{
			List<string> allLinesText = File.ReadAllLines("Words.txt").ToList();
			return allLinesText;
		}

	}
}