using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    private float _health;

    private float _armor;

    [SerializeField]
    private InteractableFieldBehavior _interactionField;

    [SerializeField]
    private float _ironHeld;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerActions();
    }

    private void PlayerActions()
    {
        Mining();
    }

    private void Mining()
    {
        if(_interactionField.canInteract == true)
        {
            if (_interactionField.interactable.CompareTag("IronOre") && _interactionField.ore.canCollect == true)
            {
                if (Input.GetButtonDown("Fire1"))
                {
                    _ironHeld++;
                    _interactionField.ore.currentHealth -= 1;
                }
            }
        }
    }
}
