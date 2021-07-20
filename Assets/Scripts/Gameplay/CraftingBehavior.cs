using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftingBehavior : MonoBehaviour
{
    [SerializeField]
    private PlayerBehavior _player;

    public GameObject _itemSpawn;

    public GameObject _ironSword;

    public GameObject _goldSword;

    public GameObject _ironPickaxe;
    
    public GameObject _goldPickaxe;

    //Sword crafting

    public void CraftIronSword()
    {
        if (_player._ironHeld >= _ironSword.GetComponent<WeaponBehavior>()._ironNeeded && _player._oakWoodHeld >= _ironSword.GetComponent<WeaponBehavior>()._oakWoodNeeded)
        {
            _player._ironHeld -= _ironSword.GetComponent<WeaponBehavior>()._ironNeeded;
            _player._oakWoodHeld -= _ironSword.GetComponent<WeaponBehavior>()._oakWoodNeeded;
            Instantiate(_ironSword, _itemSpawn.transform.position, _itemSpawn.transform.rotation);
        }
        else
        {
            Debug.Log("Not Enough Materials");
        }
    }

    public void CraftGoldSword()
    {
        if (_player._goldHeld >= _goldSword.GetComponent<WeaponBehavior>()._goldNeeded && _player._oakWoodHeld >= _goldSword.GetComponent<WeaponBehavior>()._oakWoodNeeded)
        {
            _player._goldHeld -= _goldSword.GetComponent<WeaponBehavior>()._goldNeeded;
            _player._oakWoodHeld -= _goldSword.GetComponent<WeaponBehavior>()._oakWoodNeeded;
            Instantiate(_goldSword, _itemSpawn.transform.position, _itemSpawn.transform.rotation);
        }
        else
        {
            Debug.Log("Not Enough Materials");
        }
    }

    //Pickaxe crafting

    public void CraftIronPickaxe()
    {
        if (_player._ironHeld >= _ironPickaxe.GetComponent<PickaxeBehavior>()._ironNeeded && _player._oakWoodHeld >= _ironPickaxe.GetComponent<PickaxeBehavior>()._oakWoodNeeded)
        {
            _player._ironHeld -= _ironPickaxe.GetComponent<PickaxeBehavior>()._ironNeeded;
            _player._oakWoodHeld -= _ironPickaxe.GetComponent<PickaxeBehavior>()._oakWoodNeeded;
            Instantiate(_ironPickaxe, _itemSpawn.transform.position, _itemSpawn.transform.rotation);
        }
        else
        {
            Debug.Log("Not Enough Materials");
        }
    }

    public void CraftGoldPickaxe()
    {
        if (_player._goldHeld >= _goldPickaxe.GetComponent<PickaxeBehavior>()._goldNeeded && _player._oakWoodHeld >= _goldPickaxe.GetComponent<PickaxeBehavior>()._oakWoodNeeded)
        {
            _player._goldHeld -= _goldPickaxe.GetComponent<PickaxeBehavior>()._goldNeeded;
            _player._oakWoodHeld -= _goldPickaxe.GetComponent<PickaxeBehavior>()._oakWoodNeeded;
            Instantiate(_goldPickaxe, _itemSpawn.transform.position, _itemSpawn.transform.rotation);
        }
        else
        {
            Debug.Log("Not Enough Materials");
        }
    }

    //public void Craft()
    //{
    //    if (_player.1 >= _1.GetComponent<1Behavior>().1 && _player.1 >= _1.GetComponent<1Behavior>().1)
    //    {
    //        _player.1 -= 1;
    //        _player.1 -= 1;
    //        Instantiate(1, _itemSpawn.transform.position, _itemSpawn.transform.rotation);
    //    }
    //    else
    //    {
    //        Debug.Log("Not Enough Materials");
    //    }
    //}
}
