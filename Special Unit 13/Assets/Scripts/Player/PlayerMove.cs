using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rigidBody;
    [SerializeField] private Camera mainCamera;
    [SerializeField] private float moveSpeed = 5f;

    private PlayerInputActions playerInputActions;
    private InputAction movement;
    private InputAction mousePosition;

    private Vector2 worldMousePosition;


    private void OnEnable()
    {
        movement = playerInputActions.Player.Movement;
        movement.Enable();

        mousePosition = playerInputActions.Player.MousePosition;
        mousePosition.Enable();

        playerInputActions.Player.Shooting.performed += Shoot;
        playerInputActions.Player.Shooting.Enable();

    }



    private void OnDisable()
    {
        movement.Disable();
        mousePosition.Disable();
        playerInputActions.Player.Shooting.Disable();
    }

    private void Awake()
    {
        playerInputActions = new PlayerInputActions();
    }

    private void FixedUpdate()
    {
        PlayerMovement();
        PlayerRotation();
    }

    private void PlayerMovement()
    {
        rigidBody.MovePosition(rigidBody.position + movement.ReadValue<Vector2>().normalized * moveSpeed * Time.fixedDeltaTime);
    }

    private void PlayerRotation()
    {
        worldMousePosition = mainCamera.ScreenToWorldPoint(mousePosition.ReadValue<Vector2>());

        Vector2 lookDirection = worldMousePosition - rigidBody.position;
        float angle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg - 90f;
        rigidBody.rotation = angle;
    }

    private void Shoot(InputAction.CallbackContext obj)
    {
        this.GetComponent<Shooting>().Shoot(obj.ReadValueAsButton());
    }
}
