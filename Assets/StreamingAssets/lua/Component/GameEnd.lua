require "Common.define"
GameEnd={
    fadeDuration= 1,
    displayImageDuration=1,
    player=nil,
    exitBackgroundImageCanvasGroup=nil,
    caughtBackgroundImageCanvasGroup=nil,
    m_IsPlayerAtExit=false,
    m_IsPlayerCaught=false,
    m_Timer=0,
    m_HasAudioPlayed=false,
    exitAudio=nil,
    caughtAudio=nil
}

function GameEnd:Start(gameObject) 
     self.player=GameObject.Find("Player")
     self.exitBackgroundImageCanvasGroup=GameObject.Find("ExitImageBackground"):GetComponent("CanvasGroup")
     self.caughtBackgroundImageCanvasGroup=GameObject.Find("CaughtImageBackground"):GetComponent("CanvasGroup")
     self.exitAudio = GameObject.Find("Caught"):GetComponent("AudioSource");
     self.caughtAudio = GameObject.Find("Escape"):GetComponent("AudioSource");
end

function GameEnd:OnTriggerEnter(other) 
    if(other.gameObject  ==self.player) then
        self.m_IsPlayerAtExit=true
    end
end


function GameEnd:Update(gameObject)
    if(self.m_IsPlayerAtExit) then
       self:EndLevel(self.exitBackgroundImageCanvasGroup,false,self.exitAudio)
    elseif (self.m_IsPlayerCaught) then
        self:EndLevel(self.caughtBackgroundImageCanvasGroup,true, self.caughtAudio)
    end
end


function GameEnd:EndLevel(imageCanvasGroup,doRestart,audioSource)
    if (not self.m_HasAudioPlayed)then
            audioSource:Play();
            self.m_HasAudioPlayed = true;
    end
    self.m_Timer=self.m_Timer+Time.deltaTime
    self.exitBackgroundImageCanvasGroup.alpha = self.m_Timer / self.fadeDuration;
    if(self.m_Timer > self.fadeDuration + self.displayImageDuration) then
        if (doRestart) then
                SceneManager.LoadScene(0);
        else 
                Application.Quit();
        end
    end
end

function GameEnd:CaughtPlayer()
    self.m_IsPlayerCaught = true;
end


--创建对象
function GameEnd:New(obj)
	local o = {} 
	setmetatable(o, self)  
    self.__index = self  
	return o
end 