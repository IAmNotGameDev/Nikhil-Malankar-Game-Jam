using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3 : MonoBehaviour
{
    public float horizontalSpeed = 2.0f; // Speed of left-right movement
    public float verticalSpeed = 2.0f;   // Speed of up-down movement
    public float distance = 2.0f;        // Distance to move left-right and up-down

    private Vector3 initialPosition;
    private float startTime;

    private void Start()
    {
        initialPosition = transform.position;
        startTime = Time.time;
    }

    private void Update()
    {
        // Calculate the new horizontal and vertical positions based on sine wave patterns
        float horizontalInput = Mathf.Sin((Time.time - startTime) * horizontalSpeed) * distance;
        float verticalInput = Mathf.Sin((Time.time - startTime) * verticalSpeed) * distance;

        Vector3 newPosition = initialPosition + new Vector3(horizontalInput, verticalInput, 0);

        // Apply the new position to the object's Transform
        transform.position = newPosition;
    }
}