using UnityEngine;

public class FollowPlayer : MonoBehaviour {
	public 	Transform player;
	public Vector3 offset;//Vector3 stores 3 float numbers which is very easy for 3 float numbers x,y and z 
	// Use this for initialization
	/*void Start () {
		
	}*/
	
	// Update is called once per frame
	void Update () 
	{
		//Debug.Log (player.position);//Display position of the player or on which axis it is moving
		transform.position= player.position + offset; //position of the camera = position of the player ie.Camera follows the Player
	}
}
