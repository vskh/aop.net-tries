using System;

namespace TestUtil
{
	public static class Logger
	{
		public static void Log(string message)
		{
			// noop, needs to be instrumented
			Console.WriteLine($"[log] {message}");
		}
	}
}