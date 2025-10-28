using UnityEngine;
using UnityEngine.InputSystem;
using System;
using UnityEngine.Scripting.APIUpdating;
using Unity.VisualScripting;

public class PlayerController : MonoBehaviour
{
    [SerializeField] public float moveSpeed = 10f;
    private Vector3 move;
    [SerializeField] private Rigidbody rb;

    public void OnMove(InputAction.CallbackContext context)
    {
        move = context.ReadValue<Vector2>();
    }
    
    private void FixedUpdate()
    {
        MovePlayer();
    }

    public void MovePlayer()
    {
        rb.linearVelocity = new Vector3(move.x * moveSpeed * Time.deltaTime, move.y * moveSpeed * Time.deltaTime, 0f);
    }
}
