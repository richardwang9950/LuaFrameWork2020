
CtrlNames = {
	Prompt = "PromptCtrl",
	Message = "MessageCtrl"
}

PanelNames = {
	"PromptPanel",	
	"MessagePanel",
}

--协议类型--
ProtocalType = {
	BINARY = 0,
	PB_LUA = 1,
	PBC = 2,
	SPROTO = 3,
}
--当前使用的协议类型--
TestProtoType = ProtocalType.BINARY;

Util = LuaFramework.Util;
AppConst = LuaFramework.AppConst;
LuaHelper = LuaFramework.LuaHelper;
ByteBuffer = LuaFramework.ByteBuffer;

resMgr = LuaHelper.GetResManager();
panelMgr = LuaHelper.GetPanelManager();
soundMgr = LuaHelper.GetSoundManager();
networkMgr = LuaHelper.GetNetManager();

WWW = UnityEngine.WWW;
GameObject = UnityEngine.GameObject;
Input = UnityEngine.Input;
RigidBody = UnityEngine.Rigidbody;
Animator = UnityEngine.Animator;
Mathf = UnityEngine.Mathf;
Time = UnityEngine.Time;
Application = UnityEngine.Application;
Physics = UnityEngine.Physics;
Ray = UnityEngine.Ray;
Ray = UnityEngine.ParticleSystem;
NavMeshAgent=UnityEngine.AI.NavMeshAgent;
SceneManager=UnityEngine.SceneManagement.SceneManager