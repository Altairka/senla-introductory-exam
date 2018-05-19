using System;
namespace senlaintroductoryexam.Tasks
{
	public interface iTask
	{
		Int32 ID { get; }

		String Name { get; }

		void Invoke();
	}
}
