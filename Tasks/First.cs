using System;
namespace senlaintroductoryexam.Tasks
{
	public class First : iTask
    {
		public String Name { get; } = "Number characteristics";

		public void Invoke()
		{
			Console.Write("Number: ");
			Int32 Number = Int32.Parse(Console.ReadLine());

			Boolean isSimple = true;
            for (int i = 2; i <= Number / 2; i++)
            {
                if (Number % i == 0)
                {
                    isSimple = false;
                    break;
                }
            }

			Console.WriteLine($"Number is {((Number % 2 == 0) ? "even" : "odd")} and {(isSimple ? "simple" : "complex")}");
		}
	}
}
