using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Motion2D : AbstractMotion2D
{
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
            Move(Vector3.left);
        else if (Input.GetKey(KeyCode.RightArrow))
            Move(Vector3.right);

        if (!Input.anyKey) Move(new Vector3(0, 0, 0));
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) && Mathf.Abs(_rigidbody.velocity.y) < 0.001f)
            Jump();

        if (!_onPlate)
            _onGround = Mathf.Abs(_rigidbody.velocity.y) < 0.001f ? true : false;
    }
}