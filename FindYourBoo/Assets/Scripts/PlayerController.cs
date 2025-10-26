using UnityEngine;
using UnityEngine.InputSystem;
using System;
using UnityEngine.Scripting.APIUpdating;

public class PlayerController : MonoBehaviour
{
    [SerializeField] public float moveSpeed = 10f;
    private Vector3 move;
    [SerializeField] private Rigidbody rb;
    //private float rotateSpeed = 0.15f;

    public void OnMove(InputAction.CallbackContext context)
    {
        move = context.ReadValue<Vector2>();
    }

    private void Update()
    {
        MovePlayer();
    }

    public void MovePlayer()
    {
        rb.linearVelocity = new Vector3(move.x * moveSpeed * Time.deltaTime, move.y * moveSpeed * Time.deltaTime, 0f);
    }
}
