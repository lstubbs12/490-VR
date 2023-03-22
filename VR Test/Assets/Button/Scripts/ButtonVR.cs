/**************************************************
Copyright : Copyright (c) RealaryVR. All rights reserved.
Description: Script for VR Button functionality.
***************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonVR : MonoBehaviour
{
    public GameObject button;
    public UnityEvent onPress;
    public UnityEvent onRelease;
    GameObject presser;
    AudioSource sound;
    bool isPressed;

    ArrayList order = new ArrayList();
    ArrayList pressed = new ArrayList();

    void Start()
    {
        sound = GetComponent<AudioSource>();
        isPressed = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!isPressed)
        {
            button.transform.localPosition = new Vector3(0, 0.003f, 0);
            presser = other.gameObject;
            onPress.Invoke();
            sound.Play();
            isPressed = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == presser)
        {
            button.transform.localPosition = new Vector3(0, 0.015f, 0);
            onRelease.Invoke();
            isPressed = false;
        }
    }

    public void SpawnSphere()
    {
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        sphere.transform.localPosition = new Vector3(0, 1, 2);
        sphere.AddComponent<Rigidbody>();
    }

    /*
    2 first     T Z
    4 second    P T O C
    5 third     Z L P E D
    6 fourth    E T O D C F
    7 fifth     D P C Z L F T
    8 sixth     C F D T E O P L
    8 seventh   L D C Z O T E P
    8 ninth     P F C D T Z L E
    */

    public void TakeInLetter(string letter){
        pressed.Add(letter);
        
        // for(int i = 0; i < pressed.Count; i++){
        //     Debug.Log(pressed[i]);
        // }
        foreach(var let in pressed)
            Debug.Log(let.ToString());
            Debug.Log(pressed.Count);
        
    }

}
