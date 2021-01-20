--[[
Auth:Chiuan
like Unity Brocast Event System in lua.
]]

local EventLib = require "eventlib"

local Event = {}
local events = {}

function Event.AddListener(event,handler)
	if not event or type(event) ~= "string" then
		error("event parameter in addlistener function has to be string, " .. type(event) .. " not right.")
	end
	if not handler or type(handler) ~= "function" then
		error("handler parameter in addlistener function has to be function, " .. type(handler) .. " not right")
	end

	if not events[event] then
		--create the Event with name
		events[event] = EventLib:new(event)
	end

	--conn this handler
	events[event]:connect(handler)
end

function Event.Brocast(event,...)
	if not events[event] then
		error("brocast " .. event .. " has no event.")
	else
		events[event]:fire(...)
	end
end

function Event.RemoveListener(event,handler)
	if not events[event] then
		error("remove " .. event .. " has no event.")
	else
		events[event]:disconnect(handler)
	end
end

return Event


UpdateBeat =event("Update",true)
LateUpdateBeat =event("LateUpdate",true)
FixedUpdateBeat =event("FixedUpdate",true)
CoUpdateBeat =event("CoUpdate",true)

local Time =Time
local UpdateBeat =UpdateBeat
local LateUpdateBeat=LateUpdateBeat
local FixedUpdateBeat=FixedUpdateBeat
local CoUpdateBeat=CoUpdateBeat

function Update(deltaTime,unscaleDeltaTime)
	Time:SetDeltaTime(deltaTime,unscaleDeltaTime)
	UpdateBeat()
end

function LateUpdate()
	LateUpdateBeat()
	CoUpdateBeat()
	Time:SetFrameCount()
end

function FixedUpdate(fixDalteTime)
	Time:SetFixedDelta(fixDalteTime)
	FixedUpdateBeat()
end