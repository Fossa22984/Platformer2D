using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public abstract class AbstractPartMechanism : MonoBehaviour
{
    [field: SerializeField] public Transform _target { get; private set; }
    [field: SerializeField] public Transform _startPoint { get; private set; }
    [field: SerializeField] public Transform _endPoint { get; private set; }

    [field: SerializeField] protected Ease _ease;
    [field: SerializeField] protected float _duration;

    public virtual void Move(Transform endPoint)
    {
        _target.DOMove(endPoint.position, _duration).SetEase(_ease);
    }
}
