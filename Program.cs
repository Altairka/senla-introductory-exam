﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using senlaintroductoryexam.Tasks;

namespace senla_introductory_exam
{
    class Program
    {
		/* Хотелось бы увидеть побольше подобных практических задач :)
		 * Хорошо помогает развлечься в свободное время
		 * @ Ходаков Артём - ГрГУ УИР-171
         */

		static List<iTask> Tasks = new List<iTask>();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Getting ready...");
                     
			List<Type> Types = Assembly.GetExecutingAssembly().GetTypes().
							Where(x => x.GetInterface("iTask") != null).
							ToList();
			
			foreach (var type in Types)
			{
				Tasks.Add((iTask)Activator.CreateInstance(type));
			}

			Tasks = Tasks.OrderBy(x => x.ID).ToList();

			Console.WriteLine("Available tasks:");
			foreach(iTask task in Tasks){
				Console.WriteLine($" > [{task.ID}] - {task.Name}");
			}
            
			Console.WriteLine("Enter task index to invoke: ");
			while (true)
			{
				try
				{
					Console.Write(" > ");
					String Command = Console.ReadLine();

					if (Command == "exit") { break; }
					else if (Command == "clear") { Console.Clear(); continue; }

					Int32 Index = Int32.Parse(Command);

					iTask Task = Tasks.First(x => x.ID == Index);

					Task.Invoke();
				}
				catch (ArgumentNullException) { }
				catch (FormatException)
				{
					Console.WriteLine("Invalid format");
				}
				catch(ArgumentOutOfRangeException){
					Console.WriteLine("Unknown task index");
				}
				catch(Exception Ex){
					Ex = (Ex.InnerException != null) ? Ex.InnerException : Ex;
					Console.WriteLine($"Oops... {Ex.GetType().Name} : {Ex.Message}");
				}
			}

			Console.WriteLine("Done. Waiting key press for exit...");
			Console.ReadKey();
        }
    }
}
