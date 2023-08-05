using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHelper1 : MonoBehaviour
{
    public float moveSpeed = 5.0f; // Speed of movement
    public float distanceToMove = 5.0f; // Distance to move before stopping
    private Vector3 initialPosition;
    private Vector3 targetPosition;
    private bool isMoving = true;
    public GameObject objectToMoveWith;
    private Vector3 initialScale;

    private void Start()
    {
        initialPosition = transform.position;
        targetPosition = initialPosition + new Vector3(distanceToMove, 0, 0);
        initialScale = objectToMoveWith.transform.localScale;
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

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Store the current scale of the objectToMoveWith
            Vector3 currentScale = new(0.3960396f, 2.424242f, 1);

            // Set the object with the PlayerHelper1 script as the parent of the player object
            collision.transform.SetParent(transform);

            // Restore the original scale of the objectToMoveWith
            objectToMoveWith.transform.localScale = currentScale;
        }
    }
}