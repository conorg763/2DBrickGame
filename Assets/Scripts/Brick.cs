using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	static int numBricks = 0;
	public int PointValue=1;
	public int hitPoints=1;
	public int powerUpChance = 3;
	public GameObject[] powerUpPrefabs;
	// Use this for initialization

	void Start () 
	{	
		numBricks++;
	}//Start() increments numBricks variable each time



	void Update ()
	{
	
	}// Update() is called once per frame
	 

	void OnCollisionEnter (Collision col) 
	{  //Detects a collision



		hitPoints--;
		if (hitPoints <= 0) {

						Die ();
				}
		
	}//OnCollisionEnter () detects a collision when the brick is hit by the ball and the brick is destroyed


	 void Die()
	{

		Destroy (gameObject); //destroys brick
		GameObject.Find ("Paddle").GetComponent<Paddle> ().AddPoint(PointValue);
		numBricks--;
	if ( Random.Range(0, powerUpChance) == 0 ) {
		Instantiate( powerUpPrefabs[ Random.Range(0, powerUpPrefabs.Length) ] , transform.position, Quaternion.identity );
	}//if

		if (numBricks <= 0) 
		{
			Application.LoadLevel("Level2");				//load a new level
		}//if
	}//Die() Destroys the brick and adds a point to the score.  A powerup is also instantiated here	
}



