using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2 : MonoBehaviour
{
    private bool backIsPressed = false;
    private bool frontIsPressed = false;
    public float speed = 5f;
    
    public void MoveFrontDown()
    {
        frontIsPressed = true;
    }

    public void MoveFrontUp()
    {
        frontIsPressed = false;
    }
    
    public void MoveBackDown()
    {
        backIsPressed = true;
    }

    public void MoveBackUp()
    {
        backIsPressed = false;
    }

    private void Update()
    {
        if (frontIsPressed)
        {
            transform.position += Vector3.forward * speed * Time.deltaTime;
        }

        if (backIsPressed)
        {
            transform.position += Vector3.back * speed * Time.deltaTime;
        }
    }
}
