using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectTexture : MonoBehaviour
{
    public Texture2D texture;

    void Start()
    {
        GetComponent<Renderer>().material.mainTexture = texture;
    }
}

