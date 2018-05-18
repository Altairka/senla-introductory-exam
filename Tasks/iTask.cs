using System;
namespace senlaintroductoryexam.Tasks
{
	public interface iTask
	{
		String Name { get; }

		void Invoke();
	}
}
