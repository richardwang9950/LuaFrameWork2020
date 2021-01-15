--主入口函数。从这里开始lua逻辑
require "Component/TankCmp"
local go;
function Main()					
	--print("logic start")
	LuaFramework.Util.Log("HelloWorld");

	LuaHelper = LuaFramework.LuaHelper;
	resMgr = LuaHelper.GetResManager();
	--resMgr:LoadPrefab('tank', { 'tank' }, OnLoadFinish);
	resMgr:LoadPrefab('Panel', { 'Panel' }, OnLoadFinish);
	
end

--场景切换通知
function OnLevelWasLoaded(level)
	collectgarbage("collect")
	Time.timeSinceLevelLoad = 0
end

function OnApplicationQuit()
end

--加载完成后的回调--
function OnLoadFinish(objs)
	go = UnityEngine.GameObject.Instantiate(objs[0]);
	local parent = UnityEngine.GameObject.Find("Canvas")
    go.transform:SetParent(parent.transform);
	LuaFramework.Util.Log("Finish");
	--LuaComponent.Add(go,TankCmp)
	local btn = go.transform:FindChild("Button").gameObject
	UIEvent.AddButtonClick(btn, OnClick)
end



function OnClick()
	print("触发按钮事件")
end


--连接EmmyLua
function ConnectEmmyLua()
	local func = function()
		--UnityEngine.Application.dataPath绝对路径：
		--E:\hankangwen-LuaFramework-master\LuaFramework\LuaFramework\Assets
		--emmy_core.dll绝对路径：E:\hankangwen-LuaFramework-master\LuaFramework\Tools\Emmylua
		local assets = UnityEngine.Application.dataPath
		local assetDict = string.split(assets, "/")
		local path = ''
		for i = 1, #assetDict-2 do
			path = path .. assetDict[i] .. '/'
		end
		-- package.cpath = package.cpath .. ';' .. path .. 'Tools/Emmylua/emmy_core.dll'
		package.cpath ="C:/Users/Administrator/.vscode/extensions/tangzx.emmylua-0.3.49/debugger/emmy/windows/x64/emmy_core.dll"
		local dbg = require('emmy_core')
		dbg.tcpConnect('localhost', 9966)
	end
 
	local handle = function()
		print('IDE没有开启调试')
	end
 
	xpcall(func, handle)
end