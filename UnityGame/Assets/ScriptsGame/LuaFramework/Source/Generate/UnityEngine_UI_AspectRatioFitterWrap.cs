﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_UI_AspectRatioFitterWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.UI.AspectRatioFitter), typeof(UnityEngine.EventSystems.UIBehaviour),"AspectRatioFitter");
		L.RegFunction("SetLayoutHorizontal", SetLayoutHorizontal);
		L.RegFunction("SetLayoutVertical", SetLayoutVertical);
		L.RegFunction("IsComponentValidOnObject", IsComponentValidOnObject);
		L.RegFunction("IsAspectModeValid", IsAspectModeValid);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("aspectMode", get_aspectMode, set_aspectMode);
		L.RegVar("aspectRatio", get_aspectRatio, set_aspectRatio);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetLayoutHorizontal(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.UI.AspectRatioFitter obj = (UnityEngine.UI.AspectRatioFitter)ToLua.CheckObject<UnityEngine.UI.AspectRatioFitter>(L, 1);
			obj.SetLayoutHorizontal();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetLayoutVertical(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.UI.AspectRatioFitter obj = (UnityEngine.UI.AspectRatioFitter)ToLua.CheckObject<UnityEngine.UI.AspectRatioFitter>(L, 1);
			obj.SetLayoutVertical();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsComponentValidOnObject(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.UI.AspectRatioFitter obj = (UnityEngine.UI.AspectRatioFitter)ToLua.CheckObject<UnityEngine.UI.AspectRatioFitter>(L, 1);
			bool o = obj.IsComponentValidOnObject();
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsAspectModeValid(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.UI.AspectRatioFitter obj = (UnityEngine.UI.AspectRatioFitter)ToLua.CheckObject<UnityEngine.UI.AspectRatioFitter>(L, 1);
			bool o = obj.IsAspectModeValid();
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_aspectMode(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.AspectRatioFitter obj = (UnityEngine.UI.AspectRatioFitter)o;
			UnityEngine.UI.AspectRatioFitter.AspectMode ret = obj.aspectMode;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index aspectMode on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_aspectRatio(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.AspectRatioFitter obj = (UnityEngine.UI.AspectRatioFitter)o;
			float ret = obj.aspectRatio;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index aspectRatio on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_aspectMode(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.AspectRatioFitter obj = (UnityEngine.UI.AspectRatioFitter)o;
			UnityEngine.UI.AspectRatioFitter.AspectMode arg0 = (UnityEngine.UI.AspectRatioFitter.AspectMode)ToLua.CheckObject(L, 2, typeof(UnityEngine.UI.AspectRatioFitter.AspectMode));
			obj.aspectMode = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index aspectMode on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_aspectRatio(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.AspectRatioFitter obj = (UnityEngine.UI.AspectRatioFitter)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.aspectRatio = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index aspectRatio on a nil value");
		}
	}
}
