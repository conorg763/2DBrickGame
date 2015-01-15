using UnityEngine;
using System.Collections;

public class SimplyBall : MonoBehaviour {
	public AudioClip[] blipAudio;

	void Start () 
	{

	}	// Use this for initialization

	
	void Update () 
	{
	
	}	// Update is called once per frame


	public void Die()
	{
		Destroy(gameObject);
		GameObject PaddleObject = GameObject.Find ("Paddle");
		Paddle paddleScript = PaddleObject.GetComponent<Paddle>();
		paddleScript.SpawnBall ();
	}//Die() destroys gameObject and spawns a new ball

	void OnCollisionEnter(Collision collision) 
	{
		AudioSource.PlayClipAtPoint(blipAudio[Random.Range(0,blipAudio.Length)],transform.position,.25f);


	}		//play a blip

}