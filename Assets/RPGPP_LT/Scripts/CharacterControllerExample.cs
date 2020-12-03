using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerExample : MonoBehaviour
{
    private float horizontalInput = 0;
    private float verticalInput = 0;

    public float movementSpeed = 5f;

    public CharacterController myCharacterController;

    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        float xMovement = horizontalInput * movementSpeed * Time.deltaTime;
        float zMovement = verticalInput * movementSpeed * Time.deltaTime;

        Vector3 motion = new Vector3(xMovement, 0f, zMovement);
        //Agregar fuerza de gravedad
        motion.y += GRAVITY * Time.deltaTime;

        //Convertir direccion local a direccion global
        Vector3 finalMove = transform.TransformDirection(motion);

        //Movimiento final
        myCharacterController.Move(finalMove);
    }

    public const float GRAVITY = -9.8f;
}
