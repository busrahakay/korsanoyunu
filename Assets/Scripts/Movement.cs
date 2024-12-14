using System.Collections;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 2, gravity = -0.8f, jumpPower;
    Vector3 velocity;
    CharacterController charactercontroller;
    Quaternion rotation;
    Animator animator;

    private void Awake()
    {
        charactercontroller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }
    public void SlidePerformed()
    {
    }
    public void RunCancled()
    {
    }
    private void Update()
    {
        charactercontroller.Move(moveSpeed * velocity * Time.deltaTime);

        rotation = Camera.main.transform.rotation;
        rotation.x = 0;
        rotation.z = 0;
        //transform.rotation = Quaternion.Slerp(transform.rotation, rotation, 0.2f);

        if (!charactercontroller.isGrounded)
        {
            velocity.y += gravity;
        }
    }
    public void Move(float x, float y)
    {
        velocity = transform.forward * y + transform.right * x;
        animator.SetFloat("Horizontal", y);
        animator.SetFloat("Vertical", x);
    }
    public void Jump()
    {
        if (charactercontroller.isGrounded)
        {
            velocity.y = 0;
            velocity.y += jumpPower;
        }
    }
}
