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
    private Text _goldSwordReqirements;

    [SerializeField]
    private Text _ironPickaxeReqirements;

    [SerializeField]
    private Text _goldPickaxeReqirements;

    private void Update()
    {
        Crafting();
        UpdateRequirements();
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

    public void ExitCraftingMenu()
    {
        _craftingUI.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        _UIManager._player.GetComponent<PlayerMovmentBehavior>().canMove = true;
    }

    private void UpdateRequirements()
    {
        _ironPickaxeReqirements.text = ("Iron:" + _UIManager._craftingTable._ironPickaxe.GetComponent<PickaxeBehavior>()._ironNeeded + 
            "| Oak Wood:" + _UIManager._craftingTable._ironPickaxe.GetComponent<PickaxeBehavior>()._oakWoodNeeded);

        _goldPickaxeReqirements.text = ("Gold:" + _UIManager._craftingTable._goldPickaxe.GetComponent<PickaxeBehavior>()._goldNeeded + 
            "| Oak Wood:" + _UIManager._craftingTable._goldPickaxe.GetComponent<PickaxeBehavior>()._oakWoodNeeded);

        _ironSwordReqirements.text = ("Iron:" + _UIManager._craftingTable._ironSword.GetComponent<WeaponBehavior>()._ironNeeded + 
            "| Oak Wood:" + _UIManager._craftingTable._ironSword.GetComponent<WeaponBehavior>()._oakWoodNeeded);

        _goldSwordReqirements.text = ("Gold:" + _UIManager._craftingTable._goldSword.GetComponent<WeaponBehavior>()._goldNeeded +
            "| Oak Wood:" + _UIManager._craftingTable._goldSword.GetComponent<WeaponBehavior>()._oakWoodNeeded);
    }
}
