using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableFieldBehavior : MonoBehaviour
{
    public bool canInteract = false;

    public GameObject interactable;

    [HideInInspector]
    public OreBehavior ore;
    [HideInInspector]
    public GroundEnemyAIBehavior groundEnemy;
    [HideInInspector]
    public AirEnemyAIBehavior airEnemy;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("IronOre"))
        {
            ore = other.GetComponent<OreBehavior>();
            canInteract = true;
            interactable = other.gameObject;
        }
        else if(other.CompareTag("GroundEnemy"))
        {
            groundEnemy = other.GetComponent<GroundEnemyAIBehavior>();
            canInteract = true;
            interactable = other.gameObject;
        }
        else if(other.CompareTag("AirEnemy"))
        {
            airEnemy = other.GetComponent<AirEnemyAIBehavior>();
            canInteract = true;
            interactable = other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        canInteract = false;
        interactable = null;
        airEnemy = null;
        groundEnemy = null;
        ore = null;
    }
}
