using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Enemy1 : MonoBehaviour
{
    public float speed = 2.0f;       // Speed of movement
    public float distance = 2.0f;    // Distance to move left and right

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
        float horizontalInput = Mathf.Sin((Time.time - startTime) * speed) * distance;
        Vector3 newPosition = initialPosition + new Vector3(horizontalInput, 0, 0);

        // Apply the new position to the object's Transform
        transform.position = newPosition;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameManager.Instance.GameOver();
        }
    }
}