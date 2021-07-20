using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableFieldBehavior : MonoBehaviour
{
    public bool canInteract = false;

    public float range;

    [SerializeField]
    private Camera playerCamera;

    [HideInInspector]
    public float _ironMined;

    public bool canCraft;
    public bool canFight;

    [HideInInspector]
    public OreBehavior ore;
    [HideInInspector]
    public GroundEnemyAIBehavior groundEnemy;
    [HideInInspector]
    public AirEnemyAIBehavior airEnemy;
    [HideInInspector]
    public WeaponBehavior weapon;
    [HideInInspector]
    public PickaxeBehavior pickaxe;

    [SerializeField]
    private GameObject _currentInteraction;

    private void Update()
    {
        Interact();
    }

    private void Interact()
    {
        RaycastHit hit;

        Debug.DrawRay(playerCamera.transform.position, playerCamera.transform.forward * range, Color.white);

        if (_currentInteraction)
        {
            canInteract = false;
            ore = null;
            groundEnemy = null;
            airEnemy = null;
            weapon = null;
            pickaxe = null;
            canFight = false;
            canCraft = false;
            _currentInteraction = null;
        }

        if (Physics.Raycast(playerCamera.transform.position, playerCamera.transform.forward, out hit, range))
        {
            if(hit.transform.CompareTag("IronOre"))
            {
                ore = hit.transform.GetComponent<OreBehavior>();
                canInteract = true;
                Debug.Log("Looking at ore");
                _currentInteraction = hit.transform.gameObject;
            }
            else if(hit.transform.CompareTag("GroundEnemy"))
            {
                groundEnemy = hit.transform.GetComponent<GroundEnemyAIBehavior>();
                canInteract = true;
                Debug.Log("Looking at ground enemy");
                _currentInteraction = hit.transform.gameObject;
            }
            //else if(hit.transform.CompareTag("AirEnemy"))
            //{
            //    canInteract = true;
            //    airEnemy = hit.transform.GetComponent<AirEnemyAIBehavior>();
            //    _currentInteraction = hit.transform.gameObject;
            //}
            else if(hit.transform.CompareTag("CraftingTable"))
            {
                canCraft = true;
                Debug.Log("Looking at carfting bench");
                _currentInteraction = hit.transform.gameObject;
            }
            else if(hit.transform.CompareTag("Weapon"))
            {
                canInteract = true;
                weapon = hit.transform.GetComponent<WeaponBehavior>();
                _currentInteraction = hit.transform.gameObject;
            }
            else if (hit.transform.CompareTag("Pickaxe"))
            {
                canInteract = true;
                pickaxe = hit.transform.GetComponent<PickaxeBehavior>();
                _currentInteraction = hit.transform.gameObject;
            }
        }
    }
}
