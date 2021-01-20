﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_AI_NavMeshAgentWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.AI.NavMeshAgent), typeof(UnityEngine.Behaviour));
		L.RegFunction("SetDestination", SetDestination);
		L.RegFunction("ActivateCurrentOffMeshLink", ActivateCurrentOffMeshLink);
		L.RegFunction("CompleteOffMeshLink", CompleteOffMeshLink);
		L.RegFunction("Warp", Warp);
		L.RegFunction("Move", Move);
		L.RegFunction("ResetPath", ResetPath);
		L.RegFunction("SetPath", SetPath);
		L.RegFunction("FindClosestEdge", FindClosestEdge);
		L.RegFunction("Raycast", Raycast);
		L.RegFunction("CalculatePath", CalculatePath);
		L.RegFunction("SamplePathPosition", SamplePathPosition);
		L.RegFunction("SetAreaCost", SetAreaCost);
		L.RegFunction("GetAreaCost", GetAreaCost);
		L.RegFunction("New", _CreateUnityEngine_AI_NavMeshAgent);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("destination", get_destination, set_destination);
		L.RegVar("stoppingDistance", get_stoppingDistance, set_stoppingDistance);
		L.RegVar("velocity", get_velocity, set_velocity);
		L.RegVar("nextPosition", get_nextPosition, set_nextPosition);
		L.RegVar("steeringTarget", get_steeringTarget, null);
		L.RegVar("desiredVelocity", get_desiredVelocity, null);
		L.RegVar("remainingDistance", get_remainingDistance, null);
		L.RegVar("baseOffset", get_baseOffset, set_baseOffset);
		L.RegVar("isOnOffMeshLink", get_isOnOffMeshLink, null);
		L.RegVar("currentOffMeshLinkData", get_currentOffMeshLinkData, null);
		L.RegVar("nextOffMeshLinkData", get_nextOffMeshLinkData, null);
		L.RegVar("autoTraverseOffMeshLink", get_autoTraverseOffMeshLink, set_autoTraverseOffMeshLink);
		L.RegVar("autoBraking", get_autoBraking, set_autoBraking);
		L.RegVar("autoRepath", get_autoRepath, set_autoRepath);
		L.RegVar("hasPath", get_hasPath, null);
		L.RegVar("pathPending", get_pathPending, null);
		L.RegVar("isPathStale", get_isPathStale, null);
		L.RegVar("pathStatus", get_pathStatus, null);
		L.RegVar("pathEndPosition", get_pathEndPosition, null);
		L.RegVar("isStopped", get_isStopped, set_isStopped);
		L.RegVar("path", get_path, set_path);
		L.RegVar("navMeshOwner", get_navMeshOwner, null);
		L.RegVar("agentTypeID", get_agentTypeID, set_agentTypeID);
		L.RegVar("areaMask", get_areaMask, set_areaMask);
		L.RegVar("speed", get_speed, set_speed);
		L.RegVar("angularSpeed", get_angularSpeed, set_angularSpeed);
		L.RegVar("acceleration", get_acceleration, set_acceleration);
		L.RegVar("updatePosition", get_updatePosition, set_updatePosition);
		L.RegVar("updateRotation", get_updateRotation, set_updateRotation);
		L.RegVar("updateUpAxis", get_updateUpAxis, set_updateUpAxis);
		L.RegVar("radius", get_radius, set_radius);
		L.RegVar("height", get_height, set_height);
		L.RegVar("obstacleAvoidanceType", get_obstacleAvoidanceType, set_obstacleAvoidanceType);
		L.RegVar("avoidancePriority", get_avoidancePriority, set_avoidancePriority);
		L.RegVar("isOnNavMesh", get_isOnNavMesh, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUnityEngine_AI_NavMeshAgent(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				UnityEngine.AI.NavMeshAgent obj = new UnityEngine.AI.NavMeshAgent();
				ToLua.PushSealed(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: UnityEngine.AI.NavMeshAgent.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetDestination(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.AI.NavMeshAgent obj = (UnityEngine.AI.NavMeshAgent)ToLua.CheckObject(L, 1, typeof(UnityEngine.AI.NavMeshAgent));
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			bool o = obj.SetDestination(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ActivateCurrentOffMeshLink(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.AI.NavMeshAgent obj = (UnityEngine.AI.NavMeshAgent)ToLua.CheckObject(L, 1, typeof(UnityEngine.AI.NavMeshAgent));
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.ActivateCurrentOffMeshLink(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CompleteOffMeshLink(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.AI.NavMeshAgent obj = (UnityEngine.AI.NavMeshAgent)ToLua.CheckObject(L, 1, typeof(UnityEngine.AI.NavMeshAgent));
			obj.CompleteOffMeshLink();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Warp(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.AI.NavMeshAgent obj = (UnityEngine.AI.NavMeshAgent)ToLua.CheckObject(L, 1, typeof(UnityEngine.AI.NavMeshAgent));
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			bool o = obj.Warp(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Move(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.AI.NavMeshAgent obj = (UnityEngine.AI.NavMeshAgent)ToLua.CheckObject(L, 1, typeof(UnityEngine.AI.NavMeshAgent));
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			obj.Move(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ResetPath(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.AI.NavMeshAgent obj = (UnityEngine.AI.NavMeshAgent)ToLua.CheckObject(L, 1, typeof(UnityEngine.AI.NavMeshAgent));
			obj.ResetPath();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetPath(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.AI.NavMeshAgent obj = (UnityEngine.AI.NavMeshAgent)ToLua.CheckObject(L, 1, typeof(UnityEngine.AI.NavMeshAgent));
			UnityEngine.AI.NavMeshPath arg0 = (UnityEngine.AI.NavMeshPath)ToLua.CheckObject(L, 2, typeof(UnityEngine.AI.NavMeshPath));
			bool o = obj.SetPath(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindClosestEdge(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.AI.NavMeshAgent obj = (UnityEngine.AI.NavMeshAgent)ToLua.CheckObject(L, 1, typeof(UnityEngine.AI.NavMeshAgent));
			UnityEngine.AI.NavMeshHit arg0;
			bool o = obj.FindClosestEdge(out arg0);
			LuaDLL.lua_pushboolean(L, o);
			ToLua.PushValue(L, arg0);
			return 2;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Raycast(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			UnityEngine.AI.NavMeshAgent obj = (UnityEngine.AI.NavMeshAgent)ToLua.CheckObject(L, 1, typeof(UnityEngine.AI.NavMeshAgent));
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			UnityEngine.AI.NavMeshHit arg1;
			bool o = obj.Raycast(arg0, out arg1);
			LuaDLL.lua_pushboolean(L, o);
			ToLua.PushValue(L, arg1);
			return 2;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CalculatePath(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			UnityEngine.AI.NavMeshAgent obj = (UnityEngine.AI.NavMeshAgent)ToLua.CheckObject(L, 1, typeof(UnityEngine.AI.NavMeshAgent));
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			UnityEngine.AI.NavMeshPath arg1 = (UnityEngine.AI.NavMeshPath)ToLua.CheckObject(L, 3, typeof(UnityEngine.AI.NavMeshPath));
			bool o = obj.CalculatePath(arg0, arg1);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SamplePathPosition(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 4);
			UnityEngine.AI.NavMeshAgent obj = (UnityEngine.AI.NavMeshAgent)ToLua.CheckObject(L, 1, typeof(UnityEngine.AI.NavMeshAgent));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
			UnityEngine.AI.NavMeshHit arg2;
			bool o = obj.SamplePathPosition(arg0, arg1, out arg2);
			LuaDLL.lua_pushboolean(L, o);
			ToLua.PushValue(L, arg2);
			return 2;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetAreaCost(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			UnityEngine.AI.NavMeshAgent obj = (UnityEngine.AI.NavMeshAgent)ToLua.CheckObject(L, 1, typeof(UnityEngine.AI.NavMeshAgent));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
			obj.SetAreaCost(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetAreaCost(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.AI.NavMeshAgent obj = (UnityEngine.AI.NavMeshAgent)ToLua.CheckObject(L, 1, typeof(UnityEngine.AI.NavMeshAgent));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			float o = obj.GetAreaCost(arg0);
			LuaDLL.lua_pushnumber(L, o);
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
	static int get_destination(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.AI.NavMeshAgent obj = (UnityEngine.AI.NavMeshAgent)o;
			UnityEngine.Vector3 ret = obj.destination;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index destination on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_stoppingDistance(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.AI.NavMeshAgent obj = (UnityEngine.AI.NavMeshAgent)o;
			float ret = obj.stoppingDistance;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index stoppingDistance on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_velocity(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.AI.NavMeshAgent obj = (UnityEngine.AI.NavMeshAgent)o;
			UnityEngine.Vector3 ret = obj.velocity;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index velocity on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_nextPosition(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.AI.NavMeshAgent obj = (UnityEngine.AI.NavMeshAgent)o;
			UnityEngine.Vector3 ret = obj.nextPosition;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index nextPosition on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_steeringTarget(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.AI.NavMeshAgent obj = (UnityEngine.AI.NavMeshAgent)o;
			UnityEngine.Vector3 ret = obj.steeringTarget;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index steeringTarget on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_desiredVelocity(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.AI.NavMeshAgent obj = (UnityEngine.AI.NavMeshAgent)o;
			UnityEngine.Vector3 ret = obj.desiredVelocity;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index desiredVelocity on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_remainingDistance(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.AI.NavMeshAgent obj = (UnityEngine.AI.NavMeshAgent)o;
			float ret = obj.remainingDistance;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index remainingDistance on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_baseOffset(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.AI.NavMeshAgent obj = (UnityEngine.AI.NavMeshAgent)o;
			float ret = obj.baseOffset;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index baseOffset on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isOnOffMeshLink(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.AI.NavMeshAgent obj = (UnityEngine.AI.NavMeshAgent)o;
			bool ret = obj.isOnOffMeshLink;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index isOnOffMeshLink on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_currentOffMeshLinkData(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.AI.NavMeshAgent obj = (UnityEngine.AI.NavMeshAgent)o;
			UnityEngine.AI.OffMeshLinkData ret = obj.currentOffMeshLinkData;
			ToLua.PushValue(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index currentOffMeshLinkData on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_nextOffMeshLinkData(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.AI.NavMeshAgent obj = (UnityEngine.AI.NavMeshAgent)o;
			UnityEngine.AI.OffMeshLinkData ret = obj.nextOffMeshLinkData;
			ToLua.PushValue(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index nextOffMeshLinkData on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_autoTraverseOffMeshLink(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.AI.NavMeshAgent obj = (UnityEngine.AI.NavMeshAgent)o;
			bool ret = obj.autoTraverseOffMeshLink;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index autoTraverseOffMeshLink on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_autoBraking(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.AI.NavMeshAgent obj = (UnityEngine.AI.NavMeshAgent)o;
			bool ret = obj.autoBraking;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index autoBraking on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_autoRepath(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.AI.NavMeshAgent obj = (UnityEngine.AI.NavMeshAgent)o;
			bool ret = obj.autoRepath;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index autoRepath on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_hasPath(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.AI.NavMeshAgent obj = (UnityEngine.AI.NavMeshAgent)o;
			bool ret = obj.hasPath;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index hasPath on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_pathPending(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.AI.NavMeshAgent obj = (UnityEngine.AI.NavMeshAgent)o;
			bool ret = obj.pathPending;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index pathPending on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isPathStale(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.AI.NavMeshAgent obj = (UnityEngine.AI.NavMeshAgent)o;
			bool ret = obj.isPathStale;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index isPathStale on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_pathStatus(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.AI.NavMeshAgent obj = (UnityEngine.AI.NavMeshAgent)o;
			UnityEngine.AI.NavMeshPathStatus ret = obj.pathStatus;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index pathStatus on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_pathEndPosition(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.AI.NavMeshAgent obj = (UnityEngine.AI.NavMeshAgent)o;
			UnityEngine.Vector3 ret = obj.pathEndPosition;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index pathEndPosition on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isStopped(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.AI.NavMeshAgent obj = (UnityEngine.AI.NavMeshAgent)o;
			bool ret = obj.isStopped;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index isStopped on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_path(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.AI.NavMeshAgent obj = (UnityEngine.AI.NavMeshAgent)o;
			UnityEngine.AI.NavMeshPath ret = obj.path;
			ToLua.PushSealed(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index path on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_navMeshOwner(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.AI.NavMeshAgent obj = (UnityEngine.AI.NavMeshAgent)o;
			UnityEngine.Object ret = obj.navMeshOwner;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index navMeshOwner on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_agentTypeID(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.AI.NavMeshAgent obj = (UnityEngine.AI.NavMeshAgent)o;
			int ret = obj.agentTypeID;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index agentTypeID on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_areaMask(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.AI.NavMeshAgent obj = (UnityEngine.AI.NavMeshAgent)o;
			int ret = obj.areaMask;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index areaMask on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_speed(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.AI.NavMeshAgent obj = (UnityEngine.AI.NavMeshAgent)o;
			float ret = obj.speed;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index speed on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_angularSpeed(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.AI.NavMeshAgent obj = (UnityEngine.AI.NavMeshAgent)o;
			float ret = obj.angularSpeed;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index angularSpeed on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_acceleration(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.AI.NavMeshAgent obj = (UnityEngine.AI.NavMeshAgent)o;
			float ret = obj.acceleration;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index acceleration on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_updatePosition(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.AI.NavMeshAgent obj = (UnityEngine.AI.NavMeshAgent)o;
			bool ret = obj.updatePosition;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index updatePosition on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_updateRotation(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.AI.NavMeshAgent obj = (UnityEngine.AI.NavMeshAgent)o;
			bool ret = obj.updateRotation;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index updateRotation on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_updateUpAxis(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.AI.NavMeshAgent obj = (UnityEngine.AI.NavMeshAgent)o;
			bool ret = obj.updateUpAxis;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index updateUpAxis on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_radius(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.AI.NavMeshAgent obj = (UnityEngine.AI.NavMeshAgent)o;
			float ret = obj.radius;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index radius on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_height(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.AI.NavMeshAgent obj = (UnityEngine.AI.NavMeshAgent)o;
			float ret = obj.height;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index height on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_obstacleAvoidanceType(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.AI.NavMeshAgent obj = (UnityEngine.AI.NavMeshAgent)o;
			UnityEngine.AI.ObstacleAvoidanceType ret = obj.obstacleAvoidanceType;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index obstacleAvoidanceType on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_avoidancePriority(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.AI.NavMeshAgent obj = (UnityEngine.AI.NavMeshAgent)o;
			int ret = obj.avoidancePriority;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index avoidancePriority on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isOnNavMesh(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.AI.NavMeshAgent obj = (UnityEngine.AI.NavMeshAgent)o;
			bool ret = obj.isOnNavMesh;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index isOnNavMesh on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_destination(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.AI.NavMeshAgent obj = (UnityEngine.AI.NavMeshAgent)o;
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			obj.destination = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index destination on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_stoppingDistance(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.AI.NavMeshAgent obj = (UnityEngine.AI.NavMeshAgent)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.stoppingDistance = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index stoppingDistance on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_velocity(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.AI.NavMeshAgent obj = (UnityEngine.AI.NavMeshAgent)o;
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			obj.velocity = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index velocity on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_nextPosition(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.AI.NavMeshAgent obj = (UnityEngine.AI.NavMeshAgent)o;
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			obj.nextPosition = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index nextPosition on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_baseOffset(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.AI.NavMeshAgent obj = (UnityEngine.AI.NavMeshAgent)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.baseOffset = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index baseOffset on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_autoTraverseOffMeshLink(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.AI.NavMeshAgent obj = (UnityEngine.AI.NavMeshAgent)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.autoTraverseOffMeshLink = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index autoTraverseOffMeshLink on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_autoBraking(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.AI.NavMeshAgent obj = (UnityEngine.AI.NavMeshAgent)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.autoBraking = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index autoBraking on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_autoRepath(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.AI.NavMeshAgent obj = (UnityEngine.AI.NavMeshAgent)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.autoRepath = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index autoRepath on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_isStopped(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.AI.NavMeshAgent obj = (UnityEngine.AI.NavMeshAgent)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.isStopped = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index isStopped on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_path(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.AI.NavMeshAgent obj = (UnityEngine.AI.NavMeshAgent)o;
			UnityEngine.AI.NavMeshPath arg0 = (UnityEngine.AI.NavMeshPath)ToLua.CheckObject(L, 2, typeof(UnityEngine.AI.NavMeshPath));
			obj.path = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index path on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_agentTypeID(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.AI.NavMeshAgent obj = (UnityEngine.AI.NavMeshAgent)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.agentTypeID = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index agentTypeID on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_areaMask(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.AI.NavMeshAgent obj = (UnityEngine.AI.NavMeshAgent)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.areaMask = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index areaMask on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_speed(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.AI.NavMeshAgent obj = (UnityEngine.AI.NavMeshAgent)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.speed = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index speed on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_angularSpeed(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.AI.NavMeshAgent obj = (UnityEngine.AI.NavMeshAgent)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.angularSpeed = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index angularSpeed on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_acceleration(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.AI.NavMeshAgent obj = (UnityEngine.AI.NavMeshAgent)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.acceleration = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index acceleration on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_updatePosition(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.AI.NavMeshAgent obj = (UnityEngine.AI.NavMeshAgent)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.updatePosition = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index updatePosition on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_updateRotation(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.AI.NavMeshAgent obj = (UnityEngine.AI.NavMeshAgent)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.updateRotation = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index updateRotation on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_updateUpAxis(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.AI.NavMeshAgent obj = (UnityEngine.AI.NavMeshAgent)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.updateUpAxis = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index updateUpAxis on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_radius(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.AI.NavMeshAgent obj = (UnityEngine.AI.NavMeshAgent)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.radius = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index radius on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_height(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.AI.NavMeshAgent obj = (UnityEngine.AI.NavMeshAgent)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.height = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index height on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_obstacleAvoidanceType(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.AI.NavMeshAgent obj = (UnityEngine.AI.NavMeshAgent)o;
			UnityEngine.AI.ObstacleAvoidanceType arg0 = (UnityEngine.AI.ObstacleAvoidanceType)ToLua.CheckObject(L, 2, typeof(UnityEngine.AI.ObstacleAvoidanceType));
			obj.obstacleAvoidanceType = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index obstacleAvoidanceType on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_avoidancePriority(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.AI.NavMeshAgent obj = (UnityEngine.AI.NavMeshAgent)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.avoidancePriority = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index avoidancePriority on a nil value");
		}
	}
}
