using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody2D Player;
    public Vector2 Walk_Speed;
    public Vector2 Sneak_Speed;
    public Vector2 Sprint_Speed;

    private bool isGrounded = false;
    
    void Start()
    {

    }

 
    void Update()
    {
        Walk();
        Sneak();
        Sprint();
    }

    void Walk()
    {
       if ((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) && isGrounded == true)
       {
            Player.velocity = -Walk_Speed;
 
       }
       else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
       {
            Player.velocity = Walk_Speed;
 
       }
    }

    void Sneak()
    {
        if ((Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl)) && isGrounded == true)
        {
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                Player.velocity = -Sneak_Speed;

            }
            else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                Player.velocity = Sneak_Speed;

            }
        }  
    }

    void Sprint()
    {
        if ((Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) && isGrounded == true)
        {
            Player.velocity = -Sprint_Speed;

        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            Player.velocity = Sprint_Speed;

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
    }
}
