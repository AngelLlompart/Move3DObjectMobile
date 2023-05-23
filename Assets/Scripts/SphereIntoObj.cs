using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereIntoObj : MonoBehaviour
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
        }
    }
}
