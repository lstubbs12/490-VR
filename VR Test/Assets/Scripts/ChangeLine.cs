using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLine : MonoBehaviour
{
    List<GameObject> lineBlockers = new List<GameObject>();

    private void Start()
    {
        for(int i = 0; i < 6; i++)
        {
            GameObject g = GameObject.Find("line" + i);
            lineBlockers.Add(g);
        }
        GameObject b = GameObject.Find("line1");
        lineBlockers.Add(b);
        Debug.Log(b.name);
        
    }
    private void Update()
    {
        GameObject b = GameObject.Find("line1");
        lineBlockers.Add(b);
        Debug.Log(b.name);
    }

}
