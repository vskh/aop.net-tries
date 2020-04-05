using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Threading.Tasks;
using Puresharp;

namespace PurseSharp.Lib
{
	public class TimingAdvice : IAdvice
	{
		private Stopwatch m_timer;
		private readonly MethodBase m_method;


		public TimingAdvice(MethodBase method)
		{
			m_method = method;
		}


		public void Dispose()
		{
		}


		public void Instance<T>(T value)
		{
		}


		public void Argument<T>(ref T value)
		{
		}


		public void Begin()
		{
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

			Console.WriteLine(
				$"[{nameof(TimingAspect)}] " +
				$"{m_method.DeclaringType?.Name}::{m_method.Name} finished abnormally in {m_timer.ElapsedMilliseconds} ms.");
		}


		public void Throw<T>(ref Exception exception, ref T value)
		{
			m_timer.Stop();

			Console.WriteLine(
				$"[{nameof(TimingAspect)}] " +
				$"{m_method.DeclaringType?.Name}::{m_method.Name} finished abnormally in {m_timer.ElapsedMilliseconds} ms.");
		}


		public void Return()
		{
			m_timer.Stop();

			Console.WriteLine(
				$"[{nameof(TimingAspect)}] " +
				$"{m_method.DeclaringType?.Name}::{m_method.Name} finished normally in {m_timer.ElapsedMilliseconds} ms.");
		}


		public void Return<T>(ref T value)
		{
			m_timer.Stop();

			Console.WriteLine(
				$"[{nameof(TimingAspect)}] " +
				$"{m_method.DeclaringType?.Name}::{m_method.Name} finished normally in {m_timer.ElapsedMilliseconds} ms and returned '{value}'.");
		}
	}
}