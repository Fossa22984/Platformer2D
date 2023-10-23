using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Motion2D : AbstractMotion2D
{
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
            Move(Vector3.left);
        else if (Input.GetKey(KeyCode.D))
            Move(Vector3.right);

        if (!Input.anyKey) Move(new Vector3(0, 0, 0));
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W) && Mathf.Abs(_rigidbody.velocity.y) < 0.001f)
            Jump();

        if (!_onPlate)
            _onGround = Mathf.Abs(_rigidbody.velocity.y) < 0.001f ? true : false;
    }
}