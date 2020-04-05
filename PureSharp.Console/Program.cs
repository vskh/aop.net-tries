using System;
using PurseSharp.Lib;
using TestUtil;

namespace PureSharp
{
	class Program
	{
		static void Main(string[] args)
		{
			var timingAspect = new TimingAspect();
			timingAspect.Weave<InstrumentedClassPointcut>();
			
			var testClass = new TestClass();
			var instrumentedTestClass = new InstrumentedTestClass();
			
			testClass.SuccessfulVoidOperation();
			instrumentedTestClass.SuccessfulVoidOperation();
			
			// try
			// {
			// 	instrumentedTestClass.FailedVoidOperation();
			// }
			// catch (Exception ex)
			// {
			// 	Console.Error.WriteLine($"Caught exception: {ex}");
			// }
			
			var result = testClass.SuccessfulOperationWithReturnValue();
			result = instrumentedTestClass.SuccessfulOperationWithReturnValue();
			
			// try
			// {
			// 	result = instrumentedTestClass.FailedOperationWithReturnValue();
			// }
			// catch (Exception ex)
			// {
			// 	Console.Error.WriteLine($"Caught exception: {ex}");
			// }
			
			Console.WriteLine();

			testClass.ShouldLog = false;
			instrumentedTestClass.ShouldLog = false;
			timingAspect.ShouldLog = false;
			
			OverheadTester.Time(
				"SuccessfulVoidOperation",
				() => testClass.SuccessfulVoidOperation(),
				() => instrumentedTestClass.SuccessfulVoidOperation());
			
			OverheadTester.Time(
				"SuccessfulOperationWithReturnValue",
				() => testClass.SuccessfulOperationWithReturnValue(),
				() => instrumentedTestClass.SuccessfulOperationWithReturnValue());
			
			OverheadTester.Time(
				"FailedVoidOperation",
				() => testClass.FailedVoidOperation(),
				() => instrumentedTestClass.FailedVoidOperation(),
				100000);
			
			OverheadTester.Time(
				"FailedOperationWithReturnValue",
				() => testClass.FailedOperationWithReturnValue(),
				() => instrumentedTestClass.FailedOperationWithReturnValue(),
				100000);
		}
	}
}