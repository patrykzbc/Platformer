using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class playercontroller : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 1f;

    private Playercontrol playercontrols;
    private Vector2 movement;
    private Rigidbody2D rb;

    private void Awake()
    {
       playercontrols = new Playercontrol ();
       rb = GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        playercontrols.Enable();
    }
    private void OnDisable()
    {
        playercontrols.Disable();
    }
    


    void Update()
    {
        PlayerInput();
    }


    private void PlayerInput()
    {
         movement = playercontrols.movement.move.ReadValue<Vector2>(); 
    }
}
