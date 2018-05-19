using System;
namespace senlaintroductoryexam.Tasks
{
	public class Second : iTask
    {
		public Int32 ID { get; } = 2;

		public String Name { get; } = "Operations with numbers";

		public void Invoke()
		{
			Console.WriteLine("Numbers: ");

			try{
				Console.Write("A: ");
				Int32 A = Int32.Parse(Console.ReadLine());

				Console.Write("B: ");
				Int32 B = Int32.Parse(Console.ReadLine());

				Console.WriteLine("Sum -> " + (A + B));
				Console.WriteLine("Difference -> " + (A - B));

				Int32 GCD = 0;
                for (int i = 1; i <= A * B; i++)
				{
                    if(A % i == 0 && B % i == 0)
					{
						GCD = i;
					}
				}

				Int32 LCM = A * B / GCD;

				Console.WriteLine("Greatest Common Divisor -> " + GCD);
				Console.WriteLine("Least Common Multiple -> " + LCM);
			}
			catch (FormatException){
				Console.WriteLine("Not a number...");
			}
		}
	}
}
