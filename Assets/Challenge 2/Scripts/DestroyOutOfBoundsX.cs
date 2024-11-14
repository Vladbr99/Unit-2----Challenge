﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftLimit = -30f;
    private float bottomLimit = -10f; 

    // Update is called once per frame
    void Update()
    {
        // Destroy dogs if x position is less than left limit (for left boundary)
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        } 
        // Destroy balls if y position is less than bottomLimit (for bottom boundary)
        else if (transform.position.y < bottomLimit)
        {
            Destroy(gameObject);
        }
    }
}
