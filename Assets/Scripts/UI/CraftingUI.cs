using UnityEngine;
using UnityEngine.UI;

public class CraftingUI : MonoBehaviour
{
    [SerializeField]
    private GameObject _craftingUI;

    [SerializeField]
    private UIManagerBehavior _UIManager;

    private bool _updateCraftingUI = false;

    public bool[] _tabs;

    [SerializeField]
    private Text[] _swords;

    [SerializeField]
    private Text[] _pickaxes;

    [SerializeField]
    private Text[] _helmet;

    [SerializeField]
    private Text[] _chestplate;

    [SerializeField]
    private Text[] _leggings;

    [SerializeField]
    private Text[] _boots;

    [SerializeField]
    private bool _onIronTab;

    [SerializeField]
    private bool _onSilverTab;

    [SerializeField]
    private bool _onGoldTab;

    [SerializeField]
    private bool _onDiamondTab;

    [SerializeField]
    private bool _onBloodstoneTab;

    [SerializeField]
    private bool _onChlorophyteTab;

    [SerializeField]
    private bool _onMithrilTab;

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
    private Text _bloodstoneSwordReqirements;

    [SerializeField]
    private Button _bloodstoneSwordButton;

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
    private Text _bloodstonePickaxeReqirements;

    [SerializeField]
    private Button _bloodstonePickaxeButton;

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
    private Text _bloodstoneHelmetReqirements;

    [SerializeField]
    private Button _bloodstoneHelmetButton;

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
    private Text _bloodstoneChestplateReqirements;

    [SerializeField]
    private Button _bloodstoneChestplateButton;

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
    private Text _bloodstoneLeggingsReqirements;

    [SerializeField]
    private Button _bloodstoneLeggingsButton;

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
    private Text _bloodstoneBootsReqirements;

    [SerializeField]
    private Button _bloodstoneBootsButton;

    [SerializeField]
    private Text _chlorophyteBootsReqirements;

    [SerializeField]
    private Button _chlorophyteBootsButton;

    [SerializeField]
    private Text _mithrilBootsReqirements;

    [SerializeField]
    private Button _mithrilBootsButton;

    private void Start()
    {
        _tabs[0] = _onIronTab;
        _tabs[1] = _onSilverTab;
        _tabs[2] = _onGoldTab;
        _tabs[3] = _onDiamondTab;
        _tabs[4] = _onBloodstoneTab;
        _tabs[5] = _onChlorophyteTab;
        _tabs[6] = _onMithrilTab;
    }

    private void Update()
    {
        Crafting();
    }

    public void ExitCraftingMenu()
    {
        _updateCraftingUI = false;
        _craftingUI.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        _UIManager._player.GetComponent<PlayerMovmentBehavior>().canMove = true;
    }

    public void Crafting()
    {
        if(Input.GetButtonDown("Fire1") && _UIManager._player._interactionField.canCraft == true)
        {
            _updateCraftingUI = true;
            _craftingUI.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.lockState = CursorLockMode.Confined;
            _UIManager._player.GetComponent<PlayerMovmentBehavior>().canMove = false;
        }
        if(_updateCraftingUI)
        {
            updateCraftButtons();
            UpdateRequirements();
        }
    }

