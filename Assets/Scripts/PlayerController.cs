using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public float jumpForce;
    [SerializeField] Rigidbody2D player;
    private bool isGrounded;
    private bool isAllowedToDoubleJump;
    [SerializeField] Transform groundCheckPoint;
    [SerializeField] LayerMask whatIsGround;

    void Start()
    {
        
    }

    void Update()
    {
        player.velocity = new Vector2(moveSpeed * Input.GetAxis("Horizontal"), player.velocity.y);
        isGrounded = Physics2D.OverlapCircle(groundCheckPoint.position, .2f, whatIsGround);
        Debug.Log(isGrounded);
        if (isGrounded)
            isAllowedToDoubleJump = true;
        if (Input.GetButtonDown("Jump"))
        {
            if (isGrounded)
                player.velocity = new Vector2(player.velocity.x, jumpForce);
            else if (isAllowedToDoubleJump)
            {
                player.velocity = new Vector2(player.velocity.x, jumpForce);
                isAllowedToDoubleJump = false;
            }
        }
    }
}
