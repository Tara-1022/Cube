using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform playerInf;
    public Vector3 distancing;//distance or position is a vector type
   
    // Update is called once per frame
    void Update()
    {
        transform.position = playerInf.position + distancing;//adding the distancing to the position of the object on which the script sits
    }
}
