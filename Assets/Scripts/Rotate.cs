using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    public float rotationSpeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Vector3 pos = Input.GetTouch(0).position;
            pos.z = 6;
            Vector3 positionWorld = Camera.main.ScreenToWorldPoint(pos);
            Debug.Log(positionWorld);
            //transform.Rotate(vx,vy,0);
            //transform.rotation = Quaternion.Euler(-positionWorld.y * 80,- positionWorld.x * 40,0); 

            float totalWidth = Screen.width;
            float moveWidth =  360 / totalWidth;

            float totalHeight = Screen.height;
            float moveHeight = 360 / totalHeight;
            transform.rotation *= Quaternion.Euler(-pos.y * moveHeight,-pos.x * moveWidth,0);
        }
    }
}
