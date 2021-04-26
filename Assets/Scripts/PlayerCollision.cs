using UnityEngine;

public class PlayerCollision : MonoBehaviour 
{
	public PlayerMovement movement; //Use when we turn of the PlayerMovement Script to stop the object flying when it hits the obstacle



	void OnCollisionEnter(Collision collisionInfo)
	{
		if (collisionInfo.collider.tag == "Obstacle")// "tag" because "name" is not preferrable for game consisting of thousands of objects   
		{
			movement.enabled = false;// Now the script stops and Player doesnt fly when hits an obstacle ,instead it stops there 
			FindObjectOfType<GameManager>().EndGame();

		}
	}
}

