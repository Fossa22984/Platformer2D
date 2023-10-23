using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    [SerializeField] private string _idleLeftAnimation;
    [SerializeField] private string _idleRightAnimation;

    [SerializeField] private string _runLeftAnimation;
    [SerializeField] private string _runRightAnimation;

    [SerializeField] private string _jumpLeftAnimation;
    [SerializeField] private string _jumpRightAnimation;

    public void SwitchToIdle(float flip)
    {
        if (flip == 1) _animator.Play(_idleRightAnimation);
        else _animator.Play(_idleLeftAnimation);
    }

    public void SwitchToRun(float flip)
    {
        if (flip == 1) _animator.Play(_runRightAnimation);
        else _animator.Play(_runLeftAnimation);
    }

    public void SwitchToJump(float flip)
    {
        if (flip == 1) _animator.Play(_jumpRightAnimation);
        else _animator.Play(_jumpLeftAnimation);
    }
}
