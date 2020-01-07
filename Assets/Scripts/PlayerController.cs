using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public float jumpForce;

    [SerializeField] Rigidbody2D player;
    void Start()
    {
        
    }

    void Update()
    {
        player.velocity = new Vector2(moveSpeed * Input.GetAxis("Horizontal"), player.velocity.y);
        if (Input.GetButtonDown("Jump"))
        {
             player.velocity = new Vector2(player.velocity.x, jumpForce);
        }
    }
}
