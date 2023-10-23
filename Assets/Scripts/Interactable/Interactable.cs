using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    [field: SerializeField] public InteractableType InteractableType { get; private set; }
    [field: SerializeField] public ElementType ElementType { get; private set; }
}