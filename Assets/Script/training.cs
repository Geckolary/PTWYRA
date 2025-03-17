 using UnityEngine;

public class training : MonoBehaviour
{
    public Rigidbody rb; // Me permet de créer ma variable rigidbody et ensuite de pouvoir intéragir avec
    
    public float forwardForce = 2000f;
    public float sideForce = 500f;

    
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); // J'ajoute une force sur mon rigidbody via l'axe z, le delta time me permet de ralentir cette force et j'utilise ma variable "forwardforce" que j'ai créer au dessus.

        if ( Input.GetKey("d") )
        {
            rb.AddForce(sideForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0);
        }
    }
}
