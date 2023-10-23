using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreCollision : MonoBehaviour
{
    [SerializeField] private Collider2D _collider1;
    [SerializeField] private Collider2D _collider2;

    void Start()
    {
        Physics2D.IgnoreCollision(_collider1, _collider2);
    }
}
