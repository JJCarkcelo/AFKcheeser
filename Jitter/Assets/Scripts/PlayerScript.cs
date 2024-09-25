using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{
    //testing bc pain
    private bool isGrounded;
       
    PlayerInputs playerInputs;
    public unequippedMap currentMap;
    
    InputAction move;

    private void Awake()
    {
        playerInputs = new InputSystem();

    }


    private void OnEnable()
    {
        currentMap.Unequipped.Move;
        playerInputs.
    }

    public struct unequippedMap
    {
        public InputAction move;
        public InputAction jump;
        public InputAction run;
        public InputAction crouchSlide;
        public InputAction focus;
        public InputAction punch;
        
    }
    public struct knifeMap
    {
        public InputAction move;
        public InputAction jump;
        public InputAction run;
        public InputAction crouchSlide;
        public InputAction focus;
        public InputAction lightAttack;
        public InputAction heavyAttack;
    }

    public struct rifleMap
    {
        public InputAction move;
        public InputAction jump;
        public InputAction run;
        public InputAction crouchSlide;
        public InputAction punch;
        public InputAction ads;
        public InputAction shoot;
        public InputAction reload;
    }

    
