using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{   
    public float JumpForce;
    public bool IsGrounded;
    private Rigidbody2D rb;
    private Animator animator;
    public GameObject GameOverUI;

    public GameObject HideGmOvr;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (IsGrounded && Input.GetKeyDown(KeyCode.Space)){
            Jump();
        }
        if(Input.GetKeyDown(KeyCode.C)){
            Time.timeScale = 1;
        }
    }
    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.CompareTag("Ground")){
            IsGrounded = true;
            animator.SetBool("IsGrounded",true);
        }
        if(collision.gameObject.CompareTag("Obstacle")){
            Time.timeScale = 0;
            GameOverUI.SetActive(true);
            HideGmOvr.SetActive(false);
        }
    }
    void OnCollisionExit2D(Collision2D collision)
    {   if(collision.gameObject.CompareTag("Ground")){
        IsGrounded=false;
        animator.SetBool("IsGrounded",false);
        }
    }
    void Jump()
    {
        rb.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
    }
}
