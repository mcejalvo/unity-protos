using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [Header("Player Attributes")]
    [SerializeField] float movementSpeed = 10f;

    [Space]
    InputMaster playerControls;
    Rigidbody2D gameObjectComponent;

    void Awake()
    {
        playerControls = new InputMaster();
        playerControls.Player.Move.performed += movementInput => Move(movementInput.ReadValue<Vector2>());
    }

    void Start()
    {
        gameObjectComponent = gameObject.GetComponent<Rigidbody2D>();
    }

    void Move(Vector2 direction)
    {
        gameObjectComponent.AddForce(new Vector2(direction.x * movementSpeed, direction.y * movementSpeed));
    }

    private void OnEnable() 
    {
        playerControls.Enable();
    }

    private void OnDisable()
    {
        playerControls.Disable();
    }

    
}