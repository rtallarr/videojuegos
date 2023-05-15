using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCollisions : MonoBehaviour
{
    
    
    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "Proyectil")
        {
            Destroy(collision.gameObject);
        }
    }
}