using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerB : MonoBehaviour
{









    void Start()
    {

    }

    [SerializeField] private Animator myAnimationController;
    private float moveDirection;
    private bool isMoving;



    void Update()
    {





            // Input Special Move

            if (Input.GetKey(KeyCode.E))
            {
                myAnimationController.SetBool("SPM", true);
            }
            else if (Input.GetKeyUp(KeyCode.E))
            {
                myAnimationController.SetBool("SPM", false);
            }



        // left
        if(Input.GetKey(KeyCode.A))
            {

            myAnimationController.SetBool("MoveL", true);

            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                myAnimationController.SetBool("RunL", true);
            }
            else if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                myAnimationController.SetBool("RunL", false);
            }
        }
            else
        {
            myAnimationController.SetBool("MoveL", false);
            myAnimationController.SetBool("RunL", false);

        }

        // right
        if (Input.GetKey(KeyCode.D))
            {

                myAnimationController.SetBool("Move", true);

                if (Input.GetKeyDown(KeyCode.LeftShift))
                {
                    myAnimationController.SetBool("Run", true);
                }
                else if (Input.GetKeyUp(KeyCode.LeftShift))
                {
                    myAnimationController.SetBool("Run", false);
                }
            }
            else
            {
                myAnimationController.SetBool("Move", false);
                myAnimationController.SetBool("Run", false);

            }


            // jump
            if (Input.GetKey(KeyCode.Space))
            {
                myAnimationController.SetBool("Jump", true);
            }
            else
            {
                myAnimationController.SetBool("Jump", false);
            }

        moveDirection = Input.GetAxis("Horizontal");
        if (moveDirection != 0)
        {
            isMoving = true;
        }
        else
        {
            isMoving = false;
        }

        LeftRight();

    }
    private void LeftRight()
    {
        if (moveDirection > 0)
        {
            gameObject.transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else if (moveDirection < 0)
        {
            gameObject.transform.eulerAngles = new Vector3(0, 180, 0);
        }
    }
}

