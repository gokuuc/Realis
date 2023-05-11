using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class Player_Movement : MonoBehaviour
{
    public float speed = 3;
    public float rotationSpeed = 90;
    public float gravity = -20f;
    public float jumpSpeed = 15;

    [SerializeField] private Animator animator;
    CharacterController characterController;

    Vector3 moveVelocity;
    Vector3 TurnVelocity;

    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }
    private void Update()
    {
        var hInput = Input.GetAxis("Horizontal");
        var vInput = Input.GetAxis("Vertical");

        animator.SetFloat("Speed", Mathf.Abs(hInput + vInput));

        if (characterController.isGrounded)
        {
            animator.SetBool("Jump", false);
            moveVelocity = transform.forward * speed * vInput;
            TurnVelocity = transform.up * rotationSpeed * hInput;
            if (Input.GetButtonDown("Jump"))
            {
                moveVelocity.y = jumpSpeed;
                animator.SetBool("Jump", true);
            }
        }
        //Gravity
        moveVelocity.y += gravity * Time.deltaTime;
        characterController.Move(moveVelocity * Time.deltaTime);
        transform.Rotate(TurnVelocity * Time.deltaTime);
    }
}
