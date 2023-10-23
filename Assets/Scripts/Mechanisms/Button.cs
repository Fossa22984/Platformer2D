using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using DG.Tweening;

public class Button : AbstractPartMechanism
{
    [SerializeField] private AbstractPartMechanism _partMechanism;

    private void OnTriggerStay2D(Collider2D other)
    {
        Move(_endPoint);
        _partMechanism.Move(_partMechanism._endPoint);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Move(_startPoint);
        _partMechanism.Move(_partMechanism._startPoint);
    }
}