﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_QualitySettingsWrap
{
	public static void Register(LuaState L)
	{
		L.BeginStaticLibs("QualitySettings");
		L.RegFunction("IncreaseLevel", IncreaseLevel);
		L.RegFunction("DecreaseLevel", DecreaseLevel);
		L.RegFunction("SetQualityLevel", SetQualityLevel);
		L.RegFunction("ForEach", ForEach);
		L.RegFunction("SetLODSettings", SetLODSettings);
		L.RegFunction("SetTextureMipmapLimitSettings", SetTextureMipmapLimitSettings);
		L.RegFunction("GetTextureMipmapLimitSettings", GetTextureMipmapLimitSettings);
		L.RegFunction("GetRenderPipelineAssetAt", GetRenderPipelineAssetAt);
		L.RegFunction("GetQualityLevel", GetQualityLevel);
		L.RegFunction("GetQualitySettings", GetQualitySettings);
		L.RegFunction("__eq", op_Equality);
		L.RegVar("pixelLightCount", get_pixelLightCount, set_pixelLightCount);
		L.RegVar("shadows", get_shadows, set_shadows);
		L.RegVar("shadowProjection", get_shadowProjection, set_shadowProjection);
		L.RegVar("shadowCascades", get_shadowCascades, set_shadowCascades);
		L.RegVar("shadowDistance", get_shadowDistance, set_shadowDistance);
		L.RegVar("shadowResolution", get_shadowResolution, set_shadowResolution);
		L.RegVar("shadowmaskMode", get_shadowmaskMode, set_shadowmaskMode);
		L.RegVar("shadowNearPlaneOffset", get_shadowNearPlaneOffset, set_shadowNearPlaneOffset);
		L.RegVar("shadowCascade2Split", get_shadowCascade2Split, set_shadowCascade2Split);
		L.RegVar("shadowCascade4Split", get_shadowCascade4Split, set_shadowCascade4Split);
		L.RegVar("lodBias", get_lodBias, set_lodBias);
		L.RegVar("anisotropicFiltering", get_anisotropicFiltering, set_anisotropicFiltering);
		L.RegVar("globalTextureMipmapLimit", get_globalTextureMipmapLimit, set_globalTextureMipmapLimit);
		L.RegVar("maximumLODLevel", get_maximumLODLevel, set_maximumLODLevel);
		L.RegVar("enableLODCrossFade", get_enableLODCrossFade, set_enableLODCrossFade);
		L.RegVar("particleRaycastBudget", get_particleRaycastBudget, set_particleRaycastBudget);
		L.RegVar("softParticles", get_softParticles, set_softParticles);
		L.RegVar("softVegetation", get_softVegetation, set_softVegetation);
		L.RegVar("vSyncCount", get_vSyncCount, set_vSyncCount);
		L.RegVar("realtimeGICPUUsage", get_realtimeGICPUUsage, set_realtimeGICPUUsage);
		L.RegVar("antiAliasing", get_antiAliasing, set_antiAliasing);
		L.RegVar("asyncUploadTimeSlice", get_asyncUploadTimeSlice, set_asyncUploadTimeSlice);
		L.RegVar("asyncUploadBufferSize", get_asyncUploadBufferSize, set_asyncUploadBufferSize);
		L.RegVar("asyncUploadPersistentBuffer", get_asyncUploadPersistentBuffer, set_asyncUploadPersistentBuffer);
		L.RegVar("realtimeReflectionProbes", get_realtimeReflectionProbes, set_realtimeReflectionProbes);
		L.RegVar("billboardsFaceCameraPosition", get_billboardsFaceCameraPosition, set_billboardsFaceCameraPosition);
		L.RegVar("useLegacyDetailDistribution", get_useLegacyDetailDistribution, set_useLegacyDetailDistribution);
		L.RegVar("resolutionScalingFixedDPIFactor", get_resolutionScalingFixedDPIFactor, set_resolutionScalingFixedDPIFactor);
		L.RegVar("terrainQualityOverrides", get_terrainQualityOverrides, set_terrainQualityOverrides);
		L.RegVar("terrainPixelError", get_terrainPixelError, set_terrainPixelError);
		L.RegVar("terrainDetailDensityScale", get_terrainDetailDensityScale, set_terrainDetailDensityScale);
		L.RegVar("terrainBasemapDistance", get_terrainBasemapDistance, set_terrainBasemapDistance);
		L.RegVar("terrainDetailDistance", get_terrainDetailDistance, set_terrainDetailDistance);
		L.RegVar("terrainTreeDistance", get_terrainTreeDistance, set_terrainTreeDistance);
		L.RegVar("terrainBillboardStart", get_terrainBillboardStart, set_terrainBillboardStart);
		L.RegVar("terrainFadeLength", get_terrainFadeLength, set_terrainFadeLength);
		L.RegVar("terrainMaxTrees", get_terrainMaxTrees, set_terrainMaxTrees);
		L.RegVar("renderPipeline", get_renderPipeline, set_renderPipeline);
		L.RegVar("skinWeights", get_skinWeights, set_skinWeights);
		L.RegVar("count", get_count, null);
		L.RegVar("streamingMipmapsActive", get_streamingMipmapsActive, set_streamingMipmapsActive);
		L.RegVar("streamingMipmapsMemoryBudget", get_streamingMipmapsMemoryBudget, set_streamingMipmapsMemoryBudget);
		L.RegVar("streamingMipmapsAddAllCameras", get_streamingMipmapsAddAllCameras, set_streamingMipmapsAddAllCameras);
		L.RegVar("streamingMipmapsMaxFileIORequests", get_streamingMipmapsMaxFileIORequests, set_streamingMipmapsMaxFileIORequests);
		L.RegVar("maxQueuedFrames", get_maxQueuedFrames, set_maxQueuedFrames);
		L.RegVar("names", get_names, null);
		L.RegVar("desiredColorSpace", get_desiredColorSpace, null);
		L.RegVar("activeColorSpace", get_activeColorSpace, null);
		L.RegVar("activeQualityLevelChanged", get_activeQualityLevelChanged, set_activeQualityLevelChanged);
		L.EndStaticLibs();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IncreaseLevel(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				UnityEngine.QualitySettings.IncreaseLevel();
				return 0;
			}
			else if (count == 1)
			{
				bool arg0 = LuaDLL.luaL_checkboolean(L, 1);
				UnityEngine.QualitySettings.IncreaseLevel(arg0);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.QualitySettings.IncreaseLevel");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DecreaseLevel(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				UnityEngine.QualitySettings.DecreaseLevel();
				return 0;
			}
			else if (count == 1)
			{
				bool arg0 = LuaDLL.luaL_checkboolean(L, 1);
				UnityEngine.QualitySettings.DecreaseLevel(arg0);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.QualitySettings.DecreaseLevel");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetQualityLevel(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
				UnityEngine.QualitySettings.SetQualityLevel(arg0);
				return 0;
			}
			else if (count == 2)
			{
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
				bool arg1 = LuaDLL.luaL_checkboolean(L, 2);
				UnityEngine.QualitySettings.SetQualityLevel(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.QualitySettings.SetQualityLevel");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ForEach(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1 && TypeChecker.CheckTypes<System.Action>(L, 1))
			{
				System.Action arg0 = (System.Action)ToLua.ToObject(L, 1);
				UnityEngine.QualitySettings.ForEach(arg0);
				return 0;
			}
			else if (count == 1 && TypeChecker.CheckTypes<System.Action<int,string>>(L, 1))
			{
				System.Action<int,string> arg0 = (System.Action<int,string>)ToLua.ToObject(L, 1);
				UnityEngine.QualitySettings.ForEach(arg0);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.QualitySettings.ForEach");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetLODSettings(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				float arg0 = (float)LuaDLL.luaL_checknumber(L, 1);
				int arg1 = (int)LuaDLL.luaL_checknumber(L, 2);
				UnityEngine.QualitySettings.SetLODSettings(arg0, arg1);
				return 0;
			}
			else if (count == 3)
			{
				float arg0 = (float)LuaDLL.luaL_checknumber(L, 1);
				int arg1 = (int)LuaDLL.luaL_checknumber(L, 2);
				bool arg2 = LuaDLL.luaL_checkboolean(L, 3);
				UnityEngine.QualitySettings.SetLODSettings(arg0, arg1, arg2);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.QualitySettings.SetLODSettings");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetTextureMipmapLimitSettings(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			string arg0 = ToLua.CheckString(L, 1);
			UnityEngine.TextureMipmapLimitSettings arg1 = StackTraits<UnityEngine.TextureMipmapLimitSettings>.Check(L, 2);
			UnityEngine.QualitySettings.SetTextureMipmapLimitSettings(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetTextureMipmapLimitSettings(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			UnityEngine.TextureMipmapLimitSettings o = UnityEngine.QualitySettings.GetTextureMipmapLimitSettings(arg0);
			ToLua.PushValue(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRenderPipelineAssetAt(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
			UnityEngine.Rendering.RenderPipelineAsset o = UnityEngine.QualitySettings.GetRenderPipelineAssetAt(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetQualityLevel(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			int o = UnityEngine.QualitySettings.GetQualityLevel();
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetQualitySettings(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			UnityEngine.Object o = UnityEngine.QualitySettings.GetQualitySettings();
			ToLua.Push(L, o);
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
	static int get_pixelLightCount(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, UnityEngine.QualitySettings.pixelLightCount);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_shadows(IntPtr L)
	{
		try
		{
			ToLua.Push(L, UnityEngine.QualitySettings.shadows);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_shadowProjection(IntPtr L)
	{
		try
		{
			ToLua.Push(L, UnityEngine.QualitySettings.shadowProjection);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_shadowCascades(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, UnityEngine.QualitySettings.shadowCascades);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_shadowDistance(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushnumber(L, UnityEngine.QualitySettings.shadowDistance);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_shadowResolution(IntPtr L)
	{
		try
		{
			ToLua.Push(L, UnityEngine.QualitySettings.shadowResolution);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_shadowmaskMode(IntPtr L)
	{
		try
		{
			ToLua.Push(L, UnityEngine.QualitySettings.shadowmaskMode);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_shadowNearPlaneOffset(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushnumber(L, UnityEngine.QualitySettings.shadowNearPlaneOffset);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_shadowCascade2Split(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushnumber(L, UnityEngine.QualitySettings.shadowCascade2Split);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_shadowCascade4Split(IntPtr L)
	{
		try
		{
			ToLua.Push(L, UnityEngine.QualitySettings.shadowCascade4Split);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_lodBias(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushnumber(L, UnityEngine.QualitySettings.lodBias);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_anisotropicFiltering(IntPtr L)
	{
		try
		{
			ToLua.Push(L, UnityEngine.QualitySettings.anisotropicFiltering);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_globalTextureMipmapLimit(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, UnityEngine.QualitySettings.globalTextureMipmapLimit);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_maximumLODLevel(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, UnityEngine.QualitySettings.maximumLODLevel);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_enableLODCrossFade(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, UnityEngine.QualitySettings.enableLODCrossFade);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_particleRaycastBudget(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, UnityEngine.QualitySettings.particleRaycastBudget);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_softParticles(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, UnityEngine.QualitySettings.softParticles);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_softVegetation(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, UnityEngine.QualitySettings.softVegetation);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_vSyncCount(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, UnityEngine.QualitySettings.vSyncCount);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_realtimeGICPUUsage(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, UnityEngine.QualitySettings.realtimeGICPUUsage);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_antiAliasing(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, UnityEngine.QualitySettings.antiAliasing);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_asyncUploadTimeSlice(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, UnityEngine.QualitySettings.asyncUploadTimeSlice);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_asyncUploadBufferSize(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, UnityEngine.QualitySettings.asyncUploadBufferSize);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_asyncUploadPersistentBuffer(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, UnityEngine.QualitySettings.asyncUploadPersistentBuffer);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_realtimeReflectionProbes(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, UnityEngine.QualitySettings.realtimeReflectionProbes);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_billboardsFaceCameraPosition(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, UnityEngine.QualitySettings.billboardsFaceCameraPosition);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_useLegacyDetailDistribution(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, UnityEngine.QualitySettings.useLegacyDetailDistribution);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_resolutionScalingFixedDPIFactor(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushnumber(L, UnityEngine.QualitySettings.resolutionScalingFixedDPIFactor);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_terrainQualityOverrides(IntPtr L)
	{
		try
		{
			ToLua.Push(L, UnityEngine.QualitySettings.terrainQualityOverrides);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_terrainPixelError(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushnumber(L, UnityEngine.QualitySettings.terrainPixelError);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_terrainDetailDensityScale(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushnumber(L, UnityEngine.QualitySettings.terrainDetailDensityScale);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_terrainBasemapDistance(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushnumber(L, UnityEngine.QualitySettings.terrainBasemapDistance);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_terrainDetailDistance(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushnumber(L, UnityEngine.QualitySettings.terrainDetailDistance);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_terrainTreeDistance(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushnumber(L, UnityEngine.QualitySettings.terrainTreeDistance);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_terrainBillboardStart(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushnumber(L, UnityEngine.QualitySettings.terrainBillboardStart);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_terrainFadeLength(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushnumber(L, UnityEngine.QualitySettings.terrainFadeLength);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_terrainMaxTrees(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushnumber(L, UnityEngine.QualitySettings.terrainMaxTrees);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_renderPipeline(IntPtr L)
	{
		try
		{
			ToLua.Push(L, UnityEngine.QualitySettings.renderPipeline);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_skinWeights(IntPtr L)
	{
		try
		{
			ToLua.Push(L, UnityEngine.QualitySettings.skinWeights);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_count(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, UnityEngine.QualitySettings.count);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_streamingMipmapsActive(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, UnityEngine.QualitySettings.streamingMipmapsActive);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_streamingMipmapsMemoryBudget(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushnumber(L, UnityEngine.QualitySettings.streamingMipmapsMemoryBudget);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_streamingMipmapsAddAllCameras(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, UnityEngine.QualitySettings.streamingMipmapsAddAllCameras);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_streamingMipmapsMaxFileIORequests(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, UnityEngine.QualitySettings.streamingMipmapsMaxFileIORequests);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_maxQueuedFrames(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, UnityEngine.QualitySettings.maxQueuedFrames);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_names(IntPtr L)
	{
		try
		{
			ToLua.Push(L, UnityEngine.QualitySettings.names);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_desiredColorSpace(IntPtr L)
	{
		try
		{
			ToLua.Push(L, UnityEngine.QualitySettings.desiredColorSpace);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_activeColorSpace(IntPtr L)
	{
		try
		{
			ToLua.Push(L, UnityEngine.QualitySettings.activeColorSpace);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_activeQualityLevelChanged(IntPtr L)
	{
		ToLua.Push(L, new EventObject(typeof(System.Action<int,int>)));
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_pixelLightCount(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.QualitySettings.pixelLightCount = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_shadows(IntPtr L)
	{
		try
		{
			UnityEngine.ShadowQuality arg0 = (UnityEngine.ShadowQuality)ToLua.CheckObject(L, 2, typeof(UnityEngine.ShadowQuality));
			UnityEngine.QualitySettings.shadows = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_shadowProjection(IntPtr L)
	{
		try
		{
			UnityEngine.ShadowProjection arg0 = (UnityEngine.ShadowProjection)ToLua.CheckObject(L, 2, typeof(UnityEngine.ShadowProjection));
			UnityEngine.QualitySettings.shadowProjection = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_shadowCascades(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.QualitySettings.shadowCascades = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_shadowDistance(IntPtr L)
	{
		try
		{
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.QualitySettings.shadowDistance = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_shadowResolution(IntPtr L)
	{
		try
		{
			UnityEngine.ShadowResolution arg0 = (UnityEngine.ShadowResolution)ToLua.CheckObject(L, 2, typeof(UnityEngine.ShadowResolution));
			UnityEngine.QualitySettings.shadowResolution = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_shadowmaskMode(IntPtr L)
	{
		try
		{
			UnityEngine.ShadowmaskMode arg0 = (UnityEngine.ShadowmaskMode)ToLua.CheckObject(L, 2, typeof(UnityEngine.ShadowmaskMode));
			UnityEngine.QualitySettings.shadowmaskMode = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_shadowNearPlaneOffset(IntPtr L)
	{
		try
		{
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.QualitySettings.shadowNearPlaneOffset = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_shadowCascade2Split(IntPtr L)
	{
		try
		{
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.QualitySettings.shadowCascade2Split = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_shadowCascade4Split(IntPtr L)
	{
		try
		{
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			UnityEngine.QualitySettings.shadowCascade4Split = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_lodBias(IntPtr L)
	{
		try
		{
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.QualitySettings.lodBias = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_anisotropicFiltering(IntPtr L)
	{
		try
		{
			UnityEngine.AnisotropicFiltering arg0 = (UnityEngine.AnisotropicFiltering)ToLua.CheckObject(L, 2, typeof(UnityEngine.AnisotropicFiltering));
			UnityEngine.QualitySettings.anisotropicFiltering = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_globalTextureMipmapLimit(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.QualitySettings.globalTextureMipmapLimit = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_maximumLODLevel(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.QualitySettings.maximumLODLevel = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_enableLODCrossFade(IntPtr L)
	{
		try
		{
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			UnityEngine.QualitySettings.enableLODCrossFade = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_particleRaycastBudget(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.QualitySettings.particleRaycastBudget = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_softParticles(IntPtr L)
	{
		try
		{
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			UnityEngine.QualitySettings.softParticles = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_softVegetation(IntPtr L)
	{
		try
		{
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			UnityEngine.QualitySettings.softVegetation = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_vSyncCount(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.QualitySettings.vSyncCount = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_realtimeGICPUUsage(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.QualitySettings.realtimeGICPUUsage = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_antiAliasing(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.QualitySettings.antiAliasing = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_asyncUploadTimeSlice(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.QualitySettings.asyncUploadTimeSlice = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_asyncUploadBufferSize(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.QualitySettings.asyncUploadBufferSize = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_asyncUploadPersistentBuffer(IntPtr L)
	{
		try
		{
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			UnityEngine.QualitySettings.asyncUploadPersistentBuffer = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_realtimeReflectionProbes(IntPtr L)
	{
		try
		{
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			UnityEngine.QualitySettings.realtimeReflectionProbes = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_billboardsFaceCameraPosition(IntPtr L)
	{
		try
		{
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			UnityEngine.QualitySettings.billboardsFaceCameraPosition = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_useLegacyDetailDistribution(IntPtr L)
	{
		try
		{
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			UnityEngine.QualitySettings.useLegacyDetailDistribution = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_resolutionScalingFixedDPIFactor(IntPtr L)
	{
		try
		{
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.QualitySettings.resolutionScalingFixedDPIFactor = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_terrainQualityOverrides(IntPtr L)
	{
		try
		{
			UnityEngine.TerrainQualityOverrides arg0 = (UnityEngine.TerrainQualityOverrides)ToLua.CheckObject(L, 2, typeof(UnityEngine.TerrainQualityOverrides));
			UnityEngine.QualitySettings.terrainQualityOverrides = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_terrainPixelError(IntPtr L)
	{
		try
		{
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.QualitySettings.terrainPixelError = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_terrainDetailDensityScale(IntPtr L)
	{
		try
		{
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.QualitySettings.terrainDetailDensityScale = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_terrainBasemapDistance(IntPtr L)
	{
		try
		{
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.QualitySettings.terrainBasemapDistance = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_terrainDetailDistance(IntPtr L)
	{
		try
		{
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.QualitySettings.terrainDetailDistance = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_terrainTreeDistance(IntPtr L)
	{
		try
		{
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.QualitySettings.terrainTreeDistance = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_terrainBillboardStart(IntPtr L)
	{
		try
		{
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.QualitySettings.terrainBillboardStart = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_terrainFadeLength(IntPtr L)
	{
		try
		{
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.QualitySettings.terrainFadeLength = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_terrainMaxTrees(IntPtr L)
	{
		try
		{
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.QualitySettings.terrainMaxTrees = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_renderPipeline(IntPtr L)
	{
		try
		{
			UnityEngine.Rendering.RenderPipelineAsset arg0 = (UnityEngine.Rendering.RenderPipelineAsset)ToLua.CheckObject<UnityEngine.Rendering.RenderPipelineAsset>(L, 2);
			UnityEngine.QualitySettings.renderPipeline = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_skinWeights(IntPtr L)
	{
		try
		{
			UnityEngine.SkinWeights arg0 = (UnityEngine.SkinWeights)ToLua.CheckObject(L, 2, typeof(UnityEngine.SkinWeights));
			UnityEngine.QualitySettings.skinWeights = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_streamingMipmapsActive(IntPtr L)
	{
		try
		{
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			UnityEngine.QualitySettings.streamingMipmapsActive = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_streamingMipmapsMemoryBudget(IntPtr L)
	{
		try
		{
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.QualitySettings.streamingMipmapsMemoryBudget = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_streamingMipmapsAddAllCameras(IntPtr L)
	{
		try
		{
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			UnityEngine.QualitySettings.streamingMipmapsAddAllCameras = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_streamingMipmapsMaxFileIORequests(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.QualitySettings.streamingMipmapsMaxFileIORequests = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_maxQueuedFrames(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.QualitySettings.maxQueuedFrames = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_activeQualityLevelChanged(IntPtr L)
	{
		try
		{
			EventObject arg0 = null;

			if (LuaDLL.lua_isuserdata(L, 2) != 0)
			{
				arg0 = (EventObject)ToLua.ToObject(L, 2);
			}
			else
			{
				return LuaDLL.luaL_throw(L, "The event 'UnityEngine.QualitySettings.activeQualityLevelChanged' can only appear on the left hand side of += or -= when used outside of the type 'UnityEngine.QualitySettings'");
			}

			if (arg0.op == EventOp.Add)
			{
				System.Action<int,int> ev = (System.Action<int,int>)arg0.func;
				UnityEngine.QualitySettings.activeQualityLevelChanged += ev;
			}
			else if (arg0.op == EventOp.Sub)
			{
				System.Action<int,int> ev = (System.Action<int,int>)arg0.func;
				UnityEngine.QualitySettings.activeQualityLevelChanged -= ev;
			}

			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

