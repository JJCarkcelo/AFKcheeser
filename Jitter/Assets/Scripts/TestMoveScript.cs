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
    private int currentIndex = 0;

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
        float axisValue = context.ReadValue<float>(); //direct to bind
        //Debug.Log("Mousewheel: " + axisValue);
        item[] = currentIndex;
        currentIndex += (int)(Mathf.Sign(axisValue));
        if (currentIndex = 0)
        {
            Debug.Log(item[currentIndex]);
        }
        else if (currentIndex = 1)
        {
            Debug.Log(item[currentIndex]);
        }
        else if (currentIndex = 2)
        {
            Debug.Log(item[currentIndex]);
        }

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
