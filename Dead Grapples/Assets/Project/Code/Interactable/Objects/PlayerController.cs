using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public Vector3 direction;
    public float speed = 1.0f;
    void Start()
    {
        direction = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction.normalized * speed;
        direction = Vector3.zero;
    }

    public void MoveForward(InputAction.CallbackContext context)
    {
        if (context.ReadValue<float>() > 0.0f)
        {
            direction += Vector3.forward;
        }
    }
}
