using System;
namespace senlaintroductoryexam.Tasks
{
	public class Fourth : iTask
	{
		public Int32 ID { get; } = 4;

		public String Name { get; } = "Splitting & sorting a sentence";

		public void Invoke()
		{
			Console.Write("Sentence here: ");
			String Text = Console.ReadLine();

			String[] Words = Text.Split(Shared.Separators, StringSplitOptions.RemoveEmptyEntries);
			Array.Sort(Words);

			Console.WriteLine("Result:");

			foreach(String str in Words){
				Console.WriteLine(str);
			}
		}
	}
}
