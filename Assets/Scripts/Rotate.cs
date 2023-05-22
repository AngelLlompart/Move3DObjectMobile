using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
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
            float z = positionWorld.y;
            positionWorld.z = z;
            positionWorld.y = 0.72f;
            transform.position = positionWorld;
        }
    }
}
