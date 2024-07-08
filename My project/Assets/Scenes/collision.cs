
using UnityEngine;

public class collision : MonoBehaviour

{
    public PlayerMovement movement;
    

    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
		{
			movement.enabled = false;   // Disable the players movement.
			FindObjectOfType<GameManager1>().EndGame();
		}
    }

   
}

