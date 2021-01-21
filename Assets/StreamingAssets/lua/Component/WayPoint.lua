require "Common.define"
require "Common.functions"
require "Component.Observer"
WayPoint={
    navMeshAgent=nil,
    waypoints={},
    m_CurrentWaypointIndex=1
}
function WayPoint:Start(gameObject)
    self.navMeshAgent=gameObject:GetComponent("NavMeshAgent");
    self.navMeshAgent:SetDestination(self.waypoints[1].position);
    local observer= gameObject.transform:Find("PointOfView").gameObject;
    LuaComponent.Add(observer,Observer);
end

function  WayPoint:Update(gameObject)
    if (self.navMeshAgent.remainingDistance < self.navMeshAgent.stoppingDistance) then
        local length=getArrLength(self.waypoints)
        self.m_CurrentWaypointIndex = math.fmod((self.m_CurrentWaypointIndex + 1),length ) 

        self.navMeshAgent:SetDestination(self.waypoints[self.m_CurrentWaypointIndex+1].position);
    end
end

function WayPoint:addPoint(point)
    -- if( type(self.waypoints)=="table")then
    --     self.waypoints={}
    -- end

    if (self.waypoints) then
       local count= getArrLength(self.waypoints)
       self.waypoints[count+1]=point
    end
end



function WayPoint:New(obj)
    local o = {} 
    setmetatable(o, self)  
    self.__index = self  
    --为新的对象的属性数组拷贝属性原表
    local i = {} 
    setmetatable(i, o.waypoints)
    o.waypoints.__index = o.waypoints  
    o.waypoints=i

	return o
end