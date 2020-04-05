using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Threading.Tasks;
using Puresharp;
using TestUtil;

namespace PurseSharp.Lib
{
	public class TimingAdvice : IAdvice, ILoggerTrait
	{
		private Stopwatch m_timer;
		private readonly MethodBase m_method;


		public TimingAdvice(MethodBase method, bool shouldLog = true)
		{
			ShouldLog = shouldLog;
			m_method = method;
			
			_Log("Created.");
		}


		public void Dispose()
		{
		}


		public void Instance<T>(T value)
		{
			_Log($"Bound to instance {value.GetHashCode()}.");
		}


		public void Argument<T>(ref T value)
		{
		}


		public void Begin()
		{
			_Log($"{m_method.DeclaringType?.Name}::{m_method.Name} is starting execution");
			m_timer = Stopwatch.StartNew();
		}


		public void Await(MethodInfo method, Task task)
		{
		}


		public void Await<T>(MethodInfo method, Task<T> task)
		{
		}


		public void Continue()
		{
		}


		public void Throw(ref Exception exception)
		{
			m_timer.Stop();

			_Log($"{m_method.DeclaringType?.Name}::{m_method.Name} finished abnormally in {m_timer.ElapsedMilliseconds} ms " +
				$"with exception '{exception.Message}'.");
		}


		public void Throw<T>(ref Exception exception, ref T value)
		{
			m_timer.Stop();

			_Log($"{m_method.DeclaringType?.Name}::{m_method.Name} finished abnormally in {m_timer.ElapsedMilliseconds} ms " +
			    $"and returned {value}.");
		}


		public void Return()
		{
			m_timer.Stop();

			_Log($"{m_method.DeclaringType?.Name}::{m_method.Name} finished normally in {m_timer.ElapsedMilliseconds} ms.");
		}


		public void Return<T>(ref T value)
		{
			m_timer.Stop();

			_Log($"{m_method.DeclaringType?.Name}::{m_method.Name} finished normally in {m_timer.ElapsedMilliseconds} ms " +
			    $"and returned '{value}'.");
		}


		private void _Log(string msg)
		{
			(this as ILoggerTrait).Log(msg);
		}


		public bool ShouldLog { get; set; } = true;
	}
}