using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapKeyboards : MonoBehaviour
{
    public GameObject keyboard1;
    public GameObject keyboard2;
    

    private void Update() {
         if (Input.GetKeyDown(KeyCode.C))
        {
            if(keyboard1.activeSelf){
                keyboard1.SetActive(false);
                keyboard2.SetActive(true);
            }else{
                keyboard1.SetActive(true);
                keyboard2.SetActive(false);
            }
            
                
        }
    }
}
