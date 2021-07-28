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
    private Text _copper;
    [SerializeField]
    private Text _iron;
    [SerializeField]
    private Text _gold;
    [SerializeField]
    private Text _silver;
    [SerializeField]
    private Text _diamond;
    [SerializeField]
    private Text _titanium;
    [SerializeField]
    private Text _chlorophyte;
    [SerializeField]
    private Text _mithril;
    [SerializeField]
    private Text _oakWood;
    [SerializeField]
    private Text _jungleWood;
    [SerializeField]
    private Text _ashWood;
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

    [SerializeField]
    private Text _currentDamageText;
    [SerializeField]
    private Text _miningPowerText;
    [SerializeField]
    private Text _currentArmor;

    [SerializeField]
    private Button _helmetButton;
    [SerializeField]
    private Button _chestplateButton;
    [SerializeField]
    private Button _leggingButton;
    [SerializeField]
    private Button _bootsButton;

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
            _UIManager._player._interactionField.inInventory = true;
            Cursor.lockState = CursorLockMode.None;
            Cursor.lockState = CursorLockMode.Confined;
        }
        else if (Input.GetKeyDown(KeyCode.I) && inventoryOpen == true)
        {
            inventoryUI.SetActive(false);
            inventoryOpen = false;
            _UIManager._player._interactionField.inInventory = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }

    private void UpdateUI()
    {
        _currentDamageText.text = ("" + _UIManager._player._weaponDamage);
        _miningPowerText.text = ("" + _UIManager._player._pickaxeDamage);
        _currentArmor.text = ("" + _UIManager._player._armor);
        _iron.text = ("" + _UIManager._player._ironHeld);
        _gold.text = (_UIManager._player._goldHeld + "");
        _silver.text = (_UIManager._player._silverHeld + "");
        _diamond.text = (_UIManager._player._diamondsHeld + "");
        _titanium.text = (_UIManager._player._bloodstoneHeld + "");
        _chlorophyte.text = (_UIManager._player._chlorophyteHeld + "");
        _mithril.text = (_UIManager._player._mithrilHeld + "");
        _oakWood.text = (_UIManager._player._oakWoodHeld + "");
        _jungleWood.text = (_UIManager._player._jungleWoodHeld + "");
        _ashWood.text = (_UIManager._player._ashWoodHeld + "");
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
            _helmet.text = (_UIManager._player._helmet._name + "");
            _helmetButton.gameObject.SetActive(true);
        }
        else
        {
            _helmetButton.gameObject.SetActive(false);
        }

        if (_UIManager._player._chestplate)
        {
            _chestplate.text = (_UIManager._player._chestplate._name + "");
            _chestplateButton.gameObject.SetActive(true);
        }
        else
        {
            _chestplateButton.gameObject.SetActive(false);
        }

        if (_UIManager._player._leggings)
        {
            _leggings.text = (_UIManager._player._leggings._name + "");
            _leggingButton.gameObject.SetActive(true);
        }
        else
        {
            _leggingButton.gameObject.SetActive(false);
        }

        if (_UIManager._player._boots)
        {
            _boots.text = (_UIManager._player._boots._name + "");
            _bootsButton.gameObject.SetActive(true);
        }
        else
        {
            _bootsButton.gameObject.SetActive(false);
        }
    }
}
