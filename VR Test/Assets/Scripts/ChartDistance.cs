using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChartDistance : MonoBehaviour
{
    Vector3 startPos;
    public GameObject forward;
    private void Start() {
        startPos = transform.position;
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.DownArrow)){
            transform.position += forward.transform.right;
            
        }
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            transform.position -= forward.transform.right;
        }
        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            transform.position = startPos;
        }
    }
    
}

