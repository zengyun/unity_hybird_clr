﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_LineRendererWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.LineRenderer), typeof(UnityEngine.Renderer),"LineRenderer");
		L.RegFunction("SetPosition", SetPosition);
		L.RegFunction("GetPosition", GetPosition);
		L.RegFunction("Simplify", Simplify);
		L.RegFunction("BakeMesh", BakeMesh);
		L.RegFunction("GetPositions", GetPositions);
		L.RegFunction("SetPositions", SetPositions);
		L.RegFunction("New", _CreateUnityEngine_LineRenderer);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("startWidth", get_startWidth, set_startWidth);
		L.RegVar("endWidth", get_endWidth, set_endWidth);
		L.RegVar("widthMultiplier", get_widthMultiplier, set_widthMultiplier);
		L.RegVar("numCornerVertices", get_numCornerVertices, set_numCornerVertices);
		L.RegVar("numCapVertices", get_numCapVertices, set_numCapVertices);
		L.RegVar("useWorldSpace", get_useWorldSpace, set_useWorldSpace);
		L.RegVar("loop", get_loop, set_loop);
		L.RegVar("startColor", get_startColor, set_startColor);
		L.RegVar("endColor", get_endColor, set_endColor);
		L.RegVar("positionCount", get_positionCount, set_positionCount);
		L.RegVar("textureScale", get_textureScale, set_textureScale);
		L.RegVar("shadowBias", get_shadowBias, set_shadowBias);
		L.RegVar("generateLightingData", get_generateLightingData, set_generateLightingData);
		L.RegVar("textureMode", get_textureMode, set_textureMode);
		L.RegVar("alignment", get_alignment, set_alignment);
		L.RegVar("maskInteraction", get_maskInteraction, set_maskInteraction);
		L.RegVar("widthCurve", get_widthCurve, set_widthCurve);
		L.RegVar("colorGradient", get_colorGradient, set_colorGradient);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUnityEngine_LineRenderer(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				UnityEngine.LineRenderer obj = new UnityEngine.LineRenderer();
				ToLua.PushSealed(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: UnityEngine.LineRenderer.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetPosition(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			UnityEngine.LineRenderer obj = (UnityEngine.LineRenderer)ToLua.CheckObject(L, 1, typeof(UnityEngine.LineRenderer));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.Vector3 arg1 = ToLua.ToVector3(L, 3);
			obj.SetPosition(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetPosition(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.LineRenderer obj = (UnityEngine.LineRenderer)ToLua.CheckObject(L, 1, typeof(UnityEngine.LineRenderer));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.Vector3 o = obj.GetPosition(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Simplify(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.LineRenderer obj = (UnityEngine.LineRenderer)ToLua.CheckObject(L, 1, typeof(UnityEngine.LineRenderer));
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.Simplify(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int BakeMesh(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				UnityEngine.LineRenderer obj = (UnityEngine.LineRenderer)ToLua.CheckObject(L, 1, typeof(UnityEngine.LineRenderer));
				UnityEngine.Mesh arg0 = (UnityEngine.Mesh)ToLua.CheckObject(L, 2, typeof(UnityEngine.Mesh));
				obj.BakeMesh(arg0);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes<bool>(L, 3))
			{
				UnityEngine.LineRenderer obj = (UnityEngine.LineRenderer)ToLua.CheckObject(L, 1, typeof(UnityEngine.LineRenderer));
				UnityEngine.Mesh arg0 = (UnityEngine.Mesh)ToLua.CheckObject(L, 2, typeof(UnityEngine.Mesh));
				bool arg1 = LuaDLL.lua_toboolean(L, 3);
				obj.BakeMesh(arg0, arg1);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes<UnityEngine.Camera>(L, 3))
			{
				UnityEngine.LineRenderer obj = (UnityEngine.LineRenderer)ToLua.CheckObject(L, 1, typeof(UnityEngine.LineRenderer));
				UnityEngine.Mesh arg0 = (UnityEngine.Mesh)ToLua.CheckObject(L, 2, typeof(UnityEngine.Mesh));
				UnityEngine.Camera arg1 = (UnityEngine.Camera)ToLua.ToObject(L, 3);
				obj.BakeMesh(arg0, arg1);
				return 0;
			}
			else if (count == 4)
			{
				UnityEngine.LineRenderer obj = (UnityEngine.LineRenderer)ToLua.CheckObject(L, 1, typeof(UnityEngine.LineRenderer));
				UnityEngine.Mesh arg0 = (UnityEngine.Mesh)ToLua.CheckObject(L, 2, typeof(UnityEngine.Mesh));
				UnityEngine.Camera arg1 = (UnityEngine.Camera)ToLua.CheckObject(L, 3, typeof(UnityEngine.Camera));
				bool arg2 = LuaDLL.luaL_checkboolean(L, 4);
				obj.BakeMesh(arg0, arg1, arg2);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.LineRenderer.BakeMesh");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetPositions(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes<UnityEngine.Vector3[]>(L, 2))
			{
				UnityEngine.LineRenderer obj = (UnityEngine.LineRenderer)ToLua.CheckObject(L, 1, typeof(UnityEngine.LineRenderer));
				UnityEngine.Vector3[] arg0 = ToLua.ToStructArray<UnityEngine.Vector3>(L, 2);
				int o = obj.GetPositions(arg0);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes<Unity.Collections.NativeArray<UnityEngine.Vector3>>(L, 2))
			{
				UnityEngine.LineRenderer obj = (UnityEngine.LineRenderer)ToLua.CheckObject(L, 1, typeof(UnityEngine.LineRenderer));
				Unity.Collections.NativeArray<UnityEngine.Vector3> arg0 = StackTraits<Unity.Collections.NativeArray<UnityEngine.Vector3>>.To(L, 2);
				int o = obj.GetPositions(arg0);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes<Unity.Collections.NativeSlice<UnityEngine.Vector3>>(L, 2))
			{
				UnityEngine.LineRenderer obj = (UnityEngine.LineRenderer)ToLua.CheckObject(L, 1, typeof(UnityEngine.LineRenderer));
				Unity.Collections.NativeSlice<UnityEngine.Vector3> arg0 = StackTraits<Unity.Collections.NativeSlice<UnityEngine.Vector3>>.To(L, 2);
				int o = obj.GetPositions(arg0);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.LineRenderer.GetPositions");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetPositions(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes<UnityEngine.Vector3[]>(L, 2))
			{
				UnityEngine.LineRenderer obj = (UnityEngine.LineRenderer)ToLua.CheckObject(L, 1, typeof(UnityEngine.LineRenderer));
				UnityEngine.Vector3[] arg0 = ToLua.ToStructArray<UnityEngine.Vector3>(L, 2);
				obj.SetPositions(arg0);
				return 0;
			}
			else if (count == 2 && TypeChecker.CheckTypes<Unity.Collections.NativeArray<UnityEngine.Vector3>>(L, 2))
			{
				UnityEngine.LineRenderer obj = (UnityEngine.LineRenderer)ToLua.CheckObject(L, 1, typeof(UnityEngine.LineRenderer));
				Unity.Collections.NativeArray<UnityEngine.Vector3> arg0 = StackTraits<Unity.Collections.NativeArray<UnityEngine.Vector3>>.To(L, 2);
				obj.SetPositions(arg0);
				return 0;
			}
			else if (count == 2 && TypeChecker.CheckTypes<Unity.Collections.NativeSlice<UnityEngine.Vector3>>(L, 2))
			{
				UnityEngine.LineRenderer obj = (UnityEngine.LineRenderer)ToLua.CheckObject(L, 1, typeof(UnityEngine.LineRenderer));
				Unity.Collections.NativeSlice<UnityEngine.Vector3> arg0 = StackTraits<Unity.Collections.NativeSlice<UnityEngine.Vector3>>.To(L, 2);
				obj.SetPositions(arg0);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.LineRenderer.SetPositions");
			}
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
	static int get_startWidth(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.LineRenderer obj = (UnityEngine.LineRenderer)o;
			float ret = obj.startWidth;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index startWidth on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_endWidth(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.LineRenderer obj = (UnityEngine.LineRenderer)o;
			float ret = obj.endWidth;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index endWidth on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_widthMultiplier(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.LineRenderer obj = (UnityEngine.LineRenderer)o;
			float ret = obj.widthMultiplier;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index widthMultiplier on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_numCornerVertices(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.LineRenderer obj = (UnityEngine.LineRenderer)o;
			int ret = obj.numCornerVertices;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index numCornerVertices on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_numCapVertices(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.LineRenderer obj = (UnityEngine.LineRenderer)o;
			int ret = obj.numCapVertices;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index numCapVertices on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_useWorldSpace(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.LineRenderer obj = (UnityEngine.LineRenderer)o;
			bool ret = obj.useWorldSpace;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index useWorldSpace on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_loop(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.LineRenderer obj = (UnityEngine.LineRenderer)o;
			bool ret = obj.loop;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index loop on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_startColor(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.LineRenderer obj = (UnityEngine.LineRenderer)o;
			UnityEngine.Color ret = obj.startColor;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index startColor on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_endColor(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.LineRenderer obj = (UnityEngine.LineRenderer)o;
			UnityEngine.Color ret = obj.endColor;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index endColor on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_positionCount(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.LineRenderer obj = (UnityEngine.LineRenderer)o;
			int ret = obj.positionCount;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index positionCount on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_textureScale(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.LineRenderer obj = (UnityEngine.LineRenderer)o;
			UnityEngine.Vector2 ret = obj.textureScale;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index textureScale on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_shadowBias(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.LineRenderer obj = (UnityEngine.LineRenderer)o;
			float ret = obj.shadowBias;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index shadowBias on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_generateLightingData(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.LineRenderer obj = (UnityEngine.LineRenderer)o;
			bool ret = obj.generateLightingData;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index generateLightingData on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_textureMode(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.LineRenderer obj = (UnityEngine.LineRenderer)o;
			UnityEngine.LineTextureMode ret = obj.textureMode;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index textureMode on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_alignment(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.LineRenderer obj = (UnityEngine.LineRenderer)o;
			UnityEngine.LineAlignment ret = obj.alignment;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index alignment on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_maskInteraction(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.LineRenderer obj = (UnityEngine.LineRenderer)o;
			UnityEngine.SpriteMaskInteraction ret = obj.maskInteraction;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index maskInteraction on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_widthCurve(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.LineRenderer obj = (UnityEngine.LineRenderer)o;
			UnityEngine.AnimationCurve ret = obj.widthCurve;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index widthCurve on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_colorGradient(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.LineRenderer obj = (UnityEngine.LineRenderer)o;
			UnityEngine.Gradient ret = obj.colorGradient;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index colorGradient on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_startWidth(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.LineRenderer obj = (UnityEngine.LineRenderer)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.startWidth = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index startWidth on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_endWidth(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.LineRenderer obj = (UnityEngine.LineRenderer)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.endWidth = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index endWidth on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_widthMultiplier(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.LineRenderer obj = (UnityEngine.LineRenderer)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.widthMultiplier = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index widthMultiplier on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_numCornerVertices(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.LineRenderer obj = (UnityEngine.LineRenderer)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.numCornerVertices = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index numCornerVertices on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_numCapVertices(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.LineRenderer obj = (UnityEngine.LineRenderer)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.numCapVertices = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index numCapVertices on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_useWorldSpace(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.LineRenderer obj = (UnityEngine.LineRenderer)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.useWorldSpace = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index useWorldSpace on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_loop(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.LineRenderer obj = (UnityEngine.LineRenderer)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.loop = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index loop on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_startColor(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.LineRenderer obj = (UnityEngine.LineRenderer)o;
			UnityEngine.Color arg0 = ToLua.ToColor(L, 2);
			obj.startColor = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index startColor on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_endColor(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.LineRenderer obj = (UnityEngine.LineRenderer)o;
			UnityEngine.Color arg0 = ToLua.ToColor(L, 2);
			obj.endColor = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index endColor on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_positionCount(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.LineRenderer obj = (UnityEngine.LineRenderer)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.positionCount = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index positionCount on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_textureScale(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.LineRenderer obj = (UnityEngine.LineRenderer)o;
			UnityEngine.Vector2 arg0 = ToLua.ToVector2(L, 2);
			obj.textureScale = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index textureScale on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_shadowBias(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.LineRenderer obj = (UnityEngine.LineRenderer)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.shadowBias = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index shadowBias on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_generateLightingData(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.LineRenderer obj = (UnityEngine.LineRenderer)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.generateLightingData = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index generateLightingData on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_textureMode(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.LineRenderer obj = (UnityEngine.LineRenderer)o;
			UnityEngine.LineTextureMode arg0 = (UnityEngine.LineTextureMode)ToLua.CheckObject(L, 2, typeof(UnityEngine.LineTextureMode));
			obj.textureMode = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index textureMode on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_alignment(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.LineRenderer obj = (UnityEngine.LineRenderer)o;
			UnityEngine.LineAlignment arg0 = (UnityEngine.LineAlignment)ToLua.CheckObject(L, 2, typeof(UnityEngine.LineAlignment));
			obj.alignment = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index alignment on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_maskInteraction(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.LineRenderer obj = (UnityEngine.LineRenderer)o;
			UnityEngine.SpriteMaskInteraction arg0 = (UnityEngine.SpriteMaskInteraction)ToLua.CheckObject(L, 2, typeof(UnityEngine.SpriteMaskInteraction));
			obj.maskInteraction = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index maskInteraction on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_widthCurve(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.LineRenderer obj = (UnityEngine.LineRenderer)o;
			UnityEngine.AnimationCurve arg0 = (UnityEngine.AnimationCurve)ToLua.CheckObject<UnityEngine.AnimationCurve>(L, 2);
			obj.widthCurve = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index widthCurve on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_colorGradient(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.LineRenderer obj = (UnityEngine.LineRenderer)o;
			UnityEngine.Gradient arg0 = (UnityEngine.Gradient)ToLua.CheckObject<UnityEngine.Gradient>(L, 2);
			obj.colorGradient = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index colorGradient on a nil value");
		}
	}
}

