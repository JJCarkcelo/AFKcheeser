using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TestMoveScript : MonoBehaviour
{
    //assigning player controls
    private PlayerInputs playerInputs;
    private InputActionMap Player;
    private InputActionMap Knife;
    private InputActionMap Rifle;
    //movement and physics
    public Rigidbody m_Rigidbody;
    public float moveSpeed = 10f;

    public string[] item = { "Unequipped", "Knife", "Rifle" };

    private void Awake()
    {
        playerInputs = new PlayerInputs();
    }
    private void OnEnable()
    {
        playerInputs.Enable();
        playerInputs.Player.SwitchMap.performed += GetSwitchMap;
    }

    private void OnDisable()
    {
        playerInputs.Disable();
        playerInputs.Player.SwitchMap.performed -= GetSwitchMap;
    }

    private void GetSwitchMap(InputAction.CallbackContext context)
    {
        float axisValue = playerInputs.Player.SwitchMap.ReadValue<float>();
        axisValue = Mathf.Sin(axisValue);
        
        Debug.Log("Mousewheel: " + axisValue);
    }

    private void SwitchActionMap()
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
