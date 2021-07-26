using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CraftingUI : MonoBehaviour
{
    [SerializeField]
    private GameObject _craftingUI;

    [SerializeField]
    private UIManagerBehavior _UIManager;

    //Swords
    [SerializeField]
    private Text _ironSwordReqirements;

    [SerializeField]
    private Button _ironSwordButton;

    [SerializeField]
    private Text _goldSwordReqirements;

    [SerializeField]
    private Button _goldSwordButton;

    [SerializeField]
    private Text _silverSwordReqirements;

    [SerializeField]
    private Button _silverSwordButton;

    [SerializeField]
    private Text _diamondSwordReqirements;

    [SerializeField]
    private Button _diamondSwordButton;

    [SerializeField]
    private Text _titaniumSwordReqirements;

    [SerializeField]
    private Button _titaniumSwordButton;

    [SerializeField]
    private Text _chlorophyteSwordReqirements;

    [SerializeField]
    private Button _chlorophyteSwordButton;

    [SerializeField]
    private Text _mithrilSwordReqirements;

    [SerializeField]
    private Button _mithrilSwordButton;

    //Pickaxes
    [SerializeField]
    private Text _ironPickaxeReqirements;

    [SerializeField]
    private Button _ironPickaxeButton;

    [SerializeField]
    private Text _goldPickaxeReqirements;

    [SerializeField]
    private Button _goldPickaxeButton;

    [SerializeField]
    private Text _silverPickaxeReqirements;

    [SerializeField]
    private Button _silverPickaxeButton;

    [SerializeField]
    private Text _diamondPickaxeReqirements;

    [SerializeField]
    private Button _diamondPickaxeButton;

    [SerializeField]
    private Text _titaniumPickaxeReqirements;

    [SerializeField]
    private Button _titaniumPickaxeButton;

    [SerializeField]
    private Text _chlorophytePickaxeReqirements;

    [SerializeField]
    private Button _chlorophytePickaxeButton;

    [SerializeField]
    private Text _mithrilPickaxeReqirements;

    [SerializeField]
    private Button _mithrilPickaxeButton;

    //Helmets
    [SerializeField]
    private Text _ironHelmetReqirements;

    [SerializeField]
    private Button _ironHelmetButton;

    [SerializeField]
    private Text _goldHelmetReqirements;

    [SerializeField]
    private Button _goldHelmetButton;

    [SerializeField]
    private Text _silverHelmetReqirements;

    [SerializeField]
    private Button _silverHelmetButton;

    [SerializeField]
    private Text _diamondHelmetReqirements;

    [SerializeField]
    private Button _diamondHelmetButton;

    [SerializeField]
    private Text _titaniumHelmetReqirements;

    [SerializeField]
    private Button _titaniumHelmetButton;

    [SerializeField]
    private Text _chlorophyteHelmetReqirements;

    [SerializeField]
    private Button _chlorophyteHelmetButton;

    [SerializeField]
    private Text _mithrilHelmetReqirements;

    [SerializeField]
    private Button _mithrilHelmetButton;

    //Chestplates
    [SerializeField]
    private Text _ironChestplateReqirements;

    [SerializeField]
    private Button _ironChestplateButton;

    [SerializeField]
    private Text _goldChestplateReqirements;

    [SerializeField]
    private Button _goldChestplateButton;

    [SerializeField]
    private Text _silverChestplateReqirements;

    [SerializeField]
    private Button _silverChestplateButton;

    [SerializeField]
    private Text _diamondChestplateReqirements;

    [SerializeField]
    private Button _diamondChestplateButton;

    [SerializeField]
    private Text _titaniumChestplateReqirements;

    [SerializeField]
    private Button _titaniumChestplateButton;

    [SerializeField]
    private Text _chlorophyteChestplateReqirements;

    [SerializeField]
    private Button _chlorophyteChestplateButton;

    [SerializeField]
    private Text _mithrilChestplateReqirements;

    [SerializeField]
    private Button _mithrilChestplateButton;

    //Leggings
    [SerializeField]
    private Text _ironLeggingsReqirements;

    [SerializeField]
    private Button _ironLeggingsButton;

    [SerializeField]
    private Text _goldLeggingsReqirements;

    [SerializeField]
    private Button _goldLeggingsButton;

    [SerializeField]
    private Text _silverLeggingsReqirements;

    [SerializeField]
    private Button _silverLeggingsButton;

    [SerializeField]
    private Text _diamondLeggingsReqirements;

    [SerializeField]
    private Button _diamondLeggingsButton;

    [SerializeField]
    private Text _titaniumLeggingsReqirements;

    [SerializeField]
    private Button _titaniumLeggingsButton;

    [SerializeField]
    private Text _chlorophyteLeggingsReqirements;

    [SerializeField]
    private Button _chlorophyteLeggingsButton;

    [SerializeField]
    private Text _mithrilLeggingsReqirements;

    [SerializeField]
    private Button _mithrilLeggingsButton;

    //Boots
    [SerializeField]
    private Text _ironBootsReqirements;

    [SerializeField]
    private Button _ironBootsButton;

    [SerializeField]
    private Text _goldBootsReqirements;

    [SerializeField]
    private Button _goldBootsButton;

    [SerializeField]
    private Text _silverBootsReqirements;

    [SerializeField]
    private Button _silverBootsButton;

    [SerializeField]
    private Text _diamondBootsReqirements;

    [SerializeField]
    private Button _diamondBootsButton;

    [SerializeField]
    private Text _titaniumBootsReqirements;

    [SerializeField]
    private Button _titaniumBootsButton;

    [SerializeField]
    private Text _chlorophyteBootsReqirements;

    [SerializeField]
    private Button _chlorophyteBootsButton;

    [SerializeField]
    private Text _mithrilBootsReqirements;

    [SerializeField]
    private Button _mithrilBootsButton;

    private void Update()
    {
        Crafting();
        UpdateRequirements();
        UpdateButtons();
    }

    public void ExitCraftingMenu()
    {
        _craftingUI.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        _UIManager._player.GetComponent<PlayerMovmentBehavior>().canMove = true;
    }

    public void Crafting()
    {
        if(Input.GetButtonDown("Fire1") && _UIManager._player._interactionField.canCraft == true)
        {
            _craftingUI.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.lockState = CursorLockMode.Confined;
            _UIManager._player.GetComponent<PlayerMovmentBehavior>().canMove = false;
        }
    }

    private void UpdateButtons()
    {
        //Swords
        if(_UIManager._player._ironHeld >= _UIManager._craftingTable.ironSword.GetComponent<WeaponBehavior>()._ironNeeded &&
           _UIManager._player._oakWoodHeld >= _UIManager._craftingTable.ironSword.GetComponent<WeaponBehavior>()._oakWoodNeeded)
        {
            _ironSwordButton.gameObject.SetActive(true);
        }
        else
        {
            _ironSwordButton.gameObject.SetActive(false);
        }

        if (_UIManager._player._goldHeld >= _UIManager._craftingTable.goldSword.GetComponent<WeaponBehavior>()._goldNeeded &&
            _UIManager._player._oakWoodHeld >= _UIManager._craftingTable.goldSword.GetComponent<WeaponBehavior>()._oakWoodNeeded)
        {
            _goldSwordButton.gameObject.SetActive(true);
        }
        else
        {
            _goldSwordButton.gameObject.SetActive(false);
        }

        if (_UIManager._player._silverHeld >= _UIManager._craftingTable.silverSword.GetComponent<WeaponBehavior>()._silverNeeded &&
            _UIManager._player._oakWoodHeld >= _UIManager._craftingTable.silverSword.GetComponent<WeaponBehavior>()._oakWoodNeeded)
        {
            _silverSwordButton.gameObject.SetActive(true);
        }
        else
        {
            _silverSwordButton.gameObject.SetActive(false);
        }

        if (_UIManager._player._diamondsHeld >= _UIManager._craftingTable.diamondSword.GetComponent<WeaponBehavior>()._diamondsNeeded &&
            _UIManager._player._oakWoodHeld >= _UIManager._craftingTable.diamondSword.GetComponent<WeaponBehavior>()._oakWoodNeeded)
        {
            _diamondSwordButton.gameObject.SetActive(true);
        }
        else
        {
            _diamondSwordButton.gameObject.SetActive(false);
        }

        if (_UIManager._player._titaniumHeld >= _UIManager._craftingTable.titaniumSword.GetComponent<WeaponBehavior>()._titaniumNeeded &&
            _UIManager._player._oakWoodHeld >= _UIManager._craftingTable.titaniumSword.GetComponent<WeaponBehavior>()._oakWoodNeeded)
        {
            _titaniumSwordButton.gameObject.SetActive(true);
        }
        else
        {
            _titaniumSwordButton.gameObject.SetActive(false);
        }

        if (_UIManager._player._chlorophyteHeld >= _UIManager._craftingTable.chlorophyteSword.GetComponent<WeaponBehavior>()._chlorophyteNeeded &&
            _UIManager._player._jungleWoodHeld >= _UIManager._craftingTable.chlorophyteSword.GetComponent<WeaponBehavior>()._jungleWoodNeeded)
        {
            _chlorophyteSwordButton.gameObject.SetActive(true);
        }
        else
        {
            _chlorophyteSwordButton.gameObject.SetActive(false);
        }

        if (_UIManager._player._mithrilHeld >= _UIManager._craftingTable.mithrilSword.GetComponent<WeaponBehavior>()._mithrilNeeded &&
            _UIManager._player._ashWoodHeld >= _UIManager._craftingTable.mithrilSword.GetComponent<WeaponBehavior>()._ashWoodNeeded)
        {
            _mithrilSwordButton.gameObject.SetActive(true);
        }
        else
        {
            _mithrilSwordButton.gameObject.SetActive(false);
        }

        //Pickaxes
        if (_UIManager._player._ironHeld >= _UIManager._craftingTable.ironPickaxe.GetComponent<PickaxeBehavior>()._ironNeeded &&
            _UIManager._player._oakWoodHeld >= _UIManager._craftingTable.ironPickaxe.GetComponent<PickaxeBehavior>()._oakWoodNeeded)
        {
            _ironPickaxeButton.gameObject.SetActive(true);
        }
        else
        {
            _ironPickaxeButton.gameObject.SetActive(false);
        }

        if (_UIManager._player._goldHeld >= _UIManager._craftingTable.goldPickaxe.GetComponent<PickaxeBehavior>()._goldNeeded &&
            _UIManager._player._oakWoodHeld >= _UIManager._craftingTable.goldPickaxe.GetComponent<PickaxeBehavior>()._oakWoodNeeded)
        {
            _goldPickaxeButton.gameObject.SetActive(true);
        }
        else
        {
            _goldPickaxeButton.gameObject.SetActive(false);
        }

        if (_UIManager._player._silverHeld >= _UIManager._craftingTable.silverPickaxe.GetComponent<PickaxeBehavior>()._silverNeeded &&
            _UIManager._player._oakWoodHeld >= _UIManager._craftingTable.silverPickaxe.GetComponent<PickaxeBehavior>()._oakWoodNeeded)
        {
            _silverPickaxeButton.gameObject.SetActive(true);
        }
        else
        {
            _silverPickaxeButton.gameObject.SetActive(false);
        }

        if (_UIManager._player._diamondsHeld >= _UIManager._craftingTable.diamondPickaxe.GetComponent<PickaxeBehavior>()._diamondsNeeded &&
            _UIManager._player._oakWoodHeld >= _UIManager._craftingTable.diamondPickaxe.GetComponent<PickaxeBehavior>()._oakWoodNeeded)
        {
            _diamondPickaxeButton.gameObject.SetActive(true);
        }
        else
        {
            _diamondPickaxeButton.gameObject.SetActive(false);
        }

        if (_UIManager._player._titaniumHeld >= _UIManager._craftingTable.titaniumPickaxe.GetComponent<PickaxeBehavior>()._titaniumNeeded &&
            _UIManager._player._oakWoodHeld >= _UIManager._craftingTable.titaniumPickaxe.GetComponent<PickaxeBehavior>()._oakWoodNeeded)
        {
            _titaniumPickaxeButton.gameObject.SetActive(true);
        }
        else
        {
            _titaniumPickaxeButton.gameObject.SetActive(false);
        }

        if (_UIManager._player._chlorophyteHeld >= _UIManager._craftingTable.chlorophytePickaxe.GetComponent<PickaxeBehavior>()._chlorophyteNeeded &&
            _UIManager._player._jungleWoodHeld >= _UIManager._craftingTable.chlorophytePickaxe.GetComponent<PickaxeBehavior>()._jungleWoodNeeded)
        {
            _chlorophytePickaxeButton.gameObject.SetActive(true);
        }
        else
        {
            _chlorophytePickaxeButton.gameObject.SetActive(false);
        }

        if (_UIManager._player._mithrilHeld >= _UIManager._craftingTable.mithrilPickaxe.GetComponent<PickaxeBehavior>()._mithrilNeeded &&
            _UIManager._player._ashWoodHeld >= _UIManager._craftingTable.mithrilPickaxe.GetComponent<PickaxeBehavior>()._ashWoodNeeded)
        {
            _mithrilPickaxeButton.gameObject.SetActive(true);
        }
        else
        {
            _mithrilPickaxeButton.gameObject.SetActive(false);
        }

        //Helmets
        if (_UIManager._player._ironHeld >= _UIManager._craftingTable.ironHelmet.GetComponent<ArmorBehavior>()._ironNeeded)
        {
            _ironHelmetButton.gameObject.SetActive(true);
        }
        else
        {
            _ironHelmetButton.gameObject.SetActive(false);
        }

        if (_UIManager._player._goldHeld >= _UIManager._craftingTable.goldHelmet.GetComponent<ArmorBehavior>()._goldNeeded)
        {
            _goldHelmetButton.gameObject.SetActive(true);
        }
        else
        {
            _goldHelmetButton.gameObject.SetActive(false);
        }

        if (_UIManager._player._silverHeld >= _UIManager._craftingTable.silverHelmet.GetComponent<ArmorBehavior>()._silverNeeded)
        {
            _silverHelmetButton.gameObject.SetActive(true);
        }
        else
        {
            _silverHelmetButton.gameObject.SetActive(false);
        }

        if (_UIManager._player._diamondsHeld >= _UIManager._craftingTable.diamondHelmet.GetComponent<ArmorBehavior>()._diamondsNeeded)
        {
            _diamondHelmetButton.gameObject.SetActive(true);
        }
        else
        {
            _diamondHelmetButton.gameObject.SetActive(false);
        }

        if (_UIManager._player._titaniumHeld >= _UIManager._craftingTable.titaniumHelmet.GetComponent<ArmorBehavior>()._titaniumNeeded)
        {
            _titaniumHelmetButton.gameObject.SetActive(true);
        }
        else
        {
            _titaniumHelmetButton.gameObject.SetActive(false);
        }

        if (_UIManager._player._chlorophyteHeld >= _UIManager._craftingTable.chlorophyteHelmet.GetComponent<ArmorBehavior>()._chlorophyteNeeded)
        {
            _chlorophyteHelmetButton.gameObject.SetActive(true);
        }
        else
        {
            _chlorophyteHelmetButton.gameObject.SetActive(false);
        }

        if (_UIManager._player._mithrilHeld >= _UIManager._craftingTable.mithrilHelmet.GetComponent<ArmorBehavior>()._mithrilNeeded)
        {
            _mithrilHelmetButton.gameObject.SetActive(true);
        }
        else
        {
            _mithrilHelmetButton.gameObject.SetActive(false);
        }

        //Chestplates
        if (_UIManager._player._ironHeld >= _UIManager._craftingTable.ironChestplate.GetComponent<ArmorBehavior>()._ironNeeded)
        {
            _ironChestplateButton.gameObject.SetActive(true);
        }
        else
        {
            _ironChestplateButton.gameObject.SetActive(false);
        }

        if (_UIManager._player._goldHeld >= _UIManager._craftingTable.goldChestplate.GetComponent<ArmorBehavior>()._goldNeeded)
        {
            _goldChestplateButton.gameObject.SetActive(true);
        }
        else
        {
            _goldChestplateButton.gameObject.SetActive(false);
        }

        if (_UIManager._player._silverHeld >= _UIManager._craftingTable.silverChestplate.GetComponent<ArmorBehavior>()._silverNeeded)
        {
            _silverChestplateButton.gameObject.SetActive(true);
        }
        else
        {
            _silverChestplateButton.gameObject.SetActive(false);
        }

        if (_UIManager._player._diamondsHeld >= _UIManager._craftingTable.diamondChestplate.GetComponent<ArmorBehavior>()._diamondsNeeded)
        {
            _diamondChestplateButton.gameObject.SetActive(true);
        }
        else
        {
            _diamondChestplateButton.gameObject.SetActive(false);
        }

        if (_UIManager._player._titaniumHeld >= _UIManager._craftingTable.titaniumChestplate.GetComponent<ArmorBehavior>()._titaniumNeeded)
        {
            _titaniumChestplateButton.gameObject.SetActive(true);
        }
        else
        {
            _titaniumChestplateButton.gameObject.SetActive(false);
        }

        if (_UIManager._player._chlorophyteHeld >= _UIManager._craftingTable.chlorophyteChestplate.GetComponent<ArmorBehavior>()._chlorophyteNeeded)
        {
            _chlorophyteChestplateButton.gameObject.SetActive(true);
        }
        else
        {
            _chlorophyteChestplateButton.gameObject.SetActive(false);
        }

        if (_UIManager._player._mithrilHeld >= _UIManager._craftingTable.mithrilChestplate.GetComponent<ArmorBehavior>()._mithrilNeeded)
        {
            _mithrilChestplateButton.gameObject.SetActive(true);
        }
        else
        {
            _mithrilChestplateButton.gameObject.SetActive(false);
        }

        //Leggings
        if (_UIManager._player._ironHeld >= _UIManager._craftingTable.ironLeggings.GetComponent<ArmorBehavior>()._ironNeeded)
        {
            _ironLeggingsButton.gameObject.SetActive(true);
        }
        else
        {
            _ironLeggingsButton.gameObject.SetActive(false);
        }

        if (_UIManager._player._goldHeld >= _UIManager._craftingTable.goldLeggings.GetComponent<ArmorBehavior>()._goldNeeded)
        {
            _goldLeggingsButton.gameObject.SetActive(true);
        }
        else
        {
            _goldLeggingsButton.gameObject.SetActive(false);
        }

        if (_UIManager._player._silverHeld >= _UIManager._craftingTable.silverLeggings.GetComponent<ArmorBehavior>()._silverNeeded)
        {
            _silverLeggingsButton.gameObject.SetActive(true);
        }
        else
        {
            _silverLeggingsButton.gameObject.SetActive(false);
        }

        if (_UIManager._player._diamondsHeld >= _UIManager._craftingTable.diamondLeggings.GetComponent<ArmorBehavior>()._diamondsNeeded)
        {
            _diamondLeggingsButton.gameObject.SetActive(true);
        }
        else
        {
            _diamondLeggingsButton.gameObject.SetActive(false);
        }

        if (_UIManager._player._titaniumHeld >= _UIManager._craftingTable.titaniumLeggings.GetComponent<ArmorBehavior>()._titaniumNeeded)
        {
            _titaniumLeggingsButton.gameObject.SetActive(true);
        }
        else
        {
            _titaniumLeggingsButton.gameObject.SetActive(false);
        }

        if (_UIManager._player._chlorophyteHeld >= _UIManager._craftingTable.chlorophyteLeggings.GetComponent<ArmorBehavior>()._chlorophyteNeeded)
        {
            _chlorophyteLeggingsButton.gameObject.SetActive(true);
        }
        else
        {
            _chlorophyteLeggingsButton.gameObject.SetActive(false);
        }

        if (_UIManager._player._mithrilHeld >= _UIManager._craftingTable.mithrilLeggings.GetComponent<ArmorBehavior>()._mithrilNeeded)
        {
            _mithrilLeggingsButton.gameObject.SetActive(true);
        }
        else
        {
            _mithrilLeggingsButton.gameObject.SetActive(false);
        }

        //Boots
        if (_UIManager._player._ironHeld >= _UIManager._craftingTable.ironBoots.GetComponent<ArmorBehavior>()._ironNeeded)
        {
            _ironBootsButton.gameObject.SetActive(true);
        }
        else
        {
            _ironBootsButton.gameObject.SetActive(false);
        }

        if (_UIManager._player._goldHeld >= _UIManager._craftingTable.goldBoots.GetComponent<ArmorBehavior>()._goldNeeded)
        {
            _goldBootsButton.gameObject.SetActive(true);
        }
        else
        {
            _goldBootsButton.gameObject.SetActive(false);
        }

        if (_UIManager._player._silverHeld >= _UIManager._craftingTable.silverBoots.GetComponent<ArmorBehavior>()._silverNeeded)
        {
            _silverBootsButton.gameObject.SetActive(true);
        }
        else
        {
            _silverBootsButton.gameObject.SetActive(false);
        }

        if (_UIManager._player._diamondsHeld >= _UIManager._craftingTable.diamondBoots.GetComponent<ArmorBehavior>()._diamondsNeeded)
        {
            _diamondBootsButton.gameObject.SetActive(true);
        }
        else
        {
            _diamondBootsButton.gameObject.SetActive(false);
        }

        if (_UIManager._player._titaniumHeld >= _UIManager._craftingTable.titaniumBoots.GetComponent<ArmorBehavior>()._titaniumNeeded)
        {
            _titaniumBootsButton.gameObject.SetActive(true);
        }
        else
        {
            _titaniumBootsButton.gameObject.SetActive(false);
        }

        if (_UIManager._player._chlorophyteHeld >= _UIManager._craftingTable.chlorophyteBoots.GetComponent<ArmorBehavior>()._chlorophyteNeeded)
        {
            _chlorophyteBootsButton.gameObject.SetActive(true);
        }
        else
        {
            _chlorophyteBootsButton.gameObject.SetActive(false);
        }

        if (_UIManager._player._mithrilHeld >= _UIManager._craftingTable.mithrilBoots.GetComponent<ArmorBehavior>()._mithrilNeeded)
        {
            _mithrilBootsButton.gameObject.SetActive(true);
        }
        else
        {
            _mithrilBootsButton.gameObject.SetActive(false);
        }
    }

    private void UpdateRequirements()
    {
        _ironPickaxeReqirements.text = ("Iron:" + _UIManager._craftingTable.ironPickaxe.GetComponent<PickaxeBehavior>()._ironNeeded + 
            " | Oak Wood:" + _UIManager._craftingTable.ironPickaxe.GetComponent<PickaxeBehavior>()._oakWoodNeeded);

        _goldPickaxeReqirements.text = ("Gold:" + _UIManager._craftingTable.goldPickaxe.GetComponent<PickaxeBehavior>()._goldNeeded + 
            " | Oak Wood:" + _UIManager._craftingTable.goldPickaxe.GetComponent<PickaxeBehavior>()._oakWoodNeeded);

        _ironSwordReqirements.text = ("Iron:" + _UIManager._craftingTable.ironSword.GetComponent<WeaponBehavior>()._ironNeeded + 
            " | Oak Wood:" + _UIManager._craftingTable.ironSword.GetComponent<WeaponBehavior>()._oakWoodNeeded);

        _goldSwordReqirements.text = ("Gold:" + _UIManager._craftingTable.goldSword.GetComponent<WeaponBehavior>()._goldNeeded +
            " | Oak Wood:" + _UIManager._craftingTable.goldSword.GetComponent<WeaponBehavior>()._oakWoodNeeded);

        _ironHelmetReqirements.text = ("Iron:" + _UIManager._craftingTable.ironHelmet.GetComponent<ArmorBehavior>()._ironNeeded);

        _ironChestplateReqirements.text = ("Iron:" + _UIManager._craftingTable.ironChestplate.GetComponent<ArmorBehavior>()._ironNeeded);

        _ironLeggingsReqirements.text = ("Iron:" + _UIManager._craftingTable.ironLeggings.GetComponent<ArmorBehavior>()._ironNeeded);

        _ironBootsReqirements.text = ("Iron:" + _UIManager._craftingTable.ironBoots.GetComponent<ArmorBehavior>()._ironNeeded);
    }
}
