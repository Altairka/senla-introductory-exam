using System;
namespace senlaintroductoryexam.Tasks
{
	public class Sixth : iTask
	{
		public String Name { get; } = "Is right triangle exists";

		public void Invoke()
		{
			Console.WriteLine("Enter parameters:");

			try{
				Console.Write("a: ");
				Double a = Double.Parse(Console.ReadLine());

				Console.Write("b: ");
				Double b = Double.Parse(Console.ReadLine());
                
				Console.Write("c: ");
				Double c = Double.Parse(Console.ReadLine());

                // TO DO
			}
			catch{
				Console.WriteLine("There shouldn't be exceptions here..");
			}
		}
	}
}
