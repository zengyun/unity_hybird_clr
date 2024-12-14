﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_EventSystems_PointerEventDataWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.EventSystems.PointerEventData), typeof(UnityEngine.EventSystems.BaseEventData),"PointerEventData");
		L.RegFunction("IsPointerMoving", IsPointerMoving);
		L.RegFunction("IsScrolling", IsScrolling);
		L.RegFunction("ToString", ToString);
		L.RegFunction("New", _CreateUnityEngine_EventSystems_PointerEventData);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("hovered", get_hovered, set_hovered);
		L.RegVar("pointerEnter", get_pointerEnter, set_pointerEnter);
		L.RegVar("lastPress", get_lastPress, null);
		L.RegVar("rawPointerPress", get_rawPointerPress, set_rawPointerPress);
		L.RegVar("pointerDrag", get_pointerDrag, set_pointerDrag);
		L.RegVar("pointerClick", get_pointerClick, set_pointerClick);
		L.RegVar("pointerCurrentRaycast", get_pointerCurrentRaycast, set_pointerCurrentRaycast);
		L.RegVar("pointerPressRaycast", get_pointerPressRaycast, set_pointerPressRaycast);
		L.RegVar("eligibleForClick", get_eligibleForClick, set_eligibleForClick);
		L.RegVar("displayIndex", get_displayIndex, set_displayIndex);
		L.RegVar("pointerId", get_pointerId, set_pointerId);
		L.RegVar("position", get_position, set_position);
		L.RegVar("delta", get_delta, set_delta);
		L.RegVar("pressPosition", get_pressPosition, set_pressPosition);
		L.RegVar("clickTime", get_clickTime, set_clickTime);
		L.RegVar("clickCount", get_clickCount, set_clickCount);
		L.RegVar("scrollDelta", get_scrollDelta, set_scrollDelta);
		L.RegVar("useDragThreshold", get_useDragThreshold, set_useDragThreshold);
		L.RegVar("dragging", get_dragging, set_dragging);
		L.RegVar("button", get_button, set_button);
		L.RegVar("pressure", get_pressure, set_pressure);
		L.RegVar("tangentialPressure", get_tangentialPressure, set_tangentialPressure);
		L.RegVar("altitudeAngle", get_altitudeAngle, set_altitudeAngle);
		L.RegVar("azimuthAngle", get_azimuthAngle, set_azimuthAngle);
		L.RegVar("twist", get_twist, set_twist);
		L.RegVar("tilt", get_tilt, set_tilt);
		L.RegVar("penStatus", get_penStatus, set_penStatus);
		L.RegVar("radius", get_radius, set_radius);
		L.RegVar("radiusVariance", get_radiusVariance, set_radiusVariance);
		L.RegVar("fullyExited", get_fullyExited, set_fullyExited);
		L.RegVar("reentered", get_reentered, set_reentered);
		L.RegVar("enterEventCamera", get_enterEventCamera, null);
		L.RegVar("pressEventCamera", get_pressEventCamera, null);
		L.RegVar("pointerPress", get_pointerPress, set_pointerPress);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUnityEngine_EventSystems_PointerEventData(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				UnityEngine.EventSystems.EventSystem arg0 = (UnityEngine.EventSystems.EventSystem)ToLua.CheckObject<UnityEngine.EventSystems.EventSystem>(L, 1);
				UnityEngine.EventSystems.PointerEventData obj = new UnityEngine.EventSystems.PointerEventData(arg0);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: UnityEngine.EventSystems.PointerEventData.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsPointerMoving(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.EventSystems.PointerEventData obj = (UnityEngine.EventSystems.PointerEventData)ToLua.CheckObject<UnityEngine.EventSystems.PointerEventData>(L, 1);
			bool o = obj.IsPointerMoving();
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsScrolling(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.EventSystems.PointerEventData obj = (UnityEngine.EventSystems.PointerEventData)ToLua.CheckObject<UnityEngine.EventSystems.PointerEventData>(L, 1);
			bool o = obj.IsScrolling();
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ToString(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.EventSystems.PointerEventData obj = (UnityEngine.EventSystems.PointerEventData)ToLua.CheckObject<UnityEngine.EventSystems.PointerEventData>(L, 1);
			string o = obj.ToString();
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_hovered(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.PointerEventData obj = (UnityEngine.EventSystems.PointerEventData)o;
			System.Collections.Generic.List<UnityEngine.GameObject> ret = obj.hovered;
			ToLua.PushSealed(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index hovered on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_pointerEnter(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.PointerEventData obj = (UnityEngine.EventSystems.PointerEventData)o;
			UnityEngine.GameObject ret = obj.pointerEnter;
			ToLua.PushSealed(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index pointerEnter on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_lastPress(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.PointerEventData obj = (UnityEngine.EventSystems.PointerEventData)o;
			UnityEngine.GameObject ret = obj.lastPress;
			ToLua.PushSealed(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index lastPress on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_rawPointerPress(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.PointerEventData obj = (UnityEngine.EventSystems.PointerEventData)o;
			UnityEngine.GameObject ret = obj.rawPointerPress;
			ToLua.PushSealed(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index rawPointerPress on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_pointerDrag(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.PointerEventData obj = (UnityEngine.EventSystems.PointerEventData)o;
			UnityEngine.GameObject ret = obj.pointerDrag;
			ToLua.PushSealed(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index pointerDrag on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_pointerClick(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.PointerEventData obj = (UnityEngine.EventSystems.PointerEventData)o;
			UnityEngine.GameObject ret = obj.pointerClick;
			ToLua.PushSealed(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index pointerClick on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_pointerCurrentRaycast(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.PointerEventData obj = (UnityEngine.EventSystems.PointerEventData)o;
			UnityEngine.EventSystems.RaycastResult ret = obj.pointerCurrentRaycast;
			ToLua.PushValue(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index pointerCurrentRaycast on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_pointerPressRaycast(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.PointerEventData obj = (UnityEngine.EventSystems.PointerEventData)o;
			UnityEngine.EventSystems.RaycastResult ret = obj.pointerPressRaycast;
			ToLua.PushValue(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index pointerPressRaycast on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_eligibleForClick(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.PointerEventData obj = (UnityEngine.EventSystems.PointerEventData)o;
			bool ret = obj.eligibleForClick;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index eligibleForClick on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_displayIndex(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.PointerEventData obj = (UnityEngine.EventSystems.PointerEventData)o;
			int ret = obj.displayIndex;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index displayIndex on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_pointerId(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.PointerEventData obj = (UnityEngine.EventSystems.PointerEventData)o;
			int ret = obj.pointerId;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index pointerId on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_position(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.PointerEventData obj = (UnityEngine.EventSystems.PointerEventData)o;
			UnityEngine.Vector2 ret = obj.position;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index position on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_delta(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.PointerEventData obj = (UnityEngine.EventSystems.PointerEventData)o;
			UnityEngine.Vector2 ret = obj.delta;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index delta on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_pressPosition(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.PointerEventData obj = (UnityEngine.EventSystems.PointerEventData)o;
			UnityEngine.Vector2 ret = obj.pressPosition;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index pressPosition on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_clickTime(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.PointerEventData obj = (UnityEngine.EventSystems.PointerEventData)o;
			float ret = obj.clickTime;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index clickTime on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_clickCount(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.PointerEventData obj = (UnityEngine.EventSystems.PointerEventData)o;
			int ret = obj.clickCount;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index clickCount on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_scrollDelta(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.PointerEventData obj = (UnityEngine.EventSystems.PointerEventData)o;
			UnityEngine.Vector2 ret = obj.scrollDelta;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index scrollDelta on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_useDragThreshold(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.PointerEventData obj = (UnityEngine.EventSystems.PointerEventData)o;
			bool ret = obj.useDragThreshold;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index useDragThreshold on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_dragging(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.PointerEventData obj = (UnityEngine.EventSystems.PointerEventData)o;
			bool ret = obj.dragging;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index dragging on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_button(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.PointerEventData obj = (UnityEngine.EventSystems.PointerEventData)o;
			UnityEngine.EventSystems.PointerEventData.InputButton ret = obj.button;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index button on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_pressure(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.PointerEventData obj = (UnityEngine.EventSystems.PointerEventData)o;
			float ret = obj.pressure;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index pressure on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_tangentialPressure(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.PointerEventData obj = (UnityEngine.EventSystems.PointerEventData)o;
			float ret = obj.tangentialPressure;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index tangentialPressure on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_altitudeAngle(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.PointerEventData obj = (UnityEngine.EventSystems.PointerEventData)o;
			float ret = obj.altitudeAngle;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index altitudeAngle on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_azimuthAngle(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.PointerEventData obj = (UnityEngine.EventSystems.PointerEventData)o;
			float ret = obj.azimuthAngle;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index azimuthAngle on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_twist(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.PointerEventData obj = (UnityEngine.EventSystems.PointerEventData)o;
			float ret = obj.twist;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index twist on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_tilt(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.PointerEventData obj = (UnityEngine.EventSystems.PointerEventData)o;
			UnityEngine.Vector2 ret = obj.tilt;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index tilt on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_penStatus(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.PointerEventData obj = (UnityEngine.EventSystems.PointerEventData)o;
			UnityEngine.PenStatus ret = obj.penStatus;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index penStatus on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_radius(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.PointerEventData obj = (UnityEngine.EventSystems.PointerEventData)o;
			UnityEngine.Vector2 ret = obj.radius;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index radius on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_radiusVariance(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.PointerEventData obj = (UnityEngine.EventSystems.PointerEventData)o;
			UnityEngine.Vector2 ret = obj.radiusVariance;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index radiusVariance on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_fullyExited(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.PointerEventData obj = (UnityEngine.EventSystems.PointerEventData)o;
			bool ret = obj.fullyExited;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index fullyExited on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_reentered(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.PointerEventData obj = (UnityEngine.EventSystems.PointerEventData)o;
			bool ret = obj.reentered;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index reentered on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_enterEventCamera(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.PointerEventData obj = (UnityEngine.EventSystems.PointerEventData)o;
			UnityEngine.Camera ret = obj.enterEventCamera;
			ToLua.PushSealed(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index enterEventCamera on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_pressEventCamera(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.PointerEventData obj = (UnityEngine.EventSystems.PointerEventData)o;
			UnityEngine.Camera ret = obj.pressEventCamera;
			ToLua.PushSealed(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index pressEventCamera on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_pointerPress(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.PointerEventData obj = (UnityEngine.EventSystems.PointerEventData)o;
			UnityEngine.GameObject ret = obj.pointerPress;
			ToLua.PushSealed(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index pointerPress on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_hovered(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.PointerEventData obj = (UnityEngine.EventSystems.PointerEventData)o;
			System.Collections.Generic.List<UnityEngine.GameObject> arg0 = (System.Collections.Generic.List<UnityEngine.GameObject>)ToLua.CheckObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.GameObject>));
			obj.hovered = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index hovered on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_pointerEnter(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.PointerEventData obj = (UnityEngine.EventSystems.PointerEventData)o;
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckObject(L, 2, typeof(UnityEngine.GameObject));
			obj.pointerEnter = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index pointerEnter on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_rawPointerPress(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.PointerEventData obj = (UnityEngine.EventSystems.PointerEventData)o;
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckObject(L, 2, typeof(UnityEngine.GameObject));
			obj.rawPointerPress = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index rawPointerPress on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_pointerDrag(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.PointerEventData obj = (UnityEngine.EventSystems.PointerEventData)o;
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckObject(L, 2, typeof(UnityEngine.GameObject));
			obj.pointerDrag = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index pointerDrag on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_pointerClick(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.PointerEventData obj = (UnityEngine.EventSystems.PointerEventData)o;
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckObject(L, 2, typeof(UnityEngine.GameObject));
			obj.pointerClick = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index pointerClick on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_pointerCurrentRaycast(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.PointerEventData obj = (UnityEngine.EventSystems.PointerEventData)o;
			UnityEngine.EventSystems.RaycastResult arg0 = StackTraits<UnityEngine.EventSystems.RaycastResult>.Check(L, 2);
			obj.pointerCurrentRaycast = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index pointerCurrentRaycast on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_pointerPressRaycast(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.PointerEventData obj = (UnityEngine.EventSystems.PointerEventData)o;
			UnityEngine.EventSystems.RaycastResult arg0 = StackTraits<UnityEngine.EventSystems.RaycastResult>.Check(L, 2);
			obj.pointerPressRaycast = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index pointerPressRaycast on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_eligibleForClick(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.PointerEventData obj = (UnityEngine.EventSystems.PointerEventData)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.eligibleForClick = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index eligibleForClick on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_displayIndex(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.PointerEventData obj = (UnityEngine.EventSystems.PointerEventData)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.displayIndex = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index displayIndex on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_pointerId(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.PointerEventData obj = (UnityEngine.EventSystems.PointerEventData)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.pointerId = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index pointerId on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_position(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.PointerEventData obj = (UnityEngine.EventSystems.PointerEventData)o;
			UnityEngine.Vector2 arg0 = ToLua.ToVector2(L, 2);
			obj.position = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index position on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_delta(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.PointerEventData obj = (UnityEngine.EventSystems.PointerEventData)o;
			UnityEngine.Vector2 arg0 = ToLua.ToVector2(L, 2);
			obj.delta = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index delta on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_pressPosition(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.PointerEventData obj = (UnityEngine.EventSystems.PointerEventData)o;
			UnityEngine.Vector2 arg0 = ToLua.ToVector2(L, 2);
			obj.pressPosition = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index pressPosition on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_clickTime(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.PointerEventData obj = (UnityEngine.EventSystems.PointerEventData)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.clickTime = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index clickTime on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_clickCount(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.PointerEventData obj = (UnityEngine.EventSystems.PointerEventData)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.clickCount = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index clickCount on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_scrollDelta(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.PointerEventData obj = (UnityEngine.EventSystems.PointerEventData)o;
			UnityEngine.Vector2 arg0 = ToLua.ToVector2(L, 2);
			obj.scrollDelta = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index scrollDelta on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_useDragThreshold(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.PointerEventData obj = (UnityEngine.EventSystems.PointerEventData)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.useDragThreshold = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index useDragThreshold on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_dragging(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.PointerEventData obj = (UnityEngine.EventSystems.PointerEventData)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.dragging = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index dragging on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_button(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.PointerEventData obj = (UnityEngine.EventSystems.PointerEventData)o;
			UnityEngine.EventSystems.PointerEventData.InputButton arg0 = (UnityEngine.EventSystems.PointerEventData.InputButton)ToLua.CheckObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData.InputButton));
			obj.button = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index button on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_pressure(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.PointerEventData obj = (UnityEngine.EventSystems.PointerEventData)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.pressure = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index pressure on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_tangentialPressure(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.PointerEventData obj = (UnityEngine.EventSystems.PointerEventData)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.tangentialPressure = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index tangentialPressure on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_altitudeAngle(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.PointerEventData obj = (UnityEngine.EventSystems.PointerEventData)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.altitudeAngle = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index altitudeAngle on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_azimuthAngle(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.PointerEventData obj = (UnityEngine.EventSystems.PointerEventData)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.azimuthAngle = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index azimuthAngle on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_twist(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.PointerEventData obj = (UnityEngine.EventSystems.PointerEventData)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.twist = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index twist on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_tilt(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.PointerEventData obj = (UnityEngine.EventSystems.PointerEventData)o;
			UnityEngine.Vector2 arg0 = ToLua.ToVector2(L, 2);
			obj.tilt = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index tilt on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_penStatus(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.PointerEventData obj = (UnityEngine.EventSystems.PointerEventData)o;
			UnityEngine.PenStatus arg0 = (UnityEngine.PenStatus)ToLua.CheckObject(L, 2, typeof(UnityEngine.PenStatus));
			obj.penStatus = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index penStatus on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_radius(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.PointerEventData obj = (UnityEngine.EventSystems.PointerEventData)o;
			UnityEngine.Vector2 arg0 = ToLua.ToVector2(L, 2);
			obj.radius = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index radius on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_radiusVariance(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.PointerEventData obj = (UnityEngine.EventSystems.PointerEventData)o;
			UnityEngine.Vector2 arg0 = ToLua.ToVector2(L, 2);
			obj.radiusVariance = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index radiusVariance on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_fullyExited(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.PointerEventData obj = (UnityEngine.EventSystems.PointerEventData)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.fullyExited = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index fullyExited on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_reentered(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.PointerEventData obj = (UnityEngine.EventSystems.PointerEventData)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.reentered = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index reentered on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_pointerPress(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.EventSystems.PointerEventData obj = (UnityEngine.EventSystems.PointerEventData)o;
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckObject(L, 2, typeof(UnityEngine.GameObject));
			obj.pointerPress = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index pointerPress on a nil value");
		}
	}
}

