using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    public float speed = 2.0f;       // Speed of movement
    public float distance = 2.0f;    // Distance to move up and down

    private Vector3 initialPosition;
    private float startTime;

    private void Start()
    {
        initialPosition = transform.position;
        startTime = Time.time;
    }

    private void Update()
    {
        // Calculate the new position based on a sine wave pattern
        float verticalInput = Mathf.Sin((Time.time - startTime) * speed) * distance;
        Vector3 newPosition = initialPosition + new Vector3(0, verticalInput, 0);

        // Apply the new position to the object's Transform
        transform.position = newPosition;
    }
}




