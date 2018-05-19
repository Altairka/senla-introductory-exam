using System;
using System.Linq;

namespace senlaintroductoryexam.Tasks
{
	public class Third : iTask
	{
		public Int32 ID { get; } = 3;

		public String Name { get; } = "Is Palindrome";

		public void Invoke()
		{
			Console.Write("Enter word: ");
			String Word = Console.ReadLine();

			for (int i = 0; i < Word.Length; i++)
			{
				if(Word[i] != Word[Word.Length - 1 - i])
				{
					Console.WriteLine("Wrong. The word isn't palindrome");
					return;
				}
			}
			Console.WriteLine("Truth. The word is palindrome");
		}
	}
}
