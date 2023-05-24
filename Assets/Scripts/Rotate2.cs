using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate2 : MonoBehaviour
{
    private bool leftIsPressed = false;
    private bool rightIsPressed = false;
    public float rotationSpeed = 1f;
    
    public void LeftRotateDownm()
    {
        leftIsPressed = true;
    }

    public void LeftRotateUp()
    {
        leftIsPressed = false;
    }
    
    public void RightRotateDown()
    {
        rightIsPressed = true;
    }

    public void RightRotateUp()
    {
        rightIsPressed = false;
    }

    private void Update()
    {
        if (leftIsPressed)
        {
            transform.Rotate(0, -rotationSpeed,0);
        }

        if (rightIsPressed)
        {
            transform.Rotate(0,rotationSpeed,0);
        }
    }
}
