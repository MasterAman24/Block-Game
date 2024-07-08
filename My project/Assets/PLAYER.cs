using UnityEngine;

public class PLAYER : MonoBehaviour
{  
    public Rigidbody rb;
    public float forwardforce = 2000f;
    public float sideways=500f;
   
    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0,0,forwardforce* Time.deltaTime);

        if(Input.GetKey("d")){
            rb.AddForce(sideways*Time.deltaTime ,0,0,ForceMode.VelocityChange);
        }

        if(Input.GetKey("a")){
            rb.AddForce(-sideways*Time.deltaTime ,0,0,ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
		{
			FindObjectOfType<GameManager1>().EndGame();
		}

        
    }
}
