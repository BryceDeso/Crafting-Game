using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftingBehavior : MonoBehaviour
{
    [SerializeField]
    private PlayerBehavior _player;

    public GameObject _itemSpawn;

    //Swords
    public GameObject ironSword;

    public GameObject goldSword;

    public GameObject silverSword;

    public GameObject diamondSword;

    public GameObject bloodstoneSword;

    public GameObject chlorophyteSword;

    public GameObject mithrilSword;

    //Pickaxes
    public GameObject ironPickaxe;

    public GameObject goldPickaxe;

    public GameObject silverPickaxe;

    public GameObject diamondPickaxe;

    public GameObject bloodstonePickaxe;

    public GameObject chlorophytePickaxe;

    public GameObject mithrilPickaxe;

    //Helmets
    public GameObject ironHelmet;

    public GameObject goldHelmet;

    public GameObject silverHelmet;

    public GameObject diamondHelmet;

    public GameObject bloodstoneHelmet;

    public GameObject chlorophyteHelmet;

    public GameObject mithrilHelmet;

    //Chestplates
    public GameObject ironChestplate;

    public GameObject goldChestplate;

    public GameObject silverChestplate;

    public GameObject diamondChestplate;

    public GameObject bloodstoneChestplate;

    public GameObject chlorophyteChestplate;

    public GameObject mithrilChestplate;

    //Leggings
    public GameObject ironLeggings;

    public GameObject goldLeggings;

    public GameObject silverLeggings;

    public GameObject diamondLeggings;

    public GameObject bloodstoneLeggings;

    public GameObject chlorophyteLeggings;

    public GameObject mithrilLeggings;

    //Boots
    public GameObject ironBoots;

    public GameObject goldBoots;

    public GameObject silverBoots;

    public GameObject diamondBoots;

    public GameObject bloodstoneBoots;

    public GameObject chlorophyteBoots;

    public GameObject mithrilBoots;

    //Sword Crafting
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

    public void CraftSilverSword()
    {
        if (_player._silverHeld >= silverSword.GetComponent<WeaponBehavior>()._silverNeeded && _player._oakWoodHeld >= silverSword.GetComponent<WeaponBehavior>()._oakWoodNeeded)
        {
            _player._silverHeld -= silverSword.GetComponent<WeaponBehavior>()._silverNeeded;
            _player._oakWoodHeld -= silverSword.GetComponent<WeaponBehavior>()._oakWoodNeeded;
            Instantiate(silverSword, _itemSpawn.transform.position, _itemSpawn.transform.rotation);
        }
        else
        {
            Debug.Log("Not Enough Materials");
        }
    }

    public void CraftDiamondSword()
    {
        if (_player._diamondsHeld >= diamondSword.GetComponent<WeaponBehavior>()._diamondsNeeded && _player._oakWoodHeld >= diamondSword.GetComponent<WeaponBehavior>()._oakWoodNeeded)
        {
            _player._diamondsHeld -= diamondSword.GetComponent<WeaponBehavior>()._diamondsNeeded;
            _player._oakWoodHeld -= diamondSword.GetComponent<WeaponBehavior>()._oakWoodNeeded;
            Instantiate(diamondSword, _itemSpawn.transform.position, _itemSpawn.transform.rotation);
        }
        else
        {
            Debug.Log("Not Enough Materials");
        }
    }

    public void CraftBloodStoneSword()
    {
        if (_player._bloodstoneHeld >= bloodstoneSword.GetComponent<WeaponBehavior>()._bloodstoneNeeded && _player._oakWoodHeld >= bloodstoneSword.GetComponent<WeaponBehavior>()._oakWoodNeeded)
        {
            _player._bloodstoneHeld -= bloodstoneSword.GetComponent<WeaponBehavior>()._bloodstoneNeeded;
            _player._oakWoodHeld -= bloodstoneSword.GetComponent<WeaponBehavior>()._oakWoodNeeded;
            Instantiate(bloodstoneSword, _itemSpawn.transform.position, _itemSpawn.transform.rotation);
        }
        else
        {
            Debug.Log("Not Enough Materials");
        }
    }

    public void CraftChlorophyteSword()
    {
        if (_player._chlorophyteHeld >= chlorophyteSword.GetComponent<WeaponBehavior>()._chlorophyteNeeded && _player._jungleWoodHeld >= chlorophyteSword.GetComponent<WeaponBehavior>()._jungleWoodNeeded)
        {
            _player._chlorophyteHeld -= chlorophyteSword.GetComponent<WeaponBehavior>()._chlorophyteNeeded;
            _player._jungleWoodHeld -= chlorophyteSword.GetComponent<WeaponBehavior>()._jungleWoodNeeded;
            Instantiate(chlorophyteSword, _itemSpawn.transform.position, _itemSpawn.transform.rotation);
        }
        else
        {
            Debug.Log("Not Enough Materials");
        }
    }

    public void CraftMithrilSword()
    {
        if (_player._mithrilHeld >= mithrilSword.GetComponent<WeaponBehavior>()._mithrilNeeded && _player._ashWoodHeld >= mithrilSword.GetComponent<WeaponBehavior>()._ashWoodNeeded)
        {
            _player._mithrilHeld -= mithrilSword.GetComponent<WeaponBehavior>()._mithrilNeeded;
            _player._ashWoodHeld -= mithrilSword.GetComponent<WeaponBehavior>()._ashWoodNeeded;
            Instantiate(mithrilSword, _itemSpawn.transform.position, _itemSpawn.transform.rotation);
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

    public void CraftSilverPickaxe()
    {
        if (_player._silverHeld >= silverPickaxe.GetComponent<PickaxeBehavior>()._silverNeeded && _player._oakWoodHeld >= silverPickaxe.GetComponent<PickaxeBehavior>()._oakWoodNeeded)
        {
            _player._silverHeld -= silverPickaxe.GetComponent<PickaxeBehavior>()._silverNeeded;
            _player._oakWoodHeld -= silverPickaxe.GetComponent<PickaxeBehavior>()._oakWoodNeeded;
            Instantiate(silverPickaxe, _itemSpawn.transform.position, _itemSpawn.transform.rotation);
        }
        else
        {
            Debug.Log("Not Enough Materials");
        }
    }

    public void CraftDiamondPickaxe()
    {
        if (_player._diamondsHeld >= diamondPickaxe.GetComponent<PickaxeBehavior>()._diamondsNeeded && _player._oakWoodHeld >= diamondPickaxe.GetComponent<PickaxeBehavior>()._oakWoodNeeded)
        {
            _player._diamondsHeld -= diamondPickaxe.GetComponent<PickaxeBehavior>()._diamondsNeeded;
            _player._oakWoodHeld -= diamondPickaxe.GetComponent<PickaxeBehavior>()._oakWoodNeeded;
            Instantiate(diamondPickaxe, _itemSpawn.transform.position, _itemSpawn.transform.rotation);
        }
        else
        {
            Debug.Log("Not Enough Materials");
        }
    }

    public void CraftBloodstonePickaxe()
    {
        if (_player._bloodstoneHeld >= bloodstonePickaxe.GetComponent<PickaxeBehavior>()._bloodstoneNeeded && _player._oakWoodHeld >= bloodstonePickaxe.GetComponent<PickaxeBehavior>()._oakWoodNeeded)
        {
            _player._bloodstoneHeld -= bloodstonePickaxe.GetComponent<PickaxeBehavior>()._bloodstoneNeeded;
            _player._oakWoodHeld -= bloodstonePickaxe.GetComponent<PickaxeBehavior>()._oakWoodNeeded;
            Instantiate(bloodstonePickaxe, _itemSpawn.transform.position, _itemSpawn.transform.rotation);
        }
        else
        {
            Debug.Log("Not Enough Materials");
        }
    }

    public void CraftChlorophytePickaxe()
    {
        if (_player._chlorophyteHeld >= chlorophytePickaxe.GetComponent<PickaxeBehavior>()._chlorophyteNeeded && _player._oakWoodHeld >= chlorophytePickaxe.GetComponent<PickaxeBehavior>()._oakWoodNeeded)
        {
            _player._chlorophyteHeld -= chlorophytePickaxe.GetComponent<PickaxeBehavior>()._chlorophyteNeeded;
            _player._oakWoodHeld -= chlorophytePickaxe.GetComponent<PickaxeBehavior>()._oakWoodNeeded;
            Instantiate(chlorophytePickaxe, _itemSpawn.transform.position, _itemSpawn.transform.rotation);
        }
        else
        {
            Debug.Log("Not Enough Materials");
        }
    }

    public void CraftMithrilPickaxe()
    {
        if (_player._mithrilHeld >= mithrilPickaxe.GetComponent<PickaxeBehavior>()._mithrilNeeded && _player._ashWoodHeld >= mithrilPickaxe.GetComponent<PickaxeBehavior>()._ashWoodNeeded)
        {
            _player._mithrilHeld -= mithrilPickaxe.GetComponent<PickaxeBehavior>()._mithrilNeeded;
            _player._ashWoodHeld -= mithrilPickaxe.GetComponent<PickaxeBehavior>()._ashWoodNeeded;
            Instantiate(mithrilPickaxe, _itemSpawn.transform.position, _itemSpawn.transform.rotation);
        }
        else
        {
            Debug.Log("Not Enough Materials");
        }
    }

    //Helemt crafting
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

    public void CraftGoldHelmet()
    {
        if (_player._goldHeld >= goldHelmet.GetComponent<ArmorBehavior>()._goldNeeded)
        {
            _player._goldHeld -= goldHelmet.GetComponent<ArmorBehavior>()._goldNeeded;
            Instantiate(goldHelmet, _itemSpawn.transform.position, _itemSpawn.transform.rotation);
        }
        else
        {
            Debug.Log("Not Enough Materials");
        }
    }

    public void CraftSilverHelmet()
    {
        if (_player._silverHeld >= silverHelmet.GetComponent<ArmorBehavior>()._silverNeeded)
        {
            _player._silverHeld -= silverHelmet.GetComponent<ArmorBehavior>()._silverNeeded;
            Instantiate(silverHelmet, _itemSpawn.transform.position, _itemSpawn.transform.rotation);
        }
        else
        {
            Debug.Log("Not Enough Materials");
        }
    }

    public void CraftDiamondHelmet()
    {
        if (_player._diamondsHeld >= diamondHelmet.GetComponent<ArmorBehavior>()._diamondsNeeded)
        {
            _player._diamondsHeld -= diamondHelmet.GetComponent<ArmorBehavior>()._diamondsNeeded;
            Instantiate(diamondHelmet, _itemSpawn.transform.position, _itemSpawn.transform.rotation);
        }
        else
        {
            Debug.Log("Not Enough Materials");
        }
    }

    public void CraftBloodStoneHelmet()
    {
        if (_player._bloodstoneHeld >= bloodstoneHelmet.GetComponent<ArmorBehavior>()._bloodstoneNeeded)
        {
            _player._bloodstoneHeld -= bloodstoneHelmet.GetComponent<ArmorBehavior>()._bloodstoneNeeded;
            Instantiate(bloodstoneHelmet, _itemSpawn.transform.position, _itemSpawn.transform.rotation);
        }
        else
        {
            Debug.Log("Not Enough Materials");
        }
    }

    public void CraftChlorophyteHelmet()
    {
        if (_player._chlorophyteHeld >= chlorophyteHelmet.GetComponent<ArmorBehavior>()._chlorophyteNeeded)
        {
            _player._chlorophyteHeld -= chlorophyteHelmet.GetComponent<ArmorBehavior>()._chlorophyteNeeded;
            Instantiate(chlorophyteHelmet, _itemSpawn.transform.position, _itemSpawn.transform.rotation);
        }
        else
        {
            Debug.Log("Not Enough Materials");
        }
    }
    public void CraftMithrilHelmet()
    {
        if (_player._mithrilHeld >= mithrilHelmet.GetComponent<ArmorBehavior>()._mithrilNeeded)
        {
            _player._mithrilHeld -= mithrilHelmet.GetComponent<ArmorBehavior>()._mithrilNeeded;
            Instantiate(mithrilHelmet, _itemSpawn.transform.position, _itemSpawn.transform.rotation);
        }
        else
        {
            Debug.Log("Not Enough Materials");
        }
    }


    //Chestplate Crafting
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

    public void CraftGoldChestplate()
    {
        if (_player._goldHeld >= goldChestplate.GetComponent<ArmorBehavior>()._goldNeeded)
        {
            _player._goldHeld -= goldChestplate.GetComponent<ArmorBehavior>()._goldNeeded;
            Instantiate(goldChestplate, _itemSpawn.transform.position, _itemSpawn.transform.rotation);
        }
        else
        {
            Debug.Log("Not Enough Materials");
        }
    }

    public void CraftSilverChestplate()
    {
        if (_player._silverHeld >= silverChestplate.GetComponent<ArmorBehavior>()._silverNeeded)
        {
            _player._silverHeld -= silverChestplate.GetComponent<ArmorBehavior>()._silverNeeded;
            Instantiate(silverChestplate, _itemSpawn.transform.position, _itemSpawn.transform.rotation);
        }
        else
        {
            Debug.Log("Not Enough Materials");
        }
    }

    public void CraftDiamondChestplate()
    {
        if (_player._diamondsHeld >= diamondChestplate.GetComponent<ArmorBehavior>()._diamondsNeeded)
        {
            _player._diamondsHeld -= diamondChestplate.GetComponent<ArmorBehavior>()._diamondsNeeded;
            Instantiate(diamondChestplate, _itemSpawn.transform.position, _itemSpawn.transform.rotation);
        }
        else
        {
            Debug.Log("Not Enough Materials");
        }
    }

    public void CraftBloodStoneChestplate()
    {
        if (_player._bloodstoneHeld >= bloodstoneChestplate.GetComponent<ArmorBehavior>()._bloodstoneNeeded)
        {
            _player._bloodstoneHeld -= bloodstoneChestplate.GetComponent<ArmorBehavior>()._bloodstoneNeeded;
            Instantiate(bloodstoneChestplate, _itemSpawn.transform.position, _itemSpawn.transform.rotation);
        }
        else
        {
            Debug.Log("Not Enough Materials");
        }
    }

    public void CraftChlorophyteChestplate()
    {
        if (_player._chlorophyteHeld >= chlorophyteChestplate.GetComponent<ArmorBehavior>()._chlorophyteNeeded)
        {
            _player._chlorophyteHeld -= chlorophyteChestplate.GetComponent<ArmorBehavior>()._chlorophyteNeeded;
            Instantiate(chlorophyteChestplate, _itemSpawn.transform.position, _itemSpawn.transform.rotation);
        }
        else
        {
            Debug.Log("Not Enough Materials");
        }
    }
    public void CraftMithrilChestplate()
    {
        if (_player._mithrilHeld >= mithrilChestplate.GetComponent<ArmorBehavior>()._mithrilNeeded)
        {
            _player._mithrilHeld -= mithrilChestplate.GetComponent<ArmorBehavior>()._mithrilNeeded;
            Instantiate(mithrilChestplate, _itemSpawn.transform.position, _itemSpawn.transform.rotation);
        }
        else
        {
            Debug.Log("Not Enough Materials");
        }
    }

    //Leggings crafting
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

    public void CraftGoldLeggings()
    {
        if (_player._goldHeld >= goldLeggings.GetComponent<ArmorBehavior>()._goldNeeded)
        {
            _player._goldHeld -= goldLeggings.GetComponent<ArmorBehavior>()._goldNeeded;
            Instantiate(goldLeggings, _itemSpawn.transform.position, _itemSpawn.transform.rotation);
        }
        else
        {
            Debug.Log("Not Enough Materials");
        }
    }

    public void CraftSilverLeggings()
    {
        if (_player._silverHeld >= silverLeggings.GetComponent<ArmorBehavior>()._silverNeeded)
        {
            _player._silverHeld -= silverLeggings.GetComponent<ArmorBehavior>()._silverNeeded;
            Instantiate(silverLeggings, _itemSpawn.transform.position, _itemSpawn.transform.rotation);
        }
        else
        {
            Debug.Log("Not Enough Materials");
        }
    }

    public void CraftDiamondLeggings()
    {
        if (_player._diamondsHeld >= diamondLeggings.GetComponent<ArmorBehavior>()._diamondsNeeded)
        {
            _player._diamondsHeld -= diamondLeggings.GetComponent<ArmorBehavior>()._diamondsNeeded;
            Instantiate(diamondLeggings, _itemSpawn.transform.position, _itemSpawn.transform.rotation);
        }
        else
        {
            Debug.Log("Not Enough Materials");
        }
    }

    public void CraftBloodStoneLeggings()
    {
        if (_player._bloodstoneHeld >= bloodstoneLeggings.GetComponent<ArmorBehavior>()._bloodstoneNeeded)
        {
            _player._bloodstoneHeld -= bloodstoneLeggings.GetComponent<ArmorBehavior>()._bloodstoneNeeded;
            Instantiate(bloodstoneLeggings, _itemSpawn.transform.position, _itemSpawn.transform.rotation);
        }
        else
        {
            Debug.Log("Not Enough Materials");
        }
    }

    public void CraftChlorophyteLeggings()
    {
        if (_player._chlorophyteHeld >= chlorophyteLeggings.GetComponent<ArmorBehavior>()._chlorophyteNeeded)
        {
            _player._chlorophyteHeld -= chlorophyteLeggings.GetComponent<ArmorBehavior>()._chlorophyteNeeded;
            Instantiate(chlorophyteLeggings, _itemSpawn.transform.position, _itemSpawn.transform.rotation);
        }
        else
        {
            Debug.Log("Not Enough Materials");
        }
    }
    public void CraftMithrilLeggings()
    {
        if (_player._mithrilHeld >= mithrilLeggings.GetComponent<ArmorBehavior>()._mithrilNeeded)
        {
            _player._mithrilHeld -= mithrilLeggings.GetComponent<ArmorBehavior>()._mithrilNeeded;
            Instantiate(mithrilLeggings, _itemSpawn.transform.position, _itemSpawn.transform.rotation);
        }
        else
        {
            Debug.Log("Not Enough Materials");
        }
    }

    //Boots crafting
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

    public void CraftGoldBoots()
    {
        if (_player._goldHeld >= goldBoots.GetComponent<ArmorBehavior>()._goldNeeded)
        {
            _player._goldHeld -= goldBoots.GetComponent<ArmorBehavior>()._goldNeeded;
            Instantiate(goldBoots, _itemSpawn.transform.position, _itemSpawn.transform.rotation);
        }
        else
        {
            Debug.Log("Not Enough Materials");
        }
    }

    public void CraftSilverBoots()
    {
        if (_player._silverHeld >= silverBoots.GetComponent<ArmorBehavior>()._silverNeeded)
        {
            _player._silverHeld -= silverBoots.GetComponent<ArmorBehavior>()._silverNeeded;
            Instantiate(silverBoots, _itemSpawn.transform.position, _itemSpawn.transform.rotation);
        }
        else
        {
            Debug.Log("Not Enough Materials");
        }
    }

    public void CraftDiamondBoots()
    {
        if (_player._diamondsHeld >= diamondBoots.GetComponent<ArmorBehavior>()._diamondsNeeded)
        {
            _player._diamondsHeld -= diamondBoots.GetComponent<ArmorBehavior>()._diamondsNeeded;
            Instantiate(diamondBoots, _itemSpawn.transform.position, _itemSpawn.transform.rotation);
        }
        else
        {
            Debug.Log("Not Enough Materials");
        }
    }

    public void CraftBloodStoneBoots()
    {
        if (_player._bloodstoneHeld >= bloodstoneBoots.GetComponent<ArmorBehavior>()._bloodstoneNeeded)
        {
            _player._bloodstoneHeld -= bloodstoneBoots.GetComponent<ArmorBehavior>()._bloodstoneNeeded;
            Instantiate(bloodstoneBoots, _itemSpawn.transform.position, _itemSpawn.transform.rotation);
        }
        else
        {
            Debug.Log("Not Enough Materials");
        }
    }

    public void CraftChlorophyteBoots()
    {
        if (_player._chlorophyteHeld >= chlorophyteBoots.GetComponent<ArmorBehavior>()._chlorophyteNeeded)
        {
            _player._chlorophyteHeld -= chlorophyteBoots.GetComponent<ArmorBehavior>()._chlorophyteNeeded;
            Instantiate(chlorophyteBoots, _itemSpawn.transform.position, _itemSpawn.transform.rotation);
        }
        else
        {
            Debug.Log("Not Enough Materials");
        }
    }
    public void CraftMithrilBoots()
    {
        if (_player._mithrilHeld >= mithrilBoots.GetComponent<ArmorBehavior>()._mithrilNeeded)
        {
            _player._mithrilHeld -= mithrilBoots.GetComponent<ArmorBehavior>()._mithrilNeeded;
            Instantiate(mithrilBoots, _itemSpawn.transform.position, _itemSpawn.transform.rotation);
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
