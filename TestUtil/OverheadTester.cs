using System;
using System.Diagnostics;

namespace TestUtil
{
	public class OverheadTester
	{
		public static void Time(string experimentId, Action refOp, Action testOp, int iterations = 1000000)
		{
			Stopwatch timer = Stopwatch.StartNew();
			for (int i = 0; i < iterations; ++i)
			{
				try
				{
					refOp();
				}
				catch (Exception)
				{
					
				}
			}
			timer.Stop();
			var refElapsed = timer.Elapsed;
			
			timer = Stopwatch.StartNew();
			for (int i = 0; i < iterations; ++i)
			{
				try
				{
					testOp();
				}
				catch (Exception)
				{
					
				}
			}
			timer.Stop();
			var testElapsed = timer.Elapsed;

			double relation = testElapsed.TotalMilliseconds / refElapsed.TotalMilliseconds;
			
			Console.WriteLine($"Experiment '{experimentId}' results (after {iterations} iterations):");
			Console.WriteLine($"	Reference operation took {refElapsed.TotalMilliseconds} ms.");
			Console.WriteLine($"	Test operation took {testElapsed.TotalMilliseconds} ms.");
			Console.WriteLine("Reference operation is {0} than test operation in {1} times.",
				relation < 1 ? "slower" : "faster",
				relation);
		}
	}
}