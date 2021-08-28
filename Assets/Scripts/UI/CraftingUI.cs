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
    private Text[] _swordReqirement;

    [SerializeField]
    private Text[] _pickaxesRequirement;

    [SerializeField]
    private Text[] _helmetRequirement;

    [SerializeField]
    private Text[] _chestplateRequirement;

    [SerializeField]
    private Text[] _leggingsRequirement;

    [SerializeField]
    private Text[] _bootsRequirement;

    [SerializeField]
    private bool _onIronTab = false;

    [SerializeField]
    private bool _onSilverTab = false;

    [SerializeField]
    private bool _onGoldTab = false;

    [SerializeField]
    private bool _onDiamondTab = false;

    [SerializeField]
    private bool _onBloodstoneTab = false;

    [SerializeField]
    private bool _onChlorophyteTab = false;

    [SerializeField]
    private bool _onMithrilTab = false;

    //Swords

    [SerializeField]
    private Button _ironSwordButton;

    [SerializeField]
    private Button _goldSwordButton;

    [SerializeField]
    private Button _silverSwordButton;

    [SerializeField]
    private Button _diamondSwordButton;

    [SerializeField]
    private Button _bloodstoneSwordButton;

    [SerializeField]
    private Button _chlorophyteSwordButton;

    [SerializeField]
    private Button _mithrilSwordButton;

    [SerializeField]
    private Button _ironPickaxeButton;

    [SerializeField]
    private Button _goldPickaxeButton;

    [SerializeField]
    private Button _silverPickaxeButton;

    [SerializeField]
    private Button _diamondPickaxeButton;

    [SerializeField]
    private Button _bloodstonePickaxeButton;

    [SerializeField]
    private Button _chlorophytePickaxeButton;

    [SerializeField]
    private Button _mithrilPickaxeButton;

    //Helmets
    [SerializeField]
    private Button _ironHelmetButton;

    [SerializeField]
    private Button _goldHelmetButton;

    [SerializeField]
    private Button _silverHelmetButton;

    [SerializeField]
    private Button _diamondHelmetButton;

    [SerializeField]
    private Button _bloodstoneHelmetButton;

    [SerializeField]
    private Button _chlorophyteHelmetButton;

    [SerializeField]
    private Button _mithrilHelmetButton;

    //Chestplates
    [SerializeField]
    private Button _ironChestplateButton;

    [SerializeField]
    private Button _goldChestplateButton;

    [SerializeField]
    private Button _silverChestplateButton;

    [SerializeField]
    private Button _diamondChestplateButton;

    [SerializeField]
    private Button _bloodstoneChestplateButton;

    [SerializeField]
    private Button _chlorophyteChestplateButton;

    [SerializeField]
    private Button _mithrilChestplateButton;

    //Leggings
    [SerializeField]
    private Button _ironLeggingsButton;

    [SerializeField]
    private Button _goldLeggingsButton;

    [SerializeField]
    private Button _silverLeggingsButton;

    [SerializeField]
    private Button _diamondLeggingsButton;

    [SerializeField]
    private Button _bloodstoneLeggingsButton;

    [SerializeField]
    private Button _chlorophyteLeggingsButton;

    [SerializeField]
    private Button _mithrilLeggingsButton;

    //Boots
    [SerializeField]
    private Button _ironBootsButton;

    [SerializeField]
    private Button _goldBootsButton;

    [SerializeField]
    private Button _silverBootsButton;

    [SerializeField]
    private Button _diamondBootsButton;

    [SerializeField]
    private Button _bloodstoneBootsButton;

    [SerializeField]
    private Button _chlorophyteBootsButton;

    [SerializeField]
    private Button _mithrilBootsButton;

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
        if (Input.GetButtonDown("Fire1") && _UIManager._player._interactionField.canCraft == true)
        {
            _updateCraftingUI = true;
            _craftingUI.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.lockState = CursorLockMode.Confined;
            _UIManager._player.GetComponent<PlayerMovmentBehavior>().canMove = false;
        }
        if (_updateCraftingUI)
        {
            updateCraftButtons();
            UpdateRequirements();
        }
    }

    private void ToggleRequirementText(int index, bool enable)
    {
        _pickaxesRequirement[index].gameObject.SetActive(enable);
        _swordReqirement[index].gameObject.SetActive(enable);
        _helmetRequirement[index].gameObject.SetActive(enable);
        _chestplateRequirement[index].gameObject.SetActive(enable);
        _leggingsRequirement[index].gameObject.SetActive(enable);
        _bootsRequirement[index].gameObject.SetActive(enable);
    }

    public void OnIronTab()
    {
        _onIronTab = true;
        _onSilverTab = false;
        _onGoldTab = false;
        _onDiamondTab = false;
        _onBloodstoneTab = false;
        _onChlorophyteTab = false;
        _onMithrilTab = false;
    }

    public void OnSilverTab()
    {
        _onIronTab = false;
        _onSilverTab = true;
        _onGoldTab = false;
        _onDiamondTab = false;
        _onBloodstoneTab = false;
        _onChlorophyteTab = false;
        _onMithrilTab = false;
    }

    public void OnGoldTab()
    {
        _onIronTab = false;
        _onSilverTab = false;
        _onGoldTab = true;
        _onDiamondTab = false;
        _onBloodstoneTab = false;
        _onChlorophyteTab = false;
        _onMithrilTab = false;
    }

    public void OnDiamondTab()
    {
        _onIronTab = false;
        _onSilverTab = false;
        _onGoldTab = false;
        _onDiamondTab = true;
        _onBloodstoneTab = false;
        _onChlorophyteTab = false;
        _onMithrilTab = false;
    }

    public void OnBloodStoneTab()
    {
        _onIronTab = false;
        _onSilverTab = false;
        _onGoldTab = false;
        _onDiamondTab = false;
        _onBloodstoneTab = true;
        _onChlorophyteTab = false;
        _onMithrilTab = false;
    }

    public void OnChlorophyteTab()
    {
        _onIronTab = false;
        _onSilverTab = false;
        _onGoldTab = false;
        _onDiamondTab = false;
        _onBloodstoneTab = false;
        _onChlorophyteTab = true;
        _onMithrilTab = false;
    }

    public void OnMithrilTab()
    {
        _onIronTab = false;
        _onSilverTab = false;
        _onGoldTab = false;
        _onDiamondTab = false;
        _onBloodstoneTab = false;
        _onChlorophyteTab = false;
        _onMithrilTab = true;
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

    private void UpdateRequirements()
    {
        //Iron
        if (_onIronTab)
        {
            ToggleRequirementText(0, true);

            _pickaxesRequirement[0].text = ("Iron:" + _UIManager._craftingTable.ironPickaxe.GetComponent<PickaxeBehavior>()._ironNeeded +
            "|Oak Wood:" + _UIManager._craftingTable.ironPickaxe.GetComponent<PickaxeBehavior>()._oakWoodNeeded);

            _swordReqirement[0].text = ("Iron:" + _UIManager._craftingTable.ironSword.GetComponent<WeaponBehavior>()._ironNeeded +
                "|Oak Wood:" + _UIManager._craftingTable.ironSword.GetComponent<WeaponBehavior>()._oakWoodNeeded);

            _helmetRequirement[0].text = ("Iron:" + _UIManager._craftingTable.ironHelmet.GetComponent<ArmorBehavior>()._ironNeeded);

            _chestplateRequirement[0].text = ("Iron:" + _UIManager._craftingTable.ironChestplate.GetComponent<ArmorBehavior>()._ironNeeded);

            _leggingsRequirement[0].text = ("Iron:" + _UIManager._craftingTable.ironLeggings.GetComponent<ArmorBehavior>()._ironNeeded);

            _bootsRequirement[0].text = ("Iron:" + _UIManager._craftingTable.ironBoots.GetComponent<ArmorBehavior>()._ironNeeded);
        }
        else
        {
            ToggleRequirementText(0, false);
        }

        //Silver
        if(_onSilverTab)
        {
            ToggleRequirementText(1, true);

            _pickaxesRequirement[1].text = ("Silver:" + _UIManager._craftingTable.silverPickaxe.GetComponent<PickaxeBehavior>()._silverNeeded +
            "|Oak Wood:" + _UIManager._craftingTable.silverPickaxe.GetComponent<PickaxeBehavior>()._oakWoodNeeded);

            _swordReqirement[1].text = ("Silver:" + _UIManager._craftingTable.silverSword.GetComponent<WeaponBehavior>()._silverNeeded +
            "|Oak Wood:" + _UIManager._craftingTable.silverSword.GetComponent<WeaponBehavior>()._oakWoodNeeded);

            _helmetRequirement[1].text = ("Silver:" + _UIManager._craftingTable.silverHelmet.GetComponent<ArmorBehavior>()._silverNeeded);

            _chestplateRequirement[1].text = ("Silver:" + _UIManager._craftingTable.silverChestplate.GetComponent<ArmorBehavior>()._silverNeeded);

            _leggingsRequirement[1].text = ("Silver:" + _UIManager._craftingTable.silverHelmet.GetComponent<ArmorBehavior>()._silverNeeded);

            _bootsRequirement[1].text = ("Silver:" + _UIManager._craftingTable.silverBoots.GetComponent<ArmorBehavior>()._silverNeeded);
        }
        else
        {
            ToggleRequirementText(1, false);
        }

        //Gold
        if (_onGoldTab)
        {
            ToggleRequirementText(2, true);

            _pickaxesRequirement[2].text = ("Gold:" + _UIManager._craftingTable.goldSword.GetComponent<WeaponBehavior>()._goldNeeded +
            "|Oak Wood:" + _UIManager._craftingTable.goldSword.GetComponent<WeaponBehavior>()._oakWoodNeeded);

            _swordReqirement[2].text = ("Gold:" + _UIManager._craftingTable.goldPickaxe.GetComponent<PickaxeBehavior>()._goldNeeded +
                "|Oak Wood:" + _UIManager._craftingTable.goldPickaxe.GetComponent<PickaxeBehavior>()._oakWoodNeeded);

            _helmetRequirement[2].text = ("Gold:" + _UIManager._craftingTable.goldHelmet.GetComponent<ArmorBehavior>()._goldNeeded);

            _chestplateRequirement[2].text = ("Gold:" + _UIManager._craftingTable.goldChestplate.GetComponent<ArmorBehavior>()._goldNeeded);

            _leggingsRequirement[2].text = ("Gold:" + _UIManager._craftingTable.goldHelmet.GetComponent<ArmorBehavior>()._goldNeeded);

            _bootsRequirement[2].text = ("Gold:" + _UIManager._craftingTable.goldBoots.GetComponent<ArmorBehavior>()._goldNeeded);
        }
        else
        {
            ToggleRequirementText(2, false);
        }

        //Diamond
        if(_onDiamondTab)
        {
            ToggleRequirementText(3, true);

            _pickaxesRequirement[3].text = ("Diamonds:" + _UIManager._craftingTable.diamondSword.GetComponent<WeaponBehavior>()._diamondsNeeded +
            "|Oak Wood:" + _UIManager._craftingTable.diamondSword.GetComponent<WeaponBehavior>()._oakWoodNeeded);

            _swordReqirement[3].text = ("Diamonds:" + _UIManager._craftingTable.diamondPickaxe.GetComponent<PickaxeBehavior>()._diamondsNeeded +
            "|Oak Wood:" + _UIManager._craftingTable.diamondPickaxe.GetComponent<PickaxeBehavior>()._oakWoodNeeded);

            _helmetRequirement[3].text = ("Diamonds:" + _UIManager._craftingTable.diamondHelmet.GetComponent<ArmorBehavior>()._diamondsNeeded);

            _chestplateRequirement[3].text = ("Diamonds:" + _UIManager._craftingTable.diamondChestplate.GetComponent<ArmorBehavior>()._diamondsNeeded);

            _leggingsRequirement[3].text = ("Diamonds:" + _UIManager._craftingTable.diamondHelmet.GetComponent<ArmorBehavior>()._diamondsNeeded);

            _bootsRequirement[3].text = ("Diamonds:" + _UIManager._craftingTable.diamondBoots.GetComponent<ArmorBehavior>()._diamondsNeeded);
        }
        else
        {
            ToggleRequirementText(3, false);
        }

        //BloodStone
        if(_onBloodstoneTab)
        {
            ToggleRequirementText(4, true);

            _pickaxesRequirement[4].text = ("Bloodstone:" + _UIManager._craftingTable.bloodstonePickaxe.GetComponent<PickaxeBehavior>()._bloodstoneNeeded +
            "|Oak Wood:" + _UIManager._craftingTable.bloodstonePickaxe.GetComponent<PickaxeBehavior>()._oakWoodNeeded);

            _swordReqirement[4].text = ("Bloodstone:" + _UIManager._craftingTable.bloodstoneSword.GetComponent<WeaponBehavior>()._bloodstoneNeeded +
            "|Oak Wood:" + _UIManager._craftingTable.bloodstoneSword.GetComponent<WeaponBehavior>()._oakWoodNeeded);

            _helmetRequirement[4].text = ("Bloodstone:" + _UIManager._craftingTable.bloodstoneHelmet.GetComponent<ArmorBehavior>()._bloodstoneNeeded);

            _chestplateRequirement[4].text = ("Bloodstone:" + _UIManager._craftingTable.bloodstoneChestplate.GetComponent<ArmorBehavior>()._bloodstoneNeeded);

            _leggingsRequirement[4].text = ("Bloodstone:" + _UIManager._craftingTable.bloodstoneBoots.GetComponent<ArmorBehavior>()._bloodstoneNeeded);

            _bootsRequirement[4].text = ("Bloodstone:" + _UIManager._craftingTable.bloodstoneLeggings.GetComponent<ArmorBehavior>()._bloodstoneNeeded);
        }
        else
        {
            ToggleRequirementText(4, false);
        }

        //Chlorophyte
        if(_onChlorophyteTab)
        {
            ToggleRequirementText(5, true);

            _pickaxesRequirement[5].text = ("Chlorophyte:" + _UIManager._craftingTable.chlorophytePickaxe.GetComponent<PickaxeBehavior>()._chlorophyteNeeded +
            "|Jungle Wood:" + _UIManager._craftingTable.chlorophytePickaxe.GetComponent<PickaxeBehavior>()._jungleWoodNeeded);

            _swordReqirement[5].text = ("Chlorophyte:" + _UIManager._craftingTable.chlorophyteSword.GetComponent<WeaponBehavior>()._chlorophyteNeeded +
            "|Jungle Wood:" + _UIManager._craftingTable.chlorophyteSword.GetComponent<WeaponBehavior>()._jungleWoodNeeded);

            _helmetRequirement[5].text = ("Chlorophyte:" + _UIManager._craftingTable.chlorophyteHelmet.GetComponent<ArmorBehavior>()._chlorophyteNeeded);

            _chestplateRequirement[5].text = ("Chlorophyte:" + _UIManager._craftingTable.chlorophyteChestplate.GetComponent<ArmorBehavior>()._chlorophyteNeeded);

            _leggingsRequirement[5].text = ("Chlorophyte:" + _UIManager._craftingTable.chlorophyteLeggings.GetComponent<ArmorBehavior>()._chlorophyteNeeded);

            _bootsRequirement[5].text = ("Chlorophyte:" + _UIManager._craftingTable.chlorophyteBoots.GetComponent<ArmorBehavior>()._chlorophyteNeeded);
        }
        else
        {
            ToggleRequirementText(5, false);
        }

        //Mithril
        if(_onMithrilTab)
        {
            ToggleRequirementText(6, true);

            _pickaxesRequirement[6].text = ("Mithril:" + _UIManager._craftingTable.mithrilSword.GetComponent<WeaponBehavior>()._mithrilNeeded +
            "|Ash Wood:" + _UIManager._craftingTable.mithrilSword.GetComponent<WeaponBehavior>()._ashWoodNeeded);

            _swordReqirement[6].text = ("Mithril:" + _UIManager._craftingTable.mithrilPickaxe.GetComponent<PickaxeBehavior>()._mithrilNeeded +
            "|Ash Wood:" + _UIManager._craftingTable.mithrilPickaxe.GetComponent<PickaxeBehavior>()._ashWoodNeeded);

            _helmetRequirement[6].text = ("Mithril:" + _UIManager._craftingTable.mithrilHelmet.GetComponent<ArmorBehavior>()._mithrilNeeded);

            _chestplateRequirement[6].text = ("Mithril:" + _UIManager._craftingTable.mithrilChestplate.GetComponent<ArmorBehavior>()._mithrilNeeded);

            _leggingsRequirement[6].text = ("Mithril:" + _UIManager._craftingTable.mithrilLeggings.GetComponent<ArmorBehavior>()._mithrilNeeded);

            _bootsRequirement[6].text = ("Mithril:" + _UIManager._craftingTable.mithrilBoots.GetComponent<ArmorBehavior>()._mithrilNeeded);
        }
        else
        {
            ToggleRequirementText(6, false);
        }
    }
}