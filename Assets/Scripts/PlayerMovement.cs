using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody rb;//reference to Rigidbody component is "rb"
	public float forwardForce = 2000f;
	public float sidewaysForce= 500f;

	// Use this for initialization
	/*void Start () {
		rb.AddForce(0, 200, 500);
	}*/
	
	// We marked it as FixedUpdate() because we are using it to mess with Physics.
	void FixedUpdate () 
	{
		//Add a forward force
		rb.AddForce (0, 0, forwardForce* Time.deltaTime);	
		if (Input.GetKey("d")) 
		{
			rb.AddForce (sidewaysForce*Time.deltaTime, 0, 0,ForceMode.VelocityChange);
		}
		if (Input.GetKey("a")) 
		{
			rb.AddForce (-sidewaysForce*Time.deltaTime, 0, 0,ForceMode.VelocityChange);
		}
	
		if (rb.position.y < -1f) 
		{	
			FindObjectOfType<GameManager> ().EndGame ();
		}
	}
}
