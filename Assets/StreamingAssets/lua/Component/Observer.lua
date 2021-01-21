require "Common.define"
require "Component/GameEnd"
Observer={
    player=nil,
    gameEnding=nil,
    m_IsPlayerInRange=false,
    name= "Observer"
}

function Observer:Start(gameObject)
    self.player=GameObject.Find("Player").transform;
    local object=GameObject.Find("GameEnding")
       local s=GameEnd
    self.gameEnding=LuaComponent.Get(object ,GameEnd); 
end

function Observer:Update(gameObject)
    if(self.m_IsPlayerInRange)then 
        local direction= self.player.position-gameObject.transform.position+Vector3.up;
        local ray= Ray.New(gameObject.transform.position,direction)
        if (Physics.Raycast(ray)) then
          local isRay,raycastHit=Physics.Raycast(ray, nil)
            if (isRay) then 
                if (raycastHit.collider.transform == self.player) then
                    self.gameEnding:CaughtPlayer();
                end
            end
        end
    end
end


function Observer:OnTriggerEnter(other) 
    LuaFramework.Util.Log("Observer:OnTriggerEnter");
    if(other.transform==self.player) then 
        self.m_IsPlayerInRange=true;
    end
end

function Observer:OnTriggerExit(other) 
    if(other.transform==self.player) then 
        self.m_IsPlayerInRange=false;
    end
end

--创建对象
function Observer:New(obj)
	local o = {} 
	setmetatable(o, self)  
    self.__index = self  
	return o
end 