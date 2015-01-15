using UnityEngine;
using System.Collections;

public class Rules : MonoBehaviour {

	public Texture BackgroundTexture;

	
	void Start () 
	{
	

		
	
	}// Use this for initialization


	void Update () 
	{
	
	}// Update is called once per frame



	void OnGUI ()
	{
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), BackgroundTexture);

	}//OnGUI() creates a background texture
	
}	