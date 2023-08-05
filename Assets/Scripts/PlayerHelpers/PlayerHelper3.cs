using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHelper3 : MonoBehaviour
{
    public float moveSpeed = 5.0f; // Speed of movement
    public float distanceToMove = 5.0f; // Distance to move before stopping
    private Vector3 initialPosition;
    private Vector3 targetPosition;
    private bool isMoving = true;

    private void Start()
    {
        initialPosition = transform.position;
        targetPosition = initialPosition + new Vector3(0, distanceToMove, 0); // Move in y-up direction
    }

    private void Update()
    {
        if (isMoving)
        {
            // Move the object towards the target position
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

            // Check if the object has reached the target position
            if (Vector3.Distance(transform.position, targetPosition) < 0.01f)
            {
                isMoving = false;
                Debug.Log("Object has stopped.");
            }
        }
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("player");
            other.gameObject.transform.position = Vector3.MoveTowards(other.gameObject.transform.position, initialPosition + new Vector3(0, distanceToMove, 0), moveSpeed * Time.deltaTime); // Move player in y-up direction
            if (Vector3.Distance(other.gameObject.transform.position, targetPosition) < 0.01f)
            {
                isMoving = false;
                Debug.Log("Object has stopped.");
            }
        }
    }
}
