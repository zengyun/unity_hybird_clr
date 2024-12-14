﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_TouchScreenKeyboardWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.TouchScreenKeyboard), typeof(System.Object),"TouchScreenKeyboard");
		L.RegFunction("Open", Open);
		L.RegFunction("New", _CreateUnityEngine_TouchScreenKeyboard);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("isSupported", get_isSupported, null);
		L.RegVar("isInPlaceEditingAllowed", get_isInPlaceEditingAllowed, null);
		L.RegVar("text", get_text, set_text);
		L.RegVar("hideInput", get_hideInput, set_hideInput);
		L.RegVar("active", get_active, set_active);
		L.RegVar("status", get_status, null);
		L.RegVar("characterLimit", get_characterLimit, set_characterLimit);
		L.RegVar("canGetSelection", get_canGetSelection, null);
		L.RegVar("canSetSelection", get_canSetSelection, null);
		L.RegVar("selection", get_selection, set_selection);
		L.RegVar("type", get_type, null);
		L.RegVar("targetDisplay", get_targetDisplay, set_targetDisplay);
		L.RegVar("area", get_area, null);
		L.RegVar("visible", get_visible, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUnityEngine_TouchScreenKeyboard(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 8)
			{
				string arg0 = ToLua.CheckString(L, 1);
				UnityEngine.TouchScreenKeyboardType arg1 = (UnityEngine.TouchScreenKeyboardType)ToLua.CheckObject(L, 2, typeof(UnityEngine.TouchScreenKeyboardType));
				bool arg2 = LuaDLL.luaL_checkboolean(L, 3);
				bool arg3 = LuaDLL.luaL_checkboolean(L, 4);
				bool arg4 = LuaDLL.luaL_checkboolean(L, 5);
				bool arg5 = LuaDLL.luaL_checkboolean(L, 6);
				string arg6 = ToLua.CheckString(L, 7);
				int arg7 = (int)LuaDLL.luaL_checknumber(L, 8);
				UnityEngine.TouchScreenKeyboard obj = new UnityEngine.TouchScreenKeyboard(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: UnityEngine.TouchScreenKeyboard.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Open(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				string arg0 = ToLua.CheckString(L, 1);
				UnityEngine.TouchScreenKeyboard o = UnityEngine.TouchScreenKeyboard.Open(arg0);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 2)
			{
				string arg0 = ToLua.CheckString(L, 1);
				UnityEngine.TouchScreenKeyboardType arg1 = (UnityEngine.TouchScreenKeyboardType)ToLua.CheckObject(L, 2, typeof(UnityEngine.TouchScreenKeyboardType));
				UnityEngine.TouchScreenKeyboard o = UnityEngine.TouchScreenKeyboard.Open(arg0, arg1);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 3)
			{
				string arg0 = ToLua.CheckString(L, 1);
				UnityEngine.TouchScreenKeyboardType arg1 = (UnityEngine.TouchScreenKeyboardType)ToLua.CheckObject(L, 2, typeof(UnityEngine.TouchScreenKeyboardType));
				bool arg2 = LuaDLL.luaL_checkboolean(L, 3);
				UnityEngine.TouchScreenKeyboard o = UnityEngine.TouchScreenKeyboard.Open(arg0, arg1, arg2);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 4)
			{
				string arg0 = ToLua.CheckString(L, 1);
				UnityEngine.TouchScreenKeyboardType arg1 = (UnityEngine.TouchScreenKeyboardType)ToLua.CheckObject(L, 2, typeof(UnityEngine.TouchScreenKeyboardType));
				bool arg2 = LuaDLL.luaL_checkboolean(L, 3);
				bool arg3 = LuaDLL.luaL_checkboolean(L, 4);
				UnityEngine.TouchScreenKeyboard o = UnityEngine.TouchScreenKeyboard.Open(arg0, arg1, arg2, arg3);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 5)
			{
				string arg0 = ToLua.CheckString(L, 1);
				UnityEngine.TouchScreenKeyboardType arg1 = (UnityEngine.TouchScreenKeyboardType)ToLua.CheckObject(L, 2, typeof(UnityEngine.TouchScreenKeyboardType));
				bool arg2 = LuaDLL.luaL_checkboolean(L, 3);
				bool arg3 = LuaDLL.luaL_checkboolean(L, 4);
				bool arg4 = LuaDLL.luaL_checkboolean(L, 5);
				UnityEngine.TouchScreenKeyboard o = UnityEngine.TouchScreenKeyboard.Open(arg0, arg1, arg2, arg3, arg4);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 6)
			{
				string arg0 = ToLua.CheckString(L, 1);
				UnityEngine.TouchScreenKeyboardType arg1 = (UnityEngine.TouchScreenKeyboardType)ToLua.CheckObject(L, 2, typeof(UnityEngine.TouchScreenKeyboardType));
				bool arg2 = LuaDLL.luaL_checkboolean(L, 3);
				bool arg3 = LuaDLL.luaL_checkboolean(L, 4);
				bool arg4 = LuaDLL.luaL_checkboolean(L, 5);
				bool arg5 = LuaDLL.luaL_checkboolean(L, 6);
				UnityEngine.TouchScreenKeyboard o = UnityEngine.TouchScreenKeyboard.Open(arg0, arg1, arg2, arg3, arg4, arg5);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 7)
			{
				string arg0 = ToLua.CheckString(L, 1);
				UnityEngine.TouchScreenKeyboardType arg1 = (UnityEngine.TouchScreenKeyboardType)ToLua.CheckObject(L, 2, typeof(UnityEngine.TouchScreenKeyboardType));
				bool arg2 = LuaDLL.luaL_checkboolean(L, 3);
				bool arg3 = LuaDLL.luaL_checkboolean(L, 4);
				bool arg4 = LuaDLL.luaL_checkboolean(L, 5);
				bool arg5 = LuaDLL.luaL_checkboolean(L, 6);
				string arg6 = ToLua.CheckString(L, 7);
				UnityEngine.TouchScreenKeyboard o = UnityEngine.TouchScreenKeyboard.Open(arg0, arg1, arg2, arg3, arg4, arg5, arg6);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 8)
			{
				string arg0 = ToLua.CheckString(L, 1);
				UnityEngine.TouchScreenKeyboardType arg1 = (UnityEngine.TouchScreenKeyboardType)ToLua.CheckObject(L, 2, typeof(UnityEngine.TouchScreenKeyboardType));
				bool arg2 = LuaDLL.luaL_checkboolean(L, 3);
				bool arg3 = LuaDLL.luaL_checkboolean(L, 4);
				bool arg4 = LuaDLL.luaL_checkboolean(L, 5);
				bool arg5 = LuaDLL.luaL_checkboolean(L, 6);
				string arg6 = ToLua.CheckString(L, 7);
				int arg7 = (int)LuaDLL.luaL_checknumber(L, 8);
				UnityEngine.TouchScreenKeyboard o = UnityEngine.TouchScreenKeyboard.Open(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
				ToLua.PushObject(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.TouchScreenKeyboard.Open");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isSupported(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, UnityEngine.TouchScreenKeyboard.isSupported);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isInPlaceEditingAllowed(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, UnityEngine.TouchScreenKeyboard.isInPlaceEditingAllowed);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_text(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.TouchScreenKeyboard obj = (UnityEngine.TouchScreenKeyboard)o;
			string ret = obj.text;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index text on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_hideInput(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, UnityEngine.TouchScreenKeyboard.hideInput);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_active(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.TouchScreenKeyboard obj = (UnityEngine.TouchScreenKeyboard)o;
			bool ret = obj.active;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index active on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_status(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.TouchScreenKeyboard obj = (UnityEngine.TouchScreenKeyboard)o;
			UnityEngine.TouchScreenKeyboard.Status ret = obj.status;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index status on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_characterLimit(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.TouchScreenKeyboard obj = (UnityEngine.TouchScreenKeyboard)o;
			int ret = obj.characterLimit;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index characterLimit on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_canGetSelection(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.TouchScreenKeyboard obj = (UnityEngine.TouchScreenKeyboard)o;
			bool ret = obj.canGetSelection;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index canGetSelection on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_canSetSelection(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.TouchScreenKeyboard obj = (UnityEngine.TouchScreenKeyboard)o;
			bool ret = obj.canSetSelection;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index canSetSelection on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_selection(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.TouchScreenKeyboard obj = (UnityEngine.TouchScreenKeyboard)o;
			UnityEngine.RangeInt ret = obj.selection;
			ToLua.PushValue(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index selection on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_type(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.TouchScreenKeyboard obj = (UnityEngine.TouchScreenKeyboard)o;
			UnityEngine.TouchScreenKeyboardType ret = obj.type;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index type on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_targetDisplay(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.TouchScreenKeyboard obj = (UnityEngine.TouchScreenKeyboard)o;
			int ret = obj.targetDisplay;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index targetDisplay on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_area(IntPtr L)
	{
		try
		{
			ToLua.PushValue(L, UnityEngine.TouchScreenKeyboard.area);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_visible(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, UnityEngine.TouchScreenKeyboard.visible);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_text(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.TouchScreenKeyboard obj = (UnityEngine.TouchScreenKeyboard)o;
			string arg0 = ToLua.CheckString(L, 2);
			obj.text = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index text on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_hideInput(IntPtr L)
	{
		try
		{
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			UnityEngine.TouchScreenKeyboard.hideInput = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_active(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.TouchScreenKeyboard obj = (UnityEngine.TouchScreenKeyboard)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.active = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index active on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_characterLimit(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.TouchScreenKeyboard obj = (UnityEngine.TouchScreenKeyboard)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.characterLimit = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index characterLimit on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_selection(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.TouchScreenKeyboard obj = (UnityEngine.TouchScreenKeyboard)o;
			UnityEngine.RangeInt arg0 = StackTraits<UnityEngine.RangeInt>.Check(L, 2);
			obj.selection = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index selection on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_targetDisplay(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.TouchScreenKeyboard obj = (UnityEngine.TouchScreenKeyboard)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.targetDisplay = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index targetDisplay on a nil value");
		}
	}
}
