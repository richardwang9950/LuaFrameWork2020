TankCmp = 
{
	--里面可以放一些属性
	Hp = 100,
	att = 50,
	name = "good tank",
}
 
function TankCmp:Awake(gameObject)
	print("TankCmp Awake name = "..self.name );
end
 
function TankCmp:Start(gameObject)
	print("TankCmp Start name = "..self.name );
end
 
function TankCmp:Update(gameObject)
	local Input= UnityEngine.Input;
	local horizontal =Input.GetAxis("Horizontal");
	local vertical =Input.GetAxis("Vertical");
	local x= gameObject.transform.position.x+horizontal;
	local z= gameObject.transform.position.z+vertical;
	gameObject.transform.position=Vector3.New(x,0,z);
end
 
--创建对象
function TankCmp:New(obj)
	local o = {} 
	setmetatable(o, self)  
    self.__index = self  
	return o
end 