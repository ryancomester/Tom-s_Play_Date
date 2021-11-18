using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharCrontroller : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 direction;
    private int desiredLane = 1;
    private PlayerAnim Anim;

    [Header("Character's running speed")]
    public float forwardSpeed = 10f;

    [Header("distance when switching lanes")]
    public float laneDistance = 2.5f;//distance between two lanes

    [Header("Character's jumping values")]
    public float jumpForce;
    private float gravity = -20f;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        Anim = GetComponent<PlayerAnim>();
    }

    void Update()
    {
        direction.z = forwardSpeed;

        /*taking the input which lane should Tom be in.*/
        if (controller.isGrounded)
        {
            direction.y = -1;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Jump();
            }
        }
        else
        {
            direction.y += gravity * Time.deltaTime;

        }

        /* when right arrow button is pressed ```desiredLane``` val adds one.
         * if the ```desiredLane```s value is 3 it is switched to 2.*/

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            desiredLane++;
            if(desiredLane == 3)
            {
                desiredLane = 2;
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            desiredLane--;
            if (desiredLane == -1)
            {
                desiredLane = 0;
            }
        }

        /* calculating where the player should be after taking the input. */
        Vector3 targetPosition = transform.position.z * transform.forward + transform.position.y * transform.up;

        if(desiredLane == 0)
        {
            targetPosition += Vector3.left * laneDistance;

        }else if(desiredLane == 2)
        {
            targetPosition += Vector3.right * laneDistance;
        }

        //transform.position = Vector3.Lerp(transform.position, targetPosition, 80 * Time.deltaTime);

        if (transform.position == targetPosition)
            return;
        Vector3 diff = targetPosition - transform.position;
        Vector3 moveDiff = diff.normalized * 25 * Time.deltaTime;
        if (moveDiff.sqrMagnitude < diff.sqrMagnitude)
            controller.Move(moveDiff);
        else
            controller.Move(diff);
    }

    private void FixedUpdate()
    {
        controller.Move(direction * Time.fixedDeltaTime);
    }

    private void Jump()
    {
        direction.y = jumpForce;
        Anim.JumpAmin();
    }

}
