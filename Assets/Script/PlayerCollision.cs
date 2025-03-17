using UnityEngine;

public class PlayerCollision : MonoBehaviour
    
{
    public training movement;
 
    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "obstacle")  
        {
            movement.enabled = false;
        }
    }
   
}
