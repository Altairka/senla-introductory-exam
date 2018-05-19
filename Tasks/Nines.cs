using System;
namespace senlaintroductoryexam.Tasks
{
	public class Nines : iTask
	{
		public Int32 ID { get; } = 9;

		public String Name => "Number sequence";

		public void Invoke()
		{
			Console.Write("Enter N: ");
			Int32 N = Int32.Parse(Console.ReadLine());

            if(N <= 0)
			{
				Console.WriteLine("Bad idea :(");
				return;
			}

			Int32 Sum = 0;
			for (int i = 0; i < N - 1; i += 2)
			{
				Sum += i;
			}

			Console.WriteLine("Sum equals " + Sum);
		}
	}
}
