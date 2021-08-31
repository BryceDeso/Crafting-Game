using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    [SerializeField]
    private float _health;
    public float _currentHealth;
    public float _armor;
    [SerializeField]
    private bool canBeHit = true;

    public ArmorBehavior _helmet;
    public ArmorBehavior _chestplate;
    public ArmorBehavior _leggings;
    public ArmorBehavior _boots;
    public WeaponBehavior _weapon;
    public PickaxeBehavior _pickaxe;

    public float _pickaxeDamage;
    public float _weaponDamage;

    [SerializeField]
    private bool _canEquipWeapon;
    [SerializeField]
    private bool _canEquipPickaxe;
    [SerializeField]
    private bool _canEquipHelmet;
    [SerializeField]
    private bool _canEquipChestplate;
    [SerializeField]
    private bool _canEquipLeggings;
    [SerializeField]
    private bool _canEquipBoots;

    [SerializeField]
    private GameObject _weaponAnchor;
    [SerializeField]
    private GameObject _pickaxeAnchor;
    [SerializeField]
    private GameObject _armorAnchor;
    [SerializeField]
    private GameObject _itemDropAnchor;

    [SerializeField]
    private PlayerHitBoxBehavior _hitbox;

    public InteractableFieldBehavior _interactionField;

    public float _ironHeld;
    public float _goldHeld;
    public float _silverHeld;
    public float _diamondsHeld;
    public float _bloodstoneHeld;
    public float _chlorophyteHeld;
    public float _mithrilHeld;
    public float _oakWoodHeld;
    public float _jungleWoodHeld;
    public float _ashWoodHeld;

    public float _invincibleTime;
    public float _timeLeft;

    // Start is called before the first frame update
    void Start()
    {
        _canEquipPickaxe = true;
        _canEquipWeapon = true;
        _canEquipHelmet = true;
        _canEquipChestplate = true;
        _canEquipLeggings = true;
        _canEquipBoots = true;
        _currentHealth = _health;
    }

    // Update is called once per frame
    private void Update()
    {
        PlayerActions();
    }

    private void PlayerActions()
    {
        TakeDamage();
        UnEquipTools();
        Interact();
        UpdateStats();
    }

    //private void CollectOre(float oreHeld, )

    private void TakeDamage()
    {
        if (_hitbox.isHit == true && canBeHit == true)
        {
            if (_hitbox.enemy.CompareTag("GroundEnemy"))
            {
                float damageTaken = _hitbox.enemy.GetComponent<GroundEnemyAIBehavior>().damage - _armor;
                _currentHealth -= damageTaken;
                canBeHit = false;
            }
        }

        if (canBeHit == false)
        {
            Timer();
        }
        if (_currentHealth <= 0)
        {
            _currentHealth = 0;
        }
    }

    private void UpdateStats()
    {
        float helmetArmor = 0;
        float chestplateArmor = 0;
        float leggingArmor = 0;
        float bootArmor = 0;

        if (_pickaxe)
        {
            _pickaxeDamage = _pickaxe.miningDamage;
        }
        else
        {
            _pickaxeDamage = 0;
        }

        if (_weapon)
        {
            _weaponDamage = _weapon.weaponDamage;
        }
        else
        {
            _weaponDamage = 0;
        }

        if(_helmet)
        {
            helmetArmor = _helmet.armorPoints;
        }

        if (_chestplate)
        {
            chestplateArmor = _chestplate.armorPoints;
        }

        if (_leggings)
        {
            leggingArmor = _leggings.armorPoints;
        }

        if (_boots)
        {
            bootArmor = _boots.armorPoints;
        }

        _armor = helmetArmor + chestplateArmor + leggingArmor + bootArmor;
    }

    private void Interact()
    {
        //Mining
        if (_interactionField.ore)
        {
            if (Input.GetButtonDown("Fire1") && _interactionField.ore.canCollect)
            {
                OreInteraction();
            }
        }
        //Fighting
        if (Input.GetButtonDown("Fire1") && _interactionField.groundEnemy)
        {
            _interactionField.groundEnemy.health -= _weapon.weaponDamage;
            Debug.Log("Hit ground enemy");
        }
        //Tool eqipping
        if (_canEquipWeapon)
        {
            if (Input.GetButtonDown("Fire1") && _interactionField.weapon)
            {
                _weapon = _interactionField.weapon;
                Debug.Log("Equipped " + _interactionField.weapon);
                _weapon.equipped = true;
                _weapon.transform.rotation = _weaponAnchor.transform.rotation;
                _weapon.transform.position = _weaponAnchor.transform.position;
                _weapon.gameObject.transform.parent = _weaponAnchor.transform;
                _canEquipWeapon = false;
            }
        }
        if (_canEquipPickaxe)
        {
            if (Input.GetButtonDown("Fire1") && _interactionField.pickaxe)
            {
                _pickaxe = _interactionField.pickaxe;
                Debug.Log("Equipped " + _interactionField.pickaxe);
                _pickaxe.equipped = true;
                _pickaxe.transform.rotation = _pickaxeAnchor.transform.rotation;
                _pickaxe.transform.position = _pickaxeAnchor.transform.position;
                _pickaxe.gameObject.transform.parent = _pickaxeAnchor.transform;
                _canEquipPickaxe = false;
            }
        }
        //Armor equipping
        if(_interactionField.armor)
        {
            if (_canEquipHelmet)
            {
                if (Input.GetButtonDown("Fire1") && _interactionField.armor._helmet)
                {
                    _helmet = _interactionField.armor;
                    Debug.Log("Equipped " + _interactionField.armor);
                    _helmet.equipped = true;
                    _helmet.transform.rotation = _armorAnchor.transform.rotation;
                    _helmet.transform.position = _armorAnchor.transform.position;
                    _helmet.gameObject.transform.parent = _armorAnchor.transform;
                    _canEquipHelmet = false;
                }
            }
            if (_canEquipChestplate)
            {
                if (Input.GetButtonDown("Fire1") && _interactionField.armor._chestplate)
                {
                    _chestplate = _interactionField.armor;
                    Debug.Log("Equipped " + _interactionField.armor);
                    _chestplate.equipped = true;
                    _chestplate.transform.rotation = _armorAnchor.transform.rotation;
                    _chestplate.transform.position = _armorAnchor.transform.position;
                    _chestplate.gameObject.transform.parent = _armorAnchor.transform;
                    _canEquipChestplate = false;
                }
            }
            if (_canEquipLeggings)
            {
                if (Input.GetButtonDown("Fire1") && _interactionField.armor._leggings)
                {
                    _leggings = _interactionField.armor;
                    Debug.Log("Equipped " + _interactionField.armor);
                    _leggings.equipped = true;
                    _leggings.transform.rotation = _armorAnchor.transform.rotation;
                    _leggings.transform.position = _armorAnchor.transform.position;
                    _leggings.gameObject.transform.parent = _armorAnchor.transform;
                    _canEquipLeggings = false;
                }
            }
            if (_canEquipBoots)
            {
                if (Input.GetButtonDown("Fire1") && _interactionField.armor._boots)
                {
                    _boots = _interactionField.armor;
                    Debug.Log("Equipped " + _interactionField.armor);
                    _boots.equipped = true;
                    _boots.transform.rotation = _armorAnchor.transform.rotation;
                    _boots.transform.position = _armorAnchor.transform.position;
                    _boots.gameObject.transform.parent = _armorAnchor.transform;
                    _canEquipBoots = false;
                }
            }
        }
    }

    private void UnEquipTools()
    {
        if(Input.GetKeyDown(KeyCode.Q) && _pickaxe)
        {
            _pickaxeDamage = 0;
            _pickaxe.transform.parent = null;
            _pickaxe.equipped = false;
            _canEquipPickaxe = true;
            _pickaxe = null;
        }
        if(Input.GetKeyDown(KeyCode.E) && _weapon)
        {
            _weapon.transform.parent = null;
            _weapon.equipped = false;
            _canEquipWeapon = true;
            _weapon = null;
        }
    }

    public void UnEquipHelmet()
    {
        _helmet.transform.position = _itemDropAnchor.transform.position;
        _helmet.transform.parent = null;
        _helmet.equipped = false;
        _canEquipHelmet = true;
        _helmet = null;
    }

    public void UnEquipChestplate()
    {
        _chestplate.transform.position = _itemDropAnchor.transform.position;
        _chestplate.transform.parent = null;
        _chestplate.equipped = false;
        _canEquipChestplate = true;
        _chestplate = null;
    }

    public void UnEquipLeggings()
    {
        _leggings.transform.position = _itemDropAnchor.transform.position;
        _leggings.transform.parent = null;
        _leggings.equipped = false;
        _canEquipLeggings = true;
        _leggings = null;
    }

    public void UnEquipBoots()
    {
        _boots.transform.position = _itemDropAnchor.transform.position;
        _boots.transform.parent = null;
        _boots.equipped = false;
        _canEquipBoots = true;
        _boots = null;
    }

    private void OreInteraction()
    {
        if (_interactionField.ore.CheckOreType() == 0)
        {
            if(_pickaxe.miningDamage > _interactionField.ore._defense)
            {
                if (_pickaxe.miningDamage <= _interactionField.ore.currentHealth)
                {
                    _ironHeld += _pickaxe.miningDamage;
                    _interactionField.ore.currentHealth -= _pickaxe.miningDamage;
                    Debug.Log("Hit ore");
                }
                else
                {
                    _ironHeld += _interactionField.ore.currentHealth;
                    _interactionField.ore.currentHealth -= _pickaxe.miningDamage;
                    Debug.Log("Hit ore");
                }
            }
        }
        else if (_interactionField.ore.CheckOreType() == 1)
        {
            if(_pickaxe.miningDamage > _interactionField.ore._defense)
            {
                if (_pickaxe.miningDamage <= _interactionField.ore.currentHealth)
                {
                    _silverHeld += _pickaxe.miningDamage;
                    _interactionField.ore.currentHealth -= _pickaxe.miningDamage;
                    Debug.Log("Hit ore");
                }
                else
                {
                    _silverHeld += _interactionField.ore.currentHealth;
                    _interactionField.ore.currentHealth -= _pickaxe.miningDamage;
                    Debug.Log("Hit ore");
                }
            }
        }
        else if (_interactionField.ore.CheckOreType() == 2)
        {
            if (_pickaxe.miningDamage > _interactionField.ore._defense)
            {
                if (_pickaxe.miningDamage <= _interactionField.ore.currentHealth)
                {
                    _goldHeld += _pickaxe.miningDamage;
                    _interactionField.ore.currentHealth -= _pickaxe.miningDamage;
                    Debug.Log("Hit ore");
                }
                else
                {
                    _goldHeld += _interactionField.ore.currentHealth;
                    _interactionField.ore.currentHealth -= _pickaxe.miningDamage;
                    Debug.Log("Hit ore");
                }
            }
        }
        else if (_interactionField.ore.CheckOreType() == 3)
        {
            if (_pickaxe.miningDamage > _interactionField.ore._defense)
            {
                if (_pickaxe.miningDamage <= _interactionField.ore.currentHealth)
                {
                    _diamondsHeld += _pickaxe.miningDamage;
                    _interactionField.ore.currentHealth -= _pickaxe.miningDamage;
                    Debug.Log("Hit ore");
                }
                else
                {
                    _diamondsHeld += _interactionField.ore.currentHealth;
                    _interactionField.ore.currentHealth -= _pickaxe.miningDamage;
                    Debug.Log("Hit ore");
                }
            }
        }
        else if (_interactionField.ore.CheckOreType() == 4)
        {
            if (_pickaxe.miningDamage > _interactionField.ore._defense)
            {
                if (_pickaxe.miningDamage <= _interactionField.ore.currentHealth)
                {
                    _bloodstoneHeld += _pickaxe.miningDamage;
                    _interactionField.ore.currentHealth -= _pickaxe.miningDamage;
                    Debug.Log("Hit ore");
                }
                else
                {
                    _bloodstoneHeld += _interactionField.ore.currentHealth;
                    _interactionField.ore.currentHealth -= _pickaxe.miningDamage;
                    Debug.Log("Hit ore");
                }
            }
        }
        else if (_interactionField.ore.CheckOreType() == 5)
        {
            if (_pickaxe.miningDamage > _interactionField.ore._defense)
            {
                if (_pickaxe.miningDamage <= _interactionField.ore.currentHealth)
                {
                    _chlorophyteHeld += _pickaxe.miningDamage;
                    _interactionField.ore.currentHealth -= _pickaxe.miningDamage;
                    Debug.Log("Hit ore");
                }
                else
                {
                    _chlorophyteHeld += _interactionField.ore.currentHealth;
                    _interactionField.ore.currentHealth -= _pickaxe.miningDamage;
                    Debug.Log("Hit ore");
                }
            }
        }
        else if (_interactionField.ore.CheckOreType() == 6)
        {
            if (_pickaxe.miningDamage > _interactionField.ore._defense)
            {
                if (_pickaxe.miningDamage <= _interactionField.ore.currentHealth)
                {
                    _mithrilHeld += _pickaxe.miningDamage;
                    _interactionField.ore.currentHealth -= _pickaxe.miningDamage;
                    Debug.Log("Hit ore");
                }
                else
                {
                    _mithrilHeld += _interactionField.ore.currentHealth;
                    _interactionField.ore.currentHealth -= _pickaxe.miningDamage;
                    Debug.Log("Hit ore");
                }
            }
        }
    }

    private void Timer()
    {
        _timeLeft -= Time.deltaTime;

        if (_timeLeft <= 0)
        {
            canBeHit = true;
            _timeLeft = _invincibleTime;
        }
    }

    //private float OreInteraction(int index)
    //{
    //    if (_interactionField.ore.CheckOreType() == index)
    //    {
    //        if (_pickaxe.miningDamage <= _interactionField.ore.currentHealth)
    //        {
    //            oreHeld += _pickaxe.miningDamage;
    //            _interactionField.ore.currentHealth -= _pickaxe.miningDamage;
    //            Debug.Log("Hit ore");
    //            return oreHeld;
    //        }
    //        else
    //        {
    //            oreHeld += _interactionField.ore.currentHealth;
    //            _interactionField.ore.currentHealth -= _pickaxe.miningDamage;
    //            Debug.Log("Hit ore");
    //            return oreHeld;
    //        }
    //    }
    //    return 0;
    //}
}