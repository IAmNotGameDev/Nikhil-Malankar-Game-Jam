using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHelper2 : MonoBehaviour
{
    public float springForce = 10f; // Adjust the force to your liking

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Rigidbody2D playerRigidbody = collision.gameObject.GetComponent<Rigidbody2D>();

            if (playerRigidbody != null)
            {
                Vector2 upwardForce = Vector2.up * springForce;
                playerRigidbody.AddForce(upwardForce, ForceMode2D.Impulse);
            }
        }
    }
}