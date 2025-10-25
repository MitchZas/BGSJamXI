using UnityEngine;
using UnityEngine.InputSystem;
using System;
using UnityEngine.Scripting.APIUpdating;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10f;
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
        //Vector3 movement = new Vector3(move.x, 0, move.y);

        //transform.Translate(movement * speed * Time.deltaTime);

        rb.linearVelocity = new Vector3(move.x * moveSpeed * Time.deltaTime, 0f, move.y * moveSpeed * Time.deltaTime);
    }
}
