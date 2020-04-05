using System.Collections.Generic;
using System.Reflection;
using Puresharp;

namespace PurseSharp.Lib
{
	public class TimingAspect : Aspect
	{
		public bool ShouldLog { get; set; } = true;
		
		public override IEnumerable<Advisor> Manage(MethodBase method)
		{
			yield return Advice.For(method).Around(() => new TimingAdvice(method, ShouldLog));
		}
	}
}