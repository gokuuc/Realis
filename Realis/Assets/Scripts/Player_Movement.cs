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

    private bool jump;

    [SerializeField] private Animator animator;
    [SerializeField] private Joystick _joystick;
    CharacterController characterController;

    Vector3 moveVelocity;
    Vector3 TurnVelocity;

    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }
    private void Update()
    {
        var HorizontalJ = _joystick.Horizontal;
        var VerticalJ = _joystick.Vertical;

        animator.SetFloat("Speed", Mathf.Abs(HorizontalJ + VerticalJ));

        if (characterController.isGrounded)
        {
            animator.SetBool("Jump", false);
            moveVelocity = transform.forward * speed * VerticalJ;
            TurnVelocity = transform.up * rotationSpeed * HorizontalJ;
            if (jump == true)
            {
                moveVelocity.y = jumpSpeed;
                animator.SetBool("Jump", true);
                jump = false;
            }
        }
        //Gravity
        moveVelocity.y += gravity * Time.deltaTime;
        characterController.Move(moveVelocity * Time.deltaTime);
        transform.Rotate(TurnVelocity * Time.deltaTime);
    }

    public void Jump()
    {
        jump = true;
    }
}
