﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FakeThat
{
    public partial class Fake<TObj> : Fake 
        where TObj : class
    {
		/// <summary>
		/// Execute <paramref name="stub"/> when <paramref name="method"/> is called. <paramref name="method"/> must be a method of an object created with <see cref="Mock"/>.
		/// </summary>
		public StubbedAction Stub(Action method, Action stub) 
		{ 
			return RegisterStub(method, stub, new StubbedAction()); 
		}
		 
		/// <summary>
		/// Execute <paramref name="stub"/> when <paramref name="method"/> is called. <paramref name="method"/> must be a method of an object created with <see cref="Mock"/>.
		/// </summary>
		public StubbedAction<T1> Stub<T1>(Action<T1> method, Action<T1> stub) 
		{ 
			return RegisterStub(method, stub, new StubbedAction<T1>()); 
		}
		 
		/// <summary>
		/// Execute <paramref name="stub"/> when <paramref name="method"/> is called. <paramref name="method"/> must be a method of an object created with <see cref="Mock"/>.
		/// </summary>
		public StubbedAction<T1, T2> Stub<T1, T2>(Action<T1, T2> method, Action<T1, T2> stub) 
		{ 
			return RegisterStub(method, stub, new StubbedAction<T1, T2>()); 
		}
		 
		/// <summary>
		/// Execute <paramref name="stub"/> when <paramref name="method"/> is called. <paramref name="method"/> must be a method of an object created with <see cref="Mock"/>.
		/// </summary>
		public StubbedAction<T1, T2, T3> Stub<T1, T2, T3>(Action<T1, T2, T3> method, Action<T1, T2, T3> stub) 
		{ 
			return RegisterStub(method, stub, new StubbedAction<T1, T2, T3>()); 
		}
		 
		/// <summary>
		/// Execute <paramref name="stub"/> when <paramref name="method"/> is called. <paramref name="method"/> must be a method of an object created with <see cref="Mock"/>.
		/// </summary>
		public StubbedAction<T1, T2, T3, T4> Stub<T1, T2, T3, T4>(Action<T1, T2, T3, T4> method, Action<T1, T2, T3, T4> stub) 
		{ 
			return RegisterStub(method, stub, new StubbedAction<T1, T2, T3, T4>()); 
		}
		 
		/// <summary>
		/// Execute <paramref name="stub"/> when <paramref name="method"/> is called. <paramref name="method"/> must be a method of an object created with <see cref="Mock"/>.
		/// </summary>
		public StubbedAction<T1, T2, T3, T4, T5> Stub<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> method, Action<T1, T2, T3, T4, T5> stub) 
		{ 
			return RegisterStub(method, stub, new StubbedAction<T1, T2, T3, T4, T5>()); 
		}
		 
		/// <summary>
		/// Execute <paramref name="stub"/> when <paramref name="method"/> is called. <paramref name="method"/> must be a method of an object created with <see cref="Mock"/>.
		/// </summary>
		public StubbedAction<T1, T2, T3, T4, T5, T6> Stub<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> method, Action<T1, T2, T3, T4, T5, T6> stub) 
		{ 
			return RegisterStub(method, stub, new StubbedAction<T1, T2, T3, T4, T5, T6>()); 
		}
		 
		/// <summary>
		/// Execute <paramref name="stub"/> when <paramref name="method"/> is called. <paramref name="method"/> must be a method of an object created with <see cref="Mock"/>.
		/// </summary>
		public StubbedAction<T1, T2, T3, T4, T5, T6, T7> Stub<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> method, Action<T1, T2, T3, T4, T5, T6, T7> stub) 
		{ 
			return RegisterStub(method, stub, new StubbedAction<T1, T2, T3, T4, T5, T6, T7>()); 
		}
		 
		/// <summary>
		/// Execute <paramref name="stub"/> when <paramref name="method"/> is called. <paramref name="method"/> must be a method of an object created with <see cref="Mock"/>.
		/// </summary>
		public StubbedAction<T1, T2, T3, T4, T5, T6, T7, T8> Stub<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> method, Action<T1, T2, T3, T4, T5, T6, T7, T8> stub) 
		{ 
			return RegisterStub(method, stub, new StubbedAction<T1, T2, T3, T4, T5, T6, T7, T8>()); 
		}
		 
		/// <summary>
		/// Execute <paramref name="stub"/> when <paramref name="method"/> is called. <paramref name="method"/> must be a method of an object created with <see cref="Mock"/>.
		/// </summary>
		public StubbedFunc<TRet> Stub<TRet>(Func<TRet> method, Func<TRet> stub) 
		{ 
			return RegisterStub(method, stub, new StubbedFunc<TRet>()); 
		}
		 
		/// <summary>
		/// Execute <paramref name="stub"/> when <paramref name="method"/> is called. <paramref name="method"/> must be a method of an object created with <see cref="Mock"/>.
		/// </summary>
		public StubbedFunc<T1, TRet> Stub<T1, TRet>(Func<T1, TRet> method, Func<T1, TRet> stub) 
		{ 
			return RegisterStub(method, stub, new StubbedFunc<T1, TRet>()); 
		}
		 
		/// <summary>
		/// Execute <paramref name="stub"/> when <paramref name="method"/> is called. <paramref name="method"/> must be a method of an object created with <see cref="Mock"/>.
		/// </summary>
		public StubbedFunc<T1, T2, TRet> Stub<T1, T2, TRet>(Func<T1, T2, TRet> method, Func<T1, T2, TRet> stub) 
		{ 
			return RegisterStub(method, stub, new StubbedFunc<T1, T2, TRet>()); 
		}
		 
		/// <summary>
		/// Execute <paramref name="stub"/> when <paramref name="method"/> is called. <paramref name="method"/> must be a method of an object created with <see cref="Mock"/>.
		/// </summary>
		public StubbedFunc<T1, T2, T3, TRet> Stub<T1, T2, T3, TRet>(Func<T1, T2, T3, TRet> method, Func<T1, T2, T3, TRet> stub) 
		{ 
			return RegisterStub(method, stub, new StubbedFunc<T1, T2, T3, TRet>()); 
		}
		 
		/// <summary>
		/// Execute <paramref name="stub"/> when <paramref name="method"/> is called. <paramref name="method"/> must be a method of an object created with <see cref="Mock"/>.
		/// </summary>
		public StubbedFunc<T1, T2, T3, T4, TRet> Stub<T1, T2, T3, T4, TRet>(Func<T1, T2, T3, T4, TRet> method, Func<T1, T2, T3, T4, TRet> stub) 
		{ 
			return RegisterStub(method, stub, new StubbedFunc<T1, T2, T3, T4, TRet>()); 
		}
		 
		/// <summary>
		/// Execute <paramref name="stub"/> when <paramref name="method"/> is called. <paramref name="method"/> must be a method of an object created with <see cref="Mock"/>.
		/// </summary>
		public StubbedFunc<T1, T2, T3, T4, T5, TRet> Stub<T1, T2, T3, T4, T5, TRet>(Func<T1, T2, T3, T4, T5, TRet> method, Func<T1, T2, T3, T4, T5, TRet> stub) 
		{ 
			return RegisterStub(method, stub, new StubbedFunc<T1, T2, T3, T4, T5, TRet>()); 
		}
		 
		/// <summary>
		/// Execute <paramref name="stub"/> when <paramref name="method"/> is called. <paramref name="method"/> must be a method of an object created with <see cref="Mock"/>.
		/// </summary>
		public StubbedFunc<T1, T2, T3, T4, T5, T6, TRet> Stub<T1, T2, T3, T4, T5, T6, TRet>(Func<T1, T2, T3, T4, T5, T6, TRet> method, Func<T1, T2, T3, T4, T5, T6, TRet> stub) 
		{ 
			return RegisterStub(method, stub, new StubbedFunc<T1, T2, T3, T4, T5, T6, TRet>()); 
		}
		 
		/// <summary>
		/// Execute <paramref name="stub"/> when <paramref name="method"/> is called. <paramref name="method"/> must be a method of an object created with <see cref="Mock"/>.
		/// </summary>
		public StubbedFunc<T1, T2, T3, T4, T5, T6, T7, TRet> Stub<T1, T2, T3, T4, T5, T6, T7, TRet>(Func<T1, T2, T3, T4, T5, T6, T7, TRet> method, Func<T1, T2, T3, T4, T5, T6, T7, TRet> stub) 
		{ 
			return RegisterStub(method, stub, new StubbedFunc<T1, T2, T3, T4, T5, T6, T7, TRet>()); 
		}
		 
		/// <summary>
		/// Execute <paramref name="stub"/> when <paramref name="method"/> is called. <paramref name="method"/> must be a method of an object created with <see cref="Mock"/>.
		/// </summary>
		public StubbedFunc<T1, T2, T3, T4, T5, T6, T7, T8, TRet> Stub<T1, T2, T3, T4, T5, T6, T7, T8, TRet>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TRet> method, Func<T1, T2, T3, T4, T5, T6, T7, T8, TRet> stub) 
		{ 
			return RegisterStub(method, stub, new StubbedFunc<T1, T2, T3, T4, T5, T6, T7, T8, TRet>()); 
		}
		 
	}
}
