using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Door : MonoBehaviour
{
    [field: SerializeField] public ElementType ElementType { get; private set; }
    [field: SerializeField] public bool IsOpen { get; set; }

    [field: SerializeField] private Light2D _light;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.TryGetComponent<Interaction>(out var player) && player.ElementType == ElementType)
        {
            IsOpen = true;
            _light.intensity = 1f;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.TryGetComponent<Interaction>(out var player) && player.ElementType == ElementType)
        {
            IsOpen = false;
            _light.intensity = 0f;
        }
    }
}
