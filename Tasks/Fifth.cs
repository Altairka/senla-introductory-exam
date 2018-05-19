using System;
using System.Collections.Generic;
using System.Linq;

namespace senlaintroductoryexam.Tasks
{
	public class Fifth : iTask
	{
		public Int32 ID { get; } = 5;

		public String Name { get; } = "Words counter";

		public void Invoke()
		{
			Console.Write("Text: ");
			String[] Words = Console.ReadLine().Split(Shared.Separators, StringSplitOptions.RemoveEmptyEntries);

			Dictionary<String, Int32> Counter = new Dictionary<string, int>();

			foreach(String str in Words){
				String key = str.ToLowerInvariant();

				if(Counter.ContainsKey(key)){
					Counter[key] += 1;
				}
				else
				{
					Counter.Add(key, 1);
				}
			}
         
			Console.WriteLine("Result:");
            foreach (var item in Counter)
			{
				Console.WriteLine(" > {0,15} : {1}", item.Key, item.Value);
			}
		}
	}
}
