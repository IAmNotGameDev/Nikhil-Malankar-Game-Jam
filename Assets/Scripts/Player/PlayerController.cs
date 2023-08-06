using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float bounceForce;
    public float moveSpeed;

    public AudioSource jump;
    public float moveInput;
    private void Start()
    {

    }



    // Update is called once per frame
    void FixedUpdate()
    {
        Debug.Log(moveInput);
/*        moveInput = Input.GetAxis("Horizontal");*/
        Vector2 moveDirection = new Vector2(moveInput, 0);
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, rb.velocity.y);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            jump.Play();
            rb.velocity = new Vector2(rb.velocity.x, bounceForce);
        }
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("gameover");
        }
    }
}
