using System;
using System.Reflection;
using Puresharp;
using TestUtil;

namespace PurseSharp.Lib
{
	public class InstrumentedClassPointcut : Pointcut, ILoggerTrait
	{
		public override bool Match(MethodBase method)
		{
			var result = method.ReflectedType == typeof(InstrumentedTestClass); 
			_Log($"Testing {method.ReflectedType?.Name}[{method.DeclaringType?.Name}]::{method.Name}: {result}.");
			return result;
		}


		private void _Log(string msg)
		{
			(this as ILoggerTrait).Log(msg);
		}


		public bool ShouldLog { get; set; } = true;
	}
}