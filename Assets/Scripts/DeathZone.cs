using UnityEngine;
using System.Collections;

public class DeathZone : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
	
	}//Start()
	

	void Update () 
	{
	
	}// Update() is called once per frame


	void OnTriggerEnter(Collider other) 
	{

		SimplyBall ballScript = other.GetComponent<SimplyBall> ();

		if(ballScript){

			ballScript.Die();

		}//if
	}//OnTriggerEnter() This detects when the ball hits the deathzone and the ball then dies.
}