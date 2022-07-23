﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchmovementx : MonoBehaviour
{
    private Touch touch;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                transform.position = new Vector3(transform.position.x + touch.deltaPosition.x * Time.deltaTime *3f, transform.position.y, transform.position.z);
            }
        }
    }
}
