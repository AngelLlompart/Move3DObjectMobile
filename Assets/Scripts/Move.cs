using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private GameObject ballPointer;

    public float speed = 4;

    private bool selected = false;
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
            Ray ray = Camera.main.ScreenPointToRay(pos); 
            
            Debug.DrawRay(ray.origin, ray.direction * 100, Color.red);
            if (Physics.Raycast(ray, out RaycastHit hit, 100f))
            {
                if (hit.transform.gameObject.Equals(transform.gameObject))
                {
                    selected = true;
                }
            }

            if (selected)
            {
                Cursor.visible = false;
                ballPointer.SetActive(true);
                pos.z = 6;
                Vector3 positionWorld = Camera.main.ScreenToWorldPoint(pos);
                float z = positionWorld.y * speed;
                positionWorld.z = z;
                positionWorld.y = 0.72f;
                transform.position = positionWorld;
            }
            
        }
        else
        {
            selected = false;
            Cursor.visible = true;
            ballPointer.SetActive(false);
        }
    }
}
