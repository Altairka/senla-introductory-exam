using System;
namespace senlaintroductoryexam.Tasks
{
	public class Sixth : iTask
	{
		public Int32 ID { get; } = 6;

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
               
				if(a <= 0 || b <= 0 || c <= 0){
					Console.WriteLine("Funny joke...");
					return;
				}

				Boolean isOk = false;

				Check(a, b, c, ref isOk);
				Check(b, c, a, ref isOk);
				Check(c, b, a, ref isOk);

				Console.WriteLine("Result: " + isOk);
			}
			catch{
				Console.WriteLine("There shouldn't be exceptions here..");
			}
		}

		void Check(Double a, Double b, Double c, ref Boolean isOk){
			if ((a * a + b * b) == c * c)
				isOk = true;
		}
	}
}
