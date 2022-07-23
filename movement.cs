using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
   

    public Rigidbody rb;
    public float fowardForce = 2000f;

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0, 0, fowardForce * Time.deltaTime);
        
    }
    void OnDisable()
    {

    }

}
