﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_Networking_DownloadHandlerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.Networking.DownloadHandler), typeof(System.Object),"DownloadHandler");
		L.RegFunction("Dispose", Dispose);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("isDone", get_isDone, null);
		L.RegVar("error", get_error, null);
		L.RegVar("nativeData", get_nativeData, null);
		L.RegVar("data", get_data, null);
		L.RegVar("text", get_text, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Dispose(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.Networking.DownloadHandler obj = (UnityEngine.Networking.DownloadHandler)ToLua.CheckObject<UnityEngine.Networking.DownloadHandler>(L, 1);
			obj.Dispose();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isDone(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Networking.DownloadHandler obj = (UnityEngine.Networking.DownloadHandler)o;
			bool ret = obj.isDone;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index isDone on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_error(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Networking.DownloadHandler obj = (UnityEngine.Networking.DownloadHandler)o;
			string ret = obj.error;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index error on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_nativeData(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Networking.DownloadHandler obj = (UnityEngine.Networking.DownloadHandler)o;
			Unity.Collections.NativeArray<byte>.ReadOnly ret = obj.nativeData;
			ToLua.PushValue(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index nativeData on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_data(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Networking.DownloadHandler obj = (UnityEngine.Networking.DownloadHandler)o;
			byte[] ret = obj.data;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index data on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_text(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Networking.DownloadHandler obj = (UnityEngine.Networking.DownloadHandler)o;
			string ret = obj.text;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index text on a nil value");
		}
	}
}

