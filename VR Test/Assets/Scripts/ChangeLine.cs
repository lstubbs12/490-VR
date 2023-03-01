using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLine : MonoBehaviour
{
    GameObject[] lineBlockers = new GameObject[9];
    int count = 1;
    int previous = 1;

    private void Start()
    {

        for(int i = 1; i < 9; i++)
        {
            String name = "line" + i;
            lineBlockers[i] = GameObject.Find(name);
            lineBlockers[i].SetActive(false);
        }
 
    }
    private void Update()
    {
        
        
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (lineBlockers[previous].activeSelf)
            {
                lineBlockers[previous].SetActive(false);
            }
            lineBlockers[count].SetActive(true);
            if (count < 8)
            {
                count++;
                if(count > 2)
                    previous++;
            }
            else
            {
                count = 1;
                previous = 1;
                
            }
            if (lineBlockers[1].activeSelf)
                lineBlockers[8].SetActive(false);


        }
        
    }

}
