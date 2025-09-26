using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float speed;
    [SerializeField] private float rotationSpeed;
    private Vector2 movementValue;
    private float lookValue;
    private Rigidbody rb;
    //im keeping it as rb and not rigidbody despite what the book said because im super prone to spelling errors

    private void Awake()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        rb = GetComponent<Rigidbody>();
    }

    public void OnMove(InputValue value)
    {
        movementValue = value.Get<Vector2>() * speed;
    }

    public void OnLook(InputValue value)
    {
        lookValue = value.Get<Vector2>().x * rotationSpeed;
    }

    void Update()
    {
        // =========== With Rigidbodies ============\\
        rb.AddRelativeForce(movementValue.x * Time.deltaTime, 0, movementValue.y * Time.deltaTime);
        rb.AddRelativeTorque(0, lookValue * Time.deltaTime, 0);

        // =========== New Input System ============\\
        // transform.Translate(movementValue.x * Time.deltaTime, 0, movementValue.y * Time.deltaTime);
        // transform.Rotate(0, lookValue * Time.deltaTime, 0);

        // =========== Old Input System ============\\
        // deleted for clarity!

    }
}
