using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	public float paddleSpeed = 20f;
	public GameObject Ball;
	static int lives=3;  //lives
	int score=0; //score
	public Texture lifeImage;
	public GUISkin ScoreboardSkin;
	 bool isFirst=true;

	GameObject attachedBall = null;

	// Use this for initialization
	void Start () 
	{


		isFirst = false;


	}//sets isFirst to false so a live is not taken off once the game is loaded


	public void OnLevelWasLoaded(int level)
	{

		DontDestroyOnLoad (gameObject); 

		SpawnBall ();


	}//OnLevelWasLoaded passes the level and does not destroy the game object on load then spawns a ball
	public void AddPoint(int v)
	{

		score += v;

	}//passes an integer and score is updated each time



	public void SpawnBall()
	
	{


				attachedBall = (GameObject)Instantiate (Ball, transform.position + new Vector3 (0, .75f, 0), Quaternion.identity);


		if (!isFirst) 
		{  
						lives--;

		}//if its not first then minus a live
	}//SpawnBall() this instantiates the ball




	void Update ()
	{
		//left-right

		transform.Translate(paddleSpeed*Time.deltaTime*Input.GetAxis ("Horizontal"),0,0);


		if (transform.position.x > 7.4) 
		{
				
			transform.position = new Vector3 (7.4f,transform.position.y,transform.position.z);

		
		}

		if (transform.position.x < -7.4) 
		{
			
			transform.position = new Vector3 (-7.4f,transform.position.y,transform.position.z);
			
			
		}

		if (attachedBall) 
		{

						Rigidbody ballRigidBody = attachedBall.rigidbody;

						ballRigidBody.position = transform.position + new Vector3 (0, .75f, 0);
						if (Input.GetButtonDown ("LaunchBall"))
						{
								//fire the ball

						
								ballRigidBody.isKinematic = false;
								ballRigidBody.AddForce (0,1000f, 0); //speed of ball
								attachedBall = null;
						}

				
		}//if

	}//update() is called once per frame


	void GameOver(){
	

		Destroy(gameObject);

		PlayerPrefs.GetInt ("YourScore");
		PlayerPrefs.SetInt ("YourScore", score);//Your Score

		if (score > PlayerPrefs.GetInt ("HighScore")) 
		{
						PlayerPrefs.SetInt ("HighScore", score);
		}//if
			



		Application.LoadLevel("GameOver");



	}//GameOver() Destroys the gameobject and also saves the users score and the high score and will then 
	//load the GameOver scene



	void OnGUI()
	{
		GUI.skin = ScoreboardSkin;

		GUI.Label (new Rect (0, 10, 300, 100), "Score:" + score);   //Score



		for (int i=0; i<lives; i++) 
		{
			//Draw the one live texture offsetting the x co-ord by the current value for 
			//i * the width of the texture + 15
			GUI.DrawTexture(new Rect(Screen.width - 200+i*60+10,30,55,55),lifeImage);  //Lives
		}//for


		if (lives <= 0) 
		{
			

			GameOver();

		}//if


	}//OnGUI() creates the score and uses a for loop to display the health


	void OnCollisionEnter (Collision col) 
	{  
		Debug.Log (col);
		foreach (ContactPoint contact in col.contacts) 
			{
						if (contact.thisCollider == collider)
						{
								//this is th paddles contact point
								float english = contact.point.x - transform.position.x;
								contact.otherCollider.rigidbody.AddForce (300f * english, 0, 0);
						}//if
			}//foreach
	}//Detects a collision so when ball collides with paddle

}
