using System;
using UnityEngine;

public class movescript : MonoBehaviour
{
   public float moveSpeed = 5f;
   public float jumpForce = 10f;
   public Transform groundCheck;
   public float groundCheckRadius =  0.2f;
   public LayerMask groundLayer;
   
   private Rigidbody2D rb;
   private bool isGrounded;
   
   private Animator animator;
   private float moveInput;
   void Start()
   {
       rb = GetComponent<Rigidbody2D>();
       animator = GetComponent<Animator>();
   }
   
   
   
   void Update()
   {
     moveInput = Input.GetAxis("Horizontal");
     rb.linearVelocity = new Vector2(moveInput * moveSpeed, rb.linearVelocity.y);
     
     if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
     {
         animator.SetBool("Jumped" ,true);
         rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);  
     }

     
   }

   private void FixedUpdate()
   {
       isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
       if (isGrounded)
       {
           animator.SetBool("Jumped", false);
       }
       animator.SetFloat("Speed", Mathf.Abs(moveInput));

       animator.SetFloat("VerticalSpeed" , rb.linearVelocity.y);
   }

   
          
}
