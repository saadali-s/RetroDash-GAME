using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercollision : MonoBehaviour {
    public movement movements;
    public ParticleSystem engine1;
    public ParticleSystem engine2;
    public Rigidbody SpaceShip;


    public GameObject spaceship;


    void OnCollisionEnter (Collision collisionInfo)
    {
      
       if (collisionInfo.collider.tag == "Obsticle")
        {
            movements.enabled = false;
        }


        if (collisionInfo.collider.tag == "Obsticle")
        {
            engine1.Stop();
        }


        if (collisionInfo.collider.tag == "Obsticle")
        {
            engine2.Stop();
           
        }


        if (collisionInfo.collider.tag == "Obsticle")
        {
            PlayerManager.gameOver = true;

        }

        if (collisionInfo.collider.tag == "Obsticle")
        {
            SpaceShip.velocity = new Vector3(0, 0, 0);

        }

        if (collisionInfo.collider.tag == "Obsticle")
        {
            SpaceShip.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezeRotationY;

        }


    }
   
            
           
   
    
}
