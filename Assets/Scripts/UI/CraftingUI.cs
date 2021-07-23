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

    [SerializeField]
    private Text _ironSwordReqirements;

    [SerializeField]
    private Button _ironSwordButton;

    [SerializeField]
    private Text _goldSwordReqirements;

    [SerializeField]
    private Button _goldSwordButton;

    [SerializeField]
    private Text _ironPickaxeReqirements;

    [SerializeField]
    private Button _ironPickaxeButton;

    [SerializeField]
    private Text _goldPickaxeReqirements;

    [SerializeField]
    private Button _goldPickaxeButton;

    [SerializeField]
    private Text _ironHelmetReqirements;

    [SerializeField]
    private Button _ironHelmetButton;

    [SerializeField]
    private Text _ironChestplateReqirements;

    [SerializeField]
    private Button _ironChestplateButton;

    [SerializeField]
    private Text _ironLeggingsReqirements;

    [SerializeField]
    private Button _ironLeggingsButton;

    [SerializeField]
    private Text _ironBootsReqirements;

    [SerializeField]
    private Button _ironBootsButton;

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

        if (_UIManager._player._ironHeld >= _UIManager._craftingTable.ironHelmet.GetComponent<ArmorBehavior>()._ironNeeded)
        {
            _ironHelmetButton.gameObject.SetActive(true);
        }
        else
        {
            _ironHelmetButton.gameObject.SetActive(false);
        }

        if (_UIManager._player._ironHeld >= _UIManager._craftingTable.ironChestplate.GetComponent<ArmorBehavior>()._ironNeeded)
        {
            _ironChestplateButton.gameObject.SetActive(true);
        }
        else
        {
            _ironChestplateButton.gameObject.SetActive(false);
        }

        if (_UIManager._player._ironHeld >= _UIManager._craftingTable.ironLeggings.GetComponent<ArmorBehavior>()._ironNeeded)
        {
            _ironLeggingsButton.gameObject.SetActive(true);
        }
        else
        {
            _ironLeggingsButton.gameObject.SetActive(false);
        }

        if (_UIManager._player._ironHeld >= _UIManager._craftingTable.ironBoots.GetComponent<ArmorBehavior>()._ironNeeded)
        {
            _ironBootsButton.gameObject.SetActive(true);
        }
        else
        {
            _ironBootsButton.gameObject.SetActive(false);
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
