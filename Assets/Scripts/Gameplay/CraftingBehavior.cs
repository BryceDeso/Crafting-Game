using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftingBehavior : MonoBehaviour
{
    [SerializeField]
    private PlayerBehavior _player;

    [SerializeField]
    private GameObject _itemSpawn;

    [SerializeField]
    private GameObject _ironSword;

    [SerializeField]
    private GameObject _ironPickaxe;

    [SerializeField]
    private GameObject _goldPickaxe;

    //[SerializeField]
    //private GameObject ;

    // Update is called once per frame
    void Update()
    {
        Crafting();
    }

    private void Crafting()
    {
        if(_player._interactionField.canCraft == true)
        {
            if (_player._ironHeld >= 5 && _player._oakWoodHeld >= 3)
            {
                if (Input.GetButtonDown("Fire1"))
                {
                    _player._ironHeld -= 5;
                    _player._oakWoodHeld -= 3;
                    Instantiate(_ironSword, _itemSpawn.transform.position, _itemSpawn.transform.rotation);
                }
            }
            if (_player._ironHeld >= 5 && _player._oakWoodHeld >= 3)
            {

                if (Input.GetButtonDown("Fire2"))
                {
                    _player._goldHeld -= 5;
                    _player._oakWoodHeld -= 3;
                    Instantiate(_goldPickaxe, _itemSpawn.transform.position, _itemSpawn.transform.rotation);
                }
            }
        }
    }
}
