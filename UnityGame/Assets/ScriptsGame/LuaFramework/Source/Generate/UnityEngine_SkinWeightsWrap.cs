﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_SkinWeightsWrap
{
	public static void Register(LuaState L)
	{
		L.BeginEnum(typeof(UnityEngine.SkinWeights),"SkinWeights");
		L.RegVar("None", get_None, null);
		L.RegVar("OneBone", get_OneBone, null);
		L.RegVar("TwoBones", get_TwoBones, null);
		L.RegVar("FourBones", get_FourBones, null);
		L.RegVar("Unlimited", get_Unlimited, null);
		L.RegFunction("IntToEnum", IntToEnum);
		L.EndEnum();
		TypeTraits<UnityEngine.SkinWeights>.Check = CheckType;
		StackTraits<UnityEngine.SkinWeights>.Push = Push;
	}

	static void Push(IntPtr L, UnityEngine.SkinWeights arg)
	{
		ToLua.Push(L, arg);
	}

	static bool CheckType(IntPtr L, int pos)
	{
		return TypeChecker.CheckEnumType(typeof(UnityEngine.SkinWeights), L, pos);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_None(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.SkinWeights.None);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_OneBone(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.SkinWeights.OneBone);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_TwoBones(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.SkinWeights.TwoBones);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_FourBones(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.SkinWeights.FourBones);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Unlimited(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.SkinWeights.Unlimited);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		UnityEngine.SkinWeights o = (UnityEngine.SkinWeights)arg0;
		ToLua.Push(L, o);
		return 1;
	}
}

