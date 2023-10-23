using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Switch : AbstractPartMechanism
{
    [SerializeField] private AbstractPartMechanism _partMechanism;
    [SerializeField] private bool _isOn;
    private void OnTriggerEnter2D(Collider2D other)
    {
        Move(_endPoint);

        if (_isOn) _partMechanism.Move(_partMechanism._endPoint);
        else _partMechanism.Move(_partMechanism._startPoint);
    }

    public override void Move(Transform endPoint)
    {
        _target.DORotateQuaternion(endPoint.rotation, _duration).SetEase(_ease);
    }
}