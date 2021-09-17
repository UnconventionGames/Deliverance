using UnityEngine;

[RequireComponent(typeof(Collider2D))]

public abstract class Interactable : MonoBehaviour
{
    public abstract void Interact();
    private void Reset()
    {
        GetComponent<Collider2D>().isTrigger = true;
    }
}