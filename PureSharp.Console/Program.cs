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

			var instrumentedClass = new InstrumentedClass();
			instrumentedClass.TimedOperation();
		}
	}
}