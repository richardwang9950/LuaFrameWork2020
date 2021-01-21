require "Common/define"
Player = {
	m_Movement = Vector3.zero,
	name="JohnLemon",
	m_Rotation = Quaternion.identity,
	m_animator =nil,
    turnSpeed=20,
	m_AudioSource=nil,
	m_rigidbody=nil,
}
	--里面可以放一些属性


 
function Player:Awake(gameObject)
	
end
 
function Player:Start(gameObject)
	self.m_rigidbody= gameObject:GetComponent('Rigidbody')
	self.m_animator=gameObject:GetComponent('Animator')
	self.m_AudioSource = gameObject:GetComponent("AudioSource");
   	GameObject.Find("Particle System"):GetComponent("ParticleSystem"):Play()
end
 
function Player:FixedUpdate(gameObject)
	local horizontal =Input.GetAxis("Horizontal");
	local vertical =Input.GetAxis("Vertical");
    self.m_Movement:Set(horizontal, 0, vertical);
	self.m_Movement:Normalize();
	local hasHorizontalInput = not Mathf.Approximately(horizontal, 0);
	local hasVerticalInput = not Mathf.Approximately(vertical, 0);
	local isWalking = hasHorizontalInput or hasVerticalInput;
	self.m_animator:SetBool("IsWalking", isWalking);
	if (isWalking) then
		if (not self.m_AudioSource.isPlaying) then
			self.m_AudioSource:Play();
		end
	else
		self.m_AudioSource:Stop();
	end

	local desiredForward = Vector3.RotateTowards(gameObject.transform.forward, self.m_Movement, self.turnSpeed * Time.deltaTime, 0);
	self.m_Rotation = Quaternion.LookRotation(desiredForward);
end
 
 
function Player:Update(gameObject)

end

function Player:OnAnimatorMove(gameObject)
	self.m_rigidbody:MovePosition(self.m_rigidbody.position+self.m_Movement*self.m_animator.deltaPosition.magnitude);
	self.m_rigidbody:MoveRotation(self.m_Rotation);
end



--创建对象
function Player:New(obj)
	local o = {} 
	setmetatable(o, self)  
    self.__index = self  
	return o
end 