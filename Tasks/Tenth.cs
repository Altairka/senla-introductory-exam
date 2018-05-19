using System;
using System.Linq;
using System.Text;

namespace senlaintroductoryexam.Tasks
{
	public class Tenth : iTask
	{
		// Шикарное задание, если его чуть-чуть усложнить :D

		public Int32 ID { get; } = 10;

		public String Name => "Numbers combination";

		Char[] Numbers;

		public void Invoke()
		{
			Console.WriteLine("Wow. Something interesting...");

			Int32 N = 3;

			Console.Write("Enter N (count of number columns & default 3): ");
			String Input = Console.ReadLine();
			if (!String.IsNullOrEmpty(Input))
			{
				N = Int32.Parse(Input);
			}

			Numbers = new Char[N];

			Console.WriteLine("Waiting for numbers:");
			for (int i = 0; i < Numbers.Length; i++)
			{
				Console.Write(i + ": ");
				Numbers[i] = Console.ReadLine().First();
			}
            
			Console.WriteLine("Processing");

			for (int i = 0; i < Numbers.Length; i++)
			{
				Char[] INumber = new Char[Numbers.Length];
				INumber[0] = Numbers[i];

                // Generating number source
                for (int k = 1; k < INumber.Length; k++)
				{
					INumber[k] = Numbers[0];
				}

				Iteration(INumber, 1);
			}
		}

        // Here stage means column of the source number
		void Iteration(Char[] Source, Int32 Stage)
		{
			for (int i = 0; i < Numbers.Length; i++)
			{
				Source[Stage] = Numbers[i];

				// Interacting with next column
				if (Stage < Source.Length - 1)
				{
					Iteration(Source, Stage + 1);
				}
				else
				{
					Console.WriteLine(String.Join(' ', Source));
				}
			}
		}
	}
}