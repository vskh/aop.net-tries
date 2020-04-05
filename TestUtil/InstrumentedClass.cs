using System;
using System.Reflection;

namespace TestUtil
{
	public class InstrumentedClass
	{
		public InstrumentedClass()
		{
			Console.WriteLine($"{nameof(InstrumentedClass)}::{MethodBase.GetCurrentMethod().Name}");
		}


		public void TimedOperation()
		{
			Console.WriteLine($"{nameof(InstrumentedClass)}::{MethodBase.GetCurrentMethod().Name}");
		}
	}
}