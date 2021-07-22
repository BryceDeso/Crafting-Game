using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftingBehavior : MonoBehaviour
{
    [SerializeField]
    private PlayerBehavior _player;

    public GameObject _itemSpawn;

    public GameObject ironSword;

    public GameObject ironPickaxe;

    public GameObject ironHelmet;

    public GameObject ironChestplate;

    public GameObject ironLeggings;

    public GameObject ironBoots;

    public GameObject goldSword;
    
    public GameObject goldPickaxe;

    //Sword crafting

    public void CraftIronSword()
    {
        if (_player._ironHeld >= ironSword.GetComponent<WeaponBehavior>()._ironNeeded && _player._oakWoodHeld >= ironSword.GetComponent<WeaponBehavior>()._oakWoodNeeded)
        {
            _player._ironHeld -= ironSword.GetComponent<WeaponBehavior>()._ironNeeded;
            _player._oakWoodHeld -= ironSword.GetComponent<WeaponBehavior>()._oakWoodNeeded;
            Instantiate(ironSword, _itemSpawn.transform.position, _itemSpawn.transform.rotation);
        }
        else
        {
            Debug.Log("Not Enough Materials");
        }
    }

    public void CraftGoldSword()
    {
        if (_player._goldHeld >= goldSword.GetComponent<WeaponBehavior>()._goldNeeded && _player._oakWoodHeld >= goldSword.GetComponent<WeaponBehavior>()._oakWoodNeeded)
        {
            _player._goldHeld -= goldSword.GetComponent<WeaponBehavior>()._goldNeeded;
            _player._oakWoodHeld -= goldSword.GetComponent<WeaponBehavior>()._oakWoodNeeded;
            Instantiate(goldSword, _itemSpawn.transform.position, _itemSpawn.transform.rotation);
        }
        else
        {
            Debug.Log("Not Enough Materials");
        }
    }

    //Pickaxe crafting

    public void CraftIronPickaxe()
    {
        if (_player._ironHeld >= ironPickaxe.GetComponent<PickaxeBehavior>()._ironNeeded && _player._oakWoodHeld >= ironPickaxe.GetComponent<PickaxeBehavior>()._oakWoodNeeded)
        {
            _player._ironHeld -= ironPickaxe.GetComponent<PickaxeBehavior>()._ironNeeded;
            _player._oakWoodHeld -= ironPickaxe.GetComponent<PickaxeBehavior>()._oakWoodNeeded;
            Instantiate(ironPickaxe, _itemSpawn.transform.position, _itemSpawn.transform.rotation);
        }
        else
        {
            Debug.Log("Not Enough Materials");
        }
    }

    public void CraftGoldPickaxe()
    {
        if (_player._goldHeld >= goldPickaxe.GetComponent<PickaxeBehavior>()._goldNeeded && _player._oakWoodHeld >= goldPickaxe.GetComponent<PickaxeBehavior>()._oakWoodNeeded)
        {
            _player._goldHeld -= goldPickaxe.GetComponent<PickaxeBehavior>()._goldNeeded;
            _player._oakWoodHeld -= goldPickaxe.GetComponent<PickaxeBehavior>()._oakWoodNeeded;
            Instantiate(goldPickaxe, _itemSpawn.transform.position, _itemSpawn.transform.rotation);
        }
        else
        {
            Debug.Log("Not Enough Materials");
        }
    }

    //Armor crafting

    public void CraftIronHelmet()
    {
        if (_player._ironHeld >= ironHelmet.GetComponent<ArmorBehavior>()._ironNeeded)
        {
            _player._ironHeld -= ironHelmet.GetComponent<ArmorBehavior>()._ironNeeded;
            Instantiate(ironHelmet, _itemSpawn.transform.position, _itemSpawn.transform.rotation);
        }
        else
        {
            Debug.Log("Not Enough Materials");
        }
    }

    public void CraftIronChestplate()
    {
        if (_player._ironHeld >= ironChestplate.GetComponent<ArmorBehavior>()._ironNeeded)
        {
            _player._ironHeld -= ironChestplate.GetComponent<ArmorBehavior>()._ironNeeded;
            Instantiate(ironChestplate, _itemSpawn.transform.position, _itemSpawn.transform.rotation);
        }
        else
        {
            Debug.Log("Not Enough Materials");
        }
    }

    public void CraftIronLeggings()
    {
        if (_player._ironHeld >= ironLeggings.GetComponent<ArmorBehavior>()._ironNeeded)
        {
            _player._ironHeld -= ironLeggings.GetComponent<ArmorBehavior>()._ironNeeded;
            Instantiate(ironLeggings, _itemSpawn.transform.position, _itemSpawn.transform.rotation);
        }
        else
        {
            Debug.Log("Not Enough Materials");
        }
    }

    public void CraftIronBoots()
    {
        if (_player._ironHeld >= ironBoots.GetComponent<ArmorBehavior>()._ironNeeded)
        {
            _player._ironHeld -= ironBoots.GetComponent<ArmorBehavior>()._ironNeeded;
            Instantiate(ironBoots, _itemSpawn.transform.position, _itemSpawn.transform.rotation);
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
