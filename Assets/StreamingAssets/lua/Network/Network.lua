Network={}
Protocal={
    Connnect ='101', --连接服务器
    Exception ='102', --异常掉线
    Disconnnect ='103', --正常断线
    Message='104'   --接受信息
}

function Network.OnSocket(key,data)
    if key==101 then 
        LuaFramework.Util.Log('OnSocket Connect');
        send("好书")	
    elseif key ==102 then
        LuaFramework.Util.Log('OnSocket Exception');	
    elseif key==103 then
        LuaFramework.Util.Log('OnSocket Disconnect');	
    elseif key==104 then
        LuaFramework.Util.Log('OnSocket Message');	
        local str=data:ReadString();
        LuaFramework.Util.Log('收到的字符串：'..str)
    end
end

function send(data)
    local buffer=LuaFramework.ByteBuffer.New()
    buffer:WriteShort(Protocal.Message);
    buffer:WriteString(data)
    local LuaHelper= LuaFramework.LuaHelper
    local networkMgr=LuaHelper.GetNetManager()
    networkMgr:SendMessage(buffer)
    LuaFramework.Util.Log("数据发送完毕")
end