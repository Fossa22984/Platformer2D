using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamond : MonoBehaviour
{
    [field: SerializeField] public ElementType ElementType { get; private set; }
    [field: SerializeField] public bool Collected { get; set; }
}
