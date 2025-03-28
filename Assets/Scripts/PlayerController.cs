using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Base Values")]
    public float walkingSpeed; //this will be the basic walk speed of the character
    public float runningSpeed; //this will serve as the character's maximum movement speed aka run
    public float jumpForce; //this will be the character's jumping power
    public float gravity; //this will serve as the world gravity

    [Header("Camera Reference")]
    public Camera playerCamera; //this will be referenced to the main camera/ the camera that will serve as the player's vision

    [Header("Camera Rotation")]
    public float lookSpeed = 2.0f; 
    public float lookXLimit = 45.0f; 

    [Header("Controller Properties")]
    CharacterController characterController; 
    Vector3 moveDirection = Vector3.zero; //direction of movement
    float rotationX = 0f; //charac rotation

    [Header("Movement Condition")]
    public bool canMove = true; //move

    void Start()
    {
        characterController = GetComponent<CharacterController>(); //calls characterController

        //this will lock and hide the cursor from the screen
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

        // We are grounded, so recalculate move direction based on axes
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        Vector3 right = transform.TransformDirection(Vector3.right);

        //press left shift to run
        bool isRunning = Input.GetKey(KeyCode.LeftShift); //this will return true, if the lShift is pressed

        //conditions for movement
        // if ? then : else
        float curSpeedX = canMove ? (isRunning ? runningSpeed : walkingSpeed) * Input.GetAxis("Vertical") : 0;
        float curSpeedY = canMove ? (isRunning ? runningSpeed : walkingSpeed) * Input.GetAxis("Horizontal") : 0;
        float movementDirectionY = moveDirection.y;
        moveDirection = (forward * curSpeedX) + (right * curSpeedY);

        //for the jumping condition
        if (Input.GetButton("Jump") && canMove && characterController.isGrounded)
        {
            moveDirection.y = jumpForce;
        }
        else
        {
            moveDirection.y = movementDirectionY;
        }

        // Apply gravity. Gravity is multiplied by deltaTime twice (once here, and once below
        // when the moveDirection is multiplied by deltaTime). This is because gravity should be applied
        // as an acceleration (ms^-2)
        if (!characterController.isGrounded)
        {
            //pull the object down
            moveDirection.y -= gravity * Time.deltaTime;
        }

        // Move the controller
        characterController.Move(moveDirection * Time.deltaTime);

        //Player and Camera rotation
        if (canMove)
        {
            rotationX += -Input.GetAxis("Mouse Y") * lookSpeed;
            rotationX = Mathf.Clamp(rotationX, -lookXLimit, lookXLimit); //this limits the angle of the x rotation
            playerCamera.transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
            transform.rotation *= Quaternion.Euler(0, Input.GetAxis("Mouse X") * lookSpeed, 0);
        }
    }
}
