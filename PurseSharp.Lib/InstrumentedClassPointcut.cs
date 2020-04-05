using System.Reflection;
using Puresharp;
using TestUtil;

namespace PurseSharp.Lib
{
	public class InstrumentedClassPointcut : Pointcut
	{
		public override bool Match(MethodBase method)
		{
			return method.DeclaringType == typeof(InstrumentedClass) &&
			       method.Name == nameof(InstrumentedClass.TimedOperation);
		}
	}
}