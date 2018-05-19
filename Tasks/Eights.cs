using System;
using System.Collections.Generic;

namespace senlaintroductoryexam.Tasks
{
	public class Eights : iTask
	{
		public Int32 ID { get; } = 8;

		public String Name => "Palindromic numbers";

		public void Invoke()
		{
			Console.Write("Enter N: ");
			Int32 N = Int32.Parse(Console.ReadLine());

			if(N <= 0 || N > 100){
				Console.WriteLine("Wrong length!");
				return;
			}

			Int32[] Numbers = new Int32[N];

			Random Rnd = new Random();
            for (int i = 0; i < Numbers.Length; i++)
			{
				Numbers[i] = Rnd.Next(-999, 999);
			}

			List<Int32> Palindromic = new List<int>();

			Console.WriteLine("Processing...");        
			for (int i = 0; i < Numbers.Length; i++)
			{
				char[] symbols = Numbers[i].ToString().ToCharArray();

				Boolean isPalindromic = true;
                for (int j = 0; j < symbols.Length; j++)
				{
					if(symbols[j] != symbols[symbols.Length - 1 - j]){
						isPalindromic = false;
						break;
					}
				}

				if (isPalindromic)
					Palindromic.Add(Numbers[i]);
			}


			Console.WriteLine("Result:");
            foreach (var item in Palindromic)
			{
				Console.WriteLine(" > " + item);
			}
		}
	}
}