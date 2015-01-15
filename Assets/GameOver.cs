using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	public GUIText bScore;
	 public GUIText aScore;


	void Start () {
	
	}// Use this for initialization

	void Awake () {

		bScore.text = "High Score : " + PlayerPrefs.GetInt ("HighScore");
		aScore.text = "Your Score : " + PlayerPrefs.GetInt ("YourScore");

	}//Awake() uses PlayerPref functions to get the players score and the highest score

	void Update () 
	{
	
	}// Update is called once per frame
}
