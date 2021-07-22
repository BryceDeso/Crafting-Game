using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUIBehavior : MonoBehaviour
{
    [SerializeField]
    private UIManagerBehavior _UIManager;

    [SerializeField]
    private GameObject inventoryUI;

    [SerializeField]
    private Text _iron;
    [SerializeField]
    private Text _gold;
    [SerializeField]
    private Text _oakWood;
    [SerializeField]
    private Text _weapon;
    [SerializeField]
    private Text _pickaxe;
    [SerializeField]
    private Text _helmet;
    [SerializeField]
    private Text _chestplate;
    [SerializeField]
    private Text _leggings;
    [SerializeField]
    private Text _boots;


    private bool inventoryOpen;


    // Start is called before the first frame update
    void Start()
    {
        inventoryOpen = false;   
    }

    // Update is called once per frame
    void Update()
    {
        OpenInventory();
        UpdateUI();
    }

    private void OpenInventory()
    {
        if (Input.GetKeyDown(KeyCode.I) && inventoryOpen == false)
        {
            inventoryUI.SetActive(true);
            inventoryOpen = true;
        }
        else if (Input.GetKeyDown(KeyCode.I) && inventoryOpen == true)
        {
            inventoryUI.SetActive(false);
            inventoryOpen = false;
        }
    }

    private void UpdateUI()
    {
        _iron.text = (_UIManager._player._ironHeld + "");
        _gold.text = (_UIManager._player._goldHeld + "");
        _oakWood.text = (_UIManager._player._oakWoodHeld + "");
        _weapon.text = ("none");
        _pickaxe.text = ("none");
        _helmet.text = ("none");
        _chestplate.text = ("none");
        _leggings.text = ("none");
        _boots.text = ("none");
        if (_UIManager._player._weapon)
        {
            _weapon.text = (_UIManager._player._weapon._name + "");
        }
        if (_UIManager._player._pickaxe)
        {
            _pickaxe.text = (_UIManager._player._pickaxe._name + "");
        }
        if (_UIManager._player._helmet)
        {
            _weapon.text = (_UIManager._player._helmet._name + "");
        }
        if (_UIManager._player._chestplate)
        {
            _pickaxe.text = (_UIManager._player._chestplate._name + "");
        }
        if (_UIManager._player._leggings)
        {
            _weapon.text = (_UIManager._player._leggings._name + "");
        }
        if (_UIManager._player._boots)
        {
            _pickaxe.text = (_UIManager._player._boots._name + "");
        }
    }
}
