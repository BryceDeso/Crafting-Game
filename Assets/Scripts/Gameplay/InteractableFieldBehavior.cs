using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableFieldBehavior : MonoBehaviour
{
    public bool canInteract = false;

    public GameObject interactable;

    [HideInInspector]
    public OreBehavior ore;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("IronOre"))
        {
            ore = other.GetComponent<OreBehavior>();
            canInteract = true;
            interactable = other.gameObject;
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        ore = null;
        canInteract = false;
        interactable = null;
    }
}
