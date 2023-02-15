using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChartDistance : MonoBehaviour
{
    [Range(-10f, 10f)] // set the range for the slider
    public float xPosition; // the x position of the object

    public GameObject objectToMove; // reference to the object you want to move
    private void Start() {
        xPosition = -6f;
    }
    private void Update()
    {
        Vector3 newPosition = new Vector3(xPosition, objectToMove.transform.position.y, objectToMove.transform.position.z); // create a new position vector with the new x value
        objectToMove.transform.position = newPosition; // move the object to the new position
    }
}

