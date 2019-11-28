using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoviment : MonoBehaviour
{
    public PlayerControl controller;

    public float speed = 30f;
    float horizontalMove = 0f;
    bool jump = false;   

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * speed ;

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
    }

    private void FixedUpdate()
    {
        controller.Move(horizontalMove* Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
