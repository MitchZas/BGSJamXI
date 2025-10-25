using UnityEngine;
using UnityEngine.InputSystem;
using System;
using UnityEngine.Scripting.APIUpdating;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    private Vector2 move;
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
        Vector3 movement = new Vector3(move.x, 0, move.y);

        transform.Translate(movement * speed * Time.deltaTime);
    }
}
