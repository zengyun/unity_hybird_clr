﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_Networking_UnityWebRequestAsyncOperationWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.Networking.UnityWebRequestAsyncOperation), typeof(UnityEngine.AsyncOperation),"UnityWebRequestAsyncOperation");
		L.RegFunction("New", _CreateUnityEngine_Networking_UnityWebRequestAsyncOperation);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("webRequest", get_webRequest, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUnityEngine_Networking_UnityWebRequestAsyncOperation(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				UnityEngine.Networking.UnityWebRequestAsyncOperation obj = new UnityEngine.Networking.UnityWebRequestAsyncOperation();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: UnityEngine.Networking.UnityWebRequestAsyncOperation.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_webRequest(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Networking.UnityWebRequestAsyncOperation obj = (UnityEngine.Networking.UnityWebRequestAsyncOperation)o;
			UnityEngine.Networking.UnityWebRequest ret = obj.webRequest;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index webRequest on a nil value");
		}
	}
}

