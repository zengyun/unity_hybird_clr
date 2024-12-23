﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_AnimatorCullingModeWrap
{
	public static void Register(LuaState L)
	{
		L.BeginEnum(typeof(UnityEngine.AnimatorCullingMode),"AnimatorCullingMode");
		L.RegVar("AlwaysAnimate", get_AlwaysAnimate, null);
		L.RegVar("CullUpdateTransforms", get_CullUpdateTransforms, null);
		L.RegVar("CullCompletely", get_CullCompletely, null);
		L.RegFunction("IntToEnum", IntToEnum);
		L.EndEnum();
		TypeTraits<UnityEngine.AnimatorCullingMode>.Check = CheckType;
		StackTraits<UnityEngine.AnimatorCullingMode>.Push = Push;
	}

	static void Push(IntPtr L, UnityEngine.AnimatorCullingMode arg)
	{
		ToLua.Push(L, arg);
	}

	static bool CheckType(IntPtr L, int pos)
	{
		return TypeChecker.CheckEnumType(typeof(UnityEngine.AnimatorCullingMode), L, pos);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_AlwaysAnimate(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.AnimatorCullingMode.AlwaysAnimate);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_CullUpdateTransforms(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.AnimatorCullingMode.CullUpdateTransforms);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_CullCompletely(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.AnimatorCullingMode.CullCompletely);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		UnityEngine.AnimatorCullingMode o = (UnityEngine.AnimatorCullingMode)arg0;
		ToLua.Push(L, o);
		return 1;
	}
}

