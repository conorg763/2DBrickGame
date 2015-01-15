using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	public Texture backgroundTexture;

	 int Reset=0;

	// Use this for initialization
	void OnGUI() {
		//Display background texture
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), backgroundTexture);

		//Displays our buttons

		if (GUI.Button (new Rect (Screen.width * .375f, Screen.height * .35f, Screen.width * .25f, Screen.height * .1f), "Play Game")) {


			Application.LoadLevel ("Level1");

				}//Play

		if (GUI.Button (new Rect (Screen.width * .375f, Screen.height * .50f, Screen.width * .25f, Screen.height * .1f), "LeaderBoard")) 
		{

		}//LeaderBoard

		if (GUI.Button (new Rect (Screen.width * .375f, Screen.height * .65f, Screen.width * .25f, Screen.height * .1f), "Rules")) {
			
			Application.LoadLevel ("rules");
			
		}//rules

		if (GUI.Button (new Rect (Screen.width * .375f, Screen.height * .80f, Screen.width * .25f, Screen.height * .1f), "Quit")) {


				}//Quit


	
}
}