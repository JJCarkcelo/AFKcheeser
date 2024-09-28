using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{
    private PlayerInputs playerInputs;
    public float moveSpeed = 10f;
    public Rigidbody rb;


    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        playerInputs = new PlayerInputs();
    }

    private void OnEnable()
    {
        playerInputs.Enable();
    }

    private void OnDisable()
    {
        playerInputs.Disable();
    }

    public Vector2 GetMove()
    {
        return playerInputs.Player.Move.ReadValue<Vector2>();

    }
    public Vector2 GetMouse()
    {
        return playerInputs.Player.Look.ReadValue<Vector2>();
    }

    public bool jumped()
    {
        return playerInputs.Player.Jump.triggered;
    }
}

    
