using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractMotion2D : MonoBehaviour
{
    [SerializeField] protected Rigidbody2D _rigidbody;
    [SerializeField] protected AnimationController _animationController;

    [SerializeField] protected float _force;
    [SerializeField] protected float _jumpForce;

    protected float _flip;
    protected bool _onGround;
    protected bool _onPlate;

    void Start()
    {
        _flip = 1;
        _onGround = true;
    }

    protected void Move(Vector3 direction)
    {
        float moveInput = direction.x;
        transform.position += direction * _force * Time.deltaTime;

        if (moveInput != 0) _flip = moveInput;

        if (!_onGround)
        {
            _animationController.SwitchToJump(_flip);
            return;
        }

        if (moveInput == 0) _animationController.SwitchToIdle(_flip);
        else _animationController.SwitchToRun(_flip);

    }

    protected void Jump()
    {
        _animationController.SwitchToJump(_flip);
        AudioManager.Instance.PlaySfx(SfxType.Jump);

        _rigidbody.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
    }


    protected void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Plate")
        {
            _onGround = true;
            _onPlate = true;
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Plate")
            _onPlate = false;
    }
}