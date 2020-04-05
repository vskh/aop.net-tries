using System;

namespace TestUtil
{
	public interface ILoggerTrait
	{
		bool ShouldLog { get; set; }


		public void Log(string msg)
		{
			if (ShouldLog)
			{
				Console.WriteLine($"[{GetType().Name}({GetHashCode()})] {msg}");
			}
		}
	}
}