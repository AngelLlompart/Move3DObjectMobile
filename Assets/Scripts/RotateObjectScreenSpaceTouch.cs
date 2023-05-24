using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;

public class RotateObjectScreenSpaceTouch : MonoBehaviour
{
    private void Awake()
    {
        EnhancedTouchSupport.Enable();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Touch.activeTouches.Count > 0)
        {
            if (Touch.activeTouches[0].phase == TouchPhase.Began) 
            {
                //Debug.Log("[Began]" + Touch.activeTouches[0].screenPosition);
            }
            else if(Touch.activeTouches[0].phase == TouchPhase.Moved)
            {
                //Debug.Log("[Moved position] " + Touch.activeTouches[0].screenPosition);
                //Debug.Log("[Moved delta] " + Touch.activeTouches[0].delta);
                
                
                transform.Rotate(0,-Touch.activeTouches[0].delta.x * 360 / Screen.width, 0);
            } 
            else if (Touch.activeTouches[0].phase == TouchPhase.Ended)
            {
                //Debug.Log("[Ended] " + Touch.activeTouches[0].screenPosition);
            }
        }
    }
}
