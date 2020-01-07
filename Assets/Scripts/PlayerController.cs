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

    private Animator anim;
    private SpriteRenderer render;

    void Start()
    {
        anim = GetComponent<Animator>();
        render = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        player.velocity = new Vector2(moveSpeed * Input.GetAxis("Horizontal"), player.velocity.y);
        isGrounded = Physics2D.OverlapCircle(groundCheckPoint.position, .2f, whatIsGround);
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
        if (player.velocity.x < 0)
            render.flipX = true;
        else if (player.velocity.x > 0)
            render.flipX = false;
        anim.SetBool("isGrounded", isGrounded);
        anim.SetFloat("moveSpeed", Mathf.Abs(player.velocity.x));
    }

}
