﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class TestLuaFunWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(TestLuaFun), typeof(System.Object));
		L.RegFunction("Log", Log);
		L.RegFunction("New", _CreateTestLuaFun);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateTestLuaFun(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				TestLuaFun obj = new TestLuaFun();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: TestLuaFun.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Log(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			TestLuaFun.Log();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

