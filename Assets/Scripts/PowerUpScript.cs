using UnityEngine;
using System.Collections;

public class PowerUpScript : MonoBehaviour {
	public int PointValue=5;


	void Start () {
	
	}// Use this for initialization
	
	void Update () {
	
		rigidbody.AddTorque( Vector3.forward * 10f );    


	}	// Update is called once per frame



	void OnTriggerEnter (Collider collider)
	{


	
		GameObject.Find ("Paddle").GetComponent<Paddle> ().AddPoint(PointValue);

	}//triggers when powerup is detected by the paddle

	void OnCollisionEnter (Collision col )
	{
		Destroy (gameObject);
	}//Detects a collision and then destroys gameObject


}