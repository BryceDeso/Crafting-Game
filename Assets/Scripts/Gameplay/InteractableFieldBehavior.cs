using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableFieldBehavior : MonoBehaviour
{
    public bool canInteract = false;

    public float range;

    [SerializeField]
    private Camera playerCamera;

    public bool canCraft;

    [HideInInspector]
    public bool inInventory;

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
    [HideInInspector]
    public ArmorBehavior armor;
    [HideInInspector]
    public GameObject healthPotion;

    [SerializeField]
    private GameObject _currentInteraction;

    private void Start()
    {
        inInventory = false;
    }

    private void Update()
    {
        Interact();
    }

    private void Interact()
    {
        if (_currentInteraction)
        {
            canInteract = false;
            ore = null;
            groundEnemy = null;
            airEnemy = null;
            weapon = null;
            pickaxe = null;
            armor = null;
            canCraft = false;
            _currentInteraction = null;
        }

        if (inInventory == false)
        {
            RaycastHit hit;

            Debug.DrawRay(playerCamera.transform.position, playerCamera.transform.forward * range, Color.white);

            if (Physics.Raycast(playerCamera.transform.position, playerCamera.transform.forward, out hit, range))
            {
                if (hit.transform.CompareTag("Ore") || hit.transform.CompareTag("Wood"))
                {
                    ore = hit.transform.GetComponent<OreBehavior>();
                    canInteract = true;
                    Debug.Log("Looking at " + ore.name + " ore");
                    _currentInteraction = hit.transform.gameObject;
                }
                else if (hit.transform.CompareTag("GroundEnemy"))
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
                else if (hit.transform.CompareTag("CraftingTable"))
                {
                    canCraft = true;
                    Debug.Log("Looking at crafting bench");
                    _currentInteraction = hit.transform.gameObject;
                }
                else if (hit.transform.CompareTag("Weapon"))
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
                else if (hit.transform.CompareTag("Armor"))
                {
                    canInteract = true;
                    armor = hit.transform.GetComponent<ArmorBehavior>();
                    _currentInteraction = hit.transform.gameObject;
                }
            }
        }
    }
}
