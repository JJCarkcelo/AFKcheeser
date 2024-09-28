using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TestMoveScript : MonoBehaviour
{
    private PlayerInputs playerInputs;

    public InputActionMap Player;
    private InputActionMap Knife;
    private InputActionMap Rifle;
    
    Rigidbody m_Rigidbody;
    public float moveSpeed = 10f;

    public string[] item = { "Unequipped", "Knife", "Rifle" };

    private void Awake()
    {
        playerInputs = new PlayerInputs();
    }
    private void OnEnable()
    {
        playerInputs.Disable();
        playerInputs.Player.SwitchMap.performed += SwitchActionMap;
    }

    private void OnDisable()
    {
        playerInputs.Disable();
        playerInputs.Player.SwitchMap.performed -= SwitchActionMap;
    }

    private void SwitchActionMap(InputAction.CallbackContext context)
    {
        Player.Enable();
        Player.Disable();
        Knife.Enable();
        Knife.Disable();
        Rifle.Enable();
        Rifle.Disable();
    }
    

    private void Start()
    {
        //Fetch the Rigidbody from the GameObject with this script attached
        m_Rigidbody = GetComponent<Rigidbody>();
        //Stop the Rigidbody from rotating
        m_Rigidbody.freezeRotation = true;
    }

    private void Update()
    {
        Vector2 move = playerInputs.Player.Move.ReadValue<Vector2>();
        Debug.Log(move);
        playerInputs.Player.Jump.ReadValue<float>();
        //if (playerInputs.Player.Jump.ReadValue<float>() == 1)
    }

    
}
