/*
Necromancer GUI Demo Script
Author: Jason Wentzel
jc_wentzel@ironboundstudios.com

In this script you'll find some handy little functions for some of the 
Custom elements in the skin, these should help you create your own;

AddSpikes (not perfect but works well enough if you’re careful with your window widths)
FancyTop (just an example of using the elements to do a centered header graphic)
WaxSeal (adds the waxseal and ribbon to the right of the window)
DeathBadge (adds the iconFrame, skull, and ribbon elements properly aligned)

*/


var doWindow2 = true;


private var leafOffset;
private var frameOffset;
private var skullOffset;

private var RibbonOffsetX;
private var FrameOffsetX;
private var SkullOffsetX;
private var RibbonOffsetY;
private var FrameOffsetY;
private var SkullOffsetY;

private var WSwaxOffsetX;
private var WSwaxOffsetY;
private var WSribbonOffsetX;
private var WSribbonOffsetY;
	
private var spikeCount;

// This script will only work with the Necromancer skin
var mySkin : GUISkin;

//if you're using the spikes you'll need to find sizes that work well with them these are a few...

public var windowRect2 = Rect (4, 40, 306, 480);


private var scrollPosition : Vector2;
private var HroizSliderValue = 0.5;
private var VertSliderValue = 0.5;
private var ToggleBTN = false;

//skin info
private var NecroText ="'\n' '\n' RULES OF BRICK BREAKER  '\n' '\n' Aim of the Game is To Destroy all Bricks in sigh and collect the Powerups. Challenge friends to see who can get the Highest Score " ;


function AddSpikes(winX)
{
	spikeCount = Mathf.Floor(winX - 152)/22;
	GUILayout.BeginHorizontal();
	GUILayout.Label ("", "SpikeLeft");//-------------------------------- custom
	for (i = 0; i < spikeCount; i++)
        {
			GUILayout.Label ("", "SpikeMid");//-------------------------------- custom
        }
	GUILayout.Label ("", "SpikeRight");//-------------------------------- custom
	GUILayout.EndHorizontal();
}

function FancyTop(topX)
{
	leafOffset = (topX/2)-64;
	frameOffset = (topX/2)-27;
	skullOffset = (topX/2)-20;
	GUI.Label(new Rect(leafOffset, 18, 0, 0), "", "GoldLeaf");//-------------------------------- custom	
	GUI.Label(new Rect(frameOffset, 3, 0, 0), "", "IconFrame");//-------------------------------- custom	
	GUI.Label(new Rect(skullOffset, 12, 0, 0), "", "Skull");//-------------------------------- custom	
}

function WaxSeal(x,y)
{
	WSwaxOffsetX = x - 120;
	WSwaxOffsetY = y - 115;
	WSribbonOffsetX = x - 114;
	WSribbonOffsetY = y - 83;
	
	GUI.Label(new Rect(WSribbonOffsetX, WSribbonOffsetY, 0, 0), "", "RibbonBlue");//-------------------------------- custom	
	GUI.Label(new Rect(WSwaxOffsetX, WSwaxOffsetY, 0, 0), "", "WaxSeal");//-------------------------------- custom	
}

function DeathBadge(x,y)
{
	RibbonOffsetX = x;
	FrameOffsetX = x+3;
	SkullOffsetX = x+10;
	RibbonOffsetY = y+22;
	FrameOffsetY = y;
	SkullOffsetY = y+9;
	
	GUI.Label(new Rect(RibbonOffsetX, RibbonOffsetY, 0, 0), "", "RibbonRed");//-------------------------------- custom	
	GUI.Label(new Rect(FrameOffsetX, FrameOffsetY, 0, 0), "", "IconFrame");//-------------------------------- custom	
	GUI.Label(new Rect(SkullOffsetX, SkullOffsetY, 0, 0), "", "Skull");//-------------------------------- custom	
}

function DoMyWindow0 (windowID : int) 
{
	// use the spike function to add the spikes
	// note: were passing the width of the window to the function
		
		
		// Make the windows be draggable.
		GUI.DragWindow (Rect (0,0,10000,10000));
}



function DoMyWindow2 (windowID : int) 
{
		// use the spike function to add the spikes
		//AddSpikes(windowRect2.width);

		GUILayout.Space(8);
		GUILayout.BeginVertical();
		GUILayout.BeginHorizontal();
		scrollPosition = GUILayout.BeginScrollView(scrollPosition, true, true);
        GUILayout.Label (NecroText, "PlainText");
        GUILayout.EndScrollView();
		GUILayout.EndHorizontal();
		GUILayout.Space(8);
		
        GUILayout.EndVertical();
		// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
	if ( GUI.Button (Rect (190,250,150,50), "Return To Main Menu")) {
		Application.LoadLevel ("MainMenu");
	}
}




function OnGUI ()
{
GUI.skin = mySkin;


	
	
if (doWindow2)
	windowRect2 = GUI.Window (2, windowRect2, DoMyWindow2, "");
	//now adjust to the group. (0,0) is the topleft corner of the group.
	GUI.BeginGroup (Rect (0,0,100,100));
	// End the group we started above. This is very important to remember!
	GUI.EndGroup ();
	

}