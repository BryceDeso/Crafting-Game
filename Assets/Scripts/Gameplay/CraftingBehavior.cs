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

    public void CraftIronSword()
    {
        if (_player._ironHeld >= 5 && _player._oakWoodHeld >= 3)
        {
            _player._ironHeld -= 5;
            _player._oakWoodHeld -= 3;
            Instantiate(_ironSword, _itemSpawn.transform.position, _itemSpawn.transform.rotation);
        }
        else
        {
            Debug.Log("Not Enough Materials");
        }
    }

    public void CraftSword()
    {
        if (_player._ironHeld >= 5 && _player._oakWoodHeld >= 3)
        {
            _player._ironHeld -= 5;
            _player._oakWoodHeld -= 3;
            Instantiate(_ironSword, _itemSpawn.transform.position, _itemSpawn.transform.rotation);
        }
        else
        {
            Debug.Log("Not Enough Materials");
        }
    }

    public void CraftIronPickaxe()
    {
        if (_player._ironHeld >= 5 && _player._oakWoodHeld >= 3)
        {
            _player._ironHeld -= 5;
            _player._oakWoodHeld -= 3;
            Instantiate(_ironPickaxe, _itemSpawn.transform.position, _itemSpawn.transform.rotation);
        }
        else
        {
            Debug.Log("Not Enough Materials");
        }
    }

    public void CraftGoldPickaxe(float goldNeeded, float oakWoodNeeded)
    {
        if (_player._goldHeld >= goldNeeded && _player._oakWoodHeld >= oakWoodNeeded)
        {
            _player._goldHeld -= 5;
            _player._oakWoodHeld -= 3;
            Instantiate(_goldPickaxe, _itemSpawn.transform.position, _itemSpawn.transform.rotation);
        }
        else
        {
            Debug.Log("Not Enough Materials");
        }
    }
}
