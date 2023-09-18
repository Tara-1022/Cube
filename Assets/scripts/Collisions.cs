using UnityEngine;

public class Collisions : MonoBehaviour
{
    public playerscript movement;//referencing to the script 'player script'
    void OnCollisionEnter(Collision collisionInfo)//collision info has type 'collosion' and holds collision info;funvtion called when collision occurs
    {
        if (collisionInfo.collider.tag == "Obstacle")//disable movement script if player collides with an obstacle
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().GameEnd();//Searches for GameManager,function-'GameEnd'. Can also write 
            //at beginning 'public GameManager gamemanager, call it ; drag in the GameManager script to the variable. inefficient because attached to specefic object
        }
    }
}
