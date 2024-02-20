#NoEnv
SendMode Input
SetWorkingDir %A_ScriptDir%

idleMinutes := 5
 
SetTimer, CheckIdleTime, 60000, 30000

lastInputTime := A_TickCount

CheckIdleTime:
    If(A_TimeIdlePhysical > idleMinutes )
    {
        Send, {Ctrl down}a(Ctrl up)
        Send, {Ctrl down}c(Ctrl up)

        lastInputTime = :A_TickCount
    }
    Return

#IfWinActive, ahk_class AutoHotkey
    LButton::
    lastInputTime := A_TickCount
Return