    public void updateCraftButtons()
    {
        if(_onIronTab)
        {
            //Sword
            if (_UIManager._player._ironHeld >= _UIManager._craftingTable.ironSword.GetComponent<WeaponBehavior>()._ironNeeded &&
                _UIManager._player._oakWoodHeld >= _UIManager._craftingTable.ironSword.GetComponent<WeaponBehavior>()._oakWoodNeeded)
            {
                _ironSwordButton.gameObject.SetActive(true);
            }
            else
            {
                _ironSwordButton.gameObject.SetActive(false);
            }
            //Pickaxe
            if (_UIManager._player._ironHeld >= _UIManager._craftingTable.ironPickaxe.GetComponent<PickaxeBehavior>()._ironNeeded &&
                _UIManager._player._oakWoodHeld >= _UIManager._craftingTable.ironPickaxe.GetComponent<PickaxeBehavior>()._oakWoodNeeded)
            {
                _ironPickaxeButton.gameObject.SetActive(true);
            }
            else
            {
                _ironPickaxeButton.gameObject.SetActive(false);
            }
            //Helemt
            if (_UIManager._player._ironHeld >= _UIManager._craftingTable.ironHelmet.GetComponent<ArmorBehavior>()._ironNeeded)
            {
                _ironHelmetButton.gameObject.SetActive(true);
            }
            else
            {
                _ironHelmetButton.gameObject.SetActive(false);
            }
            //Chestplate
            if (_UIManager._player._ironHeld >= _UIManager._craftingTable.ironChestplate.GetComponent<ArmorBehavior>()._ironNeeded)
            {
                _ironChestplateButton.gameObject.SetActive(true);
            }
            else
            {
                _ironChestplateButton.gameObject.SetActive(false);
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
            //Boots
            if (_UIManager._player._ironHeld >= _UIManager._craftingTable.ironBoots.GetComponent<ArmorBehavior>()._ironNeeded)
            {
                _ironBootsButton.gameObject.SetActive(true);
            }
            else
            {
                _ironBootsButton.gameObject.SetActive(false);
            }
        }
        else if (_onSilverTab)
        {
            //Sword
            if (_UIManager._player._silverHeld >= _UIManager._craftingTable.silverSword.GetComponent<WeaponBehavior>()._silverNeeded &&
                _UIManager._player._oakWoodHeld >= _UIManager._craftingTable.silverSword.GetComponent<WeaponBehavior>()._oakWoodNeeded)
            {
                _silverSwordButton.gameObject.SetActive(true);
            }
            else
            {
                _silverSwordButton.gameObject.SetActive(false);
            }
            //Pickaxe
            if (_UIManager._player._silverHeld >= _UIManager._craftingTable.silverPickaxe.GetComponent<PickaxeBehavior>()._silverNeeded &&
                _UIManager._player._oakWoodHeld >= _UIManager._craftingTable.silverPickaxe.GetComponent<PickaxeBehavior>()._oakWoodNeeded)
            {
                _silverPickaxeButton.gameObject.SetActive(true);
            }
            else
            {
                _silverPickaxeButton.gameObject.SetActive(false);
            }
            //Helmet
            if (_UIManager._player._silverHeld >= _UIManager._craftingTable.silverHelmet.GetComponent<ArmorBehavior>()._silverNeeded)
            {
                _silverHelmetButton.gameObject.SetActive(true);
            }
            else
            {
                _silverHelmetButton.gameObject.SetActive(false);
            }
            //Chestplate
            if (_UIManager._player._silverHeld >= _UIManager._craftingTable.silverChestplate.GetComponent<ArmorBehavior>()._silverNeeded)
            {
                _silverChestplateButton.gameObject.SetActive(true);
            }
            else
            {
                _silverChestplateButton.gameObject.SetActive(false);
            }
            //Leggings
            if (_UIManager._player._silverHeld >= _UIManager._craftingTable.silverLeggings.GetComponent<ArmorBehavior>()._silverNeeded)
            {
                _silverLeggingsButton.gameObject.SetActive(true);
            }
            else
            {
                _silverLeggingsButton.gameObject.SetActive(false);
            }
            //Boots
            if (_UIManager._player._silverHeld >= _UIManager._craftingTable.silverBoots.GetComponent<ArmorBehavior>()._silverNeeded)
            {
                _silverBootsButton.gameObject.SetActive(true);
            }
            else
            {
                _silverBootsButton.gameObject.SetActive(false);
            }
        }
        else if(_onGoldTab)
        {
            //Sword
            if (_UIManager._player._goldHeld >= _UIManager._craftingTable.goldSword.GetComponent<WeaponBehavior>()._goldNeeded &&
                _UIManager._player._oakWoodHeld >= _UIManager._craftingTable.goldSword.GetComponent<WeaponBehavior>()._oakWoodNeeded)
            {
                _goldSwordButton.gameObject.SetActive(true);
            }
            else
            {
                _goldSwordButton.gameObject.SetActive(false);
            }
            //Pickaxe
            if (_UIManager._player._goldHeld >= _UIManager._craftingTable.goldPickaxe.GetComponent<PickaxeBehavior>()._goldNeeded &&
                _UIManager._player._oakWoodHeld >= _UIManager._craftingTable.goldPickaxe.GetComponent<PickaxeBehavior>()._oakWoodNeeded)
            {
                _goldPickaxeButton.gameObject.SetActive(true);
            }
            else
            {
                _goldPickaxeButton.gameObject.SetActive(false);
            }
            //Helmet
            if (_UIManager._player._goldHeld >= _UIManager._craftingTable.goldHelmet.GetComponent<ArmorBehavior>()._goldNeeded)
            {
                _goldHelmetButton.gameObject.SetActive(true);
            }
            else
            {
                _goldHelmetButton.gameObject.SetActive(false);
            }
            //Chestplate
            if (_UIManager._player._goldHeld >= _UIManager._craftingTable.goldChestplate.GetComponent<ArmorBehavior>()._goldNeeded)
            {
                _goldChestplateButton.gameObject.SetActive(true);
            }
            else
            {
                _goldChestplateButton.gameObject.SetActive(false);
            }
            //Leggings
            if (_UIManager._player._goldHeld >= _UIManager._craftingTable.goldLeggings.GetComponent<ArmorBehavior>()._goldNeeded)
            {
                _goldLeggingsButton.gameObject.SetActive(true);
            }
            else
            {
                _goldLeggingsButton.gameObject.SetActive(false);
            }
            //Boots
            if (_UIManager._player._goldHeld >= _UIManager._craftingTable.goldBoots.GetComponent<ArmorBehavior>()._goldNeeded)
            {
                _goldBootsButton.gameObject.SetActive(true);
            }
            else
            {
                _goldBootsButton.gameObject.SetActive(false);
            }
        }
        else if (_onDiamondTab)
        {
            //Sword
            if (_UIManager._player._diamondsHeld >= _UIManager._craftingTable.diamondSword.GetComponent<WeaponBehavior>()._diamondsNeeded &&
                _UIManager._player._oakWoodHeld >= _UIManager._craftingTable.diamondSword.GetComponent<WeaponBehavior>()._oakWoodNeeded)
            {
                _diamondSwordButton.gameObject.SetActive(true);
            }
            else
            {
                _diamondSwordButton.gameObject.SetActive(false);
            }
            //Pickaxe
            if (_UIManager._player._diamondsHeld >= _UIManager._craftingTable.diamondPickaxe.GetComponent<PickaxeBehavior>()._diamondsNeeded &&
                _UIManager._player._oakWoodHeld >= _UIManager._craftingTable.diamondPickaxe.GetComponent<PickaxeBehavior>()._oakWoodNeeded)
            {
                _diamondPickaxeButton.gameObject.SetActive(true);
            }
            else
            {
                _diamondPickaxeButton.gameObject.SetActive(false);
            }
            //Helmet
            if (_UIManager._player._diamondsHeld >= _UIManager._craftingTable.diamondHelmet.GetComponent<ArmorBehavior>()._diamondsNeeded)
            {
                _diamondHelmetButton.gameObject.SetActive(true);
            }
            else
            {
                _diamondHelmetButton.gameObject.SetActive(false);
            }
            //Chestplate
            if (_UIManager._player._diamondsHeld >= _UIManager._craftingTable.diamondChestplate.GetComponent<ArmorBehavior>()._diamondsNeeded)
            {
                _diamondChestplateButton.gameObject.SetActive(true);
            }
            else
            {
                _diamondChestplateButton.gameObject.SetActive(false);
            }
            //Leggings
            if (_UIManager._player._diamondsHeld >= _UIManager._craftingTable.diamondLeggings.GetComponent<ArmorBehavior>()._diamondsNeeded)
            {
                _diamondLeggingsButton.gameObject.SetActive(true);
            }
            else
            {
                _diamondLeggingsButton.gameObject.SetActive(false);
            }
            //Boots
            if (_UIManager._player._diamondsHeld >= _UIManager._craftingTable.diamondBoots.GetComponent<ArmorBehavior>()._diamondsNeeded)
            {
                _diamondBootsButton.gameObject.SetActive(true);
            }
            else
            {
                _diamondBootsButton.gameObject.SetActive(false);
            }
        }
        else if (_onBloodstoneTab)
        {
            //Sword
            if (_UIManager._player._bloodstoneHeld >= _UIManager._craftingTable.bloodstoneSword.GetComponent<WeaponBehavior>()._bloodstoneNeeded &&
                _UIManager._player._oakWoodHeld >= _UIManager._craftingTable.bloodstoneSword.GetComponent<WeaponBehavior>()._oakWoodNeeded)
            {
                _bloodstoneSwordButton.gameObject.SetActive(true);
            }
            else
            {
                _bloodstoneSwordButton.gameObject.SetActive(false);
            }
            //Pickaxe
            if (_UIManager._player._bloodstoneHeld >= _UIManager._craftingTable.bloodstonePickaxe.GetComponent<PickaxeBehavior>()._bloodstoneNeeded &&
                _UIManager._player._oakWoodHeld >= _UIManager._craftingTable.bloodstonePickaxe.GetComponent<PickaxeBehavior>()._oakWoodNeeded)
            {
                _bloodstonePickaxeButton.gameObject.SetActive(true);
            }
            else
            {
                _bloodstonePickaxeButton.gameObject.SetActive(false);
            }
            //Helmet
            if (_UIManager._player._bloodstoneHeld >= _UIManager._craftingTable.bloodstoneHelmet.GetComponent<ArmorBehavior>()._bloodstoneNeeded)
            {
                _bloodstoneHelmetButton.gameObject.SetActive(true);
            }
            else
            {
                _bloodstoneHelmetButton.gameObject.SetActive(false);
            }
            //Chestplate
            if (_UIManager._player._bloodstoneHeld >= _UIManager._craftingTable.bloodstoneChestplate.GetComponent<ArmorBehavior>()._bloodstoneNeeded)
            {
                _bloodstoneChestplateButton.gameObject.SetActive(true);
            }
            else
            {
                _bloodstoneChestplateButton.gameObject.SetActive(false);
            }
            //Leggings
            if (_UIManager._player._bloodstoneHeld >= _UIManager._craftingTable.bloodstoneLeggings.GetComponent<ArmorBehavior>()._bloodstoneNeeded)
            {
                _bloodstoneLeggingsButton.gameObject.SetActive(true);
            }
            else
            {
                _bloodstoneLeggingsButton.gameObject.SetActive(false);
            }
            //Boots
            if (_UIManager._player._bloodstoneHeld >= _UIManager._craftingTable.bloodstoneBoots.GetComponent<ArmorBehavior>()._bloodstoneNeeded)
            {
                _bloodstoneBootsButton.gameObject.SetActive(true);
            }
            else
            {
                _bloodstoneBootsButton.gameObject.SetActive(false);
            }
        }
        else if (_onChlorophyteTab)
        {
            //Sword
            if (_UIManager._player._chlorophyteHeld >= _UIManager._craftingTable.chlorophyteSword.GetComponent<WeaponBehavior>()._chlorophyteNeeded &&
                _UIManager._player._jungleWoodHeld >= _UIManager._craftingTable.chlorophyteSword.GetComponent<WeaponBehavior>()._jungleWoodNeeded)
            {
                _chlorophyteSwordButton.gameObject.SetActive(true);
            }
            else
            {
                _chlorophyteSwordButton.gameObject.SetActive(false);
            }
            //Pickaxe
            if (_UIManager._player._chlorophyteHeld >= _UIManager._craftingTable.chlorophytePickaxe.GetComponent<PickaxeBehavior>()._chlorophyteNeeded &&
                _UIManager._player._jungleWoodHeld >= _UIManager._craftingTable.chlorophytePickaxe.GetComponent<PickaxeBehavior>()._jungleWoodNeeded)
            {
                _chlorophytePickaxeButton.gameObject.SetActive(true);
            }
            else
            {
                _chlorophytePickaxeButton.gameObject.SetActive(false);
            }
            //Helmet
            if (_UIManager._player._chlorophyteHeld >= _UIManager._craftingTable.chlorophyteHelmet.GetComponent<ArmorBehavior>()._chlorophyteNeeded)
            {
                _chlorophyteHelmetButton.gameObject.SetActive(true);
            }
            else
            {
                _chlorophyteHelmetButton.gameObject.SetActive(false);
            }
            //Chestplate
            if (_UIManager._player._chlorophyteHeld >= _UIManager._craftingTable.chlorophyteChestplate.GetComponent<ArmorBehavior>()._chlorophyteNeeded)
            {
                _chlorophyteChestplateButton.gameObject.SetActive(true);
            }
            else
            {
                _chlorophyteChestplateButton.gameObject.SetActive(false);
            }
            //Leggings
            if (_UIManager._player._chlorophyteHeld >= _UIManager._craftingTable.chlorophyteLeggings.GetComponent<ArmorBehavior>()._chlorophyteNeeded)
            {
                _chlorophyteLeggingsButton.gameObject.SetActive(true);
            }
            else
            {
                _chlorophyteLeggingsButton.gameObject.SetActive(false);
            }
            //Boots
            if (_UIManager._player._chlorophyteHeld >= _UIManager._craftingTable.chlorophyteBoots.GetComponent<ArmorBehavior>()._chlorophyteNeeded)
            {
                _chlorophyteBootsButton.gameObject.SetActive(true);
            }
            else
            {
                _chlorophyteBootsButton.gameObject.SetActive(false);
            }
        }
        else if (_onMithrilTab)
        {
            //Sword
            if (_UIManager._player._mithrilHeld >= _UIManager._craftingTable.mithrilSword.GetComponent<WeaponBehavior>()._mithrilNeeded &&
                _UIManager._player._ashWoodHeld >= _UIManager._craftingTable.mithrilSword.GetComponent<WeaponBehavior>()._ashWoodNeeded)
            {
                _mithrilSwordButton.gameObject.SetActive(true);
            }
            else
            {
                _mithrilSwordButton.gameObject.SetActive(false);
            }
            //Pickaxe
            if (_UIManager._player._mithrilHeld >= _UIManager._craftingTable.mithrilPickaxe.GetComponent<PickaxeBehavior>()._mithrilNeeded &&
                _UIManager._player._ashWoodHeld >= _UIManager._craftingTable.mithrilPickaxe.GetComponent<PickaxeBehavior>()._ashWoodNeeded)
            {
                _mithrilPickaxeButton.gameObject.SetActive(true);
            }
            else
            {
                _mithrilPickaxeButton.gameObject.SetActive(false);
            }
            //Helmet
            if (_UIManager._player._mithrilHeld >= _UIManager._craftingTable.mithrilHelmet.GetComponent<ArmorBehavior>()._mithrilNeeded)
            {
                _mithrilHelmetButton.gameObject.SetActive(true);
            }
            else
            {
                _mithrilHelmetButton.gameObject.SetActive(false);
            }
            //Chestplate
            if (_UIManager._player._mithrilHeld >= _UIManager._craftingTable.mithrilChestplate.GetComponent<ArmorBehavior>()._mithrilNeeded)
            {
                _mithrilChestplateButton.gameObject.SetActive(true);
            }
            else
            {
                _mithrilChestplateButton.gameObject.SetActive(false);
            }
            //Leggings
            if (_UIManager._player._mithrilHeld >= _UIManager._craftingTable.mithrilLeggings.GetComponent<ArmorBehavior>()._mithrilNeeded)
            {
                _mithrilLeggingsButton.gameObject.SetActive(true);
            }
            else
            {
                _mithrilLeggingsButton.gameObject.SetActive(false);
            }
            //Boots
            if (_UIManager._player._mithrilHeld >= _UIManager._craftingTable.mithrilBoots.GetComponent<ArmorBehavior>()._mithrilNeeded)
            {
                _mithrilBootsButton.gameObject.SetActive(true);
            }
            else
            {
                _mithrilBootsButton.gameObject.SetActive(false);
            }
        }
    }

    private void ItemReqirements(string name)
    {

    }

    private void UpdateRequirements()
    {
        //Iron
        if(_onIronTab)
        {
            _ironPickaxeReqirements.text = ("Iron:" + _UIManager._craftingTable.ironPickaxe.GetComponent<PickaxeBehavior>()._ironNeeded +
            "|Oak Wood:" + _UIManager._craftingTable.ironPickaxe.GetComponent<PickaxeBehavior>()._oakWoodNeeded);

            _ironSwordReqirements.text = ("Iron:" + _UIManager._craftingTable.ironSword.GetComponent<WeaponBehavior>()._ironNeeded +
                "|Oak Wood:" + _UIManager._craftingTable.ironSword.GetComponent<WeaponBehavior>()._oakWoodNeeded);

            _ironChestplateReqirements.text = ("Iron:" + _UIManager._craftingTable.ironChestplate.GetComponent<ArmorBehavior>()._ironNeeded);

            _ironHelmetReqirements.text = ("Iron:" + _UIManager._craftingTable.ironHelmet.GetComponent<ArmorBehavior>()._ironNeeded);

            _ironLeggingsReqirements.text = ("Iron:" + _UIManager._craftingTable.ironLeggings.GetComponent<ArmorBehavior>()._ironNeeded);

            _ironBootsReqirements.text = ("Iron:" + _UIManager._craftingTable.ironBoots.GetComponent<ArmorBehavior>()._ironNeeded);
        }


        //Gold
        if(_onGoldTab)
        {
            _goldSwordReqirements.text = ("Gold:" + _UIManager._craftingTable.goldSword.GetComponent<WeaponBehavior>()._goldNeeded +
            "|Oak Wood:" + _UIManager._craftingTable.goldSword.GetComponent<WeaponBehavior>()._oakWoodNeeded);

            _goldPickaxeReqirements.text = ("Gold:" + _UIManager._craftingTable.goldPickaxe.GetComponent<PickaxeBehavior>()._goldNeeded +
                "|Oak Wood:" + _UIManager._craftingTable.goldPickaxe.GetComponent<PickaxeBehavior>()._oakWoodNeeded);

            _goldHelmetReqirements.text = ("Gold:" + _UIManager._craftingTable.goldHelmet.GetComponent<ArmorBehavior>()._goldNeeded);

            _goldChestplateReqirements.text = ("Gold:" + _UIManager._craftingTable.goldChestplate.GetComponent<ArmorBehavior>()._goldNeeded);

            _goldLeggingsReqirements.text = ("Gold:" + _UIManager._craftingTable.goldHelmet.GetComponent<ArmorBehavior>()._goldNeeded);

            _goldBootsReqirements.text = ("Gold:" + _UIManager._craftingTable.goldBoots.GetComponent<ArmorBehavior>()._goldNeeded);
        }

        //Silver
        if(_onSilverTab)
        {
            _silverHelmetReqirements.text = ("Silver:" + _UIManager._craftingTable.silverHelmet.GetComponent<ArmorBehavior>()._silverNeeded);

            _silverChestplateReqirements.text = ("Silver:" + _UIManager._craftingTable.silverChestplate.GetComponent<ArmorBehavior>()._silverNeeded);

            _silverLeggingsReqirements.text = ("Silver:" + _UIManager._craftingTable.silverHelmet.GetComponent<ArmorBehavior>()._silverNeeded);

            _silverBootsReqirements.text = ("Silver:" + _UIManager._craftingTable.silverBoots.GetComponent<ArmorBehavior>()._silverNeeded);

            _silverPickaxeReqirements.text = ("Silver:" + _UIManager._craftingTable.silverPickaxe.GetComponent<PickaxeBehavior>()._silverNeeded +
            "|Oak Wood:" + _UIManager._craftingTable.silverPickaxe.GetComponent<PickaxeBehavior>()._oakWoodNeeded);

            _silverSwordReqirements.text = ("Silver:" + _UIManager._craftingTable.silverSword.GetComponent<WeaponBehavior>()._silverNeeded +
            "|Oak Wood:" + _UIManager._craftingTable.silverSword.GetComponent<WeaponBehavior>()._oakWoodNeeded);
        }

        //Diamond
        if(_onDiamondTab)
        {
            _diamondSwordReqirements.text = ("Diamonds:" + _UIManager._craftingTable.diamondSword.GetComponent<WeaponBehavior>()._diamondsNeeded +
            "|Oak Wood:" + _UIManager._craftingTable.diamondSword.GetComponent<WeaponBehavior>()._oakWoodNeeded);

            _diamondPickaxeReqirements.text = ("Diamonds:" + _UIManager._craftingTable.diamondPickaxe.GetComponent<PickaxeBehavior>()._diamondsNeeded +
            "|Oak Wood:" + _UIManager._craftingTable.diamondPickaxe.GetComponent<PickaxeBehavior>()._oakWoodNeeded);

            _diamondHelmetReqirements.text = ("Diamonds:" + _UIManager._craftingTable.diamondHelmet.GetComponent<ArmorBehavior>()._diamondsNeeded);

            _diamondChestplateReqirements.text = ("Diamonds:" + _UIManager._craftingTable.diamondChestplate.GetComponent<ArmorBehavior>()._diamondsNeeded);

            _diamondLeggingsReqirements.text = ("Diamonds:" + _UIManager._craftingTable.diamondHelmet.GetComponent<ArmorBehavior>()._diamondsNeeded);

            _diamondBootsReqirements.text = ("Diamonds:" + _UIManager._craftingTable.diamondBoots.GetComponent<ArmorBehavior>()._diamondsNeeded);
        }

        //BloodStone
        if(_onBloodstoneTab)
        {
            _bloodstonePickaxeReqirements.text = ("Bloodstone:" + _UIManager._craftingTable.bloodstonePickaxe.GetComponent<PickaxeBehavior>()._bloodstoneNeeded +
            "|Oak Wood:" + _UIManager._craftingTable.bloodstonePickaxe.GetComponent<PickaxeBehavior>()._oakWoodNeeded);

            _bloodstoneSwordReqirements.text = ("Bloodstone:" + _UIManager._craftingTable.bloodstoneSword.GetComponent<WeaponBehavior>()._bloodstoneNeeded +
            "|Oak Wood:" + _UIManager._craftingTable.bloodstoneSword.GetComponent<WeaponBehavior>()._oakWoodNeeded);

            _bloodstoneHelmetReqirements.text = ("Bloodstone:" + _UIManager._craftingTable.bloodstoneHelmet.GetComponent<ArmorBehavior>()._bloodstoneNeeded);

            _bloodstoneChestplateReqirements.text = ("Bloodstone:" + _UIManager._craftingTable.bloodstoneChestplate.GetComponent<ArmorBehavior>()._bloodstoneNeeded);

            _bloodstoneBootsReqirements.text = ("Bloodstone:" + _UIManager._craftingTable.bloodstoneBoots.GetComponent<ArmorBehavior>()._bloodstoneNeeded);

            _bloodstoneLeggingsReqirements.text = ("Bloodstone:" + _UIManager._craftingTable.bloodstoneLeggings.GetComponent<ArmorBehavior>()._bloodstoneNeeded);
        }

        //Chlorophyte
        if(_onChlorophyteTab)
        {
            _chlorophytePickaxeReqirements.text = ("Chlorophyte:" + _UIManager._craftingTable.chlorophytePickaxe.GetComponent<PickaxeBehavior>()._chlorophyteNeeded +
            "|Jungle Wood:" + _UIManager._craftingTable.chlorophytePickaxe.GetComponent<PickaxeBehavior>()._jungleWoodNeeded);

            _chlorophyteSwordReqirements.text = ("Chlorophyte:" + _UIManager._craftingTable.chlorophyteSword.GetComponent<WeaponBehavior>()._chlorophyteNeeded +
            "|Jungle Wood:" + _UIManager._craftingTable.chlorophyteSword.GetComponent<WeaponBehavior>()._jungleWoodNeeded);

            _chlorophyteHelmetReqirements.text = ("Chlorophyte:" + _UIManager._craftingTable.chlorophyteHelmet.GetComponent<ArmorBehavior>()._chlorophyteNeeded);

            _chlorophyteChestplateReqirements.text = ("Chlorophyte:" + _UIManager._craftingTable.chlorophyteChestplate.GetComponent<ArmorBehavior>()._chlorophyteNeeded);

            _chlorophyteLeggingsReqirements.text = ("Chlorophyte:" + _UIManager._craftingTable.chlorophyteLeggings.GetComponent<ArmorBehavior>()._chlorophyteNeeded);

            _chlorophyteBootsReqirements.text = ("Chlorophyte:" + _UIManager._craftingTable.chlorophyteBoots.GetComponent<ArmorBehavior>()._chlorophyteNeeded);
        }

        //Mithril
        if(_onMithrilTab)
        {
            _mithrilSwordReqirements.text = ("Mithril:" + _UIManager._craftingTable.mithrilSword.GetComponent<WeaponBehavior>()._mithrilNeeded +
            "|Ash Wood:" + _UIManager._craftingTable.mithrilSword.GetComponent<WeaponBehavior>()._ashWoodNeeded);

            _mithrilPickaxeReqirements.text = ("Mithril:" + _UIManager._craftingTable.mithrilPickaxe.GetComponent<PickaxeBehavior>()._mithrilNeeded +
            "|Ash Wood:" + _UIManager._craftingTable.mithrilPickaxe.GetComponent<PickaxeBehavior>()._ashWoodNeeded);

            _mithrilHelmetReqirements.text = ("Mithril:" + _UIManager._craftingTable.mithrilHelmet.GetComponent<ArmorBehavior>()._mithrilNeeded);

            _mithrilChestplateReqirements.text = ("Mithril:" + _UIManager._craftingTable.mithrilChestplate.GetComponent<ArmorBehavior>()._mithrilNeeded);

            _mithrilLeggingsReqirements.text = ("Mithril:" + _UIManager._craftingTable.mithrilLeggings.GetComponent<ArmorBehavior>()._mithrilNeeded);

            _mithrilBootsReqirements.text = ("Mithril:" + _UIManager._craftingTable.mithrilBoots.GetComponent<ArmorBehavior>()._mithrilNeeded);
        }
    }
}
