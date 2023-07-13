using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    private float horizontal;
    private float speed = 8f;
    private float jumpPower = 16f;
    private bool isFacingRight = true;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        if((Input.GetButtonDown("Jump") || Input.GetKeyDown(KeyCode.UpArrow)) && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
        }
        if((Input.GetButtonUp("Jump") || Input.GetKeyUp(KeyCode.UpArrow)) && rb.velocity.y < 0f)
        {
            rb.velocity = new Vector2 (rb.velocity.x, rb.velocity.y * .5f);
        }
        flip();
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, .2f, groundLayer);
    }

    private void flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
}
