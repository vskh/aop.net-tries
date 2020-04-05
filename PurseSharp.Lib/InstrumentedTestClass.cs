using TestUtil;

namespace PurseSharp.Lib
{
	public class InstrumentedTestClass : TestClass
	{
		public override void SuccessfulVoidOperation()
		{
			base.SuccessfulVoidOperation();
		}


		public override void FailedVoidOperation()
		{
			base.FailedVoidOperation();
		}


		public override int SuccessfulOperationWithReturnValue()
		{
			return base.SuccessfulOperationWithReturnValue();
		}


		public override int FailedOperationWithReturnValue()
		{
			return base.FailedOperationWithReturnValue();
		}
	}
}