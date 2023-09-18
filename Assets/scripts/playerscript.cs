using UnityEngine;

public class playerscript : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f, sideForce=100f;//f indicates float value
    bool right, left;

    
    // Update is called once per frame

    void Update()
    {
        right = Input.GetKey("d");//Input.GetKey returns 'True' or 'False' depending on if the given key is pressed
        left = Input.GetKey("a");
    }

    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce*Time.fixedDeltaTime);//'Time.fixedDeltaTime' gives a value depending on framerate; Ensures speed same for all users

        if (right)
        {
            rb.AddForce(sideForce * Time.fixedDeltaTime, 0, 0,ForceMode.VelocityChange);
        }

        if(left)
        {
            rb.AddForce(-sideForce*Time.fixedDeltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if (rb.position.y < -0.75f)//Calls function 'GameEnd' if the player falls off 
        {
            FindObjectOfType<GameManager>().GameEnd();
        }
    }
}
