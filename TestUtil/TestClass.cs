using System;
using System.Reflection;

namespace TestUtil
{
	public class TestClass : ILoggerTrait
	{
		public bool ShouldLog { get; set; } = true;
		
		private int m_counter = 0;
		
		public TestClass()
		{
			_Log($"{nameof(TestClass)}::{MethodBase.GetCurrentMethod().Name}");
		}


		public virtual void SuccessfulVoidOperation()
		{
			_Log($"{nameof(TestClass)}::{MethodBase.GetCurrentMethod().Name}");
		}


		public virtual void FailedVoidOperation()
		{
			_Log($"{nameof(TestClass)}::{MethodBase.GetCurrentMethod().Name}");

			throw new Exception("FailedVoidOperation");
		}


		public virtual int SuccessfulOperationWithReturnValue()
		{
			_Log($"{nameof(TestClass)}::{MethodBase.GetCurrentMethod().Name}");

			return m_counter++;
		}
		
		
		public virtual int FailedOperationWithReturnValue()
		{
			_Log($"{nameof(TestClass)}::{MethodBase.GetCurrentMethod().Name}");

			throw new Exception("FailedOperationWithReturnValue");
		}
		
		public void _Log(string msg)
		{
			(this as ILoggerTrait).Log(msg);
		}
	}
}