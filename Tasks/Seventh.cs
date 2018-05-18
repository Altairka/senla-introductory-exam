using System;
using System.Linq;

namespace senlaintroductoryexam.Tasks
{
	public class Seventh : iTask
	{
		public String Name => "Min & Max in array";

		public void Invoke()
		{
			Console.Write("Enter N: ");
			Int32 N = Int32.Parse(Console.ReadLine());

			Int32[] Numbers = new Int32[N];

			Random Rnd = new Random();
            for (int i = 0; i < Numbers.Length; i++)
			{
				Numbers[i] = Rnd.Next(-99, 99);
			}

			Console.WriteLine("Min -> " + Numbers.Min());
			Console.WriteLine("Max -> " + Numbers.Max());
		}
	}
}
