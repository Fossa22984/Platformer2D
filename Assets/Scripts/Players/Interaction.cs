using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class Interaction : MonoBehaviour
{
    [field: SerializeField] public ElementType ElementType { get; private set; }

    [SerializeField] private LevelController _levelController;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.TryGetComponent<Interactable>(out var interactable))
        {
            if (interactable.InteractableType == InteractableType.Puddle && interactable.ElementType != ElementType)
            {
                AudioManager.Instance.PlaySfx(SfxType.Death);
                _levelController.ResetLevel();
            }
        }
        else if (other.gameObject.TryGetComponent<Door>(out var door) && door.ElementType == ElementType)
        {
            AudioManager.Instance.PlaySfx(SfxType.OpenDoor);
            _levelController.Win();
        }
        else if (other.gameObject.TryGetComponent<Diamond>(out var collectable) && collectable.ElementType == ElementType)
        {
            AudioManager.Instance.PlaySfx(SfxType.GetCoin);
            collectable.gameObject.SetActive(false);
            collectable.Collected = true;
        }
    }
}
