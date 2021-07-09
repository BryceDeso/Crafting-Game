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
    public OreBehavior ore;
    [HideInInspector]
    public GroundEnemyAIBehavior groundEnemy;
    [HideInInspector]
    public AirEnemyAIBehavior airEnemy;

    private void Update()
    {
        Interact();
    }

    private void Interact()
    {
        RaycastHit hit;

        Debug.DrawRay(playerCamera.transform.position, playerCamera.transform.forward * range, Color.white);

        if (Physics.Raycast(playerCamera.transform.position, playerCamera.transform.forward, out hit, range))
        {
            if (hit.transform.CompareTag("IronOre"))
            {
                ore = hit.transform.GetComponent<OreBehavior>();
                canInteract = true;
                if(Input.GetButtonDown("Fire1"))
                {
                    ore.currentHealth -= 1;
                    Debug.Log("Hit ore");
                }
            }
            else if (hit.transform.CompareTag("GroundEnemy"))
            {
                groundEnemy = hit.transform.GetComponent<GroundEnemyAIBehavior>();
                canInteract = true;
                if (Input.GetButtonDown("Fire1"))
                {
                    groundEnemy.health -= 1;
                    Debug.Log("Hit ground enemy");
                }
            }
            else if (hit.transform.CompareTag("AirEnemy"))
            {
                airEnemy = hit.transform.GetComponent<AirEnemyAIBehavior>();
                canInteract = true;
                if (Input.GetButtonDown("Fire1"))
                {
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {

    }

    private void OnTriggerExit(Collider other)
    {
    }
}
