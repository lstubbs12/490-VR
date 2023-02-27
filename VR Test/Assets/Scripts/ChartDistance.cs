using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChartDistance : MonoBehaviour
{

    private void Start() {
        
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.DownArrow)){
            transform.position += transform.right * 6;
        }
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            transform.position -= transform.right * 6;
        }
    }
    
}

