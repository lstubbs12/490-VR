using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetToMiddle : MonoBehaviour
{
    public GameObject headset;

    private void Update() {
        if (Input.GetKeyDown(KeyCode.X))
        {

            headset.transform.position = new Vector3(0, 1, 0);
                
        }
    }
}
